using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDevelopmentCompany
{
    public partial class ProjectListForm : Form
    {
        private static ProjectListForm f;

        public static ProjectListForm fw
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new ProjectListForm();
                }

                return f;
            }
        }

        public ProjectListForm()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void projectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softwareDevelopmentCompanyDataSet);

        }

        private void ProjectListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareDevelopmentCompanyDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.softwareDevelopmentCompanyDataSet.Project);

        }

        private void ProjectDataGridView_CellFormatting(object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (ProjectDataGridView.Rows[e.RowIndex].
                Cells["DataGridViewCheckBoxColumnActOfImplementation"].Value == null)
            {
                e.CellStyle.BackColor = Color.LightGreen;
            }
            else
            {
                if ((bool)ProjectDataGridView.Rows[e.RowIndex].
                    Cells["DataGridViewCheckBoxColumnActOfImplementation"].Value == false)
                {
                    e.CellStyle.BackColor = Color.LightPink;
                }
                else
                {
                    e.CellStyle.BackColor = Color.SkyBlue;
                }
            }
        }
    }
}
