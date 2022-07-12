using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {

        BindingList<CarReport> list = new BindingList<CarReport>();
        public Form1()
        {
            InitializeComponent();
           
        }
        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //氏名が未入力なら登録しない
            if (String.IsNullOrWhiteSpace(DateTime.Text))
            {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

           CarReport newPerson = new CarReport
            {
               DateTime = dtpDate.Value,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = cbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
                Registration = dtpRegistDate.Value,
            };
            listPerson.Add(newPerson);
            dgvPersons.Rows[dgvPersons.RowCount - 1].Selected = true;

            EnabledCheck(); //マスク処理呼び出し

            setCbCompany(cbCompany.Text);
        }
    }

       
    }
}
