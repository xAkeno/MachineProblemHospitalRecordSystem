using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineProblemHospitalRecordSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Juice();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Gurt();
        }
        private void Juice()
        {
            SignUp f2 = new SignUp();
            f2.Show();
        }

        private void Gurt() { 
        MainForm f3 = new MainForm();
            f3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
