#pragma checksum "C:\TUDO\Projetos\CSharp\IntroducaoMVC\Rotas\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45d268b42e16783cf370943c94545dd557c6696c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\Rotas\Views\_ViewImports.cshtml"
using Rotas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\Rotas\Views\_ViewImports.cshtml"
using Rotas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45d268b42e16783cf370943c94545dd557c6696c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5557475e6de41002327466a80041f89131733c25", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rotas.Models.Noticia>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\Rotas\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Categorias</h2>\r\n\r\n<div class=\"noticia\">\r\n    <ul>\r\n        <!--Mostra as categorias-->\r\n");
#nullable restore
#line 12 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\Rotas\Views\Home\Index.cshtml"
         foreach(string item in ViewBag.Categorias)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                ");
#nullable restore
#line 15 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\Rotas\Views\Home\Index.cshtml"
           Write(Html.ActionLink(item, "MostraCategoria", "Home", new { @categoria = item }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 17 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\Rotas\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n<br />\r\n<br />\r\n<h2>Noticias</h2>\r\n<div>\r\n    <ul>\r\n        <!--Mostra as noticias-->\r\n");
#nullable restore
#line 26 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\Rotas\Views\Home\Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                ");
#nullable restore
#line 29 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\Rotas\Views\Home\Index.cshtml"
           Write(Html.ActionLink(item.Titulo, "MostraNoticia", "Home", new{
                @noticiaId = item.NoticiaId,
                @categoria = item.Categoria.ToLower(),
                @titulo = item.Titulo.ToLower()
                }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n                <em>");
#nullable restore
#line 35 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\Rotas\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>\r\n                <b>");
#nullable restore
#line 36 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\Rotas\Views\Home\Index.cshtml"
              Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            </li>\r\n");
#nullable restore
#line 38 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\Rotas\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 42 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\Rotas\Views\Home\Index.cshtml"
Write(Html.ActionLink("Todas as Noticias", "TodasAsNoticias", "Home"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Rotas.Models.Noticia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
