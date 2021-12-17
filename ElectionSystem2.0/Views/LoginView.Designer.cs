namespace ElectionSystem2._0
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.voterRDB = new System.Windows.Forms.RadioButton();
            this.ballotCommitteeRDB = new System.Windows.Forms.RadioButton();
            this.electionCommitteeRDB = new System.Windows.Forms.RadioButton();
            this.userRDB = new System.Windows.Forms.RadioButton();
            this.launchBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // voterRDB
            // 
            this.voterRDB.AutoSize = true;
            this.voterRDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.voterRDB.Location = new System.Drawing.Point(12, 46);
            this.voterRDB.Name = "voterRDB";
            this.voterRDB.Size = new System.Drawing.Size(80, 29);
            this.voterRDB.TabIndex = 0;
            this.voterRDB.TabStop = true;
            this.voterRDB.Text = "Voter";
            this.voterRDB.UseVisualStyleBackColor = true;
            // 
            // ballotCommitteeRDB
            // 
            this.ballotCommitteeRDB.AutoSize = true;
            this.ballotCommitteeRDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ballotCommitteeRDB.Location = new System.Drawing.Point(12, 192);
            this.ballotCommitteeRDB.Name = "ballotCommitteeRDB";
            this.ballotCommitteeRDB.Size = new System.Drawing.Size(180, 29);
            this.ballotCommitteeRDB.TabIndex = 1;
            this.ballotCommitteeRDB.TabStop = true;
            this.ballotCommitteeRDB.Text = "Ballot Committee";
            this.ballotCommitteeRDB.UseVisualStyleBackColor = true;
            // 
            // electionCommitteeRDB
            // 
            this.electionCommitteeRDB.AutoSize = true;
            this.electionCommitteeRDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.electionCommitteeRDB.Location = new System.Drawing.Point(12, 145);
            this.electionCommitteeRDB.Name = "electionCommitteeRDB";
            this.electionCommitteeRDB.Size = new System.Drawing.Size(201, 29);
            this.electionCommitteeRDB.TabIndex = 2;
            this.electionCommitteeRDB.TabStop = true;
            this.electionCommitteeRDB.Text = "Election Committee";
            this.electionCommitteeRDB.UseVisualStyleBackColor = true;
            // 
            // userRDB
            // 
            this.userRDB.AutoSize = true;
            this.userRDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userRDB.Location = new System.Drawing.Point(12, 93);
            this.userRDB.Name = "userRDB";
            this.userRDB.Size = new System.Drawing.Size(85, 29);
            this.userRDB.TabIndex = 3;
            this.userRDB.TabStop = true;
            this.userRDB.Text = "Usher";
            this.userRDB.UseVisualStyleBackColor = true;
            // 
            // launchBTN
            // 
            this.launchBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.launchBTN.Location = new System.Drawing.Point(12, 251);
            this.launchBTN.Name = "launchBTN";
            this.launchBTN.Size = new System.Drawing.Size(217, 43);
            this.launchBTN.TabIndex = 4;
            this.launchBTN.Text = "Launch";
            this.launchBTN.UseVisualStyleBackColor = true;
            this.launchBTN.Click += new System.EventHandler(this.LaunchBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Your Role:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 280);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(554, 306);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.launchBTN);
            this.Controls.Add(this.userRDB);
            this.Controls.Add(this.electionCommitteeRDB);
            this.Controls.Add(this.ballotCommitteeRDB);
            this.Controls.Add(this.voterRDB);
            this.Name = "LoginView";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton voterRDB;
        private System.Windows.Forms.RadioButton ballotCommitteeRDB;
        private System.Windows.Forms.RadioButton electionCommitteeRDB;
        private System.Windows.Forms.RadioButton userRDB;
        private System.Windows.Forms.Button launchBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

