namespace DataBase
{
    partial class Form4
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
            System.Windows.Forms.Label courseFeeLabel;
            System.Windows.Forms.Label duringOneLessonLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label timetableLabel;
            System.Windows.Forms.Label coursetTitleLabel;
            System.Windows.Forms.Label idCourseLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label idTeacherLabel;
            this.coursesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.coursesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.coursesDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.idCourseTextBox = new System.Windows.Forms.TextBox();
            this.coursetTitleTextBox = new System.Windows.Forms.TextBox();
            this.timetableTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.duringOneLessonTextBox = new System.Windows.Forms.TextBox();
            this.courseFeeTextBox = new System.Windows.Forms.TextBox();
            this.serachCourseToolStrip = new System.Windows.Forms.ToolStrip();
            this.idCourseToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idCourseToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.coursetTitleToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.coursetTitleToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.serachCourseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new DataBase.DataSet3();
            this.coursesTableAdapter = new DataBase.DataSet3TableAdapters.CoursesTableAdapter();
            this.tableAdapterManager = new DataBase.DataSet3TableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTeacherTextBox = new System.Windows.Forms.TextBox();
            courseFeeLabel = new System.Windows.Forms.Label();
            duringOneLessonLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            timetableLabel = new System.Windows.Forms.Label();
            coursetTitleLabel = new System.Windows.Forms.Label();
            idCourseLabel = new System.Windows.Forms.Label();
            idTeacherLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).BeginInit();
            this.coursesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).BeginInit();
            this.serachCourseToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // courseFeeLabel
            // 
            courseFeeLabel.AutoSize = true;
            courseFeeLabel.Location = new System.Drawing.Point(100, 199);
            courseFeeLabel.Name = "courseFeeLabel";
            courseFeeLabel.Size = new System.Drawing.Size(53, 13);
            courseFeeLabel.TabIndex = 19;
            courseFeeLabel.Text = "Вартість:";
            // 
            // duringOneLessonLabel
            // 
            duringOneLessonLabel.AutoSize = true;
            duringOneLessonLabel.Location = new System.Drawing.Point(6, 173);
            duringOneLessonLabel.Name = "duringOneLessonLabel";
            duringOneLessonLabel.Size = new System.Drawing.Size(147, 13);
            duringOneLessonLabel.TabIndex = 18;
            duringOneLessonLabel.Text = "Тривалість одного заняття:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(52, 147);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(101, 13);
            durationLabel.TabIndex = 17;
            durationLabel.Text = "Тривальсть курсу:";
            // 
            // timetableLabel
            // 
            timetableLabel.AutoSize = true;
            timetableLabel.Location = new System.Drawing.Point(100, 121);
            timetableLabel.Name = "timetableLabel";
            timetableLabel.Size = new System.Drawing.Size(53, 13);
            timetableLabel.TabIndex = 16;
            timetableLabel.Text = "Розклад:";
            // 
            // coursetTitleLabel
            // 
            coursetTitleLabel.AutoSize = true;
            coursetTitleLabel.Location = new System.Drawing.Point(80, 94);
            coursetTitleLabel.Name = "coursetTitleLabel";
            coursetTitleLabel.Size = new System.Drawing.Size(73, 13);
            coursetTitleLabel.TabIndex = 15;
            coursetTitleLabel.Text = "Назва курсу:";
            // 
            // idCourseLabel
            // 
            idCourseLabel.AutoSize = true;
            idCourseLabel.Location = new System.Drawing.Point(103, 41);
            idCourseLabel.Name = "idCourseLabel";
            idCourseLabel.Size = new System.Drawing.Size(50, 13);
            idCourseLabel.TabIndex = 14;
            idCourseLabel.Text = "Id курсу:";
            // 
            // coursesBindingNavigator
            // 
            this.coursesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coursesBindingNavigator.BindingSource = this.coursesBindingSource;
            this.coursesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coursesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coursesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.coursesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.coursesBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripSeparator2});
            this.coursesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.coursesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coursesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coursesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coursesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coursesBindingNavigator.Name = "coursesBindingNavigator";
            this.coursesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coursesBindingNavigator.Size = new System.Drawing.Size(368, 25);
            this.coursesBindingNavigator.TabIndex = 0;
            this.coursesBindingNavigator.Text = "bindingNavigator1";
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
            // coursesBindingNavigatorSaveItem
            // 
            this.coursesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coursesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coursesBindingNavigatorSaveItem.Image")));
            this.coursesBindingNavigatorSaveItem.Name = "coursesBindingNavigatorSaveItem";
            this.coursesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.coursesBindingNavigatorSaveItem.Text = "Save Data";
            this.coursesBindingNavigatorSaveItem.Click += new System.EventHandler(this.coursesBindingNavigatorSaveItem_Click);
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
            // coursesDataGridView
            // 
            this.coursesDataGridView.AllowUserToAddRows = false;
            this.coursesDataGridView.AllowUserToDeleteRows = false;
            this.coursesDataGridView.AutoGenerateColumns = false;
            this.coursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.IdTeacher,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.coursesDataGridView.DataSource = this.coursesBindingSource;
            this.coursesDataGridView.Location = new System.Drawing.Point(265, 28);
            this.coursesDataGridView.Name = "coursesDataGridView";
            this.coursesDataGridView.ReadOnly = true;
            this.coursesDataGridView.Size = new System.Drawing.Size(747, 220);
            this.coursesDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "На головну";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idCourseTextBox
            // 
            this.idCourseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "IdCourse", true));
            this.idCourseTextBox.Location = new System.Drawing.Point(159, 38);
            this.idCourseTextBox.Name = "idCourseTextBox";
            this.idCourseTextBox.Size = new System.Drawing.Size(100, 20);
            this.idCourseTextBox.TabIndex = 21;
            // 
            // coursetTitleTextBox
            // 
            this.coursetTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CoursetTitle", true));
            this.coursetTitleTextBox.Location = new System.Drawing.Point(159, 91);
            this.coursetTitleTextBox.Name = "coursetTitleTextBox";
            this.coursetTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.coursetTitleTextBox.TabIndex = 22;
            // 
            // timetableTextBox
            // 
            this.timetableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Timetable", true));
            this.timetableTextBox.Location = new System.Drawing.Point(159, 118);
            this.timetableTextBox.Name = "timetableTextBox";
            this.timetableTextBox.Size = new System.Drawing.Size(100, 20);
            this.timetableTextBox.TabIndex = 23;
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(159, 144);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 20);
            this.durationTextBox.TabIndex = 24;
            // 
            // duringOneLessonTextBox
            // 
            this.duringOneLessonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "DuringOneLesson", true));
            this.duringOneLessonTextBox.Location = new System.Drawing.Point(159, 170);
            this.duringOneLessonTextBox.Name = "duringOneLessonTextBox";
            this.duringOneLessonTextBox.Size = new System.Drawing.Size(100, 20);
            this.duringOneLessonTextBox.TabIndex = 25;
            // 
            // courseFeeTextBox
            // 
            this.courseFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CourseFee", true));
            this.courseFeeTextBox.Location = new System.Drawing.Point(159, 199);
            this.courseFeeTextBox.Name = "courseFeeTextBox";
            this.courseFeeTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseFeeTextBox.TabIndex = 26;
            // 
            // serachCourseToolStrip
            // 
            this.serachCourseToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.serachCourseToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idCourseToolStripLabel,
            this.idCourseToolStripTextBox,
            this.coursetTitleToolStripLabel,
            this.coursetTitleToolStripTextBox,
            this.serachCourseToolStripButton});
            this.serachCourseToolStrip.Location = new System.Drawing.Point(380, 0);
            this.serachCourseToolStrip.Name = "serachCourseToolStrip";
            this.serachCourseToolStrip.Size = new System.Drawing.Size(396, 25);
            this.serachCourseToolStrip.TabIndex = 27;
            this.serachCourseToolStrip.Text = "serachCourseToolStrip";
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
            // coursetTitleToolStripLabel
            // 
            this.coursetTitleToolStripLabel.Name = "coursetTitleToolStripLabel";
            this.coursetTitleToolStripLabel.Size = new System.Drawing.Size(76, 22);
            this.coursetTitleToolStripLabel.Text = "Назва курсу:";
            // 
            // coursetTitleToolStripTextBox
            // 
            this.coursetTitleToolStripTextBox.Name = "coursetTitleToolStripTextBox";
            this.coursetTitleToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // serachCourseToolStripButton
            // 
            this.serachCourseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.serachCourseToolStripButton.Name = "serachCourseToolStripButton";
            this.serachCourseToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.serachCourseToolStripButton.Text = "Пошук";
            this.serachCourseToolStripButton.Click += new System.EventHandler(this.serachCourseToolStripButton_Click);
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.ListOfStudyingTableAdapter = null;
            this.tableAdapterManager.sqlite_sequenceTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DataBase.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCourse";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id курсу";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // IdTeacher
            // 
            this.IdTeacher.DataPropertyName = "IdTeacher";
            this.IdTeacher.HeaderText = "Id викладача";
            this.IdTeacher.Name = "IdTeacher";
            this.IdTeacher.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CoursetTitle";
            this.dataGridViewTextBoxColumn2.HeaderText = "Назва курсу";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Timetable";
            this.dataGridViewTextBoxColumn3.HeaderText = "Розклад";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn4.HeaderText = "Тривалість курсу";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DuringOneLesson";
            this.dataGridViewTextBoxColumn5.HeaderText = "Тривалість одного заняття";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CourseFee";
            this.dataGridViewTextBoxColumn6.HeaderText = "Вартість";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // idTeacherLabel
            // 
            idTeacherLabel.AutoSize = true;
            idTeacherLabel.Location = new System.Drawing.Point(78, 67);
            idTeacherLabel.Name = "idTeacherLabel";
            idTeacherLabel.Size = new System.Drawing.Size(75, 13);
            idTeacherLabel.TabIndex = 27;
            idTeacherLabel.Text = "Id викладача:";
            // 
            // idTeacherTextBox
            // 
            this.idTeacherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "IdTeacher", true));
            this.idTeacherTextBox.Location = new System.Drawing.Point(159, 64);
            this.idTeacherTextBox.Name = "idTeacherTextBox";
            this.idTeacherTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTeacherTextBox.TabIndex = 28;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 257);
            this.Controls.Add(idTeacherLabel);
            this.Controls.Add(this.idTeacherTextBox);
            this.Controls.Add(this.serachCourseToolStrip);
            this.Controls.Add(this.courseFeeTextBox);
            this.Controls.Add(this.duringOneLessonTextBox);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.timetableTextBox);
            this.Controls.Add(this.coursetTitleTextBox);
            this.Controls.Add(this.idCourseTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(courseFeeLabel);
            this.Controls.Add(duringOneLessonLabel);
            this.Controls.Add(durationLabel);
            this.Controls.Add(timetableLabel);
            this.Controls.Add(coursetTitleLabel);
            this.Controls.Add(idCourseLabel);
            this.Controls.Add(this.coursesDataGridView);
            this.Controls.Add(this.coursesBindingNavigator);
            this.Name = "Form4";
            this.Text = "Курси";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).EndInit();
            this.coursesBindingNavigator.ResumeLayout(false);
            this.coursesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).EndInit();
            this.serachCourseToolStrip.ResumeLayout(false);
            this.serachCourseToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private DataSet3TableAdapters.CoursesTableAdapter coursesTableAdapter;
        private DataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator coursesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton coursesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView coursesDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idCourseTextBox;
        private System.Windows.Forms.TextBox coursetTitleTextBox;
        private System.Windows.Forms.TextBox timetableTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox duringOneLessonTextBox;
        private System.Windows.Forms.TextBox courseFeeTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip serachCourseToolStrip;
        private System.Windows.Forms.ToolStripLabel idCourseToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idCourseToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel coursetTitleToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox coursetTitleToolStripTextBox;
        private System.Windows.Forms.ToolStripButton serachCourseToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox idTeacherTextBox;
    }
}