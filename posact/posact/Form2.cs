    using posact;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Xml.Linq;

namespace posact
{
    public partial class Form2 : Form
    {
        public string SKU { get; set; }
        public string itemname { get; set; }
        public double Price { get; set; }

        public static Form2 instance;
        
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label5.Text = SKU; // SKU of the selected item from Form1
            label6.Text = itemname; // Name of the selected item from Form1
            label7.Text = Convert.ToString(Price); // Price of the selected item from Form1

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                Form1.instance.litemquantity = Convert.ToDouble(textBox1.Text);
                Form1.instance.litemtotal = Price * Convert.ToDouble(textBox1.Text);
                Form1.instance.AddList();
                Form1.instance.SumPrice();
                this.Close(); // Close Form2 after processing the item
            }
            else
            {
                MessageBox.Show("Please enter the quantity of the selected item.");
                this.ActiveControl = textBox1;
            }
        }
    }
}