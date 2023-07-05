using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.prodiDataSet1 = new Disconnected_Environment.prodiDataSet1();
            this.prodiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prodiDataSet = new Disconnected_Environment.prodiDataSet();
            this.prodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodiTableAdapter = new Disconnected_Environment.prodiDataSetTableAdapters.prodiTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.nmp = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.prodiTableAdapter1 = new Disconnected_Environment.prodiDataSet1TableAdapters.prodiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodiDataGridViewTextBoxColumn,
            this.namaprodiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prodiBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(222, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(300, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idprodiDataGridViewTextBoxColumn
            // 
            this.idprodiDataGridViewTextBoxColumn.DataPropertyName = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.HeaderText = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idprodiDataGridViewTextBoxColumn.Name = "idprodiDataGridViewTextBoxColumn";
            this.idprodiDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaprodiDataGridViewTextBoxColumn
            // 
            this.namaprodiDataGridViewTextBoxColumn.DataPropertyName = "nama_prodi";
            this.namaprodiDataGridViewTextBoxColumn.HeaderText = "nama_prodi";
            this.namaprodiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaprodiDataGridViewTextBoxColumn.Name = "namaprodiDataGridViewTextBoxColumn";
            this.namaprodiDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodiBindingSource2
            // 
            this.prodiBindingSource2.DataMember = "prodi";
            this.prodiBindingSource2.DataSource = this.prodiDataSet1;
            // 
            // prodiDataSet1
            // 
            this.prodiDataSet1.DataSetName = "prodiDataSet1";
            this.prodiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodiBindingSource1
            // 
            this.prodiBindingSource1.DataMember = "prodi";
            this.prodiBindingSource1.DataSource = this.prodiDataSet1;
            // 
            // prodiDataSet
            // 
            this.prodiDataSet.DataSetName = "prodiDataSet";
            this.prodiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodiBindingSource
            // 
            this.prodiBindingSource.DataMember = "prodi";
            this.prodiBindingSource.DataSource = this.prodiDataSet;
            // 
            // prodiTableAdapter
            // 
            this.prodiTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Prodi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nmp
            // 
            this.nmp.Location = new System.Drawing.Point(330, 232);
            this.nmp.Name = "nmp";
            this.nmp.Size = new System.Drawing.Size(192, 22);
            this.nmp.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(557, 37);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(557, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(447, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(330, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // prodiTableAdapter1
            // 
            this.prodiTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.nmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Data Prodi";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private prodiDataSet prodiDataSet;
        private System.Windows.Forms.BindingSource prodiBindingSource;
        private prodiDataSetTableAdapters.prodiTableAdapter prodiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaprodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nmp;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private prodiDataSet1 prodiDataSet1;
        private System.Windows.Forms.BindingSource prodiBindingSource1;
        private prodiDataSet1TableAdapters.prodiTableAdapter prodiTableAdapter1;
        private BindingSource prodiBindingSource2;
    }
}