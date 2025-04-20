using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_taking_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Clear the RichTextBox
            richTextBox.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Open FileDialog to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.*";
            openFileDialog.Title = "Open Note";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening file " + ex.Message);
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //// Open SaveFileDialog to select a file name and location
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.*";
            saveFileDialog.Title = "Save Note";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try {
                    richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening file " + ex.Message);
                }
            }
        }
    }
}
