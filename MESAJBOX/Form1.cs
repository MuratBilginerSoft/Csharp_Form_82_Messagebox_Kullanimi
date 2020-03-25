using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MESAJBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Moda hayatımızı esir almış durumda","Bilgi",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            MessageBox.Show("1. bu yüzden bu illetten kurtulmalı \n"+"2. hayata birde modaya esir olmadan bakmalısın","Uyarılarımı Dikkate Al",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            MessageBox.Show("Bir hafta sonra nasıl hissedeceğini merak ediyormusun"+Environment.NewLine+"Şimdiden olacakları hayal edebiliyormusun","Soru",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            MessageBox.Show("Eğer edebiliyorsan güzel şeylerin olacağının farkındasındır umarım","Son",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1,MessageBoxOptions.ServiceNotification);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult basılantus;

            basılantus = MessageBox.Show("Artık mutluluklar yok", "önemli!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (basılantus == DialogResult.OK)
                Application.Exit();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult basılantus;

            basılantus = colorDialog1.ShowDialog();
            basılantus = MessageBox.Show("Renk Değiştirilecek","test",MessageBoxButtons.OKCancel,MessageBoxIcon.None);
            if (basılantus == DialogResult.OK)
                this.BackColor = colorDialog1.Color;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
