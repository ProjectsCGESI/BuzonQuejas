#pragma checksum "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b99438b220376941df3a5c20ee940c8d6416ce8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Queja_Index), @"mvc.1.0.view", @"/Views/Queja/Index.cshtml")]
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
#line 1 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\_ViewImports.cshtml"
using BuzonQuejas3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\_ViewImports.cshtml"
using BuzonQuejas3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b99438b220376941df3a5c20ee940c8d6416ce8", @"/Views/Queja/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7774562118b5619486dad59aaad99a1bd02d459", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Queja_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BuzonQuejas3.Models.Queja>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/IndexQueja.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Seguimiento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    //var username = Context.User.FindFirst("Correo");

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3b99438b220376941df3a5c20ee940c8d6416ce85343", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""row "">
    <div class=""col align-self-center mb-2"">
        <h1 class=""text-center"">Buzón de quejas</h1>
    </div>
    <div class=""col-12 "">
        <div class=""table-responsive border contenedor-tabla"">
            <table class=""table table-hover "">
                <thead>
                    <tr>
                        <th>
                            ");
#nullable restore
#line 20 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                       Write(Html.DisplayName("Nombre"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </th>\r\n                        <!--<th>\r\n                            ");
#nullable restore
#line 25 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                       Write(Html.DisplayName("Dirección"));

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n");
            WriteLiteral("                        <!--</th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 29 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                       Write(Html.DisplayName("Teléfono"));

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n");
            WriteLiteral("                        <!--</th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 33 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                       Write(Html.DisplayName("Correo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n");
            WriteLiteral("                        <!--</th>-->\r\n                        <th>\r\n                            ");
#nullable restore
#line 37 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                       Write(Html.DisplayName("Motivo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 41 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                       Write(Html.DisplayName("Hechos"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 45 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                       Write(Html.DisplayName("Servidor Involucrado"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 49 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                       Write(Html.DisplayName("Fecha"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </th>\r\n                        <th>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b99438b220376941df3a5c20ee940c8d6416ce810103", async() => {
                WriteLiteral("\r\n                                ");
#nullable restore
#line 54 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                           Write(Html.DisplayName("Estatus"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-filtro", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                                                                          WriteLiteral(ViewData["FiltroEstatus"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filtro"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filtro", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filtro"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 62 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 66 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NombreCreador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n");
            WriteLiteral("                            <td>\r\n                                ");
#nullable restore
#line 78 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MotivoQueja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"col-2\">\r\n                                ");
#nullable restore
#line 81 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.RelatoHechos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 84 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ServidorInvolucrado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 87 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 91 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                                  
                                    if (@item.Estatus == "Pendiente")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p class=\"text-danger\">Pendiente</p>\r\n");
#nullable restore
#line 95 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p class=\"text-success\">Atendido</p>\r\n");
#nullable restore
#line 99 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b99438b220376941df3a5c20ee940c8d6416ce816611", async() => {
                WriteLiteral("Seguimiento");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                                                              WriteLiteral(item.IdQueja);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 107 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BuzonQuejas3.Models.Queja>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
