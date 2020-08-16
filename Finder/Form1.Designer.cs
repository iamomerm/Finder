namespace Finder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CB_Drives = new System.Windows.Forms.ComboBox();
            this.Label_Select_Drive = new System.Windows.Forms.Label();
            this.Btn_Scan = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.CLB_Files = new System.Windows.Forms.CheckedListBox();
            this.Label_Threshold = new System.Windows.Forms.Label();
            this.MTB_Threshold = new System.Windows.Forms.MaskedTextBox();
            this.CB_System_Files = new System.Windows.Forms.CheckBox();
            this.Footer = new System.Windows.Forms.Label();
            this.Seperator = new System.Windows.Forms.PictureBox();
            this.Label_Remove = new System.Windows.Forms.Label();
            this.Pic_Remove = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Seperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Remove)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Drives
            // 
            this.CB_Drives.FormattingEnabled = true;
            this.CB_Drives.Location = new System.Drawing.Point(175, 25);
            this.CB_Drives.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Drives.Name = "CB_Drives";
            this.CB_Drives.Size = new System.Drawing.Size(100, 29);
            this.CB_Drives.TabIndex = 0;
            // 
            // Label_Select_Drive
            // 
            this.Label_Select_Drive.AutoSize = true;
            this.Label_Select_Drive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Select_Drive.Location = new System.Drawing.Point(42, 25);
            this.Label_Select_Drive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Select_Drive.Name = "Label_Select_Drive";
            this.Label_Select_Drive.Size = new System.Drawing.Size(90, 21);
            this.Label_Select_Drive.TabIndex = 1;
            this.Label_Select_Drive.Text = "Select drive";
            // 
            // Btn_Scan
            // 
            this.Btn_Scan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(186)))), ((int)(((byte)(200)))));
            this.Btn_Scan.FlatAppearance.BorderSize = 0;
            this.Btn_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Scan.ForeColor = System.Drawing.Color.White;
            this.Btn_Scan.Location = new System.Drawing.Point(588, 614);
            this.Btn_Scan.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Scan.Name = "Btn_Scan";
            this.Btn_Scan.Size = new System.Drawing.Size(150, 29);
            this.Btn_Scan.TabIndex = 2;
            this.Btn_Scan.Text = "Scan";
            this.Btn_Scan.UseVisualStyleBackColor = true;
            this.Btn_Scan.Click += new System.EventHandler(this.ButtonScanClick);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(138)))), ((int)(((byte)(143)))));
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.ForeColor = System.Drawing.Color.White;
            this.Btn_Exit.Location = new System.Drawing.Point(430, 614);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(150, 29);
            this.Btn_Exit.TabIndex = 3;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // CLB_Files
            // 
            this.CLB_Files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CLB_Files.CheckOnClick = true;
            this.CLB_Files.FormattingEnabled = true;
            this.CLB_Files.HorizontalScrollbar = true;
            this.CLB_Files.Location = new System.Drawing.Point(46, 172);
            this.CLB_Files.Margin = new System.Windows.Forms.Padding(4);
            this.CLB_Files.Name = "CLB_Files";
            this.CLB_Files.Size = new System.Drawing.Size(692, 384);
            this.CLB_Files.TabIndex = 4;
            // 
            // Label_Threshold
            // 
            this.Label_Threshold.AutoSize = true;
            this.Label_Threshold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Threshold.Location = new System.Drawing.Point(42, 65);
            this.Label_Threshold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Threshold.Name = "Label_Threshold";
            this.Label_Threshold.Size = new System.Drawing.Size(116, 21);
            this.Label_Threshold.TabIndex = 5;
            this.Label_Threshold.Text = "Threshold (Mb)";
            // 
            // MTB_Threshold
            // 
            this.MTB_Threshold.Location = new System.Drawing.Point(175, 62);
            this.MTB_Threshold.Margin = new System.Windows.Forms.Padding(4);
            this.MTB_Threshold.Mask = "0000";
            this.MTB_Threshold.Name = "MTB_Threshold";
            this.MTB_Threshold.PromptChar = '#';
            this.MTB_Threshold.Size = new System.Drawing.Size(100, 29);
            this.MTB_Threshold.TabIndex = 6;
            this.MTB_Threshold.Text = "0100";
            // 
            // CB_System_Files
            // 
            this.CB_System_Files.AutoSize = true;
            this.CB_System_Files.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CB_System_Files.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CB_System_Files.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.CB_System_Files.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.CB_System_Files.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CB_System_Files.Location = new System.Drawing.Point(46, 132);
            this.CB_System_Files.Margin = new System.Windows.Forms.Padding(4);
            this.CB_System_Files.Name = "CB_System_Files";
            this.CB_System_Files.Size = new System.Drawing.Size(112, 25);
            this.CB_System_Files.TabIndex = 7;
            this.CB_System_Files.Text = "System files";
            this.CB_System_Files.UseVisualStyleBackColor = true;
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.Footer.Location = new System.Drawing.Point(0, 595);
            this.Footer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(785, 70);
            this.Footer.TabIndex = 9;
            // 
            // Seperator
            // 
            this.Seperator.Image = ((System.Drawing.Image)(resources.GetObject("Seperator.Image")));
            this.Seperator.Location = new System.Drawing.Point(-2, 109);
            this.Seperator.Name = "Seperator";
            this.Seperator.Size = new System.Drawing.Size(797, 3);
            this.Seperator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Seperator.TabIndex = 10;
            this.Seperator.TabStop = false;
            // 
            // Label_Remove
            // 
            this.Label_Remove.AutoSize = true;
            this.Label_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.Label_Remove.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Label_Remove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Remove.ForeColor = System.Drawing.Color.White;
            this.Label_Remove.Location = new System.Drawing.Point(65, 618);
            this.Label_Remove.Name = "Label_Remove";
            this.Label_Remove.Size = new System.Drawing.Size(67, 21);
            this.Label_Remove.TabIndex = 11;
            this.Label_Remove.Text = "Remove";
            this.Label_Remove.Click += new System.EventHandler(this.LabelRemoveClick);
            // 
            // Pic_Remove
            // 
            this.Pic_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.Pic_Remove.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Remove.Image")));
            this.Pic_Remove.Location = new System.Drawing.Point(46, 620);
            this.Pic_Remove.Name = "Pic_Remove";
            this.Pic_Remove.Size = new System.Drawing.Size(18, 19);
            this.Pic_Remove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pic_Remove.TabIndex = 13;
            this.Pic_Remove.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.Pic_Remove);
            this.Controls.Add(this.Label_Remove);
            this.Controls.Add(this.Seperator);
            this.Controls.Add(this.CB_System_Files);
            this.Controls.Add(this.MTB_Threshold);
            this.Controls.Add(this.Label_Threshold);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Scan);
            this.Controls.Add(this.Label_Select_Drive);
            this.Controls.Add(this.CB_Drives);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.CLB_Files);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Seperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Remove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Drives;
        private System.Windows.Forms.Label Label_Select_Drive;
        private System.Windows.Forms.Button Btn_Scan;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.CheckedListBox CLB_Files;
        private System.Windows.Forms.Label Label_Threshold;
        private System.Windows.Forms.MaskedTextBox MTB_Threshold;
        private System.Windows.Forms.CheckBox CB_System_Files;
        private System.Windows.Forms.Label Footer;
        private System.Windows.Forms.PictureBox Seperator;
        private System.Windows.Forms.Label Label_Remove;
        private System.Windows.Forms.PictureBox Pic_Remove;
    }
}

