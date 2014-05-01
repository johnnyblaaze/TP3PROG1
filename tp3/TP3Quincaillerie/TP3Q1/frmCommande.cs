using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3Q1
{
    public partial class frmCommande : Form
    {
        public frmCommande()
        {
            InitializeComponent();
        }

        private void frmCommande_Load(object sender, EventArgs e)
        {
            
            for (int nbItems = 1; nbItems < 101; nbItems++)
            {
                cboQuantité.Items.Add(nbItems);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstNum.SelectedIndex = lstObjet.SelectedIndex;
        }

        private void lstObjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstObjet.SelectedIndex = lstNum.SelectedIndex;
        }






    }
}
