using GuestApp.DataBase;
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
    public partial class DeleteGuestForm : Form
    {
        private static DeleteGuestForm instance = null;
        private Point pointCursor = new Point();

        private DeleteGuestForm()
        {
            InitializeComponent();
        }

        public static DeleteGuestForm CreateDeleteGuestForm()
        {
            if (instance == null)
            {
                instance = new DeleteGuestForm();
            }
            return instance;
        }


        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DeleteUsers(string category)
        {
            DataBaseUsersLink.Delete(category, textBoxResearchLine.Text);
        }

        private void radioButtonCategoryName_CheckedChanged(object sender, EventArgs e)
        {
            DeleteUsers("Name");
        }

        private void radioButtonCategorySurname_CheckedChanged(object sender, EventArgs e)
        {
            DeleteUsers("Surname");
        }

        private void radioButtonCategoryMidllename_CheckedChanged(object sender, EventArgs e)
        {
            DeleteUsers("Middlename");
        }

        private void radioButtonCategoryID_CheckedChanged(object sender, EventArgs e)
        {
            DeleteUsers("id");
        }

        private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - pointCursor.X;
                this.Top += e.Y - pointCursor.Y;
            }
        }

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            pointCursor = new Point(e.X, e.Y);
        }
    }
}
