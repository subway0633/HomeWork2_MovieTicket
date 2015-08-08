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

        //private KidDiscount Kid;
        //private VipDiscount Vip;
        //private StudentDiscount Student;
        private double TotalMoney, TicketMoney;

        public Form1()
        {
            InitializeComponent();
            Ticket = new AllTicket();
            TicketMoney = 300;
            //Student = new StudentDiscount();
            //Vip = new VipDiscount();
            //Kid = new KidDiscount();
            Ticket.Price = TicketMoney;
        }

        private void cmbDiscountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string config;

            //將票價固定在TicketMoney

            switch (cmbDiscountList.SelectedIndex)
            {
                case 0:
                    config = ConfigurationManager.AppSettings["Student"];
                    txtTicket.Text = "學生票";
                    計算票價(config);
                    break;

                case 1:
                    config = ConfigurationManager.AppSettings["Student2"];
                    txtTicket.Text = "大學生票";
                    計算票價(config);
                    break;

                case 2:
                    config = ConfigurationManager.AppSettings["Kid"];
                    txtTicket.Text = "三歲以下小朋友";
                    計算票價(config);
                    break;

                case 3:
                    config = ConfigurationManager.AppSettings["Kid2"];
                    txtTicket.Text = "小屁孩";
                    計算票價(config);
                    break;

                case 4:
                    config = ConfigurationManager.AppSettings["Vip"];
                    txtTicket.Text = "VIP";
                    計算票價(config);
                    break;
            }
        }

        public void 計算票價(string key)
        {
            IDiscount discount;
            discount = Reflection.GetDiscount(key);
            txtDiscount.Text = discount.ToString();
            Ticket.SetDiscount(discount);
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(txtamount.Text);
            double Money = Ticket.Price * amount;

            txtResult.Text += "一張" + txtTicket.Text + "原價" + TicketMoney + "," + txtDiscount.Text +
                "折扣完後:" + Ticket.Price + ",買" + amount + "張,共" + Money + "元\n";
            TotalMoney += Money;
            btnPayMoney.Enabled = true;
        }

        private void btnPayMoney_Click(object sender, EventArgs e)
        {
            txtResult.Text += "總計:共" + TotalMoney + "元\n";

            TotalMoney = 0;
            btnPayMoney.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TotalMoney = 0;
            lblMovieTicket.Text = "電影票價:" + TicketMoney + "元";
            btnPayMoney.Enabled = false;
        }
    }
}