using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareDevelopmentCompany.Properties;

namespace SoftwareDevelopmentCompany
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Do you want to close the program?",
                "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                != DialogResult.Yes;
        }

        private void AboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)TUSUR, CSUP, Lunev Lev Alexandrovich," +
                " 571-1, 2023", "About the program", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void StaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffListForm fd = new StaffListForm();
            fd.Show();
        }
    }
}
