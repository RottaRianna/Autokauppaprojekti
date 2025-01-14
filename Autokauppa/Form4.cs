using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Autokauppa
{
    public partial class Form4 : Form
    {
        private int currentImageIndex = 0; // Seuraa tämänhetkisen kuvan indexiä
        private List<Image> images = new List<Image>();  // Tallentaa kuvan
        private List<string> imageDescriptions = new List<string>();  // Tallentaa jokaisen kuvan tiedot

        public Form4()
        {
            InitializeComponent();
            InitializeImages(); 
            InitializeDescriptions();  
        }

        private void InitializeImages()
        {
            // Kuvat
            images.Add(Properties.Resources.toyotakuva);  
            images.Add(Properties.Resources.mersukuva);
            images.Add(Properties.Resources.Näyttökuva_2025_01_07_141711);
            images.Add(Properties.Resources.bmwuusi1);
            images.Add(Properties.Resources.jaguaruus);

            // Ensimmäinen kuva
            pictureBox1.Image = images[currentImageIndex];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void InitializeDescriptions()
        {
            imageDescriptions.Add("Tässä on tyylikäs ja luotettava Toyota-malli.");
            imageDescriptions.Add("Mercedes – ylellisyyttä ja huippusuorituskykyä yhdistettynä.");
            imageDescriptions.Add("Tässä on moderni ja ympäristöystävällinen sähköinen Toyota-malli.");
            imageDescriptions.Add("Uusi BMW tuo ajokokemuksen huipulle.");
            imageDescriptions.Add("Tässä on upea ja voimakas Jaguar-malli.");

        }

        // Kun nappia painetaan siirrytään seuraavaan kuvaan
        private void NextButton_Click(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % images.Count;  // Siirrytään seuraavaan kuvaan
            pictureBox1.Image = images[currentImageIndex];  
        }

        // Takaisin nappia painaessa mennään edelliseen kuvaan
        private void BackButton_Click(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex - 1 + images.Count) % images.Count;  // Siirytään edelliseen kuvaan
            pictureBox1.Image = images[currentImageIndex];  
        }

        // Hover efekti tehdään tässä
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            // Näytetään kuvan tiedot kun hiiri on kuvan päällä
            labelDecription.Text = imageDescriptions[currentImageIndex]; // Tämänhetkisen kuvan tiedot haetaan
            labelDecription.Visible = true; // Muokataan label näkyväksi
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //Piilotetaan kuvan tiedot kun hiiri lähtee pois kuvan päältä
            labelDecription.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void ESC_Click(object sender, EventArgs e)
        {
            // Takaisin Form3
            Form3 form3 = new Form3();  
            form3.Show();               // Näytä Form3
            this.Hide();
        }

        private void labelDecription_Click(object sender, EventArgs e)
        {
        }
    }
}
