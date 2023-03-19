namespace Project
{
    public partial class Resouce : Form
    {
        Product products;
        public Resouce()
        {
            InitializeComponent();
        }

        public Product getProduct()
        {
            return products;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string category = tbCate.Text;
            int Number = int.Parse(tbNumber.Text);


            products = new Product()
            {
                name = name,
                category = category,
                Number = Number,

            };
            this.DialogResult = DialogResult.OK;
        }
    }
}