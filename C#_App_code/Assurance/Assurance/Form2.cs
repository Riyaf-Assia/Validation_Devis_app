﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assurance
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void SetDevisDetails(Devis devis)
        {
            label1.Text = $"Type de véhicule : {devis.TypeVehicule}";
            label2.Text = $"Marque : {devis.Marque}";
            label3.Text = $"Modèle : {devis.Modele}";
            label4.Text = $"Coût des réparations estimé par le client : {devis.Montant}";
            label5.Text = $"Coût des réparations estimé par l’application : {devis.result}";
            int resultInt = Convert.ToInt32(devis.result);

            if (devis.Montant > resultInt)
            {
                label5.Text = $"Coût des réparations estimé par l’application : {devis.result}";
                label6.Text = $"Devis Client valide : Non";
            }
            else
            {
                label5.Text = $"Coût des réparations estimé par l’application : {devis.result}";
                label6.Text = $"Devis Client valide : Oui";
            }



        }
    }
}
