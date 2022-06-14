using RaellShoes.Models;
using RaellShoes.Models.Administrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Strategy
{
    public class ValidarDadosProduto : IStrategy
    {
        public string Processar(EntidadeDominio entidadeDominio)
        {
            if (!entidadeDominio.GetType().Name.ToLower().Equals("produto"))
                return "Objeto diferente do esperado";

            Produto produto = (Produto)entidadeDominio;

            if(produto.Nome == null || produto.Marca == null || produto.Marca == Models.Enums.Marca.Selecione || produto.Modelo == null
                || produto.CorPrimariaProduto == null || produto.CorPrimariaProduto == Models.Enums.CorPrimariaProduto.Selecione
                || produto.Genero == null || produto.Genero == Models.Enums.GeneroProduto.Selecione || produto.Status == null || produto.Status == Models.Enums.Status.Selecione
                || produto.Tamanho == null || produto.Tamanho == Models.Enums.Tamanho.Selecione || produto.GrupoPrecificacao == null 
                || produto.Valor == null || produto.Valor <= 0 || produto.DataCadastro == null || produto.Categoria == null
                || produto.CodigoBarra == null || produto.Quantidade == null || produto.Quantidade <=0 || produto.Fornecedor ==null
                || produto.URLFoto == null || produto.Descricao == null)
                return "Campos obrigatórios de produto não preenchidos";

            if(produto.FichaTecnica.Material == null || produto.FichaTecnica.Palmilha == null || produto.FichaTecnica.Solado == null
                || produto.FichaTecnica.GarantiaMeses ==null || produto.FichaTecnica.GarantiaMeses < 0 || produto.FichaTecnica.Limpeza == null
                || produto.FichaTecnica.Altura == null || produto.FichaTecnica.Altura == Models.Enums.Altura.Selecione || produto.FichaTecnica.Cuidados == null)
                return "Campos obrigatórios de ficha técnica não preenchidos";

            return null;
        }
    }
}
