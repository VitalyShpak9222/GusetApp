namespace GuestApp_finish
{
    partial class DeleteGuestForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonCategoryID = new System.Windows.Forms.RadioButton();
            this.radioButtonCategoryMidllename = new System.Windows.Forms.RadioButton();
            this.radioButtonCategorySurname = new System.Windows.Forms.RadioButton();
            this.radioButtonCategoryName = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxResearchLine = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelClose = new System.Windows.Forms.Label();
            this.panelPhone.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPhone
            // 
            this.panelPhone.BackColor = System.Drawing.Color.DarkGray;
            this.panelPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPhone.Controls.Add(this.tableLayoutPanel1);
            this.panelPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhone.Location = new System.Drawing.Point(0, 0);
            this.panelPhone.Name = "panelPhone";
            this.panelPhone.Size = new System.Drawing.Size(600, 240);
            this.panelPhone.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelClose, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 238);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseMove);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonCategoryID, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonCategoryMidllename, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonCategorySurname, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonCategoryName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(481, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(114, 209);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // radioButtonCategoryID
            // 
            this.radioButtonCategoryID.AutoSize = true;
            this.radioButtonCategoryID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCategoryID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonCategoryID.Location = new System.Drawing.Point(3, 167);
            this.radioButtonCategoryID.Name = "radioButtonCategoryID";
            this.radioButtonCategoryID.Size = new System.Drawing.Size(108, 39);
            this.radioButtonCategoryID.TabIndex = 3;
            this.radioButtonCategoryID.TabStop = true;
            this.radioButtonCategoryID.Text = "id";
            this.radioButtonCategoryID.UseVisualStyleBackColor = true;
            this.radioButtonCategoryID.CheckedChanged += new System.EventHandler(this.radioButtonCategoryID_CheckedChanged);
            // 
            // radioButtonCategoryMidllename
            // 
            this.radioButtonCategoryMidllename.AutoSize = true;
            this.radioButtonCategoryMidllename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCategoryMidllename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonCategoryMidllename.Location = new System.Drawing.Point(3, 126);
            this.radioButtonCategoryMidllename.Name = "radioButtonCategoryMidllename";
            this.radioButtonCategoryMidllename.Size = new System.Drawing.Size(108, 35);
            this.radioButtonCategoryMidllename.TabIndex = 2;
            this.radioButtonCategoryMidllename.TabStop = true;
            this.radioButtonCategoryMidllename.Text = "Отчество";
            this.radioButtonCategoryMidllename.UseVisualStyleBackColor = true;
            this.radioButtonCategoryMidllename.CheckedChanged += new System.EventHandler(this.radioButtonCategoryMidllename_CheckedChanged);
            // 
            // radioButtonCategorySurname
            // 
            this.radioButtonCategorySurname.AutoSize = true;
            this.radioButtonCategorySurname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCategorySurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonCategorySurname.Location = new System.Drawing.Point(3, 85);
            this.radioButtonCategorySurname.Name = "radioButtonCategorySurname";
            this.radioButtonCategorySurname.Size = new System.Drawing.Size(108, 35);
            this.radioButtonCategorySurname.TabIndex = 1;
            this.radioButtonCategorySurname.TabStop = true;
            this.radioButtonCategorySurname.Text = "Фамилия";
            this.radioButtonCategorySurname.UseVisualStyleBackColor = true;
            this.radioButtonCategorySurname.CheckedChanged += new System.EventHandler(this.radioButtonCategorySurname_CheckedChanged);
            // 
            // radioButtonCategoryName
            // 
            this.radioButtonCategoryName.AutoSize = true;
            this.radioButtonCategoryName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCategoryName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonCategoryName.Location = new System.Drawing.Point(3, 44);
            this.radioButtonCategoryName.Name = "radioButtonCategoryName";
            this.radioButtonCategoryName.Size = new System.Drawing.Size(108, 35);
            this.radioButtonCategoryName.TabIndex = 0;
            this.radioButtonCategoryName.TabStop = true;
            this.radioButtonCategoryName.Text = "Имя";
            this.radioButtonCategoryName.UseVisualStyleBackColor = true;
            this.radioButtonCategoryName.CheckedChanged += new System.EventHandler(this.radioButtonCategoryName_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Категории";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxResearchLine, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(472, 209);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // textBoxResearchLine
            // 
            this.textBoxResearchLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResearchLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResearchLine.Location = new System.Drawing.Point(3, 3);
            this.textBoxResearchLine.Name = "textBoxResearchLine";
            this.textBoxResearchLine.Size = new System.Drawing.Size(466, 22);
            this.textBoxResearchLine.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(466, 172);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // labelClose
            // 
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClose.Location = new System.Drawing.Point(571, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(24, 23);
            this.labelClose.TabIndex = 2;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // DeleteGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 240);
            this.Controls.Add(this.panelPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteGuestForm";
            this.Text = "DeleteGuestForm";
            this.panelPhone.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButtonCategoryID;
        private System.Windows.Forms.RadioButton radioButtonCategoryMidllename;
        private System.Windows.Forms.RadioButton radioButtonCategorySurname;
        private System.Windows.Forms.RadioButton radioButtonCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResearchLine;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Panel panelPhone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}