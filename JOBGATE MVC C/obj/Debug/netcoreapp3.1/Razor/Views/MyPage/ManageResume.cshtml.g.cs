#pragma checksum "C:\Users\kunan\source\repos\JOBGATE MVC C\JOBGATE MVC C\Views\MyPage\ManageResume.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11955baa122be23982a3a818216524bc045ce399"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyPage_ManageResume), @"mvc.1.0.view", @"/Views/MyPage/ManageResume.cshtml")]
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
#line 1 "C:\Users\kunan\source\repos\JOBGATE MVC C\JOBGATE MVC C\Views\_ViewImports.cshtml"
using JOBGATE_MVC_C.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kunan\source\repos\JOBGATE MVC C\JOBGATE MVC C\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11955baa122be23982a3a818216524bc045ce399", @"/Views/MyPage/ManageResume.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a180e9bf2ce24f537727929589b70cc7fadfffd7", @"/Views/_ViewImports.cshtml")]
    public class Views_MyPage_ManageResume : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kunan\source\repos\JOBGATE MVC C\JOBGATE MVC C\Views\MyPage\ManageResume.cshtml"
   Layout = "_Layout MyPage"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""card shadow-lg"">
        <div class=""card-body bg-light"">
            <div class=""card-header"">
                <h3 class=""font-weight-bold text-dark"">Manage Resume</h3>
                <h6 class=""font-weight-bold text-dark"">Total Resume : 3 items</h6>
            </div>
            <div class=""card-body"">
                <div id=""Resume1"" class=""row"">
                    <div class=""col-8"">
                        <h5 class=""font-weight-bold text-dark"">Name of Resume #1</h5>
                        <div class=""row"">
                            <div class=""col-6 row"">
                                <i class=""fa fa-briefcase col-2 mt-1""></i>
                                <label>Job Experince : # Year ## Month</label>
                            </div>
                            <div class=""col-6 row"">
                                <i class=""fa fa-wrench col-2 mt-1""></i>
                                <label>Job Field : Accounting</label>
                            </");
            WriteLiteral(@"div>
                        </div>
                        <div class=""row"">
                            <div class=""col-6 row"">
                                <i class=""fa fa-money-bill-alt col-2 mt-1""></i>
                                <label>Expected Salary : 30,000</label>
                            </div>
                            <div class=""col-6 row"">
                                <i class=""fa fa-map-marker-alt col-2 mt-1""></i>
                                <label>Working Location : Bangkok</label>
                            </div>
                        </div>
                    </div>
                    <div class=""col-2 text-center"">
                        <h6 class=""font-weight-bold text-dark mt-4"">Show Resume</h6>
                        <div class=""custom-control custom-switch"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""ChkResume1"">
                            <label class=""custom-control-label"" for=""ChkResume1""></label>
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-2 text-center"">
                        <button type=""button"" class=""btn btn-outline-primary btn-block"">Revise</button>
                        <button type=""button"" class=""btn btn-outline-primary btn-block"">Copy</button>
                        <button type=""button"" class=""btn btn-outline-primary btn-block"">View&Print</button>
                    </div>
                </div>
                <div id=""Resume2"" class=""row mt-5"">
                    <div class=""col-8"">
                        <h5 class=""font-weight-bold text-dark"">Name of Resume #2</h5>
                        <div class=""row"">
                            <div class=""col-6 row"">
                                <i class=""fa fa-briefcase col-2 mt-1""></i>
                                <label>Job Experince : # Year ## Month</label>
                            </div>
                            <div class=""col-6 row"">
                   ");
            WriteLiteral(@"             <i class=""fa fa-wrench col-2 mt-1""></i>
                                <label>Job Field : Accounting</label>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-6 row"">
                                <i class=""fa fa-money-bill-alt col-2 mt-1""></i>
                                <label>Expected Salary : 30,000</label>
                            </div>
                            <div class=""col-6 row"">
                                <i class=""fa fa-map-marker-alt col-2 mt-1""></i>
                                <label>Working Location : Bangkok</label>
                            </div>
                        </div>
                    </div>
                    <div class=""col-2 text-center"">
                        <h6 class=""font-weight-bold text-dark mt-4"">Show Resume</h6>
                        <div class=""custom-control custom-switch"">
                            <inpu");
            WriteLiteral(@"t type=""checkbox"" class=""custom-control-input"" id=""ChkResume2"">
                            <label class=""custom-control-label"" for=""ChkResume2""></label>
                        </div>
                    </div>
                    <div class=""col-2 text-center"">
                        <button type=""button"" class=""btn btn-outline-primary btn-block"">Revise</button>
                        <button type=""button"" class=""btn btn-outline-primary btn-block"">Copy</button>
                        <button type=""button"" class=""btn btn-outline-primary btn-block"">View&Print</button>
                    </div>
                </div>
                <div id=""Resume3"" class=""row mt-5"">
                    <div class=""col-8"">
                        <h5 class=""font-weight-bold text-dark"">Name of Resume #3</h5>
                        <div class=""row"">
                            <div class=""col-6 row"">
                                <i class=""fa fa-briefcase col-2 mt-1""></i>
                                <");
            WriteLiteral(@"label>Job Experince : # Year ## Month</label>
                            </div>
                            <div class=""col-6 row"">
                                <i class=""fa fa-wrench col-2 mt-1""></i>
                                <label>Job Field : Accounting</label>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-6 row"">
                                <i class=""fa fa-money-bill-alt col-2 mt-1""></i>
                                <label>Expected Salary : 30,000</label>
                            </div>
                            <div class=""col-6 row"">
                                <i class=""fa fa-map-marker-alt col-2 mt-1""></i>
                                <label>Working Location : Bangkok</label>
                            </div>
                        </div>
                    </div>
                    <div class=""col-2 text-center"">
                        <h6 clas");
            WriteLiteral(@"s=""font-weight-bold text-dark mt-4"">Show Resume</h6>
                        <div class=""custom-control custom-switch custom-switch-lg"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""ChkResume3"">
                            <label class=""custom-control-label"" for=""ChkResume3""></label>
                        </div>
                    </div>
                    <div class=""col-2 text-center"">
                        <button type=""button"" class=""btn btn-outline-primary btn-block"">Revise</button>
                        <button type=""button"" class=""btn btn-outline-primary btn-block"">Copy</button>
                        <button type=""button"" class=""btn btn-outline-primary btn-block"">View&Print</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
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