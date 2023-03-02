namespace GuestApp_finish
{
    partial class AddGuestForm
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
            this.panelPhone = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDateExit = new System.Windows.Forms.Label();
            this.labelDateStar = new System.Windows.Forms.Label();
            this.labelDateBirth = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelAddPhoto = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonToAdd = new System.Windows.Forms.Button();
            this.buttonToPopulate = new System.Windows.Forms.Button();
            this.buttonToReserve = new System.Windows.Forms.Button();
            this.buttonToPay = new System.Windows.Forms.Button();
            this.dateTimePickerDateExit = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateStar = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateBirth = new System.Windows.Forms.DateTimePicker();
            this.checkBoxPresenceAnimals = new System.Windows.Forms.CheckBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.panelPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPhone
            // 
            this.panelPhone.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPhone.Controls.Add(this.buttonExit);
            this.panelPhone.Controls.Add(this.labelDateExit);
            this.panelPhone.Controls.Add(this.labelDateStar);
            this.panelPhone.Controls.Add(this.labelDateBirth);
            this.panelPhone.Controls.Add(this.labelPatronymic);
            this.panelPhone.Controls.Add(this.labelAddPhoto);
            this.panelPhone.Controls.Add(this.labelSurname);
            this.panelPhone.Controls.Add(this.labelName);
            this.panelPhone.Controls.Add(this.buttonToAdd);
            this.panelPhone.Controls.Add(this.buttonToPopulate);
            this.panelPhone.Controls.Add(this.buttonToReserve);
            this.panelPhone.Controls.Add(this.buttonToPay);
            this.panelPhone.Controls.Add(this.dateTimePickerDateExit);
            this.panelPhone.Controls.Add(this.dateTimePickerDateStar);
            this.panelPhone.Controls.Add(this.dateTimePickerDateBirth);
            this.panelPhone.Controls.Add(this.checkBoxPresenceAnimals);
            this.panelPhone.Controls.Add(this.textBoxPatronymic);
            this.panelPhone.Controls.Add(this.textBoxSurname);
            this.panelPhone.Controls.Add(this.textBoxName);
            this.panelPhone.Controls.Add(this.pictureBoxPhoto);
            this.panelPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhone.Location = new System.Drawing.Point(0, 0);
            this.panelPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPhone.Name = "panelPhone";
            this.panelPhone.Size = new System.Drawing.Size(400, 738);
            this.panelPhone.TabIndex = 0;
            this.panelPhone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPhone_MouseDown);
            this.panelPhone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPhone_MouseMove);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(67, 689);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(267, 28);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "Закрыть ";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelDateExit
            // 
            this.labelDateExit.AutoSize = true;
            this.labelDateExit.Location = new System.Drawing.Point(63, 466);
            this.labelDateExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateExit.Name = "labelDateExit";
            this.labelDateExit.Size = new System.Drawing.Size(91, 16);
            this.labelDateExit.TabIndex = 18;
            this.labelDateExit.Text = "Дата выезда";
            // 
            // labelDateStar
            // 
            this.labelDateStar.AutoSize = true;
            this.labelDateStar.Location = new System.Drawing.Point(63, 418);
            this.labelDateStar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateStar.Name = "labelDateStar";
            this.labelDateStar.Size = new System.Drawing.Size(90, 16);
            this.labelDateStar.TabIndex = 17;
            this.labelDateStar.Text = "Дата заезда";
            // 
            // labelDateBirth
            // 
            this.labelDateBirth.AutoSize = true;
            this.labelDateBirth.Location = new System.Drawing.Point(63, 370);
            this.labelDateBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateBirth.Name = "labelDateBirth";
            this.labelDateBirth.Size = new System.Drawing.Size(106, 16);
            this.labelDateBirth.TabIndex = 16;
            this.labelDateBirth.Text = "Дата рождения";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(63, 322);
            this.labelPatronymic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(70, 16);
            this.labelPatronymic.TabIndex = 15;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelAddPhoto
            // 
            this.labelAddPhoto.AutoSize = true;
            this.labelAddPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAddPhoto.Location = new System.Drawing.Point(139, 201);
            this.labelAddPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddPhoto.Name = "labelAddPhoto";
            this.labelAddPhoto.Size = new System.Drawing.Size(107, 16);
            this.labelAddPhoto.TabIndex = 14;
            this.labelAddPhoto.Text = "Добавить фото";
            this.labelAddPhoto.Click += new System.EventHandler(this.labelAddPhoto_Click);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(63, 274);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(66, 16);
            this.labelSurname.TabIndex = 13;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(63, 226);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 16);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Имя";
            // 
            // buttonToAdd
            // 
            this.buttonToAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToAdd.Location = new System.Drawing.Point(67, 654);
            this.buttonToAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonToAdd.Name = "buttonToAdd";
            this.buttonToAdd.Size = new System.Drawing.Size(267, 28);
            this.buttonToAdd.TabIndex = 11;
            this.buttonToAdd.Text = "Добавить в списки ";
            this.buttonToAdd.UseVisualStyleBackColor = true;
            this.buttonToAdd.Click += new System.EventHandler(this.buttonToAdd_Click);
            // 
            // buttonToPopulate
            // 
            this.buttonToPopulate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToPopulate.Location = new System.Drawing.Point(67, 618);
            this.buttonToPopulate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonToPopulate.Name = "buttonToPopulate";
            this.buttonToPopulate.Size = new System.Drawing.Size(267, 28);
            this.buttonToPopulate.TabIndex = 10;
            this.buttonToPopulate.Text = "Заселить ";
            this.buttonToPopulate.UseVisualStyleBackColor = true;
            this.buttonToPopulate.Click += new System.EventHandler(this.buttonToPopulate_Click);
            // 
            // buttonToReserve
            // 
            this.buttonToReserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToReserve.Location = new System.Drawing.Point(67, 582);
            this.buttonToReserve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonToReserve.Name = "buttonToReserve";
            this.buttonToReserve.Size = new System.Drawing.Size(267, 28);
            this.buttonToReserve.TabIndex = 9;
            this.buttonToReserve.Text = "Зареззервировать";
            this.buttonToReserve.UseVisualStyleBackColor = true;
            this.buttonToReserve.Click += new System.EventHandler(this.buttonToReserve_Click);
            // 
            // buttonToPay
            // 
            this.buttonToPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToPay.Location = new System.Drawing.Point(67, 546);
            this.buttonToPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonToPay.Name = "buttonToPay";
            this.buttonToPay.Size = new System.Drawing.Size(267, 28);
            this.buttonToPay.TabIndex = 8;
            this.buttonToPay.Text = "Оплатить";
            this.buttonToPay.UseVisualStyleBackColor = true;
            this.buttonToPay.Click += new System.EventHandler(this.buttonToPay_Click);
            // 
            // dateTimePickerDateExit
            // 
            this.dateTimePickerDateExit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateExit.Location = new System.Drawing.Point(67, 486);
            this.dateTimePickerDateExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDateExit.Name = "dateTimePickerDateExit";
            this.dateTimePickerDateExit.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerDateExit.TabIndex = 7;
            // 
            // dateTimePickerDateStar
            // 
            this.dateTimePickerDateStar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateStar.Location = new System.Drawing.Point(67, 438);
            this.dateTimePickerDateStar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDateStar.Name = "dateTimePickerDateStar";
            this.dateTimePickerDateStar.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerDateStar.TabIndex = 6;
            // 
            // dateTimePickerDateBirth
            // 
            this.dateTimePickerDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateBirth.Location = new System.Drawing.Point(67, 390);
            this.dateTimePickerDateBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDateBirth.Name = "dateTimePickerDateBirth";
            this.dateTimePickerDateBirth.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerDateBirth.TabIndex = 5;
            // 
            // checkBoxPresenceAnimals
            // 
            this.checkBoxPresenceAnimals.AutoSize = true;
            this.checkBoxPresenceAnimals.Location = new System.Drawing.Point(67, 518);
            this.checkBoxPresenceAnimals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPresenceAnimals.Name = "checkBoxPresenceAnimals";
            this.checkBoxPresenceAnimals.Size = new System.Drawing.Size(153, 20);
            this.checkBoxPresenceAnimals.TabIndex = 4;
            this.checkBoxPresenceAnimals.Text = "Наличие животных";
            this.checkBoxPresenceAnimals.UseVisualStyleBackColor = true;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(67, 342);
            this.textBoxPatronymic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(265, 22);
            this.textBoxPatronymic.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(67, 294);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(265, 22);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(67, 246);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(265, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(100, 12);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(199, 184);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 0;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // AddGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 738);
            this.Controls.Add(this.panelPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddGuestForm";
            this.Text = "AddGuestForm";
            this.panelPhone.ResumeLayout(false);
            this.panelPhone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPhone;
        private System.Windows.Forms.Label labelDateExit;
        private System.Windows.Forms.Label labelDateStar;
        private System.Windows.Forms.Label labelDateBirth;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelAddPhoto;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonToAdd;
        private System.Windows.Forms.Button buttonToPopulate;
        private System.Windows.Forms.Button buttonToReserve;
        private System.Windows.Forms.Button buttonToPay;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateExit;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateStar;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateBirth;
        private System.Windows.Forms.CheckBox checkBoxPresenceAnimals;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonExit;
    }
}