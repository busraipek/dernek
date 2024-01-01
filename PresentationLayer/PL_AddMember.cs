using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class PL_AddMember : Form
    {
        private BusinessLayer.BL_CityList pl_citylist;
        private BusinessLayer.BL_AddDuetoMember pl_addtomember;
        private BusinessLayer.BL_AddMember pl_addmember;

        public PL_AddMember()
        {
            pl_citylist = new BL_CityList();
            pl_addtomember = new BL_AddDuetoMember();
            pl_addmember = new BL_AddMember();
            InitializeComponent();
        }
        private void PL_AddMember_Load(object sender, EventArgs e)
        {
            try
            {            
            List<string> cinsiyet = new List<string> { "Kadın", "Erkek" };
            foreach (string veri in cinsiyet)
            {
                cb_cinsiyet.Items.Add(veri);
            }
            
            List<string> kangrubu = new List<string> { "0-", "0+", "A-", "A+", "B-", "B+", "AB-", "AB+" };
            foreach (string veri in kangrubu)
            {
                cb_kangrubu.Items.Add(veri);
            }
            
            List<string> uyelik = new List<string> { "Aktif", "Pasif" };
            foreach (string veri in uyelik)
            {
                cb_uyelikdurumu.Items.Add(veri);
            }
                cb_uyelikdurumu.Text = uyelik[0];
                cb_kangrubu.Text = kangrubu[0];
                cb_cinsiyet.Text = cinsiyet[0];
                cb_cinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_kangrubu.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_uyelikdurumu.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_sehir.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch
            {
                MessageBox.Show("Form yüklenirken bir hata oluştu.");
                this.Close();
            }
            try
            {
                List<string> cities = new List<string>();
                pl_citylist.GetCities(cities);
                cb_sehir.DataSource = cities;
            }
            catch
            {
                MessageBox.Show("şehir listesi oluşturulamadı");
            }
        }
        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }
        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);


        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox5.Text != string.Empty && textBox4.Text != string.Empty)
            {
                    string ad = textBox1.Text;
                    string soyad = textBox2.Text;
                    string cinsiyet = cb_cinsiyet.Text;
                    string kimlik =textBox5.Text;
                    DateTime dogum = dateTimePicker1.Value;
                    string kan_grubu= cb_kangrubu.Text;
                    string uyelik= cb_uyelikdurumu.Text;
                    string e_posta = textBox4.Text;
                    string sehir = cb_sehir.Text;
                try
                {

                    pl_addmember.AddMember(ad, soyad, cinsiyet, kimlik,dogum, kan_grubu, uyelik, e_posta, sehir);
                    pl_addtomember.DuetoNewMember(textBox5.Text,"Ödenmedi");

                    if (pl_addmember.BL_FillBar()==true)
                    {
                        while (progressBar1.Value < 100)
                        {
                        
                        progressBar1.Value = +progressBar1.Value + 100;

                        }
                        if (progressBar1.Value == 100)
                        {
                            MessageBox.Show("Üye kaydedildi.");
                            progressBar1.Value = 0;
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Üye kaydedilemedi, tekrar deneyin");
                }
            }
            else
                MessageBox.Show("Tüm bilgilerin doldurulması zorunludur.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.ToUpper();
            textBox2.SelectionStart = textBox2.Text.Length;
        }
    }
}
