#pragma checksum "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e878ef3f97c19cf31ef5a0c211951142c2d1c81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegisLogin_RegisStudent), @"mvc.1.0.view", @"/Views/RegisLogin/RegisStudent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegisLogin/RegisStudent.cshtml", typeof(AspNetCore.Views_RegisLogin_RegisStudent))]
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
#line 1 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\_ViewImports.cshtml"
using CSFinder;

#line default
#line hidden
#line 2 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\_ViewImports.cshtml"
using CSFinder.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e878ef3f97c19cf31ef5a0c211951142c2d1c81", @"/Views/RegisLogin/RegisStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd4e36d9b3fc190a2cb34169a3cc924b27a01d0", @"/Views/_ViewImports.cshtml")]
    public class Views_RegisLogin_RegisStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CSFinder.Models.StudentAccount>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
  
    ViewData["Title"] = "RegisStudent";
    Layout = null;

#line default
#line hidden
            BeginContext(107, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
 using (Html.BeginForm("RegisStudent", "RegisLogin", FormMethod.Post))

{

#line default
#line hidden
            BeginContext(188, 667, true);
            WriteLiteral(@"    <style>
        .RegisStudent {
            padding: 20px;          
        }
        .ID{
            padding-right: 110px;
        }
        .Password{
            padding-right: 65px;
        }
        .confirmPassword{
            padding-right: 15px;
        }
        .SID{
            padding-right: 100px;
        }
        .Name{
            padding-right: 85px;
        }
        .Email{
            padding-right: 85px;
        }
        .Phone{
            padding-right: 85px;
        }
        .Detail{
            padding-right: 85px;
        }
        .button{
            margin-left:20px;
        }
    </style>
");
            EndContext();
            BeginContext(857, 99, true);
            WriteLiteral("    <div class=\"RegisStudent\">\r\n        <table>\r\n            <tr>\r\n                <td class=\"ID\" >");
            EndContext();
            BeginContext(957, 32, false);
#line 47 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
                           Write(Html.LabelFor(a => a.account.ID));

#line default
#line hidden
            EndContext();
            BeginContext(989, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1017, 34, false);
#line 48 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.TextBoxFor(a => a.account.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1079, 44, false);
#line 49 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.ValidationMessageFor(a => a.student.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1123, 160, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n    <div class=\"RegisStudent\">\r\n        <table>\r\n            <tr>\r\n                <td class=\"Password\">");
            EndContext();
            BeginContext(1284, 38, false);
#line 56 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
                                Write(Html.LabelFor(a => a.account.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1350, 41, false);
#line 57 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.PasswordFor(a => a.account.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1419, 50, false);
#line 58 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.ValidationMessageFor(a => a.account.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 167, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n    <div class=\"RegisStudent\">\r\n        <table>\r\n            <tr>\r\n                <td class=\"confirmPassword\">");
            EndContext();
            BeginContext(1637, 37, false);
#line 65 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
                                       Write(Html.LabelFor(a => a.confirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(1674, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1702, 40, false);
#line 66 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.PasswordFor(a => a.confirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(1742, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1770, 49, false);
#line 67 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.ValidationMessageFor(a => a.confirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(1819, 155, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n    <div class=\"RegisStudent\">\r\n        <table>\r\n            <tr>\r\n                <td class=\"SID\">");
            EndContext();
            BeginContext(1975, 33, false);
#line 74 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
                           Write(Html.LabelFor(a => a.student.SID));

#line default
#line hidden
            EndContext();
            BeginContext(2008, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2036, 35, false);
#line 75 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.TextBoxFor(a => a.student.SID));

#line default
#line hidden
            EndContext();
            BeginContext(2071, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2099, 45, false);
#line 76 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.ValidationMessageFor(a => a.student.SID));

#line default
#line hidden
            EndContext();
            BeginContext(2144, 166, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n    <br>\r\n    <div class=\"RegisStudent\">\r\n        <table>\r\n            <tr>\r\n                <td class=\"Name\">");
            EndContext();
            BeginContext(2311, 34, false);
#line 84 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
                            Write(Html.LabelFor(a => a.student.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2345, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2373, 36, false);
#line 85 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.TextBoxFor(a => a.student.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2409, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2437, 46, false);
#line 86 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.ValidationMessageFor(a => a.student.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2483, 167, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n    <br>\r\n    <div class=\"RegisStudent\">\r\n        <table>\r\n            <tr>\r\n                <td class=\"Email\">");
            EndContext();
            BeginContext(2651, 35, false);
#line 94 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
                             Write(Html.LabelFor(a => a.student.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2686, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2714, 37, false);
#line 95 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.TextBoxFor(a => a.student.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2751, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2779, 47, false);
#line 96 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.ValidationMessageFor(a => a.student.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2826, 167, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n    <br>\r\n    <div class=\"RegisStudent\">\r\n        <table>\r\n            <tr>\r\n                <td class=\"Phone\">");
            EndContext();
            BeginContext(2994, 35, false);
#line 104 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
                             Write(Html.LabelFor(a => a.student.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(3029, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(3057, 37, false);
#line 105 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.TextBoxFor(a => a.student.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(3094, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(3122, 47, false);
#line 106 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.ValidationMessageFor(a => a.student.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(3169, 168, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n    <br>\r\n    <div class=\"RegisStudent\">\r\n        <table>\r\n            <tr>\r\n                <td class=\"Detail\">");
            EndContext();
            BeginContext(3338, 36, false);
#line 114 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
                              Write(Html.LabelFor(a => a.student.Detail));

#line default
#line hidden
            EndContext();
            BeginContext(3374, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(3402, 38, false);
#line 115 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.TextBoxFor(a => a.student.Detail));

#line default
#line hidden
            EndContext();
            BeginContext(3440, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(3468, 48, false);
#line 116 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
               Write(Html.ValidationMessageFor(a => a.student.Detail));

#line default
#line hidden
            EndContext();
            BeginContext(3516, 189, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n    <br>\r\n    <tr>\r\n        <td>\r\n            <input class=\"button\" type=\"submit\" value=\"Register\" /> <b>\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 126 "C:\Users\MSI\CSFinder\CSFinder\CSFinder\Views\RegisLogin\RegisStudent.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSFinder.Models.StudentAccount> Html { get; private set; }
    }
}
#pragma warning restore 1591
