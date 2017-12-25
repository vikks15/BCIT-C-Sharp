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

namespace Lab5
{
    public partial class Lab5Form : Form
    {
        public Lab5Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// File content list
        /// </summary>
        List<string> list = new List<string>();

        private void choosefile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "текстовые файлы|*.txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                listBox.Items.Clear();
                listBoxResults.Items.Clear();
                Timer2Box.Clear();
                EnterWordBox.Clear();
                Stopwatch timer = new Stopwatch();
                timer.Start();

                string text = File.ReadAllText(fileDialog.FileName); //read text from file in string
                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };
                string[] textArray = text.Split(separators);

                listBox.BeginUpdate();
                foreach (string tempStr in textArray)
                {
                    string str = tempStr.Trim(); //delete spaces
                    if (!list.Contains(str)) //repeat check 
                    {
                        list.Add(str); //add word to list
                        //TextBox.Text += str + "\r\n";
                        listBox.Items.Add(str);
                    }
                }
                listBox.EndUpdate();
                timer.Stop();
                Timer1Box.Text = timer.Elapsed.ToString();
                WordsCountBox.Text = list.Count.ToString();
            }
            else MessageBox.Show("Choose file!");
        }

        private void SearchWordButton_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear(); //clean listbox with results
            string word = EnterWordBox.Text.Trim(); //word for search
            if (!string.IsNullOrWhiteSpace(word) && list.Count != 0)
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                listBoxResults.BeginUpdate();
                foreach (string str in list)
                {

                    if (str.ToUpper().Contains(word.ToUpper()))
                    {
                        listBoxResults.Items.Add(str);
                    }
                }
                listBoxResults.EndUpdate();
                timer.Stop();
                Timer2Box.Text = timer.Elapsed.ToString();
            }
            else MessageBox.Show("Choose file and enter word.");
        }
    }
}