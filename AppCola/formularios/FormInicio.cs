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
    public partial class FormInicio : Form
    {
        public static Documento NuevoDocumento;
        public Cola<Documento> colaDeImpresion;
        public FormInicio()
        {
            InitializeComponent();
            this.colaDeImpresion = new Cola<Documento>(5);
            dataGridView1.Columns.Add("Nombre", "Nombre del documento");
            dataGridView1.Columns.Add("Paginas", "Num. paginas");
            dataGridView1.Columns.Add("Tipo", "Extension");
            dataGridView1.Columns.Add("Fecha inicio", "Fecha de inicio");
            dataGridView1.Columns.Add("Tamano", "Tamano");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ActualizarCantidad();
        }

        private void nuevoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormDocumento().ShowDialog();
            colaDeImpresion.Enqueue(NuevoDocumento);
            ActualizarDGV(TipoDGV.Incrementar);
            ActualizarCantidad();
        }
        public enum TipoDGV
        {
            Incrementar,
            Decrementar
        }
        public void ActualizarDGV(TipoDGV tipo)
        {
            if(tipo == TipoDGV.Incrementar)
                dataGridView1.Rows.Add(NuevoDocumento.Nombre, NuevoDocumento.CantidadPaginas
                , NuevoDocumento.Tipo.Extension, NuevoDocumento.FechaInicio, NuevoDocumento.Tamano);
            else
                dataGridView1.Rows.RemoveAt(0);
        }
        public void ActualizarCantidad()
        {
            labelCantidad.Text = $"{this.colaDeImpresion.Count()}/{this.colaDeImpresion.Size()}";
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colaDeImpresion.Dequeue();
            ActualizarDGV(TipoDGV.Decrementar);
            ActualizarCantidad();
        }
    }
}
