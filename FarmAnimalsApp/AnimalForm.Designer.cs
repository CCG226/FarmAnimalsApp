using System.Windows.Forms;

namespace FarmAnimalsApp
{
    partial class AnimalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            selectLabel = new Label();
            animalDropdown = new ComboBox();
            selectBtn = new Button();
            animalPicture = new PictureBox();
            soundIcon = new PictureBox();
            soundLabel = new Label();
            playLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)animalPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)soundIcon).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.Location = new Point(273, 32);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(289, 46);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Animal Farm Sounds";
            // 
            // selectLabel
            // 
            selectLabel.AutoSize = true;
            selectLabel.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            selectLabel.Location = new Point(189, 87);
            selectLabel.Name = "selectLabel";
            selectLabel.Size = new Size(131, 25);
            selectLabel.TabIndex = 2;
            selectLabel.Text = "Select Animal: ";
            // 
            // animalDropdown
            // 
            animalDropdown.FormattingEnabled = true;
            animalDropdown.Location = new Point(323, 86);
            animalDropdown.Name = "animalDropdown";
            animalDropdown.Size = new Size(151, 28);
            animalDropdown.TabIndex = 5;
            // 
            // selectBtn
            // 
            selectBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            selectBtn.Location = new Point(501, 83);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(75, 35);
            selectBtn.TabIndex = 1;
            selectBtn.Text = "Enter";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += selectBtn_Click;
            // 
            // animalPicture
            // 
            animalPicture.Location = new Point(189, 231);
            animalPicture.Name = "animalPicture";
            animalPicture.Size = new Size(131, 132);
            animalPicture.TabIndex = 6;
            animalPicture.TabStop = false;
            // 
            // soundIcon
            // 
            soundIcon.Location = new Point(496, 269);
            soundIcon.Name = "soundIcon";
            soundIcon.Size = new Size(66, 62);
            soundIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            soundIcon.TabIndex = 7;
            soundIcon.TabStop = false;
            soundIcon.Visible = false;
            soundIcon.Click += soundIcon_Click;
            // 
            // soundLabel
            // 
            soundLabel.AutoSize = true;
            soundLabel.Location = new Point(189, 167);
            soundLabel.Name = "soundLabel";
            soundLabel.Size = new Size(0, 20);
            soundLabel.TabIndex = 8;
            // 
            // playLabel
            // 
            playLabel.AutoSize = true;
            playLabel.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            playLabel.Location = new Point(478, 231);
            playLabel.Name = "playLabel";
            playLabel.Size = new Size(107, 25);
            playLabel.TabIndex = 9;
            playLabel.Text = "Play Sound:";
            playLabel.Visible = false;
            // 
            // AnimalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(playLabel);
            Controls.Add(soundLabel);
            Controls.Add(soundIcon);
            Controls.Add(animalPicture);
            Controls.Add(selectBtn);
            Controls.Add(animalDropdown);
            Controls.Add(selectLabel);
            Controls.Add(titleLabel);
            Name = "AnimalForm";
            Text = "AnimalForm";
            ((System.ComponentModel.ISupportInitialize)animalPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)soundIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label selectLabel;
        private ComboBox animalDropdown;
        private Button selectBtn;
        private PictureBox animalPicture;
        private PictureBox soundIcon;
        private Label soundLabel;
        private Label playLabel;
    }
}
