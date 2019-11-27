using Freshot.abas.cadastro.cliente;
using Freshot.abas.cadastro.empresa;
using Freshot.abas.login;
using Freshot.abas.telas.cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshot.abas
{
    class abasControl
    {
        UserControl1 UcLogin = new UserControl1();
        UcEmpresa UcEmpresa = new UcEmpresa();
        UcCliente UcCliente = new UcCliente();
        UcClienteEdit ucClienteEdit = new UcClienteEdit();

        public UserControl1 UcLogin1 { get => UcLogin; set => UcLogin = value; }
        public UcEmpresa UcEmpresa1 { get => UcEmpresa; set => UcEmpresa = value; }
        public UcCliente UcCliente1 { get => UcCliente; set => UcCliente = value; }
        public UcClienteEdit UcClienteEdit { get => ucClienteEdit; set => ucClienteEdit = value; }
    }
}
