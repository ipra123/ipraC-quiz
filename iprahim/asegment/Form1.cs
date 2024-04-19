using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asegment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {



                if (name.Text != "" && id.Text != "" && age.Text != ""  )
                {
                    info.Text = "  \n    " + name.Text;
                    int Id;
                    if(int.TryParse(id.Text , out Id)){
                        info.Text += "  \n    " + id.Text; 
                    }else{
                        MessageBox.Show("ID IS A NUMBER ");

                    }

                    int Age;
                    if (int.TryParse(age.Text, out Age))
                    {
                        if (Age > 30)
                        {
                            MessageBox.Show("Age most be less the 30 ");
                            age.Text = "";
                        }
                        else
                        {
                            info.Text += "  \n    " + Age;
                        }
                    }
                    else
                    {
                        MessageBox.Show("AGE IS A NUMBER ");

                    }

                    if (male.Checked)
                    {
                        info.Text +="  \n    " +"male";
                    }
                    else
                    {
                        info.Text +="  \n    "+ "female"; 
                    }
                    info.Text += "  \n    " + doorasho.SelectedItem.ToString();
                }

                   
                    
                    

                    
                else
                {
                    MessageBox.Show("enter value  ");
                }
            }
            catch
            {
                MessageBox.Show(" ONLY ENTER INTEGER NUMBER OR ENTER NUMBER ");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            name.Text = "";
            id.Text = "";
            age.Text = "";
            info.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
