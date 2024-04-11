namespace NetGroupProject
{
    partial class User_Management
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
            this.User_info = new System.Windows.Forms.GroupBox();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.Information = new System.Windows.Forms.GroupBox();
            this.position = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.user_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.User_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // User_info
            // 
            this.User_info.Controls.Add(this.dataview);
            this.User_info.Location = new System.Drawing.Point(31, 22);
            this.User_info.Name = "User_info";
            this.User_info.Size = new System.Drawing.Size(763, 262);
            this.User_info.TabIndex = 0;
            this.User_info.TabStop = false;
            this.User_info.Text = "User information";
            // 
            // dataview
            // 
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Location = new System.Drawing.Point(3, 22);
            this.dataview.Name = "dataview";
            this.dataview.RowTemplate.Height = 28;
            this.dataview.Size = new System.Drawing.Size(754, 234);
            this.dataview.TabIndex = 0;
            this.dataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataview_CellContentClick);
            // 
            // Information
            // 
            this.Information.Controls.Add(this.position);
            this.Information.Controls.Add(this.salary);
            this.Information.Controls.Add(this.pass);
            this.Information.Controls.Add(this.email);
            this.Information.Controls.Add(this.phone);
            this.Information.Controls.Add(this.address);
            this.Information.Controls.Add(this.name);
            this.Information.Controls.Add(this.user_id);
            this.Information.Controls.Add(this.label1);
            this.Information.Controls.Add(this.label2);
            this.Information.Controls.Add(this.label3);
            this.Information.Controls.Add(this.label4);
            this.Information.Controls.Add(this.label5);
            this.Information.Controls.Add(this.label6);
            this.Information.Controls.Add(this.label7);
            this.Information.Controls.Add(this.label8);
            this.Information.Location = new System.Drawing.Point(34, 328);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(754, 219);
            this.Information.TabIndex = 1;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // position
            // 
            this.position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.position.Location = new System.Drawing.Point(478, 179);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(164, 26);
            this.position.TabIndex = 17;
            // 
            // salary
            // 
            this.salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salary.Location = new System.Drawing.Point(478, 135);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(164, 26);
            this.salary.TabIndex = 16;
            // 
            // pass
            // 
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Location = new System.Drawing.Point(478, 92);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(164, 26);
            this.pass.TabIndex = 15;
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Location = new System.Drawing.Point(478, 50);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(164, 26);
            this.email.TabIndex = 14;
            // 
            // phone
            // 
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Location = new System.Drawing.Point(139, 179);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(164, 26);
            this.phone.TabIndex = 13;
            this.phone.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // address
            // 
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Location = new System.Drawing.Point(139, 135);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(164, 26);
            this.address.TabIndex = 12;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(139, 92);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(164, 26);
            this.name.TabIndex = 11;
            // 
            // user_id
            // 
            this.user_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_id.Location = new System.Drawing.Point(139, 50);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(164, 26);
            this.user_id.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Position_id";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(113, 563);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(268, 563);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 42);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(421, 563);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 42);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(577, 563);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 42);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 627);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.User_info);
            this.Name = "User_Management";
            this.Text = "User_Management";
            this.Load += new System.EventHandler(this.User_Management_Load);
            this.User_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox User_info;
        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}