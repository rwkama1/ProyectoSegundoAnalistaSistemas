namespace ApEscritorio
{
    partial class FrmPrincipal
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
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noticiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem,
            this.listadoToolStripMenuItem,
            this.registrosUsuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaAdminToolStripMenuItem,
            this.noticiasToolStripMenuItem,
            this.periodistasToolStripMenuItem});
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aBMToolStripMenuItem.Text = "ABM";
            // 
            // altaAdminToolStripMenuItem
            // 
            this.altaAdminToolStripMenuItem.Name = "altaAdminToolStripMenuItem";
            this.altaAdminToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.altaAdminToolStripMenuItem.Text = "Alta Admin";
            this.altaAdminToolStripMenuItem.Click += new System.EventHandler(this.altaAdminToolStripMenuItem_Click);
            // 
            // noticiasToolStripMenuItem
            // 
            this.noticiasToolStripMenuItem.Name = "noticiasToolStripMenuItem";
            this.noticiasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.noticiasToolStripMenuItem.Text = "Noticias";
            this.noticiasToolStripMenuItem.Click += new System.EventHandler(this.noticiasToolStripMenuItem_Click);
            // 
            // periodistasToolStripMenuItem
            // 
            this.periodistasToolStripMenuItem.Name = "periodistasToolStripMenuItem";
            this.periodistasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.periodistasToolStripMenuItem.Text = "Periodistas";
            this.periodistasToolStripMenuItem.Click += new System.EventHandler(this.periodistasToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(169, 20);
            this.listadoToolStripMenuItem.Text = "ListadoComentariosLectores";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // registrosUsuariosToolStripMenuItem
            // 
            this.registrosUsuariosToolStripMenuItem.Name = "registrosUsuariosToolStripMenuItem";
            this.registrosUsuariosToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.registrosUsuariosToolStripMenuItem.Text = "AprobacionLectores";
            this.registrosUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registrosUsuariosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.statusStrip1.Location = new System.Drawing.Point(0, 237);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(478, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblerror
            // 
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 259);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noticiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosUsuariosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
    }
}