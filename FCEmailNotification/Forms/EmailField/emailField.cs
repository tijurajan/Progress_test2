﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Sitefinity.Data.Metadata;
using Telerik.Sitefinity.Metadata.Model;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.Modules.Forms.Web.UI.Fields;
using Telerik.Sitefinity.Security;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Web.UI.ControlDesign;
using Telerik.Sitefinity.Web.UI.Fields;
using Telerik.Sitefinity.Web.UI.Fields.Enums;

namespace SitefinityWebApp.Forms.EmailField
{
    /// <summary>
    /// Class used to create custom control for Form Builder

    [DatabaseMapping(UserFriendlyDataType.ShortText)]
    [PropertyEditorTitle("emailField Properties")]
    [ControlDesigner(typeof(Designer.emailFieldDesigner))]
    public class emailField : FieldControl, IFormFieldControl
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the emailField class.
        /// </summary>
        public emailField()
        {
            this.Title = "Email";
            this.Example = "john.smith@gmail.com";
        }
        #endregion

        #region Public properties (will show up in dialog)
        /// <summary>
        /// Example string
        /// </summary>
        public override string Example { get; set; }

        /// <summary>
        /// Title string
        /// </summary>
        public override string Title { get; set; }

        /// <summary>
        /// Description string
        /// </summary>
        public override string Description { get; set; }
        #endregion

        #region IFormFieldControl members
        /// <summary>
        /// Gets or sets MetaField property to persist data from control to the DB when form is submitted
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public IMetaField MetaField
        {
            get
            {
                if (this.metaField == null)
                {
                    this.metaField = this.LoadDefaultMetaField();
                }

                return this.metaField;
            }
            set
            {
                this.metaField = value;
            }
        }
        #endregion

        #region Value method
        /// <summary>
        /// Get and set the value of the field. 
        /// </summary>
        public override object Value
        {
            get
            {
                
                return this.ToAddresses.Text;
            }

            set
            {
                this.ToAddresses.Text = value.ToString();
            }
        }
        #endregion

        #region Template
        /// <summary>
        /// Obsolete. Use LayoutTemplatePath instead.
        /// </summary>
        protected override string LayoutTemplateName
        {
            get
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the layout template's relative or virtual path.
        /// </summary>
        public override string LayoutTemplatePath
        {
            get
            {
                if (string.IsNullOrEmpty(base.LayoutTemplatePath))
                    return emailField.layoutTemplatePath;
                return base.LayoutTemplatePath;
            }
            set
            {
                base.LayoutTemplatePath = value;
            }
        }
        #endregion

        #region Labels on control template
        /// <summary>
        /// Gets reference to the TitleLabel
        /// </summary>
        protected internal virtual Label TitleLabel
        {
            get
            {
                return this.Container.GetControl<Label>("titleLabel", true);
            }
        }

        /// <summary>
        /// Gets reference to the DescriptionLabel
        /// </summary>
        protected internal virtual Label DescriptionLabel
        {
            get
            {
                return Container.GetControl<Label>("descriptionLabel", true);
            }
        }

        /// <summary>
        /// Gets reference to the ExampleLabel
        /// </summary>
        protected internal virtual Label ExampleLabel
        {
            get
            {
                return this.Container.GetControl<Label>("exampleLabel", this.DisplayMode == FieldDisplayMode.Write);
            }
        }

        /// <summary>
        /// Reference to the TitleControl
        /// </summary>
        protected override WebControl TitleControl
        {
            get
            {
                return this.TitleLabel;
            }
        }

        /// <summary>
        /// Reference to the DescriptionControl
        /// </summary>
        protected override WebControl DescriptionControl
        {
            get
            {
                return this.DescriptionLabel;
            }
        }

        /// <summary>
        /// Gets the reference to the control that represents the example of the field control.
        /// Return null if no such control exists in the template.
        /// </summary>
        /// <value></value>
        protected override WebControl ExampleControl
        {
            get
            {
                return this.ExampleLabel;
            }
        }
        #endregion

        #region Textbox on control
        /// <summary>
        /// Gets reference to the ToAddresses control
        /// </summary>
        protected virtual TextBox ToAddresses
        {
            get
            {
                return this.Container.GetControl<TextBox>("ToAddresses", true);
            }
        }
        #endregion

        #region InitializeControls method
        /// <summary>
        /// Initializes the controls.
        /// </summary>
        /// <remarks>
        /// Initialize your controls in this method. Do not override CreateChildControls method.
        /// </remarks>
        protected override void InitializeControls(GenericContainer container)
        {
            // Set the label values
            this.ExampleLabel.Text = this.Example;
            this.TitleLabel.Text = this.Title;
            this.DescriptionLabel.Text = this.Description;

            this.ToAddresses.Text = "";
        }
        #endregion

        #region Get Current User
        /// <summary>
        /// Get the full name for the currently logged-in Sitefinity user.
        /// </summary>
        /// <returns>String with full name of current user, or empty string if user not logged in.</returns>
        private static string GetCurrentSitefinityUser()
        {
            Telerik.Sitefinity.Security.Web.UI.ProfileView pv = new Telerik.Sitefinity.Security.Web.UI.ProfileView();
            Guid currentUserGuid = pv.CurrentUser.UserId;

            if (currentUserGuid != Guid.Empty)
            {
                var userProfile = UserProfileManager.GetManager().GetUserProfiles(currentUserGuid).FirstOrDefault() as Telerik.Sitefinity.Security.Model.SitefinityProfile;
                if (userProfile != null)
                {
                    return userProfile.FirstName + " " + userProfile.LastName;
                }
            }
            return String.Empty;
        }
        #endregion

        #region Script methods
        /// <summary>
        /// Get list of all scripts used by control
        /// </summary>
        /// <returns>List of all scripts used by control</returns>



        public override IEnumerable<ScriptDescriptor> GetScriptDescriptors()
        {
            var descriptor = new ScriptControlDescriptor(typeof(emailField).FullName, this.ClientID);
            descriptor.AddElementProperty("textbox", this.ToAddresses.ClientID);
            descriptor.AddProperty("dataFieldName", this.MetaField.FieldName); //the field name of the corresponding widget
            return new[] { descriptor };
        }

        /// <summary>
        /// Get reference to all scripts
        /// </summary>
        /// <returns>Reference to all scripts</returns>
        public override IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences()
        {
            var scripts = new List<ScriptReference>(base.GetScriptReferences())
            {
                new ScriptReference(emailField.scriptReference),
                new ScriptReference("Telerik.Sitefinity.Web.UI.Fields.Scripts.FieldDisplayMode.js", "Telerik.Sitefinity"),
            };
            return scripts;
        }
        #endregion

        #region Private fields and constants
        private IMetaField metaField = null;
        public static readonly string layoutTemplatePath = "~/Forms/EmailField/emailField.ascx";
        public const string scriptReference = "~/Forms/EmailField/emailField.js";
        #endregion
    }
   

}