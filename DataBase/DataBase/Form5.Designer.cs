namespace DataBase
{
    partial class Form5
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
            System.Windows.Forms.Label idCourseLabel;
            System.Windows.Forms.Label idStudentLabel;
            System.Windows.Forms.Label idTeacherLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label idListLabel;
            this.listOfStudyingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.listOfStudyingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listOfStudyingDataGridView = new System.Windows.Forms.DataGridView();
            this.idCourseTextBox = new System.Windows.Forms.TextBox();
            this.idStudentTextBox = new System.Windows.Forms.TextBox();
            this.idTeacherTextBox = new System.Windows.Forms.TextBox();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.teachersDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.coursesDataGridView = new System.Windows.Forms.DataGridView();
            this.IdTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idListTextBox = new System.Windows.Forms.TextBox();
            this.searchNewLIStToolStrip = new System.Windows.Forms.ToolStrip();
            this.idListToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idListToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.idCourseToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idCourseToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.idStudentToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idStudentToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.idTeacherToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idTeacherToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchNewLIStToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.listOfStudyingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new DataBase.DataSet3();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listOfStudyingTableAdapter = new DataBase.DataSet3TableAdapters.ListOfStudyingTableAdapter();
            this.tableAdapterManager = new DataBase.DataSet3TableAdapters.TableAdapterManager();
            this.coursesTableAdapter = new DataBase.DataSet3TableAdapters.CoursesTableAdapter();
            this.studentsTableAdapter = new DataBase.DataSet3TableAdapters.StudentsTableAdapter();
            this.teachersTableAdapter = new DataBase.DataSet3TableAdapters.TeachersTableAdapter();
            idCourseLabel = new System.Windows.Forms.Label();
            idStudentLabel = new System.Windows.Forms.Label();
            idTeacherLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            idListLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listOfStudyingBindingNavigator)).BeginInit();
            this.listOfStudyingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfStudyingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).BeginInit();
            this.searchNewLIStToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfStudyingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idCourseLabel
            // 
            idCourseLabel.AutoSize = true;
            idCourseLabel.Location = new System.Drawing.Point(37, 58);
            idCourseLabel.Name = "idCourseLabel";
            idCourseLabel.Size = new System.Drawing.Size(50, 13);
            idCourseLabel.TabIndex = 2;
            idCourseLabel.Text = "Id курсу:";
            // 
            // idStudentLabel
            // 
            idStudentLabel.AutoSize = true;
            idStudentLabel.Location = new System.Drawing.Point(20, 84);
            idStudentLabel.Name = "idStudentLabel";
            idStudentLabel.Size = new System.Drawing.Size(67, 13);
            idStudentLabel.TabIndex = 4;
            idStudentLabel.Text = "Id студента:";
            // 
            // idTeacherLabel
            // 
            idTeacherLabel.AutoSize = true;
            idTeacherLabel.Location = new System.Drawing.Point(12, 110);
            idTeacherLabel.Name = "idTeacherLabel";
            idTeacherLabel.Size = new System.Drawing.Size(75, 13);
            idTeacherLabel.TabIndex = 6;
            idTeacherLabel.Text = "Id викладача:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(466, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 13);
            label1.TabIndex = 9;
            label1.Text = "Студенти:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(466, 148);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 13);
            label2.TabIndex = 11;
            label2.Text = "Викладачі:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(466, 301);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 13);
            label3.TabIndex = 13;
            label3.Text = "Курси:";
            // 
            // listOfStudyingBindingNavigator
            // 
            this.listOfStudyingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listOfStudyingBindingNavigator.BindingSource = this.listOfStudyingBindingSource;
            this.listOfStudyingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listOfStudyingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listOfStudyingBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.listOfStudyingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listOfStudyingBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripSeparator2});
            this.listOfStudyingBindingNavigator.Location = new System.Drawing.Point(93, 0);
            this.listOfStudyingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listOfStudyingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listOfStudyingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listOfStudyingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listOfStudyingBindingNavigator.Name = "listOfStudyingBindingNavigator";
            this.listOfStudyingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listOfStudyingBindingNavigator.Size = new System.Drawing.Size(368, 25);
            this.listOfStudyingBindingNavigator.TabIndex = 0;
            this.listOfStudyingBindingNavigator.Text = "bindingNavigator1";
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
            // listOfStudyingBindingNavigatorSaveItem
            // 
            this.listOfStudyingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listOfStudyingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listOfStudyingBindingNavigatorSaveItem.Image")));
            this.listOfStudyingBindingNavigatorSaveItem.Name = "listOfStudyingBindingNavigatorSaveItem";
            this.listOfStudyingBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listOfStudyingBindingNavigatorSaveItem.Text = "Save Data";
            this.listOfStudyingBindingNavigatorSaveItem.Click += new System.EventHandler(this.listOfStudyingBindingNavigatorSaveItem_Click);
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
            // listOfStudyingDataGridView
            // 
            this.listOfStudyingDataGridView.AllowUserToAddRows = false;
            this.listOfStudyingDataGridView.AllowUserToDeleteRows = false;
            this.listOfStudyingDataGridView.AutoGenerateColumns = false;
            this.listOfStudyingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfStudyingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdList,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.listOfStudyingDataGridView.DataSource = this.listOfStudyingBindingSource;
            this.listOfStudyingDataGridView.Location = new System.Drawing.Point(14, 133);
            this.listOfStudyingDataGridView.Name = "listOfStudyingDataGridView";
            this.listOfStudyingDataGridView.ReadOnly = true;
            this.listOfStudyingDataGridView.Size = new System.Drawing.Size(449, 220);
            this.listOfStudyingDataGridView.TabIndex = 1;
            // 
            // idCourseTextBox
            // 
            this.idCourseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listOfStudyingBindingSource, "IdCourse", true));
            this.idCourseTextBox.Location = new System.Drawing.Point(93, 55);
            this.idCourseTextBox.Name = "idCourseTextBox";
            this.idCourseTextBox.Size = new System.Drawing.Size(100, 20);
            this.idCourseTextBox.TabIndex = 3;
            // 
            // idStudentTextBox
            // 
            this.idStudentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listOfStudyingBindingSource, "IdStudent", true));
            this.idStudentTextBox.Location = new System.Drawing.Point(93, 81);
            this.idStudentTextBox.Name = "idStudentTextBox";
            this.idStudentTextBox.Size = new System.Drawing.Size(100, 20);
            this.idStudentTextBox.TabIndex = 5;
            // 
            // idTeacherTextBox
            // 
            this.idTeacherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listOfStudyingBindingSource, "IdTeacher", true));
            this.idTeacherTextBox.Location = new System.Drawing.Point(93, 107);
            this.idTeacherTextBox.Name = "idTeacherTextBox";
            this.idTeacherTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTeacherTextBox.TabIndex = 7;
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AllowUserToAddRows = false;
            this.studentsDataGridView.AllowUserToDeleteRows = false;
            this.studentsDataGridView.AutoGenerateColumns = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.studentsDataGridView.DataSource = this.studentsBindingSource;
            this.studentsDataGridView.Location = new System.Drawing.Point(469, 43);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.ReadOnly = true;
            this.studentsDataGridView.Size = new System.Drawing.Size(547, 99);
            this.studentsDataGridView.TabIndex = 8;
            // 
            // teachersDataGridView
            // 
            this.teachersDataGridView.AllowUserToAddRows = false;
            this.teachersDataGridView.AllowUserToDeleteRows = false;
            this.teachersDataGridView.AutoGenerateColumns = false;
            this.teachersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.teachersDataGridView.DataSource = this.teachersBindingSource;
            this.teachersDataGridView.Location = new System.Drawing.Point(469, 164);
            this.teachersDataGridView.Name = "teachersDataGridView";
            this.teachersDataGridView.ReadOnly = true;
            this.teachersDataGridView.Size = new System.Drawing.Size(649, 127);
            this.teachersDataGridView.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "На головну";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // coursesDataGridView
            // 
            this.coursesDataGridView.AllowUserToAddRows = false;
            this.coursesDataGridView.AllowUserToDeleteRows = false;
            this.coursesDataGridView.AutoGenerateColumns = false;
            this.coursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.IdTeacher,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.coursesDataGridView.DataSource = this.coursesBindingSource;
            this.coursesDataGridView.Location = new System.Drawing.Point(469, 319);
            this.coursesDataGridView.Name = "coursesDataGridView";
            this.coursesDataGridView.ReadOnly = true;
            this.coursesDataGridView.Size = new System.Drawing.Size(747, 116);
            this.coursesDataGridView.TabIndex = 23;
            // 
            // IdTeacher
            // 
            this.IdTeacher.DataPropertyName = "IdTeacher";
            this.IdTeacher.HeaderText = "Id викладача";
            this.IdTeacher.Name = "IdTeacher";
            this.IdTeacher.ReadOnly = true;
            // 
            // IdList
            // 
            this.IdList.DataPropertyName = "IdList";
            this.IdList.HeaderText = "Id навчання";
            this.IdList.Name = "IdList";
            this.IdList.ReadOnly = true;
            // 
            // idListLabel
            // 
            idListLabel.AutoSize = true;
            idListLabel.Location = new System.Drawing.Point(18, 31);
            idListLabel.Name = "idListLabel";
            idListLabel.Size = new System.Drawing.Size(69, 13);
            idListLabel.TabIndex = 23;
            idListLabel.Text = "Id навчання:";
            // 
            // idListTextBox
            // 
            this.idListTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listOfStudyingBindingSource, "IdList", true));
            this.idListTextBox.Location = new System.Drawing.Point(93, 28);
            this.idListTextBox.Name = "idListTextBox";
            this.idListTextBox.Size = new System.Drawing.Size(100, 20);
            this.idListTextBox.TabIndex = 24;
            // 
            // searchNewLIStToolStrip
            // 
            this.searchNewLIStToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchNewLIStToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idListToolStripLabel,
            this.idListToolStripTextBox,
            this.idCourseToolStripLabel,
            this.idCourseToolStripTextBox,
            this.idStudentToolStripLabel,
            this.idStudentToolStripTextBox,
            this.idTeacherToolStripLabel,
            this.idTeacherToolStripTextBox,
            this.searchNewLIStToolStripButton});
            this.searchNewLIStToolStrip.Location = new System.Drawing.Point(469, 0);
            this.searchNewLIStToolStrip.Name = "searchNewLIStToolStrip";
            this.searchNewLIStToolStrip.Size = new System.Drawing.Size(749, 25);
            this.searchNewLIStToolStrip.TabIndex = 25;
            this.searchNewLIStToolStrip.Text = "searchNewLIStToolStrip";
            // 
            // idListToolStripLabel
            // 
            this.idListToolStripLabel.Name = "idListToolStripLabel";
            this.idListToolStripLabel.Size = new System.Drawing.Size(75, 22);
            this.idListToolStripLabel.Text = "Id навчання:";
            // 
            // idListToolStripTextBox
            // 
            this.idListToolStripTextBox.Name = "idListToolStripTextBox";
            this.idListToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // idCourseToolStripLabel
            // 
            this.idCourseToolStripLabel.Name = "idCourseToolStripLabel";
            this.idCourseToolStripLabel.Size = new System.Drawing.Size(54, 22);
            this.idCourseToolStripLabel.Text = "Id курсу:";
            // 
            // idCourseToolStripTextBox
            // 
            this.idCourseToolStripTextBox.Name = "idCourseToolStripTextBox";
            this.idCourseToolStripTextBox.Size = new System.Drawing.Size(100, 25);
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
            // searchNewLIStToolStripButton
            // 
            this.searchNewLIStToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchNewLIStToolStripButton.Name = "searchNewLIStToolStripButton";
            this.searchNewLIStToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.searchNewLIStToolStripButton.Text = "Пошук";
            this.searchNewLIStToolStripButton.Click += new System.EventHandler(this.searchNewLIStToolStripButton_Click);
            // 
            // listOfStudyingBindingSource
            // 
            this.listOfStudyingBindingSource.DataMember = "ListOfStudying";
            this.listOfStudyingBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "IdCourse";
            this.dataGridViewTextBoxColumn15.HeaderText = "Id курсу";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "CoursetTitle";
            this.dataGridViewTextBoxColumn16.HeaderText = "Назва курсу";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Timetable";
            this.dataGridViewTextBoxColumn17.HeaderText = "Розклад";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn18.HeaderText = "Тривалість курсу";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "DuringOneLesson";
            this.dataGridViewTextBoxColumn19.HeaderText = "Тривалість одного заняття";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "CourseFee";
            this.dataGridViewTextBoxColumn20.HeaderText = "Вартість";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.dataSet3;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdTeacher";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id викладача";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn10.HeaderText = "Повне ім\'я";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Passport";
            this.dataGridViewTextBoxColumn11.HeaderText = "Паспорт";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Identification code";
            this.dataGridViewTextBoxColumn12.HeaderText = "Ідентифікаційний код";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "HomeAddress";
            this.dataGridViewTextBoxColumn13.HeaderText = "Місце проживання";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn14.HeaderText = "Номер телефону";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.dataSet3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdStudent";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id студента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Повне ім\'я";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Passport";
            this.dataGridViewTextBoxColumn6.HeaderText = "Паспорт";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HomeAddress";
            this.dataGridViewTextBoxColumn7.HeaderText = "Місце проживання";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn8.HeaderText = "Номер телефону";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.dataSet3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdCourse";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id курсу";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdStudent";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id студента";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdTeacher";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id викладача";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // listOfStudyingTableAdapter
            // 
            this.listOfStudyingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.ListOfStudyingTableAdapter = this.listOfStudyingTableAdapter;
            this.tableAdapterManager.sqlite_sequenceTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.TeachersTableAdapter = this.teachersTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataBase.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 443);
            this.Controls.Add(this.searchNewLIStToolStrip);
            this.Controls.Add(idListLabel);
            this.Controls.Add(this.idListTextBox);
            this.Controls.Add(this.coursesDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.teachersDataGridView);
            this.Controls.Add(label1);
            this.Controls.Add(this.studentsDataGridView);
            this.Controls.Add(idTeacherLabel);
            this.Controls.Add(this.idTeacherTextBox);
            this.Controls.Add(idStudentLabel);
            this.Controls.Add(this.idStudentTextBox);
            this.Controls.Add(idCourseLabel);
            this.Controls.Add(this.idCourseTextBox);
            this.Controls.Add(this.listOfStudyingDataGridView);
            this.Controls.Add(this.listOfStudyingBindingNavigator);
            this.Name = "Form5";
            this.Text = "Навчання";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOfStudyingBindingNavigator)).EndInit();
            this.listOfStudyingBindingNavigator.ResumeLayout(false);
            this.listOfStudyingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfStudyingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).EndInit();
            this.searchNewLIStToolStrip.ResumeLayout(false);
            this.searchNewLIStToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfStudyingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource listOfStudyingBindingSource;
        private DataSet3TableAdapters.ListOfStudyingTableAdapter listOfStudyingTableAdapter;
        private DataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator listOfStudyingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listOfStudyingBindingNavigatorSaveItem;
        private DataSet3TableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridView listOfStudyingDataGridView;
        private System.Windows.Forms.TextBox idCourseTextBox;
        private System.Windows.Forms.TextBox idStudentTextBox;
        private System.Windows.Forms.TextBox idTeacherTextBox;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private DataSet3TableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private DataSet3TableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridView teachersDataGridView;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView coursesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox idListTextBox;
        private System.Windows.Forms.ToolStrip searchNewLIStToolStrip;
        private System.Windows.Forms.ToolStripLabel idListToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idListToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel idCourseToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idCourseToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel idStudentToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idStudentToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel idTeacherToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idTeacherToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchNewLIStToolStripButton;
    }
}