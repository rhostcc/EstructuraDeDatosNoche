using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCola.clases;

namespace AppCola.formularios
{
    public partial class FormDocumento : Form
    {
        public FormDocumento()
        {
            InitializeComponent();
            AgregarTipos();
        }
        public void AgregarTipos()
        {
            comboTipos.Items.Add(new TipoDocumento() { Nombre = "Documento de word", Extension = ".docx", Programa = "Microsoft Word" });
            comboTipos.Items.Add(new TipoDocumento() { Nombre = "Documento de excel", Extension = ".xlsx", Programa = "Microsoft Excel" });
            comboTipos.Items.Add(new TipoDocumento() { Nombre = "Documento de texto", Extension = ".txt", Programa = "Block de notas" });
            comboTipos.DisplayMember = "Nombre";
        }

        private void buttonEnqueue_Click(object sender, EventArgs e)
        {
            Documento docNuevo = new Documento();
            docNuevo.Nombre = textNombre.Text;
            docNuevo.CantidadPaginas = int.Parse(textPaginas.Text);
            docNuevo.Tipo = (TipoDocumento)comboTipos.SelectedItem;
            docNuevo.Tamano = int.Parse(textTamano.Text);
            FormInicio.NuevoDocumento = docNuevo;
            this.Close();
        }
    }
}
