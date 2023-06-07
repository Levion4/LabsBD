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

        int idCurrent = -1;

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

        public int ShowSelectForm(int id)
        {
            OKToolStripButton.Visible = true;
            idCurrent = id;

            if (ShowDialog() == DialogResult.OK)
            {
                return
                (int)((DataRowView)clientBindingSource.Current)["IdClient"];
            }
            else
            {
                return -1;
            }
        }

        public void ShowForm()
        {
            OKToolStripButton.Visible = false;
            clientBindingSource.Position = 0;
            Show();
            Activate();
        }

        string GetSelectedFieldName()
        {
            return ClientDataGridView.Columns[
                ClientDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }


        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(
                    this.softwareDevelopmentCompanyDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error when filling out clients", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareDevelopmentCompanyDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.softwareDevelopmentCompanyDataSet.Client);
        }

        private void FindToolStripButton_Click(object sender, EventArgs e)
        {
            if (FindToolStripTextBox.Text == "")
            {
                MessageBox.Show("You didn't ask anything", "Attention",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            int indexPos;

            try
            {
                indexPos =
                clientBindingSource.Find(GetSelectedFieldName(),
                FindToolStripTextBox.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Search error \n" + err.Message);

                return;
            }

            if (indexPos > -1)
            {
                clientBindingSource.Position = indexPos;
            }
            else
            {
                MessageBox.Show("There are no such clients", "Attention",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                clientBindingSource.Position = 0;
            }

        }

        private void FindCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FindCheckBox.Checked)
            {
                if (FindToolStripTextBox.Text == "")
                {
                    MessageBox.Show("You didn't ask anything", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        clientBindingSource.Filter =
                        GetSelectedFieldName() + "='" + FindToolStripTextBox.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Filtering error \n" +
                        err.Message);
                    }
                }
            }
            else
            {
                clientBindingSource.Filter = "";
            }

            if (clientBindingSource.Count == 0)
            {
                MessageBox.Show("There are no such");
                clientBindingSource.Filter = "";
                FindCheckBox.Checked = false;
            }
        }

        private void OKToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ClientListForm_Shown(object sender, EventArgs e)
        {
            clientBindingSource.Position =
                clientBindingSource.Find("IdClient", idCurrent);
        }
    }
}
