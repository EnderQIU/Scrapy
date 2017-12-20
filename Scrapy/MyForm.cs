using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrapy
{
    public partial class MyForm : Form
    {
        private static int[] vector=new int[40];
        public MyForm()
        {
            InitializeComponent();
        }

        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
           calVector(); 
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void calVector()
        { 
            int j = 0;
            for(int i = 0; i < 4; i++)
            {
                vector[j] = checkedListBox1.GetSelected(i)? 1:0;
                j++;
            }
            for (int i = 0; i < 12; i++)
            {
                vector[j] = checkedListBox2.GetSelected(i) ? 1 : 0;
                j++;
            }
            for (int i = 0; i < 5; i++)
            {
                vector[j] = checkedListBox3.GetSelected(i) ? 1 : 0;
                j++;
            }
            for (int i = 0; i < 8; i++)
            {
                vector[j] = checkedListBox4.GetSelected(i) ? 1 : 0;
                j++;
            }
            for (int i = 0; i < 11; i++)
            {
                vector[j] = checkedListBox5.GetSelected(i) ? 1 : 0;
                j++;
            }
        }
        public static int[] getVector()
        {
            return vector;
        }
    }
}
