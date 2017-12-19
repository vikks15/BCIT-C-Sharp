namespace Lab4
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.choosefile = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.Timer = new System.Windows.Forms.Label();
            this.TimerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WordsCountBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // choosefile
            // 
            this.choosefile.Location = new System.Drawing.Point(144, 261);
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
            this.listBox.Location = new System.Drawing.Point(12, 22);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(76, 277);
            this.listBox.TabIndex = 4;
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(128, 202);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(33, 13);
            this.Timer.TabIndex = 5;
            this.Timer.Text = "Timer";
            // 
            // TimerBox
            // 
            this.TimerBox.Location = new System.Drawing.Point(197, 199);
            this.TimerBox.Name = "TimerBox";
            this.TimerBox.Size = new System.Drawing.Size(106, 20);
            this.TimerBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of words";
            // 
            // WordsCountBox
            // 
            this.WordsCountBox.Location = new System.Drawing.Point(221, 228);
            this.WordsCountBox.Name = "WordsCountBox";
            this.WordsCountBox.Size = new System.Drawing.Size(82, 20);
            this.WordsCountBox.TabIndex = 8;
            // 
            // Lab4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 329);
            this.Controls.Add(this.WordsCountBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimerBox);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.choosefile);
            this.Controls.Add(this.button2);
            this.Name = "Lab4Form";
            this.Text = "Lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button choosefile;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.TextBox TimerBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WordsCountBox;
    }
}

