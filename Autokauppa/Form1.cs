namespace Autokauppa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            // Tarkistetaan, ett‰ molemmat kent‰t on t‰ytetty
            while (string.IsNullOrWhiteSpace(UserNameBox.Text) || string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                MessageBox.Show("T‰yt‰ sek‰ k‰ytt‰j‰nimi ett‰ salasana ennen jatkamista!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Keskeytt‰‰ suorituksen, kunnes k‰ytt‰j‰ korjaa tilanteen
            }

            // Jos kent‰t on t‰ytetty, jatketaan eteenp‰in
            MessageBox.Show("Kaikki kent‰t on t‰ytetty. Voit jatkaa!", "Onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Jos molemmat kent‰t on t‰ytetty, avataan uusi formi
            CheckHuman newForm = new CheckHuman(); 
            newForm.Show();             
            this.Hide();
        }
    }
}
