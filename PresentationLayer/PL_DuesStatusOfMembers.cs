using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace PresentationLayer
{

    public partial class PL_DuesStatusOfMembers : Form
    {
        private BusinessLayer.BL_SendEmail pl_sendmail;
        private BusinessLayer.BL_MemberList pl_memberlist;
        private BusinessLayer.BL_UpdateMember pl_updatemember;
        private BusinessLayer.BL_UniqueMember pl_uniquemember;
        private BusinessLayer.BL_AddMember pl_admember;
        private BusinessLayer.BL_AddDuetoMember pl_addduetomember;
        public PL_DuesStatusOfMembers()
        {
            pl_memberlist = new BusinessLayer.BL_MemberList();
            pl_sendmail = new BusinessLayer.BL_SendEmail();
            pl_updatemember = new BusinessLayer.BL_UpdateMember();
            pl_uniquemember = new BusinessLayer.BL_UniqueMember();
            pl_admember = new BusinessLayer.BL_AddMember();
            pl_addduetomember = new BusinessLayer.BL_AddDuetoMember();
            InitializeComponent();
        }
        public static string kimlik_no;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                richTextBox1.Enabled = true;
            }
            else if (checkBox1.Checked == false)
            {
                textBox1.Enabled = false;
                richTextBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> postalist = new List<string>();
                pl_sendmail.SendMail(postalist, textBox1.Text, richTextBox1.Text);
                MessageBox.Show("Mail gönderildi.");
            }
            catch
            {
                MessageBox.Show("Mail gönderilemedi.");
            }
        }

        private void PL_DuesStatusOfMembers_Load(object sender, EventArgs e)
        {
            try
            {
                FillTable(0);
            }
            catch
            {
                MessageBox.Show("kişi listesi olmadı");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox2.Checked == true)
                {
                    FillTable(2);
                }
                else if (checkBox2.Checked == false)
                {
                    FillTable(0);

                }
            }
            catch
            {
                MessageBox.Show("kişi listesi olmadı");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {           
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                                 
                label3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Yapamadın ibine");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //GÜNCELLE BUTONU
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                string kimlik = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                string[,] membersArray = new string[100, 10];

                pl_updatemember.UpdateMember(id, kimlik, comboBox2.Text, comboBox1.Text);
                FillTable(0);
            }
            catch
            {
                MessageBox.Show("Aidat listesi hazırlanırken bir hata oluştu. ");
            }

        }
        public void FillTable(int x)
        {
            try
            {
                string[,] membersArray = new string[100, 10];
                dataGridView1.Rows.Clear();
                pl_memberlist.GetMember(membersArray,kimlik_no, x);
                for (int i = 0; i < membersArray.GetLength(0); i++)
                {
                    if (membersArray[i, 0] != null)
                    {
                        dataGridView1.Rows.Add(
                            membersArray[i, 0],
                            membersArray[i, 1],
                            membersArray[i, 2] + " TL",
                            membersArray[i, 3],
                            membersArray[i, 4],
                            membersArray[i, 5],
                            membersArray[i, 6],
                            membersArray[i, 7],
                            membersArray[i, 8],
                            membersArray[i, 9]
                        );
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Güncellenemedi");
            }

        }

        private void buton_pdf_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                {
                    try
                    {
                        PdfPTable pdfTablosu = new PdfPTable(dataGridView1.ColumnCount);
                        pdfTablosu.DefaultCell.Padding = 3;
                        pdfTablosu.WidthPercentage = 100;
                        pdfTablosu.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfTablosu.DefaultCell.BorderWidth = 1;
                        foreach (DataGridViewColumn sutun in dataGridView1.Columns)
                        {
                            PdfPCell pdfHucresi = new PdfPCell(new Phrase(sutun.HeaderText));
                            pdfTablosu.AddCell(pdfHucresi);
                        }
                        foreach (DataGridViewRow satir in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in satir.Cells)
                            {
                                pdfTablosu.AddCell(cell.Value.ToString());
                            }
                        }

                        SaveFileDialog pdfkaydetme = new SaveFileDialog();
                        pdfkaydetme.Filter = "PDF Dosyaları|*.pdf";
                        pdfkaydetme.Title = "PDF Olarak Kaydet";
                        if (pdfkaydetme.ShowDialog() == DialogResult.OK)
                        {
                            using (FileStream stream = new FileStream(pdfkaydetme.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDosya = new iTextSharp.text.Document(PageSize.A4, 5f, 5f, 11f, 10f);
                                iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDosya, stream);
                                pdfDosya.Open();
                                pdfDosya.Add(pdfTablosu);
                                pdfDosya.Close();
                                stream.Close();
                                MessageBox.Show("PDF dosyası başarıyla oluşturuldu!\n" + "Dosya Konumu: " + pdfkaydetme.FileName, "İşlem Tamam");
                            }
                        }
                    }

                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Önce Borçluları Seçiniz");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                string[,] duestats = new string[100, 10];
                pl_uniquemember.UniqueMember(duestats, dateTimePicker1.Value, dateTimePicker2.Value, comboBox4.Text);

                dataGridView1.Rows.Clear();
                for (int i = 0; i < duestats.GetLength(0); i++)
                {
                    if (duestats[i, 0] != null)
                    {
                        dataGridView1.Rows.Add(
                            duestats[i, 0],
                            duestats[i, 1],
                            duestats[i, 2] + " TL",
                            duestats[i, 3],
                            duestats[i, 4],
                            duestats[i, 5],
                            duestats[i, 6],
                            duestats[i, 7],
                            duestats[i, 8],
                            duestats[i, 9]
                        );
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            kimlik_no= dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            PL_UniqueMemberForm pl_UniqueMemberForm = new PL_UniqueMemberForm();
            pl_UniqueMemberForm.StartPosition = FormStartPosition.CenterScreen;
            pl_UniqueMemberForm.Show();
        }

    }
}
    

    

