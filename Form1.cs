using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.IO;

namespace CRUD
{
    public partial class Form1 : Form
    {
        static string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            string defaultValue, message, title;
            string myValue;
            message = "Set file location";
            title = "Create file";
            defaultValue = @"D:\Default.txt";
            myValue = Interaction.InputBox(message, title, defaultValue);
            if (string.IsNullOrEmpty(myValue))
                return;
            else
            {
                filePath = myValue;                
                if (File.Exists(filePath))
                {
                    MessageBox.Show("File already exist. Overwriting file.");
                    var fs = File.Create(filePath);
                    fs.Close();
                    MessageBox.Show("File created sucessfully");
                    
                }
                else
                {
                    var fs = File.Create(filePath);
                    fs.Close();
                    MessageBox.Show("File created sucessfully");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string defaultValue, message, title;
            string myValue;
            message = "Set file location";
            title = "Create file";
            defaultValue = @"D:\Default.txt";
            myValue = Interaction.InputBox(message, title, defaultValue);
            if (string.IsNullOrEmpty(myValue))
                return;
            else
            {
                filePath = myValue;
                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"File doesn't exist in {filePath}");
                }
                else
                {
                    string fileText = File.ReadAllText(filePath);
                    richTextBox1.Text = fileText;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string defaultValue, message, title;
            string myValue;
            message = "Set file location";
            title = "Create file";
            defaultValue = @"D:\Default.txt";
            myValue = Interaction.InputBox(message, title, defaultValue);
            if (string.IsNullOrEmpty(myValue))
                return;
            else
            {
                filePath = myValue;
                string text = richTextBox1.Text;
                if (File.Exists(filePath))
                {
                    File.AppendAllText(filePath, text);
                    MessageBox.Show("File edited succesfully");
                }
                else
                    return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string defaultValue, message, title;
            string myValue;
            message = "Set file location";
            title = "Create file";
            defaultValue = @"D:\Default.txt";
            myValue = Interaction.InputBox(message, title, defaultValue);
            if (string.IsNullOrEmpty(myValue))
                return;
            else
            {
                filePath = myValue;
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    MessageBox.Show("File deleted succesfully");
                }
                else
                    MessageBox.Show("File doesn't exist");
            }
        }
    }
}
