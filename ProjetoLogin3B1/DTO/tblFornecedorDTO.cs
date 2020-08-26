using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLogin3B1.DTO
{
    public class tblFornecedorDTO
    {
        private int id;
        private string nome;
        private string email;
        private string telefone;

        public int Id { get => id; set => id = value; }
        public string Nome {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O campo Nome é obrigatório.");
                }
            }
            get { return this.nome; }
        }
        public string Email
        {
            set
            {
                if (value != string.Empty)
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("O campo Email é obrigatório.");
                }
            }
            get { return this.email; }
        }
        public string Telefone 
        {
            set
            {
                if(value != string.Empty)
                {
                    this.telefone = value;
                }
                else
                {
                    throw new Exception("telefone é obrigatório");
                }
            }
            get
            {
                return this.telefone;
            }
        }
    }
}