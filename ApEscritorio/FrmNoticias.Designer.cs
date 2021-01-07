namespace ApEscritorio
{
    partial class FrmNoticias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNoticias));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnalta = new System.Windows.Forms.ToolStripButton();
            this.btnbaja = new System.Windows.Forms.ToolStripButton();
            this.btnmodificar = new System.Windows.Forms.ToolStripButton();
            this.btnlimpiar = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CBOperiodistas = new System.Windows.Forms.ComboBox();
            this.CBOCategorias = new System.Windows.Forms.ComboBox();
            this.CBRelevante = new System.Windows.Forms.CheckBox();
            this.rtxtCuerponoticia = new System.Windows.Forms.RichTextBox();
            this.rtxtresumen = new System.Windows.Forms.RichTextBox();
            this.rtxtitulo = new System.Windows.Forms.RichTextBox();
            this.DGVnoticias = new System.Windows.Forms.DataGridView();
            this.IdNoticia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relevante = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtxtid = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVnoticias)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1110, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblerror
            // 
            this.lblerror.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnalta,
            this.btnbaja,
            this.btnmodificar,
            this.btnlimpiar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1110, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnalta
            // 
            this.btnalta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnalta.Image = ((System.Drawing.Image)(resources.GetObject("btnalta.Image")));
            this.btnalta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnalta.Name = "btnalta";
            this.btnalta.Size = new System.Drawing.Size(23, 22);
            this.btnalta.Text = "&Nuevo";
            this.btnalta.Click += new System.EventHandler(this.btnalta_Click);
            // 
            // btnbaja
            // 
            this.btnbaja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbaja.Image = ((System.Drawing.Image)(resources.GetObject("btnbaja.Image")));
            this.btnbaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(23, 22);
            this.btnbaja.Text = "baja";
            this.btnbaja.Click += new System.EventHandler(this.btnbaja_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(23, 22);
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(23, 22);
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "NOTICIAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "IdNoticia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Titulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Resumen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "CuerpoNoticia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Periodista";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 511);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Relevante";
            // 
            // CBOperiodistas
            // 
            this.CBOperiodistas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOperiodistas.FormattingEnabled = true;
            this.CBOperiodistas.Location = new System.Drawing.Point(113, 457);
            this.CBOperiodistas.Name = "CBOperiodistas";
            this.CBOperiodistas.Size = new System.Drawing.Size(121, 21);
            this.CBOperiodistas.TabIndex = 36;
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
            this.CBOCategorias.Location = new System.Drawing.Point(113, 511);
            this.CBOCategorias.Name = "CBOCategorias";
            this.CBOCategorias.Size = new System.Drawing.Size(121, 21);
            this.CBOCategorias.TabIndex = 37;
            // 
            // CBRelevante
            // 
            this.CBRelevante.Location = new System.Drawing.Point(359, 452);
            this.CBRelevante.Name = "CBRelevante";
            this.CBRelevante.Size = new System.Drawing.Size(108, 24);
            this.CBRelevante.TabIndex = 38;
            this.CBRelevante.UseVisualStyleBackColor = true;
            // 
            // rtxtCuerponoticia
            // 
            this.rtxtCuerponoticia.Location = new System.Drawing.Point(32, 354);
            this.rtxtCuerponoticia.MaxLength = 1499;
            this.rtxtCuerponoticia.Name = "rtxtCuerponoticia";
            this.rtxtCuerponoticia.Size = new System.Drawing.Size(413, 70);
            this.rtxtCuerponoticia.TabIndex = 41;
            this.rtxtCuerponoticia.Text = "";
            // 
            // rtxtresumen
            // 
            this.rtxtresumen.Location = new System.Drawing.Point(32, 244);
            this.rtxtresumen.MaxLength = 149;
            this.rtxtresumen.Name = "rtxtresumen";
            this.rtxtresumen.Size = new System.Drawing.Size(413, 60);
            this.rtxtresumen.TabIndex = 42;
            this.rtxtresumen.Text = "";
            // 
            // rtxtitulo
            // 
            this.rtxtitulo.Location = new System.Drawing.Point(39, 154);
            this.rtxtitulo.MaxLength = 39;
            this.rtxtitulo.Name = "rtxtitulo";
            this.rtxtitulo.Size = new System.Drawing.Size(350, 35);
            this.rtxtitulo.TabIndex = 43;
            this.rtxtitulo.Text = "";
            // 
            // DGVnoticias
            // 
            this.DGVnoticias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVnoticias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdNoticia,
            this.FechaHoraCreacion,
            this.Relevante,
            this.Categoria,
            this.Periodista});
            this.DGVnoticias.Location = new System.Drawing.Point(485, 87);
            this.DGVnoticias.Name = "DGVnoticias";
            this.DGVnoticias.Size = new System.Drawing.Size(575, 337);
            this.DGVnoticias.TabIndex = 44;
            // 
            // IdNoticia
            // 
            this.IdNoticia.DataPropertyName = "IdNoticia";
            this.IdNoticia.HeaderText = "IdNoticia";
            this.IdNoticia.Name = "IdNoticia";
            // 
            // FechaHoraCreacion
            // 
            this.FechaHoraCreacion.DataPropertyName = "FechaHoraCreacion";
            this.FechaHoraCreacion.HeaderText = "FechaHoraCreacion";
            this.FechaHoraCreacion.Name = "FechaHoraCreacion";
            // 
            // Relevante
            // 
            this.Relevante.DataPropertyName = "Relevante";
            this.Relevante.HeaderText = "Relevante";
            this.Relevante.Name = "Relevante";
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Periodista
            // 
            this.Periodista.DataPropertyName = "NomPeriodista";
            this.Periodista.HeaderText = "Periodista";
            this.Periodista.Name = "Periodista";
            // 
            // mtxtid
            // 
            this.mtxtid.Location = new System.Drawing.Point(95, 87);
            this.mtxtid.Mask = "99999";
            this.mtxtid.Name = "mtxtid";
            this.mtxtid.Size = new System.Drawing.Size(43, 20);
            this.mtxtid.TabIndex = 45;
            this.mtxtid.Validating += new System.ComponentModel.CancelEventHandler(this.txtidnoticia_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "0 para dar de ALTA";
            // 
            // FrmNoticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1110, 598);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mtxtid);
            this.Controls.Add(this.DGVnoticias);
            this.Controls.Add(this.rtxtitulo);
            this.Controls.Add(this.rtxtresumen);
            this.Controls.Add(this.rtxtCuerponoticia);
            this.Controls.Add(this.CBRelevante);
            this.Controls.Add(this.CBOCategorias);
            this.Controls.Add(this.CBOperiodistas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmNoticias";
            this.Text = "FrmNoticias";
            this.Load += new System.EventHandler(this.FrmNoticias_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVnoticias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnalta;
        private System.Windows.Forms.ToolStripButton btnbaja;
        private System.Windows.Forms.ToolStripButton btnmodificar;
        private System.Windows.Forms.ToolStripButton btnlimpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBOperiodistas;
        private System.Windows.Forms.ComboBox CBOCategorias;
        private System.Windows.Forms.CheckBox CBRelevante;
        private System.Windows.Forms.RichTextBox rtxtCuerponoticia;
        private System.Windows.Forms.RichTextBox rtxtresumen;
        private System.Windows.Forms.RichTextBox rtxtitulo;
        private System.Windows.Forms.DataGridView DGVnoticias;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNoticia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraCreacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Relevante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodista;
        private System.Windows.Forms.MaskedTextBox mtxtid;
        private System.Windows.Forms.Label label10;
    }
}