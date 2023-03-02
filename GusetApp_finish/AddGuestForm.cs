using GuestApp.DataBase;
//using GuestApp_finish.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestApp_finish
{
    public partial class AddGuestForm : Form
    {
        private enum StatusOptions
        {
            Зарезервировал,
            Занял,
            Свободен
        }
        private enum PaymentStatus
        {
            Оплачено,
            Неоплачено
        }

        private static AddGuestForm instance = null;
        private Point pointCursor = new Point();
        private bool paymentStatus = false;

        private AddGuestForm()
        {
            InitializeComponent();
        }

        public static AddGuestForm GetInstance()
        {
            if (instance == null)
            {
                instance = new AddGuestForm();
            }
            return instance;
        }

        private void buttonToPay_Click(object sender, EventArgs e)
        {
            paymentStatus = true;
        }

        private void AddUser(string status)
        {
            bool exChek = false;
            string animal;
            string payment;
            if (this.checkBoxPresenceAnimals.Checked)
            {
                animal = "есть";
            }
            else
            {
                animal = "отсутствует";
            }
            if (paymentStatus)
            {
                payment = PaymentStatus.Оплачено.ToString();
            }
            else
            {
                payment = PaymentStatus.Неоплачено.ToString();
            }
            DateTime dateBirth = DateTime.Parse(this.dateTimePickerDateBirth.Text);
            DateTime dateStar = DateTime.Parse(this.dateTimePickerDateStar.Text);
            DateTime dateExit = DateTime.Parse(this.dateTimePickerDateExit.Text);
            string way = "";
            try
            {
                way = System.IO.Directory.GetCurrentDirectory() + $@"\profile_image\image_{DataBaseUsersLink.SELECT_CountUsers()}";
                pictureBoxPhoto.Image.Save(way);
            }
            catch (Exception)
            {
                MessageBox.Show("Добавьте фото!!!");
                way = null;
                exChek = true;
            }
            if (exChek == false) 
            {
                string insert = $"INSERT INTO [Users] (Name, Surname, Middlename, Status," +
$" Payment, DateBirth, DateStar, DateExit, PresenceAnimals, AdressPhoto) " +
$"VALUES(N'{this.textBoxName.Text}',N'{this.textBoxSurname.Text}'," +
$"N'{this.textBoxPatronymic.Text}',N'{status}',N'{payment}'," +
$"'{dateBirth.Month}/{dateBirth.Day}/{dateBirth.Year}'," +
$"'{dateStar.Month}/{dateStar.Day}/{dateStar.Year}'," +
$"'{dateExit.Month}/{dateExit.Day}/{dateExit.Year}', N'{animal}','{way}')";
                DataBaseUsersLink.AddUsersInfo(insert);
            }
            paymentStatus = false;
        }

        private void buttonToReserve_Click(object sender, EventArgs e)
        {
            AddUser(StatusOptions.Зарезервировал.ToString());
        }

        private void buttonToPopulate_Click(object sender, EventArgs e)
        {
            AddUser(StatusOptions.Занял.ToString());
        }

        private void buttonToAdd_Click(object sender, EventArgs e)
        {
            AddUser(StatusOptions.Свободен.ToString());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panelPhone_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - pointCursor.X;
                this.Top += e.Y - pointCursor.Y;
            }
        }


        private void panelPhone_MouseDown(object sender, MouseEventArgs e)
        {
            pointCursor = new Point(e.X, e.Y);
        }

        private void labelAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBoxPhoto.Image = Image.FromFile(openFileDialog1.FileName);
        }

    }
}
