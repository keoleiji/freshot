using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Freshot.abas.login;
using Freshot.DAO;

namespace Freshot.abas.telas.cliente
{
    public partial class UcClienteEdit : UserControl
    {
        //Form1 uc = new Form1();
        private MySqlConnection con;
        private string configurationDeConexao =
          "Server=localhost;" +
          "Database=freshotdb;" +
          "Uid=root;" +
          "Password=root";

        public UcClienteEdit()
        {
            InitializeComponent();
            con = new MySqlConnection(configurationDeConexao);
            
        }

        public void lerDados()
        {
            /*
            MySqlCommand comando = con.CreateCommand();
            comando.CommandText = "SELECT * FROM dadosclientes where dadosclientes.usuario = @usuario";

            System.Console.WriteLine(uc.session);
            comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = uc.session;

            try
            {
                MySqlDataReader dr = comando.ExecuteReader();
                usuarioC.Text = Convert.ToString(dr["usuario"]);
                data.Text = Convert.ToString(dr["data"]);
                doencas.Text = Convert.ToString(dr["doencas"]);
                medicamentos.Text = Convert.ToString(dr["medicamentos"]);
                convenio.Text = Convert.ToString(dr["convenio"]);
                alimentacao.Text = Convert.ToString(dr["alimentacao"]);
                eliminacoes.Text = Convert.ToString(dr["eliminacoes"]);
                banho.Text = Convert.ToString(dr["banho"]);
                cpf.Text = Convert.ToString(dr["cpf"]);
                labelreg.Visible = false;
                gravar.Visible = false;
                panelUD.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
            */

        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
