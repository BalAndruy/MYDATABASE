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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label idTeacherLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label identification_codeLabel;
            System.Windows.Forms.Label homeAddressLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label passportLabel;
            this.dataSet1 = new DataBase.DataSet1();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new DataBase.DataSet1TableAdapters.TeachersTableAdapter();
            this.tableAdapterManager = new DataBase.DataSet1TableAdapters.TableAdapterManager();
            this.teachersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.teachersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTeacherTextBox = new System.Windows.Forms.TextBox();
            this.identification_codeTextBox = new System.Windows.Forms.TextBox();
            this.homeAddressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fullNameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            idTeacherLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            identification_codeLabel = new System.Windows.Forms.Label();
            homeAddressLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingNavigator)).BeginInit();
            this.teachersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.dataSet1;
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
            // teachersBindingNavigator
            // 
            this.teachersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.teachersBindingNavigator.BindingSource = this.teachersBindingSource;
            this.teachersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teachersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.teachersBindingNavigatorSaveItem});
            this.teachersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teachersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teachersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teachersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teachersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teachersBindingNavigator.Name = "teachersBindingNavigator";
            this.teachersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teachersBindingNavigator.Size = new System.Drawing.Size(298, 25);
            this.teachersBindingNavigator.TabIndex = 0;
            this.teachersBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // idTeacherLabel
            // 
            idTeacherLabel.AutoSize = true;
            idTeacherLabel.Location = new System.Drawing.Point(52, 45);
            idTeacherLabel.Name = "idTeacherLabel";
            idTeacherLabel.Size = new System.Drawing.Size(75, 13);
            idTeacherLabel.TabIndex = 1;
            idTeacherLabel.Text = "Id викладача:";
            // 
            // idTeacherTextBox
            // 
            this.idTeacherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "IdTeacher", true));
            this.idTeacherTextBox.Location = new System.Drawing.Point(133, 42);
            this.idTeacherTextBox.Name = "idTeacherTextBox";
            this.idTeacherTextBox.Size = new System.Drawing.Size(159, 20);
            this.idTeacherTextBox.TabIndex = 2;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(63, 81);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(63, 13);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "Повне ім\'я:";
            // 
            // identification_codeLabel
            // 
            identification_codeLabel.AutoSize = true;
            identification_codeLabel.Location = new System.Drawing.Point(12, 143);
            identification_codeLabel.Name = "identification_codeLabel";
            identification_codeLabel.Size = new System.Drawing.Size(117, 13);
            identification_codeLabel.TabIndex = 5;
            identification_codeLabel.Text = "Ідентифікаційний код:";
            // 
            // identification_codeTextBox
            // 
            this.identification_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "Identification code", true));
            this.identification_codeTextBox.Location = new System.Drawing.Point(133, 140);
            this.identification_codeTextBox.Name = "identification_codeTextBox";
            this.identification_codeTextBox.Size = new System.Drawing.Size(159, 20);
            this.identification_codeTextBox.TabIndex = 6;
            this.identification_codeTextBox.TextChanged += new System.EventHandler(this.identification_codeTextBox_TextChanged);
            // 
            // homeAddressLabel
            // 
            homeAddressLabel.AutoSize = true;
            homeAddressLabel.Location = new System.Drawing.Point(23, 169);
            homeAddressLabel.Name = "homeAddressLabel";
            homeAddressLabel.Size = new System.Drawing.Size(104, 13);
            homeAddressLabel.TabIndex = 7;
            homeAddressLabel.Text = "Місце проживання:";
            // 
            // homeAddressTextBox
            // 
            this.homeAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "HomeAddress", true));
            this.homeAddressTextBox.Location = new System.Drawing.Point(133, 166);
            this.homeAddressTextBox.Name = "homeAddressTextBox";
            this.homeAddressTextBox.Size = new System.Drawing.Size(159, 20);
            this.homeAddressTextBox.TabIndex = 8;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(32, 195);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(95, 13);
            phoneNumberLabel.TabIndex = 9;
            phoneNumberLabel.Text = "Номер телефону:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(133, 192);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(159, 20);
            this.phoneNumberTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 218);
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
            this.fullNameRichTextBox.Location = new System.Drawing.Point(132, 68);
            this.fullNameRichTextBox.Name = "fullNameRichTextBox";
            this.fullNameRichTextBox.Size = new System.Drawing.Size(160, 40);
            this.fullNameRichTextBox.TabIndex = 12;
            this.fullNameRichTextBox.Text = "";
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Location = new System.Drawing.Point(75, 117);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(53, 13);
            passportLabel.TabIndex = 12;
            passportLabel.Text = "Паспорт:";
            // 
            // passportTextBox
            // 
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "Passport", true));
            this.passportTextBox.Location = new System.Drawing.Point(132, 114);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(160, 20);
            this.passportTextBox.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 246);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingNavigator)).EndInit();
            this.teachersBindingNavigator.ResumeLayout(false);
            this.teachersBindingNavigator.PerformLayout();
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
    }
}