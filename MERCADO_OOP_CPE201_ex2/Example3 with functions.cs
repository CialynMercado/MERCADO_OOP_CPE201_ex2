using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MERCADO_OOP_CPE201_ex2
{
    public partial class Lesson2_Activity : Form
    {
        private int qty_total = 0;
        private Double discount_totalgiven = 0;
        private double discounted_total = 0;
        public Lesson2_Activity()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amount;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);
            discount_amt = (qty * price) * 0;
            discounted_amount = (qty * price) - discount_amt;
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amount.ToString("n");
            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            itemnametxtbox.Enabled = false;
            pricetxtbox.Enabled = false;
            label.Enabled = false;
            label100.Enabled = false;
            label101.Enabled = false;
            label103.Enabled = false;
            changetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;

            pictureBox20.Image = Image.FromFile("C:\\Users\\C203-13\\Source\\Repos\\MERCADO_OOP_CPE201_ex2\\MERCADO_OOP_CPE201_ex2\\pictures\\L2.jpg");
            pictureBox19.Image = Image.FromFile("C:\\Users\\C203-13\\Source\\Repos\\MERCADO_OOP_CPE201_ex2\\MERCADO_OOP_CPE201_ex2\\pictures\\L3.jpg");
            pictureBox18.Image = Image.FromFile("C:\\Users\\C203-13\\Source\\Repos\\MERCADO_OOP_CPE201_ex2\\MERCADO_OOP_CPE201_ex2\\pictures\\SP1.jpg");
            pictureBox17.Image = Image.FromFile("C:\\Users\\C203-13\\Source\\Repos\\MERCADO_OOP_CPE201_ex2\\MERCADO_OOP_CPE201_ex2\\pictures\\SP2.jpg");
            pictureBox16.Image = Image.FromFile("C:\\Users\\C203-13\\Source\\Repos\\MERCADO_OOP_CPE201_ex2\\MERCADO_OOP_CPE201_ex2\\pictures\\L1.jpg");

            label1.Text = "KUYA JAYS POINT OF SALE";
            label16.Text = "Seafood";
            label17.Text = "Crispy Chicken";
            label19.Text = "Crispy Pata";
            label18.Text = "Grilled Mussles";
            label24.Text = "Orange Shake";
            label23.Text = "Watermelon Shake";
            label22.Text = "Mango Shake";
            label21.Text = "Cucumber Juice";
            label20.Text = "Pomelo Juice";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Sisig";
            pricetxtbox.Text = "360.00";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amount;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);
            discount_amt = (qty * price) * 0.30;
            discounted_amount = (qty * price) - discount_amt;
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amount.ToString("n");
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amt;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);
            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            radioButton1.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            int qty;
            double price, discount_amt, discounted_amount;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);
            discount_amt = (qty * price) * 0.15;
            discounted_amount = (qty * price) - discount_amt;
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amount.ToString("n");
            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }


        private void CalculateBtn_Click(object sender, EventArgs e)
        {

            int qty;
            double discount_amt, discounted_amount, cash_rendered, change;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            discount_amt = Convert.ToDouble(discounttxtbox.Text);
            discounted_amount = Convert.ToDouble(discountedtxtbox.Text);
            cash_rendered = Convert.ToDouble(cash_renderedtxtbox.Text);
            qty_total += qty;
            discount_totalgiven += discount_amt;
            discounted_total += discounted_amount;
            change = cash_rendered - discounted_amount;
            label100.Text = qty_total.ToString();
            label101.Text = discount_totalgiven.ToString("n");
            label103.Text = discounted_total.ToString("n");
            changetxtbox.Text = change.ToString("n");
            cash_renderedtxtbox.Text = cash_rendered.ToString("n");

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetxtbox.Clear();
            quantitytxtbox.Clear();
            discounttxtbox.Clear();
            discountedtxtbox.Clear();
            cash_renderedtxtbox.Clear();
            changetxtbox.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Seafood";
            pricetxtbox.Text = "460.00";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Crispy Chicken";
            pricetxtbox.Text = "460.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Grilled Mussles";
            pricetxtbox.Text = "150.00";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Crispy Pata";
            pricetxtbox.Text = "560.00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Orange Shake";
            pricetxtbox.Text = "160.00";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Watermelon Shake";
            pricetxtbox.Text = "160.00";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Mango Shake";
            pricetxtbox.Text = "160.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Cucmber Juice";
            pricetxtbox.Text = "120.00";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Pomelo Juice";
            pricetxtbox.Text = "120.00";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Set A";
            pricetxtbox.Text = "537.00";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Set B";
            pricetxtbox.Text = "540.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Set D";
            pricetxtbox.Text = "611.00";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Set C";
            pricetxtbox.Text = "547.00";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Set E";
            pricetxtbox.Text = "450.00";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "L1";
            pricetxtbox.Text = "499.00";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "L2";
            pricetxtbox.Text = "499.00";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "L3";
            pricetxtbox.Text = "539.00";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

            itemnametxtbox.Text = "SP1";
            pricetxtbox.Text = "1299.00";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

            itemnametxtbox.Text = "SP2";
            pricetxtbox.Text = "1399.00";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
