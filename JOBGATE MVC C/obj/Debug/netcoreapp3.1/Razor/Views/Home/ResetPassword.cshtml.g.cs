#pragma checksum "D:\Jobgate\Git\JOBGATE MVC C\Views\Home\ResetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce18fad5054e7fa481dba68c65b4c8c162adc9e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ResetPassword), @"mvc.1.0.view", @"/Views/Home/ResetPassword.cshtml")]
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
#nullable restore
#line 1 "D:\Jobgate\Git\JOBGATE MVC C\Views\_ViewImports.cshtml"
using JOBGATE_MVC_C.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Jobgate\Git\JOBGATE MVC C\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce18fad5054e7fa481dba68c65b4c8c162adc9e1", @"/Views/Home/ResetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a180e9bf2ce24f537727929589b70cc7fadfffd7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ResetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>
    $(document).ready(function () {
        $('#btnSend').click(function () {
            $('#forgotPW').hide();
            $('#success').toggleClass('d-none');
            setTimeout(function () { $('#countdown').text('Go to Home ... 4 sec ...'); }, 1000);
            setTimeout(function () { $('#countdown').text('Go to Home ... 3 sec ...'); }, 2000);
            setTimeout(function () { $('#countdown').text('Go to Home ... 2 sec ...'); }, 3000);
            setTimeout(function () { $('#countdown').text('Go to Home ... 1 sec ...'); }, 4000);
            setTimeout(function () { $('#countdown').text('Go to Home ... 0 sec ...'); window.location.href = 'Home'; }, 5000);
        });
    });
</script>
    <br />
    <br />
    <br />
    <br />
    <br />
    <div id=""forgotPW"" class=""row justify-content-center"">
        <div class=""col-xl-5 col-lg-12 col-md-9"">
            <div class=""row justify-content-center"">
                <h5 class=""font-weight-bold text-dark"">Enter your ema");
            WriteLiteral(@"il address. We will send you email to reset your password</h5>
            </div>
            <br />
            <div class=""row justify-content-center"">
                <input type=""email"" class=""form-control col-6"" />
                <button id=""btnSend"" type=""button"" class=""btn btn-primary ml-2"" style=""width:150px;"">Send Email</button>
            </div>
        </div>
    </div>
    <div id=""success"" class=""row justify-content-center d-none"">
        <div class=""col-xl-5 col-lg-12 col-md-9 text-center"">
            <h4 class=""font-weight-bold text-dark"">We sent email to you! Check your email.</h4>
            <h4 class=""font-weight-bold text-dark"">Click link in email to reset password</h4>
            <u><a");
            BeginWriteAttribute("href", " href=\"", 1757, "\"", 1790, 1);
#nullable restore
#line 35 "D:\Jobgate\Git\JOBGATE MVC C\Views\Home\ResetPassword.cshtml"
WriteAttributeValue("", 1764, Url.Action("Home","Home"), 1764, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"countdown\" class=\"font-weight-bold text-primary\">Go to Home ... 5 sec ...</a></u>\r\n        </div>\r\n    </div>\r\n");
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
