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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.VideoGallery
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.VideoGallery;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/VideoGallery/List.OverlayGallery.cshtml")]
    public partial class List_OverlayGallery : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_OverlayGallery()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
Write(Html.StyleSheet(Url.WidgetContent("assets/magnific/magnific-popup.css"), "head", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
Write(Html.Script(Url.WidgetContent("assets/magnific/jquery.magnific-popup.min.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 11 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/VideoGallery/overlay-gallery.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"sf-Gallery-thumbs-container\"");

WriteLiteral(">\r\n    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 642), Tuple.Create("\"", 717)
, Tuple.Create(Tuple.Create("", 650), Tuple.Create("sf-Gallery-thumbs", 650), true)
, Tuple.Create(Tuple.Create(" ", 667), Tuple.Create("sf-Gallery-thumbs--video", 668), true)
, Tuple.Create(Tuple.Create(" ", 692), Tuple.Create("clearfix", 693), true)
            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create(" ", 701), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 702), false)
);

WriteLiteral(">\r\n    \r\n");

            
            #line 16 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
        
            
            #line default
            #line hidden
            
            #line 16 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
         foreach (var item in Model.Items)
        {
            var title = item.Fields.Title;
            var alternativeText = System.Text.RegularExpressions.Regex.Replace(title, @"[^\w\d_-]", "");

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"video-link\"");

WriteAttribute("href", Tuple.Create("\r\n                href=\"", 998), Tuple.Create("\"", 1043)
            
            #line 22 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1022), Tuple.Create<System.Object, System.Int32>(item.Fields.MediaUrl
            
            #line default
            #line hidden
, 1022), false)
);

WriteAttribute("title", Tuple.Create("\r\n                title=\"", 1044), Tuple.Create("\"", 1085)
            
            #line 23 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1069), Tuple.Create<System.Object, System.Int32>(alternativeText
            
            #line default
            #line hidden
, 1069), false)
);

WriteLiteral(">\r\n\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1111), Tuple.Create("\"", 1164)
            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1117), Tuple.Create<System.Object, System.Int32>(((VideoThumbnailViewModel)item).ThumbnailUrl
            
            #line default
            #line hidden
, 1117), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 1165), Tuple.Create("\"", 1187)
            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1171), Tuple.Create<System.Object, System.Int32>(alternativeText
            
            #line default
            #line hidden
, 1171), false)
);

WriteLiteral(" \r\n                    data-detail-url=\"");

            
            #line 26 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
                                Write(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" />\r\n            </a>\r\n            <h3>");

            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
           Write(title);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n        </div>\r\n");

            
            #line 30 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"

        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n\r\n");

            
            #line 35 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 37 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 42 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
         
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591