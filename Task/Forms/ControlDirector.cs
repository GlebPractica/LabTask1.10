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
    public partial class ControlDirector : Form
    {
        public ControlDirector()
        {
            InitializeComponent();
        }
        private void ControlDirector_Load(object sender, EventArgs e)
        {
            UpdateListBox(listBox1, PersonalControl.Students, PersonalControl.Workers);
        }

        private void UpdateListBox(ListBox listBox, List<Student> students, List<Worker> workers)
        {
            if (listBox == null || students == null || workers == null)
            {
                MessageBox.Show("Произошла непредвиденная ошибка. Повторите попытку.", "Ошибка");
                return;
            }

            listBox.Items.Clear();

            if (students.Count > 0)
            {
                listBox.Items.Add("Студенты:");

                for (int i = 0; i < students.Count; i++)
                {
                    listBox.Items.Add($"{i + 1} студ.: {students[i].Name} с стипендией {students[i].Scholarship}");
                }
            }
            else
            {
                MessageBox.Show("Похоже вы не добавляли студентов.", "Результат");
            }

            if (workers.Count > 0)
            {
                listBox.Items.Add("Рабочие:");

                for (int i = 0; i < workers.Count; i++)
                {
                    listBox.Items.Add($"{i + 1} раб.: {workers[i].Name} с зарплатой {workers[i].Salary}");
                }
            }
            else
            {
                MessageBox.Show("Похоже вы не добавляли рабочих.", "Результат");
            }
        }

        private void BttnPromote_Click(object sender, EventArgs e)
        {
            if (PersonalControl.Direc == null)
            {
                MessageBox.Show("Произошла ошибка. Повторите попытку.", "Ошибка");
                return;
            }

            if (PersonalControl.Direc.promote == null)
            {
                MessageBox.Show("Никто не подписан на директора.", "Ошибка");
                return;
            }

            if (int.TryParse(textBox1.Text, out int amount))
            {
                MessageBox.Show(PersonalControl.Direc.Promote(amount), "Результат");
                UpdateListBox(listBox1, PersonalControl.Students, PersonalControl.Workers);
            }
            else
            {
                MessageBox.Show($"Неверно написано число. Повторите попытку.\nТекущий результат: {textBox1.Text}", "Ошибка");
                return;
            }
        }

        private void BttnPenalize_Click(object sender, EventArgs e)
        {
            if (PersonalControl.Direc == null)
            {
                MessageBox.Show("Произошла ошибка. Повторите попытку.", "Ошибка");
                return;
            }

            if (PersonalControl.Direc.penalize == null)
            {
                MessageBox.Show("Никто не подписан на директора.", "Ошибка");
                return;
            }

            if (int.TryParse(textBox2.Text, out int amount))
            {
                MessageBox.Show(PersonalControl.Direc.Penalize(amount), "Результат");
                UpdateListBox(listBox1, PersonalControl.Students, PersonalControl.Workers);
            }
            else
            {
                MessageBox.Show($"Неверно написано число. Повторите попытку.\nТекущий результат: {textBox2.Text}", "Ошибка");
                return;
            }
        }
    }
}
