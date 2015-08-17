using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            System.Drawing.Graphics g = this.CreateGraphics();

            Brush b = new SolidBrush(Color.Magenta);

            Point[] Puntos = new Point[]{
                new Point(10,10),
                new Point(10,100),
                new Point(50,65),
                new Point(100,100),
                new Point(85,40)
            };

            g.FillPolygon(b,Puntos);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Graphics g = this.CreateGraphics();

            Brush b = new SolidBrush(Color.Magenta);

            Point[] Puntos = new Point[]{
                new Point(10,10),
                new Point(10,100),
                new Point(50,65),
                new Point(100,100),
                new Point(85,40)
            };

            g.FillPolygon(b, Puntos);

        }
    }
}
