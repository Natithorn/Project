using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ResourceInfo : Form
    {
        public static ResourceInfo Instance;
        public List<Product> listProduct = new List<Product>();

        public ResourceInfo()
        {
            InitializeComponent();
            Instance = this;
        }

        private void newItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Resouce resos = new Resouce();
            resos.ShowDialog();


            if (resos.DialogResult == DialogResult.OK)
            {
                listProduct.Add(resos.getProduct());
                RefreshDataG();

            }
        }
        private void RefreshDataG()
        {
            dataGridView1.Rows.Clear();
            foreach (Product product_ in listProduct)
            {
                dataGridView1.Rows.Add(product_.name, product_.category, product_.Number);


            }

        }
    }
}
