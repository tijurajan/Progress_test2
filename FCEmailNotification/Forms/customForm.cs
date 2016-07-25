using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using Telerik.Microsoft.Practices.EnterpriseLibrary.Logging;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Forms.Model;
using Telerik.Sitefinity.Modules.Forms;
using Telerik.Sitefinity.Modules.Forms.Web.UI;
using Telerik.Sitefinity.Services;
using Telerik.Sitefinity.Web.UI.Fields;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Web.Mail;
using Telerik.Sitefinity.Modules.Forms.Events;


namespace SitefinityWebApp.Forms
{

    public class customForm : FormsControl
    {
        protected override void InitializeControls(GenericContainer container)
        {
            base.InitializeControls(container);
            EventHub.Subscribe<IFormEntryCreatedEvent>(evt => FormsEventHandler(evt));;
            }


        private void FormsEventHandler(IFormEntryCreatedEvent eventInfo)
        {
                 
            var ipAddress = eventInfo.IpAddress;
            var submissionTime = eventInfo.SubmissionTime;
                     
          //  var formSubscriptionListId = eventInfo.FormSubscriptionListId;
            var controls = eventInfo.Controls;

            var mailServer = new SmtpClient();
            MailMessage message = new MailMessage();
           



            var smtpSettings = Config.Get<SystemConfig>().SmtpSettings;
            if (!smtpSettings.Host.IsNullOrWhitespace())
            {
                mailServer.Host = smtpSettings.Host;
                mailServer.Port = smtpSettings.Port;
                mailServer.EnableSsl = smtpSettings.EnableSSL;
                
                mailServer.Timeout = smtpSettings.Timeout;

                if (!string.IsNullOrEmpty(smtpSettings.UserName))
                {
                    mailServer.UseDefaultCredentials = false;
                    mailServer.Credentials = new NetworkCredential(smtpSettings.UserName, smtpSettings.Password);
                }
            }

            var email = from con in controls where con.FieldName == "emailField" select con;
            //message.From = new MailAddress(smtpSettings.DefaultSenderEmailAddress);
           
            StringBuilder sb = new StringBuilder();
           
            
            message.From=   new MailAddress(smtpSettings.DefaultSenderEmailAddress.ToString());
            string fName = "";
            string mName = "";
            string lName = "";
            string toAddr = "";
            string userType = "";
            string org = "";

            foreach (var item in controls)
            {

                if (item.Type == FormEntryEventControlType.SectionHeader)
                {
                    message.Subject = item.Title.ToString();
                }
                
                else if (item.Type == FormEntryEventControlType.FieldControl)
                {
                    if (item.FieldName == "fName_TextBox")
                    {
                        
                        fName = item.Value.ToString();
                    }
                    else if (item.FieldName == "mNameTextBox")
                    {
                        mName = item.Value.ToString();
                    }
                    else if (item.FieldName == "lNameTextBox")
                    {
                        lName = item.Value.ToString();
                    }
                    
                    else if (item.FieldName == "emailField")
                    {
                        toAddr = item.Value.ToString();
                        message.To.Add(new MailAddress(toAddr));
                    }
                    else if (item.FieldName == "userTypeMultipleChoice")
                    {
                        userType = item.Value.ToString();
                    }
                    else if (item.FieldName == "organizationTextBox")
                    {
                        org = item.Value.ToString();
                    }
                }
                   
                

            }
            sb.AppendFormat("Dear <b>{0}</b>,<br>",fName);
           
            sb.AppendFormat("<p>Your user registration process has been completed successfully!<p><br>");
            
            sb.AppendFormat("<p>Please verify the details below,<p>");
            sb.AppendFormat("<ul><li><b>Name :</b> {0} {1} {2} (User Type : {3}).</li>", fName,lName,mName,userType);
            
            sb.AppendFormat("<li><b>Organization : </b> {0}.</li>", org);
            sb.AppendFormat("<li><b>Time of submission :</b> {0} (IP address: {1})</li></ul>", submissionTime, ipAddress);
            sb.AppendFormat("Thanks,<br>");
            sb.AppendLine("<b>Telerik Sitefinity Test</b>");

            message.Body = sb.ToString();
            
            message.IsBodyHtml = true;
          
            message.BodyEncoding = Encoding.Unicode;
            message.SubjectEncoding = Encoding.Unicode;
            //send the notification
            try
            {
               

                    mailServer.Send(message);
                           

            }
            catch (Exception ex)
            {
                
                    var logEntry = new LogEntry();
                    logEntry.Categories.Add("ErrorLog");
                    logEntry.Message = ex.ToString();
                    logEntry.Title = "Email on form submission failed";

                    Logger.Writer.Write(logEntry);              

                
            }
           
        }


    }
}