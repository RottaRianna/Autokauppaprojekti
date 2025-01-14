using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Autokauppa
{
    public partial class Form6 : Form
    {
        private int currentImageIndex = 0; // Seuraa tämänhetkisen kuvan indexiä
        private List<Image> images = new List<Image>();  // Tallentaa kuvan
        private List<string> imageDescriptions = new List<string>();  // Tallentaa jokaisen kuvan tiedot

        public Form6()
        {
            InitializeComponent();
            InitializeImages();  
            InitializeDescriptions();  
        }

        
        private void InitializeImages()
        {
            // Kuvat
            images.Add(Properties.Resources.toyotaOld);
            images.Add(Properties.Resources.jaguarOld);
            images.Add(Properties.Resources.bmwOld);
            images.Add(Properties.Resources.mazdaOld);
            images.Add(Properties.Resources.hondaOld);
            images.Add(Properties.Resources.bmwkuva1);

            // Ensimmäinen kuva valittuna
            pictureBox1.Image = images[currentImageIndex];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Tiedot kuville
        private void InitializeDescriptions()
        {
            imageDescriptions.Add("Tämä klassinen Toyota on luotettavan ajokokemuksen symboli, joka on kestänyt aikaa.");
            imageDescriptions.Add("Jaguarin vanha malli, joka on täynnä ylellisyyttä ja ajamisen nautintoa. Täydellinen yhdistelmä tyyliä ja voimaa.");
            imageDescriptions.Add("BMW:n ikonisesta vanhasta mallista huokuu ainutlaatuinen ajotunne ja huipputeknologia, joka ei koskaan mene pois muodista.");
            imageDescriptions.Add("Mazda MX-5 Miata, joka on pieni ja ketterä legendaarinen roadster. Täydellinen valinta ajamisen ystäville.");
            imageDescriptions.Add("Honda vanhempana mallina edustaa luotettavuutta ja ajamisen iloista perinnettä.");
            imageDescriptions.Add("Tämä BMW:n vanha malli on ikoninen esimerkki klassisesta ajoneuvosta, jossa yhdistyvät tyyli ja suorituskyky.");
    }

       

        


        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void labelDecription_Click(object sender, EventArgs e)
        {
        }

        private void BackButton_Click_1(object sender, EventArgs e)
            {
                currentImageIndex = (currentImageIndex - 1 + images.Count) % images.Count;  // Liikutaav aijempaan kuvaan
                pictureBox1.Image = images[currentImageIndex];  
            }

            private void NextButton_Click_1(object sender, EventArgs e)
            {
                currentImageIndex = (currentImageIndex + 1) % images.Count;  // Seuraava kuva
                pictureBox1.Image = images[currentImageIndex];  
            }
        

        private void labelDecription_Click_1(object sender, EventArgs e)
        {

        }

        private void ESC_Click_1(object sender, EventArgs e)
        {

            // Takaisin nappi Form3
            Form3 form3 = new Form3();  
            form3.Show();               // NäytäForm3
            this.Hide();
        }

        private void labelDecription_MouseLeave(object sender, EventArgs e)
        {

        }

        private void labelDecription_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {

            // Piiloita kuvan tiedot kun hiiri lähtee pois kuvan päältä
            labelDecription.Visible = false;
        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {

            // Näyttää kuvan tiedot
            labelDecription.Text = imageDescriptions[currentImageIndex]; // Saadaan kirjoitus tämänhetkiselle kuvalle
            labelDecription.Visible = true; // Muutetaan näkyvyys todeksi
        }
    }
}
