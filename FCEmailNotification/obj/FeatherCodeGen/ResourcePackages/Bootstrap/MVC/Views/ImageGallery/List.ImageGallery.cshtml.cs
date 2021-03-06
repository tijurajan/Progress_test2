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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.ImageGallery
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
    
    #line 3 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/ImageGallery/List.ImageGallery.cshtml")]
    public partial class List_ImageGallery : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_ImageGallery()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 8 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"sf-Gallery-thumbs-container\"");

WriteLiteral(">\r\n  <div");

WriteAttribute("class", Tuple.Create(" class=\"", 348), Tuple.Create("\"", 398)
, Tuple.Create(Tuple.Create("", 356), Tuple.Create("sf-Gallery-thumbs", 356), true)
, Tuple.Create(Tuple.Create(" ", 373), Tuple.Create("clearfix", 374), true)
            
            #line 11 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create(" ", 382), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 383), false)
);

WriteLiteral(">\r\n\r\n");

            
            #line 13 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
    
            
            #line default
            #line hidden
            
            #line 13 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
     for (int i = 0; i < Model.Items.Count(); i++)
    {
        var item = Model.Items.ElementAt(i);
        var itemIndex = (Model.CurrentPage - 1) * ViewBag.ItemsPerPage + i + 1;
		var detailPageUrl = ViewBag.OpenInSamePage ? HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix, itemIndex) :
            HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix);


            
            #line default
            #line hidden
WriteLiteral("      <a");

WriteLiteral(" class=\"pull-left text-center\"");

WriteAttribute("href", Tuple.Create("\r\n             href=\"", 919), Tuple.Create("\"", 954)
            
            #line 21 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create("", 940), Tuple.Create<System.Object, System.Int32>(detailPageUrl
            
            #line default
            #line hidden
, 940), false)
);

WriteAttribute("title", Tuple.Create("\r\n       title=\"", 955), Tuple.Create("\"", 1065)
            
            #line 22 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create("", 971), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(item.Fields.Description) ? item.Fields.Title : item.Fields.Description
            
            #line default
            #line hidden
, 971), false)
);

WriteLiteral(">\r\n      <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1079), Tuple.Create("\"", 1127)
            
            #line 23 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1085), Tuple.Create<System.Object, System.Int32>(((ThumbnailViewModel)item).ThumbnailUrl
            
            #line default
            #line hidden
, 1085), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\'", 1128), Tuple.Create("\'", 1226)
            
            #line 23 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1134), Tuple.Create<System.Object, System.Int32>(System.Text.RegularExpressions.Regex.Replace(item.Fields.AlternativeText, @"[^\w\d_-]", "")
            
            #line default
            #line hidden
, 1134), false)
);

WriteLiteral(" />\r\n      </a>\r\n");

            
            #line 25 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
      }

            
            #line default
            #line hidden
WriteLiteral("  </div>\r\n</div>\r\n\r\n");

            
            #line 29 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 31 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 36 "..\..MVC\Views\ImageGallery\List.ImageGallery.cshtml"
         
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
