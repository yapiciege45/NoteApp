#pragma checksum "C:\Users\yapic\Desktop\NoteApp\NoteApp.WebUI\Views\Note\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "843e98db67b59edd1addfa9f1b052cb6bcc964cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Note_Index), @"mvc.1.0.view", @"/Views/Note/Index.cshtml")]
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
#line 1 "C:\Users\yapic\Desktop\NoteApp\NoteApp.WebUI\Views\_ViewImports.cshtml"
using NoteApp.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843e98db67b59edd1addfa9f1b052cb6bcc964cd", @"/Views/Note/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91615094a652a8101ed9801c467c359cbc886296", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Note_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Note>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\yapic\Desktop\NoteApp\NoteApp.WebUI\Views\Note\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"field\">\r\n    <canvas id=\"canvas\"");
            BeginWriteAttribute("style", " style=\"", 93, "\"", 132, 4);
            WriteAttributeValue("", 101, "background:", 101, 11, true);
            WriteAttributeValue(" ", 112, "url(", 113, 5, true);
#nullable restore
#line 8 "C:\Users\yapic\Desktop\NoteApp\NoteApp.WebUI\Views\Note\Index.cshtml"
WriteAttributeValue("", 117, Model.ImgUrl, 117, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 130, ");", 130, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"></canvas>
    <div class=""tools"">
        <button onclick=""undoLast()"" type=""button"" class=""button"">Undo</button>
        <button onclick=""clearCanvas()"" type=""button"" class=""button"">Clear</button>

        <div onclick=""changeColor(this)"" class=""color-field"" style=""background: red;""></div>
        <div onclick=""changeColor(this)"" class=""color-field"" style=""background: blue;""></div>
        <div onclick=""changeColor(this)"" class=""color-field"" style=""background: green;""></div>
        <div onclick=""changeColor(this)"" class=""color-field"" style=""background: yellow;""></div>
        <div onclick=""changeColor(this)"" class=""color-field"" style=""background: black;""></div>

        <input onInput=""draw_color = this.value"" type=""color"" class=""color-picker"">
        <input onInput=""draw_width = this.value"" type=""range"" min=""1"" max=""10"" class=""pen-range"">

        <button type=""submit"" onclick=""exportImg()"" class=""button btn-success"" data-toggle=""modal""
            data-target=""#exampleModal"" data-toggle=""");
            WriteLiteral(@"modal"" data-target=""#exampleModal"">Save</button>

        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
            aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""exampleModalLabel"">Edit Note</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "843e98db67b59edd1addfa9f1b052cb6bcc964cd6070", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"NoteId\"");
                BeginWriteAttribute("value", " value=\"", 1981, "\"", 2002, 1);
#nullable restore
#line 37 "C:\Users\yapic\Desktop\NoteApp\NoteApp.WebUI\Views\Note\Index.cshtml"
WriteAttributeValue("", 1989, Model.NoteId, 1989, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            <input type=""hidden"" id=""ImgURL"" name=""ImgUrl"">
                            <div class=""form-floating mb-3"">
                                <label class=""mb-2"">Name</label>
                                <input type=""text"" class=""form-control"" name=""Name""");
                BeginWriteAttribute("value", " value=\"", 2294, "\"", 2313, 1);
#nullable restore
#line 41 "C:\Users\yapic\Desktop\NoteApp\NoteApp.WebUI\Views\Note\Index.cshtml"
WriteAttributeValue("", 2302, Model.Name, 2302, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                            <div class=""form-floating mb-3"">
                                <label class=""mb-2"">Description</label>
                                <input type=""text"" class=""form-control"" name=""Description""");
                BeginWriteAttribute("value", " value=\"", 2578, "\"", 2604, 1);
#nullable restore
#line 45 "C:\Users\yapic\Desktop\NoteApp\NoteApp.WebUI\Views\Note\Index.cshtml"
WriteAttributeValue("", 2586, Model.Description, 2586, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                <button type=""submit"" class=""btn btn-primary"">Save changes</button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Note> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
