using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            actu();
        }

        private int mm;
        [Category("Mis propiedades")]
        [Description("Los minutos del contador")]
        public int Mm
        {
            get
            {
                return mm;
            }
            set
            {
                if (value>59)
                {
                    mm = 0;
                }
                else if (value<0)
                {
                    throw new ArgumentException("Error");
                }
                else
                {
                    mm = value;
                }
                actu();
            }
        }

        private int ss;
        [Category("Mis propiedades")]
        [Description("Los segundos del contador")]
        public int Ss
        {
            get
            {
                return ss;
            }
            set
            {
                if (value <  0)
                {
                    throw new ArgumentException("Error");
                }
                else
                {
                    int resto = value % 60;

                    if (resto == 0 && value != 0)
                    {
                        OnDesbordaTiempo(EventArgs.Empty);
                    }

                    ss = resto;
                    actu();
                }
            }
        }

        private void actu(){
            label1.Text = $"{mm:00}:{ss:00}";
        }

        [Category("Evento")]
        [Description("Se lanza cuando resto llega a cero")]
        public event EventHandler DesbordaTiempo;

        protected virtual void OnDesbordaTiempo(EventArgs e)
        {
            if (DesbordaTiempo != null)
            {
                DesbordaTiempo(this, e);
            }
        }

        [Category("Evento")]
        [Description("Se lanza al dale al botón")]
        public event EventHandler PlayClick;

        protected virtual void OnPlayClick(EventArgs e)
        {
            if (PlayClick != null)
            {
                PlayClick(this, e);
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Play") {
                button1.Text = "Pausa";
            }
            else
            {
                button1.Text = "Play";
            }
            OnPlayClick(e);
        }
    }
}
