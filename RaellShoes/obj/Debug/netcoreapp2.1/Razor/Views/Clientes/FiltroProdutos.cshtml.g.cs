#pragma checksum "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\RaellShoes\Views\Clientes\FiltroProdutos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2963bd2b26bfea257f17ab647250916f272d6db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_FiltroProdutos), @"mvc.1.0.view", @"/Views/Clientes/FiltroProdutos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/FiltroProdutos.cshtml", typeof(AspNetCore.Views_Clientes_FiltroProdutos))]
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
#line 1 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\RaellShoes\Views\_ViewImports.cshtml"
using RaellShoes;

#line default
#line hidden
#line 2 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\RaellShoes\Views\_ViewImports.cshtml"
using RaellShoes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2963bd2b26bfea257f17ab647250916f272d6db", @"/Views/Clientes/FiltroProdutos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29b89463cebe54846ca5e9d1cf3537ebfb0e81de", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_FiltroProdutos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RaellShoes.Models.Administrador.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetalhesProduto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark btn-sm col col-lg-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:8px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProdutoCarrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\RaellShoes\Views\Clientes\FiltroProdutos.cshtml"
  ViewData["Title"] = "Resultado de Produtos";

#line default
#line hidden
            BeginContext(112, 41, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(153, 1091, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be5a0774ba2347c19b4e502dc7c5cb42", async() => {
                BeginContext(159, 1078, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta content=""width=device-width, initial-scale=1.0"" name=""viewport"">

    <title>RaellShoes</title>
    <meta content="""" name=""description"">
    <meta content="""" name=""keywords"">

    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Roboto:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i"" rel=""stylesheet"">

    <!-- Vendor CSS Files -->
    <link href=""assets/vendor/aos/aos.css"" rel=""stylesheet"">
    <link href=""assets/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/bootstrap-icons/bootstrap-icons.css"" rel=""stylesheet"">
    <link href=""assets/vendor/boxicons/css/boxicons.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/glightbox/css/glightbox.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/swiper/swiper-bundle.min.css"" rel=""stylesheet"">

    <!-- Template Main CSS File -->
    <");
                WriteLiteral("link href=\"assets/css/style.css\" rel=\"stylesheet\">\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1244, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1248, 12377, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "128c52f825874bbcac3159c5b32f89e1", async() => {
                BeginContext(1254, 3796, true);
                WriteLiteral(@"

    <!-- ======= Top Bar ======= -->
    <section id=""topbar"" class=""d-flex align-items-center"">
        <div class=""container d-flex justify-content-center justify-content-md-between"">
            <div class=""contact-info d-flex align-items-center"">
                <i class=""bi bi-envelope d-flex align-items-center""><a href=""mailto:contact@example.com"">raellcurvelo@gmail.com</a></i>
                <i class=""bi bi-phone d-flex align-items-center ms-4""><span>11 989462969</span></i>
            </div>
            <div class=""social-links d-none d-md-flex align-items-center"">
                <a href=""#"" class=""twitter""><i class=""bi bi-twitter""></i></a>
                <a href=""#"" class=""facebook""><i class=""bi bi-facebook""></i></a>
                <a href=""#"" class=""instagram""><i class=""bi bi-instagram""></i></a>
                <a href=""#"" class=""linkedin""><i class=""bi bi-linkedin""></i></i></a>
            </div>
        </div>
    </section>

    <!-- ======= Header ======= -->
    <header ");
                WriteLiteral(@"id=""header"" class=""d-flex align-items-center"">
        <div class=""container d-flex align-items-center justify-content-between"">

            <h1 class=""logo""><a href=""index.html"">RaellShoes<span>.</span></a></h1>
            <!-- Uncomment below if you prefer to use an image logo -->
            <!-- <a href=""index.html"" class=""logo""><img src=""assets/img/logo.png"" alt=""""></a>-->

            <nav id=""navbar"" class=""navbar"">
                <ul>
                    <li><a class=""nav-link scrollto active"" href=""home"">Início</a></li>
                    <li class=""dropdown"">
                        <a href=""#""><span>Navegue</span> <i class=""bi bi-chevron-down""></i></a>
                        <ul>
                            <li class=""dropdown"">
                                <a href=""#""><span>Masculino</span> <i class=""bi bi-chevron-right""></i></a>
                                <ul>
                                    <li><a href=""#"">Adulto</a></li>
                                    <li>");
                WriteLiteral(@"<a href=""#"">Infantil</a></li>
                                </ul>
                            </li>
                            <li class=""dropdown"">
                                <a href=""#""><span>Feminino</span> <i class=""bi bi-chevron-right""></i></a>
                                <ul>
                                    <li><a href=""#"">Adulto</a></li>
                                    <li><a href=""#"">Infantil</a></li>
                                </ul>
                            </li>
                            <li><a href=""#"">Lançamentos</a></li>
                            <li><a href=""#"">Outlet</a></li>
                        </ul>
                    </li>
                    <li><a class=""nav-link scrollto"" href=""home/sobrenos"">Sobre Nós</a></li>
                    <li><a class=""nav-link scrollto"" href=""home/contato"">Contato</a></li>
                    <li><a class=""nav-link scrollto"" href=""home/perguntasfrequentes"">Perguntas Frequentes</a></li>
                    <li");
                WriteLiteral(@"><a class=""nav-link scrollto"" href="""">Carrinho</a></li>
                    <li><a class=""nav-link scrollto"" href=""home/login"">Login</a></li>
                </ul>
                <i class=""bi bi-list mobile-nav-toggle""></i>
            </nav><!-- .navbar -->

        </div>
    </header><!-- End Header -->

    <main id=""main"">

        <!-- ======= Products Section ======= -->
        <section id=""team"" class=""team section-bg"">


            <div class=""container"" data-aos=""fade-up"">
                <br /><br />
                <div class=""section-title"">
                    <h2>Resultado da busca</h2>

                </div>
                <br /><br />

                <div class=""row"">
");
                EndContext();
#line 110 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\RaellShoes\Views\Clientes\FiltroProdutos.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
                BeginContext(5123, 82, true);
                WriteLiteral("                        <div class=\"col col-lg-4\">\r\n\r\n                            ");
                EndContext();
                BeginContext(5205, 2039, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "024f48215eb44db8815ddc944b22b889", async() => {
                    BeginContext(5240, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                    BeginContext(5274, 52, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f3f92ca5629044adb0bbdbd6386ccefc", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 115 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\RaellShoes\Views\Clientes\FiltroProdutos.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Id);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(5326, 303, true);
                    WriteLiteral(@"
                                <div class=""col-lg-12 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                                    <div class=""member"">
                                        <div class=""member-img"">
                                            ");
                    EndContext();
                    BeginContext(5629, 98, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "180778b6fe19496795ff8de977dea2bf", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    AddHtmlAttributeValue("", 5639, "~/assets/img/Produtos/", 5639, 22, true);
#line 119 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\RaellShoes\Views\Clientes\FiltroProdutos.cshtml"
AddHtmlAttributeValue("", 5661, Html.DisplayFor(model => item.URLFoto), 5661, 39, false);

#line default
#line hidden
                    EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(5727, 167, true);
                    WriteLiteral("\r\n\r\n                                        </div>\r\n                                        <div class=\"member-info\">\r\n                                            <h6>");
                    EndContext();
                    BeginContext(5895, 36, false);
#line 123 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\RaellShoes\Views\Clientes\FiltroProdutos.cshtml"
                                           Write(Html.DisplayFor(model => item.Marca));

#line default
#line hidden
                    EndContext();
                    BeginContext(5931, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(5933, 37, false);
#line 123 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\RaellShoes\Views\Clientes\FiltroProdutos.cshtml"
                                                                                 Write(Html.DisplayFor(model => item.Modelo));

#line default
#line hidden
                    EndContext();
                    BeginContext(5970, 3, true);
                    WriteLiteral(" - ");
                    EndContext();
                    BeginContext(5974, 35, false);
#line 123 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\RaellShoes\Views\Clientes\FiltroProdutos.cshtml"
                                                                                                                          Write(Html.DisplayFor(model => item.Nome));

#line default
#line hidden
                    EndContext();
                    BeginContext(6009, 3, true);
                    WriteLiteral(" - ");
                    EndContext();
                    BeginContext(6013, 49, false);
#line 123 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\RaellShoes\Views\Clientes\FiltroProdutos.cshtml"
                                                                                                                                                                 Write(Html.DisplayFor(model => item.CorPrimariaProduto));

#line default
#line hidden
                    EndContext();
                    BeginContext(6062, 88, true);
                    WriteLiteral(" </h6>\r\n                                            <span style=\" font-size: large;\">R$ ");
                    EndContext();
                    BeginContext(6151, 36, false);
#line 124 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\RaellShoes\Views\Clientes\FiltroProdutos.cshtml"
                                                                           Write(Html.DisplayFor(model => item.Valor));

#line default
#line hidden
                    EndContext();
                    BeginContext(6187, 663, true);
                    WriteLiteral(@"</span>
                                            <span>6x Sem Juros</span>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-lg-12"" style=""padding-bottom: 5px; margin:2px"">
                                                <button class=""btn btn-info btn-sm col col-lg-12"" style=""border-radius:8px"">Adicionar ao Carrinho</button>
                                            </div>

                                            <div class=""col-lg-12"" style=""padding-bottom: 5px; margin:2px"">
                                                ");
                    EndContext();
                    BeginContext(6850, 125, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5611a312bb864a0eb65dc10d73a4e320", async() => {
                        BeginContext(6955, 11, true);
                        WriteLiteral("Ver Produto");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(6975, 262, true);
                    WriteLiteral(@"
                                            </div>
                                        </div>
                                        <br />
                                    </div>
                                </div>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7244, 34, true);
                WriteLiteral("\r\n                        </div>\r\n");
                EndContext();
#line 141 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\RaellShoes\Views\Clientes\FiltroProdutos.cshtml"

                    }

#line default
#line hidden
                BeginContext(7303, 558, true);
                WriteLiteral(@"                </div>
        </section><!-- End Products Section -->

    </main><!-- End #main -->
    <!-- ======= Footer ======= -->
    <footer id=""footer"">

        <div class=""footer-newsletter"">
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col-lg-6"">
                        <h4>Central de Assinaturas</h4>
                        <p>Se inscreva em nossa Central de Assinaturas para receber conteúdo promocionais e informativos</p>
                        ");
                EndContext();
                BeginContext(7861, 167, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc6d8e287b064752a7b71f9b26cd6748", async() => {
                    BeginContext(7891, 130, true);
                    WriteLiteral("\r\n                            <input type=\"email\" name=\"email\"><input type=\"submit\" value=\"Inscreva-se\">\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8028, 5590, true);
                WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>

        <div class=""footer-top"">
            <div class=""container"">
                <div class=""row"">

                    <div class=""col-lg-3 col-md-6 footer-contact"">
                        <h3>RaellShoes<span>.</span></h3>
                        <p>
                            Avenida Paulista, 9999 <br>
                            São Paulo, SP 15370-496<br>
                            Brasil <br><br>
                            <strong>Telefone:</strong> 11 989462969<br>
                            <strong>Email:</strong> raellcurvelo@gmail.com<br>
                        </p>
                    </div>

                    <div class=""col-lg-3 col-md-6 footer-links"">
                        <h4>Links Úteis</h4>
                        <ul>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Início</a></li>
                            <li><i class=""bx bx-chevron-r");
                WriteLiteral(@"ight""></i> <a href=""#"">Sobre Nós</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Contato</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Termos de Uso</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Política de Privacidade</a></li>
                        </ul>
                    </div>

                    <div class=""col-lg-3 col-md-6 footer-links"">
                        <h4>Navegue</h4>
                        <ul>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Masculino</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Feminino</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Infantil</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Lançamentos</a></li>
                            <li><i class=""bx bx-chevron-right""></i");
                WriteLiteral(@"> <a href=""#"">Outlet</a></li>
                        </ul>
                    </div>

                    <div class=""col-lg-3 col-md-6 footer-links"">
                        <h4>Redes Sociais</h4>
                        <p>Nos siga em nossas redes socias para conhecer um pouco mais sobre a RaellShoes</p>
                        <div class=""social-links mt-3"">
                            <a href=""#"" class=""twitter""><i class=""bx bxl-twitter""></i></a>
                            <a href=""#"" class=""facebook""><i class=""bx bxl-facebook""></i></a>
                            <a href=""#"" class=""instagram""><i class=""bx bxl-instagram""></i></a>
                            <a href=""#"" class=""google-plus""><i class=""bx bxl-skype""></i></a>
                            <a href=""#"" class=""linkedin""><i class=""bx bxl-linkedin""></i></a>
                        </div>
                    </div>

                </div>
            </div>
        </div>

        <div class=""container py-4"">
            <div c");
                WriteLiteral(@"lass=""copyright"">
                &copy; Copyright <strong><span>RaellShoes</span></strong>. Todos os direitos reservados.
            </div>
            <div class=""credits"">
                Desenvolvido por <a href=""https://www.linkedin.com/in/israel-curvelo-0a9686173/"">Israel Curvelo</a>
            </div>
        </div>
    </footer><!-- End Footer -->
    <!--Whats-->
    <a href=""https://api.whatsapp.com/send?phone=5511989462969&text=Dúvidas"" target=""_blank""
       style=""position:fixed;bottom:20px;right:18px;"">
        <svg enable-background=""new 0 0 512 512"" width=""50"" height=""50"" version=""1.1"" viewBox=""0 0 512 512""
             xml:space=""preserve"" xmlns=""http://www.w3.org/2000/svg"">
        <path d=""M256.064,0h-0.128l0,0C114.784,0,0,114.816,0,256c0,56,18.048,107.904,48.736,150.048l-31.904,95.104  l98.4-31.456C155.712,496.512,204,512,256.064,512C397.216,512,512,397.152,512,256S397.216,0,256.064,0z""
              fill=""#4CAF50"" />



        <path d=""m405.02 361.5c-6.176 17.44-30.688");
                WriteLiteral(@" 31.904-50.24 36.128-13.376 2.848-30.848 5.12-89.664-19.264-75.232-31.168-123.68-107.62-127.46-112.58-3.616-4.96-30.4-40.48-30.4-77.216s18.656-54.624 26.176-62.304c6.176-6.304 16.384-9.184 26.176-9.184 3.168 0 6.016 0.16 8.576 0.288 7.52 0.32 11.296 0.768 16.256 12.64 6.176 14.88 21.216 51.616 23.008 55.392 1.824 3.776 3.648 8.896 1.088 13.856-2.4 5.12-4.512 7.392-8.288 11.744s-7.36 7.68-11.136 12.352c-3.456 4.064-7.36 8.416-3.008 15.936 4.352 7.36 19.392 31.904 41.536 51.616 28.576 25.44 51.744 33.568 60.032 37.024 6.176 2.56 13.536 1.952 18.048-2.848 5.728-6.176 12.8-16.416 20-26.496 5.12-7.232 11.584-8.128 18.368-5.568 6.912 2.4 43.488 20.48 51.008 24.224 7.52 3.776 12.48 5.568 14.304 8.736 1.792 3.168 1.792 18.048-4.384 35.52z""
              fill=""#FAFAFA"" />



 </svg>
    </a>

    <!-- Vendor JS Files -->
    <script src=""assets/vendor/purecounter/purecounter.js""></script>
    <script src=""assets/vendor/aos/aos.js""></script>
    <script src=""assets/vendor/bootstrap/js/bootstrap.bundle.min.js");
                WriteLiteral(@"""></script>
    <script src=""assets/vendor/glightbox/js/glightbox.min.js""></script>
    <script src=""assets/vendor/isotope-layout/isotope.pkgd.min.js""></script>
    <script src=""assets/vendor/swiper/swiper-bundle.min.js""></script>
    <script src=""assets/vendor/waypoints/noframework.waypoints.js""></script>
    <script src=""assets/vendor/php-email-form/validate.js""></script>

    <!-- Template Main JS File -->
    <script src=""assets/js/main.js""></script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13625, 11, true);
            WriteLiteral("\r\n\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RaellShoes.Models.Administrador.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
