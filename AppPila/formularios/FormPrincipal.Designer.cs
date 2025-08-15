namespace AppPila.formularios
{
    partial class FormPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPush = new System.Windows.Forms.Button();
            this.checkSSL = new System.Windows.Forms.CheckBox();
            this.textContenido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNavUrl = new System.Windows.Forms.TextBox();
            this.textNavContenido = new System.Windows.Forms.TextBox();
            this.buttonPop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPush);
            this.groupBox1.Controls.Add(this.checkSSL);
            this.groupBox1.Controls.Add(this.textContenido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textURL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la pagina";
            // 
            // buttonPush
            // 
            this.buttonPush.Location = new System.Drawing.Point(68, 92);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(116, 23);
            this.buttonPush.TabIndex = 5;
            this.buttonPush.Text = "Visitar pagina";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // checkSSL
            // 
            this.checkSSL.AutoSize = true;
            this.checkSSL.Location = new System.Drawing.Point(68, 69);
            this.checkSSL.Name = "checkSSL";
            this.checkSSL.Size = new System.Drawing.Size(82, 17);
            this.checkSSL.TabIndex = 4;
            this.checkSSL.Text = "Tiene SSL?";
            this.checkSSL.UseVisualStyleBackColor = true;
            // 
            // textContenido
            // 
            this.textContenido.Location = new System.Drawing.Point(68, 43);
            this.textContenido.Name = "textContenido";
            this.textContenido.Size = new System.Drawing.Size(163, 20);
            this.textContenido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contenido";
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(68, 17);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(163, 20);
            this.textURL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // textNavUrl
            // 
            this.textNavUrl.Location = new System.Drawing.Point(345, 6);
            this.textNavUrl.Name = "textNavUrl";
            this.textNavUrl.Size = new System.Drawing.Size(348, 20);
            this.textNavUrl.TabIndex = 1;
            // 
            // textNavContenido
            // 
            this.textNavContenido.Location = new System.Drawing.Point(278, 32);
            this.textNavContenido.Multiline = true;
            this.textNavContenido.Name = "textNavContenido";
            this.textNavContenido.Size = new System.Drawing.Size(415, 264);
            this.textNavContenido.TabIndex = 2;
            // 
            // buttonPop
            // 
            this.buttonPop.Location = new System.Drawing.Point(278, 4);
            this.buttonPop.Name = "buttonPop";
            this.buttonPop.Size = new System.Drawing.Size(61, 23);
            this.buttonPop.TabIndex = 3;
            this.buttonPop.Text = "< Atras";
            this.buttonPop.UseVisualStyleBackColor = true;
            this.buttonPop.Click += new System.EventHandler(this.buttonPop_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 307);
            this.Controls.Add(this.buttonPop);
            this.Controls.Add(this.textNavContenido);
            this.Controls.Add(this.textNavUrl);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textContenido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.CheckBox checkSSL;
        private System.Windows.Forms.TextBox textNavUrl;
        private System.Windows.Forms.TextBox textNavContenido;
        private System.Windows.Forms.Button buttonPop;
    }
}