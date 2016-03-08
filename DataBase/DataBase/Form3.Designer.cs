namespace DataBase
{
    partial class Form3
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
            System.Windows.Forms.Label idStudentLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label homeAddressLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label passportLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.studentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new DataBase.DataSet2();
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
            this.studentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idStudentTextBox = new System.Windows.Forms.TextBox();
            this.fullNameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.homeAddressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchStudToolStrip = new System.Windows.Forms.ToolStrip();
            this.idStudentToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idStudentToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fullNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fullNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.passportToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.passportToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchStudToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.studentsTableAdapter = new DataBase.DataSet2TableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new DataBase.DataSet2TableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idStudentLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            homeAddressLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).BeginInit();
            this.studentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.searchStudToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // idStudentLabel
            // 
            idStudentLabel.AutoSize = true;
            idStudentLabel.Location = new System.Drawing.Point(47, 31);
            idStudentLabel.Name = "idStudentLabel";
            idStudentLabel.Size = new System.Drawing.Size(67, 13);
            idStudentLabel.TabIndex = 1;
            idStudentLabel.Text = "Id студента:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(55, 68);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(63, 13);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "Повне ім\'я:";
            // 
            // homeAddressLabel
            // 
            homeAddressLabel.AutoSize = true;
            homeAddressLabel.Location = new System.Drawing.Point(10, 129);
            homeAddressLabel.Name = "homeAddressLabel";
            homeAddressLabel.Size = new System.Drawing.Size(104, 13);
            homeAddressLabel.TabIndex = 5;
            homeAddressLabel.Text = "Місце проживання:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(19, 155);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(95, 13);
            phoneNumberLabel.TabIndex = 7;
            phoneNumberLabel.Text = "Номер телефону:";
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Location = new System.Drawing.Point(63, 103);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(53, 13);
            passportLabel.TabIndex = 13;
            passportLabel.Text = "Паспорт:";
            // 
            // studentsBindingNavigator
            // 
            this.studentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentsBindingNavigator.BindingSource = this.studentsBindingSource;
            this.studentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.studentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentsBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripSeparator2});
            this.studentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentsBindingNavigator.Name = "studentsBindingNavigator";
            this.studentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentsBindingNavigator.Size = new System.Drawing.Size(368, 25);
            this.studentsBindingNavigator.TabIndex = 0;
            this.studentsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // studentsBindingNavigatorSaveItem
            // 
            this.studentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsBindingNavigatorSaveItem.Image")));
            this.studentsBindingNavigatorSaveItem.Name = "studentsBindingNavigatorSaveItem";
            this.studentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentsBindingNavigatorSaveItem.Text = "Save Data";
            this.studentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentsBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel1.Text = "&Оновити";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // idStudentTextBox
            // 
            this.idStudentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "IdStudent", true));
            this.idStudentTextBox.Location = new System.Drawing.Point(120, 28);
            this.idStudentTextBox.Name = "idStudentTextBox";
            this.idStudentTextBox.Size = new System.Drawing.Size(154, 20);
            this.idStudentTextBox.TabIndex = 2;
            // 
            // fullNameRichTextBox
            // 
            this.fullNameRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "FullName", true));
            this.fullNameRichTextBox.Location = new System.Drawing.Point(120, 54);
            this.fullNameRichTextBox.Name = "fullNameRichTextBox";
            this.fullNameRichTextBox.Size = new System.Drawing.Size(154, 40);
            this.fullNameRichTextBox.TabIndex = 4;
            this.fullNameRichTextBox.Text = "";
            // 
            // homeAddressTextBox
            // 
            this.homeAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "HomeAddress", true));
            this.homeAddressTextBox.Location = new System.Drawing.Point(120, 126);
            this.homeAddressTextBox.Name = "homeAddressTextBox";
            this.homeAddressTextBox.Size = new System.Drawing.Size(154, 20);
            this.homeAddressTextBox.TabIndex = 6;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(120, 152);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(154, 20);
            this.phoneNumberTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "На головну";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AllowUserToAddRows = false;
            this.studentsDataGridView.AllowUserToDeleteRows = false;
            this.studentsDataGridView.AutoGenerateColumns = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.studentsDataGridView.DataSource = this.studentsBindingSource;
            this.studentsDataGridView.Location = new System.Drawing.Point(280, 28);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.ReadOnly = true;
            this.studentsDataGridView.Size = new System.Drawing.Size(652, 173);
            this.studentsDataGridView.TabIndex = 12;
            // 
            // searchStudToolStrip
            // 
            this.searchStudToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchStudToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idStudentToolStripLabel,
            this.idStudentToolStripTextBox,
            this.fullNameToolStripLabel,
            this.fullNameToolStripTextBox,
            this.passportToolStripLabel,
            this.passportToolStripTextBox,
            this.searchStudToolStripButton});
            this.searchStudToolStrip.Location = new System.Drawing.Point(368, 0);
            this.searchStudToolStrip.Name = "searchStudToolStrip";
            this.searchStudToolStrip.Size = new System.Drawing.Size(564, 25);
            this.searchStudToolStrip.TabIndex = 13;
            this.searchStudToolStrip.Text = "searchStudToolStrip";
            // 
            // idStudentToolStripLabel
            // 
            this.idStudentToolStripLabel.Name = "idStudentToolStripLabel";
            this.idStudentToolStripLabel.Size = new System.Drawing.Size(70, 22);
            this.idStudentToolStripLabel.Text = "Id студента:";
            // 
            // idStudentToolStripTextBox
            // 
            this.idStudentToolStripTextBox.Name = "idStudentToolStripTextBox";
            this.idStudentToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fullNameToolStripLabel
            // 
            this.fullNameToolStripLabel.Name = "fullNameToolStripLabel";
            this.fullNameToolStripLabel.Size = new System.Drawing.Size(69, 22);
            this.fullNameToolStripLabel.Text = "Повне ім\'я:";
            // 
            // fullNameToolStripTextBox
            // 
            this.fullNameToolStripTextBox.Name = "fullNameToolStripTextBox";
            this.fullNameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // passportToolStripLabel
            // 
            this.passportToolStripLabel.Name = "passportToolStripLabel";
            this.passportToolStripLabel.Size = new System.Drawing.Size(57, 22);
            this.passportToolStripLabel.Text = "Паспорт:";
            // 
            // passportToolStripTextBox
            // 
            this.passportToolStripTextBox.Name = "passportToolStripTextBox";
            this.passportToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchStudToolStripButton
            // 
            this.searchStudToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchStudToolStripButton.Name = "searchStudToolStripButton";
            this.searchStudToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.searchStudToolStripButton.Text = "Пошук";
            this.searchStudToolStripButton.Click += new System.EventHandler(this.searchStudToolStripButton_Click);
            // 
            // passportTextBox
            // 
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Passport", true));
            this.passportTextBox.Location = new System.Drawing.Point(120, 100);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(154, 20);
            this.passportTextBox.TabIndex = 14;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataBase.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdStudent";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id студента:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Повне ім\'я";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Passport";
            this.dataGridViewTextBoxColumn3.HeaderText = "Паспорт";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HomeAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "Місце проживання";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер телефону";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 200);
            this.Controls.Add(passportLabel);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(this.searchStudToolStrip);
            this.Controls.Add(this.studentsDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(homeAddressLabel);
            this.Controls.Add(this.homeAddressTextBox);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameRichTextBox);
            this.Controls.Add(idStudentLabel);
            this.Controls.Add(this.idStudentTextBox);
            this.Controls.Add(this.studentsBindingNavigator);
            this.Name = "Form3";
            this.Text = "Студенти";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).EndInit();
            this.studentsBindingNavigator.ResumeLayout(false);
            this.studentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.searchStudToolStrip.ResumeLayout(false);
            this.searchStudToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private DataSet2TableAdapters.StudentsTableAdapter studentsTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idStudentTextBox;
        private System.Windows.Forms.RichTextBox fullNameRichTextBox;
        private System.Windows.Forms.TextBox homeAddressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip searchStudToolStrip;
        private System.Windows.Forms.ToolStripLabel idStudentToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idStudentToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel fullNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fullNameToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel passportToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox passportToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchStudToolStripButton;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}