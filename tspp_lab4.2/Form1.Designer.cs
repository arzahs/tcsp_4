﻿namespace tspp_lab4._2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataSet1 = new System.Data.DataSet();
            this.DataTable1 = new System.Data.DataTable();
            this.DataColumn1 = new System.Data.DataColumn();
            this.DataColumn2 = new System.Data.DataColumn();
            this.DataColumn3 = new System.Data.DataColumn();
            this.DataColumn4 = new System.Data.DataColumn();
            this.DataColumn5 = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NightTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoplataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "NewDataSet";
            this.DataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.DataTable1});
            // 
            // DataTable1
            // 
            this.DataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.DataColumn1,
            this.DataColumn2,
            this.DataColumn3,
            this.DataColumn4,
            this.DataColumn5});
            this.DataTable1.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "number"}, false)});
            this.DataTable1.TableName = "Table1";
            // 
            // DataColumn1
            // 
            this.DataColumn1.AutoIncrement = true;
            this.DataColumn1.Caption = "Таб.номер";
            this.DataColumn1.ColumnName = "number";
            this.DataColumn1.DataType = typeof(int);
            this.DataColumn1.ReadOnly = true;
            // 
            // DataColumn2
            // 
            this.DataColumn2.ColumnName = "FIO";
            // 
            // DataColumn3
            // 
            this.DataColumn3.Caption = "Тарифная ставка";
            this.DataColumn3.ColumnName = "Tarif";
            this.DataColumn3.DataType = typeof(double);
            // 
            // DataColumn4
            // 
            this.DataColumn4.Caption = "Отработано в ночное время";
            this.DataColumn4.ColumnName = "nightTime";
            this.DataColumn4.DataType = typeof(int);
            // 
            // DataColumn5
            // 
            this.DataColumn5.ColumnName = "Doplata";
            this.DataColumn5.DataType = typeof(double);
            this.DataColumn5.Expression = "IIF(nightTime<30, 2*Tarif, 2.5*Tarif)";
            this.DataColumn5.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberDataGridViewTextBoxColumn,
            this.FIODataGridViewTextBoxColumn,
            this.TarifDataGridViewTextBoxColumn,
            this.NightTimeDataGridViewTextBoxColumn,
            this.DoplataDataGridViewTextBoxColumn});
            this.DataGridView1.DataMember = "Table1";
            this.DataGridView1.DataSource = this.DataSet1;
            this.DataGridView1.Location = new System.Drawing.Point(12, 12);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(683, 150);
            this.DataGridView1.TabIndex = 3;
            // 
            // NumberDataGridViewTextBoxColumn
            // 
            this.NumberDataGridViewTextBoxColumn.DataPropertyName = "number";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.NumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.NumberDataGridViewTextBoxColumn.HeaderText = "Таб. номер";
            this.NumberDataGridViewTextBoxColumn.Name = "NumberDataGridViewTextBoxColumn";
            this.NumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FIODataGridViewTextBoxColumn
            // 
            this.FIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.FIODataGridViewTextBoxColumn.HeaderText = "Ф.И.О.";
            this.FIODataGridViewTextBoxColumn.Name = "FIODataGridViewTextBoxColumn";
            this.FIODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FIODataGridViewTextBoxColumn.Width = 240;
            // 
            // TarifDataGridViewTextBoxColumn
            // 
            this.TarifDataGridViewTextBoxColumn.DataPropertyName = "Tarif";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.TarifDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.TarifDataGridViewTextBoxColumn.HeaderText = "Тарифна ставка";
            this.TarifDataGridViewTextBoxColumn.Name = "TarifDataGridViewTextBoxColumn";
            this.TarifDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NightTimeDataGridViewTextBoxColumn
            // 
            this.NightTimeDataGridViewTextBoxColumn.DataPropertyName = "nightTime";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.NightTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.NightTimeDataGridViewTextBoxColumn.HeaderText = "Отработано часов в ночное время";
            this.NightTimeDataGridViewTextBoxColumn.Name = "NightTimeDataGridViewTextBoxColumn";
            this.NightTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DoplataDataGridViewTextBoxColumn
            // 
            this.DoplataDataGridViewTextBoxColumn.DataPropertyName = "Doplata";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.DoplataDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.DoplataDataGridViewTextBoxColumn.HeaderText = "Доплата";
            this.DoplataDataGridViewTextBoxColumn.Name = "DoplataDataGridViewTextBoxColumn";
            this.DoplataDataGridViewTextBoxColumn.ReadOnly = true;
            this.DoplataDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Data.DataSet DataSet1;
        internal System.Data.DataTable DataTable1;
        internal System.Data.DataColumn DataColumn1;
        internal System.Data.DataColumn DataColumn2;
        internal System.Data.DataColumn DataColumn3;
        internal System.Data.DataColumn DataColumn4;
        internal System.Data.DataColumn DataColumn5;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn NumberDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FIODataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TarifDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn NightTimeDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DoplataDataGridViewTextBoxColumn;
    }
}
