using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autokauppa
{
    public partial class CheckHuman : Form
    {
        public CheckHuman()
        {
            InitializeComponent();
        }

        private void LaskuBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Photo1CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Photo2CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Photo3CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Photo4CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            // tarkistetaan onko oikein
            bool isTextCorrect = LaskuBox.Text == "23";

            if (isTextCorrect)
            {
                // Vaihdetaan väri vihreään
                CheckButton.BackColor = System.Drawing.Color.Green;

                // Lukitaan nappi ja vastaus
                LaskuBox.Enabled = false;
                CheckButton.Enabled = false;
            }
            else
            {
                // virhe ilmoitus
                MessageBox.Show("Väärä vastaus. Yritä uudelleen.", "Result",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContinueButton2_Click(object sender, EventArgs e)
        {

        }

        private void ContinueButton2_Click_1(object sender, EventArgs e)
        {
            // Check if LaskuBox is not empty and contains the correct value
            bool isTextCorrect = LaskuBox.Text == "23";

            // Check if the checkboxes are selected correctly
            bool areCheckBoxesCorrect =
                Photo1CheckBox.Checked &&
                Photo4CheckBox.Checked &&
                !(Photo2CheckBox.Checked || Photo3CheckBox.Checked);

            // Both conditions must be met to proceed
            if (isTextCorrect && areCheckBoxesCorrect)
            {
                // Open the next form
                Form3 nextForm = new Form3();
                nextForm.Show();

                // Hide current form
                this.Hide();
            }
            else
            {
                // Error message if conditions are not met
                MessageBox.Show("Väärä vastaus tai tyhjäksi jätetyt vastaukset. Yritä uudelleen tai täytä laatikot.", "Result",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
