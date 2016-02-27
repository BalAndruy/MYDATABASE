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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label idCourseLabel;
            System.Windows.Forms.Label coursetTitleLabel;
            System.Windows.Forms.Label timetableLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label duringOneLessonLabel;
            System.Windows.Forms.Label courseFeeLabel;
            this.dataSet3 = new DataBase.DataSet3();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new DataBase.DataSet3TableAdapters.CoursesTableAdapter();
            this.tableAdapterManager = new DataBase.DataSet3TableAdapters.TableAdapterManager();
            this.coursesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.coursesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idCourseTextBox = new System.Windows.Forms.TextBox();
            this.coursetTitleTextBox = new System.Windows.Forms.TextBox();
            this.timetableTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.duringOneLessonTextBox = new System.Windows.Forms.TextBox();
            this.courseFeeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            idCourseLabel = new System.Windows.Forms.Label();
            coursetTitleLabel = new System.Windows.Forms.Label();
            timetableLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            duringOneLessonLabel = new System.Windows.Forms.Label();
            courseFeeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).BeginInit();
            this.coursesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.dataSet3;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.UpdateOrder = DataBase.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // coursesBindingNavigator
            // 
            this.coursesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coursesBindingNavigator.BindingSource = this.coursesBindingSource;
            this.coursesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coursesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.coursesBindingNavigatorSaveItem});
            this.coursesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.coursesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coursesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coursesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coursesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coursesBindingNavigator.Name = "coursesBindingNavigator";
            this.coursesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coursesBindingNavigator.Size = new System.Drawing.Size(282, 25);
            this.coursesBindingNavigator.TabIndex = 0;
            this.coursesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // coursesBindingNavigatorSaveItem
            // 
            this.coursesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coursesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coursesBindingNavigatorSaveItem.Image")));
            this.coursesBindingNavigatorSaveItem.Name = "coursesBindingNavigatorSaveItem";
            this.coursesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.coursesBindingNavigatorSaveItem.Text = "Save Data";
            this.coursesBindingNavigatorSaveItem.Click += new System.EventHandler(this.coursesBindingNavigatorSaveItem_Click);
            // 
            // idCourseLabel
            // 
            idCourseLabel.AutoSize = true;
            idCourseLabel.Location = new System.Drawing.Point(105, 31);
            idCourseLabel.Name = "idCourseLabel";
            idCourseLabel.Size = new System.Drawing.Size(50, 13);
            idCourseLabel.TabIndex = 1;
            idCourseLabel.Text = "Id курсу:";
            // 
            // idCourseTextBox
            // 
            this.idCourseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "IdCourse", true));
            this.idCourseTextBox.Location = new System.Drawing.Point(161, 28);
            this.idCourseTextBox.Name = "idCourseTextBox";
            this.idCourseTextBox.Size = new System.Drawing.Size(113, 20);
            this.idCourseTextBox.TabIndex = 2;
            // 
            // coursetTitleLabel
            // 
            coursetTitleLabel.AutoSize = true;
            coursetTitleLabel.Location = new System.Drawing.Point(82, 57);
            coursetTitleLabel.Name = "coursetTitleLabel";
            coursetTitleLabel.Size = new System.Drawing.Size(73, 13);
            coursetTitleLabel.TabIndex = 3;
            coursetTitleLabel.Text = "Назва курсу:";
            // 
            // coursetTitleTextBox
            // 
            this.coursetTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CoursetTitle", true));
            this.coursetTitleTextBox.Location = new System.Drawing.Point(161, 54);
            this.coursetTitleTextBox.Name = "coursetTitleTextBox";
            this.coursetTitleTextBox.Size = new System.Drawing.Size(113, 20);
            this.coursetTitleTextBox.TabIndex = 4;
            // 
            // timetableLabel
            // 
            timetableLabel.AutoSize = true;
            timetableLabel.Location = new System.Drawing.Point(102, 84);
            timetableLabel.Name = "timetableLabel";
            timetableLabel.Size = new System.Drawing.Size(53, 13);
            timetableLabel.TabIndex = 5;
            timetableLabel.Text = "Розклад:";
            // 
            // timetableTextBox
            // 
            this.timetableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Timetable", true));
            this.timetableTextBox.Location = new System.Drawing.Point(161, 81);
            this.timetableTextBox.Name = "timetableTextBox";
            this.timetableTextBox.Size = new System.Drawing.Size(113, 20);
            this.timetableTextBox.TabIndex = 6;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(54, 110);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(101, 13);
            durationLabel.TabIndex = 7;
            durationLabel.Text = "Тривальсть курсу:";
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(161, 107);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(113, 20);
            this.durationTextBox.TabIndex = 8;
            // 
            // duringOneLessonLabel
            // 
            duringOneLessonLabel.AutoSize = true;
            duringOneLessonLabel.Location = new System.Drawing.Point(8, 136);
            duringOneLessonLabel.Name = "duringOneLessonLabel";
            duringOneLessonLabel.Size = new System.Drawing.Size(147, 13);
            duringOneLessonLabel.TabIndex = 9;
            duringOneLessonLabel.Text = "Тривалість одного заняття:";
            // 
            // duringOneLessonTextBox
            // 
            this.duringOneLessonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "DuringOneLesson", true));
            this.duringOneLessonTextBox.Location = new System.Drawing.Point(161, 133);
            this.duringOneLessonTextBox.Name = "duringOneLessonTextBox";
            this.duringOneLessonTextBox.Size = new System.Drawing.Size(113, 20);
            this.duringOneLessonTextBox.TabIndex = 10;
            // 
            // courseFeeLabel
            // 
            courseFeeLabel.AutoSize = true;
            courseFeeLabel.Location = new System.Drawing.Point(102, 162);
            courseFeeLabel.Name = "courseFeeLabel";
            courseFeeLabel.Size = new System.Drawing.Size(53, 13);
            courseFeeLabel.TabIndex = 11;
            courseFeeLabel.Text = "Вартість:";
            // 
            // courseFeeTextBox
            // 
            this.courseFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CourseFee", true));
            this.courseFeeTextBox.Location = new System.Drawing.Point(161, 159);
            this.courseFeeTextBox.Name = "courseFeeTextBox";
            this.courseFeeTextBox.Size = new System.Drawing.Size(113, 20);
            this.courseFeeTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "На головну";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 213);
            this.Controls.Add(this.button1);
            this.Controls.Add(courseFeeLabel);
            this.Controls.Add(this.courseFeeTextBox);
            this.Controls.Add(duringOneLessonLabel);
            this.Controls.Add(this.duringOneLessonTextBox);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(timetableLabel);
            this.Controls.Add(this.timetableTextBox);
            this.Controls.Add(coursetTitleLabel);
            this.Controls.Add(this.coursetTitleTextBox);
            this.Controls.Add(idCourseLabel);
            this.Controls.Add(this.idCourseTextBox);
            this.Controls.Add(this.coursesBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).EndInit();
            this.coursesBindingNavigator.ResumeLayout(false);
            this.coursesBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox idCourseTextBox;
        private System.Windows.Forms.TextBox coursetTitleTextBox;
        private System.Windows.Forms.TextBox timetableTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox duringOneLessonTextBox;
        private System.Windows.Forms.TextBox courseFeeTextBox;
        private System.Windows.Forms.Button button1;
    }
}