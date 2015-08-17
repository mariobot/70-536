namespace AppTestCapIII
{
    partial class Form1
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
            this.txtTextoEvualar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatron = new System.Windows.Forms.TextBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.rbIsMatch = new System.Windows.Forms.RadioButton();
            this.rbReplace = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtTextoEvualar
            // 
            this.txtTextoEvualar.Location = new System.Drawing.Point(106, 22);
            this.txtTextoEvualar.Name = "txtTextoEvualar";
            this.txtTextoEvualar.Size = new System.Drawing.Size(383, 20);
            this.txtTextoEvualar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto a Evaluar: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patrón de Análisis para la Expression Regular ";
            // 
            // txtPatron
            // 
            this.txtPatron.Location = new System.Drawing.Point(15, 78);
            this.txtPatron.Name = "txtPatron";
            this.txtPatron.Size = new System.Drawing.Size(474, 20);
            this.txtPatron.TabIndex = 3;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(67, 128);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(380, 23);
            this.btnEvaluar.TabIndex = 4;
            this.btnEvaluar.Text = "EVALUAR";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(15, 161);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(474, 58);
            this.txtOut.TabIndex = 5;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(12, 228);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 13);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "label3";
            this.lblError.Visible = false;
            // 
            // rbIsMatch
            // 
            this.rbIsMatch.AutoSize = true;
            this.rbIsMatch.Location = new System.Drawing.Point(15, 105);
            this.rbIsMatch.Name = "rbIsMatch";
            this.rbIsMatch.Size = new System.Drawing.Size(63, 17);
            this.rbIsMatch.TabIndex = 7;
            this.rbIsMatch.TabStop = true;
            this.rbIsMatch.Text = "IsMatch";
            this.rbIsMatch.UseVisualStyleBackColor = true;
            // 
            // rbReplace
            // 
            this.rbReplace.AutoSize = true;
            this.rbReplace.Location = new System.Drawing.Point(84, 105);
            this.rbReplace.Name = "rbReplace";
            this.rbReplace.Size = new System.Drawing.Size(65, 17);
            this.rbReplace.TabIndex = 8;
            this.rbReplace.TabStop = true;
            this.rbReplace.Text = "Replace";
            this.rbReplace.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 249);
            this.Controls.Add(this.rbReplace);
            this.Controls.Add(this.rbIsMatch);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.txtPatron);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTextoEvualar);
            this.Name = "Form1";
            this.Text = "Compare Regular Expression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoEvualar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatron;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.RadioButton rbIsMatch;
        private System.Windows.Forms.RadioButton rbReplace;
    }
}

