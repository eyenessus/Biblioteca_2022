#pragma checksum "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fe30daa83e1ab73e267f113a28dfcfab92d8c22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_Listagem), @"mvc.1.0.view", @"/Views/Emprestimo/Listagem.cshtml")]
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
#line 1 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fe30daa83e1ab73e267f113a28dfcfab92d8c22", @"/Views/Emprestimo/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Emprestimo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Livro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Empr??stimos";
    int FiltroPorPag = Int32.Parse(ViewData["LivrosPorPagina"].ToString());
    int PaginaAtual = Int32.Parse(ViewData["PaginaAtual"].ToString());

    int NumLivrosPorPag = (Model.Count<FiltroPorPag ? Model.Count : FiltroPorPag);


    int NumTotalDePag;


    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
     if(Model.Count > 0)
{
	NumTotalDePag = Model.Count/NumLivrosPorPag + (Model.Count%NumLivrosPorPag == 0 ? 0 : 1);
}else{
    NumTotalDePag = 1;
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
 

string Classe =  "";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fe30daa83e1ab73e267f113a28dfcfab92d8c225752", async() => {
                WriteLiteral("\r\n        <div class=\"form-group mb-2\">\r\n            <select name=\"TipoFiltro\" class=\"form-control\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fe30daa83e1ab73e267f113a28dfcfab92d8c226136", async() => {
                    WriteLiteral("Usu??rio");
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
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fe30daa83e1ab73e267f113a28dfcfab92d8c227376", async() => {
                    WriteLiteral("Livro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </select>
        </div>
        <div class=""form-group mb-2 mx-sm-3"">
            <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control"" />
        </div>
        
        <button type=""submit"" class=""btn btn-primary mb-2"">Pesquisar</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n<div id=\"SeletorPaginas\">\r\n                <span>P??gina:</span>\r\n");
#nullable restore
#line 45 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                 for(int i=1; i <=NumTotalDePag; i++) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span><a");
            BeginWriteAttribute("href", " href=\"", 1314, "\"", 1385, 4);
            WriteAttributeValue("", 1321, "/Emprestimo/Listagem?PaginaAtual=", 1321, 33, true);
#nullable restore
#line 46 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 1354, i, 1354, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1356, "&itensPorPagina=", 1356, 16, true);
#nullable restore
#line 46 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 1372, FiltroPorPag, 1372, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                                                                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n");
#nullable restore
#line 47 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 54 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
         if (Model.Count >0)
        {
       

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-striped""> 
                <thead>
                    <tr><th>Id</th>
                    <th>Usuario</th>
                    <th>Data Empr??stimo</th>
                    <th>Data Devolu????o</th>
                    <th>Livro</th>
                    <th>Autor</th>
                    <th></th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 70 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
 for(int i = (PaginaAtual-1)*NumLivrosPorPag; i <(NumLivrosPorPag*PaginaAtual<Model.Count?NumLivrosPorPag*PaginaAtual:Model.Count); i++){
 

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
  if((System.DateTime.Compare(System.DateTime.Now, @Model[i].DataDevolucao)>0))
 
 {  
                     Classe = "text-danger";
                        }
                        else
                        {
                            Classe = "";
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("class", " class=\"", 2498, "\"", 2513, 1);
#nullable restore
#line 82 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 2506, Classe, 2506, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 83 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 84 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(Model[i].NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 85 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(Model[i].DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 86 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(Model[i].DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 87 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(Model[i].Livro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 88 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                   Write(Model[i].Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 2898, "\"", 2936, 2);
            WriteAttributeValue("", 2905, "/Emprestimo/Edicao/", 2905, 19, true);
#nullable restore
#line 89 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 2924, Model[i].Id, 2924, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                    </td>\r\n                    </tr>\r\n");
#nullable restore
#line 92 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                    }   

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 95 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
            }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("              <tr>\r\n                    <td colspan=\"5\">Nenhum registro foi encontrado</td>\r\n                    </tr>  \r\n");
#nullable restore
#line 99 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Emprestimo\Listagem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Emprestimo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
