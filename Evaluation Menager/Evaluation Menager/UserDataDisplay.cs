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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Evaluation_Menager
{
    public partial class Form1 : Form
    {
        public string ime { get; private set; }
        public string Ime { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<klasa2.Podaci> people = new List<klasa2.Podaci>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";  // Postavite početni direktorij pretraživanja na C:\

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;

                // Provjerite je li odabrana datoteka tekstualna
                if (Path.GetExtension(selectedFile).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(selectedFile);

                        foreach (string line in lines)
                        {
                            string[] parts = line.Split('=');
                            if (parts.Length == 2)
                            {
                                string key = parts[0].Trim();
                                string value = parts[1].Trim();
                                ShowData(key, value);
                            }
                        }

                        MessageBox.Show("Podaci uspješno učitani.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Došlo je do greške prilikom čitanja datoteke: " + ex.Message);
                    }
                    }
            }
        }

        private void ShowData(string key, string value)
        {
            switch (key)
            {
                case "Ime":
                    txtFullName.Text = value;
                    break;
                case "Prezime":
                    txtFullName.Text = value;
                    break;
                case "Godina rođenja":
                    txtYearOfBirth.Text = value;
                    break;
                case "Grad rođenja":
                    txtCity.Text = value;
                    break;
                case "Fakultet":
                    txtFaculty.Text = value;
                    break;
                case "Uloga":
                    txtRole.Text = value;
                    break;
                case "Najdraži kolegij":
                    txtRoleSpecificAttribute.Text = value;
                    break;
                case "Datoteci pristupljeno puta":
                    btnChooseFile.Text = value;
                    break;
                default:
                    break;
            }

        }
    }
}
