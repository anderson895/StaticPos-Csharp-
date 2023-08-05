using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Policy;

namespace posact
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public string litemsku;
        public string litemname;
        public double litemprice;
        public double litemquantity;
        public double litemtotal;
        public double lsum;
        public bool cancel;

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComboBox();
            Form2 form2 = new Form2
            {
                SKU = litemsku,
                itemname = litemname,
                Price = litemprice
            };
            form2.Show();
        }


        public void ComboBox()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                litemsku = "634542";
                litemname = "SPRITE";
                litemprice = 50.00;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                litemsku = "124215";
                litemname = "COKE";
                litemprice = 60.00;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                litemsku = "4564563";
                litemname = "PEPSI";
                litemprice = 40.00;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                litemsku = "53267151";
                litemname = "MOUNTAIN DEW";
                litemprice = 100.00;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                litemsku = "875451";
                litemname = "ROYAL";
                litemprice = 30.00;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                litemsku = "235232151";
                litemname = "ROOTBEER";
                litemprice = 20.00;
            }

        }

        public void AddList()
        {
            ListViewItem item = new ListViewItem(litemsku);
            item.SubItems.Add(litemname);
            item.SubItems.Add(Convert.ToString(Math.Round(litemprice, 2)));
            item.SubItems.Add(Convert.ToString(Math.Round(litemquantity, 2)));
            item.SubItems.Add(Convert.ToString(Math.Round(litemtotal, 2)));
            listView1.Items.Add(item);
        }

        public void SumPrice()
        {
            lsum += litemtotal;
            label3.Text = Convert.ToString(Math.Round(lsum, 2));
        }
        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Not necessary for now, can leave it empty.
        


        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                ComboBox(); // Update the selected item details in Form1

                // Pass the selected item details to Form2
                Form2 form2 = new Form2
                {
                    SKU = litemsku,
                    itemname = litemname,
                    Price = litemprice
                };

                form2.ShowDialog(); // Show Form2 as a modal dialog
            }
            else
            {
                MessageBox.Show("Please select an item from the combo box.");
            }
        }
    }
}