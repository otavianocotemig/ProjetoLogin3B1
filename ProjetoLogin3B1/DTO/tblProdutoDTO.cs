using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLogin3B1.DTO
{
    public class tblProdutoDTO
    {

        private int id, tbl_categoria_id, tbl_fornecedor_id, quantidade;
        private String nomeProduto, descricao, foto;
        private Double preco, peso;

        public int Id { get => id; set => id = value; }
        public int Tbl_fornecedor_id { get => tbl_fornecedor_id; set => tbl_fornecedor_id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco { get => preco; set => preco = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Foto { get => foto; set => foto = value; }

        public string NomeProduto
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeProduto = value;
                }
                else
                {
                    throw new Exception("O campo Nome do Produto é obrigatório.");
                }
            }
            get { return this.nomeProduto; }
        }
        public int Quantidade
        {
            set
            {
                if (value != 0)
                {
                    this.quantidade = value;
                }
                else
                {
                    throw new Exception("O campo Quantidade do Produto é obrigatório.");
                }
            }
            get { return this.quantidade; }
        }

        public int Tbl_categoria_id
        {
            set
            {
                if (value != 0)
                {
                    this.tbl_categoria_id = value;
                }
                else
                {
                    throw new Exception("O campo Categoria  do Produto é obrigatório.");
                }
            }
            get { return this.tbl_categoria_id; }
        }

      
    }
}