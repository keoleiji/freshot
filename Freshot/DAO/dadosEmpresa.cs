using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshot.DAO
{
    class DadosEmpresa
    {
        string cnpj;
        string email;
        string senha;
        string nomeFantasia;
        string telefone;
        string cae;
        string logradouro;
        string num;
        string complemento;
        string cep;
        string bairro;
        string municipio;
        string uf;

        public DadosEmpresa()
        {

        }

        public DadosEmpresa(string cnpj, string email, string senha, string nomeFantasia, string telefone, string cae, string logradouro, string num, string complemento, string cep, string bairro, string municipio, string uf)
        {
            this.cnpj = cnpj;
            this.email = email;
            this.senha = senha;
            this.nomeFantasia = nomeFantasia;
            this.telefone = telefone;
            this.cae = cae;
            this.logradouro = logradouro;
            this.num = num;
            this.complemento = complemento;
            this.cep = cep;
            this.bairro = bairro;
            this.municipio = municipio;
            this.uf = uf;
        }

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cae { get => cae; set => cae = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Num { get => num; set => num = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public string Uf { get => uf; set => uf = value; }
    }
}
