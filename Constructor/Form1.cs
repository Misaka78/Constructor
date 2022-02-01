using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Product
        {
            string name;
            int size;
            float price1;
            float price2;
            int guarantee;

            public Product(string name, int size, float price1, float price2, int guarantee)
            {
                this.name = name;
                this.size = size;
                this.price1 = price1;
                this.price2 = price2;
                this.guarantee = guarantee;
            }
        }


        private void ButtonSetInBuffer_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxSize.Text != "" && textBoxPrize1.Text != "" && textBoxPrize2.Text != "" && textBoxGuarantee.Text != "")

            {
                string name = textBoxName.Text;
                int size = Convert.ToInt32(textBoxSize.Text);
                float price1 = Convert.ToSingle(textBoxPrize1.Text);
                float price2 = Convert.ToSingle(textBoxPrize2.Text);
                int guarantee = Convert.ToInt32(textBoxGuarantee.Text);

                Product prod = new Product(name, size, price1, price2, guarantee);
                textBoxName.Text = "";
                textBoxSize.Text = "";
                textBoxPrize1.Text = "";
                textBoxPrize2.Text = "";
                textBoxGuarantee.Text = "";


                textBoxRead.Text += ($"Название товара:{name}\r\n Количество данного товара:{size}\r\n Розничная цена товара:{price1}\r\n Оптовая цена товара:{price2}\r\n Гарантийтый срок:{guarantee}");
            }
            else
            {
                MessageBox.Show("Введены не все значения");
            }
        }
       
    }

 }
 

