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
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //設定情報保存
        Settings settings = Settings.getInstance();

        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public Form1()
        {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReport;
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
           CarReport newCarreport = new CarReport
            {
                Date = dtpDate.Value,
                Auther = cbName.Text,
                Maker = getMaker(),
                CarName = cbCarName.Text,
                Picture = pbPicture.Image,
                Report = tbReport.Text,               
            };
            listCarReport.Add(newCarreport);
            EnabledCheck();
            setCbCarName(cbCarName.Text);
            setCbName(cbName.Text);
        }

        //コンポボックスに記録者を登録する
        private void setCbName(String Auther) {

            if (!cbName.Items.Contains(Auther))
            {
                //まだ登録されていなければ登録処理
                cbName.Items.Add(Auther);
            }
        }
        //コンポボックスに車名を登録する
        private void setCbCarName(String CarName)
        {

            if (!cbCarName.Items.Contains(CarName))
            {
                //まだ登録されていなければ登録処理
                cbCarName.Items.Add(CarName);
            }
        }

        private void btRepair_Click(object sender, EventArgs e)
        {
            listCarReport[dgvCarReport.CurrentRow.Index].Date = dtpDate.Value;
            listCarReport[dgvCarReport.CurrentRow.Index].Auther = cbName.Text;
            listCarReport[dgvCarReport.CurrentRow.Index].CarName =cbCarName.Text ;
            listCarReport[dgvCarReport.CurrentRow.Index].Report = tbReport.Text;
            listCarReport[dgvCarReport.CurrentRow.Index].Picture = pbPicture.Image;
            listCarReport[dgvCarReport.CurrentRow.Index].Maker = getMaker();
            dgvCarReport.Refresh(); //データグリッドビュー更新
        }

        private void btDelete2_Click(object sender, EventArgs e)
        {
            listCarReport.RemoveAt(dgvCarReport.CurrentRow.Index);
            EnabledCheck();
        }
         private void EnabledCheck()
        {
          btRepair.Enabled = btDelete2.Enabled = listCarReport.Count() > 0 ? true : false;
        }

        private CarReport.MakerGroup getMaker() {
            if (rbHonnda.Checked)
            {
                return CarReport.MakerGroup.ホンダ;
            }
            if (rbNissann.Checked)
            {
                return CarReport.MakerGroup.日産;
            }
            if (rbToyota.Checked)
            {
                return CarReport.MakerGroup.トヨタ;
            }
            if (rbSubaru.Checked)
            {
                return CarReport.MakerGroup.スバル;
            }
            if (rbAbroad.Checked)
            {
                return CarReport.MakerGroup.外国車;
            }
            else
            {
                return CarReport.MakerGroup.その他;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create))
                    {
                        bf.Serialize(fs,listCarReport);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOpen2_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReport.DataSource = null;
                        dgvCarReport.DataSource = listCarReport;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cbCarName.Items.Clear();    //コンボボックスのアイテム消去
                cbName.Items.Clear();
                //コンボボックスへ新規登録
                foreach (var item in listCarReport.Select(x => x.CarName))
                {
                    setCbCarName(item); //存在する会社を登録
                }
                foreach (var item in listCarReport.Select(x => x.Auther))
                {
                    setCbName(item); //存在する会社を登録
                }
            }
            EnabledCheck(); //マスク処理呼び出し
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ColorChange_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
                settings.MainFormColor = colorDialog1.Color.ToArgb();
            }

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //設定ファイルをシリアル化
            using (var writer = XmlWriter.Create("settings.xml"))
            {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer,settings);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //設定ファイルを逆シリアル化して背景の色を設定
            try
            {
                using (var reader = XmlReader.Create("settings.xml"))
                {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

            }
            EnabledCheck();
        }
    }
}  

