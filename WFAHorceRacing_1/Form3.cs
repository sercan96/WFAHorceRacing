using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHorceRacing_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        decimal bakiye = 5000, cuzdan = 0;

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            try
            {
                decimal cekilecekMiktar = Convert.ToDecimal(txtMiktar.Text);
                if(cekilecekMiktar == 0)
                {
                    MessageBox.Show("Lütfen miktar giriniz");
                }
                else if (cekilecekMiktar > bakiye)
                {
                    MessageBox.Show("Hesabınızda bu kadar para yok");
                }
                else
                {
                    bakiye -= cekilecekMiktar;
                    cuzdan += cekilecekMiktar;
                    lblCuzdan.Text = $"Cüzdan: {cuzdan}";
                    lblHesap.Text = $"Hesap : {bakiye}";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblCuzdan.Text += $" {cuzdan}";
            lblHesap.Text += $" {bakiye}";
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            decimal yatirilacakPara = Convert.ToDecimal(txtMiktar.Text);
            if(yatirilacakPara == 0)
            {
                MessageBox.Show("Lütfen miktar giriniz");
            }
            else if(yatirilacakPara > cuzdan)
            {
                MessageBox.Show("Cuzdanınızda bu kadar para yok");
            }
            else
            {
                cuzdan -= yatirilacakPara;
                bakiye += yatirilacakPara;
                lblCuzdan.Text = $"Cüzdan: {cuzdan}";
                lblHesap.Text = $"Hesap: {bakiye}";
            }

        }
    }
}
