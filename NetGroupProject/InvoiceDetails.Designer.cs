﻿namespace NetGroupProject
{
    partial class InvoiceDetails
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
            this.dgvInvoiceDetailsList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupProjectDataSet1 = new NetGroupProject.groupProjectDataSet1();
            this.foodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodsTableAdapter = new NetGroupProject.groupProjectDataSet1TableAdapters.foodsTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetailsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoiceDetailsList
            // 
            this.dgvInvoiceDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetailsList.Location = new System.Drawing.Point(71, 57);
            this.dgvInvoiceDetailsList.Name = "dgvInvoiceDetailsList";
            this.dgvInvoiceDetailsList.Size = new System.Drawing.Size(276, 133);
            this.dgvInvoiceDetailsList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(103, 243);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(121, 20);
            this.tbQuantity.TabIndex = 4;
            this.tbQuantity.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cbFood
            // 
            this.cbFood.DataSource = this.foodsBindingSource;
            this.cbFood.DisplayMember = "food_name";
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(103, 212);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(121, 21);
            this.cbFood.TabIndex = 5;
            this.cbFood.ValueMember = "food_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Invoice Details";
            // 
            // groupProjectDataSet1
            // 
            this.groupProjectDataSet1.DataSetName = "groupProjectDataSet1";
            this.groupProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodsBindingSource
            // 
            this.foodsBindingSource.DataMember = "foods";
            this.foodsBindingSource.DataSource = this.groupProjectDataSet1;
            // 
            // foodsTableAdapter
            // 
            this.foodsTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(272, 206);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(272, 233);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(272, 262);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // InvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 312);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFood);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInvoiceDetailsList);
            this.Name = "InvoiceDetails";
            this.Text = "InvoiceDetails";
            this.Load += new System.EventHandler(this.InvoiceDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetailsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoiceDetailsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.Label label3;
        private groupProjectDataSet1 groupProjectDataSet1;
        private System.Windows.Forms.BindingSource foodsBindingSource;
        private groupProjectDataSet1TableAdapters.foodsTableAdapter foodsTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}