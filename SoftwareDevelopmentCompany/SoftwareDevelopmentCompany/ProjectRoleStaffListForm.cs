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
    public partial class ProjectRoleStaffListForm : Form
    {
        private static ProjectRoleStaffListForm f;

        public static ProjectRoleStaffListForm fw
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new ProjectRoleStaffListForm();
                }

                return f;
            }
        }

        public ProjectRoleStaffListForm()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        string GetSelectedFieldName()
        {
            return RoleStaffDataGridView.Columns[RoleStaffDataGridView.
                CurrentCell.ColumnIndex].DataPropertyName;
        }


        private void projectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.projectBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(
                    this.softwareDevelopmentCompanyDataSet);
            }
            catch(Exception err)
            {
                MessageBox.Show("Error when filling out the project", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProjectRoleStaffListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareDevelopmentCompanyDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.softwareDevelopmentCompanyDataSet.Staff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareDevelopmentCompanyDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.softwareDevelopmentCompanyDataSet.Staff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareDevelopmentCompanyDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.softwareDevelopmentCompanyDataSet.Staff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareDevelopmentCompanyDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.softwareDevelopmentCompanyDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareDevelopmentCompanyDataSet.RoleStaff". При необходимости она может быть перемещена или удалена.
            this.roleStaffTableAdapter.Fill(this.softwareDevelopmentCompanyDataSet.RoleStaff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareDevelopmentCompanyDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.softwareDevelopmentCompanyDataSet.Project);

        }

        private void roleStaffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.projectBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(
                    this.softwareDevelopmentCompanyDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error when filling in staff roles", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            int id = -1;

            if(((DataRowView)projectBindingSource.Current)[
                "IdClient"].ToString() != "")
            {
                id = (int)(((DataRowView)projectBindingSource.Current)
                    ["IdClient"]);
            }

            id = ClientListForm.fw.ShowSelectForm(id);

            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)projectBindingSource.Current)
                    ["IdClient"] = id;
                projectBindingSource.EndEdit();
                clientTableAdapter.Fill(
                    this.softwareDevelopmentCompanyDataSet.Client);
            }
        }

        private void RoleStaffDataGridView_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (String.Compare(GetSelectedFieldName(), "AboutEmployee", false) ==
0)
            {
                string post = "";
                int idStaffCurrent = -1;

                int.TryParse((((DataRowView)roleStaffBindingSource.Current)
                    ["IdStaff"]).ToString(), out idStaffCurrent);
                int idStaff = StaffListForm.fd.ShowSelectForm(
                    idStaffCurrent, out post);
                MessageBox.Show("Id staff=" + idStaff.ToString());
                ((DataRowView)roleStaffBindingSource.Current)
                    ["IdStaff"] = idStaff;
                ((DataRowView)roleStaffBindingSource.Current)["Role"] = post;
                roleStaffBindingSource.EndEdit();
                roleStaffTableAdapter.Update(
                    this.softwareDevelopmentCompanyDataSet);
                staffTableAdapter.Fill(
                    this.softwareDevelopmentCompanyDataSet.Staff);
            }
        }
    }
}
