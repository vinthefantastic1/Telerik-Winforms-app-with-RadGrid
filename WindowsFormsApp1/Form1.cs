using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace WindowsFormsApp1
{
    public partial class Form1 : Telerik.WinControls.UI.RadForm
    {
        NorthwindEntities db = new NorthwindEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void wBSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var d = db.Customers.ToList();
            radGridView1.DataSource = d;

        }

        private  void getCustomersData()
        {






        }

        private void Form1_Load(object sender, EventArgs e)
        {



            var d = db.Customers.ToList();

            radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            radGridView1.DataSource = d;

        }



    }
}
