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
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void resultsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.resultsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.plotnickov_ExamsDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "plotnickov_ExamsDataSet.results". При необходимости она может быть перемещена или удалена.
            this.resultsTableAdapter.Fill(this.plotnickov_ExamsDataSet.results);

        }
    }
}
