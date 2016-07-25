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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.TextField
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.TextField;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/TextField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.TextField.TextFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n<!-- InputCssClass class variable -->\r\n\r\n");

            
            #line 12 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
   var inputCssClass = "";
   HashSet<TextType> availableOptions = new HashSet<TextType>() { TextType.Text, TextType.Password, TextType.Date, TextType.DateTimeLocal, TextType.Month, TextType.Time,
   TextType.Week, TextType.Number, TextType.Email,TextType.Url, TextType.Tel, TextType.Color };

   if (availableOptions.Contains(Model.InputType))
   {
       inputCssClass = "form-control";
   }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 845), Tuple.Create("\"", 879)
            
            #line 23 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 853), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 853), false)
, Tuple.Create(Tuple.Create(" ", 868), Tuple.Create("form-group", 869), true)
);

WriteLiteral(" data-sf-role=\"text-field-container\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" data-sf-role=\"violation-restrictions\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 981), Tuple.Create("\'", 1094)
, Tuple.Create(Tuple.Create("", 989), Tuple.Create("{\"maxLength\":\"", 989), true)
            
            #line 24 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
    , Tuple.Create(Tuple.Create("", 1003), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MaxLength
            
            #line default
            #line hidden
, 1003), false)
, Tuple.Create(Tuple.Create("", 1039), Tuple.Create("\",", 1039), true)
, Tuple.Create(Tuple.Create(" ", 1041), Tuple.Create("\"minLength\":", 1042), true)
, Tuple.Create(Tuple.Create(" ", 1054), Tuple.Create("\"", 1055), true)
            
            #line 24 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
                                                         , Tuple.Create(Tuple.Create("", 1056), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MinLength
            
            #line default
            #line hidden
, 1056), false)
, Tuple.Create(Tuple.Create("", 1092), Tuple.Create("\"}", 1092), true)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1158), Tuple.Create("\'", 1438)
, Tuple.Create(Tuple.Create("", 1166), Tuple.Create("{\"maxLength\":\"", 1166), true)
            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1180), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MaxLengthViolationMessage
            
            #line default
            #line hidden
, 1180), false)
, Tuple.Create(Tuple.Create("", 1232), Tuple.Create("\",", 1232), true)
, Tuple.Create(Tuple.Create(" ", 1234), Tuple.Create("\"required\":", 1235), true)
, Tuple.Create(Tuple.Create(" ", 1246), Tuple.Create("\"", 1247), true)
            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
                                                                    , Tuple.Create(Tuple.Create("", 1248), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RequiredViolationMessage
            
            #line default
            #line hidden
, 1248), false)
, Tuple.Create(Tuple.Create("", 1299), Tuple.Create("\",", 1299), true)
, Tuple.Create(Tuple.Create(" ", 1301), Tuple.Create("\"invalid\":", 1302), true)
, Tuple.Create(Tuple.Create(" ", 1312), Tuple.Create("\"", 1313), true)
            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                      , Tuple.Create(Tuple.Create("", 1314), Tuple.Create<System.Object, System.Int32>(Html.Resource("InvalidEntryMessage")
            
            #line default
            #line hidden
, 1314), false)
, Tuple.Create(Tuple.Create("", 1351), Tuple.Create("\",", 1351), true)
, Tuple.Create(Tuple.Create(" ", 1353), Tuple.Create("\"regularExpression\":", 1354), true)
, Tuple.Create(Tuple.Create(" ", 1374), Tuple.Create("\"", 1375), true)
            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1376), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RegularExpressionViolationMessage
            
            #line default
            #line hidden
, 1376), false)
, Tuple.Create(Tuple.Create("", 1436), Tuple.Create("\"}", 1436), true)
);

WriteLiteral(" />\r\n\r\n    <label");

WriteAttribute("for", Tuple.Create(" for=\'", 1456), Tuple.Create("\'", 1487)
            
            #line 27 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1462), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 1462), false)
);

WriteLiteral(">");

            
            #line 27 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
                                      Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n    <input");

WriteAttribute("id", Tuple.Create(" id=\'", 1531), Tuple.Create("\'", 1561)
            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1536), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 1536), false)
);

WriteLiteral(" data-sf-role=\"text-field-input\"");

WriteAttribute("type", Tuple.Create(" type=\"", 1594), Tuple.Create("\"", 1635)
            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1601), Tuple.Create<System.Object, System.Int32>(Model.InputType.ToHtmlInputType()
            
            #line default
            #line hidden
, 1601), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 1636), Tuple.Create("\"", 1669)
            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
                                          , Tuple.Create(Tuple.Create("", 1643), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 1643), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 1670), Tuple.Create("\"", 1706)
            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
                                                                                   , Tuple.Create(Tuple.Create("", 1684), Tuple.Create<System.Object, System.Int32>(Model.PlaceholderText
            
            #line default
            #line hidden
, 1684), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1707), Tuple.Create("\"", 1727)
            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                  , Tuple.Create(Tuple.Create("", 1715), Tuple.Create<System.Object, System.Int32>(Model.Value
            
            #line default
            #line hidden
, 1715), false)
);

WriteLiteral(" ");

            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                                                                                           Write(Model.ValidationAttributes);

            
            #line default
            #line hidden
WriteLiteral(" class=\"");

            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                                                                                                                              Write(inputCssClass);

            
            #line default
            #line hidden
WriteLiteral("\"></input>\r\n");

            
            #line 29 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
     
            
            #line default
            #line hidden
            
            #line 29 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
      if (!string.IsNullOrEmpty(Model.MetaField.Description)) 
     {

            
            #line default
            #line hidden
WriteLiteral("         <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 31 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
                          Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 32 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
     }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

            
            #line 35 "..\..\ResourcePackages\Bootstrap\MVC\Views\TextField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/TextField/text-field.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
