#pragma checksum "C:\Users\ASUS\Desktop\2562[2]\OOD\Project\CSFinder\CSFinder\CSFinder\Views\Student\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fb005609ef8f5e910973f6ec166e23bb6639090"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Details), @"mvc.1.0.view", @"/Views/Student/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Details.cshtml", typeof(AspNetCore.Views_Student_Details))]
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
#line 1 "C:\Users\ASUS\Desktop\2562[2]\OOD\Project\CSFinder\CSFinder\CSFinder\Views\_ViewImports.cshtml"
using CSFinder;

#line default
#line hidden
#line 2 "C:\Users\ASUS\Desktop\2562[2]\OOD\Project\CSFinder\CSFinder\CSFinder\Views\_ViewImports.cshtml"
using CSFinder.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb005609ef8f5e910973f6ec166e23bb6639090", @"/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd4e36d9b3fc190a2cb34169a3cc924b27a01d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CSFinder.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ASUS\Desktop\2562[2]\OOD\Project\CSFinder\CSFinder\CSFinder\Views\Student\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(77, 237, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n<table>\r\n    <tr>\r\n        <th>SID</th>\r\n        <th>Name</th>\r\n        <th>ID</th>\r\n        <th>Type</th>\r\n        <th>Email</th>\r\n        <th>Phone</th>\r\n        <th>Detail</th>\r\n        <th>Status</th>\r\n    </tr>\r\n");
            EndContext();
#line 19 "C:\Users\ASUS\Desktop\2562[2]\OOD\Project\CSFinder\CSFinder\CSFinder\Views\Student\Details.cshtml"
     foreach(var student in ViewBag.students)
    {

#line default
#line hidden
            BeginContext(368, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(391, 11, false);
#line 22 "C:\Users\ASUS\Desktop\2562[2]\OOD\Project\CSFinder\CSFinder\CSFinder\Views\Student\Details.cshtml"
       Write(student.SID);

#line default
#line hidden
            EndContext();
            BeginContext(402, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(422, 12, false);
#line 23 "C:\Users\ASUS\Desktop\2562[2]\OOD\Project\CSFinder\CSFinder\CSFinder\Views\Student\Details.cshtml"
       Write(student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(434, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(454, 10, false);
#line 24 "C:\Users\ASUS\Desktop\2562[2]\OOD\Project\CSFinder\CSFinder\CSFinder\Views\Student\Details.cshtml"
       Write(student.ID);

#line default
#line hidden
            EndContext();
            BeginContext(464, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(484, 12, false);
#line 25 "C:\Users\ASUS\Desktop\2562[2]\OOD\Project\CSFinder\CSFinder\CSFinder\Views\Student\Details.cshtml"
       Write(student.Type);

#line default
#line hidden
            EndContext();
            BeginContext(496, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(516, 13, false);
#line 26 "C:\Users\ASUS\Desktop\2562[2]\OOD\Project\CSFinder\CSFinder\CSFinder\Views\Student\Details.cshtml"
       Write(student.Email);

#line default
#line hidden
            EndContext();
            BeginContext(529, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(549, 13, false);
#line 27 "C:\Users\ASUS\Desktop\2562[2]\OOD\Project\CSFinder\CSFinder\CSFinder\Views\Student\Details.cshtml"
       Write(student.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(562, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(582, 14, false);
#line 28 "C:\Users\ASUS\Desktop\2562[2]\OOD\Project\CSFinder\CSFinder\CSFinder\Views\Student\Details.cshtml"
       Write(student.Detail);

#line default
#line hidden
            EndContext();
            BeginContext(596, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(616, 14, false);
#line 29 "C:\Users\ASUS\Desktop\2562[2]\OOD\Project\CSFinder\CSFinder\CSFinder\Views\Student\Details.cshtml"
       Write(student.Status);

#line default
#line hidden
            EndContext();
            BeginContext(630, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 31 "C:\Users\ASUS\Desktop\2562[2]\OOD\Project\CSFinder\CSFinder\CSFinder\Views\Student\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(655, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSFinder.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591