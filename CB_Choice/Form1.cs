using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CB_Choice
{
    public partial class Form1 : Form
    {
        string[] SList = new string[]
        {
            "김밥", "샐러드김밥", "야채김밥",
            "소고기김밥", "계란김밥", "라볶이"
        };
        string OrgStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void LblResult_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < this.SList.Length; i++)
            {
                this.cbList.Items.Add(this.SList[i]);
            }
            this.OrgStr = this.lblResult.Text;
            // this.cbList.SelectedIndex = 0; // 가장 첫 번째의 인덱스를 선택함
            if(this.SList.Length > 0)
            {
                this.cbList.SelectedIndex = 0;
            }
            
        }

        private void TxtList_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = this.OrgStr + this.cbList.Text;
        }

        private void BtnAdd_Click(object sender, EventArgs e)

        {
            CheckInput();   
        }

        private bool CheckInput()
        {
            if (this.txtList.Text == "")
            {
                MessageBox.Show("추가할 항목을 입력해주세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtList.Focus();
                return false;
            }
            else
            {
                this.cbList.Items.Add(this.txtList.Text); // 적은 항목을 추가
                this.txtList.Text = "";
                this.txtList.Focus(); // 추가 시킨 항목에 다시 포커스
                this.cbList.SelectedIndex = this.cbList.Items.Count - 1; // 맨 마지막 항목을 선택되게
                // 사용자의 경험을 토대로 자연스럽게 만드는 방법, US (User S~)
                return true;
            }
        }
    }
}
