using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace username
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection myconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=registrationdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (radioButton1.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust 10'Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("250.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Crispy Crust 10' Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("250.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Extra Crispy Crust 10' Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("250.00");
                    listView1.Items.Add(item);

                }

            }

            else if (radioButton2.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust 12' Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("250.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Crispy Crust 12' Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("250.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Extra Cristpy Crust 12' Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("250.00");
                    listView1.Items.Add(item);

                }
            }

            else if (radioButton3.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust 14' Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("350.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Crispy Crust 14' Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("350.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Extra Crispy Crust 14' Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("350.00");
                    listView1.Items.Add(item);

                }
            }

            


            //Pizza Topping Selection

            if (checkBox1.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Pepperoni Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("10");
                listView1.Items.Add(item);

            }

            if (checkBox2.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Ham and Cheese");
                item.SubItems.Add("");
                item.SubItems.Add("10");
                listView1.Items.Add(item);

            }

            if (checkBox3.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Hawaiian");
                item.SubItems.Add("");
                item.SubItems.Add("10");
                listView1.Items.Add(item);

            }

            if (checkBox4.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Tuna");
                item.SubItems.Add("");
                item.SubItems.Add("15");
                listView1.Items.Add(item);

            }

            if (checkBox5.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Veggies");
                item.SubItems.Add("");
                item.SubItems.Add("15");
                listView1.Items.Add(item);

            }

            if (checkBox6.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Sisig");
                item.SubItems.Add("");
                item.SubItems.Add("15");
                listView1.Items.Add(item);

            }

            if (checkBox7.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Cheesy Beef");
                item.SubItems.Add("");
                item.SubItems.Add("20");
                listView1.Items.Add(item);

            }

            if (checkBox8.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Spicy Chicken");
                item.SubItems.Add("");
                item.SubItems.Add("20");
                listView1.Items.Add(item);

            }

            if (checkBox9.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Bacon and Beef");
                item.SubItems.Add("");
                item.SubItems.Add("20");
                listView1.Items.Add(item);

            }

            if (checkBox10.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Leandro's Best");
                item.SubItems.Add("");
                item.SubItems.Add("30");
                listView1.Items.Add(item);

            }

            //Drink Selection

            if (checkBox15.Checked == true)
            {
                ListViewItem item = new ListViewItem("Coke - Can");
                item.SubItems.Add(textBox1.Text);
                int qty = Convert.ToInt32(textBox1.Text);
                double cost = qty * 50;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox1.Text = "";
            }

            if (checkBox16.Checked == true)
            {
                ListViewItem item = new ListViewItem("Diet Coke - Can");
                item.SubItems.Add(textBox2.Text);
                int qty = Convert.ToInt32(textBox2.Text);
                double cost = qty * 50;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox2.Text = "";
            }

            if (checkBox17.Checked == true)
            {
                ListViewItem item = new ListViewItem("Iced Tea - 1L");
                item.SubItems.Add(textBox3.Text);
                int qty = Convert.ToInt32(textBox3.Text);
                double cost = qty * 40;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox3.Text = "";
            }

            if (checkBox18.Checked == true)
            {
                ListViewItem item = new ListViewItem("Royal - Can");
                item.SubItems.Add(textBox4.Text);
                int qty = Convert.ToInt32(textBox4.Text);
                double cost = qty * 50;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox4.Text = "";
            }

            if (checkBox19.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sprite - Can");
                item.SubItems.Add(textBox5.Text);
                int qty = Convert.ToInt32(textBox5.Text);
                double cost = qty * 50;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox5.Text = "";
            }

            if (checkBox20.Checked == true)
            {
                ListViewItem item = new ListViewItem("Root Beer - Can");
                item.SubItems.Add(textBox6.Text);
                int qty = Convert.ToInt32(textBox6.Text);
                double cost = qty * 50;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox6.Text = "";
            }

            if (checkBox21.Checked == true)
            {
                ListViewItem item = new ListViewItem("Fanta - Can");
                item.SubItems.Add(textBox7.Text);
                int qty = Convert.ToInt32(textBox7.Text);
                double cost = qty * 50;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox7.Text = "";
            }

            //Other Items Selection

            if (checkBox22.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sausage and Pepper Pasta");
                item.SubItems.Add("");
                item.SubItems.Add("95");
                listView1.Items.Add(item);

            }

            if (checkBox23.Checked == true)
            {
                ListViewItem item = new ListViewItem("Cheesy Spaghetti");
                item.SubItems.Add("");
                item.SubItems.Add("95");
                listView1.Items.Add(item);

            }

            if (checkBox24.Checked == true)
            {
                ListViewItem item = new ListViewItem("Creamy Carbonara");
                item.SubItems.Add("");
                item.SubItems.Add("95");
                listView1.Items.Add(item);

            }

            if (checkBox25.Checked == true)
            {
                ListViewItem item = new ListViewItem("Mac and Cheese");
                item.SubItems.Add("");
                item.SubItems.Add("95");
                listView1.Items.Add(item);

            }

            if (checkBox26.Checked == true)
            {
                ListViewItem item = new ListViewItem("Seafood Pasta in Olive Oil");
                item.SubItems.Add("");
                item.SubItems.Add("125");
                listView1.Items.Add(item);

            }


            if (checkBox27.Checked == true)
            {
                ListViewItem item = new ListViewItem("Tuna Pasta in Olive Oil");
                item.SubItems.Add("");
                item.SubItems.Add("125");
                listView1.Items.Add(item);

            }

            if (checkBox28.Checked == true)
            {
                ListViewItem item = new ListViewItem("Leandro's Pasta");
                item.SubItems.Add("");
                item.SubItems.Add("125");
                listView1.Items.Add(item);

            }


            double total = 0;
            
            double totaldue = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }

            
            totaldue = total;

            
            string totalDisplay = totaldue.ToString("");
            string amount = total.ToString("");

            textBox8.Text = amount;
            
            textBox10.Text = totalDisplay;

            tabControl1.SelectTab("tabPage2");
        }

        private void ClearOrder_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox8.Text = "";
            textBox10.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
            textBox19.Text = textBox10.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox20.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill in required fields");
            }

            else
            {
                string money = textBox19.Text;
                char[] peso = { '₱' };
                string paymoney = money.TrimStart(peso);
                double paymentDue = Convert.ToDouble(paymoney);
                double amountPaid = Convert.ToDouble(textBox20.Text);
                double change = 0;
                change = amountPaid - paymentDue;
                textBox21.Text = change.ToString("");

                if (change < 0)
                {
                    MessageBox.Show("Please pay your balance");

                }

                else
                {
                    button8.Enabled = true;
                }


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Thanks for ordering at Leandro's Pizza. Your ordered items will be ready and delivered in 30 minutes. Do you want to order some more?", "Exit", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                //Clearing all data
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;
                checkBox21.Checked = false;
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox24.Checked = false;
                checkBox25.Checked = false;
                checkBox26.Checked = false;
                checkBox27.Checked = false;
                checkBox28.Checked = false;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

                listView1.Items.Clear();
                textBox8.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                textBox19.Text = "";
                textBox20.Text = "";
                textBox21.Text = "";
                comboBox2.Text = "";

                tabControl1.SelectTab("tabPage1");
            }

            else if (dialog == DialogResult.No)
            {
                this.Close();
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_fname.Text == String.Empty && txt_lname.Text == String.Empty && txt_phonenum.Text == String.Empty && txt_numpeople.Text == String.Empty)
            {
                MessageBox.Show("Some fields are empty", "Please fillup all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txt_fname.Text;
                dataGridView1.Rows[n].Cells[1].Value = txt_lname.Text;
                dataGridView1.Rows[n].Cells[2].Value = txt_numpeople.Text;
                dataGridView1.Rows[n].Cells[3].Value = txt_phonenum.Text;
                dataGridView1.Rows[n].Cells[4].Value = dateTimePicker1.Text;

                MessageBox.Show("You have successfuly reserved your seat.", "Reservation success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_phonenum.Text = "";
            txt_numpeople.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

