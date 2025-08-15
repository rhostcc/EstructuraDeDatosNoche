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
            if (this.firefox.IsEmpty())
            {
                textNavUrl.Text = "Pagina de inicio";
                textNavContenido.Text = "Favoritos";
            }
            else
            {
                Navegador temp = firefox.Peek();
                textNavUrl.Text = temp.MostrarInformacion().Split('@')[0];
                textNavContenido.Text = temp.MostrarInformacion().Split('@')[1];
            }
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            if (!this.firefox.IsFull())
            {
                Navegador nuevaPagina = new Navegador(textURL.Text, textContenido.Text);
                SSL certificadoPagina = checkSSL.Checked ? new SSL(nuevaPagina.URL) : null;
                nuevaPagina.Certificado = certificadoPagina;
                firefox.Push(nuevaPagina);
                this.ActualizarPagina();
            } else {
                MessageBox.Show("La pila esta llena, no se puede agregar");
            }
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            if(this.firefox.IsEmpty())
            {
                MessageBox.Show("No se puede retroceder mas");
            } else
            {
                this.firefox.Pop();
                this.ActualizarPagina();
            }
        }
    }
}
