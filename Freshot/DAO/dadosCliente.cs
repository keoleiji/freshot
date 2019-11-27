using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshot.DAO
{
    class DadosCliente
    {
        string usuario;
        string email;
        string senha;
        string dataNasc;
        string sexo;
        string profissao;
        string formacao;
        string escolaridade;
        string estadoCivil;
        string tempoLivre;
        string interesses;

        public DadosCliente()
        {

        }
        public DadosCliente(string usuario, string email, string senha, string dataNasc, string sexo, string profissao, string formacao, string escolaridade, string estadoCivil, string tempoLivre, string interesses)
        {
            this.usuario = usuario;
            this.email = email;
            this.senha = senha;
            this.dataNasc = dataNasc;
            this.sexo = sexo;
            this.profissao = profissao;
            this.formacao = formacao;
            this.escolaridade = escolaridade;
            this.estadoCivil = estadoCivil;
            this.tempoLivre = tempoLivre;
            this.interesses = interesses;
        }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string DataNasc { get => dataNasc; set => dataNasc = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Profissao { get => profissao; set => profissao = value; }
        public string Formacao { get => formacao; set => formacao = value; }
        public string Escolaridade { get => escolaridade; set => escolaridade = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string TempoLivre { get => tempoLivre; set => tempoLivre = value; }
        public string Interesses { get => interesses; set => interesses = value; }
    }
}
