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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Navigation
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
    
    #line 3 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Navigation/NavigationView.Tabs.cshtml")]
    public partial class NavigationView_Tabs : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 17 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(IList<NodeViewModel> nodes)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 18 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav nav-tabs\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 20 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
        

#line default
#line hidden

#line 20 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
         foreach(var node in nodes)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 682), Tuple.Create("\"", 705)

#line 22 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 690), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 690), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 727), Tuple.Create("\"", 743)

#line 23 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 734), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 734), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 744), Tuple.Create("\"", 769)

#line 23 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 753), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 753), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 23 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n            </li>\r\n");


#line 25 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </ul>\r\n");


#line 27 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"


#line default
#line hidden
});

#line 27 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
}
#line default
#line hidden

#line 30 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(IList<NodeViewModel> nodes)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 31 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
 
    var selectedNode = nodes.SingleOrDefault(node => node.IsCurrentlyOpened || node.HasChildOpen);

    if(selectedNode !=null)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "         <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav nav-pills\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 37 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
            

#line default
#line hidden

#line 37 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
             foreach (var node in selectedNode.ChildNodes)
            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1226), Tuple.Create("\"", 1249)

#line 39 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 1234), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 1234), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1275), Tuple.Create("\"", 1291)

#line 40 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 1282), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 1282), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 1292), Tuple.Create("\"", 1317)

#line 40 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 1301), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 1301), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 40 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                    WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n                </li>\r\n");


#line 42 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        </ul>\r\n");


#line 44 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
        

#line default
#line hidden

#line 44 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(selectedNode.ChildNodes));


#line default
#line hidden

#line 44 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                                          ;
    }


#line default
#line hidden
});

#line 46 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
}
#line default
#line hidden

#line 49 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
public System.Web.WebPages.HelperResult GetClass(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 50 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
 
    if (node.IsCurrentlyOpened)
    {
        

#line default
#line hidden

#line 53 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 53 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                           ;
    }
    else if (node.HasChildOpen)
    {
        

#line default
#line hidden

#line 57 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 57 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                           ;
    }


#line default
#line hidden
});

#line 59 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
}
#line default
#line hidden

        public NavigationView_Tabs()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 268), Tuple.Create("\"", 291)
            
            #line 9 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 276), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 276), false)
);

WriteLiteral(">\r\n    ");

WriteLiteral("\r\n\r\n");

WriteLiteral("    ");

            
            #line 12 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
Write(RenderRootLevelNode(@Model.Nodes));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 13 "..\..MVC\Views\Navigation\NavigationView.Tabs.cshtml"
Write(RenderSubLevelsRecursive(@Model.Nodes));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
