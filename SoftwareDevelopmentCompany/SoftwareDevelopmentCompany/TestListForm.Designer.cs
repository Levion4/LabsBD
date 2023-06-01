namespace SoftwareDevelopmentCompany
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
            System.Windows.Forms.Label idTestLabel;
            System.Windows.Forms.Label headingLabel;
            System.Windows.Forms.Label prerequisitesLabel;
            System.Windows.Forms.Label verificationStepsLabel;
            System.Windows.Forms.Label expectedResultLabel;
            System.Windows.Forms.Label idProjectLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestListForm));
            this.softwareDevelopmentCompanyDataSet = new SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSet();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTableAdapter = new SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSetTableAdapters.TestTableAdapter();
            this.tableAdapterManager = new SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSetTableAdapters.TableAdapterManager();
            this.testBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.testBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTestTextBox = new System.Windows.Forms.TextBox();
            this.headingTextBox = new System.Windows.Forms.TextBox();
            this.prerequisitesTextBox = new System.Windows.Forms.TextBox();
            this.verificationStepsTextBox = new System.Windows.Forms.TextBox();
            this.expectedResultTextBox = new System.Windows.Forms.TextBox();
            this.idProjectTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            idTestLabel = new System.Windows.Forms.Label();
            headingLabel = new System.Windows.Forms.Label();
            prerequisitesLabel = new System.Windows.Forms.Label();
            verificationStepsLabel = new System.Windows.Forms.Label();
            expectedResultLabel = new System.Windows.Forms.Label();
            idProjectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.softwareDevelopmentCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingNavigator)).BeginInit();
            this.testBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idTestLabel
            // 
            idTestLabel.AutoSize = true;
            idTestLabel.Location = new System.Drawing.Point(12, 46);
            idTestLabel.Name = "idTestLabel";
            idTestLabel.Size = new System.Drawing.Size(51, 16);
            idTestLabel.TabIndex = 1;
            idTestLabel.Text = "Id Test:";
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Location = new System.Drawing.Point(12, 74);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new System.Drawing.Size(62, 16);
            headingLabel.TabIndex = 3;
            headingLabel.Text = "Heading:";
            // 
            // prerequisitesLabel
            // 
            prerequisitesLabel.AutoSize = true;
            prerequisitesLabel.Location = new System.Drawing.Point(12, 102);
            prerequisitesLabel.Name = "prerequisitesLabel";
            prerequisitesLabel.Size = new System.Drawing.Size(89, 16);
            prerequisitesLabel.TabIndex = 5;
            prerequisitesLabel.Text = "Prerequisites:";
            // 
            // verificationStepsLabel
            // 
            verificationStepsLabel.AutoSize = true;
            verificationStepsLabel.Location = new System.Drawing.Point(12, 130);
            verificationStepsLabel.Name = "verificationStepsLabel";
            verificationStepsLabel.Size = new System.Drawing.Size(114, 16);
            verificationStepsLabel.TabIndex = 7;
            verificationStepsLabel.Text = "Verification Steps:";
            // 
            // expectedResultLabel
            // 
            expectedResultLabel.AutoSize = true;
            expectedResultLabel.Location = new System.Drawing.Point(12, 158);
            expectedResultLabel.Name = "expectedResultLabel";
            expectedResultLabel.Size = new System.Drawing.Size(108, 16);
            expectedResultLabel.TabIndex = 9;
            expectedResultLabel.Text = "Expected Result:";
            // 
            // idProjectLabel
            // 
            idProjectLabel.AutoSize = true;
            idProjectLabel.Location = new System.Drawing.Point(12, 186);
            idProjectLabel.Name = "idProjectLabel";
            idProjectLabel.Size = new System.Drawing.Size(66, 16);
            idProjectLabel.TabIndex = 11;
            idProjectLabel.Text = "Id Project:";
            // 
            // softwareDevelopmentCompanyDataSet
            // 
            this.softwareDevelopmentCompanyDataSet.DataSetName = "SoftwareDevelopmentCompanyDataSet";
            this.softwareDevelopmentCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "Test";
            this.testBindingSource.DataSource = this.softwareDevelopmentCompanyDataSet;
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.ProjectTableAdapter = null;
            this.tableAdapterManager.RoleStaffTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.TechnicalDocumentationTableAdapter = null;
            this.tableAdapterManager.TestTableAdapter = this.testTableAdapter;
            this.tableAdapterManager.UpdateOrder = SoftwareDevelopmentCompany.SoftwareDevelopmentCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testBindingNavigator
            // 
            this.testBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.testBindingNavigator.BindingSource = this.testBindingSource;
            this.testBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.testBindingNavigator.CountItemFormat = "из {0}";
            this.testBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.testBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.testBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.testBindingNavigatorSaveItem});
            this.testBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.testBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.testBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.testBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.testBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.testBindingNavigator.Name = "testBindingNavigator";
            this.testBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.testBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.testBindingNavigator.TabIndex = 0;
            this.testBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
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
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // testBindingNavigatorSaveItem
            // 
            this.testBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.testBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("testBindingNavigatorSaveItem.Image")));
            this.testBindingNavigatorSaveItem.Name = "testBindingNavigatorSaveItem";
            this.testBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.testBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.testBindingNavigatorSaveItem.Click += new System.EventHandler(this.testBindingNavigatorSaveItem_Click);
            // 
            // idTestTextBox
            // 
            this.idTestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testBindingSource, "IdTest", true));
            this.idTestTextBox.Location = new System.Drawing.Point(132, 43);
            this.idTestTextBox.Name = "idTestTextBox";
            this.idTestTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTestTextBox.TabIndex = 2;
            // 
            // headingTextBox
            // 
            this.headingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testBindingSource, "Heading", true));
            this.headingTextBox.Location = new System.Drawing.Point(132, 71);
            this.headingTextBox.Name = "headingTextBox";
            this.headingTextBox.Size = new System.Drawing.Size(100, 22);
            this.headingTextBox.TabIndex = 4;
            // 
            // prerequisitesTextBox
            // 
            this.prerequisitesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testBindingSource, "Prerequisites", true));
            this.prerequisitesTextBox.Location = new System.Drawing.Point(132, 99);
            this.prerequisitesTextBox.Name = "prerequisitesTextBox";
            this.prerequisitesTextBox.Size = new System.Drawing.Size(100, 22);
            this.prerequisitesTextBox.TabIndex = 6;
            // 
            // verificationStepsTextBox
            // 
            this.verificationStepsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testBindingSource, "VerificationSteps", true));
            this.verificationStepsTextBox.Location = new System.Drawing.Point(132, 127);
            this.verificationStepsTextBox.Name = "verificationStepsTextBox";
            this.verificationStepsTextBox.Size = new System.Drawing.Size(100, 22);
            this.verificationStepsTextBox.TabIndex = 8;
            // 
            // expectedResultTextBox
            // 
            this.expectedResultTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testBindingSource, "ExpectedResult", true));
            this.expectedResultTextBox.Location = new System.Drawing.Point(132, 155);
            this.expectedResultTextBox.Name = "expectedResultTextBox";
            this.expectedResultTextBox.Size = new System.Drawing.Size(100, 22);
            this.expectedResultTextBox.TabIndex = 10;
            // 
            // idProjectTextBox
            // 
            this.idProjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testBindingSource, "IdProject", true));
            this.idProjectTextBox.Location = new System.Drawing.Point(132, 183);
            this.idProjectTextBox.Name = "idProjectTextBox";
            this.idProjectTextBox.Size = new System.Drawing.Size(100, 22);
            this.idProjectTextBox.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 227);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(idTestLabel);
            this.Controls.Add(this.idTestTextBox);
            this.Controls.Add(headingLabel);
            this.Controls.Add(this.headingTextBox);
            this.Controls.Add(prerequisitesLabel);
            this.Controls.Add(this.prerequisitesTextBox);
            this.Controls.Add(verificationStepsLabel);
            this.Controls.Add(this.verificationStepsTextBox);
            this.Controls.Add(expectedResultLabel);
            this.Controls.Add(this.expectedResultTextBox);
            this.Controls.Add(idProjectLabel);
            this.Controls.Add(this.idProjectTextBox);
            this.Controls.Add(this.testBindingNavigator);
            this.Name = "TestListForm";
            this.Text = "Tests";
            this.Load += new System.EventHandler(this.TestListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softwareDevelopmentCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingNavigator)).EndInit();
            this.testBindingNavigator.ResumeLayout(false);
            this.testBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SoftwareDevelopmentCompanyDataSet softwareDevelopmentCompanyDataSet;
        private System.Windows.Forms.BindingSource testBindingSource;
        private SoftwareDevelopmentCompanyDataSetTableAdapters.TestTableAdapter testTableAdapter;
        private SoftwareDevelopmentCompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator testBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton testBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTestTextBox;
        private System.Windows.Forms.TextBox headingTextBox;
        private System.Windows.Forms.TextBox prerequisitesTextBox;
        private System.Windows.Forms.TextBox verificationStepsTextBox;
        private System.Windows.Forms.TextBox expectedResultTextBox;
        private System.Windows.Forms.TextBox idProjectTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}