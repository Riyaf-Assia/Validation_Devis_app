using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assurance
{
    

    

    public partial class Form1 : Form
    {

        private Devis devis;
        private OpenFileDialog openFileDialog;
        

        public Form1()
        {
            InitializeComponent();
            devis = new Devis();
            openFileDialog = new OpenFileDialog();
            // Définir les propriétés d'ancrage des boutons
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left; // Par exemple, ancrer le bouton en haut à gauche
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right; // Par exemple, ancrer le bouton en haut à droite
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right; // Par exemple, ancrer le bouton en bas à droite
                                                                       // Ajouter l'événement FormClosing
            this.FormClosing += Form1_FormClosing;
            InitializeTesterButton();

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string dossierDestination = @"C:\Users\hp\Downloads\assia (5)\assia\assia\data3a\test";

            if (System.IO.Directory.Exists(dossierDestination))
            {
                string[] fichiers = System.IO.Directory.GetFiles(dossierDestination);

                foreach (string fichier in fichiers)
                {
                    System.IO.File.Delete(fichier);
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void InitializeTesterButton()
        {
           
            
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Images (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dossierDestination = @"C:\Users\hp\Downloads\assia (5)\assia\assia\data3a\test";

                if (!System.IO.Directory.Exists(dossierDestination))
                {
                    System.IO.Directory.CreateDirectory(dossierDestination);
                }

                foreach (string fileName in openFileDialog.FileNames)
                {
                    string cheminDestination = System.IO.Path.Combine(dossierDestination, System.IO.Path.GetFileName(fileName));
                    System.IO.File.Copy(fileName, cheminDestination, true);
                    Console.WriteLine($"Fichier enregistré : {cheminDestination}");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            devis.TypeVehicule = comboBox1.SelectedItem?.ToString();
            comboBox2.Items.Clear();

            if (devis.TypeVehicule == "Voiture")
            {
                comboBox2.Items.Add("DACIA");
                comboBox2.Items.Add("MERCEDES");
                comboBox2.Items.Add("TOYOTA");
            }
            else if (devis.TypeVehicule == "Moto")
            {
                comboBox2.Items.Add("YAMAHA");
                comboBox2.Items.Add("HONDA");
                comboBox2.Items.Add("KAWASAKI");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            devis.Marque = comboBox2.SelectedItem?.ToString();
            comboBox3.Items.Clear();

            if (devis.Marque == "DACIA")
            {
                comboBox3.Items.Add("DACIA2000");
                comboBox3.Items.Add("DACIA2001");
                comboBox3.Items.Add("DACIA2002");
            }
            else if (devis.Marque == "MERCEDES")
            {
                comboBox3.Items.Add("MERCEDES2000");
                comboBox3.Items.Add("MERCEDES2001");
                comboBox3.Items.Add("MERCEDES2002");
            }
            else if (devis.Marque == "TOYOTA")
            {
                comboBox3.Items.Add("TOYOTA2000");
                comboBox3.Items.Add("TOYOTA2001");
                comboBox3.Items.Add("TOYOTA2002");
            }
            else if (devis.Marque == "YAMAHA")
            {
                comboBox3.Items.Add("YAMAHA2000");
                comboBox3.Items.Add("YAMAHA2001");
                comboBox3.Items.Add("YAMAHA2002");
            }
            else if (devis.Marque == "HONDA")
            {
                comboBox3.Items.Add("HONDA2000");
                comboBox3.Items.Add("HONDA2001");
                comboBox3.Items.Add("HONDA2002");
            }
            else if (devis.Marque == "KAWASAKI")
            {
                comboBox3.Items.Add("KAWASAKI2000");
                comboBox3.Items.Add("KAWASAKI2001");
                comboBox3.Items.Add("KAWASAKI2002");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            devis.Modele = comboBox3.SelectedItem?.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal montant))
            {
                devis.Montant = montant;
            }
            else
            {
                MessageBox.Show("Veuillez saisir un montant valide.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form3 form3 = new Form3(openFileDialog.FileNames.ToList(), devis, this);
            form3.SetDevisDetails(devis);
            form3.ShowDialog();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Voiture");
            comboBox1.Items.Add("Moto");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Images (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dossierDestination = @"C:\Users\hp\Downloads\assia (5)\assia\assia\data3a\test";

                if (!System.IO.Directory.Exists(dossierDestination))
                {
                    System.IO.Directory.CreateDirectory(dossierDestination);
                }

                foreach (string fileName in openFileDialog.FileNames)
                {
                    string cheminDestination = System.IO.Path.Combine(dossierDestination, System.IO.Path.GetFileName(fileName));
                    System.IO.File.Copy(fileName, cheminDestination, true);
                    Console.WriteLine($"Fichier enregistré : {cheminDestination}");
                }
            }
            Form6 form6 = new Form6(openFileDialog.FileNames.ToList());
            
            form6.ShowDialog();

        }
    }
    public class Devis
    {
        public string TypeVehicule { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public decimal Montant { get; set; }
        public string result { get; set; }
    }

}
