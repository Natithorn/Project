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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using 
            //string savedata = this.dataGridView1.ToString();
            //File.WriteAllText("d:/All_Product.CSV", savedata);
            SaveFileDialog saveFile= new SaveFileDialog();
            saveFile.FileName = "All Product";
            saveFile.Filter = "Json|*.json";
            saveFile.ShowDialog();


            if(saveFile.FileName != "")
            {
                string json = JsonConvert.SerializeObject(listProduct, Formatting.Indented);
                File.WriteAllText(saveFile.FileName, json);
                //File.WriteAllText("d:\\All_Product.CSV",dataGridView1.ToString());
            }
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "All Resouce";
            openfile.Filter = "CSV|*.csv";
            openfile.ShowDialog();
            if (openfile.FileName != "")
            {
                File.ReadAllLines(openfile.FileName);
                RefreshDataG();
            }
        }
    }
}
