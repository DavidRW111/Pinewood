namespace CustomerApp
{
    partial class AddUpdateCustomerForm
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
            label1 = new Label();
            tbCustomerId = new TextBox();
            label2 = new Label();
            tbName = new TextBox();
            tbAddress = new TextBox();
            label3 = new Label();
            tbCity = new TextBox();
            label4 = new Label();
            tbPostCode = new TextBox();
            label5 = new Label();
            tbHomePhoneNumber = new TextBox();
            label6 = new Label();
            tbMobileNumber = new TextBox();
            label7 = new Label();
            btCancel = new Button();
            tbSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 27);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // tbCustomerId
            // 
            tbCustomerId.Location = new Point(209, 24);
            tbCustomerId.Name = "tbCustomerId";
            tbCustomerId.ReadOnly = true;
            tbCustomerId.Size = new Size(91, 27);
            tbCustomerId.TabIndex = 1;
            tbCustomerId.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 70);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(209, 67);
            tbName.Name = "tbName";
            tbName.Size = new Size(272, 27);
            tbName.TabIndex = 3;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(209, 110);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(381, 27);
            tbAddress.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 113);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 4;
            label3.Text = "Address";
            // 
            // tbCity
            // 
            tbCity.Location = new Point(209, 153);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(272, 27);
            tbCity.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(47, 156);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 6;
            label4.Text = "City";
            // 
            // tbPostCode
            // 
            tbPostCode.Location = new Point(209, 196);
            tbPostCode.Name = "tbPostCode";
            tbPostCode.Size = new Size(126, 27);
            tbPostCode.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(47, 199);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 8;
            label5.Text = "Post Code";
            // 
            // tbHomePhoneNumber
            // 
            tbHomePhoneNumber.Location = new Point(209, 239);
            tbHomePhoneNumber.Name = "tbHomePhoneNumber";
            tbHomePhoneNumber.Size = new Size(162, 27);
            tbHomePhoneNumber.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(47, 242);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 10;
            label6.Text = "Home Phone Number";
            // 
            // tbMobileNumber
            // 
            tbMobileNumber.Location = new Point(209, 282);
            tbMobileNumber.Name = "tbMobileNumber";
            tbMobileNumber.Size = new Size(162, 27);
            tbMobileNumber.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(47, 285);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 12;
            label7.Text = "Mobile Number";
            // 
            // btCancel
            // 
            btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btCancel.DialogResult = DialogResult.Cancel;
            btCancel.Location = new Point(579, 337);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(94, 29);
            btCancel.TabIndex = 14;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // tbSave
            // 
            tbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbSave.DialogResult = DialogResult.OK;
            tbSave.Location = new Point(462, 337);
            tbSave.Name = "tbSave";
            tbSave.Size = new Size(94, 29);
            tbSave.TabIndex = 15;
            tbSave.Text = "Save";
            tbSave.UseVisualStyleBackColor = true;
            tbSave.Click += tbSave_Click;
            // 
            // AddUpdateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 385);
            Controls.Add(tbSave);
            Controls.Add(btCancel);
            Controls.Add(tbMobileNumber);
            Controls.Add(label7);
            Controls.Add(tbHomePhoneNumber);
            Controls.Add(label6);
            Controls.Add(tbPostCode);
            Controls.Add(label5);
            Controls.Add(tbCity);
            Controls.Add(label4);
            Controls.Add(tbAddress);
            Controls.Add(label3);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(tbCustomerId);
            Controls.Add(label1);
            Name = "AddUpdateCustomerForm";
            Text = "AddUpdateCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbCustomerId;
        private Label label2;
        private TextBox tbName;
        private TextBox tbAddress;
        private Label label3;
        private TextBox tbCity;
        private Label label4;
        private TextBox tbPostCode;
        private Label label5;
        private TextBox tbHomePhoneNumber;
        private Label label6;
        private TextBox tbMobileNumber;
        private Label label7;
        private Button btCancel;
        private Button tbSave;
    }
}