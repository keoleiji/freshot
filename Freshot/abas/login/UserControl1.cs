using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freshot.abas.login
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void PanelChange_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (clienteRadio.Checked == true)
            {
                ((Form1)this.Parent.Parent).logarCliente(usuario.Text, senha.Text);
            }
            else if(empresaRadio.Checked == true)
            {
                ((Form1)this.Parent.Parent).logarEmpresa(usuario.Text, senha.Text);
            }
            else
            {
                MessageBox.Show("Escolha uma opção de login");
            }
            usuario.Text = "";
            senha.Text = "";
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            ((Form1)this.Parent.Parent).cadastrarEmpresa();
        }

        private void LoginE_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }
    }
}
