using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Freshot.DAO;
using MySql.Data.MySqlClient;

namespace Freshot.abas.cadastro.empresa
{
    public partial class UcEmpresa : UserControl
    {
        private MySqlConnection con;
        private string configurationDeConexao =
          "Server=localhost;" +
          "Database=freshotdb;" +
          //"Port=3306"+
          "Uid=root;" +
          "Password=root";
          //"SslMode=yes;";

        public UcEmpresa()
        {
            InitializeComponent();
            con = new MySqlConnection(configurationDeConexao);
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField10_Click(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField9_Click(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField8_Click(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField4_Click(object sender, EventArgs e)
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

        private void MaterialSingleLineTextField7_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField6_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void Panel10_Paint(object sender, PaintEventArgs e)
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

        private void GroupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void Panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ((Form1)this.Parent.Parent).cadastrarCliente();
        }

        private void Panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = con.CreateCommand();
            con.Open();
            con.Close();
            try
            {
                
                DadosEmpresaDAO dao = new DadosEmpresaDAO(con);
                DadosEmpresa dadosEmpresa = new DadosEmpresa(
                cnpj.Text,
                email.Text,
                senha.Text,
                nomeFantasia.Text,
                tel.Text,
                cae.Text,
                logradouro.Text,
                num.Text,
                complemento.Text,
                cep.Text,
                bairro.Text,
                municipio.Text,
                uf.Text
                );
                //DadosEmpresa dadosEmpresa = new Dados(); dados = ((Form1)this.Parent.Parent).getDados();
                dao.create(dadosEmpresa);
                
                
            }
            catch(MySqlException err)
            {
                MessageBox.Show("" + err);
            }
            
        }

        private void Panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ((Form1)this.Parent.Parent).voltar();
        }

        private void Panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField15_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField14_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField13_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField12_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField11_Click(object sender, EventArgs e)
        {

        }

        private void Panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField7_Click_1(object sender, EventArgs e)
        {

        }

        private void UcEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
