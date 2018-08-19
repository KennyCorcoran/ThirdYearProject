using ExeToCilForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeToCilForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            getFile();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            convertToCIL();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //This method converts an .exe file to a .il file
        private void convertToCIL()
        {
            List<string> outputFile;
            //These two lines find the il disassembler and pass in arugments, the path of the file to disassemble and the output path for the text file. 
            ProcessStartInfo startInfo = new ProcessStartInfo(Directory.GetCurrentDirectory() + "\\ildasm.exe");
            startInfo.Arguments = exeTextBox.Text + " /output:"+ Directory.GetCurrentDirectory() + "\\MyFile.il";

            Process.Start(startInfo);

            outputFile = readIlFile();
            //passing a list of strings to a method.
            displayNewForm(outputFile);
        }
        //This method opens up a windows explorer to browse for a file, and checks if it is an exe file.
        private void getFile()
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!FD.FileName.Contains(".exe"))
                {
                    MessageBox.Show("Please choose an .exe file", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    exeTextBox.Text = FD.FileName;
                }
            }
        }
        //This method creates a new form and displays it and hides the old form.
        private void displayNewForm(List<string> cilOutput)
        {
            DisplayForm displayOutForm = new DisplayForm(cilOutput, this);
            displayOutForm.Show();
            this.Hide();
        }
        //This file gets the .il file and reads it into a list of strings, each line in the il file is an entry.
        private List<string> readIlFile()
        {
            int counter = 0;
            string line;
            List<string> list = new List<string>();

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(Directory.GetCurrentDirectory() + "\\MyFile.il");
            while ((line = file.ReadLine()) != null)
            {
                list.Add(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}