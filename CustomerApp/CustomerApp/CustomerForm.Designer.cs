
namespace CustomerApp
{
    partial class CustomerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridCustomers = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            CustomerAddress = new DataGridViewTextBoxColumn();
            CustomerCity = new DataGridViewTextBoxColumn();
            CustomerPostcode = new DataGridViewTextBoxColumn();
            CustomerHomePhoneNumber = new DataGridViewTextBoxColumn();
            CustomerMobileNumber = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            btnDeleteCustomer = new Button();
            btnEditCustomer = new Button();
            btnAddNewCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCustomers).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridCustomers
            // 
            dataGridCustomers.AllowUserToAddRows = false;
            dataGridCustomers.AllowUserToDeleteRows = false;
            dataGridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCustomers.Columns.AddRange(new DataGridViewColumn[] { ID, CustomerName, CustomerAddress, CustomerCity, CustomerPostcode, CustomerHomePhoneNumber, CustomerMobileNumber });
            dataGridCustomers.Dock = DockStyle.Fill;
            dataGridCustomers.Location = new Point(0, 0);
            dataGridCustomers.MultiSelect = false;
            dataGridCustomers.Name = "dataGridCustomers";
            dataGridCustomers.ReadOnly = true;
            dataGridCustomers.RowHeadersWidth = 51;
            dataGridCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCustomers.Size = new Size(1050, 450);
            dataGridCustomers.TabIndex = 0;
            // 
            // ID
            // 
            ID.FillWeight = 10F;
            ID.HeaderText = "Customer ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // CustomerName
            // 
            CustomerName.FillWeight = 15F;
            CustomerName.HeaderText = "Name";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Width = 125;
            // 
            // CustomerAddress
            // 
            CustomerAddress.FillWeight = 30F;
            CustomerAddress.HeaderText = "Address";
            CustomerAddress.MinimumWidth = 6;
            CustomerAddress.Name = "CustomerAddress";
            CustomerAddress.ReadOnly = true;
            CustomerAddress.Width = 125;
            // 
            // CustomerCity
            // 
            CustomerCity.FillWeight = 15F;
            CustomerCity.HeaderText = "City";
            CustomerCity.MinimumWidth = 6;
            CustomerCity.Name = "CustomerCity";
            CustomerCity.ReadOnly = true;
            CustomerCity.Width = 125;
            // 
            // CustomerPostcode
            // 
            CustomerPostcode.FillWeight = 10F;
            CustomerPostcode.HeaderText = "Postcode";
            CustomerPostcode.MinimumWidth = 6;
            CustomerPostcode.Name = "CustomerPostcode";
            CustomerPostcode.ReadOnly = true;
            CustomerPostcode.Width = 125;
            // 
            // CustomerHomePhoneNumber
            // 
            CustomerHomePhoneNumber.FillWeight = 10F;
            CustomerHomePhoneNumber.HeaderText = "Home Phone Number";
            CustomerHomePhoneNumber.MinimumWidth = 6;
            CustomerHomePhoneNumber.Name = "CustomerHomePhoneNumber";
            CustomerHomePhoneNumber.ReadOnly = true;
            CustomerHomePhoneNumber.Width = 125;
            // 
            // CustomerMobileNumber
            // 
            CustomerMobileNumber.FillWeight = 10F;
            CustomerMobileNumber.HeaderText = "Mobile Phone Number";
            CustomerMobileNumber.MinimumWidth = 6;
            CustomerMobileNumber.Name = "CustomerMobileNumber";
            CustomerMobileNumber.ReadOnly = true;
            CustomerMobileNumber.Width = 125;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridCustomers);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 450);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDeleteCustomer);
            panel2.Controls.Add(btnEditCustomer);
            panel2.Controls.Add(btnAddNewCustomer);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 356);
            panel2.Name = "panel2";
            panel2.Size = new Size(1050, 94);
            panel2.TabIndex = 2;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Anchor = AnchorStyles.Right;
            btnDeleteCustomer.Location = new Point(892, 36);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(133, 29);
            btnDeleteCustomer.TabIndex = 2;
            btnDeleteCustomer.Text = "Delete Customer";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Anchor = AnchorStyles.Right;
            btnEditCustomer.Location = new Point(730, 36);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(133, 29);
            btnEditCustomer.TabIndex = 1;
            btnEditCustomer.Text = "Edit Customer";
            btnEditCustomer.UseVisualStyleBackColor = true;
            btnEditCustomer.Click += btnUpdateCustomer_Click;
            // 
            // btnAddNewCustomer
            // 
            btnAddNewCustomer.Anchor = AnchorStyles.Right;
            btnAddNewCustomer.Location = new Point(568, 36);
            btnAddNewCustomer.Name = "btnAddNewCustomer";
            btnAddNewCustomer.Size = new Size(133, 29);
            btnAddNewCustomer.TabIndex = 0;
            btnAddNewCustomer.Text = "New Customer";
            btnAddNewCustomer.UseVisualStyleBackColor = true;
            btnAddNewCustomer.Click += btnAddNewCustomer_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)dataGridCustomers).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridCustomers;
        private Panel panel1;
        private Panel panel2;
        private Button btnDeleteCustomer;
        private Button btnEditCustomer;
        private Button btnAddNewCustomer;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CustomerAddress;
        private DataGridViewTextBoxColumn CustomerCity;
        private DataGridViewTextBoxColumn CustomerPostcode;
        private DataGridViewTextBoxColumn CustomerHomePhoneNumber;
        private DataGridViewTextBoxColumn CustomerMobileNumber;
    }
}
