using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4: Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void groupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.plotnickov_ExamsDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "plotnickov_ExamsDataSet.groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.plotnickov_ExamsDataSet.groups);

        }
    }
}
