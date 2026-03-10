using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4Bien
{
    public partial class DibujoAhorcado: UserControl
    {
        public DibujoAhorcado()
        {
            InitializeComponent();
        }

        private int errores;
        [Category("Mis propiedades")]
        [Description("Indica el número de errores")]
        public int Errores
        {
            get
            {
                return errores;
            }
            set
            {
                errores = value;
                this.Refresh();
            }
        }

        [Category("Eventos")]
        [Description("Se lanza cuando cambia el número de errores")]
        public event EventHandler CambiaError;

        protected virtual void OnCambiaError(EventArgs e)
        {
            if (CambiaError != null)
            {
                CambiaError(this, e);
            }
        }

        [Category("Eventos")]
        [Description("Se lanza cuando se completa el dibujo")]
        public event EventHandler Ahorcado;

        protected virtual void OnAhorcado( EventArgs e)
        {
            if (Ahorcado != null)
            {
                Ahorcado(this, e);
            }
        }


        private void DibujoAhorcado_Load(object sender, EventArgs e)
        {

        }

        private void DibujoAhorcado_Paint(object sender, PaintEventArgs e)
        {
        
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            if (errores == 0)
            {

            }
            else if (errores == 1)
            {
                g.DrawLine(new Pen(Color.Black, 0), 10, this.Height - 10, this.Width - 10, this.Height - 10); // suelo
            }
             if (errores == 2)
            {
                g.DrawLine(new Pen(Color.Black, 0), 10, this.Height - 10, this.Width - 10, this.Height - 10); // suelo
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height - 10, 20, this.Height / 8); // palo alto
            }
             if (errores == 3)
            {
                g.DrawLine(new Pen(Color.Black, 0), 10, this.Height - 10, this.Width - 10, this.Height - 10); // suelo
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height - 10, 20, this.Height / 8); // palo alto
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 8, this.Width / 2, this.Height / 8); // palo arriba
            }
             if (errores == 4)
            {
                g.DrawLine(new Pen(Color.Black, 0), 10, this.Height - 10, this.Width - 10, this.Height - 10); // suelo
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height - 10, 20, this.Height / 8); // palo alto
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 8, this.Width / 2, this.Height / 8); // palo arriba
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 5, (this.Width / 3) / 2, this.Height / 8); // cuerda diagonal
            }
             if (errores == 5)
            {
                g.DrawLine(new Pen(Color.Black, 0), 10, this.Height - 10, this.Width - 10, this.Height - 10); // suelo
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height - 10, 20, this.Height / 8); // palo alto
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 8, this.Width / 2, this.Height / 8); // palo arriba
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 5, (this.Width / 3) / 2, this.Height / 8); // cuerda diagonal
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 8, this.Width / 2, this.Height / 6); // cuerda
            }
             if (errores == 6)
            {
                g.DrawLine(new Pen(Color.Black, 0), 10, this.Height - 10, this.Width - 10, this.Height - 10); // suelo
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height - 10, 20, this.Height / 8); // palo alto
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 8, this.Width / 2, this.Height / 8); // palo arriba
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 5, (this.Width / 3) / 2, this.Height / 8); // cuerda diagonal
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 8, this.Width / 2, this.Height / 6); // cuerda
                g.DrawEllipse(new Pen(Color.Black, 0), this.Width / 2 - ((this.Width / 2) / 3) / 2, this.Height / 6, (this.Width / 2) / 3, (this.Width / 2) / 3); // cabeza
            }
             if (errores == 7)
            {
                g.DrawLine(new Pen(Color.Black, 0), 10, this.Height - 10, this.Width - 10, this.Height - 10); // suelo
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height - 10, 20, this.Height / 8); // palo alto
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 8, this.Width / 2, this.Height / 8); // palo arriba
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 5, (this.Width / 3) / 2, this.Height / 8); // cuerda diagonal
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 8, this.Width / 2, this.Height / 6); // cuerda
                g.DrawEllipse(new Pen(Color.Black, 0), this.Width / 2 - ((this.Width / 2) / 3) / 2, this.Height / 6, (this.Width / 2) / 3, (this.Width / 2) / 3); // cabeza
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 6 + (this.Width / 2) / 3, this.Width / 2, this.Height / 6 + (this.Width / 2) / 3 + this.Height / 4);//cuerpo
            }
             if (errores == 8)
            {
                g.DrawLine(new Pen(Color.Black, 0), 10, this.Height - 10, this.Width - 10, this.Height - 10); // suelo
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height - 10, 20, this.Height / 8); // palo alto
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 8, this.Width / 2, this.Height / 8); // palo arriba
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 5, (this.Width / 3) / 2, this.Height / 8); // cuerda diagonal
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 8, this.Width / 2, this.Height / 6); // cuerda
                g.DrawEllipse(new Pen(Color.Black, 0), this.Width / 2 - ((this.Width / 2) / 3) / 2, this.Height / 6, (this.Width / 2) / 3, (this.Width / 2) / 3); // cabeza
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 6 + (this.Width / 2) / 3, this.Width / 2, this.Height / 6 + (this.Width / 2) / 3 + this.Height / 4);//cuerpo
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 6 + (this.Width / 2) / 3 + this.Height / 16, this.Width / 2 - (this.Width / 8), this.Height / 6 + (this.Width / 2) / 3 + this.Height / 8);//brazo izq
            }
             if (errores == 9)
            {
                g.DrawLine(new Pen(Color.Black, 0), 10, this.Height - 10, this.Width - 10, this.Height - 10); // suelo
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height - 10, 20, this.Height / 8); // palo alto
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 8, this.Width / 2, this.Height / 8); // palo arriba
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 5, (this.Width / 3) / 2, this.Height / 8); // cuerda diagonal
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 8, this.Width / 2, this.Height / 6); // cuerda
                g.DrawEllipse(new Pen(Color.Black, 0), this.Width / 2 - ((this.Width / 2) / 3) / 2, this.Height / 6, (this.Width / 2) / 3, (this.Width / 2) / 3); // cabeza
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 6 + (this.Width / 2) / 3, this.Width / 2, this.Height / 6 + (this.Width / 2) / 3 + this.Height / 4);//cuerpo
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 6 + (this.Width / 2) / 3 + this.Height / 16, this.Width / 2 - (this.Width / 8), this.Height / 6 + (this.Width / 2) / 3 + this.Height / 8);//brazo izq
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 6 + (this.Width / 2) / 3 + this.Height / 16, this.Width / 2 + (this.Width / 8), this.Height / 6 + (this.Width / 2) / 3 + this.Height / 8);//brazo der
            }
             if (errores == 10)
            {
                g.DrawLine(new Pen(Color.Black, 0), 10, this.Height - 10, this.Width - 10, this.Height - 10); // suelo
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height - 10, 20, this.Height / 8); // palo alto
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 8, this.Width / 2, this.Height / 8); // palo arriba
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 5, (this.Width / 3) / 2, this.Height / 8); // cuerda diagonal
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 8, this.Width / 2, this.Height / 6); // cuerda
                g.DrawEllipse(new Pen(Color.Black, 0), this.Width / 2 - ((this.Width / 2) / 3) / 2, this.Height / 6, (this.Width / 2) / 3, (this.Width / 2) / 3); // cabeza
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 6 + (this.Width / 2) / 3, this.Width / 2, this.Height / 6 + (this.Width / 2) / 3 + this.Height / 4);//cuerpo
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 6 + (this.Width / 2) / 3 + this.Height / 16, this.Width / 2 - (this.Width / 8), this.Height / 6 + (this.Width / 2) / 3 + this.Height / 8);//brazo izq
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 6 + (this.Width / 2) / 3 + this.Height / 16, this.Width / 2 + (this.Width / 8), this.Height / 6 + (this.Width / 2) / 3 + this.Height / 8);//brazo der
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 6 + (this.Width / 2) / 3 + this.Height / 4, this.Width / 2 - (this.Width / 10), this.Height / 6 + (this.Width / 2) / 3 + this.Height / 4 + this.Height / 6);//pierna izq
            }
             if (errores == 11)
            {
                g.DrawLine(new Pen(Color.Black, 0), 10, this.Height - 10, this.Width - 10, this.Height - 10); // suelo
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height - 10, 20, this.Height / 8); // palo alto
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 8, this.Width / 2, this.Height / 8); // palo arriba
                g.DrawLine(new Pen(Color.Black, 0), 20, this.Height / 5, (this.Width / 3) / 2, this.Height / 8); // cuerda diagonal
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 8, this.Width / 2, this.Height / 6); // cuerda
                g.DrawEllipse(new Pen(Color.Black, 0), this.Width / 2 - ((this.Width / 2) / 3) / 2, this.Height / 6, (this.Width / 2) / 3, (this.Width / 2) / 3); // cabeza
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 6 + (this.Width / 2) / 3, this.Width / 2, this.Height / 6 + (this.Width / 2) / 3 + this.Height / 4);//cuerpo
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 6 + (this.Width / 2) / 3 + this.Height / 16, this.Width / 2 - (this.Width / 8), this.Height / 6 + (this.Width / 2) / 3 + this.Height / 8);//brazo izq
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 6 + (this.Width / 2) / 3 + this.Height / 16, this.Width / 2 + (this.Width / 8), this.Height / 6 + (this.Width / 2) / 3 + this.Height / 8);//brazo der
                g.DrawLine(new Pen(Color.Black, 0), this.Width / 2, this.Height / 6 + (this.Width / 2) / 3 + this.Height / 4, this.Width / 2 - (this.Width / 10), this.Height / 6 + (this.Width / 2) / 3 + this.Height / 4 + this.Height / 6);//pierna izq
                g.DrawLine(new Pen(Color.Black, 0),this.Width / 2,this.Height / 6 + (this.Width / 2) / 3 + this.Height / 4,this.Width / 2 + (this.Width / 10),this.Height / 6 + (this.Width / 2) / 3 + this.Height / 4 + this.Height / 6);//pierna der
                OnAhorcado(EventArgs.Empty);
            }

               
        
        }
}
}
