using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tx_merge_images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("data.xml");

            mailMerge1.Merge(ds.Tables[0]);
        }
    }
}
