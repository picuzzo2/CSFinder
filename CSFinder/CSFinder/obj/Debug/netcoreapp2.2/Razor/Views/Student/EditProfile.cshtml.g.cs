#pragma checksum "C:\Users\Lenovo\Desktop\csfinder\csfinder-profile\CSFinder\CSFinder\Views\Student\EditProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84ae449511f1fd3ea7d1138e2513610430cba448"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_EditProfile), @"mvc.1.0.view", @"/Views/Student/EditProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/EditProfile.cshtml", typeof(AspNetCore.Views_Student_EditProfile))]
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
#line 1 "C:\Users\Lenovo\Desktop\csfinder\csfinder-profile\CSFinder\CSFinder\Views\_ViewImports.cshtml"
using CSFinder;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Desktop\csfinder\csfinder-profile\CSFinder\CSFinder\Views\_ViewImports.cshtml"
using CSFinder.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84ae449511f1fd3ea7d1138e2513610430cba448", @"/Views/Student/EditProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08840c4435afe68975222f70e37c852a15f87412", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_EditProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Lenovo\Desktop\csfinder\csfinder-profile\CSFinder\CSFinder\Views\Student\EditProfile.cshtml"
  
    ViewData["Title"] = "EditProfile";

#line default
#line hidden
            BeginContext(47, 859, true);
            WriteLiteral(@"
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<meta charset=""utf-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" />

<style>

    img {
        margin: 20px;
        width: 500px;
    }

    .card-img {
        border-radius: 50%;
        margin: 20px;
        width: 200px;
    }

    .profile {
        width: 100%;
    }

    .text {
        border-left: 2px solid gray;
    }

    input {
        width: 100%;
    }
</style>


<div style=""display: flex;"">
    <div class=""text-left"">
        <div class=""profile"">
            <img class=""card-img"" src=""https://www.w3schools.com/howto/img_avatar.png"" alt=""Avatar"" /><br />
            <p><b>ชื่อ:</b> ");
            EndContext();
            BeginContext(907, 19, false);
#line 41 "C:\Users\Lenovo\Desktop\csfinder\csfinder-profile\CSFinder\CSFinder\Views\Student\EditProfile.cshtml"
                       Write(ViewBag.studentName);

#line default
#line hidden
            EndContext();
            BeginContext(926, 35, true);
            WriteLiteral("</p>\r\n            <p><b>สถานะ:</b> ");
            EndContext();
            BeginContext(962, 21, false);
#line 42 "C:\Users\Lenovo\Desktop\csfinder\csfinder-profile\CSFinder\CSFinder\Views\Student\EditProfile.cshtml"
                        Write(ViewBag.studentStatus);

#line default
#line hidden
            EndContext();
            BeginContext(983, 3821, true);
            WriteLiteral(@"  </p>
        </div>
    </div>
    <div class=""text"">
        <div class=""profile"" style=""margin: 20%; margin-top:10% "">
            <p><b>ชื่อ:</b>&nbsp<input id=""studentFirstname"" type=""text"" /></p>
            <p><b>นามสกุล:</b>&nbsp<input id=""studentLastname"" type=""text"" /></p>
            <p><b>ที่อยู่:</b>&nbsp<input id=""studentAddress"" type=""text"" /></p>
            <p><b>เบอร์โทรศัพท์:</b>&nbsp<input id=""studentPhone"" type=""text"" /></p>
            <p><b>Facebook:</b>&nbsp<input id=""studentFacebook "" type=""text"" /> </p>
            <p><b>Email:</b>&nbsp<input id=""studentEmail  "" type=""text"" /></p>
            <p>
                <b>อันดับที่เลือก:</b><br><input id=""studentRanking "" type=""text"" />
                <br><input id=""studentRanking2 "" type=""text"" />
                <br><input id=""studentRanking3 "" type=""text"" />
            </p>
            <p><b>Resume:</b></p>
            <div class=""file-upload"">
                <input class=""file-upload__input"" type=""file"" name=""myFil");
            WriteLiteral(@"e[]"" id=""myFile"" multiple />
                <script>
                    Array.prototype.forEach.call(document.querySelectorAll('.file-upload__boutton'), function (button) {
                        const hiddenInput = button.parentElement.querySelector('.file-upload__input');
                        const label = button.parentElement.querySelector('.file-upload__label');
                        const defaultLabelText = 'No file(s) selected';

                        label.textContent = defaultLabelText;
                        label.title = defaultLabelText;

                        button.addEventListener(""click"", function () {
                            hiddenInput.click();
                        });

                        hiddenInput.addEventListener(""change"", function () {
                            console.log(hiddenInput.files);
                            const filenameList = Array.prototype.map.call(hiddenInput.files, function (file) {
                                return file");
            WriteLiteral(@".name;
                            });

                            label.textContent = filenameList.join(',') || defaultLabelText;
                            label.title = label.textContent;

                        });
                </script>
            </div><br>

            <p><b>Transcript:</b></p>
            <div class=""file-upload"">
                <input class=""file-upload__input"" type=""file"" name=""myFile[]"" id=""myFile"" multiple />
                <script>
                    Array.prototype.forEach.call(document.querySelectorAll('.file-upload__boutton'), function (button) {
                        const hiddenInput = button.parentElement.querySelector('.file-upload__input');
                        const label = button.parentElement.querySelector('.file-upload__label');
                        const defaultLabelText = 'No file(s) selected';

                        label.textContent = defaultLabelText;
                        label.title = defaultLabelText;

              ");
            WriteLiteral(@"          button.addEventListener(""click"", function () {
                            hiddenInput.click();
                        });

                        hiddenInput.addEventListener(""change"", function () {
                            console.log(hiddenInput.files);
                            const filenameList = Array.prototype.map.call(hiddenInput.files, function (file) {
                                return file.name;
                            });

                            label.textContent = filenameList.join(',') || defaultLabelText;
                            label.title = label.textContent;

                        });
                </script>
            </div>

        </div>
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
