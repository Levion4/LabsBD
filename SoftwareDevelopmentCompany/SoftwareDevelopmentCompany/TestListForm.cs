﻿using System;
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
    public partial class TestListForm : Form
    {
        private static TestListForm f;

        public static TestListForm fw
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new TestListForm();
                }

                return f;
            }
        }

        public TestListForm()
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

        private void projectBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.projectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softwareDevelopmentCompanyDataSet);

        }

        private void TestsListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareDevelopmentCompanyDataSet.Test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.softwareDevelopmentCompanyDataSet.Test);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareDevelopmentCompanyDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.softwareDevelopmentCompanyDataSet.Project);

        }

        private void TestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softwareDevelopmentCompanyDataSet);
        }
    }
}
