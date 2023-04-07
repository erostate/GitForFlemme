namespace MB_PRESENTATION
{
    partial class FrmDisplay
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
            this.btnInitFolder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComCommit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnSendOneCom = new System.Windows.Forms.Button();
            this.labelRepo = new System.Windows.Forms.Label();
            this.txtAddPcFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddPcName = new System.Windows.Forms.TextBox();
            this.btnAddPc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInitFolder
            // 
            this.btnInitFolder.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnInitFolder.Location = new System.Drawing.Point(593, 10);
            this.btnInitFolder.Name = "btnInitFolder";
            this.btnInitFolder.Size = new System.Drawing.Size(195, 30);
            this.btnInitFolder.TabIndex = 4;
            this.btnInitFolder.Text = "Initialiser le dossier LOCAL";
            this.btnInitFolder.UseVisualStyleBackColor = true;
            this.btnInitFolder.Click += new System.EventHandler(this.btnInitFolder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(78, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Envoyer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(596, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Récupérer";
            // 
            // txtComCommit
            // 
            this.txtComCommit.Font = new System.Drawing.Font("Ebrima", 10F);
            this.txtComCommit.Location = new System.Drawing.Point(12, 151);
            this.txtComCommit.Multiline = true;
            this.txtComCommit.Name = "txtComCommit";
            this.txtComCommit.Size = new System.Drawing.Size(282, 71);
            this.txtComCommit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 10F);
            this.label2.Location = new System.Drawing.Point(9, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Commentaire*";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnAdd.Location = new System.Drawing.Point(13, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCommit
            // 
            this.btnCommit.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnCommit.Location = new System.Drawing.Point(117, 248);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 30);
            this.btnCommit.TabIndex = 4;
            this.btnCommit.Text = "COMMIT";
            this.btnCommit.UseVisualStyleBackColor = true;
            // 
            // btnPush
            // 
            this.btnPush.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnPush.Location = new System.Drawing.Point(219, 248);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 30);
            this.btnPush.TabIndex = 5;
            this.btnPush.Text = "PUSH";
            this.btnPush.UseVisualStyleBackColor = true;
            // 
            // btnSendOneCom
            // 
            this.btnSendOneCom.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnSendOneCom.Location = new System.Drawing.Point(117, 329);
            this.btnSendOneCom.Name = "btnSendOneCom";
            this.btnSendOneCom.Size = new System.Drawing.Size(75, 30);
            this.btnSendOneCom.TabIndex = 2;
            this.btnSendOneCom.Text = "ALL";
            this.btnSendOneCom.UseVisualStyleBackColor = true;
            // 
            // labelRepo
            // 
            this.labelRepo.AutoSize = true;
            this.labelRepo.Font = new System.Drawing.Font("Ebrima", 15F);
            this.labelRepo.Location = new System.Drawing.Point(519, 151);
            this.labelRepo.Name = "labelRepo";
            this.labelRepo.Size = new System.Drawing.Size(58, 28);
            this.labelRepo.TabIndex = 18;
            this.labelRepo.Text = "Repo";
            // 
            // txtAddPcFolder
            // 
            this.txtAddPcFolder.Location = new System.Drawing.Point(129, 17);
            this.txtAddPcFolder.Name = "txtAddPcFolder";
            this.txtAddPcFolder.Size = new System.Drawing.Size(180, 20);
            this.txtAddPcFolder.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9F);
            this.label3.Location = new System.Drawing.Point(126, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Chemin du dossier LOCAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9F);
            this.label5.Location = new System.Drawing.Point(10, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nom du PC";
            // 
            // txtAddPcName
            // 
            this.txtAddPcName.Location = new System.Drawing.Point(13, 17);
            this.txtAddPcName.Name = "txtAddPcName";
            this.txtAddPcName.Size = new System.Drawing.Size(110, 20);
            this.txtAddPcName.TabIndex = 21;
            // 
            // btnAddPc
            // 
            this.btnAddPc.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnAddPc.Location = new System.Drawing.Point(315, 10);
            this.btnAddPc.Name = "btnAddPc";
            this.btnAddPc.Size = new System.Drawing.Size(68, 34);
            this.btnAddPc.TabIndex = 23;
            this.btnAddPc.Text = "Ajouter";
            this.btnAddPc.UseVisualStyleBackColor = true;
            // 
            // FrmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddPc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddPcName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddPcFolder);
            this.Controls.Add(this.labelRepo);
            this.Controls.Add(this.btnSendOneCom);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtComCommit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInitFolder);
            this.Name = "FrmDisplay";
            this.Text = "Git pour les flemmards";
            this.Load += new System.EventHandler(this.FrmDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInitFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComCommit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnSendOneCom;
        private System.Windows.Forms.Label labelRepo;
        private System.Windows.Forms.TextBox txtAddPcFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddPcName;
        private System.Windows.Forms.Button btnAddPc;
    }
}