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
    public partial class PL_UniqueMemberForm : Form
    {
        private BusinessLayer.BL_MemberList pl_memberlist;
        public PL_UniqueMemberForm()
        {
            pl_memberlist = new BusinessLayer.BL_MemberList();
            InitializeComponent();
        }
       

        private void PL_UniqueMemberForm_Load(object sender, EventArgs e)
        {
            string kimlik= PL_DuesStatusOfMembers.kimlik_no;
            try
            {
                string[,] membersArray = new string[100, 10];
                dataGridView2.Rows.Clear();
                pl_memberlist.GetMember(membersArray, kimlik, 1);
                for (int i = 0; i < membersArray.GetLength(0); i++)
                {
                    if (membersArray[i, 0] != null)
                    {
                        dataGridView2.Rows.Add(
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
    }
}
