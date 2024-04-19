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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                InitializeClasesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                Environment.Exit(1);
            }
        }

        private void InitializeClasesAsync()
        {
            InitDirector(new Director());
            InitListStudents(new List<Student>());
            InitListWorkers(new List<Worker>());
        }

        private void InitListWorkers(List<Worker> workers)
        {
            if (workers is null)
                throw new ArgumentNullException(nameof(workers), "Unkown argument. Try again.\nCode error: InitLstWrks");

            PersonalControl.Workers = workers;
        }

        private void InitListStudents(List<Student> students)
        {
            if (students is null)
                throw new ArgumentNullException(nameof(students), "Unkown argument. Try again.\nCode error: InitLstSts");

            PersonalControl.Students = students;
        }

        private void InitDirector(Director director)
        {
            if (director is null)
                throw new ArgumentNullException(nameof(director), "Unkown argument. Try again.\nCode error: InitDir");

            PersonalControl.Direc = director;
        }

        private async System.Threading.Tasks.Task OpenCDAsync()
        {
            BttnControlDirector.Enabled = false;

            using (Form controlDirector = new ControlDirector())
            {
                controlDirector.FormClosed += (sender, args) =>
                {
                    if (BttnControlDirector.InvokeRequired)
                        BttnControlDirector.Invoke(new MethodInvoker(() => BttnControlDirector.Enabled = true));
                    else
                        BttnControlDirector.Enabled = false;
                };

                await System.Threading.Tasks.Task.Run(() => controlDirector.ShowDialog());
            }
        }

        private async System.Threading.Tasks.Task OpenCWAsync()
        {
            BttnControlWorkers.Enabled = false;

            using (Form controlWorkers = new ControlWorkers())
            {
                controlWorkers.FormClosed += (sender, args) =>
                {
                    if (BttnControlWorkers.InvokeRequired)
                        BttnControlWorkers.Invoke(new MethodInvoker(() => BttnControlWorkers.Enabled = true));
                    else
                        BttnControlWorkers.Enabled = false;
                };

                await System.Threading.Tasks.Task.Run(() => controlWorkers.ShowDialog());
            }
        }

        private async System.Threading.Tasks.Task OpenCSAsync()
        {
            BttnControlStudents.Enabled = false;

            using (Form controlStudents = new ControlStudents())
            {

                controlStudents.FormClosed += (sender, args) =>
                {
                    if (BttnControlStudents.InvokeRequired)
                        BttnControlStudents.Invoke(new MethodInvoker(() => BttnControlStudents.Enabled = true));
                    else
                        BttnControlStudents.Enabled = true;
                };

                await System.Threading.Tasks.Task.Run(() => controlStudents.ShowDialog());
            }
        }

        private async void BttnControlStudents_Click(object sender, EventArgs e)
        {
            await OpenCSAsync();
        }

        private async void BttnControlWorkers_Click(object sender, EventArgs e)
        {
            await OpenCWAsync();
        }

        private async void BttnControlDirector_Click(object sender, EventArgs e)
        {
            await OpenCDAsync();
        }
    }
}
