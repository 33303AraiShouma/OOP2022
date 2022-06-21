using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("氏名が入力されていません");
                return;
            }
            Person newPerson = new Person
            {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = getCheckBoxGroup(),
                Registration = dtDateTime.Value
            };
            listPerson.Add(newPerson);
            dgvPersons.Rows[dgvPersons.RowCount -1].Selected = true;
            EnableCheck();
        }
        private void setCbCompany(string item)
        {
            //コンボボックスに会社名を登録する（重複なし）
            if (!cbCompany.Items.Contains(cbCompany.Text))
            {
                //まだ登録されていなければ登録
                cbCompany.Items.Add(cbCompany.Text);
            }
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
            dtDateTime.Value = listPerson[indexRow].Registration.Year > 1900 ? listPerson[indexRow].Registration : DateTime.Today;
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
           // var indexRow = dgvPersons.CurrentRow.Index;
            //listPerson[indexRow] = new Person {
               // Name = tbName.Text,
               // MailAddress = tbMailAddress.Text,
               // Address = tbAddress.Text,
               // Company = tbCompany.Text,
               // Picture = pbPicture.Image,
               // listGroup = getCheckBoxGroup()

            listPerson[dgvPersons.CurrentRow.Index].Name = tbName.Text;
            listPerson[dgvPersons.CurrentRow.Index].MailAddress = tbMailAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Address = tbAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Picture= pbPicture.Image;
            listPerson[dgvPersons.CurrentRow.Index].listGroup= getCheckBoxGroup();
            listPerson[dgvPersons.CurrentRow.Index].Registration= dtDateTime.Value;
            dgvPersons.Refresh();
            // };
        }

        private void btDelete_Click(object sender, EventArgs e){
            // var indexRow = dgvPersons.CurrentRow.Index;
            //dgvPersons.Rows.RemoveAt(indexRow);
            //dgvPersons.Refresh();
            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);
                EnableCheck();
        }

        private void EnableCheck()
        {
            if (listPerson.Count() > 0) {
                btDelete.Enabled = false;//削除ボタンをマスク
                btUpdate.Enabled = false;//更新ボタン
            }
            else {
                btDelete.Enabled = false;
                btUpdate.Enabled = false;
            }
        }
            private void Form1_Load(object sender, EventArgs e) {
                EnableCheck();//マスク処理呼び出し

        }
        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e){
            if (sfdSaveDialog.ShowDialog()== DialogResult.OK) {
                try
                {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create))
                    {
                        bf.Serialize(fs, listPerson);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btOpen_Click(object sender, EventArgs e)
        {
            if (ofdFileOpenDialog.ShowDialog()== DialogResult.OK) {
                try
                {
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName,FileMode.Open,FileAccess.Read))
                    {
                        //逆シリアル化して読み込む
                        listPerson =(BindingList<Person>) bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource =listPerson;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                foreach (var item in listPerson.Select(p => p.Company))
                {
                    setCbCompany(item);
                }
                EnableCheck();
            }
        }
    }
}