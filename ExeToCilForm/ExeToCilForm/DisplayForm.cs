using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExeToCilForm
{
    public partial class DisplayForm : Form
    {
        private Form1 exeFormRef;
        private List<string> input;
        public DisplayForm()
        {
            InitializeComponent();
        }
        public DisplayForm(List<string> cilFile, Form1 exeForm)
        {
            InitializeComponent();
            input = cilFile;
            addInputToTextBox();
            exeFormRef = exeForm;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            exeFormRef.Close();
        }

        private void convertToReadableButton_Click(object sender, EventArgs e)
        {
            convertToReadable();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Text = "";
        }
        private void convertToReadable()
        {
            foreach (string line in richTextBox1.Lines)
            {
                if (line.Contains("IL_"))
                {
                    outputRichTextBox.AppendText(line + Environment.NewLine);
                }
            }
        }
        private void addInputToTextBox()
        {
            foreach (string line in input)
            {
                richTextBox1.AppendText(line + Environment.NewLine);
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            showExeForm();
            this.Close();
        }
        private void showExeForm()
        {
            exeFormRef.Show();
        }
    }
}
