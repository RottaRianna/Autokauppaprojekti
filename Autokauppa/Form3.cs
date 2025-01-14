using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Autokauppa
{
    public partial class Form3 : Form
    {
        private int currentImageIndex1 = 0;  
        private int currentImageIndex2 = 0;  
        private List<Image> images1 = new List<Image>();  // Tallennetaan kuvat pictureBox1
        private List<Image> images2 = new List<Image>();  // Tallennetaan kuvat pictureBox2
        private System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();  // Ajastin kuvien vaihtoon

        public Form3()
        {
            InitializeComponent();
            InitializeImages();  
        }

        private void InitializeImages()
        {
            // Lisätään kuvat Picturebox1
            images1.Add(Properties.Resources.toyotakuva); 
            images1.Add(Properties.Resources.Hondakuva);
            images1.Add(Properties.Resources.mersukuva);

            // Lisätään kuvat Picturebox2
            images2.Add(Properties.Resources.bmwkuva);  
            images2.Add(Properties.Resources.lexusKuva);
            images2.Add(Properties.Resources.audikuva);

            //Ensimmäinen kuva picturebox1
            pictureBox1.Image = images1[currentImageIndex1];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //Ensimmäinen kuva picturebox2
            pictureBox2.Image = images2[currentImageIndex2];
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            // Ajastin kuvien vaihtumiselle
            fadeTimer.Interval = 2000; // 2 sekunttia
            fadeTimer.Tick += FadeTimer_Tick;
            fadeTimer.Start();  //Ajastimen aloitus
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            // Kuvan päivitys pictureBox1
            currentImageIndex1 = (currentImageIndex1 + 1) % images1.Count;
            pictureBox1.Image = images1[currentImageIndex1];

            //Kuvan päivityspictureBox2
            currentImageIndex2 = (currentImageIndex2 + 1) % images2.Count;
            pictureBox2.Image = images2[currentImageIndex2];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Avataan form4 kun painetaan
            Form4 form4 = new Form4();
            form4.Show();  // Näytä uusi form
            this.Hide();   // piilotetaan (Form3)
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Avataan Form6, ei Form5
            Form6 form6 = new Form6();
            form6.Show();  // Näytetään uusi Form6
            this.Hide();   // Piilotetaan nykyinen Form (tässä Form3)
        }
    }
}
