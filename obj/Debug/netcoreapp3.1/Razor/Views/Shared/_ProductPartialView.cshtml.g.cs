#pragma checksum "C:\Users\Hesen\Desktop\AP103BlogControllerCRUD\Views\Shared\_ProductPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e6884df70b85977618680d58cf7997cb3e8cc56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductPartialView), @"mvc.1.0.view", @"/Views/Shared/_ProductPartialView.cshtml")]
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
#line 1 "C:\Users\Hesen\Desktop\AP103BlogControllerCRUD\Views\_ViewImports.cshtml"
using Ap103PartialView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hesen\Desktop\AP103BlogControllerCRUD\Views\_ViewImports.cshtml"
using Ap103PartialView.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hesen\Desktop\AP103BlogControllerCRUD\Views\_ViewImports.cshtml"
using Ap103PartialView.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e6884df70b85977618680d58cf7997cb3e8cc56", @"/Views/Shared/_ProductPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95853e7efda40c3877f7e8d66c91b703b8852ba3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hesen\Desktop\AP103BlogControllerCRUD\Views\Shared\_ProductPartialView.cshtml"
 foreach (Product item in Model.Products)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"col-sm-6 col-md-4 col-lg-3 mt-3\">\n                        <div class=\"product-item text-center\" data-id=\"");
#nullable restore
#line 5 "C:\Users\Hesen\Desktop\AP103BlogControllerCRUD\Views\Shared\_ProductPartialView.cshtml"
                                                                        foreach (var category in Model.DataCategory)
                                                                    {
                                                                     

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hesen\Desktop\AP103BlogControllerCRUD\Views\Shared\_ProductPartialView.cshtml"
                                                                 Write(category.Name.ToLower()+" ");

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hesen\Desktop\AP103BlogControllerCRUD\Views\Shared\_ProductPartialView.cshtml"
                                                                                                   
                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                            <div class=\"img\">\n                                <a");
            BeginWriteAttribute("href", " href=\"", 548, "\"", 555, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e6884df70b85977618680d58cf7997cb3e8cc565696", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 604, "~/img/", 604, 6, true);
#nullable restore
#line 11 "C:\Users\Hesen\Desktop\AP103BlogControllerCRUD\Views\Shared\_ProductPartialView.cshtml"
AddHtmlAttributeValue("", 610, item.Image, 610, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </a>\n                            </div>\n                            <div class=\"title mt-3\">\n                                <h6>");
#nullable restore
#line 15 "C:\Users\Hesen\Desktop\AP103BlogControllerCRUD\Views\Shared\_ProductPartialView.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                            </div>\n                            <div class=\"price\">\n                                <span class=\"text-black-50\">Add to cart</span>\n                                <span class=\"text-black-50\">$");
#nullable restore
#line 19 "C:\Users\Hesen\Desktop\AP103BlogControllerCRUD\Views\Shared\_ProductPartialView.cshtml"
                                                        Write(item.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            </div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 23 "C:\Users\Hesen\Desktop\AP103BlogControllerCRUD\Views\Shared\_ProductPartialView.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591