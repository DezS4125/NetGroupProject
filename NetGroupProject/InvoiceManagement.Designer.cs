namespace NetGroupProject
{
    partial class InvoiceManagement
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.btnUpdateInvoice = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvInvoiceList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInvoiceID = new System.Windows.Forms.TextBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTotalMoney = new System.Windows.Forms.TextBox();
            this.btnEditInvoiceDetails = new System.Windows.Forms.Button();
            this.groupProjectDataSet = new NetGroupProject.groupProjectDataSet();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new NetGroupProject.groupProjectDataSetTableAdapters.invoicesTableAdapter();
            this.usersTable = new NetGroupProject.usersTable();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new NetGroupProject.usersTableTableAdapters.usersTableAdapter();
            this.tablesTable = new NetGroupProject.tablesTable();
            this.diningtablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dining_tablesTableAdapter = new NetGroupProject.tablesTableTableAdapters.dining_tablesTableAdapter();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningtablesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Management";
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.Location = new System.Drawing.Point(730, 283);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(102, 23);
            this.btnNewInvoice.TabIndex = 1;
            this.btnNewInvoice.Text = "New Invoice";
            this.btnNewInvoice.UseVisualStyleBackColor = true;
            this.btnNewInvoice.Click += new System.EventHandler(this.btnNewInvoiceClick);
            // 
            // btnUpdateInvoice
            // 
            this.btnUpdateInvoice.Enabled = false;
            this.btnUpdateInvoice.Location = new System.Drawing.Point(730, 354);
            this.btnUpdateInvoice.Name = "btnUpdateInvoice";
            this.btnUpdateInvoice.Size = new System.Drawing.Size(102, 23);
            this.btnUpdateInvoice.TabIndex = 2;
            this.btnUpdateInvoice.Text = "Update";
            this.btnUpdateInvoice.UseVisualStyleBackColor = true;
            this.btnUpdateInvoice.Click += new System.EventHandler(this.btnUpdate_click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(730, 388);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvInvoiceList
            // 
            this.dgvInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceList.Location = new System.Drawing.Point(181, 97);
            this.dgvInvoiceList.Name = "dgvInvoiceList";
            this.dgvInvoiceList.Size = new System.Drawing.Size(545, 152);
            this.dgvInvoiceList.TabIndex = 4;
            this.dgvInvoiceList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceList_CellEndEdit);
            this.dgvInvoiceList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoiceList_RowHeaderMouseClick);
            this.dgvInvoiceList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoiceList_RowHeaderMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Invoice ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Invoice Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Table ID";
            // 
            // tbInvoiceID
            // 
            this.tbInvoiceID.Location = new System.Drawing.Point(123, 290);
            this.tbInvoiceID.Name = "tbInvoiceID";
            this.tbInvoiceID.ReadOnly = true;
            this.tbInvoiceID.Size = new System.Drawing.Size(100, 20);
            this.tbInvoiceID.TabIndex = 9;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Location = new System.Drawing.Point(123, 326);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(200, 20);
            this.dtpInvoiceDate.TabIndex = 10;
            // 
            // cbUser
            // 
            this.cbUser.DataSource = this.usersBindingSource;
            this.cbUser.DisplayMember = "user_name";
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(123, 356);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(200, 21);
            this.cbUser.TabIndex = 11;
            this.cbUser.ValueMember = "user_id";
            // 
            // cbTable
            // 
            this.cbTable.DataSource = this.diningtablesBindingSource;
            this.cbTable.DisplayMember = "table_name";
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(123, 390);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(134, 21);
            this.cbTable.TabIndex = 12;
            this.cbTable.ValueMember = "table_id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total money";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Invoice details";
            // 
            // tbTotalMoney
            // 
            this.tbTotalMoney.Location = new System.Drawing.Point(511, 290);
            this.tbTotalMoney.Name = "tbTotalMoney";
            this.tbTotalMoney.Size = new System.Drawing.Size(155, 20);
            this.tbTotalMoney.TabIndex = 15;
            // 
            // btnEditInvoiceDetails
            // 
            this.btnEditInvoiceDetails.Location = new System.Drawing.Point(511, 323);
            this.btnEditInvoiceDetails.Name = "btnEditInvoiceDetails";
            this.btnEditInvoiceDetails.Size = new System.Drawing.Size(155, 23);
            this.btnEditInvoiceDetails.TabIndex = 16;
            this.btnEditInvoiceDetails.Text = "Edit Invoice Details";
            this.btnEditInvoiceDetails.UseVisualStyleBackColor = true;
            // 
            // groupProjectDataSet
            // 
            this.groupProjectDataSet.DataSetName = "groupProjectDataSet";
            this.groupProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "invoices";
            this.invoicesBindingSource.DataSource = this.groupProjectDataSet;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // usersTable
            // 
            this.usersTable.DataSetName = "usersTable";
            this.usersTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.usersTable;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tablesTable
            // 
            this.tablesTable.DataSetName = "tablesTable";
            this.tablesTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diningtablesBindingSource
            // 
            this.diningtablesBindingSource.DataMember = "dining_tables";
            this.diningtablesBindingSource.DataSource = this.tablesTable;
            // 
            // dining_tablesTableAdapter
            // 
            this.dining_tablesTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Enabled = false;
            this.btnAddInvoice.Location = new System.Drawing.Point(730, 318);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(102, 23);
            this.btnAddInvoice.TabIndex = 17;
            this.btnAddInvoice.Text = "Add";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // InvoiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 434);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.btnEditInvoiceDetails);
            this.Controls.Add(this.tbTotalMoney);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.tbInvoiceID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInvoiceList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateInvoice);
            this.Controls.Add(this.btnNewInvoice);
            this.Controls.Add(this.label1);
            this.Name = "InvoiceManagement";
            this.Text = "InvoiceManagement";
            this.Load += new System.EventHandler(this.InvoiceManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningtablesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.Button btnUpdateInvoice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvInvoiceList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInvoiceID;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTotalMoney;
        private System.Windows.Forms.Button btnEditInvoiceDetails;
        private groupProjectDataSet groupProjectDataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private groupProjectDataSetTableAdapters.invoicesTableAdapter invoicesTableAdapter;
        private usersTable usersTable;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private usersTableTableAdapters.usersTableAdapter usersTableAdapter;
        private tablesTable tablesTable;
        private System.Windows.Forms.BindingSource diningtablesBindingSource;
        private tablesTableTableAdapters.dining_tablesTableAdapter dining_tablesTableAdapter;
        private System.Windows.Forms.Button btnAddInvoice;
    }
}