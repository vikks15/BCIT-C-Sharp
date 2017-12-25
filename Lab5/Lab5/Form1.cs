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

        public static int Distance(string s1, string s2)
        {
            if ((s1 == null) || (s2 == null)) return -1;
            if ((s1.Length == 0) && (s2.Length == 0)) return 0;
            if (s1.Length == 0) return s2.Length; //if one str is empty return length of another
            if (s2.Length == 0) return s1.Length;

            string str1 = s1.ToUpper();
            string str2 = s2.ToUpper();

            int[,] matrix = new int[str1.Length + 1, str2.Length + 1]; //+1 for(int i=1 ...)

            //initialization of first row and column 
            for (int i = 0; i <= str1.Length; i++) matrix[i, 0] = i;
            for (int j = 0; j <= str2.Length; j++) matrix[0, j] = j;

            //counting Levenshtein distance
            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    int equalChar = (str1.Substring(i - 1, 1) == str2.Substring(j - 1, 1) ? 0 : 1); //m(s1[i],s2[j])
                    int ins = matrix[i, j - 1] + 1; //insert
                    int del = matrix[i - 1, j] + 1; //delete
                    int subst = matrix[i - 1, j - 1] + equalChar; //substitute

                    matrix[i, j] = Math.Min(Math.Min(ins, del), subst);  //matrix element count as min of 3 variants

                    //additional part for replacing 2 one by one elements 
                    if ((i > 1) && (j > 1) && (str1.Substring(i - 1, 1) == str2.Substring(j - 2, 1)) && (str1.Substring(i - 2, 1) == str2.Substring(j - 1, 1)))
                    {
                        matrix[i, j] = Math.Min(matrix[i, j], matrix[i - 2, j - 2] + equalChar);
                    }
                }
            }
            return matrix[str1.Length, str2.Length]; //result is in the lower right cell
        }

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
                char[] separators = new char[] { ' ', '.', ',', ':', ';', '«', '»', '!', '?', '/', '\r', '\t', '\n' };
                string[] textArray = text.Split(separators);

                listBox.BeginUpdate();
                foreach (string tempStr in textArray)
                {
                    string str = tempStr.Trim(); //delete spaces
                    if (!list.Contains(str) && str.Length!=0) //repeat and empty string check 
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
            string maxD = MaxDistBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(word) && list.Count != 0 && maxD.Length!=0)
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                listBoxResults.BeginUpdate();
                foreach (string str in list)
                {
                    int currentWordDist = Distance(str, word);
                    if (currentWordDist<=int.Parse(maxD))
                    {
                        listBoxResults.Items.Add(str + " (distance " + currentWordDist + ")");
                    }
                }
                listBoxResults.EndUpdate();
                timer.Stop();
                Timer2Box.Text = timer.Elapsed.ToString();
            }
            else MessageBox.Show("Choose file, enter word and maximum distance.");
        }
    }
}