using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace AppTestCapIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            string Palabra = string.Empty;
            string Patron = string.Empty;
            if (!string.IsNullOrEmpty(this.txtTextoEvualar.Text.ToString()) && !string.IsNullOrEmpty(this.txtPatron.Text.ToString()))
            {
                this.lblError.Visible = false;
                Palabra = this.txtTextoEvualar.Text.ToString();
                Patron = this.txtPatron.Text.ToString();
                if(this.rbIsMatch.Checked)   Evaluador(Palabra, Patron);
                if (this.rbReplace.Checked) Remplazo(Palabra, Patron);
            }//fin del if
            else
            {
                if (string.IsNullOrEmpty(this.txtPatron.Text.ToString()) && string.IsNullOrEmpty(this.txtTextoEvualar.Text.ToString()))
                {
                    this.lblError.Visible = true;
                    this.lblError.Text = "Hace falta todos los datos";
                    this.txtTextoEvualar.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.txtTextoEvualar.Text.ToString()))
                    {
                        this.lblError.Visible = true;
                        this.lblError.Text = "Hace falta el texto a Evaluar";
                        this.txtTextoEvualar.Focus();
                    }
                    if (string.IsNullOrEmpty(this.txtPatron.Text.ToString()))
                    {
                        this.lblError.Visible = true;
                        this.lblError.Text = "Hace falta el patron Evaluar";
                        this.txtPatron.Focus();
                    }
                }
            }
        }//fin de la funcion
        private void Evaluador(string word, string patter) 
        {
            if (Regex.IsMatch(word, patter) == true)
            {
                this.txtOut.Text = word + " - " + patter + " Son Validos";
            }
            else
            {
                this.txtOut.Text = word + " - " + patter + " No Son Validos";
            }
        }//fin del evaluador

        private void Remplazo(string word, string patter)
        {
            if (Regex.IsMatch(word, patter) == true)
            {
                this.txtOut.Text = word + " - " + patter + " Son Validos";
            }
            else
            {
                this.txtOut.Text = word + " - " + patter + " No Son Validos";
            }
        }//fin del evaluador
    }
}
