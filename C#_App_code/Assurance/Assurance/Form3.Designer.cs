namespace Assurance
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTypeVehicule = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMarque = new System.Windows.Forms.Label();
            this.labelModele = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTypeVehicule
            // 
            this.labelTypeVehicule.AutoSize = true;
            this.labelTypeVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeVehicule.Location = new System.Drawing.Point(202, 383);
            this.labelTypeVehicule.Name = "labelTypeVehicule";
            this.labelTypeVehicule.Size = new System.Drawing.Size(70, 25);
            this.labelTypeVehicule.TabIndex = 0;
            this.labelTypeVehicule.Text = "label1";
            this.labelTypeVehicule.Click += new System.EventHandler(this.labelTypeVehicule_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Images Télechargées :";
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarque.Location = new System.Drawing.Point(202, 440);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(70, 25);
            this.labelMarque.TabIndex = 5;
            this.labelMarque.Text = "label1";
            this.labelMarque.Click += new System.EventHandler(this.labelMarque_Click);
            // 
            // labelModele
            // 
            this.labelModele.AutoSize = true;
            this.labelModele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModele.Location = new System.Drawing.Point(202, 496);
            this.labelModele.Name = "labelModele";
            this.labelModele.Size = new System.Drawing.Size(70, 25);
            this.labelModele.TabIndex = 6;
            this.labelModele.Text = "label1";
            this.labelModele.Click += new System.EventHandler(this.labelModele_Click);
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontant.Location = new System.Drawing.Point(202, 552);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(70, 25);
            this.labelMontant.TabIndex = 7;
            this.labelMontant.Text = "label1";
            this.labelMontant.Click += new System.EventHandler(this.labelMontant_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(790, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 76);
            this.button1.TabIndex = 8;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(930, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 76);
            this.button2.TabIndex = 9;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1082, 651);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelModele);
            this.Controls.Add(this.labelMarque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTypeVehicule);
            this.Name = "Form3";
            this.Text = "ENREGISTREMENT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTypeVehicule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMarque;
        private System.Windows.Forms.Label labelModele;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}