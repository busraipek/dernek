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
    public partial class PL_HomePage : Form
    {
        BusinessLayer.BL_SendEmail pl_sendemail;
        BusinessLayer.BL_MemberList pl_memberlist;
        BusinessLayer.BL_FilterMember pl_filtermember;


        public PL_HomePage()
        {
            InitializeComponent();
            pl_sendemail = new BL_SendEmail();
            pl_memberlist = new BL_MemberList();
            pl_filtermember = new BL_FilterMember();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Mail gönderildi.");
            }
            catch
            {
                MessageBox.Show("Mail gönderilemedi.");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string filter = "tumu";
                string texter = "tumu";
                FillDataGridWiew(filter, texter);
            }
            catch
            {
                MessageBox.Show("Kişi listesi oluşturulamadı");
            }
        }
        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_AddMember PL_AddMember = new PL_AddMember();
            PL_AddMember.StartPosition = FormStartPosition.CenterScreen;
            PL_AddMember.Show();
        }
        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // AD FİLTRELEME

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string filter = "ad";
                    string texter = toolStripTextBox1.Text.ToString();
                    FillDataGridWiew(filter, texter);
                }
                catch
                {
                    MessageBox.Show("Filtre uygulanırken bir sorun oluştu");
                }
            }
        }
        private void tümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TÜM ÜYELERİ LİSTELEME

            try
            {
                string filter = "tumu";
                string texter = "tumu";
                FillDataGridWiew(filter, texter);
            }
            catch
            {
                MessageBox.Show("Kişi listesi oluşturulamadı");
            }
        }
        private void toolStripTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            //SOYAD FİLTRELEME

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string filter = "soyad";
                    string texter = toolStripTextBox2.Text.ToString();
                    FillDataGridWiew(filter, texter);
                }
                catch
                {
                    MessageBox.Show("Filtre uygulanırken bir sorun oluştu");
                }
            }
        }
        private void toolStripTextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            //ŞEHİR FİLTRELEME

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string filter = "sehir";
                    string texter = toolStripTextBox4.Text.ToString();
                    FillDataGridWiew(filter, texter);
                }
                catch
                {
                    MessageBox.Show("Filtre uygulanırken bir sorun oluştu");
                }
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ÜYELİK DURUMU FİLTRELEME
            try
            {
                string filter = "uyelik_durumu";
                string texter = toolStripComboBox1.Text.ToString();
                FillDataGridWiew(filter, texter);
            }
            catch
            {
                MessageBox.Show("Filtre uygulanırken bir sorun oluştu");
            }
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //KAN GRUBU FİLTRELEME
            try
            {
                string filter = "kan_grubu";
                string texter = toolStripComboBox2.Text.ToString();
                FillDataGridWiew(filter,texter);
            }
            catch
            {
                MessageBox.Show("Filtre uygulanırken bir sorun oluştu");
            }
        }

        private void üyeListeleToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
            toolStripTextBox1.Clear();
            toolStripTextBox2.Clear();
            toolStripTextBox4.Clear();
            }
            catch
            {
                MessageBox.Show("Bir hata oluştu, önemli mi bilmiyorum..");
            }

        }
        private void FillDataGridWiew(string filter,string texter)
        {
            dataGridView1.Rows.Clear();
            try
            {
                string filt = filter;
                string text = texter;

                string[,] membersArray = new string[100, 9];
                pl_filtermember.FilterMember(membersArray, filt, text);
                for (int i = 0; i < membersArray.GetLength(0); i++)
                {
                    if (membersArray[i,0]!=null)
                    {
                        dataGridView1.Rows.Add(
                            membersArray[i, 0],
                            membersArray[i, 1],
                            membersArray[i, 2],
                            membersArray[i, 3],
                            membersArray[i, 4],
                            membersArray[i, 5],
                            membersArray[i, 6],
                            membersArray[i, 7],
                            membersArray[i, 8]
                    );
                    }
                    else
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Liste görüntülenemedi");
            }
            }

        private void güncelAidatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PL_CurrentDue PL_CurrentDue = new PL_CurrentDue();
            PL_CurrentDue.StartPosition = FormStartPosition.CenterScreen;
            PL_CurrentDue.Show();

        }

        private void üyelerinAidatDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_DuesStatusOfMembers PL_DuesStatusOfMembers = new PL_DuesStatusOfMembers();
            PL_DuesStatusOfMembers.StartPosition = FormStartPosition.CenterScreen;
            PL_DuesStatusOfMembers.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    }

