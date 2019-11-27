using Freshot.abas;
using Freshot.abas.login;
using Freshot.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freshot
{
    public partial class Form1 : Form
    {
        UserControl1 userControl1 = new UserControl1();
        abasControl abasControl = new abasControl();
        DadosEmpresa dadosEmpresa = new DadosEmpresa();
        private MySqlConnection con;
        private string configurationDeConexao =
          "Server=localhost;" +
          "Database=freshotdb;" +
          //"Port=3306" +
          "Uid=root;" +
          "Password=root";
        //"SslMode=yes;";
        public Form1()
        {
            InitializeComponent();
            changePanel(abasControl.UcLogin1);
            con = new MySqlConnection(configurationDeConexao);
        }

        public void changePanel(UserControl a)
        {
            if (!panelChange.Controls.Contains(a))
            {
                panelChange.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.BringToFront();
            }
            else
            {
                a.BringToFront();
            }
        }

        private void Close_MouseHover(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelChange_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        public void logarEmpresa(string cnpj, string senha)
        {
            DadosEmpresaDAO dao = new DadosEmpresaDAO(this.con);
            List<DadosEmpresa> usuarios = dao.readAll(cnpj, senha);
            if (usuarios.Count == 0)
            {
                userControl1.textBox1.Text = "usuário ou senha incorretos";
                MessageBox.Show("usuário ou senha incorretos");
            }
            else
            {
                userControl1.textBox1.Visible = true;
                DadosEmpresa meuCadastro = usuarios[0];
                MessageBox.Show("Bem vindo ao sistema Freshot!");

                /*dadosEmpresa = dao.readDado(usuario);
                sair.Visible = true;
                relGer.Visible = true;
                criarRe.Visible = true;
                criarIdoso.Visible = true;

                changePanel(abasControl.CriarIdoso);*/
            }

        }

        public void logarCliente(string usuario, string senha)
        {
            DadosClienteDAO dao = new DadosClienteDAO(this.con);
            List<DadosCliente> usuarios = dao.readAll(usuario, senha);
            if(usuarios.Count == 0)
            {
                MessageBox.Show("usuário ou senha incorretos"); 
            }
            else
            { 
                userControl1.textBox1.Visible = true;
                DadosCliente meuCadastro = usuarios[0];
                MessageBox.Show("Bem vindo ao sistema Freshot!");
                changePanel(abasControl.UcClienteEdit);
            }
        }

        public void cadastrarEmpresa()
        {
            changePanel(abasControl.UcEmpresa1);
        }

        public void cadastrarCliente()
        {
            changePanel(abasControl.UcCliente1);
        }

        public void voltar()
        {
            changePanel(abasControl.UcLogin1);
        }

    }
}
