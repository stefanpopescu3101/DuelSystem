#pragma checksum "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4557fc229033581e6211e9ccee3d4d272ce3c2d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DuelSysWebsite.Pages.Pages_Tournaments), @"mvc.1.0.razor-page", @"/Pages/Tournaments.cshtml")]
namespace DuelSysWebsite.Pages
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
#line 1 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\_ViewImports.cshtml"
using DuelSysWebsite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4557fc229033581e6211e9ccee3d4d272ce3c2d1", @"/Pages/Tournaments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfcf61538d255306472599982bb1a11f2e476461", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Tournaments : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("member-complaint-buttons"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .container {
        min-height: 80vh;
        /*height: 100%;*/
        width: 90%;
        background: #fbfffe;
        margin: auto;
    }

    .card {
        width: 100%;
        padding: 10px;
        border: 2px solid #1B1B1E;
        transition: all .3s;
        margin: 10px;
    }

        .card:hover {
            transform: scale(1.1);
        }


        .card > .button {
            text-align: right;
        }

    button {
        /*width: 100%;*/
        background: transparent;
        border: 1px solid #1B1B1E;
        margin: 35px 0 10px;
        height: 32px;
        font-size: 12px;
        border-radius: 20px;
        padding: 0 10px;
        box-sizing: border-box;
        outline: none;
        color: #1b1b1e;
        cursor: pointer;
    }

        button:hover {
            background: #1b1b1e;
            color: #fbfffe;
        }

    .member-complaint-buttons {
        /*width:100%;*/
        padding: 10px;
        /*m");
            WriteLiteral("argin-left:60px;*/\r\n    }\r\n\r\n    .button-arrangement {\r\n        text-align: right;\r\n    }\r\n\r\n\r\n\r\n    .moreSpan {\r\n        display: none;\r\n    }\r\n</style>\r\n\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 71 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
     foreach (var item in Model.tournaments)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n\r\n            <h2>");
#nullable restore
#line 75 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
           Write(Html.DisplayTextFor(m => item.SportType));

#line default
#line hidden
#nullable disable
            WriteLiteral(" #");
#nullable restore
#line 75 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                                                      Write(Html.DisplayTextFor(m => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n            <h3>\r\n                <p>\r\n                    Tournament Type: ");
#nullable restore
#line 79 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                                Write(Html.DisplayTextFor(m => item.TournamentType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n\r\n                <br />\r\n                <p>\r\n                    Location: ");
#nullable restore
#line 84 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                         Write(Html.DisplayTextFor(m => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <br />\r\n                <p>\r\n                    Start Date: ");
#nullable restore
#line 88 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                           Write(Html.DisplayTextFor(m => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <br />\r\n                <p>\r\n                    End Date: ");
#nullable restore
#line 92 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                         Write(Html.DisplayTextFor(m => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <br />\r\n                <p>\r\n                    Min Players: ");
#nullable restore
#line 96 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                            Write(Html.DisplayTextFor(m => item.MinPlayers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <br />\r\n                <p>\r\n                    Max Players: ");
#nullable restore
#line 100 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                            Write(Html.DisplayTextFor(m => item.MaxPlayers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n\r\n                <br />\r\n                <br />\r\n                <br />\r\n\r\n                <p>\r\n                    Description:\r\n                </p>\r\n                <br />\r\n                <p>\r\n                    ");
#nullable restore
#line 112 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
               Write(Html.DisplayTextFor(m => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <br />\r\n                <br />\r\n\r\n");
#nullable restore
#line 117 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                 if (Model.tournamentManager.PlayerAlreadyRegistered(item.ID, Model.playerManager.GetPlayer(User.Identity.Name).Id) == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4557fc229033581e6211e9ccee3d4d272ce3c2d110020", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4557fc229033581e6211e9ccee3d4d272ce3c2d110303", async() => {
                    WriteLiteral("Enrolled Already");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                                                                                                   WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                                          WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 122 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                }
                else if ((Convert.ToDateTime(item.StartDate) - DateTime.Now).Days < 7)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4557fc229033581e6211e9ccee3d4d272ce3c2d115711", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4557fc229033581e6211e9ccee3d4d272ce3c2d115994", async() => {
                    WriteLiteral("Enroll Time Over");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                                                                                          WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 125 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                                          WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 128 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4557fc229033581e6211e9ccee3d4d272ce3c2d121004", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4557fc229033581e6211e9ccee3d4d272ce3c2d121287", async() => {
                    WriteLiteral("Enroll");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 132 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                                                                                          WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 131 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                                          WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 134 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h3>\r\n\r\n\r\n");
            WriteLiteral("            \r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 162 "C:\Users\Stefan\Desktop\STUDY\Synthesis_New\synthesys2nd_stefanpopescu\DuelSys\DuelSysWebsite\Pages\Tournaments.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DuelSysWebsite.Pages.TournamentsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DuelSysWebsite.Pages.TournamentsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DuelSysWebsite.Pages.TournamentsModel>)PageContext?.ViewData;
        public DuelSysWebsite.Pages.TournamentsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591