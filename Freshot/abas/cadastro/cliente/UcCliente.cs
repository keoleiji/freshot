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
using Freshot.DAO;

namespace Freshot.abas.cadastro.cliente
{
    public partial class UcCliente : UserControl
    {
        private MySqlConnection con;
        private string configurationDeConexao =
          "Server=localhost;" +
          "Database=freshotdb;" +
          //"Port=3306"+
          "Uid=root;" +
          "Password=root";
        //"SslMode=yes;";
        public UcCliente()
        {
            InitializeComponent();
            con = new MySqlConnection(configurationDeConexao);
        }

        private void GroupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ((Form1)this.Parent.Parent).cadastrarEmpresa();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ((Form1)this.Parent.Parent).voltar();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = con.CreateCommand();
            con.Open();
            con.Close();
            try
            {

                DadosClienteDAO dao = new DadosClienteDAO(con);
                DadosCliente dadosCliente = new DadosCliente(
                usuarioC.Text,
                emailC.Text,
                senhaC.Text,
                dataC.Text,
                sexoC.Text,
                profissaoC.Text,
                formacaoC.Text,
                escolaridadeC.Text,
                estadoCivilC.Text,
                tempoLivreC.Text,
                interessesC.Text
                );
                //DadosCliente DadosCliente = new Dados(); dados = ((Form1)this.Parent.Parent).getDados();
                dao.create(dadosCliente);


            }
            catch (MySqlException err)
            {
                MessageBox.Show("" + err);
            }
        }

        private void Panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void InteressesC_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void TempoLivreC_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void EstadoCivilC_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void EscolaridadeC_Click(object sender, EventArgs e)
        {

        }

        private void Panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void FormacaoC_Click(object sender, EventArgs e)
        {

        }

        private void ProfissaoC_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void SexoC_Click(object sender, EventArgs e)
        {

        }

        private void Panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void DataC_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void ConfSenhaC_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void SenhaC_Click(object sender, EventArgs e)
        {

        }

        private void Panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ConfEmailC_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void EmailC_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UsuarioC_Click(object sender, EventArgs e)
        {

        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
