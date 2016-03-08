namespace DataBase
{
    partial class Form2
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
            System.Windows.Forms.Label idTeacherLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label identification_codeLabel;
            System.Windows.Forms.Label homeAddressLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label passportLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.teachersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DataBase.DataSet1();
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
            this.teachersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idTeacherTextBox = new System.Windows.Forms.TextBox();
            this.identification_codeTextBox = new System.Windows.Forms.TextBox();
            this.homeAddressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fullNameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.teachersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTeachToolStrip = new System.Windows.Forms.ToolStrip();
            this.idTeacherToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idTeacherToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fullNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fullNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.passportToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.passportToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchTeachToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.teachersTableAdapter = new DataBase.DataSet1TableAdapters.TeachersTableAdapter();
            this.tableAdapterManager = new DataBase.DataSet1TableAdapters.TableAdapterManager();
            idTeacherLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            identification_codeLabel = new System.Windows.Forms.Label();
            homeAddressLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingNavigator)).BeginInit();
            this.teachersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).BeginInit();
            this.searchTeachToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // idTeacherLabel
            // 
            idTeacherLabel.AutoSize = true;
            idTeacherLabel.Location = new System.Drawing.Point(45, 34);
            idTeacherLabel.Name = "idTeacherLabel";
            idTeacherLabel.Size = new System.Drawing.Size(75, 13);
            idTeacherLabel.TabIndex = 1;
            idTeacherLabel.Text = "Id викладача:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(56, 70);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(63, 13);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "Повне ім\'я:";
            // 
            // identification_codeLabel
            // 
            identification_codeLabel.AutoSize = true;
            identification_codeLabel.Location = new System.Drawing.Point(5, 132);
            identification_codeLabel.Name = "identification_codeLabel";
            identification_codeLabel.Size = new System.Drawing.Size(117, 13);
            identification_codeLabel.TabIndex = 5;
            identification_codeLabel.Text = "Ідентифікаційний код:";
            // 
            // homeAddressLabel
            // 
            homeAddressLabel.AutoSize = true;
            homeAddressLabel.Location = new System.Drawing.Point(16, 158);
            homeAddressLabel.Name = "homeAddressLabel";
            homeAddressLabel.Size = new System.Drawing.Size(104, 13);
            homeAddressLabel.TabIndex = 7;
            homeAddressLabel.Text = "Місце проживання:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(25, 184);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(95, 13);
            phoneNumberLabel.TabIndex = 9;
            phoneNumberLabel.Text = "Номер телефону:";
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Location = new System.Drawing.Point(68, 106);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(53, 13);
            passportLabel.TabIndex = 12;
            passportLabel.Text = "Паспорт:";
            // 
            // teachersBindingNavigator
            // 
            this.teachersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.teachersBindingNavigator.BindingSource = this.teachersBindingSource;
            this.teachersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teachersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.teachersBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.teachersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.teachersBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripSeparator2});
            this.teachersBindingNavigator.Location = new System.Drawing.Point(2, 0);
            this.teachersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teachersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teachersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teachersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teachersBindingNavigator.Name = "teachersBindingNavigator";
            this.teachersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teachersBindingNavigator.Size = new System.Drawing.Size(368, 25);
            this.teachersBindingNavigator.TabIndex = 0;
            this.teachersBindingNavigator.Text = "bindingNavigator1";
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
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // teachersBindingNavigatorSaveItem
            // 
            this.teachersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.teachersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("teachersBindingNavigatorSaveItem.Image")));
            this.teachersBindingNavigatorSaveItem.Name = "teachersBindingNavigatorSaveItem";
            this.teachersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.teachersBindingNavigatorSaveItem.Text = "Save Data";
            this.teachersBindingNavigatorSaveItem.Click += new System.EventHandler(this.teachersBindingNavigatorSaveItem_Click);
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
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // idTeacherTextBox
            // 
            this.idTeacherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "IdTeacher", true));
            this.idTeacherTextBox.Location = new System.Drawing.Point(126, 31);
            this.idTeacherTextBox.Name = "idTeacherTextBox";
            this.idTeacherTextBox.Size = new System.Drawing.Size(159, 20);
            this.idTeacherTextBox.TabIndex = 2;
            // 
            // identification_codeTextBox
            // 
            this.identification_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "Identification code", true));
            this.identification_codeTextBox.Location = new System.Drawing.Point(126, 129);
            this.identification_codeTextBox.Name = "identification_codeTextBox";
            this.identification_codeTextBox.Size = new System.Drawing.Size(159, 20);
            this.identification_codeTextBox.TabIndex = 6;
            this.identification_codeTextBox.TextChanged += new System.EventHandler(this.identification_codeTextBox_TextChanged);
            // 
            // homeAddressTextBox
            // 
            this.homeAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "HomeAddress", true));
            this.homeAddressTextBox.Location = new System.Drawing.Point(126, 155);
            this.homeAddressTextBox.Name = "homeAddressTextBox";
            this.homeAddressTextBox.Size = new System.Drawing.Size(159, 20);
            this.homeAddressTextBox.TabIndex = 8;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(126, 181);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(159, 20);
            this.phoneNumberTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "На головну";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fullNameRichTextBox
            // 
            this.fullNameRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "FullName", true));
            this.fullNameRichTextBox.Location = new System.Drawing.Point(125, 57);
            this.fullNameRichTextBox.Name = "fullNameRichTextBox";
            this.fullNameRichTextBox.Size = new System.Drawing.Size(160, 40);
            this.fullNameRichTextBox.TabIndex = 12;
            this.fullNameRichTextBox.Text = "";
            // 
            // passportTextBox
            // 
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "Passport", true));
            this.passportTextBox.Location = new System.Drawing.Point(125, 103);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(160, 20);
            this.passportTextBox.TabIndex = 13;
            // 
            // teachersDataGridView
            // 
            this.teachersDataGridView.AllowUserToAddRows = false;
            this.teachersDataGridView.AllowUserToDeleteRows = false;
            this.teachersDataGridView.AutoGenerateColumns = false;
            this.teachersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.teachersDataGridView.DataSource = this.teachersBindingSource;
            this.teachersDataGridView.Location = new System.Drawing.Point(291, 28);
            this.teachersDataGridView.Name = "teachersDataGridView";
            this.teachersDataGridView.ReadOnly = true;
            this.teachersDataGridView.Size = new System.Drawing.Size(653, 199);
            this.teachersDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdTeacher";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id викладача";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Identification code";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ідентифікаційний код";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HomeAddress";
            this.dataGridViewTextBoxColumn5.HeaderText = "Місце проживання";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn6.HeaderText = "Номер телефону";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // searchTeachToolStrip
            // 
            this.searchTeachToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchTeachToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idTeacherToolStripLabel,
            this.idTeacherToolStripTextBox,
            this.fullNameToolStripLabel,
            this.fullNameToolStripTextBox,
            this.passportToolStripLabel,
            this.passportToolStripTextBox,
            this.searchTeachToolStripButton});
            this.searchTeachToolStrip.Location = new System.Drawing.Point(370, 0);
            this.searchTeachToolStrip.Name = "searchTeachToolStrip";
            this.searchTeachToolStrip.Size = new System.Drawing.Size(574, 25);
            this.searchTeachToolStrip.TabIndex = 15;
            this.searchTeachToolStrip.Text = "searchTeachToolStrip";
            // 
            // idTeacherToolStripLabel
            // 
            this.idTeacherToolStripLabel.Name = "idTeacherToolStripLabel";
            this.idTeacherToolStripLabel.Size = new System.Drawing.Size(80, 22);
            this.idTeacherToolStripLabel.Text = "Id викладача:";
            // 
            // idTeacherToolStripTextBox
            // 
            this.idTeacherToolStripTextBox.Name = "idTeacherToolStripTextBox";
            this.idTeacherToolStripTextBox.Size = new System.Drawing.Size(100, 25);
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
            // searchTeachToolStripButton
            // 
            this.searchTeachToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchTeachToolStripButton.Name = "searchTeachToolStripButton";
            this.searchTeachToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.searchTeachToolStripButton.Text = "Пошук";
            this.searchTeachToolStripButton.Click += new System.EventHandler(this.searchTeachToolStripButton_Click);
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TeachersTableAdapter = this.teachersTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataBase.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 240);
            this.Controls.Add(this.searchTeachToolStrip);
            this.Controls.Add(this.teachersDataGridView);
            this.Controls.Add(passportLabel);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(this.fullNameRichTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(homeAddressLabel);
            this.Controls.Add(this.homeAddressTextBox);
            this.Controls.Add(identification_codeLabel);
            this.Controls.Add(this.identification_codeTextBox);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(idTeacherLabel);
            this.Controls.Add(this.idTeacherTextBox);
            this.Controls.Add(this.teachersBindingNavigator);
            this.Name = "Form2";
            this.Text = "Викладачі";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingNavigator)).EndInit();
            this.teachersBindingNavigator.ResumeLayout(false);
            this.teachersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).EndInit();
            this.searchTeachToolStrip.ResumeLayout(false);
            this.searchTeachToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private DataSet1TableAdapters.TeachersTableAdapter teachersTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator teachersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton teachersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTeacherTextBox;
        private System.Windows.Forms.TextBox identification_codeTextBox;
        private System.Windows.Forms.TextBox homeAddressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox fullNameRichTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView teachersDataGridView;
        private System.Windows.Forms.ToolStrip searchTeachToolStrip;
        private System.Windows.Forms.ToolStripLabel idTeacherToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idTeacherToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel fullNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fullNameToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel passportToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox passportToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchTeachToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}