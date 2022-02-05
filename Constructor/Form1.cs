using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        [DataContract]
        class Product
        {
            [DataMember]
            string name;
            [DataMember]
            int size;
            [DataMember]
            float price1;
            [DataMember]
            float price2;
            [DataMember]
            int guarantee;


            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    if (value != "")
                        name = value;
                }
            }
            public int Size
            {
                get
                {
                    return size;
                }
                set
                {
                    if (value > 0)
                        size = value;
                }
            }
            public float Price1
            {
                get
                {
                    return price1;
                }
                set
                {
                    if (value > 0)
                        price1 = value;
                }
            }
            public float Price2
            {
                get
                {
                    return price2;
                }
                set
                {
                    if (value > 0)
                        price2 = value;
                }
            }
            public int Guarantee
            {
                get
                {
                    return guarantee;
                }
                set
                {
                    if (value > 0 && value < 56)
                        guarantee = value;
                }
            }


            public Product(string name, int size, float price1, float price2, int guarantee)
            {
                this.name = name;
                this.size = size;
                this.price1 = price1;
                this.price2 = price2;
                this.guarantee = guarantee;
            }

            internal static Product GetProductByJson(string json)
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Product));
                MemoryStream stream = new MemoryStream();
                var ba = Encoding.Default.GetBytes(json);
                stream.Write(ba, 0, ba.Length);
                stream.Position = 0;
                Product pr = (Product)serializer.ReadObject(stream);
                return pr;
                throw new NotImplementedException();
            }

            internal string GetJson()
            {
                string res = "";
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Product));
                MemoryStream stream = new MemoryStream();
                serializer.WriteObject(stream, this);
                stream.Position = 0;
                using (StreamReader sr = new StreamReader(stream))
                {
                    res = sr.ReadToEnd();
                }
                return res;
                throw new NotImplementedException();
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


                Product product = new Product(name, size, price1, price2, guarantee);
                string json = product.GetJson();
                Product pr = Product.GetProductByJson(json);


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
 

