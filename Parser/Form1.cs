using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Parser
{
    public partial class Form1 : MetroForm
    {
        private static List<String> files = new List<string>();
        private static string[] Keys;
        private static int key_set = 0;
        private static int keyCount = 0;
        private static List<String> PATHS = new List<string>();
        private static List<String> LINE_MATCH = new List<string>();
        private static List<String> LINE_NUM = new List<string>();
        private static List<String> KEYWORD = new List<string>();
        private static string table = "";

        public Form1()
        {
            InitializeComponent();
            this.ContextMenuStrip = settings;
            settings.Show();
        }
  
        private void metroButton1_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            openFolder.ShowNewFolderButton = false;
            openFolder.Description = "Select Folder to literate through";
     
           
            if (key_set == 1) {
              
                if (openFolder.ShowDialog() == DialogResult.OK)
            {
                    metroLabel2.Text = openFolder.SelectedPath;
                    string PATH = openFolder.SelectedPath;

                    try
                    {                                                                                               
                        Search(PATH);
                       // metroButton3.Style = Red;       
                    }//end try

                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error: Could not read file from disk. Original error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }//end catch

                    //foreach(string match in matches)
                    //{
                    //    Console.WriteLine(match);
                    //}
                    //Console.WriteLine(matches.Count.ToString());

                    PATH = "";
                }//end if
            }//end of is key_set
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Select a KEYWORD File before you continue." , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }//if key_set is not set

            
        }//end button

        private void metroButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                metroTextBox1.Text = File.ReadAllText(openFile.FileName);         
                Keys = File.ReadAllLines(openFile.FileName);
                key_set = 1;
                metroLabel1.Text = openFile.FileName;
                keyCount = Keys.Count();
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        public void Search(string PATH){

            string excludedExtensions = "*.zip";
            //add all folder file paths to array
            var files = Directory.GetFiles(PATH, "*.*", SearchOption.AllDirectories).Where(s => !excludedExtensions.Contains(Path.GetExtension(s).ToLower()));

            //convert array to List
            files.ToList();


            foreach (string key in Keys)
            {

                int counter = 1;
                Console.WriteLine("Files {0}", files.Count());
                string line;

                //emnumerate through the list 
                foreach (string path in files)
                {
                    //open file for reading
                    System.IO.StreamReader file = new System.IO.StreamReader(path);
                    //Console.WriteLine("{0} \n ", path);
                    while ((line = file.ReadLine()) != null)
                    {

                        if (line.Contains(key))
                        {
                            //matches.Add("File Path:: " + path + "\nMatching Line:: " + line + "\nLine Number:: " + counter.ToString() + "\nKeyword:: " + key + "\n");
                            PATHS.Add(path);
                            LINE_MATCH.Add(line);
                            LINE_NUM.Add(counter.ToString());
                            KEYWORD.Add(key);
                        }

                        //Console.WriteLine(line);
                        counter++;

                    }//end while
                  
                    counter = 1;
                    file.Close();
                    Console.ReadLine();

                }//end foreach
            }//end keyword foreach
            

            using (FileStream fs = new FileStream("MATCHES.htm", FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {          
                    StringBuilder sb = new StringBuilder();
                    sb.Append("<!-- Mouhamad Jaber --!>\n");
                    sb.Append("<style> \n table tr:nth-child(even){background-color: #eee;} \n table tr:nth-child(odd){background-color: #fff;} \n table th{background-color: black;color: white; border: 1px solid black;}\n table td{border: 1px solid black;} \n table {border: 1px solid black;  border-collapse: collapse;} \n</style>\n\n");
                    sb.Append("<table> \n\t<tr>\n\t\t<th>KEYWORD</th>\n\t\t<th>FILE PATH</th>\n\t\t<th>MATCH</th>\n\t\t<th>LINE #</th>\n\t</tr>\n\n");

                    for (int x = 0; x < PATHS.Count; x++)                   
                    {
                        sb.AppendFormat("\n\t<tr>\n\t\t<td>{0}</td>\n", KEYWORD[x]);
                        sb.AppendFormat("\t\t<td>{0}</td>\n", PATHS[x]);
                        sb.AppendFormat("\t\t<td>{0}</td>\n", LINE_MATCH[x]);
                        sb.AppendFormat("\t\t<td>{0}</td>\n\t</tr>\n", LINE_NUM[x]);                       
                    }
                    
                    sb.Append("</table>");
                    w.WriteLine(sb);

                    table = fs.Name;
                    // table = System.Uri.EscapeUriString(table);
                    
                    table = Regex.Replace(table, @"\s+", "%20");                   
                    Console.WriteLine(table);
                    metroButton3.Enabled = true;
                    
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("chrome.exe", table);
            }
            catch (Win32Exception)
            {
                Process.Start("IExplore.exe", table);
            }

                Console.WriteLine(table);
        }

        private void two_five_Click(object sender, EventArgs e)
        {
            MetroForm.ActiveForm.Opacity = .25;
            Console.WriteLine("25");
        }

        private void five_zero_Click(object sender, EventArgs e)
        {
            MetroForm.ActiveForm.Opacity = .50;
            Console.WriteLine("50");
        }

        private void seven_five_Click(object sender, EventArgs e)
        {
            MetroForm.ActiveForm.Opacity = .75;
            Console.WriteLine("75");
        }

        private void hundred_Click(object sender, EventArgs e)
        {
            MetroForm.ActiveForm.Opacity = 1;
            Console.WriteLine("100");
        }
    }//end form
}//end namespace
