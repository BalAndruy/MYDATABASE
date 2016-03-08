using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void listOfStudyingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.listOfStudyingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet3);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.dataSet3.Courses);
            // TODO: This line of code loads data into the 'dataSet3.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.dataSet3.Teachers);
            // TODO: This line of code loads data into the 'dataSet3.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.dataSet3.Students);
            // TODO: This line of code loads data into the 'dataSet3.ListOfStudying' table. You can move, or remove it, as needed.
            this.listOfStudyingTableAdapter.Fill(this.dataSet3.ListOfStudying);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fillByListStdToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.listOfStudyingTableAdapter.FillByNewList(this.dataSet3.ListOfStudying);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void searchLIstStdToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillByNewListToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void searchNewLIStToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.listOfStudyingTableAdapter.SearchNewLISt(this.dataSet3.ListOfStudying, idListToolStripTextBox.Text, idCourseToolStripTextBox.Text, idStudentToolStripTextBox.Text, idTeacherToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
