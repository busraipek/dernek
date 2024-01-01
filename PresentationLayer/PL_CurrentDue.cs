using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class PL_CurrentDue : Form
    {
        private BusinessLayer.BL_DueList pl_duelist;
        private BusinessLayer.BL_UpdateDue pl_updatedue;
        private BusinessLayer.AddDue adddue;
        public int id;
        public PL_CurrentDue()
        {
            pl_duelist = new BusinessLayer.BL_DueList();
            pl_updatedue = new BusinessLayer.BL_UpdateDue();
            adddue = new BusinessLayer.AddDue();
            InitializeComponent();
        }
        private void FillTable()
        {
            string[,] membersArray = new string[100, 4];

            pl_duelist.GetDues(membersArray);
            dataGridView1.Rows.Clear();

            for (int i = 0; i < membersArray.GetLength(0); i++)
            {

                if (membersArray[i, 0] != null)
                {
                    dataGridView1.Rows.Add(
                        membersArray[i, 0],
                        membersArray[i, 1],
                        membersArray[i, 2],
                        membersArray[i, 3]
                   );
                }
                else
                    break;
            }
        }
        private void PL_CurrentDue_Load(object sender, EventArgs e)
        {
            try
            {
                adddue.AddDues();
                FillTable();
            }
            catch
            {
                MessageBox.Show("Aidat listesi hazırlanırken bir hata oluştu. ");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                dateTimePicker1.Enabled = true;

            }
            else if (checkBox1.Checked == false)
            {
                textBox1.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                label3.Text= dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox1.Text= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] membersArray = new string[100, 4];
                if (label3.Text == "label3")
                {
                MessageBox.Show("Önce bir aidat seçiniz.");
                }
                else
                {
                pl_updatedue.UpdateDue(membersArray,label3.Text, dateTimePicker1.Text, textBox1.Text);
                    MessageBox.Show("Güncellendi");

                    FillTable();
                }

            }
            catch
            {
                MessageBox.Show("Aidat listesi hazırlanırken bir hata oluştu. ");
            }

    }

}
    }

