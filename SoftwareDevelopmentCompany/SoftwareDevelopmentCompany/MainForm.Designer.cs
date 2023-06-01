namespace SoftwareDevelopmentCompany
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutTheProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripMainForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DocumentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMainForm = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonAboutTheProgram = new System.Windows.Forms.ToolStripButton();
            this.StaffToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ClientToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ProjectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MenuStripMainForm.SuspendLayout();
            this.ContextMenuStripMainForm.SuspendLayout();
            this.ToolStripMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripMainForm
            // 
            this.MenuStripMainForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ReferencesToolStripMenuItem,
            this.DocumentsToolStripMenuItem});
            this.MenuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMainForm.Name = "MenuStripMainForm";
            this.MenuStripMainForm.Size = new System.Drawing.Size(800, 30);
            this.MenuStripMainForm.TabIndex = 0;
            this.MenuStripMainForm.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem,
            this.AboutTheProgramToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = global::SoftwareDevelopmentCompany.Properties.Resources.IconExit;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutTheProgramToolStripMenuItem
            // 
            this.AboutTheProgramToolStripMenuItem.Image = global::SoftwareDevelopmentCompany.Properties.Resources.IconInfo;
            this.AboutTheProgramToolStripMenuItem.Name = "AboutTheProgramToolStripMenuItem";
            this.AboutTheProgramToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.AboutTheProgramToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.AboutTheProgramToolStripMenuItem.Text = "About the program...";
            this.AboutTheProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutTheProgramToolStripMenuItem_Click);
            // 
            // ReferencesToolStripMenuItem
            // 
            this.ReferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaffToolStripMenuItem,
            this.ClientToolStripMenuItem});
            this.ReferencesToolStripMenuItem.Name = "ReferencesToolStripMenuItem";
            this.ReferencesToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.ReferencesToolStripMenuItem.Text = "References";
            // 
            // StaffToolStripMenuItem
            // 
            this.StaffToolStripMenuItem.Image = global::SoftwareDevelopmentCompany.Properties.Resources.IconStaff;
            this.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem";
            this.StaffToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.StaffToolStripMenuItem.Text = "Staff";
            this.StaffToolStripMenuItem.Click += new System.EventHandler(this.StaffToolStripMenuItem_Click);
            // 
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.Image = global::SoftwareDevelopmentCompany.Properties.Resources.IconClient;
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.ClientToolStripMenuItem.Text = "Client";
            this.ClientToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // DocumentsToolStripMenuItem
            // 
            this.DocumentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProjectToolStripMenuItem});
            this.DocumentsToolStripMenuItem.Name = "DocumentsToolStripMenuItem";
            this.DocumentsToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.DocumentsToolStripMenuItem.Text = "Documents";
            // 
            // ProjectToolStripMenuItem
            // 
            this.ProjectToolStripMenuItem.Image = global::SoftwareDevelopmentCompany.Properties.Resources.IconProject;
            this.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem";
            this.ProjectToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.ProjectToolStripMenuItem.Text = "Project";
            this.ProjectToolStripMenuItem.Click += new System.EventHandler(this.ProjectToolStripMenuItem_Click);
            // 
            // ContextMenuStripMainForm
            // 
            this.ContextMenuStripMainForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem1,
            this.ReferencesToolStripMenuItem1,
            this.DocumentsToolStripMenuItem1});
            this.ContextMenuStripMainForm.Name = "ContextMenuStripMainForm";
            this.ContextMenuStripMainForm.Size = new System.Drawing.Size(154, 76);
            // 
            // FileToolStripMenuItem1
            // 
            this.FileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem1,
            this.AboutToolStripMenuItem});
            this.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1";
            this.FileToolStripMenuItem1.Size = new System.Drawing.Size(153, 24);
            this.FileToolStripMenuItem1.Text = "File";
            // 
            // ExitToolStripMenuItem1
            // 
            this.ExitToolStripMenuItem1.Image = global::SoftwareDevelopmentCompany.Properties.Resources.IconExit;
            this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
            this.ExitToolStripMenuItem1.Size = new System.Drawing.Size(229, 26);
            this.ExitToolStripMenuItem1.Text = "Exit";
            this.ExitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Image = global::SoftwareDevelopmentCompany.Properties.Resources.IconInfo;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.AboutToolStripMenuItem.Text = "About the program...";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutTheProgramToolStripMenuItem_Click);
            // 
            // ReferencesToolStripMenuItem1
            // 
            this.ReferencesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaffToolStripMenuItem1,
            this.ClientToolStripMenuItem1});
            this.ReferencesToolStripMenuItem1.Name = "ReferencesToolStripMenuItem1";
            this.ReferencesToolStripMenuItem1.Size = new System.Drawing.Size(153, 24);
            this.ReferencesToolStripMenuItem1.Text = "References";
            // 
            // StaffToolStripMenuItem1
            // 
            this.StaffToolStripMenuItem1.Image = global::SoftwareDevelopmentCompany.Properties.Resources.IconStaff;
            this.StaffToolStripMenuItem1.Name = "StaffToolStripMenuItem1";
            this.StaffToolStripMenuItem1.Size = new System.Drawing.Size(130, 26);
            this.StaffToolStripMenuItem1.Text = "Staff";
            this.StaffToolStripMenuItem1.Click += new System.EventHandler(this.StaffToolStripMenuItem_Click);
            // 
            // ClientToolStripMenuItem1
            // 
            this.ClientToolStripMenuItem1.Image = global::SoftwareDevelopmentCompany.Properties.Resources.IconClient;
            this.ClientToolStripMenuItem1.Name = "ClientToolStripMenuItem1";
            this.ClientToolStripMenuItem1.Size = new System.Drawing.Size(130, 26);
            this.ClientToolStripMenuItem1.Text = "Client";
            this.ClientToolStripMenuItem1.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // DocumentsToolStripMenuItem1
            // 
            this.DocumentsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProjectToolStripMenuItem1});
            this.DocumentsToolStripMenuItem1.Name = "DocumentsToolStripMenuItem1";
            this.DocumentsToolStripMenuItem1.Size = new System.Drawing.Size(153, 24);
            this.DocumentsToolStripMenuItem1.Text = "Documents";
            // 
            // ProjectToolStripMenuItem1
            // 
            this.ProjectToolStripMenuItem1.Image = global::SoftwareDevelopmentCompany.Properties.Resources.IconProject;
            this.ProjectToolStripMenuItem1.Name = "ProjectToolStripMenuItem1";
            this.ProjectToolStripMenuItem1.Size = new System.Drawing.Size(138, 26);
            this.ProjectToolStripMenuItem1.Text = "Project";
            this.ProjectToolStripMenuItem1.Click += new System.EventHandler(this.ProjectToolStripMenuItem_Click);
            // 
            // ToolStripMainForm
            // 
            this.ToolStripMainForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonExit,
            this.ToolStripButtonAboutTheProgram,
            this.StaffToolStripButton,
            this.ClientToolStripButton,
            this.ProjectToolStripButton});
            this.ToolStripMainForm.Location = new System.Drawing.Point(0, 30);
            this.ToolStripMainForm.Name = "ToolStripMainForm";
            this.ToolStripMainForm.Size = new System.Drawing.Size(800, 31);
            this.ToolStripMainForm.TabIndex = 2;
            this.ToolStripMainForm.Text = "toolStrip1";
            // 
            // ToolStripButtonExit
            // 
            this.ToolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonExit.Image = global::SoftwareDevelopmentCompany.Properties.Resources.IconExit;
            this.ToolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonExit.Name = "ToolStripButtonExit";
            this.ToolStripButtonExit.Size = new System.Drawing.Size(29, 28);
            this.ToolStripButtonExit.Text = "ToolStripButtonExit";
            this.ToolStripButtonExit.ToolTipText = "Close the program";
            this.ToolStripButtonExit.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ToolStripButtonAboutTheProgram
            // 
            this.ToolStripButtonAboutTheProgram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonAboutTheProgram.Image = global::SoftwareDevelopmentCompany.Properties.Resources.IconInfo;
            this.ToolStripButtonAboutTheProgram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonAboutTheProgram.Name = "ToolStripButtonAboutTheProgram";
            this.ToolStripButtonAboutTheProgram.Size = new System.Drawing.Size(29, 28);
            this.ToolStripButtonAboutTheProgram.Text = "ToolStripButtonAboutTheProgram";
            this.ToolStripButtonAboutTheProgram.ToolTipText = "About the program";
            this.ToolStripButtonAboutTheProgram.Click += new System.EventHandler(this.AboutTheProgramToolStripMenuItem_Click);
            // 
            // StaffToolStripButton
            // 
            this.StaffToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StaffToolStripButton.Image = global::SoftwareDevelopmentCompany.Properties.Resources.IconStaff;
            this.StaffToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StaffToolStripButton.Name = "StaffToolStripButton";
            this.StaffToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.StaffToolStripButton.Text = "List of staff";
            this.StaffToolStripButton.Click += new System.EventHandler(this.StaffToolStripMenuItem_Click);
            // 
            // ClientToolStripButton
            // 
            this.ClientToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClientToolStripButton.Image = global::SoftwareDevelopmentCompany.Properties.Resources.IconClient;
            this.ClientToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClientToolStripButton.Name = "ClientToolStripButton";
            this.ClientToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.ClientToolStripButton.Text = "List of client";
            this.ClientToolStripButton.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // ProjectToolStripButton
            // 
            this.ProjectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ProjectToolStripButton.Image = global::SoftwareDevelopmentCompany.Properties.Resources.IconProject;
            this.ProjectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProjectToolStripButton.Name = "ProjectToolStripButton";
            this.ProjectToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.ProjectToolStripButton.Text = "List of project";
            this.ProjectToolStripButton.Click += new System.EventHandler(this.ProjectToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.ContextMenuStripMainForm;
            this.Controls.Add(this.ToolStripMainForm);
            this.Controls.Add(this.MenuStripMainForm);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::SoftwareDevelopmentCompany.Properties.Settings.Default, "FormPosss", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::SoftwareDevelopmentCompany.Properties.Settings.Default.FormPosss;
            this.MainMenuStrip = this.MenuStripMainForm;
            this.Name = "MainForm";
            this.Text = "Program for software development company";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.MenuStripMainForm.ResumeLayout(false);
            this.MenuStripMainForm.PerformLayout();
            this.ContextMenuStripMainForm.ResumeLayout(false);
            this.ToolStripMainForm.ResumeLayout(false);
            this.ToolStripMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutTheProgramToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStripMainForm;
        private System.Windows.Forms.ToolStripButton ToolStripButtonExit;
        private System.Windows.Forms.ToolStripButton ToolStripButtonAboutTheProgram;
        private System.Windows.Forms.ToolStripMenuItem ReferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReferencesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem StaffToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton StaffToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton ClientToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem DocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DocumentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ProjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton ProjectToolStripButton;
    }
}

