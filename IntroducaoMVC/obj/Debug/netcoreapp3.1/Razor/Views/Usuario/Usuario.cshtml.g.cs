#pragma checksum "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0635e6ae01d9ed554874763c771bb6a8cd8d683"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Usuario), @"mvc.1.0.view", @"/Views/Usuario/Usuario.cshtml")]
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
#line 1 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\_ViewImports.cshtml"
using IntroducaoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\_ViewImports.cshtml"
using IntroducaoMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0635e6ae01d9ed554874763c771bb6a8cd8d683", @"/Views/Usuario/Usuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6baff92e5fd0f5ca3e96e9e97b48bbd984725d0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Usuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IntroducaoMVC.Models.Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Validação de Usuários</h2>\r\n");
#nullable restore
#line 8 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
 using (Html.BeginForm("Usuario", "Usuario", FormMethod.Post))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\r\n        <legend>Dados do Usuário</legend>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
#nullable restore
#line 16 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.LabelFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
#nullable restore
#line 19 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.EditorFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 20 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n        <div class=\"editor-label\">\r\n            ");
#nullable restore
#line 25 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.LabelFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
#nullable restore
#line 28 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.TextAreaFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 29 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.ValidationMessageFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
#nullable restore
#line 33 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.LabelFor(model => model.Idade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
#nullable restore
#line 36 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.EditorFor(model => model.Idade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 37 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.ValidationMessageFor(model => model.Idade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n        <div class=\"editor-label\">\r\n            ");
#nullable restore
#line 42 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
#nullable restore
#line 45 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.EditorFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 46 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
#nullable restore
#line 50 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.LabelFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
#nullable restore
#line 53 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.EditorFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 54 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.ValidationMessageFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n        <div class=\"editor-label\">\r\n            ");
#nullable restore
#line 59 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.LabelFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
#nullable restore
#line 62 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.PasswordFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 63 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.ValidationMessageFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
#nullable restore
#line 67 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.LabelFor(model => model.ConfirmarSenha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
#nullable restore
#line 70 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.PasswordFor(model => model.ConfirmarSenha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 71 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"
       Write(Html.ValidationMessageFor(model => model.ConfirmarSenha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <br />\r\n        <p><input class=\"btn-primary\" type=\"submit\" value=\"Cadastrar\" /></p>\r\n    </fieldset>\r\n");
            WriteLiteral("    <script src=\"~\\wwwroot\\js\\jquery\\jquery-validate\\jquery.validate.js\"></script>\r\n");
#nullable restore
#line 79 "C:\TUDO\Projetos\CSharp\IntroducaoMVC\IntroducaoMVC\Views\Usuario\Usuario.cshtml"

    



}

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IntroducaoMVC.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591