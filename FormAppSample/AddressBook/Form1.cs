using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1()
        {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog()== DialogResult.OK) {
                pbPicture.Image =Image.FromFile( ofdFileOpenDialog.FileName);
            }
        }
        private void btPictureClear_Click(object sender, EventArgs e)  {
            pbPicture.Image = null;
        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person{
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = getCheckBoxGroup(),

            };
            listPerson.Add(newPerson);
        }
        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> getCheckBoxGroup() {
            var listGroup = new List<Person.GroupType>();
            if (cbFamily.Checked == true) {
                listGroup.Add(Person.GroupType.家族);
            }
            if (cbFriend.Checked == true)
            {
                listGroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked == true)
            {
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked == true)
            {
                listGroup.Add(Person.GroupType.その他);
            }


                        return listGroup;
        }

        private void dgvPersons_Click(object sender, EventArgs e)
        {
            /*
             * データグリットビューのインデックス０番の番号をテキストボックスに格納
            tbName.Text = listPerson[0].Name*/


            //選択されているインデックスを取得
            if (dgvPersons.CurrentRow == null) return;
            var indexRow = dgvPersons.CurrentRow.Index;
            tbName.Text = listPerson[indexRow].Name;
            tbMailAddress.Text = listPerson[indexRow].MailAddress;
            tbAddress.Text = listPerson[indexRow].Address;
            tbCompany.Text = listPerson[indexRow].Company;
            allClear();//グループチェックボックスをいったん初期化
            foreach (var group in listPerson[indexRow].listGroup)
            {
                switch (group)
                {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }
        //グループのチェックボックスをオールクリア
        private void allClear()
        {
            //cbFamily.Checked = false;
            // cbFriend.Checked = false;
            //cbWork.Checked = false;
            // cbOther.Checked = false;
            cbFamily.Checked =cbFriend.Checked =cbWork.Checked =cbOther.Checked =false;
        }
        //更新ボタンが押された時の処理
        private void btUpdate_Click(object sender, EventArgs e)  {
            var indexRow = dgvPersons.CurrentRow.Index;
            listPerson[indexRow] = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = getCheckBoxGroup(),
            };
        }
    }
}