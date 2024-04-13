namespace NetGroupProject

{

    partial class Menu_management
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.Information = new System.Windows.Forms.GroupBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.created_date = new System.Windows.Forms.DateTimePicker();
            this.menu_name = new System.Windows.Forms.TextBox();
            this.menu_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataview);
            this.groupBox1.Location = new System.Drawing.Point(42, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(465, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu information";
            // 
            // dataview
            // 
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Location = new System.Drawing.Point(4, 17);
            this.dataview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataview.Name = "dataview";
            this.dataview.RowTemplate.Height = 28;
            this.dataview.Size = new System.Drawing.Size(456, 125);
            this.dataview.TabIndex = 0;
            this.dataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataview_CellContentClick);
            // 
            // Information
            // 
            this.Information.Controls.Add(this.description);
            this.Information.Controls.Add(this.created_date);
            this.Information.Controls.Add(this.menu_name);
            this.Information.Controls.Add(this.menu_id);
            this.Information.Controls.Add(this.label4);
            this.Information.Controls.Add(this.label3);
            this.Information.Controls.Add(this.label2);
            this.Information.Controls.Add(this.label1);
            this.Information.Location = new System.Drawing.Point(46, 223);
            this.Information.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Information.Name = "Information";
            this.Information.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Information.Size = new System.Drawing.Size(486, 137);
            this.Information.TabIndex = 1;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(317, 63);
            this.description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(155, 57);
            this.description.TabIndex = 6;
            this.description.Text = "";
            // 
            // created_date
            // 
            this.created_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.created_date.Location = new System.Drawing.Point(317, 29);
            this.created_date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.created_date.Name = "created_date";
            this.created_date.Size = new System.Drawing.Size(91, 20);
            this.created_date.TabIndex = 5;
            // 
            // menu_name
            // 
            this.menu_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu_name.Location = new System.Drawing.Point(95, 55);
            this.menu_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menu_name.Name = "menu_name";
            this.menu_name.Size = new System.Drawing.Size(92, 20);
            this.menu_name.TabIndex = 4;
            // 
            // menu_id
            // 
            this.menu_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu_id.Location = new System.Drawing.Point(95, 27);
            this.menu_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menu_id.Name = "menu_id";
            this.menu_id.Size = new System.Drawing.Size(92, 20);
            this.menu_id.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Created_date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu_name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu_id";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(62, 382);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(178, 382);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 28);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(296, 382);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(413, 382);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Menu_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 417);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu_management";
            this.Text = "Menu_management";
            this.Load += new System.EventHandler(this.Menu_management_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion



        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.DataGridView dataview;

        private System.Windows.Forms.GroupBox Information;

        private System.Windows.Forms.RichTextBox description;

        private System.Windows.Forms.DateTimePicker created_date;

        private System.Windows.Forms.TextBox menu_name;

        private System.Windows.Forms.TextBox menu_id;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Button btnEdit;

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Button btnClear;

    }

}