namespace ApEscritorio
{
    partial class FrmAprobarLectores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAprobarLectores));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnactualizar = new System.Windows.Forms.ToolStripButton();
            this.DGVLectores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtndoc = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btnrechazar = new System.Windows.Forms.Button();
            this.Ndoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLectores)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.statusStrip1.Location = new System.Drawing.Point(0, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(808, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnactualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(808, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnactualizar
            // 
            this.btnactualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(23, 22);
            this.btnactualizar.Text = "Acualizar";
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // DGVLectores
            // 
            this.DGVLectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLectores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ndoc,
            this.Column1,
            this.Column4});
            this.DGVLectores.Location = new System.Drawing.Point(12, 63);
            this.DGVLectores.Name = "DGVLectores";
            this.DGVLectores.Size = new System.Drawing.Size(436, 225);
            this.DGVLectores.TabIndex = 2;
            this.DGVLectores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLectores_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aprobar Lectores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NºDoc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Correo";
            // 
            // txtndoc
            // 
            this.txtndoc.Location = new System.Drawing.Point(604, 88);
            this.txtndoc.Name = "txtndoc";
            this.txtndoc.ReadOnly = true;
            this.txtndoc.Size = new System.Drawing.Size(100, 20);
            this.txtndoc.TabIndex = 9;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(604, 128);
            this.txtnom.Name = "txtnom";
            this.txtnom.ReadOnly = true;
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 10;
            // 
            // txtusu
            // 
            this.txtusu.Location = new System.Drawing.Point(604, 163);
            this.txtusu.Name = "txtusu";
            this.txtusu.ReadOnly = true;
            this.txtusu.Size = new System.Drawing.Size(100, 20);
            this.txtusu.TabIndex = 11;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(604, 201);
            this.txtpass.Name = "txtpass";
            this.txtpass.ReadOnly = true;
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 12;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(604, 239);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.ReadOnly = true;
            this.txtcorreo.Size = new System.Drawing.Size(100, 20);
            this.txtcorreo.TabIndex = 13;
            // 
            // lblerror
            // 
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(492, 294);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 14;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btnrechazar
            // 
            this.btnrechazar.Location = new System.Drawing.Point(629, 294);
            this.btnrechazar.Name = "btnrechazar";
            this.btnrechazar.Size = new System.Drawing.Size(75, 23);
            this.btnrechazar.TabIndex = 15;
            this.btnrechazar.Text = "Rechazar";
            this.btnrechazar.UseVisualStyleBackColor = true;
            this.btnrechazar.Click += new System.EventHandler(this.btnrechazar_Click);
            // 
            // Ndoc
            // 
            this.Ndoc.DataPropertyName = "Ndoc";
            this.Ndoc.HeaderText = "Ndoc";
            this.Ndoc.Name = "Ndoc";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NomUsu";
            this.Column1.HeaderText = "NomUsu";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Correo";
            this.Column4.HeaderText = "Correo";
            this.Column4.Name = "Column4";
            // 
            // FrmAprobarLectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 380);
            this.Controls.Add(this.btnrechazar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtndoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVLectores);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmAprobarLectores";
            this.Text = "FrmAprobarLectores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAprobarLectores_FormClosing);
            this.Load += new System.EventHandler(this.FrmAprobarLectores_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLectores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnactualizar;
        private System.Windows.Forms.DataGridView DGVLectores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtndoc;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btnrechazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ndoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}