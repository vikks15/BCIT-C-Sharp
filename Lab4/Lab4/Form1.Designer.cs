﻿namespace Lab4
{
    partial class Lab4Form
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
            this.SearchWordButton = new System.Windows.Forms.Button();
            this.choosefile = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.Timer1 = new System.Windows.Forms.Label();
            this.Timer1Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WordsCountBox = new System.Windows.Forms.TextBox();
            this.EnterWordLabel = new System.Windows.Forms.Label();
            this.EnterWordBox = new System.Windows.Forms.TextBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.Timer2Box = new System.Windows.Forms.TextBox();
            this.Timer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchWordButton
            // 
            this.SearchWordButton.Location = new System.Drawing.Point(279, 300);
            this.SearchWordButton.Name = "SearchWordButton";
            this.SearchWordButton.Size = new System.Drawing.Size(82, 29);
            this.SearchWordButton.TabIndex = 1;
            this.SearchWordButton.Text = "Search word";
            this.SearchWordButton.UseVisualStyleBackColor = true;
            this.SearchWordButton.Click += new System.EventHandler(this.SearchWordButton_Click);
            // 
            // choosefile
            // 
            this.choosefile.Location = new System.Drawing.Point(159, 301);
            this.choosefile.Name = "choosefile";
            this.choosefile.Size = new System.Drawing.Size(84, 28);
            this.choosefile.TabIndex = 2;
            this.choosefile.Text = "Choose file";
            this.choosefile.UseVisualStyleBackColor = true;
            this.choosefile.Click += new System.EventHandler(this.choosefile_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 9);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(103, 212);
            this.listBox.TabIndex = 4;
            // 
            // Timer1
            // 
            this.Timer1.AutoSize = true;
            this.Timer1.Location = new System.Drawing.Point(141, 65);
            this.Timer1.Name = "Timer1";
            this.Timer1.Size = new System.Drawing.Size(39, 13);
            this.Timer1.TabIndex = 5;
            this.Timer1.Text = "Timer1";
            // 
            // Timer1Box
            // 
            this.Timer1Box.Location = new System.Drawing.Point(261, 58);
            this.Timer1Box.Name = "Timer1Box";
            this.Timer1Box.Size = new System.Drawing.Size(100, 20);
            this.Timer1Box.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of words";
            // 
            // WordsCountBox
            // 
            this.WordsCountBox.Location = new System.Drawing.Point(261, 28);
            this.WordsCountBox.Name = "WordsCountBox";
            this.WordsCountBox.Size = new System.Drawing.Size(100, 20);
            this.WordsCountBox.TabIndex = 8;
            // 
            // EnterWordLabel
            // 
            this.EnterWordLabel.AutoSize = true;
            this.EnterWordLabel.Location = new System.Drawing.Point(141, 109);
            this.EnterWordLabel.Name = "EnterWordLabel";
            this.EnterWordLabel.Size = new System.Drawing.Size(58, 13);
            this.EnterWordLabel.TabIndex = 9;
            this.EnterWordLabel.Text = "Enter word";
            // 
            // EnterWordBox
            // 
            this.EnterWordBox.Location = new System.Drawing.Point(261, 102);
            this.EnterWordBox.Name = "EnterWordBox";
            this.EnterWordBox.Size = new System.Drawing.Size(100, 20);
            this.EnterWordBox.TabIndex = 10;
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(12, 247);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(103, 82);
            this.listBoxResults.TabIndex = 11;
            // 
            // Timer2Box
            // 
            this.Timer2Box.Location = new System.Drawing.Point(261, 139);
            this.Timer2Box.Name = "Timer2Box";
            this.Timer2Box.Size = new System.Drawing.Size(100, 20);
            this.Timer2Box.TabIndex = 12;
            // 
            // Timer2
            // 
            this.Timer2.AutoSize = true;
            this.Timer2.Location = new System.Drawing.Point(141, 146);
            this.Timer2.Name = "Timer2";
            this.Timer2.Size = new System.Drawing.Size(39, 13);
            this.Timer2.TabIndex = 13;
            this.Timer2.Text = "Timer2";
            // 
            // Lab4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 372);
            this.Controls.Add(this.Timer2);
            this.Controls.Add(this.Timer2Box);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.EnterWordBox);
            this.Controls.Add(this.EnterWordLabel);
            this.Controls.Add(this.WordsCountBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Timer1Box);
            this.Controls.Add(this.Timer1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.choosefile);
            this.Controls.Add(this.SearchWordButton);
            this.Name = "Lab4Form";
            this.Text = "Lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchWordButton;
        private System.Windows.Forms.Button choosefile;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label Timer1;
        private System.Windows.Forms.TextBox Timer1Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WordsCountBox;
        private System.Windows.Forms.Label EnterWordLabel;
        private System.Windows.Forms.TextBox EnterWordBox;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.TextBox Timer2Box;
        private System.Windows.Forms.Label Timer2;
    }
}

