using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ResourceInfo : Form
    {
        public static ResourceInfo Instance;
        public List<Product> listProduct = new List<Product>();
        public List<int> StorageNumber = new List<int>();
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
                dataGridView1.Rows.Add(product_.GetName(), product_.GetCategory(), product_.GetNumber());
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "All Product";
            saveFile.Filter = "CSV|*.csv";
            saveFile.ShowDialog();

            if (saveFile.FileName != "")
            {
                using (StreamWriter file = new StreamWriter(saveFile.FileName))
                {
                    file.WriteLine("ProductName,Catagory,Amount");
                    foreach (Product item in listProduct)
                    {
                        file.WriteLine($"{item.GetName()},{item.GetCategory()},{item.GetNumber()}");
                    }
                }
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
                listProduct.Clear();
                dataGridView1.Rows.Clear();
                using (StreamReader file = new StreamReader(openfile.FileName))
                {
                    string line;
                    int count = 0;
                    while ((line = file.ReadLine()) != null)
                    {
                        if (count == 0)
                        {
                            count++;
                            continue;
                        }
                        else
                        {
                            string[] data = line.Split(',');
                            Product newproducts = new Product();
                            newproducts.setName(data[0]);
                            newproducts.setCate(data[1]);
                            newproducts.setNumber(int.Parse(data[2]));
                            listProduct.Add(newproducts);
                            RefreshDataG();
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StorageNumber.Clear();
            foreach (Product i in listProduct)
            {
                StorageNumber.Add(i.GetNumber());
            }
            StorageNumber.Sort();
            MessageBox.Show(StorageNumber.Last().ToString());
        }


        private void MinAmount_Click(object sender, EventArgs e)
        {
            StorageNumber.Clear();
            foreach (Product i in listProduct)
            {
                StorageNumber.Add(i.GetNumber());
            }
            StorageNumber.Sort();
            MessageBox.Show(StorageNumber.First().ToString());
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "All Resouce";
            openfile.Filter = "CSV|*.csv";
            openfile.ShowDialog();
            if (openfile.FileName != "")
            {
                listProduct.Clear();
                dataGridView1.Rows.Clear();
                using (StreamReader file = new StreamReader(openfile.FileName))
                {
                    string line;
                    int count = 0;
                    while ((line = file.ReadLine()) != null)
                    {
                        if (count == 0)
                        {
                            count++;
                            continue;
                        }
                        else
                        {
                            string[] data = line.Split(',');
                            Product newproducts = new Product();
                            newproducts.setName(data[0]);
                            newproducts.setCate(data[1]);
                            newproducts.setNumber(int.Parse(data[2]));
                            listProduct.Add(newproducts);
                            RefreshDataG();
                        }
                    }
                }
            }
        }
    }
}