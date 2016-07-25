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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.SearchResults
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
    
    #line 3 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Frontend.Search.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 7 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Libraries.Model;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Modules.Libraries;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SearchResults/SearchResults.cshtml")]
    public partial class SearchResults : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Search.Mvc.Models.ISearchResultsModel>
    {
        public SearchResults()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 318), Tuple.Create("\"", 342)
            
            #line 9 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 326), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 327), false)
);

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-8\"");

WriteLiteral(">\r\n");

            
            #line 13 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                     
            
            #line default
            #line hidden
            
            #line 13 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                      if (@Model.Results.TotalCount > 0)
                     {

            
            #line default
            #line hidden
WriteLiteral("                        <h1>");

            
            #line 15 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                       Write(Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 15 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                 Write(Html.Raw(Model.ResultText));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");

            
            #line 16 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                     }
                     else
                     {

            
            #line default
            #line hidden
WriteLiteral("                        <h1>");

            
            #line 19 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                       Write(Html.Resource("No"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 19 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                            Write(Html.Raw(Model.ResultText));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");

            
            #line 20 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                     }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n                <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n");

            
            #line 23 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 23 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                     if (Model.AllowSorting && @Model.Results.TotalCount > 0)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <label>");

            
            #line 25 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                          Write(Html.Resource("SortBy"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <select");

WriteLiteral(" class=\"userSortDropdown\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1054), Tuple.Create("\"", 1092)
            
            #line 26 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1062), Tuple.Create<System.Object, System.Int32>(Html.Resource("SortDropdown")
            
            #line default
            #line hidden
, 1062), false)
);

WriteLiteral(">\r\n                                <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1135), Tuple.Create("\"", 1168)
            
            #line 27 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1143), Tuple.Create<System.Object, System.Int32>(OrderByOptions.Relevance
            
            #line default
            #line hidden
, 1143), false)
);

WriteLiteral(" ");

            
            #line 27 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                      Write(Model.OrderBy == OrderByOptions.Relevance ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 27 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                                             Write(Html.Resource("Relevance"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1319), Tuple.Create("\"", 1349)
            
            #line 28 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1327), Tuple.Create<System.Object, System.Int32>(OrderByOptions.Newest
            
            #line default
            #line hidden
, 1327), false)
);

WriteLiteral(" ");

            
            #line 28 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                   Write(Model.OrderBy == OrderByOptions.Newest ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 28 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                                       Write(Html.Resource("NewestFirst"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                                <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1499), Tuple.Create("\"", 1529)
            
            #line 29 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1507), Tuple.Create<System.Object, System.Int32>(OrderByOptions.Oldest
            
            #line default
            #line hidden
, 1507), false)
);

WriteLiteral(" ");

            
            #line 29 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                   Write(Model.OrderBy == OrderByOptions.Oldest ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 29 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                                       Write(Html.Resource("OldestFirst"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                            </select>\r\n                        </label" +
">\r\n");

            
            #line 32 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </div>\r\n\r\n");

            
            #line 36 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 36 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             if (Model.Languages.Length > 1)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div>\r\n                    <span>");

            
            #line 39 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                     Write(Html.Resource("ChangeResultsLanguageLabel"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n");

            
            #line 40 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 40 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                     for (var i = 0; i < Model.Languages.Length; i++)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2066), Tuple.Create("\"", 2149)
            
            #line 42 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2073), Tuple.Create<System.Object, System.Int32>(String.Format(ViewBag.LanguageSearchUrlTemplate, Model.Languages[i].Name)
            
            #line default
            #line hidden
, 2073), false)
);

WriteLiteral(">");

            
            #line 42 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                          Write(Model.Languages[i].DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 43 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                        if (i < Model.Languages.Length - 2)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span>, </span>\r\n");

            
            #line 46 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                        }
                        else if (i == Model.Languages.Length - 2)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span> ");

            
            #line 49 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                              Write(Html.Resource("OrLabel"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n");

            
            #line 50 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                        }
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n");

            
            #line 53 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            }   

            
            #line default
            #line hidden
WriteLiteral("             \r\n            <div");

WriteLiteral(" class=\"sf-search-results media-list\"");

WriteLiteral(">\r\n");

            
            #line 56 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 56 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                 foreach (var item in Model.Results.Data)
                {
                    var hasLink = item.GetValue("Link") != null && !String.IsNullOrEmpty(item.GetValue("Link").ToString());

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"media sf-media\"");

WriteLiteral(">\r\n\r\n");

            
            #line 61 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 61 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                     if (((Telerik.Sitefinity.Services.Search.Model.Document)item).ItemType.ToString() == typeof(Telerik.Sitefinity.Libraries.Model.Image).ToString())
                    {
            

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"media-left sf-img-thmb\"");

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3219), Tuple.Create("\"", 3248)
            
            #line 65 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3226), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 3226), false)
);

WriteLiteral(">\r\n                            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 3284), Tuple.Create("\"", 3312)
            
            #line 66 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3290), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 3290), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 3313), Tuple.Create("\"", 3342)
            
            #line 66 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3319), Tuple.Create<System.Object, System.Int32>(item.GetValue("Title")
            
            #line default
            #line hidden
, 3319), false)
);

WriteLiteral(" width=\"120\"");

