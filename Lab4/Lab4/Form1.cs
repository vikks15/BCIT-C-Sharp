using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // for working with Directories
using System.Diagnostics; 

namespace Lab4
{
    public partial class Lab4Form : Form
    {
        public Lab4Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// File content list
        /// </summary>
        List<string> list = new List<string>();
        
        private void choosefile_Click(object sender, EventArgs e)
        { 
            OpenFileDialog fileDialog= new OpenFileDialog();
            fileDialog.Filter = "текстовые файлы|*.txt";
           

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();

                string text = File.ReadAllText(fileDialog.FileName); //read text from file in string
                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n'};
                string[] textArray = text.Split(separators);
                foreach (string tempStr in textArray)
                {
                    string str = tempStr.Trim(); //delete spaces
                    if (!list.Contains(str))//add word to list
                    {
                        list.Add(str);
                        //TextBox.Text += str + "\r\n";
                        listBox.Items.Add(str);
                    }
                                                           
                }
                timer.Stop();
                this.TimerBox.Text = timer.Elapsed.ToString();
                this.WordsCountBox.Text = list.Count.ToString();
               
               
            }
            else MessageBox.Show("Choose file!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Bye");
        }

    }
}
