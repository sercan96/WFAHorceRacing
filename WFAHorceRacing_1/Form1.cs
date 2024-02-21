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
    public partial class Form1 : Form
    {

        //Bir kontrolün "Left" property'si o kontrolün sol tarafa olan uzaklıgını size teslim eder(int tipinde deger olarak döndürür) Ve bu özellige deger atanabilir...


        //Bir kontrolün "Top" property'si ise o kontrolün üst tarafa olan uzaklıgını size int tipinde döndürür...Bu Top property'sine de deger atayabilirsiniz....

        //Bir kontrolün left ve top özelliklerine deger ataması yapabilirsiniz...Ancak right ve bottom özelliklerine atama yapamazsınız...

        //Right ve Bottom özellikleri readonly...Yani onlara atama yapılamaz...

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();

            DialogResult dr = MessageBox.Show("Programdan cıkmak ister misiniz", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }

           //string a =    textBox1.Text;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Left += 30;


            MessageBox.Show(button1.Right.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
