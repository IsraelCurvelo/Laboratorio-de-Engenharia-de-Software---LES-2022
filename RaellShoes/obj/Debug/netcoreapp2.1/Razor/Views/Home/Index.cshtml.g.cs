#pragma checksum "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a98dec9de77832541da185496f7ad6954afb87e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\Views\_ViewImports.cshtml"
using RaellShoes;

#line default
#line hidden
#line 2 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\Views\_ViewImports.cshtml"
using RaellShoes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a98dec9de77832541da185496f7ad6954afb87e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29b89463cebe54846ca5e9d1cf3537ebfb0e81de", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Início";

#line default
#line hidden
            BeginContext(42, 39, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(81, 1091, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b3f398c463a482fb5a19e8b1d98627c", async() => {
                BeginContext(87, 1078, true);
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
            BeginContext(1172, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1176, 27351, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e0d87a55ddf475a84ea6370c211c070", async() => {
                BeginContext(1182, 21581, true);
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
                    
                    <li><a class=""nav-link scrollto"" href=""home/sobrenos"">Sobre Nós</a></li>
                    <li><a class=""nav-link scrollto"" href=""home/contato"">Contato</a></li>
                    <li><a class=""nav-link scrollto"" href=""home/perguntasfrequentes"">Perguntas Frequentes</a></li>                    
                    <li><a class=""nav-link scrollto"" href=""home/login"">Login</a></li>
                </ul>
                <i clas");
                WriteLiteral(@"s=""bi bi-list mobile-nav-toggle""></i>
            </nav><!-- .navbar -->

        </div>
    </header><!-- End Header -->
    <!-- ======= Hero Section ======= -->
    <section id=""hero"" class=""d-flex align-items-center img-fluid"">
        <div class=""container"" data-aos=""zoom-out"" data-aos-delay=""100"">
            <h1>Seja bem vindo à <span>RaellShoes</span></h1>
            <h2>O conforto e comodidade que você procura, encontra aqui!</h2>
            <div class=""d-flex"">                
                <a href=""https://www.youtube.com"" class=""glightbox btn-watch-video""><i class=""bi bi-play-circle""></i><span>Conheça Nossa História</span></a>
            </div>
        </div>
    </section><!-- End Hero -->

    <main id=""main"">
        <!-- ======= Products Section ======= -->
        <section id=""team"" class=""team section-bg"">
            <div class=""container"" data-aos=""fade-up"">

                <div class=""section-title"">
                    <h2>Lançamentos</h2>
                   ");
                WriteLiteral(@" <h3>Conheça nossas <span>Novidades</span></h3>
                    <p>Conforto, novidade e elegância, você confere primeiro aqui!</p>
                </div>

                <div class=""row"">

                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""member"">
                            <div class=""member-img"">
                                <img src=""assets/img/Produtos/Nike/Tênis Nike Air Force 1 '07 Masculino/1tenis-air-force-1-07-lv8-emb-CT2301-001-1.jpg"" class=""img-fluid"" alt="""">
                                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-check""></i></a>
                                    <a href=""detalhes-produto.html""><i class=""bi bi-arrows-angle-expand""></i></a>
                                </div>
                            </div>
                            <div class=""member-info"">
                                <h6>Tê");
                WriteLiteral(@"nis Nike Air Force 1 '07' Masculino - Branco/Preto </h6>
                                <span style="" font-size: large;"">R$ 699,99</span>
                                <span>6x Sem Juros</span>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""member"">
                            <div class=""member-img"">
                                <img src=""assets/img/Produtos/Adidas/Tênis Adidas Grand Court Base Masculino/Tenis_Grand_Court_Branco_F36483_04_standard.jpg"" class=""img-fluid"" alt="""">
                                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-check""></i></a>
                                    <a href=""home/detalhesproduto""><i class=""bi bi-arrows-angle-expand""></i></a>
                                </div>
                          ");
                WriteLiteral(@"  </div>
                            <div class=""member-info"">
                                <h6>Tênis Adidas Grand Court Base Masculino - Branco </h6>
                                <span style="" font-size: large;"">R$ 249,99</span>
                                <span>6x Sem Juros</span>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""member"">
                            <div class=""member-img"">
                                <img src=""assets/img/Produtos/Nike/Tênis Nike College Navy/1tenis-air-jordan-1-high-85-masculino-BQ4422-400-5-51643217806.jpg"" class=""img-fluid"" alt="""">
                                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-check""></i></a>
                                    <a href=""detalhes-produto.html""><i class=""bi");
                WriteLiteral(@" bi-arrows-angle-expand""></i></a>
                                </div>
                            </div>
                            <div class=""member-info"">
                                <h6>Tênis Nike College Navy Masculino - Branco/Azul </h6>
                                <span style="" font-size: large;"">R$ 1149,99</span>
                                <span>6x Sem Juros</span>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""member"">
                            <div class=""member-img"">
                                <img src=""assets/img/Produtos/Adidas/Tênis Adidas VS Switch Kids/Tenis_VS_Switch_(UNISSEX)_Branco_GW2978_04_standard.jpg"" class=""img-fluid"" alt="""">
                                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-c");
                WriteLiteral(@"heck""></i></a>
                                    <a href=""detalhes-produto.html""><i class=""bi bi-arrows-angle-expand""></i></a>
                                </div>
                            </div>
                            <div class=""member-info"">
                                <h6>Tênis Adidas Kids VS Switch Feminino - Branco </h6>
                                <span style="" font-size: large;"">R$ 219,99</span>
                                <span>6x Sem Juros</span>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""member"">
                            <div class=""member-img"">
                                <img src=""assets/img/Produtos/Adidas/TÊNIS FORUM BOLD HER STUDIO LONDON/Tenis_Forum_Bold_HER_Studio_London_Branco_H00472_01_standard.jpg"" class=""img-fluid"" alt="""">
                ");
                WriteLiteral(@"                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-check""></i></a>
                                    <a href=""detalhes-produto.html""><i class=""bi bi-arrows-angle-expand""></i></a>
                                </div>
                            </div>
                            <div class=""member-info"">
                                <h6>Tênis Adidas Forum Bold Her Studio London Feminino - Branco </h6>
                                <span style="" font-size: large;"">R$ 599,99</span>
                                <span>6x Sem Juros</span>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""member"">
                            <div class=""member-img"">
                                <img src=""assets/img/Produtos/Nike/Tênis Nike Court Vision");
                WriteLiteral(@" Low Next Nature Feminino/1tenis-w-nike-court-vision-lo-be-DH3158-102-1-11637853827.jpg"" class=""img-fluid"" alt="""">
                                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-check""></i></a>
                                    <a href=""detalhes-produto.html""><i class=""bi bi-arrows-angle-expand""></i></a>
                                </div>
                            </div>
                            <div class=""member-info"">
                                <h6>Tênis Nike Court Vision Low Next Nature Feminino - Branco </h6>
                                <span style="" font-size: large;"">R$ 349,99</span>
                                <span>6x Sem Juros</span>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""member"">
              ");
                WriteLiteral(@"              <div class=""member-img"">
                                <img src=""assets/img/Produtos/Adidas/Tênis Adidas Superstar preto/Tenis_Superstar_Preto_EG4957_04_standard.jpg"" class=""img-fluid"" alt="""">
                                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-check""></i></a>
                                    <a href=""detalhes-produto.html""><i class=""bi bi-arrows-angle-expand""></i></a>
                                </div>
                            </div>
                            <div class=""member-info"">
                                <h6>Tênis Adidas Superstar Unissex - Preto</h6>
                                <span style="" font-size: large;"">R$ 449,99</span>
                                <span>6x Sem Juros</span>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos");
                WriteLiteral(@"-delay=""100"">
                        <div class=""member"">
                            <div class=""member-img"">
                                <img src=""assets/img/Produtos/Nike/Tênis Nike Explor Next Nature Infantil/1tenis-nike-eco-run-tdv-DC5862-500-1-11638989187.jpg"" class=""img-fluid"" alt="""">
                                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-check""></i></a>
                                    <a href=""detalhes-produto.html""><i class=""bi bi-arrows-angle-expand""></i></a>
                                </div>
                            </div>
                            <div class=""member-info"">
                                <h6>Tênis Nike Explor Next Nature Infantil Unissex - Roxo </h6>
                                <span style="" font-size: large;"">R$ 349,99</span>
                                <span>6x Sem Juros</span>
                            </div>
                        </div>
                    </div>
");
                WriteLiteral(@"
                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""member"">
                            <div class=""member-img"">
                                <img src=""assets/img/Produtos/New Balance/Tênis New Balance 5740/1.png"" class=""img-fluid"" alt="""">
                                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-check""></i></a>
                                    <a href=""detalhes-produto.html""><i class=""bi bi-arrows-angle-expand""></i></a>
                                </div>
                            </div>
                            <div class=""member-info"">
                                <h6>Tênis New Balance 5740 Casual Masculino - Bege </h6>
                                <span style="" font-size: large;"">R$ 699,99</span>
                                <span>6x Sem Juros</span>
                            </div>
                ");
                WriteLiteral(@"        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""member"">
                            <div class=""member-img"">
                                <img src=""assets/img/Produtos/Adidas/Tênis Adidas Superstar Pride/Tenis_Superstar_Pride_Branco_GW2415_04_standard.jpg"" class=""img-fluid"" alt="""">
                                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-check""></i></a>
                                    <a href=""detalhes-produto.html""><i class=""bi bi-arrows-angle-expand""></i></a>
                                </div>
                            </div>
                            <div class=""member-info"">
                                <h6>Tênis Adidas Superstar Pride Feminino - Branco </h6>
                                <span style="" font-size: large;"">R$ 499,99</span>
                    ");
                WriteLiteral(@"            <span>6x Sem Juros</span>
                            </div>
                        </div>
                    </div>



                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""member"">
                            <div class=""member-img"">
                                <img src=""assets/img/Produtos/New Balance/Tênis New Balance Tempo Corrida Feminino/1.jpeg"" class=""img-fluid"" alt="""">
                                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-check""></i></a>
                                    <a href=""detalhes-produto.html""><i class=""bi bi-arrows-angle-expand""></i></a>
                                </div>
                            </div>
                            <div class=""member-info"">
                                <h6>Tênis New Balance Tempo Corrida Feminino - Rosa </h6>
                                <sp");
                WriteLiteral(@"an style="" font-size: large;"">R$ 349,99</span>
                                <span>6x Sem Juros</span>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""member"">
                            <div class=""member-img"">
                                <img src=""assets/img/Produtos/Adidas/Tênis Adidas Busenitz/Tenis_Busenitz_Cinza_H03345_01_standard.jpg"" class=""img-fluid"" alt="""">
                                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-check""></i></a>
                                    <a href=""detalhes-produto.html""><i class=""bi bi-arrows-angle-expand""></i></a>
                                </div>
                            </div>
                            <div class=""member-info"">
                                <h6>Tênis Adidas ");
                WriteLiteral(@"Busenitz Masculino - Grafitti </h6>
                                <span style="" font-size: large;"">R$ 399,99</span>
                                <span>6x Sem Juros</span>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""member"">
                            <div class=""member-img"">
                                <img src=""assets/img/Produtos/New Balance/Tênis New Balance 574 Infantil/1.jpeg"" class=""img-fluid"" alt="""">
                                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-check""></i></a>
                                    <a href=""detalhes-produto.html""><i class=""bi bi-arrows-angle-expand""></i></a>
                                </div>
                            </div>
                            <div class=""member-info"">
");
                WriteLiteral(@"                                <h6>Tênis New Balance 547 Infantil - Cinza </h6>
                                <span style="" font-size: large;"">R$ 259,99</span>
                                <span>6x Sem Juros</span>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""member"">
                            <div class=""member-img"">
                                <img src=""assets/img/Produtos/Reebok/Tênis Princess/Tenis_Princess_Preto_J95361_01_standard.jpg"" class=""img-fluid"" alt="""">
                                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-check""></i></a>
                                    <a href=""detalhes-produto.html""><i class=""bi bi-arrows-angle-expand""></i></a>
                                </div>
                            </");
                WriteLiteral(@"div>
                            <div class=""member-info"">
                                <h6>Tênis Reebok Princess Feminino - Preto </h6>
                                <span style="" font-size: large;"">R$ 359,99</span>
                                <span>6x Sem Juros</span>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""member"">
                            <div class=""member-img"">
                                <img src=""assets/img/Produtos/Mizuno/Têniz Mizuno Hawk S/D16-7769-124_zoom1.jpg"" class=""img-fluid"" alt="""">
                                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-check""></i></a>
                                    <a href=""detalhes-produto.html""><i class=""bi bi-arrows-angle-expand""></i></a>
                         ");
                WriteLiteral(@"       </div>
                            </div>
                            <div class=""member-info"">
                                <h6>Tênis Mizuno Hawk S Masculino - Azul </h6>
                                <span style="" font-size: large;"">R$ 199,99</span>
                                <span>6x Sem Juros</span>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <div class=""member"">
                            <div class=""member-img"">
                                <img src=""assets/img/Produtos/Nike/Tênis Nike Court/1tenis-nike-court-vision-lo-DJ6260-001-3-31628872466.jpg"" class=""img-fluid"" alt="""">
                                <div class=""social"">

                                    <a href=""""><i class=""bi bi-cart-check""></i></a>
                                    <a href=""detalhes-produto.html"">");
                WriteLiteral(@"<i class=""bi bi-arrows-angle-expand""></i></a>
                                </div>
                            </div>
                            <div class=""member-info"">
                                <h6>Tênis Nike Court Vision Low Next Nature Masculino - Preto </h6>
                                <span style="" font-size: large;"">R$ 449,99</span>
                                <span>6x Sem Juros</span>
                            </div>
                        </div>
                    </div>


                </div>

            </div>
        </section><!-- End Products Section -->

    </main><!-- End #main -->
    <!-- ======= Footer ======= -->
    <footer id=""footer"">

        <div class=""footer-newsletter"">
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col-lg-6"">
                        <h4>Central de Assinaturas</h4>
                        <p>Se inscreva em nossa Central de Assinaturas pa");
                WriteLiteral("ra receber conteúdo promocionais e informativos</p>\r\n                        ");
                EndContext();
                BeginContext(22763, 167, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1661dfc5c44ef5a668f15de9444944", async() => {
                    BeginContext(22793, 130, true);
                    WriteLiteral("\r\n                            <input type=\"email\" name=\"email\"><input type=\"submit\" value=\"Inscreva-se\">\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(22930, 5590, true);
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
            BeginContext(28527, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
