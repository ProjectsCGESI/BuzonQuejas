#pragma checksum "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86771f59abf31349cb86d804b3508ef0bf11cffb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Queja_Tablero), @"mvc.1.0.view", @"/Views/Queja/Tablero.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86771f59abf31349cb86d804b3508ef0bf11cffb", @"/Views/Queja/Tablero.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7774562118b5619486dad59aaad99a1bd02d459", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Queja_Tablero : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Tablero.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Tablero.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml"
  
    ViewData["Title"] = "Tablero Central";
    Layout = "~/Views/Shared/_Layout.cshtml";
    //var UnidadAdministrativa = (List<UnidadAdministrativa>)ViewData["unidades"];
    //var totalesPorUnidad = (Dictionary<string, string>)ViewData["totalPorUnidad"];
    //var totalesPorMunicipio = (Dictionary<string, string>)ViewData["totalPorMunicipio"];
    //var username = Context.User.FindFirst("Correo");

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86771f59abf31349cb86d804b3508ef0bf11cffb4941", async() => {
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
            WriteLiteral(@"
<link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""row"">
                <div class=""col-12"">
                    <h1 class=""text-center titulo"">Tablero Central de Quejas  </h1>
                </div>
            </div>
        </div>
        <div class=""col-12 mt-2"">
            <div class=""row no-gutters"">
                <div class=""col-6 "">
                    <div class=""row no-gutters"">
");
            WriteLiteral(@"                        <div class=""col-12 "">
                            <div class=""card text-white card-total"">
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col-6 text-center"">
                                            <span class=""material-icons icon-home"">
                                                home
                                            </span>
                                        </div>
                                        <div class=""col-6"">
                                            <div class=""row"">
                                                <div class=""col-12 text-center size-total"" id=""totalQuejas"">

                                                </div>
                                                <div class=""col-12 text-center size-total-text"">
                                                    Quejas recibidas en total
             ");
            WriteLiteral(@"                                   </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
");
            WriteLiteral(@"                        <div class=""col-6 mt-2"">
                            <div class=""card text-white card-a-p"">
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col-6 text-center"">
                                            <span class=""material-icons icon-atendidas"">
                                                gpp_good
                                            </span>
                                        </div>
                                        <div class=""col-6"">
                                            <div class=""row"">
                                                <div class=""col-12 text-center size-total-atendidas"" id=""totalAtendidas"">

                                                </div>
                                                <div class=""col-12 text-center text-atendidas-pendientes"">
                                                    Atendid");
            WriteLiteral(@"as
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
");
            WriteLiteral(@"                        <div class=""col-6 mt-2"">
                            <div class=""card text-white card-a-p"">
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col-6 text-center"">
                                            <span class=""material-icons icon-pendientes"">
                                                gpp_bad
                                            </span>
                                        </div>
                                        <div class=""col-6"">
                                            <div class=""row"">
                                                <div class=""col-12 text-center size-total-pendientes"" id=""totalPendientes"">

                                                </div>
                                                <div class=""col-12 text-center text-atendidas-pendientes"">
                                                    Pendi");
            WriteLiteral(@"entes
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
                <div class=""col-6"">
                    <div class=""card bg-light"">
                        <div class=""card-header text-center titulo-card"">Quejas de hoy ");
#nullable restore
#line 106 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml"
                                                                                  Write(DateTime.Now.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        <div class=""card-body"">
                            <canvas id=""EstatusDiarioGraph"" style=""max-height: 200px; width: 100%;height:200px;border-radius: 10px;background-color: white""></canvas>
                        </div>
                    </div>
                </div>
                <div class=""col-6"">
                    <div class=""card bg-light"">
                        <div class=""card-header text-center titulo-card"">Estatus global de quejas</div>
                        <div class=""card-body"">
                            <canvas id=""EstatusGraph"" style=""max-height: 400px; width: 100%;height:400px;border-radius: 10px;background-color: white""></canvas>
                        </div>
                    </div>
                </div>
                <div class=""col-6"">
                    <div class=""card bg-light"">
                        <div class=""card-header text-center titulo-card"">Quejas por municipio</div>
                        <div class=""card-bod");
            WriteLiteral(@"y"">
                            <div class="" chartWrapperMunicipio"">
                                <div id=""chartAreaWrapperMunicipio"" class=""chartAreaWrapperMunicipio"" onwheel=""scrollMunicipiosHandle(event)"">
                                    <div id=""chartAreaWrapper2Municipio"" class=""chartAreaWrapper2Municipio"">
                                        <canvas id=""MunicipiosGraph"" style=""max-height: 400px; width: 100%; height: 400px; border-radius: 10px; background-color: white""></canvas>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-6"">
                    <div class=""card bg-light"">
                        <div class=""card-header text-center titulo-card"">Total de quejas por unidad administrativa</div>
                        <div class=""card-body"">
                            <div class=""chartWrapperUnid");
            WriteLiteral(@"ad"">
                                <div id=""chartAreaWrapperUnidad"" class=""chartAreaWrapperUnidad"" onwheel=""scrollUnidadesHandle(event)"">
                                    <div id=""chartAreaWrapper2Unidad"" class=""chartAreaWrapper2Unidad"">
                                        <canvas id=""UnidadesGraph"" style=""max-height: 500px; width: 100%; height: 500px; border-radius: 10px; background-color: white ""></canvas>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>


                <div class=""col-6"">
                    <div class=""card bg-light"">
                        <div class=""card-header text-center titulo-card"">Estatus de quejas por UA</div>
                        <div class=""card-body"">
                            <div class=""chartWrapperEstatusUnidad"">
                                <div id=""chartAreaWrapperEstatusUnidad"" class=""cha");
            WriteLiteral(@"rtAreaWrapperEstatusUnidad"" onwheel=""scrollEstatusUnidadesHandle(event)"">
                                    <div id=""chartAreaWrapper2EstatusUnidad"" class=""chartAreaWrapper2EstatusUnidad"">
                                        <canvas id=""EstatusUnidadesGraph"" style=""max-height: 500px; width: 100%; height: 500px; border-radius: 10px; background-color: white ""></canvas>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                
                <div class=""col-6"">
                    <div class=""card bg-light"">
                        <div class=""card-header text-center titulo-card"">Departamentos</div>
                        <div class=""card-body"">
                            <div class=""chartWrapperDpto"">
                                <div id=""chartAreaWrapperDpto"" class=""chartAreaWrapperDpto"" onwheel=""scrollDepartamentosHandle(event)""");
            WriteLiteral(@">
                                    <div id=""chartAreaWrapper2Dpto"" class=""chartAreaWrapper2Dpto"">
                                        <canvas id=""DepartamentosGraph"" style=""max-height: 400px; width: 100%; height: 400px; border-radius: 10px; background-color: white ""></canvas>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-6"">
                    <div class=""card bg-light"">
                        <div class=""card-header text-center titulo-card"">Medios de recepción</div>
                        <div class=""card-body"">
                            <canvas id=""MediosGraph"" style=""max-height: 400px; width: 100%;height:400px;border-radius: 10px;background-color: white""></canvas>
                        </div>
                    </div>
                </div>
                
                <div class=""col-12");
            WriteLiteral("\">\r\n                    <div class=\"card bg-light\">\r\n                        <div class=\"card-header text-center titulo-card\">Total de quejas por año (");
#nullable restore
#line 192 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml"
                                                                                             Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</div>
                        <div class=""card-body"">
                            <canvas id=""EstatusAnualGraph"" style=""max-height: 400px; width: 100%;height:400px;border-radius: 10px;background-color: white""></canvas>
                        </div>
                    </div>
                </div>

            </div>

        </div>

    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86771f59abf31349cb86d804b3508ef0bf11cffb17739", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 205 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"https://cdn.jsdelivr.net/npm/chart.js\"></script>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 208 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral(@"

<!--<div class=""row align-items-center"">
    <div class=""col-12"">
        <div class=""row align-items-center mb-5"">
            <div class=""col-12 align-self-center mb-5"">
                <h1 class=""text-center titulo"">Tablero Central de Quejas  </h1>
            </div>
            <div class=""col-12 align-self-center"">
                <div class=""row justify-content-center "">
                    <div class=""col-2 align-self-center "">
                        <span>
                            ");
#nullable restore
#line 236 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml"
                       Write(Html.DisplayName("Total Atendidas"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                    <div class=\"col-1 text-success font-weight-bold\">\r\n                        <span>\r\n                            ");
#nullable restore
#line 241 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml"
                       Write(ViewBag.TotalAtendidas);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                    <div class=\"col-2\">\r\n                        <span>\r\n                            ");
#nullable restore
#line 246 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml"
                       Write(Html.DisplayName("Total Pendientes"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n                    <div class=\"col-1 text-danger font-weight-bold\">\r\n                        <span>\r\n                            ");
#nullable restore
#line 251 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml"
                       Write(ViewBag.TotalPendientes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-12 "">
        <div class=""row"">
            <div class=""col-6"">
                <div class=""table-responsive border contenedor-tabla"">
                    <table class=""table table-hover "">
                        <thead>
                            <tr class="" align-text-top"">
                                <th>
                                    Total por unidad Académica
                                </th>
                                <th></th>
                            </tr>
                        </thead>
                        <thead>
                            <tr class=""table-secondary align-text-top"">
                                <th>
                                    ");
#nullable restore
#line 274 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml"
                               Write(Html.DisplayName("Unidad Administrativa"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th class=\"align-text-top\">\r\n                                    ");
#nullable restore
#line 277 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml"
                               Write(Html.DisplayName("Quejas"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <!--<th class=\"align-text-top\">\r\n                                    <a class=\"text-dark\" asp-action=\"Index\" asp-route-filtro=\"");
#nullable restore
#line 280 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml"
                                                                                         Write(ViewData["FiltroEstatus"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                        ");
#nullable restore
#line 281 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml"
                                   Write(Html.DisplayName("Estatus"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>-->\r\n-->\r\n<!--");
            WriteLiteral(@"-->
<!--</th>-->
<!--</tr>
                        </thead>
                        <tbody>

                        </tbody>
                    </table>
                </div>
            </div>
            <div class=""col-6"">
                <div class=""table-responsive border contenedor-tabla"">
                    <table class=""table table-hover "">
                        <thead>
                            <tr class="" align-text-top"">
                                <th>
                                    Total por Municipio
                                </th>
                                <th></th>
                            </tr>
                        </thead>
                        <thead>
                            <tr class=""table-secondary align-text-top"">
                                <th>
                                    ");
#nullable restore
#line 308 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml"
                               Write(Html.DisplayName("Municipio"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th class=\"align-text-top\">\r\n                                    ");
#nullable restore
#line 311 "C:\Users\jaime.martinez\Documents\prueba\Buzon\BuzonQuejas3\BuzonQuejas3\Views\Queja\Tablero.cshtml"
                               Write(Html.DisplayName("Quejas"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </th>
                            </tr>
                        </thead>
                        <tbody>

                        </tbody>
                    </table>
                </div>
            </div>

        </div>

    </div>

</div>-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
