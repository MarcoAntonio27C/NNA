#pragma checksum "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fdad23247bb5ddce72ef8df41d2e7c2a664a337"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fiscalia_DenunciasMP), @"mvc.1.0.view", @"/Views/Fiscalia/DenunciasMP.cshtml")]
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
#line 1 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\_ViewImports.cshtml"
using NNA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
using Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
using Modelos.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fdad23247bb5ddce72ef8df41d2e7c2a664a337", @"/Views/Fiscalia/DenunciasMP.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71be287c734fc8f4bddca823fb935aae44fa52fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Fiscalia_DenunciasMP : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-bold hover:text-yellow-600"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Denuncia", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
  
    ViewData["Title"] = "Administrador";
    List<DataAsignada> denuncias = (List<DataAsignada>)ViewData["denuncias"];
    string niños = "Niños y Niñas";
    string adolescentes = "Adolescentes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">
<div class=""container   mx-auto "">
    <div class=""rounded-lg mt-3 text-center text-2xl bg-yellow-600 text-white font-bold py-5"">
        DENUNCIAS ASIGNADAS A 
    </div>
    <div class="" mt-9 overflow-x-auto relative shadow-md sm:rounded-lg"">
        <table class=""w-full text-sm text-left text-gray-500 dark:text-gray-400"">
            <thead class=""text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-700 dark:text-gray-400"">
                <tr>
                    <th scope=""col"" class=""py-3 px-6"">
                        Denuncia
                    </th>
                    <th scope=""col"" class=""py-3 px-6"">
                        Denuncia Recibida
                    </th>
                    <th scope=""col"" class=""py-3 px-6"">
                        Tipo Denuncia
                    </th>
                    <th scope=""col"" class=""py-3 px-6"">
                        Nombre
                    ");
            WriteLiteral(@"</th>
                    <th scope=""col"" class=""py-3 px-6"">
                        Edad
                    </th>
                    <th scope=""col"" class=""py-3 px-6"">
                        Agente del Ministerio Publico
                    </th>
                    <th scope=""col"" class=""py-3 px-6"">
                        Estatus
                    </th>
                    <th scope=""col"" class=""py-3 px-6"">
                        Visualizar
                    </th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 47 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                 foreach (var denuncia in denuncias)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-white border-b dark:bg-gray-800 dark:border-gray-700 hover:bg-gray-50 dark:hover:bg-gray-600\">\r\n                        <th scope=\"row\" class=\"py-4 px-6 font-medium text-gray-900 whitespace-nowrap dark:text-white\">\r\n");
            WriteLiteral("                            ");
#nullable restore
#line 52 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                       Write(denuncia.Expediente);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <td class=\"py-4 px-6\">\r\n                            ");
#nullable restore
#line 55 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                       Write(denuncia.Fecha.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"py-4 px-6\">\r\n");
#nullable restore
#line 58 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                             if (denuncia.IdCaso.Equals(1))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                           Write(niños);

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                                      ;
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                           Write(adolescentes);

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                                             ;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td class=\"py-4 px-6\">\r\n                            ");
#nullable restore
#line 68 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                       Write(denuncia.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"py-4 px-6\">\r\n                            ");
#nullable restore
#line 71 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                       Write(denuncia.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"py-4 px-6\">\r\n                            ");
#nullable restore
#line 74 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                       Write(denuncia.NombreMP);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"py-4 px-6\">\r\n");
#nullable restore
#line 77 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                             if (denuncia.IdEstatus.Equals(1))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"text-red-500\">");
#nullable restore
#line 79 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                                                      Write(denuncia.NombreEstatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 80 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                           Write(denuncia.NombreEstatus);

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                                                       
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"py-4 px-6\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fdad23247bb5ddce72ef8df41d2e7c2a664a33711588", async() => {
                WriteLiteral("Ver Denuncia");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                                                                                                                      WriteLiteral(denuncia.Id);

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
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 91 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Fiscalia\DenunciasMP.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
