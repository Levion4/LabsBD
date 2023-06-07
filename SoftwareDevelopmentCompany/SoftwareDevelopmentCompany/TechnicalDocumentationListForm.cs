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
    public partial class TechnicalDocumentationListForm : Form
    {
        private static TechnicalDocumentationListForm f;

        public static TechnicalDocumentationListForm fw
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new TechnicalDocumentationListForm();
                }

                return f;
            }
        }

        public TechnicalDocumentationListForm()
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

        private void TechnicalDocumentationListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareDevelopmentCompanyDataSet.TechnicalDocumentation". При необходимости она может быть перемещена или удалена.
            this.technicalDocumentationTableAdapter.Fill(this.softwareDevelopmentCompanyDataSet.TechnicalDocumentation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareDevelopmentCompanyDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.softwareDevelopmentCompanyDataSet.Project);
            softwareDevelopmentCompanyDataSet.TechnicalDocumentation.
                Columns["DateOfCreation"].DefaultValue = DateTime.Now;
        }

        private void TDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.technicalDocumentationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softwareDevelopmentCompanyDataSet);
        }
    }
}
