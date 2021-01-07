using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApEscritorio.ServicioWindows;
namespace ApEscritorio
{
    public partial class FrmPrincipal : Form
    {
        private Usuarios usuario;
        public FrmPrincipal(Usuarios usu)
        {
            
            InitializeComponent();
            usuario = usu;
        
            lblerror.ForeColor = System.Drawing.Color.Red;
            label1.Text = "BIENVENIDO:" + usu.NomUsu;
        }

        private void altaAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblerror.Text = "";
            FrmAdmin frmadmin = new FrmAdmin(usuario);
            frmadmin.ShowDialog();
        }

        private void noticiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblerror.Text = "";
            FrmNoticias frmnoticias = new FrmNoticias(usuario);
            frmnoticias.ShowDialog();
        }

        private void periodistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblerror.Text = "";
            FrmPeriodista frmp = new FrmPeriodista(usuario);
            frmp.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblerror.Text = "";
            FrmListadoLinQ frmlq = new FrmListadoLinQ(usuario);
            frmlq.ShowDialog();
        }

        private void registrosUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblerror.Text = "";
            usuario = new Service1Client().BuscarUsuario(usuario.Ndoc);
            Administrador admin = ((Administrador)usuario);
            if (admin.GeneraLectores == true)
            {
                FrmAprobarLectores frmap = new FrmAprobarLectores(usuario);
                frmap.ShowDialog();
            }
            else
            {
                lblerror.Text = "Usted no tiene permiso para Rechazar o Aprobar Lectores";
            }
        }
    }
}
