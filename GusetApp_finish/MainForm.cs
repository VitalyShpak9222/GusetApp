using GuestApp.DataBase;
using GuestApp_finish;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestApp_finish
{
    public partial class MainForm : Form
    {
        private enum Status
        {
            Зарезервировал,
            Занял,
            Свободен,
            Выписывается
        }
        private string datebirth;
        private string payment;
        private int day;
        private bool animal;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            DataBaseUsersLink.Connect();
            DataBaseUsersLink.UpdateStatus();
            this.Location = new Point(0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime timenow = DateTime.Now;
            labelTime.Text = timenow.ToString("hh : mm : ss");
            if (int.Parse(timenow.ToString("HH")) > 12)
            {
                labelAmPm.Text = "PM";
            }
            else
            {
                labelAmPm.Text = "AM";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.panelMenu.Visible == true)
            {
                this.panelMenu.Visible = false;
                this.buttonAddGuest.Visible = false;
                this.buttonDeleteGuest.Visible = false;
                this.buttonExit.Visible = false;
            }
            else
            {
                this.panelMenu.Visible = true;
                this.buttonAddGuest.Visible = true;
                this.buttonDeleteGuest.Visible = true;
                this.buttonExit.Visible = true;
            }
        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            AddGuestForm addGuestForm = AddGuestForm.GetInstance();
            addGuestForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonStatus1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSort.DataSource = DataBaseUsersLink.SELECT_Definite_DataBase(Status.Зарезервировал.ToString()).Tables[0];
            labelListGuest.Text = "Список гостей";
        }

        private void radioButtonStatus2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSort.DataSource = DataBaseUsersLink.SELECT_Definite_DataBase(Status.Свободен.ToString()).Tables[0];
            labelListGuest.Text = "Список гостей";
        }

        private void radioButtonStatus3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSort.DataSource = DataBaseUsersLink.SELECT_Definite_DataBase(Status.Занял.ToString()).Tables[0];
            labelListGuest.Text = "Список гостей";
        }

        private void radioButtonStatus4_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSort.DataSource = DataBaseUsersLink.SELECT_Definite_DataBase(Status.Выписывается.ToString()).Tables[0];
            labelListGuest.Text = "Список гостей";
        }

        private void buttonDeleteGuest_Click(object sender, EventArgs e)
        {
            DeleteGuestForm deleteGuest = DeleteGuestForm.CreateDeleteGuestForm();
            deleteGuest.Show();
        }

        private void pictureBoxResearch_Click(object sender, EventArgs e)
        {
            dataGridViewSort.DataSource = DataBaseUsersLink.SELECT_Definite_DataBase(this.textBoxResearch.Text).Tables[0];
            labelListGuest.Text = "Результаты";
        }

        private void dataGridViewSort_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string date;
            int numLine = e.RowIndex;
            this.labelNumberID.Text = $"ID {dataGridViewSort.Rows[numLine].Cells[0].Value.ToString()}";
            string name = dataGridViewSort.Rows[numLine].Cells[1].Value.ToString();
            string surname = dataGridViewSort.Rows[numLine].Cells[2].Value.ToString();
            string middlename = dataGridViewSort.Rows[numLine].Cells[3].Value.ToString();
            this.labelSNM.Text = $"{surname} {name} {middlename}";
            this.labelStatusRiaght.Text = dataGridViewSort.Rows[numLine].Cells[4].Value.ToString();
            date = dataGridViewSort.Rows[numLine].Cells[7].Value.ToString();
            DateTime star = DateTime.Parse(date);
            this.labelDateStar.Text = date.Substring(0, date.Length - 8);
            date = dataGridViewSort.Rows[numLine].Cells[8].Value.ToString();
            DateTime exit = DateTime.Parse(date);
            this.labelDateExit.Text = date.Substring(0, date.Length - 8);
            string way = dataGridViewSort.Rows[numLine].Cells[10].Value.ToString();
            pictureBoxRight.Image = Image.FromFile(way);
            datebirth = dataGridViewSort.Rows[numLine].Cells[6].Value.ToString();
            datebirth = datebirth.Substring(0, datebirth.Length - 8);
            payment = dataGridViewSort.Rows[numLine].Cells[5].Value.ToString();
            day = (exit - star).Days;
            if (dataGridViewSort.Rows[numLine].Cells[9].Value.ToString().Length > 4)
            {
                animal = false;
            }
            else
            {
                animal = true;
            }
            //MessageBox.Show(way);
            //pictureBoxRight.Load(way);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            CardGuestForm card = new CardGuestForm();
            card.AddValue(this.labelSNM.Text, datebirth, payment, day, animal);
            card.Show();
        }
    }
}
