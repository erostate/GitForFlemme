namespace GitForFlemme
{
    partial class Connect
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
            this.btnYeet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listRepo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRepo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.namespaceRepo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.createRepo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYeet
            // 
            this.btnYeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnYeet.Location = new System.Drawing.Point(682, 403);
            this.btnYeet.Name = "btnYeet";
            this.btnYeet.Size = new System.Drawing.Size(75, 23);
            this.btnYeet.TabIndex = 0;
            this.btnYeet.Text = "YEET";
            this.btnYeet.UseVisualStyleBackColor = true;
            this.btnYeet.Click += new System.EventHandler(this.btnYeet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(130, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choisissez un Repo";
            // 
            // listRepo
            // 
            this.listRepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(59)))));
            this.listRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listRepo.ForeColor = System.Drawing.SystemColors.Control;
            this.listRepo.FormattingEnabled = true;
            this.listRepo.ItemHeight = 16;
            this.listRepo.Location = new System.Drawing.Point(133, 81);
            this.listRepo.Name = "listRepo";
            this.listRepo.Size = new System.Drawing.Size(169, 292);
            this.listRepo.TabIndex = 3;
            this.listRepo.SelectedIndexChanged += new System.EventHandler(this.listRepo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(351, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "OU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(440, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Créez-en un";
            // 
            // labelRepo
            // 
            this.labelRepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(59)))));
            this.labelRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRepo.Location = new System.Drawing.Point(443, 138);
            this.labelRepo.Name = "labelRepo";
            this.labelRepo.Size = new System.Drawing.Size(227, 23);
            this.labelRepo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(440, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Label";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(440, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nom du Repo";
            // 
            // namespaceRepo
            // 
            this.namespaceRepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(59)))));
            this.namespaceRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.namespaceRepo.Location = new System.Drawing.Point(443, 218);
            this.namespaceRepo.Name = "namespaceRepo";
            this.namespaceRepo.Size = new System.Drawing.Size(227, 23);
            this.namespaceRepo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(440, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ex: coucouGit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(440, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ex: erostate/coucouGit";
            // 
            // createRepo
            // 
            this.createRepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(59)))));
            this.createRepo.FlatAppearance.BorderSize = 0;
            this.createRepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.createRepo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createRepo.Location = new System.Drawing.Point(595, 269);
            this.createRepo.Name = "createRepo";
            this.createRepo.Size = new System.Drawing.Size(75, 31);
            this.createRepo.TabIndex = 12;
            this.createRepo.Text = "Créer";
            this.createRepo.UseVisualStyleBackColor = false;
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createRepo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.namespaceRepo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelRepo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listRepo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYeet);
            this.Name = "Connect";
            this.Text = "Git pour les flemmards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRepo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox labelRepo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox namespaceRepo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button createRepo;
    }
}

