namespace SoftwareDevelopmentCompany
{
    partial class TechnicalDocumentationListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicalDocumentationListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.softwareDevelopmentCompanyDataSet = new SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSet();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableAdapter = new SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSetTableAdapters.ProjectTableAdapter();
            this.tableAdapterManager = new SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSetTableAdapters.TableAdapterManager();
            this.technicalDocumentationTableAdapter = new SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSetTableAdapters.TechnicalDocumentationTableAdapter();
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
            this.TDGroupBox = new System.Windows.Forms.GroupBox();
            this.TDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.technicalDocumentationBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.TDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.technicalDocumentationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.TDGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TDBindingNavigator)).BeginInit();
            this.TDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.technicalDocumentationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicalDocumentationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idProjectLabel
            // 
            idProjectLabel.AutoSize = true;
            idProjectLabel.Location = new System.Drawing.Point(12, 39);
            idProjectLabel.Name = "idProjectLabel";
            idProjectLabel.Size = new System.Drawing.Size(66, 16);
            idProjectLabel.TabIndex = 1;
            idProjectLabel.Text = "Id Project:";
            // 
            // cashCostsLabel
            // 
            cashCostsLabel.AutoSize = true;
            cashCostsLabel.Location = new System.Drawing.Point(12, 67);
            cashCostsLabel.Name = "cashCostsLabel";
            cashCostsLabel.Size = new System.Drawing.Size(78, 16);
            cashCostsLabel.TabIndex = 3;
            cashCostsLabel.Text = "Cash Costs:";
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Location = new System.Drawing.Point(12, 95);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new System.Drawing.Size(53, 16);
            budgetLabel.TabIndex = 5;
            budgetLabel.Text = "Budget:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(12, 123);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(36, 16);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Title:";
            // 
            // actOfImplementationLabel
            // 
            actOfImplementationLabel.AutoSize = true;
            actOfImplementationLabel.Location = new System.Drawing.Point(12, 185);
            actOfImplementationLabel.Name = "actOfImplementationLabel";
            actOfImplementationLabel.Size = new System.Drawing.Size(139, 16);
            actOfImplementationLabel.TabIndex = 9;
            actOfImplementationLabel.Text = "Act Of Implementation:";
            // 
            // idClientLabel
            // 
            idClientLabel.AutoSize = true;
            idClientLabel.Location = new System.Drawing.Point(12, 154);
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
            this.tableAdapterManager.TechnicalDocumentationTableAdapter = this.technicalDocumentationTableAdapter;
            this.tableAdapterManager.TestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // technicalDocumentationTableAdapter
            // 
            this.technicalDocumentationTableAdapter.ClearBeforeFill = true;
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
            this.projectBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.projectBindingNavigator.TabIndex = 0;
            this.projectBindingNavigator.Text = "bindingNavigator1";
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
            // projectBindingNavigatorSaveItem
            // 
            this.projectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.projectBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("projectBindingNavigatorSaveItem.Image")));
            this.projectBindingNavigatorSaveItem.Name = "projectBindingNavigatorSaveItem";
            this.projectBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.projectBindingNavigatorSaveItem.Text = "Save data";
            this.projectBindingNavigatorSaveItem.Click += new System.EventHandler(this.projectBindingNavigatorSaveItem_Click);
            // 
            // idProjectTextBox
            // 
            this.idProjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "IdProject", true));
            this.idProjectTextBox.Location = new System.Drawing.Point(157, 36);
            this.idProjectTextBox.Name = "idProjectTextBox";
            this.idProjectTextBox.Size = new System.Drawing.Size(175, 22);
            this.idProjectTextBox.TabIndex = 2;
            // 
            // cashCostsTextBox
            // 
            this.cashCostsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "CashCosts", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.cashCostsTextBox.Location = new System.Drawing.Point(157, 64);
            this.cashCostsTextBox.Name = "cashCostsTextBox";
            this.cashCostsTextBox.Size = new System.Drawing.Size(175, 22);
            this.cashCostsTextBox.TabIndex = 4;
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "Budget", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.budgetTextBox.Location = new System.Drawing.Point(157, 92);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(175, 22);
            this.budgetTextBox.TabIndex = 6;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(157, 120);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(175, 22);
            this.titleTextBox.TabIndex = 8;
            // 
            // actOfImplementationCheckBox
            // 
            this.actOfImplementationCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.projectBindingSource, "ActOfImplementation", true));
            this.actOfImplementationCheckBox.Location = new System.Drawing.Point(171, 182);
            this.actOfImplementationCheckBox.Name = "actOfImplementationCheckBox";
            this.actOfImplementationCheckBox.Size = new System.Drawing.Size(104, 24);
            this.actOfImplementationCheckBox.TabIndex = 10;
            this.actOfImplementationCheckBox.UseVisualStyleBackColor = true;
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "IdClient", true));
            this.idClientTextBox.Location = new System.Drawing.Point(157, 148);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(175, 22);
            this.idClientTextBox.TabIndex = 12;
            // 
            // TDGroupBox
            // 
            this.TDGroupBox.Controls.Add(this.TDBindingNavigator);
            this.TDGroupBox.Controls.Add(this.technicalDocumentationDataGridView);
            this.TDGroupBox.Location = new System.Drawing.Point(15, 212);
            this.TDGroupBox.Name = "TDGroupBox";
            this.TDGroupBox.Size = new System.Drawing.Size(773, 256);
            this.TDGroupBox.TabIndex = 13;
            this.TDGroupBox.TabStop = false;
            this.TDGroupBox.Text = "Technical documentation";
            // 
            // TDBindingNavigator
            // 
            this.TDBindingNavigator.AddNewItem = this.toolStripButton1;
            this.TDBindingNavigator.BindingSource = this.technicalDocumentationBindingSource;
            this.TDBindingNavigator.CountItem = this.toolStripLabel1;
            this.TDBindingNavigator.CountItemFormat = "из {0}";
            this.TDBindingNavigator.DeleteItem = this.toolStripButton2;
            this.TDBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.TDBindingNavigatorSaveItem});
            this.TDBindingNavigator.Location = new System.Drawing.Point(3, 18);
            this.TDBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.TDBindingNavigator.MoveLastItem = this.toolStripButton6;
            this.TDBindingNavigator.MoveNextItem = this.toolStripButton5;
            this.TDBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.TDBindingNavigator.Name = "TDBindingNavigator";
            this.TDBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.TDBindingNavigator.Size = new System.Drawing.Size(767, 27);
            this.TDBindingNavigator.TabIndex = 1;
            this.TDBindingNavigator.Text = "bindingNavigator1";
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
            // technicalDocumentationBindingSource
            // 
            this.technicalDocumentationBindingSource.DataMember = "FK_TechnicalDocumentation_Project";
            this.technicalDocumentationBindingSource.DataSource = this.projectBindingSource;
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
            // TDBindingNavigatorSaveItem
            // 
            this.TDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("TDBindingNavigatorSaveItem.Image")));
            this.TDBindingNavigatorSaveItem.Name = "TDBindingNavigatorSaveItem";
            this.TDBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.TDBindingNavigatorSaveItem.Text = "Save data";
            this.TDBindingNavigatorSaveItem.Click += new System.EventHandler(this.TDBindingNavigatorSaveItem_Click);
            // 
            // technicalDocumentationDataGridView
            // 
            this.technicalDocumentationDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.technicalDocumentationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.technicalDocumentationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.technicalDocumentationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.technicalDocumentationDataGridView.DataSource = this.technicalDocumentationBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.technicalDocumentationDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.technicalDocumentationDataGridView.Location = new System.Drawing.Point(6, 48);
            this.technicalDocumentationDataGridView.Name = "technicalDocumentationDataGridView";
            this.technicalDocumentationDataGridView.RowHeadersWidth = 51;
            this.technicalDocumentationDataGridView.RowTemplate.Height = 24;
            this.technicalDocumentationDataGridView.Size = new System.Drawing.Size(761, 202);
            this.technicalDocumentationDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Designation";
            this.dataGridViewTextBoxColumn1.HeaderText = "Designation";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateOfCreation";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateOfCreation";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdProject";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdProject";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // TechnicalDocumentationListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.TDGroupBox);
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
            this.Name = "TechnicalDocumentationListForm";
            this.Text = "Technical documentation";
            this.Load += new System.EventHandler(this.TechnicalDocumentationListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softwareDevelopmentCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingNavigator)).EndInit();
            this.projectBindingNavigator.ResumeLayout(false);
            this.projectBindingNavigator.PerformLayout();
            this.TDGroupBox.ResumeLayout(false);
            this.TDGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TDBindingNavigator)).EndInit();
            this.TDBindingNavigator.ResumeLayout(false);
            this.TDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.technicalDocumentationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicalDocumentationDataGridView)).EndInit();
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
        private System.Windows.Forms.GroupBox TDGroupBox;
        private SoftwareDevelopmentCompanyDataSetTableAdapters.TechnicalDocumentationTableAdapter technicalDocumentationTableAdapter;
        private System.Windows.Forms.BindingSource technicalDocumentationBindingSource;
        private System.Windows.Forms.BindingNavigator TDBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton TDBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView technicalDocumentationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}