WriteLiteral("/>\r\n                        </a>\r\n                    </div>\r\n");

            
            #line 69 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    }

                    else if (((Telerik.Sitefinity.Services.Search.Model.Document)item).ItemType.ToString() == typeof(Telerik.Sitefinity.Libraries.Model.Video).ToString())
                    {
                        LibrariesManager librariesManager = LibrariesManager.GetManager();
                        var videoTmbId = new Guid((string)item.GetValue("Id"));
                        Video video = librariesManager.GetVideo(videoTmbId);
                        if (video != null)
                        {
                            var thumbUrl = video.ThumbnailUrl;
                        

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"media-left\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"sf-video-thmb\"");

WriteLiteral(">\r\n\r\n                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4192), Tuple.Create("\"", 4221)
            
            #line 83 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4199), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 4199), false)
);

WriteLiteral(">\r\n                                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 4265), Tuple.Create("\"", 4280)
            
            #line 84 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4271), Tuple.Create<System.Object, System.Int32>(thumbUrl
            
            #line default
            #line hidden
, 4271), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 4281), Tuple.Create("\"", 4310)
            
            #line 84 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4287), Tuple.Create<System.Object, System.Int32>(item.GetValue("Title")
            
            #line default
            #line hidden
, 4287), false)
);

WriteLiteral(" width=\"120\"");

WriteLiteral("/>\r\n                               \r\n                                    <div");

WriteLiteral(" class=\"sf-icon-play\"");

WriteLiteral("></div>\r\n                                \r\n                                </a>\r\n" +
"                            </div>\r\n                        </div>\r\n");

            
            #line 91 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                        }

                    }

                    else
                    {

                    }

            
            #line default
            #line hidden
WriteLiteral("                    \r\n                    \r\n                    <div");

WriteLiteral(" class=\"media-body sf-media-body\"");

WriteLiteral(">\r\n\r\n                        <h3>\r\n");

            
            #line 104 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 104 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                             if (hasLink)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4942), Tuple.Create("\"", 4971)
            
            #line 106 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4949), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 4949), false)
);

WriteLiteral(">");

            
            #line 106 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                            Write(item.GetValue("Title"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 107 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                            }
                            else
                            {
                                
            
            #line default
            #line hidden
            
            #line 110 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                           Write(item.GetValue("Title"));

            
            #line default
            #line hidden
            
            #line 110 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                       
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </h3>\r\n\r\n                        <p>");

            
            #line 114 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                      Write(Html.Raw(item.GetValue("HighLighterResult")));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 115 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 115 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                         if (hasLink)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5393), Tuple.Create("\"", 5422)
            
            #line 117 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 5400), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 5400), false)
);

WriteLiteral(">");

            
            #line 117 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                        Write(item.GetValue("Link"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 118 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                 </div>\r\n");

            
            #line 121 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n\r\n");

            
            #line 125 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 125 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                 if (Model.DisplayMode == ListDisplayMode.Paging && Model.TotalPagesCount != null && Model.TotalPagesCount > 1)
                {
                    if (Model.CurrentPage == Model.TotalPagesCount)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <em");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 129 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                           Write((Model.ItemsPerPage * Model.TotalPagesCount) - Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 129 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                        Write(Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" results</em>\r\n");

            
            #line 130 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <em");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 133 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                          Write(Model.ItemsPerPage);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 133 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                 Write(Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" results</em>\r\n");

            
            #line 134 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    }
                    

            
            #line default
            #line hidden
WriteLiteral("                    <div>\r\n");

WriteLiteral("                            ");

            
            #line 137 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                       Write(Html.Action("Index", "ContentPager", new
                       {
                           currentPage = Model.CurrentPage,
                           totalPagesCount = Model.TotalPagesCount,
                           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
                       }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

            
            #line 144 "..\..MVC\Views\SearchResults\SearchResults.cshtml"

                }

            
            #line default
            #line hidden
WriteLiteral("        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResOrderBy\"");

WriteAttribute("value", Tuple.Create(" value=\"", 6683), Tuple.Create("\"", 6722)
            
            #line 146 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6691), Tuple.Create<System.Object, System.Int32>(Request.QueryString["orderBy"]
            
            #line default
            #line hidden
, 6691), false)
);

WriteLiteral(" />\r\n        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResLanguage\"");

WriteAttribute("value", Tuple.Create(" value=\"", 6789), Tuple.Create("\"", 6829)
            
            #line 147 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6797), Tuple.Create<System.Object, System.Int32>(Request.QueryString["language"]
            
            #line default
            #line hidden
, 6797), false)
);

WriteLiteral(" />\r\n        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResIndexCatalogue\"");

WriteAttribute("value", Tuple.Create(" value=\"", 6902), Tuple.Create("\"", 6948)
            
            #line 148 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6910), Tuple.Create<System.Object, System.Int32>(Request.QueryString["indexCatalogue"]
            
            #line default
            #line hidden
, 6910), false)
);

WriteLiteral(" />\r\n        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResQuery\"");

WriteAttribute("value", Tuple.Create(" value=\'", 7012), Tuple.Create("\'", 7055)
            
            #line 149 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7020), Tuple.Create<System.Object, System.Int32>(Request.QueryString["searchQuery"]
            
            #line default
            #line hidden
, 7020), false)
);

WriteLiteral(" />\r\n        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResWordsMode\"");

WriteAttribute("value", Tuple.Create(" value=\'", 7123), Tuple.Create("\'", 7164)
            
            #line 150 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7131), Tuple.Create<System.Object, System.Int32>(Request.QueryString["wordsMode"]
            
            #line default
            #line hidden
, 7131), false)
);

WriteLiteral(" />\r\n        \r\n</div>\r\n\r\n");

            
            #line 154 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 155 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SearchResults/Search-results.js"), "bottom"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
