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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.DocumentsList
{
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
    using System;
    
    #line default
    #line hidden
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
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/DocumentsList/List.DocumentsList.cshtml")]
    public partial class List_DocumentsList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList.DocumentsListViewModel>
    {
        public List_DocumentsList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 231), Tuple.Create("\"", 254)
            
            #line 7 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 239), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 239), false)
);

WriteLiteral(">\r\n\r\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
		
            
            #line default
            #line hidden
            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
         foreach (var item in Model.Items)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteLiteral(" class=\"media\"");

WriteLiteral(">\r\n\t\t\t\t<div");

WriteLiteral(" class=\"media-left\"");

WriteLiteral(">\r\n\t\t\t\t\t<i");

WriteLiteral(" class=\"icon-file icon-txt icon-md\"");

WriteLiteral(">\r\n\t\t\t\t\t\t<span");

WriteAttribute("class", Tuple.Create(" class=\"", 413), Tuple.Create("\"", 472)
, Tuple.Create(Tuple.Create("", 421), Tuple.Create("icon-txt-", 421), true)
            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 430), Tuple.Create<System.Object, System.Int32>(((DocumentItemViewModel)item).Extension
            
            #line default
            #line hidden
, 430), false)
);

WriteLiteral(">");

            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                                                                      Write(((DocumentItemViewModel)item).Extension);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t\t\t\t</i>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div");

WriteLiteral(" class=\"media-body\"");

WriteLiteral(">\r\n\t\t\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 585), Tuple.Create("\"", 699)
            
            #line 18 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 592), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix)
            
            #line default
            #line hidden
, 592), false)
);

WriteLiteral(">\r\n\t\t\t\t\t\t\t<strong>");

            
            #line 19 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                               Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n\t\t\t\t\t</a>\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">(");

            
            #line 21 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                          Write(((DocumentItemViewModel)item).Extension);

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n\r\n\t\t\t\t\t<div>\r\n\t\t\t\t\t\t<a");

WriteAttribute("href", Tuple.Create(" href=\"", 863), Tuple.Create("\"", 891)
            
            #line 24 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
, Tuple.Create(Tuple.Create("", 870), Tuple.Create<System.Object, System.Int32>(item.Fields.MediaUrl
            
            #line default
            #line hidden
, 870), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Download</a>\r\n\t\t\t\t\t\t<span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">(");

            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
                                              Write(Math.Ceiling((double)item.Fields.TotalSize / 1024) + " KB");

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");

            
            #line 29 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
		}

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n");

            
            #line 33 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
 if (Model.ShowPager)
{
		
            
            #line default
            #line hidden
            
            #line 35 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
   Write(Html.Action("Index", "ContentPager", new
			 {
					 currentPage = Model.CurrentPage,
					 totalPagesCount = Model.TotalPagesCount.Value,
					 redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
			 }));

            
            #line default
            #line hidden
            
            #line 40 "..\..\ResourcePackages\Bootstrap\MVC\Views\DocumentsList\List.DocumentsList.cshtml"
               
}

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591