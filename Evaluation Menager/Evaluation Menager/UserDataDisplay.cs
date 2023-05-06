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

namespace Evaluation_Menager
{
    public partial class Form1 : Form
    {
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
                        // Učitajte sadržaj datoteke
                        string fileContent = File.ReadAllText(selectedFile);

                        // Ispis sadržaja datoteke u dijaloškom okviru poruke
                        MessageBox.Show("Sadržaj odabrane datoteke:\n\n" + fileContent);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Greška prilikom čitanja datoteke: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Odabrana datoteka nije tekstualna datoteka (.txt).");

                }
            }        
        }
    }
}
