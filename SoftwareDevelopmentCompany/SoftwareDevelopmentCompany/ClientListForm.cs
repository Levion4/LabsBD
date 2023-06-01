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
    public partial class ClientListForm : Form
    {
        private static ClientListForm f;

        public static ClientListForm fw
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new ClientListForm();
                }

                return f;
            }
        }

        public ClientListForm()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softwareDevelopmentCompanyDataSet);

        }

        private void ClientListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareDevelopmentCompanyDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.softwareDevelopmentCompanyDataSet.Client);
        }
    }
}
