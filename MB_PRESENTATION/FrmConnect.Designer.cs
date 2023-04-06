
namespace MB_PRESENTATION
{
    partial class FrmConnect
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listRepo = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreateRepo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 10F);
            this.label1.Location = new System.Drawing.Point(413, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Label*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // txtLabel
            // 
            this.txtLabel.Font = new System.Drawing.Font("Ebrima", 10F);
            this.txtLabel.Location = new System.Drawing.Point(416, 126);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(330, 26);
            this.txtLabel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(412, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Créer un Repo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 10F);
            this.label6.Location = new System.Drawing.Point(47, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 11;
            // 
            // txtNamespace
            // 
            this.txtNamespace.Font = new System.Drawing.Font("Ebrima", 10F);
            this.txtNamespace.Location = new System.Drawing.Point(416, 183);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(330, 26);
            this.txtNamespace.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 10F);
            this.label3.Location = new System.Drawing.Point(413, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Namespace*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(46, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Créer un Repo";
            // 
            // listRepo
            // 
            this.listRepo.FormattingEnabled = true;
            this.listRepo.Location = new System.Drawing.Point(51, 84);
            this.listRepo.Name = "listRepo";
            this.listRepo.Size = new System.Drawing.Size(205, 303);
            this.listRepo.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(304, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "OU";
            // 
            // btnCreateRepo
            // 
            this.btnCreateRepo.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnCreateRepo.Location = new System.Drawing.Point(671, 239);
            this.btnCreateRepo.Name = "btnCreateRepo";
            this.btnCreateRepo.Size = new System.Drawing.Size(75, 30);
            this.btnCreateRepo.TabIndex = 17;
            this.btnCreateRepo.Text = "Valider";
            this.btnCreateRepo.UseVisualStyleBackColor = true;
            this.btnCreateRepo.Click += new System.EventHandler(this.btnCreateRepo_Click);
            // 
            // FrmConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateRepo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listRepo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamespace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmConnect";
            this.Text = "Git pour les flemmards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listRepo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreateRepo;
    }
}

