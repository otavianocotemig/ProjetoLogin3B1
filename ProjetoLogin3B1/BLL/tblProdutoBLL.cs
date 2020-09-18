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
            string sql = string.Format($@"select p.id , p.nomeProduto, p.descricao, p.preco, p.quantidade, c.descricao as Categoria, f.nome as Fornecedor from tbl_produto p, tbl_categoria c, tbl_fornecedor f where p.tbl_categoria_id=c.id and p.tbl_fornecedor_id = f.id and " + condicao +" order by Id");
            return daoBanco.ExecutarConsulta(sql);
        }
        // Metodo para Excluir Produto
        public void ExcluirProduto(tblProdutoDTO dtoProduto)
        {
            string sql = string.Format($@"DELETE FROM tbl_produto where id = {dtoProduto.Id};");
            daoBanco.executarComando(sql);
        }
        //Metodo Utilizado para Incluir
        public void InserirProduto(tblProdutoDTO dtoProduto)
        {
            string sql = string.Format($@"INSERT INTO tbl_produto VALUES (NULL,'{dtoProduto.NomeProduto}',
                                                                               '{dtoProduto.Descricao}',   
                                                                               '{dtoProduto.Preco}',
                                                                               '{dtoProduto.Quantidade}',
                                                                               '{dtoProduto.Peso}',
                                                                               '{dtoProduto.Tbl_categoria_id}',
                                                                               '{dtoProduto.Tbl_fornecedor_id}');");

            daoBanco.executarComando(sql);

        }
        // Metodo para Consultar produto pelo ID
        public DataTable ConsultarProduto(int Id)
        {
            string sql = string.Format($@"select * from tbl_produto where id = " + Id + ";");
            return daoBanco.ExecutarConsulta(sql);
        }
        // Metodo para Alterar Produto
        public void AlterarProduto(tblProdutoDTO dtoProduto)
        {
            string sql = string.Format($@"UPDATE tbl_produto set nomeproduto = '{dtoProduto.NomeProduto}',
                                                                 descricao = '{dtoProduto.Descricao}',
                                                                 preco = '{dtoProduto.Preco}',
                                                                 quantidade = '{dtoProduto.Quantidade}',
                                                                 peso = '{dtoProduto.Peso}',
                                                                 tbl_categoria_id = '{dtoProduto.Tbl_categoria_id}',
                                                                 tbl_fornecedor_id  = '{dtoProduto.Tbl_fornecedor_id}'
                                                  where id = '{dtoProduto.Id}';");
            daoBanco.executarComando(sql);

        }
    }
}