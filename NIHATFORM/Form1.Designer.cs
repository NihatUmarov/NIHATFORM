
namespace NIHATFORM
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localDbDataSet = new NIHATFORM.localDbDataSet();
            this.userTableAdapter = new NIHATFORM.localDbDataSetTableAdapters.UserTableAdapter();
            this.localDbDataSet1 = new NIHATFORM.localDbDataSet1();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter1 = new NIHATFORM.localDbDataSet1TableAdapters.UserTableAdapter();
            this.localDbDataSet2 = new NIHATFORM.localDbDataSet2();
            this.userBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter2 = new NIHATFORM.localDbDataSet2TableAdapters.UserTableAdapter();
            this.localDbDataSet3 = new NIHATFORM.localDbDataSet3();
            this.userBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter3 = new NIHATFORM.localDbDataSet3TableAdapters.UserTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.localDbDataSet4 = new NIHATFORM.localDbDataSet4();
            this.userBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter4 = new NIHATFORM.localDbDataSet4TableAdapters.UserTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.localDbDataSet;
            // 
            // localDbDataSet
            // 
            this.localDbDataSet.DataSetName = "localDbDataSet";
            this.localDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // localDbDataSet1
            // 
            this.localDbDataSet1.DataSetName = "localDbDataSet1";
            this.localDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "User";
            this.userBindingSource1.DataSource = this.localDbDataSet1;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // localDbDataSet2
            // 
            this.localDbDataSet2.DataSetName = "localDbDataSet2";
            this.localDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource2
            // 
            this.userBindingSource2.DataMember = "User";
            this.userBindingSource2.DataSource = this.localDbDataSet2;
            // 
            // userTableAdapter2
            // 
            this.userTableAdapter2.ClearBeforeFill = true;
            // 
            // localDbDataSet3
            // 
            this.localDbDataSet3.DataSetName = "localDbDataSet3";
            this.localDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource3
            // 
            this.userBindingSource3.DataMember = "User";
            this.userBindingSource3.DataSource = this.localDbDataSet3;
            // 
            // userTableAdapter3
            // 
            this.userTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.foodDataGridViewTextBoxColumn,
            this.gramDataGridViewTextBoxColumn,
            this.caloriesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(208, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // localDbDataSet4
            // 
            this.localDbDataSet4.DataSetName = "localDbDataSet4";
            this.localDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource4
            // 
            this.userBindingSource4.DataMember = "User";
            this.userBindingSource4.DataSource = this.localDbDataSet4;
            // 
            // userTableAdapter4
            // 
            this.userTableAdapter4.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foodDataGridViewTextBoxColumn
            // 
            this.foodDataGridViewTextBoxColumn.DataPropertyName = "Food";
            this.foodDataGridViewTextBoxColumn.HeaderText = "Food";
            this.foodDataGridViewTextBoxColumn.Name = "foodDataGridViewTextBoxColumn";
            // 
            // gramDataGridViewTextBoxColumn
            // 
            this.gramDataGridViewTextBoxColumn.DataPropertyName = "gram";
            this.gramDataGridViewTextBoxColumn.HeaderText = "gram";
            this.gramDataGridViewTextBoxColumn.Name = "gramDataGridViewTextBoxColumn";
            // 
            // caloriesDataGridViewTextBoxColumn
            // 
            this.caloriesDataGridViewTextBoxColumn.DataPropertyName = "calories";
            this.caloriesDataGridViewTextBoxColumn.HeaderText = "calories";
            this.caloriesDataGridViewTextBoxColumn.Name = "caloriesDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private localDbDataSet localDbDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private localDbDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private localDbDataSet1 localDbDataSet1;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private localDbDataSet1TableAdapters.UserTableAdapter userTableAdapter1;
        private localDbDataSet2 localDbDataSet2;
        private System.Windows.Forms.BindingSource userBindingSource2;
        private localDbDataSet2TableAdapters.UserTableAdapter userTableAdapter2;
        private localDbDataSet3 localDbDataSet3;
        private System.Windows.Forms.BindingSource userBindingSource3;
        private localDbDataSet3TableAdapters.UserTableAdapter userTableAdapter3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private localDbDataSet4 localDbDataSet4;
        private System.Windows.Forms.BindingSource userBindingSource4;
        private localDbDataSet4TableAdapters.UserTableAdapter userTableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesDataGridViewTextBoxColumn;
    }
}

