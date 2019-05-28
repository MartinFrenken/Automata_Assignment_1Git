namespace Automata_Assignment_1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.isDetInfo = new System.Windows.Forms.Label();
            this.inputWordBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.isDetLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 612);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // isDetInfo
            // 
            this.isDetInfo.AutoSize = true;
            this.isDetInfo.Location = new System.Drawing.Point(1, 8);
            this.isDetInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isDetInfo.Name = "isDetInfo";
            this.isDetInfo.Size = new System.Drawing.Size(84, 13);
            this.isDetInfo.TabIndex = 1;
            this.isDetInfo.Text = "Is Deterministic: ";
            // 
            // inputWordBox
            // 
            this.inputWordBox.Location = new System.Drawing.Point(837, 187);
            this.inputWordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputWordBox.Name = "inputWordBox";
            this.inputWordBox.Size = new System.Drawing.Size(76, 20);
            this.inputWordBox.TabIndex = 2;
            this.inputWordBox.TextChanged += new System.EventHandler(this.inputWordBox_TextChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(838, 217);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(40, 13);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result:";
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(924, 186);
            this.checkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(56, 19);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.isDetLbl);
            this.panel1.Controls.Add(this.isDetInfo);
            this.panel1.Location = new System.Drawing.Point(837, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 85);
            this.panel1.TabIndex = 5;
            // 
            // isDetLbl
            // 
            this.isDetLbl.AutoSize = true;
            this.isDetLbl.Location = new System.Drawing.Point(84, 8);
            this.isDetLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isDetLbl.Name = "isDetLbl";
            this.isDetLbl.Size = new System.Drawing.Size(0, 13);
            this.isDetLbl.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 647);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.inputWordBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "bottom text";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label isDetInfo;
        private System.Windows.Forms.TextBox inputWordBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label isDetLbl;
    }
}

