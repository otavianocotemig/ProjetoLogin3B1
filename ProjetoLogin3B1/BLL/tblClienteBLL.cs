using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using ProjetoLogin3B1.DAL;
using ProjetoLogin3B1.DTO;

namespace ProjetoLogin3B1.BLL
{
    public class tblClienteBLL
    {
        private DALMysql daoBanco = new DALMysql();

        public Boolean Autenticar(string email, string senha)
        {
            string consulta = string.Format($@"select * from tbl_cliente where email_cliente = '{email}' and senha_cliente = '{senha}';");
            DataTable dt = daoBanco.ExecutarConsulta(consulta);
            if (dt.Rows.Count == 1)
            {
               return true;
                
            }
            else
            {
                return false;
            }
        }

        // Metodo para recuperar senha do usuario
        public string RecuperarSenha(string email)
        {
            string consulta = string.Format($@"select * from tbl_cliente where email_cliente = '{email}';");
            DataTable dt = daoBanco.ExecutarConsulta(consulta);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0]["senha_cliente"].ToString();
            }
            else
            {
                return "Usuário não Localizado.";
            }

        }

        public string RecuperarTipoUsuario(string email)
        {
            string consulta = string.Format($@"select * from tbl_cliente where email_cliente = '{email}';");
            DataTable dt = daoBanco.ExecutarConsulta(consulta);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0]["tp_usuario"].ToString();
            }
            else
            {
                return "Usuário não Localizado.";
            }

         }

        // Metodo para Listar Clientes pelo Email
        public DataTable ListarClientes(string email)
        {
            string sql = string.Format($@"select * from tbl_cliente where email_cliente = '{email}';");
            return daoBanco.ExecutarConsulta(sql);
        }
        // Metodo para Listar Todos os clientes
        public DataTable ListarClientes()
        {
            string sql = string.Format($@"select * from tbl_cliente");
            return daoBanco.ExecutarConsulta(sql);
        }
        // Metodo para Pesquisar Clientes no banco de dados - Por Nome - Por Sobrenome - Por Email
        public DataTable PesquisarClientes(string condicao)
        {
            string sql = string.Format($@"select * from tbl_cliente where " + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }
        // Para alterar o cliente
        public void AlterarCliente(tblClienteDTO dtoCliente)
        {
            string sql = string.Format($@"UPDATE tbl_cliente set nome_cliente = '{dtoCliente.Nome_cliente}',
                                                                 sobrenome_cliente = '{dtoCliente.Sobrenome_cliente}',
                                                                 cpf_cliente = '{dtoCliente.Cpf_cliente}',
                                                                 senha_cliente = '{dtoCliente.Senha_cliente}',
                                                                 cep = '{dtoCliente.Cep}',
                                                                 endereco = '{dtoCliente.Endereco}'
                                                  where email_cliente = '{dtoCliente.Email_cliente}';");
            daoBanco.executarComando(sql);

        }
        // Metodo para Inserir o cliente na tabela
        public void InserirCliente(tblClienteDTO dtocliente)
        {
            string sql = string.Format($@"INSERT INTO tbl_cliente VALUES (NULL, '{dtocliente.Nome_cliente}',
                                                                               '{dtocliente.Sobrenome_cliente}', 
                                                                               '{dtocliente.Email_cliente}',
                                                                                '{dtocliente.Senha_cliente}',
                                                                                '{dtocliente.Cpf_cliente}',
                                                                                '{dtocliente.Tp_usuario}',
                                                                                 '{dtocliente.Cep}', 
                                                                                  '{dtocliente.Endereco}'  );");
            daoBanco.executarComando(sql);

        }
        // Metodo para excluir Cliente
        public void ExcluirCliente(tblClienteDTO dtocliente)
        {
            string sql = string.Format($@"DELETE FROM tbl_cliente where id_cliente = {dtocliente.Id_cliente};");
            daoBanco.executarComando(sql);
        }

    }
}