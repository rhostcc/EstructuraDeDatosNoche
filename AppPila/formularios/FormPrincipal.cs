using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppPila.clases;

namespace AppPila.formularios
{
    public partial class FormPrincipal : Form
    {
        private Pila<Navegador> firefox;
        public FormPrincipal()
        {
            InitializeComponent();
            this.firefox = new Pila<Navegador>(5);
        }
        public void ActualizarPagina()
        {
            Navegador temp = firefox.Peek();
            textNavUrl.Text = temp.MostrarInformacion().Split('@')[0];
            textNavContenido.Text = temp.MostrarInformacion().Split('@')[1];
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            Navegador nuevaPagina = new Navegador(textURL.Text, textContenido.Text);
            SSL certificadoPagina = checkSSL.Checked ? new SSL(nuevaPagina.URL) : null;
            nuevaPagina.Certificado = certificadoPagina;
            firefox.Push(nuevaPagina);
            this.ActualizarPagina();
        }
    }
}
