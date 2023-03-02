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
    public partial class CardGuestForm : Form
    {
        private enum PaymentStatus
        {
            Оплачено,
            Неоплачено
        }

        public CardGuestForm()
        {
            InitializeComponent();
        }

        public void AddValue(string SNM, string textDateBirth, string payment, int countDay, bool animal)
        {
            this.labelSNM.Text = SNM;
            this.labelDateBirth.Text = textDateBirth;
            this.labelPaymentStatus.Text = payment;
            this.labelDay.Text = countDay.ToString();
            this.checkBoxAnimals.Checked = animal;
        }

        private void pictureBoxDayUP_Click(object sender, EventArgs e)
        {
            this.labelDay.Text = (int.Parse(this.labelDay.Text) + 1).ToString();
        }

        private void pictureBoxDayDown_Click(object sender, EventArgs e)
        {
            this.labelDay.Text = (int.Parse(this.labelDay.Text) - 1).ToString();
        }

        private void pictureBoxМariantPayment_Click(object sender, EventArgs e)
        {
            if (this.labelPaymentStatus.Text == PaymentStatus.Оплачено.ToString())
            {
                this.labelPaymentStatusNew.Text = PaymentStatus.Неоплачено.ToString();
            }
            else if (this.labelPaymentStatus.Text == PaymentStatus.Неоплачено.ToString())
            {
                this.labelPaymentStatusNew.Text = PaymentStatus.Оплачено.ToString();
            }

            if (this.labelPaymentStatusNew.Visible)
            {
                this.labelPaymentStatusNew.Visible = false;
            }
            else
            {
                this.labelPaymentStatusNew.Visible = true;
            }
        }

        private void labelPaymentStatusNew_Click(object sender, EventArgs e)
        {
            this.labelPaymentStatusNew.Visible = false;
            this.labelPaymentStatus.Text = this.labelPaymentStatusNew.Text;
        }
    }
}
