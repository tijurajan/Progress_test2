#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.UnsubscribeForm
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/UnsubscribeForm/UnsubscribeFormByEmailAddr" +
        "ess.UnsubscribeForm.cshtml")]
    public partial class UnsubscribeFormByEmailAddress_UnsubscribeForm : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.EmailCampaigns.Mvc.Models.UnsubscribeForm.UnsubscribeFormViewModel>
    {
        public UnsubscribeFormByEmailAddress_UnsubscribeForm()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js", "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 11 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 553), Tuple.Create("\"", 576)
            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
, Tuple.Create(Tuple.Create("", 561), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 561), false)
);

WriteLiteral(">    \r\n");

            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
	
            
            #line default
            #line hidden
            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
     using (Html.BeginFormSitefinity())
	{	

            
            #line default
            #line hidden
WriteLiteral("\t\t<h3>");

            
            #line 16 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
       Write(Model.WidgetTitle);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 17 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
		

            
            #line default
            #line hidden
WriteLiteral("\t\t<p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 18 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
                         Write(Model.WidgetDescription);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 19 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
		
		if (ViewBag.IsSucceded == true)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(">");

            
            #line 22 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
                                        Write(Html.Raw(Model.Message));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 23 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
		}
		
		
            
            #line default
            #line hidden
            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
   Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
                                     
		
		if (!string.IsNullOrEmpty(ViewBag.Error))
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 30 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
           Write(ViewBag.Error);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t</div>\r\n");

            
            #line 32 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
		}
		

            
            #line default
            #line hidden
WriteLiteral("\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n\t\t\t<label>\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 36 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
           Write(Html.Resource("Email"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t</label>\r\n\r\n\t\t\t<div");

WriteLiteral(" class=\"form-inline\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 41 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
           Write(Html.TextBoxFor(u => u.Email, new { @class = "form-control", type = "email" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\t\t\t\t<button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 43 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
                                                         Write(Html.Resource("ButtonUnsubscribe"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\t\r\n\t\t\t</div>\r\n\r\n");

            
            #line 47 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
			
            
            #line default
            #line hidden
            
            #line 47 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
             if (Html.ValidationMessageFor(u => u.Email) != null)
			{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<div");

WriteLiteral(" class=\"has-error\"");

WriteLiteral(">\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 50 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
                                        Write(Html.ValidationMessageFor(u => u.Email));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t\t\t</div>\r\n");

            
            #line 52 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t</div>\t\t\r\n");

            
            #line 55 "..\..\ResourcePackages\Bootstrap\MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
	}

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
