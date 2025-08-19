namespace AppCola.formularios
{
    partial class FormInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoTipoDeDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.documentoToolStripMenuItem,
            this.tipoDeDocumentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem,
            this.cancelarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            // 
            // documentoToolStripMenuItem
            // 
            this.documentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDocumentoToolStripMenuItem});
            this.documentoToolStripMenuItem.Name = "documentoToolStripMenuItem";
            this.documentoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.documentoToolStripMenuItem.Text = "Documento";
            // 
            // nuevoDocumentoToolStripMenuItem
            // 
            this.nuevoDocumentoToolStripMenuItem.Name = "nuevoDocumentoToolStripMenuItem";
            this.nuevoDocumentoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.nuevoDocumentoToolStripMenuItem.Text = "Nuevo documento";
            this.nuevoDocumentoToolStripMenuItem.Click += new System.EventHandler(this.nuevoDocumentoToolStripMenuItem_Click);
            // 
            // tipoDeDocumentoToolStripMenuItem
            // 
            this.tipoDeDocumentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoTipoDeDocumentoToolStripMenuItem});
            this.tipoDeDocumentoToolStripMenuItem.Name = "tipoDeDocumentoToolStripMenuItem";
            this.tipoDeDocumentoToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.tipoDeDocumentoToolStripMenuItem.Text = "Tipo de documento";
            // 
            // nuevoTipoDeDocumentoToolStripMenuItem
            // 
            this.nuevoTipoDeDocumentoToolStripMenuItem.Name = "nuevoTipoDeDocumentoToolStripMenuItem";
            this.nuevoTipoDeDocumentoToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.nuevoTipoDeDocumentoToolStripMenuItem.Text = "Nuevo tipo de documento";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 171);
            this.dataGridView1.TabIndex = 1;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(631, 201);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(25, 13);
            this.labelCantidad.TabIndex = 2;
            this.labelCantidad.Text = "111";
            this.labelCantidad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 223);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoTipoDeDocumentoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
    }
}