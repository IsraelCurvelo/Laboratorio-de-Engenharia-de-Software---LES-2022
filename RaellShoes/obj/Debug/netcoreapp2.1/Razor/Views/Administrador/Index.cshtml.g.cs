#pragma checksum "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\RaellShoes\Views\Administrador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aea7fcd69f8b0d6c6efc2091b8426ec402ab24e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Index), @"mvc.1.0.view", @"/Views/Administrador/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Index.cshtml", typeof(AspNetCore.Views_Administrador_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aea7fcd69f8b0d6c6efc2091b8426ec402ab24e1", @"/Views/Administrador/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29b89463cebe54846ca5e9d1cf3537ebfb0e81de", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RaellShoes.Models.ViewModel.AdminViewModel>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\curve\Desktop\LES\RaellShoes\RaellShoes\RaellShoes\RaellShoes\Views\Administrador\Index.cshtml"
   ViewData["Title"] = "Dash Admin"; 

#line default
#line hidden
            BeginContext(93, 39, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(132, 1174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46feba6b55314ff38dadce1a23eebdcc", async() => {
                BeginContext(138, 1161, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta content=""width=device-width, initial-scale=1.0"" name=""viewport"">

    <title>RaellShoes - Admin</title>
    <meta content="""" name=""description"">
    <meta content="""" name=""keywords"">

    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Roboto:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i""
          rel=""stylesheet"">

    <!-- Vendor CSS Files -->
    <link href=""assets/vendor/aos/aos.css"" rel=""stylesheet"">
    <link href=""assets/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/bootstrap-icons/bootstrap-icons.css"" rel=""stylesheet"">
    <link href=""assets/vendor/boxicons/css/boxicons.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/glightbox/css/glightbox.min.css"" rel=""stylesheet"">
    <link href=""assets/vendor/swiper/swiper-bundle.min.css"" rel=""stylesheet"">

    <!-- Template Main ");
                WriteLiteral("CSS File -->\r\n    <link href=\"assets/css/style.css\" rel=\"stylesheet\">\r\n    <link href=\"assets/antigo/css/style.css\" rel=\"stylesheet\">\r\n\r\n");
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
            BeginContext(1306, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1310, 21583, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70785bd91e8b42b38c637262e04d7c4d", async() => {
                BeginContext(1316, 21570, true);
                WriteLiteral(@"

    <!-- ======= Header ======= -->
    <header id=""header"" class=""d-flex align-items-center"">
        <div class=""container d-flex align-items-center justify-content-between"">

            <h1 class=""logo""><a href=""admin-index.html"">RaellShoes<span>.</span></a></h1>
            <!-- Uncomment below if you prefer to use an image logo -->
            <!-- <a href=""index.html"" class=""logo""><img src=""assets/img/logo.png"" alt=""""></a>-->

        </div>
        <nav id=""navbar"" class=""navbar"">
            <ul>
                <li class=""dropdown  active"">
                    <a href=""#""><span>Parâmetros</span> <i class=""bi bi-chevron-down""></i></a>
                    <ul>
                        <li><a href=""admin-parametro-grupoprecificacao.html"">Grupo de Precificação</a></li>
                        <li><a href=""admin-parametro-fornecedor.html"">Fornecedor</a></li>
                        <li><a href=""admin-parametro-categoria.html"">Categoria</a></li>
                    </ul>
             ");
                WriteLiteral(@"   </li>
                <li><a class=""nav-link scrollto"" href=""admin-procurar-cupom.html"">Cupons</a></li>
                <li><a class=""nav-link scrollto"" href=""admin-procurar-troca.html"">Trocas</a></li>
                <li><a class=""nav-link scrollto"" href=""admin-procurar-pedido.html"">Pedidos</a></li>
                <li><a class=""nav-link scrollto"" href=""admin-procurar-cliente.html"">Clientes</a></li>
                <li><a class=""nav-link scrollto"" href=""admin-procurar-produto.html"">Produtos</a></li>
                <li><a class=""nav-link scrollto"" href=""""></a></li>
            </ul>
            <i class=""bi bi-list mobile-nav-toggle""></i>
        </nav><!-- .navbar -->


    </header><!-- End Header -->


    <section id=""cliente"" class=""cliente"">
        <div class=""container mt-5"">
            <!--Box Dados Pedido-->
            <div class=""info-wrap"" style="" border-radius:20px"">
                <div class=""row"">
                    <div class=""section-title2"">
                     ");
                WriteLiteral(@"   <h2><span style=""color: rgb(0, 3, 15);"">HOME - MEU PAINÉL</span></h2>
                    </div>

                </div>

                <br><br>

                <!--Clientes-->
                <div class=""row"" style=""text-align: center;"">
                    <div class=""col-lg-3 col-md-2 form-group mt-3 mt-md-0"" id=""comb-form"">
                        <span>Clientes Ativos </span>
                        <input disabled type=""textarea"" name=""clientes-ativos"" readonly class=""form-control-plaintext""
                               id=""clientes-ativos"" value=""0""
                               style=""color: rgb(62, 91, 255);; font-weight: bold; text-align: center;"">
                        <br>
                    </div>

                    <div class=""col-lg-3 col-md-2 form-group mt-3 mt-md-0"" id=""comb-form"">
                        <span>Clientes Inativos </span>
                        <input disabled type=""textarea"" name=""clientes-inativos"" readonly class=""form-control-plaintext""
   ");
                WriteLiteral(@"                            id=""clientes-inativos"" value=""0""
                               style=""color: rgb(62, 91, 255); font-weight: bold;text-align: center;"">
                        <br>
                    </div>

                    <div class=""col-lg-3 col-md-2 form-group mt-3 mt-md-0"" id=""comb-form"" readonly>
                        <span>Novos Clientes neste mês</span>
                        <input disabled type=""text"" name=""novos-cliente-mes"" readonly class=""form-control-plaintext""
                               id=""novos-cliente-mes"" value=""0""
                               style=""color: rgb(62, 91, 255); font-weight: bold;text-align: center;"">
                    </div>

                    <div class=""col-lg-3 col-md-1 form-group mt-3 mt-md-0"" id=""comb-form"">
                        <a href=""admin-procurar-cliente.html"">
                            <input type=""button"" class=""btn btn-dark btn""
                                   style=""margin-top: 20px; margin-left:-8px; border-r");
                WriteLiteral(@"adius:5px; color: aliceblue; font-style: oblique; font-weight: bold;""
                                   id=""detalhes-cliente"" value=""Ver Clientes"">
                        </a>
                    </div>
                </div>
                <hr><br>

                <!--Produtos-->
                <div class=""row"" style=""text-align: center;"">
                    <div class=""col-lg-3 col-md-2 form-group mt-3 mt-md-0"" id=""comb-form"">
                        <span>Produtos Ativos </span>
                        <input disabled type=""textarea"" name=""produtos-ativos"" readonly class=""form-control-plaintext""
                               id=""produtos-ativos"" value=""0""
                               style=""color: rgb(62, 91, 255); font-weight: bold; text-align: center;"">
                        <br>
                    </div>

                    <div class=""col-lg-3 col-md-2 form-group mt-3 mt-md-0"" id=""comb-form"">
                        <span>Produtos Inativos </span>
                       ");
                WriteLiteral(@" <input disabled type=""textarea"" name=""produtos-inativos"" readonly class=""form-control-plaintext""
                               id=""produtos-inativos"" value=""0""
                               style=""color: rgb(62, 91, 255); font-weight: bold;text-align: center;"">
                        <br>
                    </div>

                    <div class=""col-lg-3 col-md-2 form-group mt-3 mt-md-0"" id=""comb-form"" readonly>
                        <span>Produtos cadastrados este mês</span>
                        <input disabled type=""text"" name=""novos-produtos-mes"" readonly class=""form-control-plaintext""
                               id=""novos-produtos-mes"" value=""0""
                               style=""color: rgb(62, 91, 255); font-weight: bold;text-align: center;"">
                    </div>


                    <div class=""col-lg-3 col-md-1 form-group mt-3 mt-md-0"" id=""comb-form"">
                        <a href=""admin-procurar-produto.html"">
                            <input type=""button"" c");
                WriteLiteral(@"lass=""btn btn-dark btn""
                                   style=""margin-top: 20px; margin-left:-8px; border-radius:5px; color: aliceblue; font-style: oblique; font-weight: bold;""
                                   id=""detalhes-cliente"" value=""Ver Produtos"">
                        </a>
                    </div>
                </div>

                <hr><br>

                <!--Pedidos-->
                <div class=""row"" style=""text-align: center;"">
                    <div class=""col-lg-3 col-md-2 form-group mt-3 mt-md-0"" id=""comb-form"">
                        <span>Pedidos aguardando aprovação </span>
                        <input disabled type=""textarea"" name=""pedidos-aprovacao"" readonly class=""form-control-plaintext""
                               id=""pedidos-aprovacao"" value=""0""
                               style=""color: rgb(62, 91, 255); font-weight: bold; text-align: center;"">
                        <br>
                    </div>

                    <div class=""col-lg-3 co");
                WriteLiteral(@"l-md-2 form-group mt-3 mt-md-0"" id=""comb-form"">
                        <span>Pedidos aguardando entrega </span>
                        <input disabled type=""textarea"" name=""pedidos-entrega"" readonly class=""form-control-plaintext""
                               id=""pedidos-entrega"" value=""0""
                               style=""color: rgb(62, 91, 255); font-weight: bold;text-align: center;"">
                        <br>
                    </div>

                    <div class=""col-lg-3 col-md-2 form-group mt-3 mt-md-0"" id=""comb-form"" readonly>
                        <span>Pedidos realizados este mês</span>
                        <input disabled type=""text"" name=""novos-pedidos-mes"" readonly class=""form-control-plaintext""
                               id=""novos-pedidos-mes"" value=""0""
                               style=""color: rgb(62, 91, 255); font-weight: bold;text-align: center;"">
                    </div>


                    <div class=""col-lg-3 col-md-1 form-group mt-3 mt-md-0"" i");
                WriteLiteral(@"d=""comb-form"">
                        <a href=""admin-procurar-pedido.html"">
                            <input type=""button"" class=""btn btn-dark btn""
                                   style=""margin-top: 20px; margin-left:-8px; border-radius:5px; color: rgb(255, 255, 255); font-style: oblique; font-weight: bold;""
                                   id=""detalhes-cliente"" value=""Ver Pedidos"">
                        </a>
                    </div>
                </div>

                <hr><br>

                <!--Trocas-->
                <div class=""row"" style=""text-align: center;"">
                    <div class=""col-lg-3 col-md-2 form-group mt-3 mt-md-0"" id=""comb-form"">
                        <span>Trocas aguardando aprovação </span><input disabled type=""textarea"" name=""trocas-aprovacao""
                                                                        readonly class=""form-control-plaintext"" id=""pedidos-aprovacao"" value=""2""
                                                           ");
                WriteLiteral(@"             style=""color: rgb(62, 91, 255);font-weight: bold; text-align: center;"">

                        <br>
                    </div>

                    <div class=""col-lg-3 col-md-2 form-group mt-3 mt-md-0"" id=""comb-form"">
                        <span>Trocas aguardando recebimento </span>
                        <input disabled type=""textarea"" name=""trocas-recebimento"" readonly
                               class=""form-control-plaintext"" id=""trocas-recebimento"" value=""6""
                               style=""color: rgb(62, 91, 255);font-weight: bold;text-align: center;"">
                        <br>
                    </div>

                    <div class=""col-lg-3 col-md-2 form-group mt-3 mt-md-0"" id=""comb-form"" readonly>
                        <span>Trocas efetuadas este mês</span>
                        <input disabled type=""text"" name=""novos-trocas-mes"" readonly class=""form-control-plaintext""
                               id=""novos-trocas-mes"" value=""6""
                 ");
                WriteLiteral(@"              style=""color: rgb(62, 91, 255); font-weight: bold;text-align: center;"">
                    </div>

                    <div class=""col-lg-3 col-md-1 form-group mt-3 mt-md-0"" id=""comb-form"">
                        <a href=""admin-procurar-troca.html"">
                            <input type=""button"" class=""btn btn-dark btn""
                                   style=""margin-top: 20px; margin-left:-8px; border-radius:5px; color: rgb(253, 251, 251); font-style: oblique; font-weight: bold;""
                                   id=""detalhes-cliente"" value=""Ver Trocas"">
                        </a>
                    </div>
                </div>
            </div>
        </div>



        <!--Últimos Clientes-->
        <div class=""container mt-5"">
            <!--Box ultimos clientes-->
            <div class=""info-wrap"" style="" border-radius:20px; text-align: center;"">
                <h5><strong style=""  color: rgb(13, 236, 181);"">Últimos Clientes cadastrados </strong></h5><br>");
                WriteLiteral(@"

                <div class=""row"" style=""text-align: center;"">
                    <div class=""col-lg-12 col-md-2 form-group mt-3 mt-md-0"" id=""comb-form"" readonly>
                        <table class=""table table-hover col-lg-10"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Código</th>
                                    <th scope=""col"">Nome</th>
                                    <th scope=""col"">CPF</th>
                                    <th scope=""col"">Data de Nascimento</th>
                                    <th scope=""col"">Status</th>
                                    <th scope=""col""></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <th scope=""row"">98</th>
                                    <td>João da Silva</td>
                                    <td>123.123.");
                WriteLiteral(@"123-12</td>
                                    <td>12/07/1990</td>
                                    <td>Ativo</td>
                                    <td><button class=""btn btn-warning btn-sm"">Inativar</button></td>
                                </tr>

                                <tr>
                                    <th scope=""row"">97</th>
                                    <td>Maria Soares</td>
                                    <td>123.455.673-92</td>
                                    <td>24/07/1989</td>
                                    <td>Ativo</td>
                                    <td><button class=""btn btn-warning btn-sm"">Inativar</button></td>
                                </tr>

                                <tr>
                                    <th scope=""row"">96</th>
                                    <td>Pedro Luks Carvalho</td>
                                    <td>456.876.789-95</td>
                                    <td>09/12/1978</td>
   ");
                WriteLiteral(@"                                 <td>Inativo</td>
                                    <td><button class=""btn btn-success btn-sm"">Ativar</button></td>
                                </tr>

                            </tbody>
                        </table>
                        <a href=""admin-procurar-cliente.html""><button class=""col-lg-12 btn btn-dark btn-sm"" style=""color: white;"">Ver Todos</button></a>
                    </div>
                </div>
            </div>
        </div>

        <!--Últimos Pedidos-->
        <div class=""container mt-5"">
            <!--Box ultimos pedidos-->
            <div class=""info-wrap"" style="" border-radius:20px; text-align: center;"">
                <h5><strong style=""  color: rgb(13, 236, 181);"">Últimos pedidos </strong></h5><br>

                <div class=""row"" style=""text-align: center;"">
                    <div class=""col-lg-12 col-md-2 form-group mt-3 mt-md-0"" id=""comb-form"" readonly>
                        <table class=""table table-ho");
                WriteLiteral(@"ver col-lg-10"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Código</th>
                                    <th scope=""col"">Data</th>
                                    <th scope=""col"">Qtd Itens</th>
                                    <th scope=""col"">Valor</th>
                                    <th scope=""col"">Status</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <th scope=""row"">123</th>
                                    <td>18/03/2022</td>
                                    <td>2</td>
                                    <td>R$ 1990,00</td>
                                    <td>Aguardando Pagamento</td>
                                </tr>

                                <tr>
                                    <th scope=""row"">122</th>
                       ");
                WriteLiteral(@"             <td>18/03/2022</td>
                                    <td>1</td>
                                    <td>R$ 390,00</td>
                                    <td>Aguardando Entrega</td>
                                </tr>

                                <tr>
                                    <th scope=""row"">121</th>
                                    <td>16/03/2022</td>
                                    <td>4</td>
                                    <td>R$ 890,00</td>
                                    <td>Entrega Concluída</td>
                                </tr>

                            </tbody>
                        </table>
                        <a href=""admin-procurar-pedido.html""><button class=""col-lg-12 btn btn-dark btn-sm"" style=""color: white;"">Ver Todos</button></a>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- ======= Footer ======= -->
    <footer id=""footer"">
        <header id=""");
                WriteLiteral(@"header"" class=""d-flex align-items-center"" style=""margin-top: 200px;"">
        </header>
        <div class=""footer-top"" style=""margin-top: -90px;"">
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
                            <li>");
                WriteLiteral(@"<i class=""bx bx-chevron-right""></i> <a href=""#"">Sobre Nós</a></li>
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
                            <li><i class=");
                WriteLiteral(@"""bx bx-chevron-right""></i> <a href=""#"">Outlet</a></li>
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

        <div class=""container p");
                WriteLiteral(@"y-4"">
            <div class=""copyright"">
                &copy; Copyright <strong><span>RaellShoes</span></strong>. Todos os direitos reservados.
            </div>
            <div class=""credits"">
                Desenvolvido por <a href=""https://www.linkedin.com/in/israel-curvelo-0a9686173/"">Israel Curvelo</a>
            </div>
        </div>
    </footer><!-- End Footer -->

    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM""
            crossorigin=""anonymous""></script>



    <script>
        (function () {
            'use strict'

            // Fetch all the forms we want to apply custom Bootstrap validation styles to
            var forms = document.querySelectorAll('.needs-validation')

            // Loop over them and prevent submission
            Array.prototype.slice.call(forms)
                .forEach(function (form) {
        ");
                WriteLiteral(@"            form.addEventListener('submit', function (event) {
                        if (!form.checkValidity()) {
                            event.preventDefault()
                            event.stopPropagation()


                        }
                        form.classList.add('was-validated')
                    }, false)
                })
        })()
    </script>


    <!-- Vendor JS Files -->
    <script src=""assets/vendor/purecounter/purecounter.js""></script>
    <script src=""assets/vendor/aos/aos.js""></script>
    <script src=""assets/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""assets/vendor/glightbox/js/glightbox.min.js""></script>
    <script src=""assets/vendor/isotope-layout/isotope.pkgd.min.js""></script>
    <script src=""assets/vendor/swiper/swiper-bundle.min.js""></script>
    <script src=""assets/vendor/waypoints/noframework.waypoints.js""></script>
    <script src=""assets/vendor/php-email-form/validate.js""></script>

    <!-- Template M");
                WriteLiteral("ain JS File -->\r\n    <script src=\"assets/js/main.js\"></script>\r\n\r\n");
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
            BeginContext(22893, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RaellShoes.Models.ViewModel.AdminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
