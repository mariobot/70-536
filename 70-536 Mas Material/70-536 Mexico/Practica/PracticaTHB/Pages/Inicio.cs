using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiLibreria.Base;

namespace PracticaTHB.Pages
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            MiLlamado();            
        }

        private void crearBoton()
        {
            Button btn = new Button();
            btn.Text = "Hola";
            btn.Size = new System.Drawing.Size(50,50);
            btn.Location = new System.Drawing.Point(0, 0);
            btn.Visible = true;
            panel1.Container.Add(btn);

        }

        private void MiLlamado() 
        {
            try
            {
                string resp = string.Empty;
                string mensaje = string.Empty;
                mensaje = TxbCaja.Text;
                Core miclase = new Core();
                resp = miclase.Serializacion(mensaje);
                LblEtiqueta.Text = resp;
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
