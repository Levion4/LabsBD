namespace SoftwareDevelopmentCompany
{
    partial class StaffListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label IdStaffLabel;
            System.Windows.Forms.Label FullNameLabel;
            System.Windows.Forms.Label PostLabel;
            System.Windows.Forms.Label WorkExperienceLabel;
            System.Windows.Forms.Label PaulLabel;
            System.Windows.Forms.Label PhotoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffListForm));
            this.softwareDevelopmentCompanyDataSet = new SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSetTableAdapters.StaffTableAdapter();
            this.tableAdapterManager = new SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSetTableAdapters.TableAdapterManager();
            this.staffBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.staffBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.IdStaffTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.PostTextBox = new System.Windows.Forms.TextBox();
            this.WorkExperienceTextBox = new System.Windows.Forms.TextBox();
            this.PaulComboBox = new System.Windows.Forms.ComboBox();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.ButtonOpenPhoto = new System.Windows.Forms.Button();
            this.OpenFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            IdStaffLabel = new System.Windows.Forms.Label();
            FullNameLabel = new System.Windows.Forms.Label();
            PostLabel = new System.Windows.Forms.Label();
            WorkExperienceLabel = new System.Windows.Forms.Label();
            PaulLabel = new System.Windows.Forms.Label();
            PhotoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDevelopmentCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingNavigator)).BeginInit();
            this.staffBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IdStaffLabel
            // 
            IdStaffLabel.AutoSize = true;
            IdStaffLabel.Location = new System.Drawing.Point(12, 35);
            IdStaffLabel.Name = "IdStaffLabel";
            IdStaffLabel.Size = new System.Drawing.Size(50, 16);
            IdStaffLabel.TabIndex = 1;
            IdStaffLabel.Text = "Id Staff:";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new System.Drawing.Point(12, 63);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new System.Drawing.Size(71, 16);
            FullNameLabel.TabIndex = 3;
            FullNameLabel.Text = "Full Name:";
            // 
            // PostLabel
            // 
            PostLabel.AutoSize = true;
            PostLabel.Location = new System.Drawing.Point(12, 91);
            PostLabel.Name = "PostLabel";
            PostLabel.Size = new System.Drawing.Size(37, 16);
            PostLabel.TabIndex = 5;
            PostLabel.Text = "Post:";
            // 
            // WorkExperienceLabel
            // 
            WorkExperienceLabel.AutoSize = true;
            WorkExperienceLabel.Location = new System.Drawing.Point(12, 119);
            WorkExperienceLabel.Name = "WorkExperienceLabel";
            WorkExperienceLabel.Size = new System.Drawing.Size(113, 16);
            WorkExperienceLabel.TabIndex = 7;
            WorkExperienceLabel.Text = "Work Experience:";
            // 
            // PaulLabel
            // 
            PaulLabel.AutoSize = true;
            PaulLabel.Location = new System.Drawing.Point(12, 147);
            PaulLabel.Name = "PaulLabel";
            PaulLabel.Size = new System.Drawing.Size(37, 16);
            PaulLabel.TabIndex = 9;
            PaulLabel.Text = "Paul:";
            // 
            // PhotoLabel
            // 
            PhotoLabel.AutoSize = true;
            PhotoLabel.Location = new System.Drawing.Point(346, 31);
            PhotoLabel.Name = "PhotoLabel";
            PhotoLabel.Size = new System.Drawing.Size(45, 16);
            PhotoLabel.TabIndex = 11;
            PhotoLabel.Text = "Photo:";
            // 
            // softwareDevelopmentCompanyDataSet
            // 
            this.softwareDevelopmentCompanyDataSet.DataSetName = "SoftwareDevelopmentCompanyDataSet";
            this.softwareDevelopmentCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.softwareDevelopmentCompanyDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.ProjectTableAdapter = null;
            this.tableAdapterManager.RoleStaffTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.TechnicalDocumentationTableAdapter = null;
            this.tableAdapterManager.TestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // staffBindingNavigator
            // 
            this.staffBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.staffBindingNavigator.BindingSource = this.staffBindingSource;
            this.staffBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.staffBindingNavigator.CountItemFormat = "из {0}";
            this.staffBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.staffBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staffBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.staffBindingNavigatorSaveItem});
            this.staffBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.staffBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.staffBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.staffBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.staffBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.staffBindingNavigator.Name = "staffBindingNavigator";
            this.staffBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.staffBindingNavigator.Size = new System.Drawing.Size(569, 31);
            this.staffBindingNavigator.TabIndex = 0;
            this.staffBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(47, 28);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Remove";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move to the beginning";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move back";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move Forward";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move to the end";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // staffBindingNavigatorSaveItem
            // 
            this.staffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.staffBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("staffBindingNavigatorSaveItem.Image")));
            this.staffBindingNavigatorSaveItem.Name = "staffBindingNavigatorSaveItem";
            this.staffBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.staffBindingNavigatorSaveItem.Text = "Save data";
            this.staffBindingNavigatorSaveItem.Click += new System.EventHandler(this.staffBindingNavigatorSaveItem_Click_2);
            // 
            // IdStaffTextBox
            // 
            this.IdStaffTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "IdStaff", true));
            this.IdStaffTextBox.Location = new System.Drawing.Point(131, 32);
            this.IdStaffTextBox.Name = "IdStaffTextBox";
            this.IdStaffTextBox.Size = new System.Drawing.Size(200, 22);
            this.IdStaffTextBox.TabIndex = 2;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "FullName", true));
            this.FullNameTextBox.Location = new System.Drawing.Point(131, 60);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.FullNameTextBox.TabIndex = 4;
            // 
            // PostTextBox
            // 
            this.PostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Post", true));
            this.PostTextBox.Location = new System.Drawing.Point(131, 88);
            this.PostTextBox.Name = "PostTextBox";
            this.PostTextBox.Size = new System.Drawing.Size(200, 22);
            this.PostTextBox.TabIndex = 6;
            // 
            // WorkExperienceTextBox
            // 
            this.WorkExperienceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "WorkExperience", true));
            this.WorkExperienceTextBox.Location = new System.Drawing.Point(131, 116);
            this.WorkExperienceTextBox.Name = "WorkExperienceTextBox";
            this.WorkExperienceTextBox.Size = new System.Drawing.Size(200, 22);
            this.WorkExperienceTextBox.TabIndex = 8;
            // 
            // PaulComboBox
            // 
            this.PaulComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Paul", true));
            this.PaulComboBox.FormattingEnabled = true;
            this.PaulComboBox.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.PaulComboBox.Location = new System.Drawing.Point(131, 144);
            this.PaulComboBox.Name = "PaulComboBox";
            this.PaulComboBox.Size = new System.Drawing.Size(121, 24);
            this.PaulComboBox.TabIndex = 10;
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.staffBindingSource, "Photo", true));
            this.PhotoPictureBox.Location = new System.Drawing.Point(349, 54);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(200, 149);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 12;
            this.PhotoPictureBox.TabStop = false;
            // 
            // ButtonOpenPhoto
            // 
            this.ButtonOpenPhoto.Location = new System.Drawing.Point(397, 28);
            this.ButtonOpenPhoto.Name = "ButtonOpenPhoto";
            this.ButtonOpenPhoto.Size = new System.Drawing.Size(152, 23);
            this.ButtonOpenPhoto.TabIndex = 13;
            this.ButtonOpenPhoto.Text = "Open photo";
            this.ButtonOpenPhoto.UseVisualStyleBackColor = true;
            this.ButtonOpenPhoto.Click += new System.EventHandler(this.ButtonOpenPhoto_Click);
            // 
            // OpenFileDialogPhoto
            // 
            this.OpenFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // StaffListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 230);
            this.Controls.Add(this.ButtonOpenPhoto);
            this.Controls.Add(IdStaffLabel);
            this.Controls.Add(this.IdStaffTextBox);
            this.Controls.Add(FullNameLabel);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(PostLabel);
            this.Controls.Add(this.PostTextBox);
            this.Controls.Add(WorkExperienceLabel);
            this.Controls.Add(this.WorkExperienceTextBox);
            this.Controls.Add(PaulLabel);
            this.Controls.Add(this.PaulComboBox);
            this.Controls.Add(PhotoLabel);
            this.Controls.Add(this.PhotoPictureBox);
            this.Controls.Add(this.staffBindingNavigator);
            this.Name = "StaffListForm";
            this.Text = "List of staff";
            this.Load += new System.EventHandler(this.DishesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softwareDevelopmentCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingNavigator)).EndInit();
            this.staffBindingNavigator.ResumeLayout(false);
            this.staffBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SoftwareDevelopmentCompanyDataSet softwareDevelopmentCompanyDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private SoftwareDevelopmentCompanyDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private SoftwareDevelopmentCompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator staffBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton staffBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox IdStaffTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox PostTextBox;
        private System.Windows.Forms.TextBox WorkExperienceTextBox;
        private System.Windows.Forms.ComboBox PaulComboBox;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Button ButtonOpenPhoto;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogPhoto;
    }
}