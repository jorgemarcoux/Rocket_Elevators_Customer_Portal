#pragma checksum "/mnt/c/Users/Jorge/Desktop/Rocket_Elevators_Customer_Portal/Views/Home/Intervention.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "decfc4f82bfadc8464dc54316658ba50dde1d02d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Intervention), @"mvc.1.0.view", @"/Views/Home/Intervention.cshtml")]
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
#line 1 "/mnt/c/Users/Jorge/Desktop/Rocket_Elevators_Customer_Portal/Views/_ViewImports.cshtml"
using Rocket_Elevators_Customer_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/c/Users/Jorge/Desktop/Rocket_Elevators_Customer_Portal/Views/_ViewImports.cshtml"
using Rocket_Elevators_Customer_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"decfc4f82bfadc8464dc54316658ba50dde1d02d", @"/Views/Home/Intervention.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c43fdba9ec3567df5250e21f4feb7b14e91ed237", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Intervention : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/interventions"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("intForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<header class=\"text-center mb-60 mt-40\">\r\n        <br/>\r\n\t\t\t\t<h2>New Intervention Request</h2>\r\n\t\t\t\t<hr />\r\n</header>\r\n\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<!-- FORM -->\r\n\t\t\t\t\t<div class=\"container col-5 mb-5 text-center\">\r\n                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "decfc4f82bfadc8464dc54316658ba50dde1d02d4877", async() => {
                WriteLiteral("\r\n                       <input name=\"customer_id\" id=\"customerId\" class=\"d-none\" value=\"<%=current_user.id %>\">\r\n                       <br/>\r\n                       <br/>\r\n                       <label for=\"building_id\"");
                BeginWriteAttribute("class", " class=\"", 544, "\"", 552, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""build_label"">Select Building</label>
                       <div class=""dropdown"">
                         <button class=""btn btn-danger dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                           Select Building
                         </button>
                        </div>
					               <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                           <a class=""dropdown-item"" href=""#"">Building 1</a>
                           <a class=""dropdown-item"" href=""#"">Building 2</a>
                           <a class=""dropdown-item"" href=""#"">Building 3</a>
                         </div>
                       <br/>
                       <br/>
                       <label for=""battery_id""");
                BeginWriteAttribute("class", " class=\"", 1389, "\"", 1397, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""bat_label"">Select Battery</label>
					             <div class=""dropdown"">
                         <button class=""btn btn-danger dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                           Select Battery
                         </button>
					               <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                           <a class=""dropdown-item"" href=""#"">Battery 1</a>
                           <a class=""dropdown-item"" href=""#"">Battery 2</a>
                           <a class=""dropdown-item"" href=""#"">Battery 3</a>
                         </div>
                       </div>
                       <br/>
                       <br/>
                       <label for=""column_id""");
                BeginWriteAttribute("class", " class=\"", 2220, "\"", 2228, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""col_label"">Select Column</label>
					             <div class=""dropdown"">
                         <button class=""btn btn-danger dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                           Select Column
                         </button>
					               <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                           <a class=""dropdown-item"" href=""#"">Column 1</a>
                           <a class=""dropdown-item"" href=""#"">Column 2</a>
                           <a class=""dropdown-item"" href=""#"">Column 3</a>
                         </div>
                       </div>
                       <br/>
                       <br/>
                       <label for=""elevator_id""");
                BeginWriteAttribute("class", " class=\"", 3048, "\"", 3056, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""elev_label"">Select Lift</label>
					             <div class=""dropdown"">
                         <button class=""btn btn-danger dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                           Select Elevator
                         </button>
					               <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                           <a class=""dropdown-item"" href=""#"">Elevator 1</a>
                           <a class=""dropdown-item"" href=""#"">Elevator 2</a>
                           <a class=""dropdown-item"" href=""#"">Elevator 3</a>
                         </div>
                       </div>
                       <br/>
                       <br/>
                       <label for=""report"">Intervention Description</label>
                       <input required type=""text""");
                BeginWriteAttribute("value", " value=\"", 3963, "\"", 3971, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" name=""report"" id=""descrFrm"">
                       <!--Hidden field to get current_user_id-->
                       <input name=""author"" id=""current_author"" class=""d-none"" value=""<%=current_user.id %>""> 
                       <br/>
                       <button type=""submit"" class=""btn btn-danger"" id=""btnInter"" style=""background-color:#EB2C55;""><i class=""fa fa-check""></i>SUBMIT</button>                  
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    \r\n            </div>\r\n       </div>\r\n\r\n");
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
