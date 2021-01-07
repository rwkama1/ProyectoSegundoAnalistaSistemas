using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApEscritorio.ServicioWindows;
using System.Messaging;
namespace ApEscritorio
{
    public partial class FrmAprobarLectores : Form
    {
        private Administrador adminBD;
        MessageQueue CLector;
        List<Lector> _ListaLector;
        Lector objlector;
        Usuarios usu;
        public FrmAprobarLectores(Usuarios usuario)
        {
            InitializeComponent();
            usu = usuario;
          
          

                string _NombreCola = ConfigurationManager.AppSettings["ColaMsMq"];
                CLector = new MessageQueue(_NombreCola);
                CLector.MessageReadPropertyFilter.SetAll();


                ((XmlMessageFormatter)CLector.Formatter).TargetTypes = new Type[] { typeof(Lector) };


                _ListaLector = new List<Lector>();


                objlector = null;
            
           
        }

        private void FrmAprobarLectores_Load(object sender, EventArgs e)
        {
                try
                {
                    btnrechazar.Enabled = false;
                    btnaceptar.Enabled = false;

                    CLector.ReceiveCompleted += new ReceiveCompletedEventHandler(Recepcion);


                    CLector.BeginReceive(new TimeSpan(1, 0, 0, 0));


                    DGVLectores.AutoGenerateColumns = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en MSMQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            

        }
        private void FrmAprobarLectores_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                if (_ListaLector.Count > 0)
                {
                    DialogResult _respuesta = MessageBox.Show("Hay Lectores sin Evaluar. \nSi continua dichas solicitudes se perderan. \nEsta seguro que desea abandonar igual?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (_respuesta == System.Windows.Forms.DialogResult.No)
                        e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                

                lblerror.Text = ex.Message;
            }
        }
        private void Recepcion(object sender, ReceiveCompletedEventArgs args)
        {
            try
            {

                System.Messaging.Message _unMensaje = CLector.EndReceive(args.AsyncResult);
                Lector lectom = (Lector)_unMensaje.Body;


                _ListaLector.Add(lectom);


                CLector.BeginReceive(new TimeSpan(1, 0, 0, 0));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en MSMQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVLectores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {

                objlector = _ListaLector[e.RowIndex];
                 txtndoc.Text=objlector.Ndoc.ToString();
                 txtnom.Text=objlector.NomUsu.ToString();
                 txtusu.Text=objlector.Usuario.ToString();
                 txtpass.Text=objlector.Contraseña.ToString();
                 txtcorreo.Text=objlector.Correo.ToString();
               btnaceptar.Enabled=true;
                 btnrechazar.Enabled=true; 
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
        

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                new Service1Client().AltaUsuario(objlector,adminBD=((Administrador)usu));
                   _ListaLector.Remove(objlector);
                   DGVLectores.DataSource = null;
                   DGVLectores.DataSource = _ListaLector;
                   lblerror.ForeColor = System.Drawing.Color.DarkGreen;
                   lblerror.Text = "Lector Registrado Correctamente";
                   txtndoc.Text = "";
                   txtnom.Text = "";
                   txtpass.Text = "";
                   txtcorreo.Text = "";
                   txtusu.Text = "";
                   btnaceptar.Enabled = false;
                   btnrechazar.Enabled = false;
               }

            catch (Exception ex)
            {

                lblerror.Text = ex.Message;
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DGVLectores.DataSource = null;
                DGVLectores.DataSource = _ListaLector;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en MSMQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrechazar_Click(object sender, EventArgs e)
        {
            try
            {
                lblerror.ForeColor = System.Drawing.Color.Red;
                _ListaLector.Remove(objlector);
                DGVLectores.DataSource = null;
                DGVLectores.DataSource = _ListaLector;
                lblerror.Text = "El Lector ha sido Rechazado";
                txtndoc.Text = "";
                txtnom.Text = "";
                txtpass.Text = "";
                txtcorreo.Text = "";
                txtusu.Text = "";
                btnaceptar.Enabled = false;
                btnrechazar.Enabled = false; 

            }
            catch (Exception ex)
            {

                lblerror.Text = ex.Message;
            }
        }

    }
}
