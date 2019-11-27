using Freshot.abas.login;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freshot.DAO
{
    class DadosClienteDAO
    {
        UserControl1 uc = new UserControl1();
        public MySqlConnection con;
        private string configurationDeConexao =
          "Server=localhost;" +
          "Database=freshotdb;" +
          //"Port=3306" +
          "Uid=root;" +
          "Password=root";
        //"SslMode=yes;";

        public DadosClienteDAO(MySqlConnection con)
        {
            this.con = con;
        }
        public DadosClienteDAO()
        {
            con = new MySqlConnection(configurationDeConexao);
        }
        public MySqlConnection Conn { get => con; set => con = value; }

        public bool create(DadosCliente dadosCliente)
        {

            try
            {
                con.Open();
                MySqlCommand comando = con.CreateCommand();
                comando.CommandText = "insert into dadoscliente values(@usuario,@email,@senha,@dataNasc,@sexo,@profissao,@formacao,@escolaridade,@estadoCivil,@tempoLivre,@interesses)";
                comando.Parameters.AddWithValue("@usuario", dadosCliente.Usuario);
                comando.Parameters.AddWithValue("@email", dadosCliente.Email);
                comando.Parameters.AddWithValue("@senha", dadosCliente.Senha);
                comando.Parameters.AddWithValue("@dataNasc", dadosCliente.DataNasc);
                comando.Parameters.AddWithValue("@sexo", dadosCliente.Sexo);
                comando.Parameters.AddWithValue("@profissao", dadosCliente.Profissao);
                comando.Parameters.AddWithValue("@formacao", dadosCliente.Formacao);
                comando.Parameters.AddWithValue("@escolaridade", dadosCliente.Escolaridade);
                comando.Parameters.AddWithValue("@estadoCivil", dadosCliente.EstadoCivil);
                comando.Parameters.AddWithValue("@tempoLivre", dadosCliente.TempoLivre);
                comando.Parameters.AddWithValue("@interesses", dadosCliente.Interesses);

                comando.ExecuteNonQuery();
                MessageBox.Show(dadosCliente.Usuario + " adicionada!");

                con.Close();
                return true;

            }
            catch (MySqlException err)
            {

                MessageBox.Show("" + err);
                con.Close();
                return false;

            }
        }

        public List<DadosCliente> readAll(string usuario, string senha)
        {
            con.Open();

            MySqlCommand comando = con.CreateCommand();
            comando.CommandText = "select * from dadoscliente where usuario=@usuario and senha=@senha";
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@senha", senha);
            List<DadosCliente> listaDeUsuarios = new List<DadosCliente>();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                DadosCliente tempAluno = new DadosCliente
                (
                    reader.GetString("usuario"),
                    reader.GetString("email"),
                    reader.GetString("senha"),
                    reader.GetString("dataNasc"),
                    reader.GetString("sexo"),
                    reader.GetString("profissao"),
                    reader.GetString("formacao"),
                    reader.GetString("escolaridade"),
                    reader.GetString("estadoCivil"),
                    reader.GetString("tempoLivre"),
                    reader.GetString("interesses")

                );
                listaDeUsuarios.Add(tempAluno);
            }
            con.Close();
            return listaDeUsuarios;
        }
        public DadosCliente readDado(string usuario)
        {
            try
            {
                DadosCliente dadosTemp = new DadosCliente();
                con.Open();
                MySqlCommand comando = con.CreateCommand();
                comando.CommandText = "select * from usuario where usuario=@usuario";
                comando.Parameters.AddWithValue("@usuario", usuario);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    dadosTemp.Usuario = reader.GetString("usuario");
                    dadosTemp.Senha = reader.GetString("senha");

                }
                con.Close();
                return dadosTemp;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("ERRO MMYSQL" + erro);
                return null;
            }
        }

    }
}

