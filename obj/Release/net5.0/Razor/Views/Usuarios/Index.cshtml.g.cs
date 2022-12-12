#pragma checksum "C:\Users\Ast\Source\Repos\MarcoAntonio27C\NNA\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1bc924175e5bf1055d49073d29790b507ad02b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
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
#line 1 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\NNA\Views\_ViewImports.cshtml"
using NNA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\NNA\Views\Usuarios\Index.cshtml"
using Modelos.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1bc924175e5bf1055d49073d29790b507ad02b7", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71be287c734fc8f4bddca823fb935aae44fa52fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Acceso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Restablecer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-lg py-2 block bg-yellow-600"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\NNA\Views\Usuarios\Index.cshtml"
  
    List<DataUsuario> usuarios_ = (List<DataUsuario>)ViewData["usuarios"];
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container   mx-auto "">
    <div class=""rounded-lg mt-3 text-center text-2xl bg-yellow-600 text-white font-bold py-5"">
        Usuarios
    </div>
    <div class="" mt-9 overflow-x-auto relative shadow-md sm:rounded-lg"">
        <table class=""w-full text-sm text-left text-gray-500 dark:text-gray-400"">
            <thead class=""text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-700 dark:text-gray-400"">
                <tr>
                    <th scope=""col"" class=""py-3 px-6"">
                        Numero
                    </th>
                    <th scope=""col"" class=""py-3 px-6"">
                        Nombre
                    </th>
                    <th scope=""col"" class=""py-3 px-6"">
                        Correo
                    </th>
                    <th scope=""col"" class=""py-3 px-6"">
                        Rol
                    </th>
                    <th scope=""col"" class=""py-3 px-6"">
                        Fiscalia
                    </th>");
            WriteLiteral(@"
                    <th scope=""col"" class=""py-3 px-6"">
                        Unidad
                    </th>
                    <th scope=""col"" class=""py-3 px-6"">
                        Estatus
                    </th>
                    <th scope=""col"" class=""py-3 px-6"">
                        Restablecer Constraseña
                    </th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 42 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\NNA\Views\Usuarios\Index.cshtml"
                 foreach (var usuario in usuarios_)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <tr class=""bg-white border-b dark:bg-gray-800 dark:border-gray-700 hover:bg-gray-50 dark:hover:bg-gray-600"">
                    <th scope=""row"" class=""py-4 px-6 font-medium text-gray-900 whitespace-nowrap dark:text-white"">
                        1
                    </th>
                    <td class=""py-4 px-6"">
                        ");
#nullable restore
#line 49 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\NNA\Views\Usuarios\Index.cshtml"
                   Write(usuario.NombreCompleto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"py-4 px-6\">\r\n                        ");
#nullable restore
#line 52 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\NNA\Views\Usuarios\Index.cshtml"
                   Write(usuario.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"py-4 px-6\">\r\n                        ");
#nullable restore
#line 55 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\NNA\Views\Usuarios\Index.cshtml"
                   Write(usuario.Rol);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"py-4 px-6\">\r\n                        ");
#nullable restore
#line 58 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\NNA\Views\Usuarios\Index.cshtml"
                   Write(usuario.Fiscalia);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"py-4 px-6\">\r\n                        ");
#nullable restore
#line 61 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\NNA\Views\Usuarios\Index.cshtml"
                   Write(usuario.Unidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"py-4 px-6\">\r\n");
#nullable restore
#line 64 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\NNA\Views\Usuarios\Index.cshtml"
                         if (usuario.Estatus.Equals("True"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24"" fill=""currentColor"" class=""w-6 h-6 fill-green-500"">
                                <path fill-rule=""evenodd"" d=""M19.916 4.626a.75.75 0 01.208 1.04l-9 13.5a.75.75 0 01-1.154.114l-6-6a.75.75 0 011.06-1.06l5.353 5.353 8.493-12.739a.75.75 0 011.04-.208z"" clip-rule=""evenodd"" />
                            </svg>
");
#nullable restore
#line 69 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\NNA\Views\Usuarios\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td class=\"py-4 px-6\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1bc924175e5bf1055d49073d29790b507ad02b79086", async() => {
                WriteLiteral(@"
                            <svg xmlns=""http://www.w3.org/2000/svg"" fill=""none"" viewBox=""0 0 24 24"" stroke-width=""1.5"" stroke=""currentColor"" class=""w-6 h-6 text-white mx-auto"">
                                <path stroke-linecap=""round"" stroke-linejoin=""round"" d=""M13.5 10.5V6.75a4.5 4.5 0 119 0v3.75M3.75 21.75h10.5a2.25 2.25 0 002.25-2.25v-6.75a2.25 2.25 0 00-2.25-2.25H3.75a2.25 2.25 0 00-2.25 2.25v6.75a2.25 2.25 0 002.25 2.25z"" />
                            </svg>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Iduser", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\NNA\Views\Usuarios\Index.cshtml"
                                                                                  WriteLiteral(usuario.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Iduser"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Iduser", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Iduser"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 79 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\NNA\Views\Usuarios\Index.cshtml"
                   
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
