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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Card
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Card/Card.cshtml")]
    public partial class Card : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Card.Mvc.Models.Card.CardViewModel>
    {
        public Card()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteAttribute("class", Tuple.Create(" class=\"", 77), Tuple.Create("\"", 110)
, Tuple.Create(Tuple.Create("", 85), Tuple.Create("thumbnail", 85), true)
            
            #line 3 "..\..MVC\Views\Card\Card.cshtml"
, Tuple.Create(Tuple.Create(" ", 94), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 95), false)
);

WriteLiteral(">\r\n    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 122), Tuple.Create("\"", 150)
            
            #line 4 "..\..MVC\Views\Card\Card.cshtml"
, Tuple.Create(Tuple.Create("", 128), Tuple.Create<System.Object, System.Int32>(Model.SelectedSizeUrl
            
            #line default
            #line hidden
, 128), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 151), Tuple.Create("\"", 176)
            
            #line 4 "..\..MVC\Views\Card\Card.cshtml"
, Tuple.Create(Tuple.Create("", 159), Tuple.Create<System.Object, System.Int32>(Model.ImageTitle
            
            #line default
            #line hidden
, 159), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 177), Tuple.Create("\"", 210)
            
            #line 4 "..\..MVC\Views\Card\Card.cshtml"
, Tuple.Create(Tuple.Create("", 183), Tuple.Create<System.Object, System.Int32>(Model.ImageAlternativeText
            
            #line default
            #line hidden
, 183), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"caption\"");

WriteLiteral(">\r\n        <h3>");

            
            #line 6 "..\..MVC\Views\Card\Card.cshtml"
       Write(Html.Raw(Model.Heading));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n        <p>");

            
            #line 7 "..\..MVC\Views\Card\Card.cshtml"
      Write(Html.Raw(Model.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n\r\n");

            
            #line 9 "..\..MVC\Views\Card\Card.cshtml"
        
            
            #line default
            #line hidden
            
            #line 9 "..\..MVC\Views\Card\Card.cshtml"
         if (!string.IsNullOrEmpty(Model.ActionName))
        {

            
            #line default
            #line hidden
WriteLiteral("            <p><a");

WriteAttribute("href", Tuple.Create(" href=\"", 414), Tuple.Create("\"", 437)
            
            #line 11 "..\..MVC\Views\Card\Card.cshtml"
, Tuple.Create(Tuple.Create("", 421), Tuple.Create<System.Object, System.Int32>(Model.ActionUrl
            
            #line default
            #line hidden
, 421), false)
);

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" >");

            
            #line 11 "..\..MVC\Views\Card\Card.cshtml"
                                                                            Write(Model.ActionName);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\r\n");

            
            #line 12 "..\..MVC\Views\Card\Card.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
