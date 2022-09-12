using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseSample {
    public partial class bt_Save : Form {
        public bt_Save()
        {
            InitializeComponent();
        }

        private void 社員BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.社員BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202233DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202233DataSet.社員' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
           

        }

        private void 社員DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            this.社員TableAdapter.Fill(this.infosys202233DataSet.社員);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.社員BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202233DataSet);
        }

        private void btExecute_Click(object sender, EventArgs e)
        {
            this.社員TableAdapter.FillBySalary(this.infosys202233DataSet.社員, int.Parse(tbValue.Text));
        }
    }
}
