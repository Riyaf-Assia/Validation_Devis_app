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
    public partial class Form3 : Form
    {
        private Devis devis;
        private Form1 parentForm;
        private Form1 form1;
        private string pythonExe = @"C:\Users\hp\AppData\Local\Programs\Python\Python312\python.exe";
        private string result;

        public Form3(List<string> imagePaths)
        {
            InitializeComponent();
            this.devis = devis;
            this.parentForm = parentForm;

            // Afficher les images enregistrées
            AddPictureBoxes(imagePaths);
        }
        public class Tools
        {
            public static string ExecuteCmdLine(string fileName, string cmd)
            {
                try
                {
                    Process process = new Process();

                    if (fileName != null && !string.Empty.Equals(fileName))
                    {
                        process.StartInfo.FileName = fileName;
                        process.StartInfo.Arguments = cmd;
                    }
                    else
                    {
                        process.StartInfo.FileName = cmd;
                    }

                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    process.Close();
                    return output;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public Form3(List<string> imagePaths, Devis devis, Form1 form1) : this(imagePaths)
        {
            this.devis = devis;
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Fermer la fenêtre Form3 lorsque le bouton 2 est cliqué
            var path = @"C:\Users\hp\Desktop\modele zettam";
            string pathFilePython = Path.Combine(path, "fichierMain1.py");

            if (pathFilePython.Contains(" "))
                pathFilePython = "\"" + pathFilePython + "\"";

            string treatementControlFilMdf = string.Empty;
            treatementControlFilMdf = Tools.ExecuteCmdLine(pythonExe, pathFilePython);
            string result = Tools.ExecuteCmdLine(pythonExe, $"{pathFilePython} {devis.Montant}");

            try
            {
                
                devis.result = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Form2 form2 = new Form2();
            form2.SetDevisDetails(devis);
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Fermer la fenêtre Form3 lorsque le bouton 2 est cliqué
            
        }

        public void SetDevisDetails(Devis devis)
        {
            labelTypeVehicule.Text = $"Type de véhicule : {devis.TypeVehicule}";
            labelMarque.Text = $"Marque : {devis.Marque}";
            labelModele.Text = $"Modèle : {devis.Modele}";
            labelMontant.Text = $"Montant : {devis.Montant}";
        }

        private void AddPictureBoxes(List<string> imagePaths)
        {
            // Supprimez d'abord tous les contrôles PictureBox existants
            foreach (Control control in Controls)
            {
                if (control is PictureBox)
                {
                    Controls.Remove(control);
                    control.Dispose();
                }
            }

            int pictureBoxWidth = 150;
            int pictureBoxHeight = 150;
            int spacing = 10;
            int initialX = 40;
            int initialY = 70;
            int pictureBoxCount = 0;

            // Ajoutez dynamiquement les PictureBox pour chaque chemin d'image
            foreach (string imagePath in imagePaths)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = pictureBoxWidth;
                pictureBox.Height = pictureBoxHeight;
                pictureBox.Location = new Point(initialX + (pictureBoxWidth + spacing) * pictureBoxCount, initialY);

                // Ajoutez le PictureBox à la fenêtre de formulaire
                Controls.Add(pictureBox);

                pictureBoxCount++;

                // Si on a ajouté 6 PictureBox, on passe à la ligne suivante
                if (pictureBoxCount % 6 == 0)
                {
                    initialY += pictureBoxHeight + spacing;
                    initialX = 10;
                }
            }
        }

        private void labelMarque_Click(object sender, EventArgs e)
        {

        }

        private void labelModele_Click(object sender, EventArgs e)
        {

        }

        private void labelMontant_Click(object sender, EventArgs e)
        {

        }

        private void labelTypeVehicule_Click(object sender, EventArgs e)
        {

        }
    }

}
