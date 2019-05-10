using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Product p1 = new Product();
        private void AddProduct(object sender, EventArgs e)
        {
            Regex letters = new Regex(@"^[a-zA-Z]+$");
            Match nameMatch = letters.Match(nameBox.Text);
            Match adMatch = letters.Match(adBox.Text);
            Match brandMatch = letters.Match(brandBox.Text);
            Match colorMatch = letters.Match(colorBox.Text);


            Regex numbers = new Regex(@"^[a-zA-Z0-9_]+$");
            Match priceMatch = numbers.Match(priceBox.Text);
            Match barcodeMatch = numbers.Match(barcodeBox.Text);
            Match stockMatch = numbers.Match(stockBox.Text);


            if (!nameMatch.Success)
            {
                MessageBox.Show("Fill name correctly");
            }
            else if (!priceMatch.Success)
            {
                MessageBox.Show("Price can be only numbers");
            }
            else if (!brandMatch.Success)
            {
                MessageBox.Show("Brand consists of only letters");
            }
            else if (!colorMatch.Success)
            {
                MessageBox.Show("Color consists of only letters");
            }
            else if (!barcodeMatch.Success)
            {
                MessageBox.Show("Barcode consists of only numbers");
            }
            else if (!stockMatch.Success)
            {
                MessageBox.Show("Quantity(stock) can be only numbers");
            }
            else if (!adMatch.Success)
            {
                MessageBox.Show("Fill your name correctly");
            } else
            {
                p1.Name = nameBox.Text;
                p1.Price =priceBox.Text;
                p1.Category = categoryDrop.Text;
                p1.Brand = brandBox.Text;
                p1.Color = colorBox.Text;
                p1.Barcode = barcodeBox.Text;
                p1.Stock = stockBox.Text;
                p1.Ad = adBox.Text;

                productTable.Rows.Add(p1.Name, p1.Price, p1.Category, p1.Brand, p1.Color, p1.Barcode, p1.Stock);

                foreach (var c in panel1.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;
                    }
                }
            }
        }
    }
}
