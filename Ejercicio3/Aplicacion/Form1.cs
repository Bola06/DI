using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class Form1 : Form
    {
        List<string> imagenes = new List<string> ();
        int indice = 0;
        int segundos = 1;
        bool parar = false;
        string[] imagenes2;
        public Form1()
        {
            
            InitializeComponent();

            this.Text = "Reproductor de imágenes";

            for (int i = 0; i < 20; i++)
            {
                comboBox1.Items.Add(i + 1);
            }

            comboBox1.SelectedIndex = 0;

            timer1.Interval = 1000;
           // timer1.Tick += timer1_Tick;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();

            if (f.ShowDialog() == DialogResult.OK)
            {
                string ruta = f.SelectedPath;

                string[] archivos = Directory.GetFiles(ruta);

                for (int i = 0;  i < archivos.Length;  i++)
                {
                    string ext = Path.GetExtension(archivos[i]);

                    if (ext == ".jpg" || ext == ".png")
                    {
                        try
                        {
                            Image img = Image.FromFile(archivos[i]);

                            img.Dispose();

                            imagenes.Add(archivos[i]);
                        }
                        catch { }
                    }
                    
                }


                 imagenes2 = imagenes.ToArray();

                if (imagenes2.Length>0)
                {
                    indice = 0;

                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }

                    pictureBox1.Image = Image.FromFile(imagenes2[indice]);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            segundos = comboBox1.SelectedIndex + 1;
        }

        private void userControl11_PlayClick(object sender, EventArgs e)
        {
            if (parar == false)
            {
                timer1.Start();
                parar = true;
            }
            else
            {
                timer1.Stop();
                parar = false;
            }
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            userControl11.Ss++;

            int a = userControl11.Ss % segundos;

            if (a == 0)
            {
                if (imagenes2 != null && imagenes2.Length>0)
                {
                    indice++;

                    if (indice>= imagenes2.Length)
                    {
                        indice = 0;
                    }

                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }

                    pictureBox1.Image = Image.FromFile(imagenes2[indice]);
                }
            }
        }

        private void userControl11_DesbordaTiempo(object sender, EventArgs e)
        {
            userControl11.Mm++;
        }
    }
}
