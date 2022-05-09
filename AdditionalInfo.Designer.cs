
namespace DBform
{
    partial class AdditionalInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalInfo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.районDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресПроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имеетПропискуDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.дополнительныеСведенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prefektDBDataSet = new DBform.PrefektDBDataSet();
            this.дополнительные_сведенияTableAdapter = new DBform.PrefektDBDataSetTableAdapters.Дополнительные_сведенияTableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RmButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ChTabliceButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.iBLDatSet = new DBform.IBLDatSet();
            this.additInfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.additInfTableAdapter = new DBform.IBLDatSetTableAdapters.AdditInfTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительныеСведенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefektDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBLDatSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additInfBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.возрастDataGridViewTextBoxColumn,
            this.районDataGridViewTextBoxColumn,
            this.адресПроживанияDataGridViewTextBoxColumn,
            this.имеетПропискуDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.additInfBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(777, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // возрастDataGridViewTextBoxColumn
            // 
            this.возрастDataGridViewTextBoxColumn.DataPropertyName = "Возраст";
            this.возрастDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.возрастDataGridViewTextBoxColumn.Name = "возрастDataGridViewTextBoxColumn";
            // 
            // районDataGridViewTextBoxColumn
            // 
            this.районDataGridViewTextBoxColumn.DataPropertyName = "Район";
            this.районDataGridViewTextBoxColumn.HeaderText = "Район";
            this.районDataGridViewTextBoxColumn.Name = "районDataGridViewTextBoxColumn";
            // 
            // адресПроживанияDataGridViewTextBoxColumn
            // 
            this.адресПроживанияDataGridViewTextBoxColumn.DataPropertyName = "Адрес проживания";
            this.адресПроживанияDataGridViewTextBoxColumn.HeaderText = "Адрес проживания";
            this.адресПроживанияDataGridViewTextBoxColumn.Name = "адресПроживанияDataGridViewTextBoxColumn";
            // 
            // имеетПропискуDataGridViewCheckBoxColumn
            // 
            this.имеетПропискуDataGridViewCheckBoxColumn.DataPropertyName = "Имеет прописку";
            this.имеетПропискуDataGridViewCheckBoxColumn.HeaderText = "Имеет прописку";
            this.имеетПропискуDataGridViewCheckBoxColumn.Name = "имеетПропискуDataGridViewCheckBoxColumn";
            // 
            // дополнительныеСведенияBindingSource
            // 
            this.дополнительныеСведенияBindingSource.DataMember = "Дополнительные сведения";
            this.дополнительныеСведенияBindingSource.DataSource = this.prefektDBDataSet;
            // 
            // prefektDBDataSet
            // 
            this.prefektDBDataSet.DataSetName = "PrefektDBDataSet";
            this.prefektDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // дополнительные_сведенияTableAdapter
            // 
            this.дополнительные_сведенияTableAdapter.ClearBeforeFill = true;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(78, 353);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(219, 39);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RmButton
            // 
            this.RmButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RmButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RmButton.Location = new System.Drawing.Point(303, 353);
            this.RmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RmButton.Name = "RmButton";
            this.RmButton.Size = new System.Drawing.Size(219, 39);
            this.RmButton.TabIndex = 4;
            this.RmButton.Text = "Удалить";
            this.RmButton.UseVisualStyleBackColor = false;
            this.RmButton.Click += new System.EventHandler(this.RmButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(531, 399);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(219, 39);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ChTabliceButton
            // 
            this.ChTabliceButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChTabliceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChTabliceButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChTabliceButton.Location = new System.Drawing.Point(531, 353);
            this.ChTabliceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChTabliceButton.Name = "ChTabliceButton";
            this.ChTabliceButton.Size = new System.Drawing.Size(219, 39);
            this.ChTabliceButton.TabIndex = 6;
            this.ChTabliceButton.Text = "Выбор таблицы";
            this.ChTabliceButton.UseVisualStyleBackColor = false;
            this.ChTabliceButton.Click += new System.EventHandler(this.ChTabliceButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(73, 405);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(27, 25);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "...";
            // 
            // iBLDatSet
            // 
            this.iBLDatSet.DataSetName = "IBLDatSet";
            this.iBLDatSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // additInfBindingSource
            // 
            this.additInfBindingSource.DataMember = "AdditInf";
            this.additInfBindingSource.DataSource = this.iBLDatSet;
            // 
            // additInfTableAdapter
            // 
            this.additInfTableAdapter.ClearBeforeFill = true;
            // 
            // AdditionalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ChTabliceButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RmButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdditionalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdditionalInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdditionalInfo_FormClosing);
            this.Load += new System.EventHandler(this.AdditionalInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дополнительныеСведенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefektDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBLDatSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additInfBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PrefektDBDataSet prefektDBDataSet;
        private System.Windows.Forms.BindingSource дополнительныеСведенияBindingSource;
        private PrefektDBDataSetTableAdapters.Дополнительные_сведенияTableAdapter дополнительные_сведенияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn районDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресПроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn имеетПропискуDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RmButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ChTabliceButton;
        private System.Windows.Forms.Label StatusLabel;
        private IBLDatSet iBLDatSet;
        private System.Windows.Forms.BindingSource additInfBindingSource;
        private IBLDatSetTableAdapters.AdditInfTableAdapter additInfTableAdapter;
    }
}