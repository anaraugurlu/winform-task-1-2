using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_task_1_2
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }
  private void Bakubtn_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.baku2 ;
            label1.Text = DateTime.Now.AddHours(0).ToString();

        }
        private void London_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.london;
            label1.Text = DateTime.Now.AddHours(-4).ToString();
        }

      

       

      
       
       
    }
}
