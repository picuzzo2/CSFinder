#pragma checksum "C:\Users\ASUS\Desktop\project ood\CSFinder\CSFinder\CSFinder\CSFinder\Views\Student\StudentDashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53e6abe141763a22fde6d927609d69a3594e95c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_StudentDashBoard), @"mvc.1.0.view", @"/Views/Student/StudentDashBoard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/StudentDashBoard.cshtml", typeof(AspNetCore.Views_Student_StudentDashBoard))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ASUS\Desktop\project ood\CSFinder\CSFinder\CSFinder\CSFinder\Views\_ViewImports.cshtml"
using CSFinder;

#line default
#line hidden
#line 2 "C:\Users\ASUS\Desktop\project ood\CSFinder\CSFinder\CSFinder\CSFinder\Views\_ViewImports.cshtml"
using CSFinder.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53e6abe141763a22fde6d927609d69a3594e95c6", @"/Views/Student/StudentDashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd4e36d9b3fc190a2cb34169a3cc924b27a01d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_StudentDashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ASUS\Desktop\project ood\CSFinder\CSFinder\CSFinder\CSFinder\Views\Student\StudentDashBoard.cshtml"
  
    ViewBag.Title = "UserDashBoard";

#line default
#line hidden
            BeginContext(45, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\ASUS\Desktop\project ood\CSFinder\CSFinder\CSFinder\CSFinder\Views\Student\StudentDashBoard.cshtml"
 if (ViewBag.IDType == "Student")
{

#line default
#line hidden
            BeginContext(87, 15, true);
            WriteLiteral("    <p>Welcome ");
            EndContext();
            BeginContext(103, 25, false);
#line 8 "C:\Users\ASUS\Desktop\project ood\CSFinder\CSFinder\CSFinder\CSFinder\Views\Student\StudentDashBoard.cshtml"
          Write(ViewBag.UserID.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(128, 20, true);
            WriteLiteral("</p>\r\n    <p>Name : ");
            EndContext();
            BeginContext(149, 23, false);
#line 9 "C:\Users\ASUS\Desktop\project ood\CSFinder\CSFinder\CSFinder\CSFinder\Views\Student\StudentDashBoard.cshtml"
         Write(ViewBag.Name.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(172, 23, true);
            WriteLiteral("</p>\r\n    <p>ID Type : ");
            EndContext();
            BeginContext(196, 25, false);
#line 10 "C:\Users\ASUS\Desktop\project ood\CSFinder\CSFinder\CSFinder\CSFinder\Views\Student\StudentDashBoard.cshtml"
            Write(ViewBag.IDType.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(221, 22, true);
            WriteLiteral("</p>\r\n    <p>Status : ");
            EndContext();
            BeginContext(244, 25, false);
#line 11 "C:\Users\ASUS\Desktop\project ood\CSFinder\CSFinder\CSFinder\CSFinder\Views\Student\StudentDashBoard.cshtml"
           Write(ViewBag.Status.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(269, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 12 "C:\Users\ASUS\Desktop\project ood\CSFinder\CSFinder\CSFinder\CSFinder\Views\Student\StudentDashBoard.cshtml"

}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591