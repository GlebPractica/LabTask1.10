using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class ControlStudents : Form
    {
        private string _name = "";
        private int _scholarship = 0;

        public ControlStudents()
        {
            InitializeComponent();
        }

        private void ControlStudents_Load(object sender, EventArgs e)
        {
            if (PersonalControl.Students is null || PersonalControl.Students.Count < 1)
            {
                DisenabledBttn();
            }
            else
            {
                EnabledBttn();
                UpdateListBox(PersonalControl.Students);
            }
        }

        private void DisenabledBttn()
        {
            BttnSubAllSt.Enabled = false;
            BttnDescAllSt.Enabled = false;
            BttnShowAllSt.Enabled = false;
            BttnDelAllSt.Enabled = false;
        }

        private void EnabledBttn()
        {
            BttnSubAllSt.Enabled = true;
            BttnDescAllSt.Enabled = true;
            BttnShowAllSt.Enabled = true;
            BttnDelAllSt.Enabled = true;
        }

        private void UpdateListBox(List<Student> students)
        {
            if (students is null || students.Count < 1)
            {
                MessageBox.Show("Произошла непредвиденная ошибка. Повторите попытку.", "Ошибка");
                return;
            }

            for (int i = 0; i < students.Count; i++)
            {
                listBox1.Items.Add($"{i + 1} студ.: {students[i].Name} с стипендией {students[i].Scholarship}");
            }
        }

        private void SubscAllSt(List<Student> students, Director director)
        {
            if (students is null || director is null)
            {
                MessageBox.Show("Произошла непредвиденная ошибка. Повторите попытку.", "Ошибка");
                return;
            }

            foreach (Student student in students)
            {
                student.SubscribeToDirector(director);
            }
        }

        private void DescAllSt(List<Student> students, Director director)
        {
            if (students is null || director is null)
            {
                MessageBox.Show("Произошла непредвиденная ошибка. Повторите попытку.", "Ошибка");
                return;
            }

            foreach (Student student in students)
            {
                student.UnsubscribeToDirector(director);
            }
        }

        private void DelAllSt(List<Student> students)
        {
            if (students is null || students.Count < 1)
            {
                MessageBox.Show("Произошла непредвиденная ошибка. Повторите попытку.", "Ошибка");
                return;
            }

            students.Clear();
        }

        private void BttnAcceptVal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(WorkWithTextBox.GetStringFromTextBox(textBox1, ref _name), "Результат");
            MessageBox.Show(WorkWithTextBox.GetIntFromTextBox(textBox2, ref _scholarship), "Результат");

            if (_scholarship > 0)
            {
                listBox1.Items.Clear();

                PersonalControl.Students.Add(new Student(_name, _scholarship));

                UpdateListBox(PersonalControl.Students);
                EnabledBttn();
            }
        }

        private void BttnSubAllSt_Click(object sender, EventArgs e)
        {
            try
            {
                SubscAllSt(PersonalControl.Students, PersonalControl.Direc);
                MessageBox.Show("Все студенты подписаны на событие.", "Результат");
                BttnSubAllSt.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                BttnSubAllSt.Enabled = true;
            }
        }

        private void BttnDescAllSt_Click(object sender, EventArgs e)
        {
            try
            {
                DescAllSt(PersonalControl.Students, PersonalControl.Direc);
                MessageBox.Show("Все студенты отписаны от события.", "Результат");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void BttnShowAllSt_Click(object sender, EventArgs e)
        {
            UpdateListBox(PersonalControl.Students);
        }

        private void BttnDelAllSt_Click(object sender, EventArgs e)
        {
            try
            {
                DelAllSt(PersonalControl.Students);
                MessageBox.Show("Все студенты были удалены", "Результат");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
