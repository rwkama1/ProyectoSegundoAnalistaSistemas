namespace ApEscritorio
{
    partial class FrmListadoLinQ
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnrusuario = new System.Windows.Forms.Button();
            this.btnusuespecifico = new System.Windows.Forms.Button();
            this.btncatespecifica = new System.Windows.Forms.Button();
            this.btnnespecifica = new System.Windows.Forms.Button();
            this.CBOlectores = new System.Windows.Forms.ComboBox();
            this.CBOnoticia = new System.Windows.Forms.ComboBox();
            this.CBOCategorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVComentarios = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVComentarios)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(805, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblerror
            // 
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(585, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "LISTAR COMENTARIOS DE USUARIOS LECTORES";
            // 
            // btnrusuario
            // 
            this.btnrusuario.Location = new System.Drawing.Point(188, 71);
            this.btnrusuario.Name = "btnrusuario";
            this.btnrusuario.Size = new System.Drawing.Size(113, 23);
            this.btnrusuario.TabIndex = 22;
            this.btnrusuario.Text = "ResumenUsuarios";
            this.btnrusuario.UseVisualStyleBackColor = true;
            this.btnrusuario.Click += new System.EventHandler(this.btnrusuario_Click);
            // 
            // btnusuespecifico
            // 
            this.btnusuespecifico.Location = new System.Drawing.Point(354, 135);
            this.btnusuespecifico.Name = "btnusuespecifico";
            this.btnusuespecifico.Size = new System.Drawing.Size(125, 23);
            this.btnusuespecifico.TabIndex = 23;
            this.btnusuespecifico.Text = "Usuario Especifico";
            this.btnusuespecifico.UseVisualStyleBackColor = true;
            this.btnusuespecifico.Click += new System.EventHandler(this.btnusuespecifico_Click);
            // 
            // btncatespecifica
            // 
            this.btncatespecifica.Location = new System.Drawing.Point(354, 198);
            this.btncatespecifica.Name = "btncatespecifica";
            this.btncatespecifica.Size = new System.Drawing.Size(125, 23);
            this.btncatespecifica.TabIndex = 24;
            this.btncatespecifica.Text = "Categoria Especifica";
            this.btncatespecifica.UseVisualStyleBackColor = true;
            this.btncatespecifica.Click += new System.EventHandler(this.btncatespecifica_Click);
            // 
            // btnnespecifica
            // 
            this.btnnespecifica.Location = new System.Drawing.Point(354, 267);
            this.btnnespecifica.Name = "btnnespecifica";
            this.btnnespecifica.Size = new System.Drawing.Size(125, 23);
            this.btnnespecifica.TabIndex = 25;
            this.btnnespecifica.Text = "Noticia Especifica";
            this.btnnespecifica.UseVisualStyleBackColor = true;
            this.btnnespecifica.Click += new System.EventHandler(this.btnnespecifica_Click);
            // 
            // CBOlectores
            // 
            this.CBOlectores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOlectores.FormattingEnabled = true;
            this.CBOlectores.Location = new System.Drawing.Point(180, 135);
            this.CBOlectores.Name = "CBOlectores";
            this.CBOlectores.Size = new System.Drawing.Size(121, 21);
            this.CBOlectores.TabIndex = 26;
            this.CBOlectores.SelectedIndexChanged += new System.EventHandler(this.CBOlectores_SelectedIndexChanged);
            // 
            // CBOnoticia
            // 
            this.CBOnoticia.DisplayMember = "Economica";
            this.CBOnoticia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOnoticia.FormattingEnabled = true;
            this.CBOnoticia.Location = new System.Drawing.Point(180, 267);
            this.CBOnoticia.Name = "CBOnoticia";
            this.CBOnoticia.Size = new System.Drawing.Size(121, 21);
            this.CBOnoticia.TabIndex = 27;
            this.CBOnoticia.ValueMember = "Economica";
            this.CBOnoticia.SelectedIndexChanged += new System.EventHandler(this.CBOnoticia_SelectedIndexChanged);
            // 
            // CBOCategorias
            // 
            this.CBOCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOCategorias.FormattingEnabled = true;
            this.CBOCategorias.Items.AddRange(new object[] {
            "Economica",
            "Internacional",
            "Politica",
            "Policial"});
            this.CBOCategorias.Location = new System.Drawing.Point(180, 200);
            this.CBOCategorias.Name = "CBOCategorias";
            this.CBOCategorias.Size = new System.Drawing.Size(121, 21);
            this.CBOCategorias.TabIndex = 28;
            this.CBOCategorias.SelectedIndexChanged += new System.EventHandler(this.CBOCategorias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Filtro Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Filtro Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Filtro Noticia";
            // 
            // DGVComentarios
            // 
            this.DGVComentarios.AllowUserToAddRows = false;
            this.DGVComentarios.AllowUserToDeleteRows = false;
            this.DGVComentarios.AllowUserToOrderColumns = true;
            this.DGVComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVComentarios.Location = new System.Drawing.Point(77, 315);
            this.DGVComentarios.Name = "DGVComentarios";
            this.DGVComentarios.ReadOnly = true;
            this.DGVComentarios.Size = new System.Drawing.Size(408, 148);
            this.DGVComentarios.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Filtro Resumen Noticia";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(583, 189);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(140, 32);
            this.btnlimpiar.TabIndex = 34;
            this.btnlimpiar.Text = "Volver Listado Incial";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // FrmListadoLinQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 523);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.CBOlectores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGVComentarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBOCategorias);
            this.Controls.Add(this.CBOnoticia);
            this.Controls.Add(this.btnnespecifica);
            this.Controls.Add(this.btncatespecifica);
            this.Controls.Add(this.btnusuespecifico);
            this.Controls.Add(this.btnrusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmListadoLinQ";
            this.Text = "FrmListadoLinQ";
            this.Load += new System.EventHandler(this.FrmListadoLinQ_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVComentarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnrusuario;
        private System.Windows.Forms.Button btnusuespecifico;
        private System.Windows.Forms.Button btncatespecifica;
        private System.Windows.Forms.Button btnnespecifica;
        private System.Windows.Forms.ComboBox CBOlectores;
        private System.Windows.Forms.ComboBox CBOnoticia;
        private System.Windows.Forms.ComboBox CBOCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVComentarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnlimpiar;
    }
}