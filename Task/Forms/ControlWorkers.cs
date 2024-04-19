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
    public partial class ControlWorkers : Form
    {
        private string _name = "";
        private int _solar = 0;

        public ControlWorkers()
        {
            InitializeComponent();
        }

        private void ControlWorkers_Load(object sender, EventArgs e)
        {
            if (PersonalControl.Workers is null || PersonalControl.Workers.Count < 1)
            {
                DisenabledBttn();
            }
            else
            {
                EnabledBttn();
                UpdateListBox(PersonalControl.Workers);
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

        private void UpdateListBox(List<Worker> workers)
        {
            if (workers is null || workers.Count < 1)
            {
                MessageBox.Show("Произошла непредвиденная ошибка. Повторите попытку.", "Ошибка");
                return;
            }

            for (int i = 0; i < workers.Count; i++)
            {
                listBox1.Items.Add($"{i + 1} раб.: {workers[i].Name} с зарплатой {workers[i].Salary}");
            }
        }

        private void SubscAllWk(List<Worker> workers, Director director)
        {
            if (workers is null || director is null)
            {
                MessageBox.Show("Произошла непредвиденная ошибка. Повторите попытку.", "Ошибка");
                return;
            }

            foreach (Worker worker in workers)
            {
                worker.SubscribeToDirector(director);
            }
        }

        private void DescAllWk(List<Worker> workers, Director director)
        {
            if (workers is null || director is null)
            {
                MessageBox.Show("Произошла непредвиденная ошибка. Повторите попытку.", "Ошибка");
                return;
            }

            foreach (Worker worker in workers)
            {
                worker.UnsubscribeToDirector(director);
            }
        }

        private void DelAllWk(List<Worker> workers)
        {
            if (workers is null || workers.Count < 1)
            {
                MessageBox.Show("Произошла непредвиденная ошибка. Повторите попытку.", "Ошибка");
                return;
            }

            workers.Clear();
        }

        private void BttnAcceptVal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(WorkWithTextBox.GetStringFromTextBox(textBox1, ref _name), "Результат");
            MessageBox.Show(WorkWithTextBox.GetIntFromTextBox(textBox2, ref _solar), "Результат");

            if (_solar > 0)
            {
                listBox1.Items.Clear();

                PersonalControl.Workers.Add(new Worker(_name, _solar));

                UpdateListBox(PersonalControl.Workers);
                EnabledBttn();
            }
        }

        private void BttnSubAllSt_Click(object sender, EventArgs e)
        {
            try
            {
                SubscAllWk(PersonalControl.Workers, PersonalControl.Direc);
                MessageBox.Show("Все работники подписаны на событие.", "Результат");
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
                DescAllWk(PersonalControl.Workers, PersonalControl.Direc);
                MessageBox.Show("Все работники отписаны от события.", "Результат");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void BttnShowAllSt_Click(object sender, EventArgs e)
        {
            UpdateListBox(PersonalControl.Workers);
        }

        private void BttnDelAllSt_Click(object sender, EventArgs e)
        {
            try
            {
                DelAllWk(PersonalControl.Workers);
                MessageBox.Show("Все рабочие были удалены", "Результат");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
