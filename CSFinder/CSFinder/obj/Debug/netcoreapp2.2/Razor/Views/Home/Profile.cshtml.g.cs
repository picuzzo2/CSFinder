#pragma checksum "D:\Project_OOD\CSFinder\CSFinder\CSFinder\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e2b86403137f435968c396ba42c4778e770a392"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Profile.cshtml", typeof(AspNetCore.Views_Home_Profile))]
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
#line 1 "D:\Project_OOD\CSFinder\CSFinder\CSFinder\Views\_ViewImports.cshtml"
using CSFinder;

#line default
#line hidden
#line 2 "D:\Project_OOD\CSFinder\CSFinder\CSFinder\Views\_ViewImports.cshtml"
using CSFinder.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e2b86403137f435968c396ba42c4778e770a392", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd4e36d9b3fc190a2cb34169a3cc924b27a01d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Project_OOD\CSFinder\CSFinder\CSFinder\Views\Home\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(43, 666, true);
            WriteLiteral(@"
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<meta charset=""utf-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" />

<style>
    img {
        border-radius: 50%;
        margin: 20px;
        width: 200px;
    }
</style>


<div class=""text-left"">
    <div class=""profile"">
        <img src=""https://www.w3schools.com/howto/img_avatar.png"" alt=""Avatar"" /><br />
        <p><b>ชื่อ</b> </p>
        <p><b>สถานะ:</b> </p>
        <button>แก้ไขโปรไฟล์</button>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
