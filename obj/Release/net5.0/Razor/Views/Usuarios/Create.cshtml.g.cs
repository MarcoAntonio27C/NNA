#pragma checksum "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Usuarios\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d3748b261aaa9e418ced829c2010f4ed753635a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Create), @"mvc.1.0.view", @"/Views/Usuarios/Create.cshtml")]
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
#line 1 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Usuarios\Create.cshtml"
using Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Usuarios\Create.cshtml"
using Modelos.Acceso;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d3748b261aaa9e418ced829c2010f4ed753635a", @"/Views/Usuarios/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71be287c734fc8f4bddca823fb935aae44fa52fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-gray-50 border border-yellow-600 text-gray-900 text-sm rounded-lg  block w-full p-2.5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "rol", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("rol"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "fiscalia", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fiscalia"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("registro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("registro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("javascript:Create()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-10 px-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Usuarios\Create.cshtml"
  
    List<Roles> roles = (List<Roles>)ViewData["roles"];
    List<Fiscalias> fiscalias = (List<Fiscalias>)ViewData["fiscalias"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<div id=""popup-modal"" class=""overflow-y-auto overflow-x-hidden fixed top-0 right-0 left-0 z-50 p-4 md:inset-0 h-modal md:h-full"">
    <div class=""relative w-full max-w-md h-full md:h-auto"">
        <div class=""relative bg-white rounded-lg shadow dark:bg-gray-700"">
            <button type=""button"" class=""absolute top-3 right-2.5 text-gray-400 bg-transparent hover:bg-gray-200 hover:text-gray-900 rounded-lg text-sm p-1.5 ml-auto inline-flex items-center dark:hover:bg-gray-800 dark:hover:text-white"" data-modal-toggle=""popup-modal"">
                <svg aria-hidden=""true"" class=""w-5 h-5"" fill=""currentColor"" viewBox=""0 0 20 20"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z"" clip-rule=""evenodd""></path></svg>
                <span class=""sr-only"">Close modal</span>
            </button>
            <");
            WriteLiteral(@"div class=""p-6 text-center"">
                <svg aria-hidden=""true"" class=""mx-auto mb-4 w-14 h-14 text-gray-400 dark:text-gray-200"" fill=""none"" stroke=""currentColor"" viewBox=""0 0 24 24"" xmlns=""http://www.w3.org/2000/svg""><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M12 8v4m0 4h.01M21 12a9 9 0 11-18 0 9 9 0 0118 0z""></path></svg>
                <h3 class=""mb-5 text-lg font-normal text-gray-500 dark:text-gray-400"">Are you sure you want to delete this product?</h3>
                <button data-modal-toggle=""popup-modal"" type=""button"" class=""text-white bg-red-600 hover:bg-red-800 focus:ring-4 focus:outline-none focus:ring-red-300 dark:focus:ring-red-800 font-medium rounded-lg text-sm inline-flex items-center px-5 py-2.5 text-center mr-2"">
                    Yes, I'm sure
                </button>
                <button data-modal-toggle=""popup-modal"" type=""button"" class=""text-gray-500 bg-white hover:bg-gray-100 focus:ring-4 focus:outline-none focus:ring-gray-200 rounded-lg bo");
            WriteLiteral(@"rder border-gray-200 text-sm font-medium px-5 py-2.5 hover:text-gray-900 focus:z-10 dark:bg-gray-700 dark:text-gray-300 dark:border-gray-500 dark:hover:text-white dark:hover:bg-gray-600 dark:focus:ring-gray-600"">No, cancel</button>
            </div>
        </div>
    </div>
</div>

<div class=""container mx-auto"">
    <div class=""w-1/2  mx-auto bg-gray-200 mt-9   shadow-md sm:rounded-lg"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d3748b261aaa9e418ced829c2010f4ed753635a9952", async() => {
                WriteLiteral(@"

            <h1 class=""text-center text-2xl font-bold my-4 text-yellow-600"">Nuevo Usuario</h1>
            <div class=""pt-5"">
                <div class=""grid grid-cols-12"">
                    <div class=""col-span-12"">
                        <label for=""first_name"" class=""block mb-2 text-sm font-medium text-gray-900"">Nombre (s)</label>
                        <input type=""text"" id=""nombre"" name=""nombre"" class=""bg-gray-50 border border-yellow-600 text-gray-900 text-sm rounded-lg  block w-full p-2.5"" required>
                    </div>
                </div>

                <div class=""grid grid-cols-12 mt-4"">
                    <div class=""col-span-6 pr-4"">
                        <label for=""first_name"" class=""block mb-2 text-sm font-medium text-gray-900 dark:text-white"">Apellido Paterno</label>
                        <input type=""text"" id=""apellidoPaterno"" name=""apellidoPaterno"" class=""bg-gray-50 border border-yellow-600 text-gray-900 text-sm rounded-lg  block w-full p-2.5"" required>
 ");
                WriteLiteral(@"                   </div>

                    <div class=""col-span-6"">
                        <label for=""first_name"" class=""block mb-2 text-sm font-medium text-gray-900 dark:text-white"">Apellido Materno</label>
                        <input type=""text"" name=""apellidoMaterno"" class=""bg-gray-50 border border-yellow-600 text-gray-900 text-sm rounded-lg  block w-full p-2.5"" required>
                    </div>
                </div>


                <div class=""grid grid-cols-12 mt-4"">
                    <div class=""col-span-12"">
                        <label");
                BeginWriteAttribute("for", " for=\"", 4368, "\"", 4374, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""block mb-2 text-sm font-medium text-gray-900 dark:text-white"">Correo Electronico</label>
                        <input type=""email"" name=""correo"" class=""bg-gray-50 border border-yellow-600 text-gray-900 text-sm rounded-lg  block w-full p-2.5"" required>
                    </div>
                </div>

                <div class=""grid grid-cols-12 mt-4"">
                    <div class=""col-span-6 "">
                        <label for=""first_name"" class=""block mb-2 text-sm font-medium text-gray-900 dark:text-white"">Rol</label>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d3748b261aaa9e418ced829c2010f4ed753635a12638", async() => {
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d3748b261aaa9e418ced829c2010f4ed753635a12935", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 65 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Usuarios\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(roles,nameof(Roles.Id),nameof(Roles.Nombre)));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-span-6 ml-4\">\r\n                        <label for=\"first_name\" class=\"block mb-2 text-sm font-medium text-gray-900 dark:text-white\">Fiscalia</label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d3748b261aaa9e418ced829c2010f4ed753635a16086", async() => {
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d3748b261aaa9e418ced829c2010f4ed753635a16383", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 72 "C:\Users\Ast\source\repos\MarcoAntonio27C\NNA\Views\Usuarios\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(fiscalias,nameof(Fiscalias.Id),nameof(Fiscalias.Nombre)));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"grid grid-cols-12 mt-4\">\r\n                    <div class=\"col-span-12\">\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 5981, "\"", 5987, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""block mb-2 text-sm font-medium text-gray-900 dark:text-white"">Contraseña</label>
                        <input type=""text"" id=""password"" name=""password"" class=""bg-gray-50 border border-yellow-600 text-gray-900 text-sm rounded-lg  block w-full p-2.5"" required>
                    </div>
                </div>


                <div class=""mt-4"">
                    <div class=""flex items-center"">
                        <button type=""submit"" class=""rounded rounded-lg mx-auto text-white bg-yellow-600 hover:bg-yellow-600 focus:outline-none focus:ring-4 focus:ring-yellow-300 font-medium  text-sm px-5 py-2.5 text-center mr-2 mb-2"">Crear Usuario</button>
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    </div>
</div>



<script>
    $(document).ready(function () {

        var name, paterno = '';
        var currentTime = new Date()
        var complemento = currentTime.getDate() + '' + 'FGE!';

        $(""#nombre"").keyup(function () {
            $(""#password"").val('');
            name = $(""#nombre"").val().split(' ');
            name = name[0].charAt(0).toUpperCase() + name[0].slice(1);
            $(""#password"").val(name + '#' + complemento);
        });

        $(""#apellidoPaterno"").keyup(function () {
            $(""#password"").val('');
            paterno = $(""#apellidoPaterno"").val().split(' ');
            paterno = paterno[0].charAt(0).toUpperCase() + paterno[0].slice(1);
            $(""#password"").val(name + '.' + paterno + '#' + complemento);
        });




    });


    function Create() {

        $.ajax({
            type: 'POST',
            url: '/Usuarios/Create',
            data: $(""#registro"").serialize(),
            success: function (dat");
            WriteLiteral("a) {\r\n\r\n                if (data == \'duplicate\') { }\r\n                alert(\'duplicate user\');\r\n            }\r\n        });\r\n\r\n    }\r\n\r\n</script>");
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