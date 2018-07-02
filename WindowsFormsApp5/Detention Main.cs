using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp5
{
    public partial class MainDetention : Form
    {
        DatabaseMain database;
        string cStudentID;
        long authnKey;

        public MainDetention(long authnKey)
        {
            InitializeComponent();

            database = new DatabaseMain();
        }

        private void textBox1_TextChanged(object sender , EventArgs e)
        {

            if(textBox1.Text.Length == 10)
            {
                string id = textBox1.Text;
                try
                {

                    label1.Text = database.getName(id);
                    label4.Text = "Grade: " + database.getGrade(id);
                    label2.Text = "Student ID: " + id;
                    label3.Text = "Unserved: " + database.getTotalDetention(id);
                    //TODO add option to dectect if current period is study hall

                    pictureBox1.Image = Image.FromFile("IMAGES/" + database.getImageName(id));
                }
                catch(Exception)
                {
                    label1.Text = "ID Not Found";
                }

                cStudentID = textBox1.Text;
                textBox1.Clear();
            }
        }
        

        private void button1_Click_1(object sender , EventArgs e)
        {
            button1.Enabled = false;
            database.addDetention(cStudentID , comboBox1.Text);
            button1.Enabled = true;
        }

        private void menuStrip1_ItemClicked(object sender , ToolStripItemClickedEventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender , EventArgs e)
        {

        }

        private void textBox1_Enter(object sender , EventArgs e)
        {
            label7.Hide();

        }

        private void textBox1_Leave(object sender , EventArgs e)
        {
            label7.Show();
        }
    }
}

