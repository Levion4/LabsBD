﻿namespace SoftwareDevelopmentCompany
{
    partial class TestListForm
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
            System.Windows.Forms.Label idProjectLabel;
            System.Windows.Forms.Label cashCostsLabel;
            System.Windows.Forms.Label budgetLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label actOfImplementationLabel;
            System.Windows.Forms.Label idClientLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.softwareDevelopmentCompanyDataSet = new SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSet();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSetTableAdapters.ProjectTableAdapter();
            this.tableAdapterManager = new SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSetTableAdapters.TableAdapterManager();
            this.projectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.projectBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idProjectTextBox = new System.Windows.Forms.TextBox();
            this.cashCostsTextBox = new System.Windows.Forms.TextBox();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.actOfImplementationCheckBox = new System.Windows.Forms.CheckBox();
            this.idClientTextBox = new System.Windows.Forms.TextBox();
            this.TestsGroupBox = new System.Windows.Forms.GroupBox();
            this.testBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TestBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.testDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testTableAdapter = new SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSetTableAdapters.TestTableAdapter();
            idProjectLabel = new System.Windows.Forms.Label();
            cashCostsLabel = new System.Windows.Forms.Label();
            budgetLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            actOfImplementationLabel = new System.Windows.Forms.Label();
            idClientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDevelopmentCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingNavigator)).BeginInit();
            this.projectBindingNavigator.SuspendLayout();
            this.TestsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingNavigator)).BeginInit();
            this.testBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idProjectLabel
            // 
            idProjectLabel.AutoSize = true;
            idProjectLabel.Location = new System.Drawing.Point(24, 44);
            idProjectLabel.Name = "idProjectLabel";
            idProjectLabel.Size = new System.Drawing.Size(66, 16);
            idProjectLabel.TabIndex = 1;
            idProjectLabel.Text = "Id Project:";
            // 
            // cashCostsLabel
            // 
            cashCostsLabel.AutoSize = true;
            cashCostsLabel.Location = new System.Drawing.Point(24, 72);
            cashCostsLabel.Name = "cashCostsLabel";
            cashCostsLabel.Size = new System.Drawing.Size(78, 16);
            cashCostsLabel.TabIndex = 3;
            cashCostsLabel.Text = "Cash Costs:";
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Location = new System.Drawing.Point(24, 100);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new System.Drawing.Size(53, 16);
            budgetLabel.TabIndex = 5;
            budgetLabel.Text = "Budget:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(24, 128);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(36, 16);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Title:";
            // 
            // actOfImplementationLabel
            // 
            actOfImplementationLabel.AutoSize = true;
            actOfImplementationLabel.Location = new System.Drawing.Point(24, 185);
            actOfImplementationLabel.Name = "actOfImplementationLabel";
            actOfImplementationLabel.Size = new System.Drawing.Size(139, 16);
            actOfImplementationLabel.TabIndex = 9;
            actOfImplementationLabel.Text = "Act Of Implementation:";
            // 
            // idClientLabel
            // 
            idClientLabel.AutoSize = true;
            idClientLabel.Location = new System.Drawing.Point(24, 156);
            idClientLabel.Name = "idClientLabel";
            idClientLabel.Size = new System.Drawing.Size(57, 16);
            idClientLabel.TabIndex = 11;
            idClientLabel.Text = "Id Client:";
            // 
            // softwareDevelopmentCompanyDataSet
            // 
            this.softwareDevelopmentCompanyDataSet.DataSetName = "SoftwareDevelopmentCompanyDataSet";
            this.softwareDevelopmentCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.softwareDevelopmentCompanyDataSet;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.ProjectTableAdapter = this.projectTableAdapter;
            this.tableAdapterManager.RoleStaffTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.TechnicalDocumentationTableAdapter = null;
            this.tableAdapterManager.TestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // projectBindingNavigator
            // 
            this.projectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.projectBindingNavigator.BindingSource = this.projectBindingSource;
            this.projectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.projectBindingNavigator.CountItemFormat = "из {0}";
            this.projectBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.projectBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.projectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.projectBindingNavigatorSaveItem});
            this.projectBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.projectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.projectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.projectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.projectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.projectBindingNavigator.Name = "projectBindingNavigator";
            this.projectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.projectBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.projectBindingNavigator.TabIndex = 0;
            this.projectBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(47, 24);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Remove";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move to the beginning";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move back";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move Forward";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move to the end";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // projectBindingNavigatorSaveItem
            // 
            this.projectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.projectBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("projectBindingNavigatorSaveItem.Image")));
            this.projectBindingNavigatorSaveItem.Name = "projectBindingNavigatorSaveItem";
            this.projectBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.projectBindingNavigatorSaveItem.Text = "Save data";
            this.projectBindingNavigatorSaveItem.Click += new System.EventHandler(this.projectBindingNavigatorSaveItem_Click_1);
            // 
            // idProjectTextBox
            // 
            this.idProjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "IdProject", true));
            this.idProjectTextBox.Location = new System.Drawing.Point(169, 41);
            this.idProjectTextBox.Name = "idProjectTextBox";
            this.idProjectTextBox.Size = new System.Drawing.Size(175, 22);
            this.idProjectTextBox.TabIndex = 2;
            // 
            // cashCostsTextBox
            // 
            this.cashCostsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "CashCosts", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.cashCostsTextBox.Location = new System.Drawing.Point(169, 69);
            this.cashCostsTextBox.Name = "cashCostsTextBox";
            this.cashCostsTextBox.Size = new System.Drawing.Size(175, 22);
            this.cashCostsTextBox.TabIndex = 4;
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "Budget", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.budgetTextBox.Location = new System.Drawing.Point(169, 97);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(175, 22);
            this.budgetTextBox.TabIndex = 6;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(169, 125);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(175, 22);
            this.titleTextBox.TabIndex = 8;
            // 
            // actOfImplementationCheckBox
            // 
            this.actOfImplementationCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.projectBindingSource, "ActOfImplementation", true));
            this.actOfImplementationCheckBox.Location = new System.Drawing.Point(180, 180);
            this.actOfImplementationCheckBox.Name = "actOfImplementationCheckBox";
            this.actOfImplementationCheckBox.Size = new System.Drawing.Size(104, 24);
            this.actOfImplementationCheckBox.TabIndex = 10;
            this.actOfImplementationCheckBox.UseVisualStyleBackColor = true;
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "IdClient", true));
            this.idClientTextBox.Location = new System.Drawing.Point(169, 153);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(175, 22);
            this.idClientTextBox.TabIndex = 12;
            // 
            // TestsGroupBox
            // 
            this.TestsGroupBox.Controls.Add(this.testBindingNavigator);
            this.TestsGroupBox.Controls.Add(this.testDataGridView);
            this.TestsGroupBox.Location = new System.Drawing.Point(12, 210);
            this.TestsGroupBox.Name = "TestsGroupBox";
            this.TestsGroupBox.Size = new System.Drawing.Size(776, 237);
            this.TestsGroupBox.TabIndex = 13;
            this.TestsGroupBox.TabStop = false;
            this.TestsGroupBox.Text = "Test";
            // 
            // testBindingNavigator
            // 
            this.testBindingNavigator.AddNewItem = this.toolStripButton1;
            this.testBindingNavigator.BindingSource = this.testBindingSource;
            this.testBindingNavigator.CountItem = this.toolStripLabel1;
            this.testBindingNavigator.CountItemFormat = "из {0}";
            this.testBindingNavigator.DeleteItem = this.toolStripButton2;
            this.testBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.testBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.TestBindingNavigatorSaveItem});
            this.testBindingNavigator.Location = new System.Drawing.Point(3, 18);
            this.testBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.testBindingNavigator.MoveLastItem = this.toolStripButton6;
            this.testBindingNavigator.MoveNextItem = this.toolStripButton5;
            this.testBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.testBindingNavigator.Name = "testBindingNavigator";
            this.testBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.testBindingNavigator.Size = new System.Drawing.Size(770, 27);
            this.testBindingNavigator.TabIndex = 1;
            this.testBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Add";
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "FK_Test_Project";
            this.testBindingSource.DataSource = this.projectBindingSource;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 24);
            this.toolStripLabel1.Text = "из {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "Remove";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "Move to the beginning";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "Move back";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 27);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "Move Forward";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "Move to the end";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // TestBindingNavigatorSaveItem
            // 
            this.TestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TestBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("TestBindingNavigatorSaveItem.Image")));
            this.TestBindingNavigatorSaveItem.Name = "TestBindingNavigatorSaveItem";
            this.TestBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.TestBindingNavigatorSaveItem.Text = "Save data";
            this.TestBindingNavigatorSaveItem.Click += new System.EventHandler(this.TestBindingNavigatorSaveItem_Click);
            // 
            // testDataGridView
            // 
            this.testDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.testDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.testDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.testDataGridView.DataSource = this.testBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.testDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.testDataGridView.Location = new System.Drawing.Point(6, 48);
            this.testDataGridView.Name = "testDataGridView";
            this.testDataGridView.RowHeadersWidth = 51;
            this.testDataGridView.RowTemplate.Height = 24;
            this.testDataGridView.Size = new System.Drawing.Size(764, 183);
            this.testDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdTest";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdTest";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Heading";
            this.dataGridViewTextBoxColumn2.HeaderText = "Heading";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prerequisites";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prerequisites";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VerificationSteps";
            this.dataGridViewTextBoxColumn4.HeaderText = "VerificationSteps";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ExpectedResult";
            this.dataGridViewTextBoxColumn5.HeaderText = "ExpectedResult";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdProject";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdProject";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
            // 
            // TestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.TestsGroupBox);
            this.Controls.Add(idProjectLabel);
            this.Controls.Add(this.idProjectTextBox);
            this.Controls.Add(cashCostsLabel);
            this.Controls.Add(this.cashCostsTextBox);
            this.Controls.Add(budgetLabel);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(actOfImplementationLabel);
            this.Controls.Add(this.actOfImplementationCheckBox);
            this.Controls.Add(idClientLabel);
            this.Controls.Add(this.idClientTextBox);
            this.Controls.Add(this.projectBindingNavigator);
            this.Name = "TestListForm";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.TestsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softwareDevelopmentCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingNavigator)).EndInit();
            this.projectBindingNavigator.ResumeLayout(false);
            this.projectBindingNavigator.PerformLayout();
            this.TestsGroupBox.ResumeLayout(false);
            this.TestsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingNavigator)).EndInit();
            this.testBindingNavigator.ResumeLayout(false);
            this.testBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SoftwareDevelopmentCompanyDataSet softwareDevelopmentCompanyDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private SoftwareDevelopmentCompanyDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private SoftwareDevelopmentCompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator projectBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton projectBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idProjectTextBox;
        private System.Windows.Forms.TextBox cashCostsTextBox;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.CheckBox actOfImplementationCheckBox;
        private System.Windows.Forms.TextBox idClientTextBox;
        private System.Windows.Forms.GroupBox TestsGroupBox;
        private System.Windows.Forms.BindingSource testBindingSource;
        private SoftwareDevelopmentCompanyDataSetTableAdapters.TestTableAdapter testTableAdapter;
        private System.Windows.Forms.DataGridView testDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingNavigator testBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TestBindingNavigatorSaveItem;
    }
}