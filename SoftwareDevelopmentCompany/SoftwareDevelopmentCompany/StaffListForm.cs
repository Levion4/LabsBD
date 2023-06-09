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
    public partial class StaffListForm : Form
    {
        private string _fileImage = "";

        private static StaffListForm f;

        int idCurrent = -1;

        public static StaffListForm fd
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new StaffListForm();
                }

                return f;
            }
        }

        public StaffListForm()
        {
            InitializeComponent();
        }

        public int ShowSelectForm(int idEmployee, out string role)
        {
            idCurrent = idEmployee;
            ShowDialog();
            role = ((DataRowView)staffBindingSource.Current)
                ["Post"].ToString();

            return
            (int)((DataRowView)staffBindingSource.Current)["IdStaff"];
        }


        public void ShowForm()
        {
            staffBindingSource.Position = 0;
            Show();
            Activate();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softwareDevelopmentCompanyDataSet);

        }

        private void staffBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softwareDevelopmentCompanyDataSet);

        }

        private void staffBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softwareDevelopmentCompanyDataSet);

        }

        private void DishesListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareDevelopmentCompanyDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.softwareDevelopmentCompanyDataSet.Staff);

        }

        private void ButtonOpenPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialogPhoto.Title = "Specify the file for the photo";

            if(OpenFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                _fileImage = OpenFileDialogPhoto.FileName;
                try
                {
                    PhotoPictureBox.Image =
                        new Bitmap(OpenFileDialogPhoto.FileName);
                }
                catch
                {
                    MessageBox.Show("The wrong file format is selected",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                _fileImage = "";
            }
        }

        private void StaffListForm_Shown(object sender, EventArgs e)
        {
            staffBindingSource.Position =
                staffBindingSource.Find("IdStaff", idCurrent);
        }
    }
}
