using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Composite
{
    public class PremiosComposite:ContainerControl
    {
       
        private Label UnTitulo;
        public ListBox LbPremios;
        private Button BtnAgregarpremio;
        private TextBox UnPremio;
        private Button BtnBorrarpremio;
        public Label LblError;
 

    
        public List<string> ListaPremios
        {
            get
            {
                List<string> _lista = new List<string>();

                foreach (Object unpremio in LbPremios.Items)
                    _lista.Add(unpremio.ToString());

                return _lista;
            }

            set
            {
                LbPremios.Items.Clear();

                if (value != null)
                {
                    foreach (string unpremio in value)
                        LbPremios.Items.Add(unpremio);
                }
            }
        }

    
        public PremiosComposite()
        {
         
            UnTitulo = new Label();
            UnTitulo.Text = "PREMIOS";
            
            UnTitulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.Controls.Add(UnTitulo);

         
            LbPremios = new ListBox();
            LbPremios.Width = 150;
            this.Controls.Add(LbPremios);

          
            UnPremio = new TextBox();
            UnPremio.Text = "";
            UnPremio.MaxLength = 49;
            UnPremio.Width = 150;
 
            this.Controls.Add(UnPremio);

            BtnAgregarpremio = new Button();
            BtnAgregarpremio.AutoSize = true;
            BtnAgregarpremio.Text = "Agregar a la lista";
            BtnAgregarpremio.Click += new EventHandler(AltaPremio);
            this.Controls.Add(BtnAgregarpremio);

       
            BtnBorrarpremio = new Button();
            BtnBorrarpremio.AutoSize = true;
            BtnBorrarpremio.Text = "Borrar de la lista";
            BtnBorrarpremio.Click += new EventHandler(BorrarPremio);
            this.Controls.Add(BtnBorrarpremio);

      
            LblError= new Label();
            LblError.AutoSize = true;
            LblError.ForeColor = System.Drawing.Color.Red;
            LblError.Text = "";
            this.Controls.Add(LblError);
        }


        protected override void  OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

          
            UnTitulo.Location= new System.Drawing.Point(40,0);
            LbPremios.Location = new System.Drawing.Point(5, 24);
            UnPremio.Location = new System.Drawing.Point(5, 124);
            BtnAgregarpremio.Location = new System.Drawing.Point(5, 160);
            BtnBorrarpremio.Location = new System.Drawing.Point(5, 190);
            LblError.Location = new System.Drawing.Point(30,240);
           
        }

        protected void AltaPremio(object sender, EventArgs e)
        {
            
            if (UnPremio.Text.Trim().Length > 0)
            {
                LbPremios.Items.Add(UnPremio.Text.Trim());
                UnPremio.Text = "";
                LblError.Text = "Se agrego Premio a la lista";
            }
            else
                LblError.Text = "No se Ingreso Premio";
        }

        protected void BorrarPremio(object sender, EventArgs e)
        {
            
            if (LbPremios.SelectedIndex >= 0)
            {
                LbPremios.Items.RemoveAt(LbPremios.SelectedIndex);
                LblError.Text = "Eliminado Premio de la lista";
            }
            else
                LblError.Text = "Debe Seleccionar Premio de la lista";
        }

        public void LimpiarTodo()
        {
            LbPremios.Items.Clear();
        }
    }
}
