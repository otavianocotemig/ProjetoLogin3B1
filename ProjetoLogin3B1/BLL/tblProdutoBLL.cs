using ProjetoLogin3B1.DAL;
using ProjetoLogin3B1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoLogin3B1.BLL
{
    public class tblProdutoBLL
    {
        private DALMysql daoBanco = new DALMysql();
        // Pesquisar Produtos
        public DataTable PesquisarProdutos(string condicao)
        {
            string sql = string.Format($@"select p.id , p.nomeProduto, p.descricao, p.preco, p.quantidade, c.descricao as Categoria, f.nome as Fornecedor from tbl_produto p, tbl_categoria c, tbl_fornecedor f where p.tbl_categoria_id=c.id and p.tbl_fornecedor_id = f.id and " + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }
        // Metodo para Excluir Produto
        public void ExcluirProduto(tblProdutoDTO dtoProduto)
        {
            string sql = string.Format($@"DELETE FROM tbl_produto where id = {dtoProduto.Id};");
            daoBanco.executarComando(sql);
        }
    }
}