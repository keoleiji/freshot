using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freshot.DAO
{
    class DadosEmpresaDAO
    {
        public MySqlConnection con;
        private string configurationDeConexao =
          "Server=localhost;" +
          "Database=freshotdb;" +
          //"Port=3306" +
          "Uid=root;" +
          "Password=root";
          //"SslMode=yes;";

        public DadosEmpresaDAO(MySqlConnection con)
        {
            this.con = con;
        }
        public DadosEmpresaDAO()
        {
            con = new MySqlConnection(configurationDeConexao);
        }
        public MySqlConnection Conn { get => con; set => con = value; }
        public bool create(DadosEmpresa dadosEmpresa)
        {

            try
            {
                con.Open();
                MySqlCommand comando = con.CreateCommand();
                comando.CommandText = "insert into dadosempresa values(@cnpj,@email,@senha,@nomeFantasia,@telefone,@cae,@logradouro,@num,@complemento,@cep,@bairro,@municipio,@uf)";
                comando.Parameters.AddWithValue("@cnpj", dadosEmpresa.Cnpj);
                comando.Parameters.AddWithValue("@email", dadosEmpresa.Email);
                comando.Parameters.AddWithValue("@senha", dadosEmpresa.Senha);
                comando.Parameters.AddWithValue("@nomeFantasia", dadosEmpresa.NomeFantasia);
                comando.Parameters.AddWithValue("@telefone", dadosEmpresa.Telefone);
                comando.Parameters.AddWithValue("@cae", dadosEmpresa.Cae);
                comando.Parameters.AddWithValue("@logradouro", dadosEmpresa.Logradouro);
                comando.Parameters.AddWithValue("@num", dadosEmpresa.Num);
                comando.Parameters.AddWithValue("@complemento", dadosEmpresa.Complemento);
                comando.Parameters.AddWithValue("@cep", dadosEmpresa.Cep);
                comando.Parameters.AddWithValue("@bairro", dadosEmpresa.Bairro);
                comando.Parameters.AddWithValue("@municipio", dadosEmpresa.Municipio);
                comando.Parameters.AddWithValue("@uf", dadosEmpresa.Uf);
                


                comando.ExecuteNonQuery();
                MessageBox.Show(dadosEmpresa.NomeFantasia + " adicionada!");

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

        public List<DadosEmpresa> readAll(string cnpj, string senha)
        {
            con.Open();

            MySqlCommand comando = con.CreateCommand();
            comando.CommandText = "select * from dadosempresa where cnpj=@cnpj and senha=@senha";
            comando.Parameters.AddWithValue("@cnpj", cnpj);
            comando.Parameters.AddWithValue("@senha", senha);
            List<DadosEmpresa> listaDeUsuarios = new List<DadosEmpresa>();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                DadosEmpresa tempAluno = new DadosEmpresa
                (
                    reader.GetString("cnpj"),
                    reader.GetString("email"),
                    reader.GetString("senha"),
                    reader.GetString("nomeFantasia"),
                    reader.GetString("telefone"),
                    reader.GetString("cae"),
                    reader.GetString("logradouro"),
                    reader.GetString("num"),
                    reader.GetString("complemento"),
                    reader.GetString("cep"),
                    reader.GetString("bairro"),
                    reader.GetString("municipio"),
                    reader.GetString("uf")

                );
                listaDeUsuarios.Add(tempAluno);
            }
            con.Close();
            return listaDeUsuarios;
        }
        public DadosEmpresa readDado(string cnpj)
        {
            try
            {
                DadosEmpresa dadosTemp = new DadosEmpresa();
                con.Open();
                MySqlCommand comando = con.CreateCommand();
                comando.CommandText = "select * from usuario where cnpj=@cnpj";
                comando.Parameters.AddWithValue("@cnpj", cnpj);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    dadosTemp.Cnpj = reader.GetString("cnpj");
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
