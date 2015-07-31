using DiscountLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicket
{
    public partial class Form1 : Form
    {
        private AllTicket Ticket;
        private KidDiscount Kid;
        private VipDiscount Vip;
        private StudentDiscount Student;
        private double Price;
        private double TotalMoney;
        private string config;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmbDiscountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ticket = new AllTicket() { Price = this.Price };
            Student = new StudentDiscount();
            Vip = new VipDiscount();
            Kid = new KidDiscount();
            switch (cmbDiscountList.SelectedIndex)
            {
                case 0:
                    txtTicket.Text = "學生票";
                    if (chb3D.Checked) { txtTicket.Text += "(3D)"; }
                    txtDicount.Text = Student.ToString();
                    Ticket.SetDiscount(Student);
                    break;

                case 1:
                    txtTicket.Text = "小屁孩票";
                    if (chb3D.Checked) { txtTicket.Text += "(3D)"; }
                    txtDicount.Text = "小屁孩打三折";
                    Ticket.SetDiscount(Kid);

                    break;

                case 2:
                    txtTicket.Text = "VIP票";
                    if (chb3D.Checked) { txtTicket.Text += "(3D)"; }
                    txtDicount.Text = "VIP票打五折";
                    Ticket.SetDiscount(Vip);

                    break;
            }
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            int amoount = int.Parse(txtamount.Text);
            double Money = Ticket.Price * amoount;
            if (chb3D.Checked) { txtTicket.Text += "(3D)"; }
            txtResult.Text += "一張" + txtTicket.Text + "原價" + Price + "," + txtDicount.Text + "買" + amoount + "張,共" + Money + "元\n";
            TotalMoney += Money;
            btnPayMoney.Enabled = true;
        }

        private void btnPayMoney_Click(object sender, EventArgs e)
        {
            txtResult.AppendText("總計:共" + TotalMoney + "元\n");
            TotalMoney = 0;
            btnPayMoney.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            config = ConfigurationSettings.AppSettings["two"];
            Price = double.Parse(config);
            TotalMoney = 0;
            lblMovieTicket.Text = "電影票價:" + Price + "元";
            btnPayMoney.Enabled = false;
        }

        private void chb3D_CheckedChanged(object sender, EventArgs e)
        {
            if (chb3D.Checked)
            {
                config = ConfigurationSettings.AppSettings["three"];
                Price = double.Parse(config);
                lblMovieTicket.Text = "電影票價:" + Price + "元";
            }
            else
            {
                config = ConfigurationSettings.AppSettings["two"];
                Price = double.Parse(config);
                lblMovieTicket.Text = "電影票價:" + Price + "元";
            }
        }
    }
}