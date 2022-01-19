using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
namespace CalcProfit
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        void result()
        {
            try
            {
                double buy = Convert.ToDouble(txtBuy.Text),
                        sell = 0.0,
                        rent = 0.0;
                if (btnTaxes.Checked) sell = 0.87 * Convert.ToDouble(txtSell.Text);
                else sell = Convert.ToDouble(txtSell.Text);
                txtTaxes.Text = sell.ToString();
                rent = ((sell - buy) / buy) * 100.0;

                txtRent.Text = Math.Round(rent, 3) + "%";
            }
            catch (Exception ex)
            {
                txtRent.Text = "null";
            }
        }

        private void txtSell_TextChanged(object sender, EventArgs e)
        {
            result();
        }

        private void txtBuy_TextChanged(object sender, EventArgs e)
        {
            result();
        }

        private void btnTaxes_CheckedChanged(object sender, EventArgs e)
        {
            result();
        }

        private void btnSteam_Click(object sender, EventArgs e)
        {
            Process.Start("https://steamcommunity.com/market/");
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://dmarket.com/ru/ingame-items/item-list/csgo-skins");
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://buff.163.com/market/csgo#tab=selling&page_num=1");
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://market.csgo.com");
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/id219176419");
        }
    }
}
