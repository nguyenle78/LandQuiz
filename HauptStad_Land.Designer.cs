
namespace NguyenLe_QuizProject
{
    partial class HauptStad_Land
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
            this.labelFrage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonZumEinstellung = new System.Windows.Forms.Button();
            this.labelFrageNr = new System.Windows.Forms.Label();
            this.pictureBoxFrage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFrage
            // 
            this.labelFrage.AutoSize = true;
            this.labelFrage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFrage.Location = new System.Drawing.Point(39, 92);
            this.labelFrage.Name = "labelFrage";
            this.labelFrage.Size = new System.Drawing.Size(217, 21);
            this.labelFrage.TabIndex = 0;
            this.labelFrage.Text = "Was ist die Hauptstadt von ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(39, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anwort";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton4.Location = new System.Drawing.Point(236, 136);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton3.Location = new System.Drawing.Point(236, 35);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton2.Location = new System.Drawing.Point(18, 136);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton1.Location = new System.Drawing.Point(18, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(39, 433);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(136, 37);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Nächste Frage";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(39, 29);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(67, 15);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "Wilkomen, ";
            // 
            // buttonZumEinstellung
            // 
            this.buttonZumEinstellung.Location = new System.Drawing.Point(308, 433);
            this.buttonZumEinstellung.Name = "buttonZumEinstellung";
            this.buttonZumEinstellung.Size = new System.Drawing.Size(136, 37);
            this.buttonZumEinstellung.TabIndex = 4;
            this.buttonZumEinstellung.Text = "Zurück zur Einstellung";
            this.buttonZumEinstellung.UseVisualStyleBackColor = true;
            this.buttonZumEinstellung.Click += new System.EventHandler(this.buttonZumEinstellung_Click);
            // 
            // labelFrageNr
            // 
            this.labelFrageNr.AutoSize = true;
            this.labelFrageNr.Location = new System.Drawing.Point(39, 57);
            this.labelFrageNr.Name = "labelFrageNr";
            this.labelFrageNr.Size = new System.Drawing.Size(55, 15);
            this.labelFrageNr.TabIndex = 5;
            this.labelFrageNr.Text = "Frage Nr.";
            // 
            // pictureBoxFrage
            // 
            this.pictureBoxFrage.Location = new System.Drawing.Point(39, 75);
            this.pictureBoxFrage.Name = "pictureBoxFrage";
            this.pictureBoxFrage.Size = new System.Drawing.Size(117, 66);
            this.pictureBoxFrage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFrage.TabIndex = 6;
            this.pictureBoxFrage.TabStop = false;
            // 
            // HauptStad_Land
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 512);
            this.Controls.Add(this.pictureBoxFrage);
            this.Controls.Add(this.labelFrageNr);
            this.Controls.Add(this.buttonZumEinstellung);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelFrage);
            this.Name = "HauptStad_Land";
            this.Text = "HauptStad_Land";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFrage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonZumEinstellung;
        private System.Windows.Forms.Label labelFrageNr;
        private System.Windows.Forms.PictureBox pictureBoxFrage;
    }
}