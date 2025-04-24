using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static Assurance.Form3;

namespace Assurance
{
    public partial class Form6 : Form
    {
        private string pythonExe = @"C:\Users\hp\AppData\Local\Programs\Python\Python312\python.exe";

        public Form6(List<string> imagePaths)
        {
            InitializeComponent();
            AddPictureBoxes(imagePaths);
        }
        private void DeleteImagesFromTestFolder()
        {
            string dossierDestination = @"C:\Users\hp\Downloads\assia (5)\assia\assia\data3a\test";

            if (Directory.Exists(dossierDestination))
            {
                string[] fichiers = Directory.GetFiles(dossierDestination);

                foreach (string fichier in fichiers)
                {
                    File.Delete(fichier);
                }
            }
        }

        private void AddPictureBoxes(List<string> imagePaths)
        {
            int pictureBoxWidth = 120;
            int pictureBoxHeight = 120;
            int spacing = 10;
            int initialX = 40;
            int initialY = 70;
            int maxPerRow = 6;
            int pictureBoxCount = 0;

            foreach (string imagePath in imagePaths)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = pictureBoxWidth;
                pictureBox.Height = pictureBoxHeight;

                // Calcul de la position X et Y en fonction de pictureBoxCount
                int posX = initialX + (pictureBoxWidth + spacing) * (pictureBoxCount % maxPerRow);
                int posY = initialY + (pictureBoxHeight + spacing) * (pictureBoxCount / maxPerRow);

                pictureBox.Location = new Point(posX, posY);

                Controls.Add(pictureBox);

                pictureBoxCount++;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Fermer la fenêtre Form6 lorsque le bouton est cliqué
            this.Close();
            

            // Chemin vers le fichier Python à exécuter
            var pathFilePython = @"C:\Users\hp\Desktop\modele zettam\fichierMain.py";

            // Si le chemin contient des espaces, ajoutez des guillemets
            if (pathFilePython.Contains(" "))
                pathFilePython = $"\"{pathFilePython}\"";

            try
            {
                // Exécutez le script Python et récupérez la sortie
                string output = Tools.ExecuteCmdLine(pythonExe, pathFilePython);

                // Affichez la sortie dans une boîte de dialogue
                MessageBox.Show(output, "Résultat de l'exécution Python", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Affichez une boîte de dialogue en cas d'erreur
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DeleteImagesFromTestFolder();
        }
    }
}
