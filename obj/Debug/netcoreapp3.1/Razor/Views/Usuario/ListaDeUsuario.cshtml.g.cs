#pragma checksum "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaDeUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86321f235a991c0aacf25c733403bbdfcc92006b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListaDeUsuario), @"mvc.1.0.view", @"/Views/Usuario/ListaDeUsuario.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86321f235a991c0aacf25c733403bbdfcc92006b", @"/Views/Usuario/ListaDeUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListaDeUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Usuarios cadastrado</h1>\r\n<p class=\"text-danger\">");
#nullable restore
#line 3 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaDeUsuario.cshtml"
                  Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"row\">Nome</th>\r\n            <th scope=\"row\">Login</th>\r\n            <th scope=\"row\">Tipo</th>\r\n        </tr>\r\n    </thead>\r\n</table>\r\n\r\n<tbody>\r\n");
#nullable restore
#line 16 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaDeUsuario.cshtml"
     foreach (Usuario u in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>");
#nullable restore
#line 20 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaDeUsuario.cshtml"
           Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaDeUsuario.cshtml"
           Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 22 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaDeUsuario.cshtml"
             if (u.Tipo == Usuario.ADMIN)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Administrador</td>\r\n");
#nullable restore
#line 25 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaDeUsuario.cshtml"
                
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Padrão</td>\r\n");
#nullable restore
#line 30 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaDeUsuario.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><a");
            BeginWriteAttribute("href", " href=\"", 671, "\"", 700, 2);
            WriteAttributeValue("", 678, "EditarUsuario?id=", 678, 17, true);
#nullable restore
#line 31 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaDeUsuario.cshtml"
WriteAttributeValue("", 695, u.Id, 695, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar |</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 739, "\"", 762, 2);
            WriteAttributeValue("", 746, "Excluir?id=", 746, 11, true);
#nullable restore
#line 32 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaDeUsuario.cshtml"
WriteAttributeValue("", 757, u.Id, 757, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir<a></td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\nessu\Downloads\Biblioteca - netcore3.1\Biblioteca\Views\Usuario\ListaDeUsuario.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n\r\n</table>\r\n\r\n<div>\r\n<a href=\"RegistrarUsuarioS\">Registrar novo usuario</a>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591