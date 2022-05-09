
namespace DBform
{
    partial class PaymentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имеетДетейDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.соцвыплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоДетейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пенсионныеВыплатыDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.пенсвыплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iBLDatSet = new DBform.IBLDatSet();
            this.выплатыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prefektDBDataSet = new DBform.PrefektDBDataSet();
            this.выплатыTableAdapter = new DBform.PrefektDBDataSetTableAdapters.ВыплатыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new DBform.IBLDatSetTableAdapters.PaymentsTableAdapter();
            this.paymentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBLDatSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выплатыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefektDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имеетДетейDataGridViewCheckBoxColumn,
            this.соцвыплатыDataGridViewTextBoxColumn,
            this.количествоДетейDataGridViewTextBoxColumn,
            this.пенсионныеВыплатыDataGridViewCheckBoxColumn,
            this.пенсвыплатыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentsBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(7, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 334);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
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
            // имеетДетейDataGridViewCheckBoxColumn
            // 
            this.имеетДетейDataGridViewCheckBoxColumn.DataPropertyName = "Имеет детей";
            this.имеетДетейDataGridViewCheckBoxColumn.HeaderText = "Имеет детей";
            this.имеетДетейDataGridViewCheckBoxColumn.Name = "имеетДетейDataGridViewCheckBoxColumn";
            // 
            // соцвыплатыDataGridViewTextBoxColumn
            // 
            this.соцвыплатыDataGridViewTextBoxColumn.DataPropertyName = "Соц-выплаты";
            this.соцвыплатыDataGridViewTextBoxColumn.HeaderText = "Соц-выплаты";
            this.соцвыплатыDataGridViewTextBoxColumn.Name = "соцвыплатыDataGridViewTextBoxColumn";
            // 
            // количествоДетейDataGridViewTextBoxColumn
            // 
            this.количествоДетейDataGridViewTextBoxColumn.DataPropertyName = "Количество детей";
            this.количествоДетейDataGridViewTextBoxColumn.HeaderText = "Количество детей";
            this.количествоДетейDataGridViewTextBoxColumn.Name = "количествоДетейDataGridViewTextBoxColumn";
            // 
            // пенсионныеВыплатыDataGridViewCheckBoxColumn
            // 
            this.пенсионныеВыплатыDataGridViewCheckBoxColumn.DataPropertyName = "Пенсионные выплаты";
            this.пенсионныеВыплатыDataGridViewCheckBoxColumn.HeaderText = "Пенсионные выплаты";
            this.пенсионныеВыплатыDataGridViewCheckBoxColumn.Name = "пенсионныеВыплатыDataGridViewCheckBoxColumn";
            // 
            // пенсвыплатыDataGridViewTextBoxColumn
            // 
            this.пенсвыплатыDataGridViewTextBoxColumn.DataPropertyName = "Пенс-выплаты";
            this.пенсвыплатыDataGridViewTextBoxColumn.HeaderText = "Пенс-выплаты";
            this.пенсвыплатыDataGridViewTextBoxColumn.Name = "пенсвыплатыDataGridViewTextBoxColumn";
            // 
            // paymentsBindingSource2
            // 
            this.paymentsBindingSource2.DataMember = "Payments";
            this.paymentsBindingSource2.DataSource = this.iBLDatSet;
            // 
            // iBLDatSet
            // 
            this.iBLDatSet.DataSetName = "IBLDatSet";
            this.iBLDatSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // выплатыBindingSource
            // 
            this.выплатыBindingSource.DataMember = "Выплаты";
            this.выплатыBindingSource.DataSource = this.prefektDBDataSet;
            // 
            // prefektDBDataSet
            // 
            this.prefektDBDataSet.DataSetName = "PrefektDBDataSet";
            this.prefektDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // выплатыTableAdapter
            // 
            this.выплатыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(59, 346);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(283, 346);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(507, 389);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(507, 346);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "Выбор таблицы";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(54, 403);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(27, 25);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "...";
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "Payments";
            this.paymentsBindingSource.DataSource = this.iBLDatSet;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // paymentsBindingSource1
            // 
            this.paymentsBindingSource1.DataMember = "Payments";
            this.paymentsBindingSource1.DataSource = this.iBLDatSet;
            // 
            // paymentsBindingSource3
            // 
            this.paymentsBindingSource3.DataMember = "Payments";
            this.paymentsBindingSource3.DataSource = this.iBLDatSet;
            // 
            // PaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PaymentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentsForm_FormClosing);
            this.Load += new System.EventHandler(this.PaymentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBLDatSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выплатыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prefektDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PrefektDBDataSet prefektDBDataSet;
        private System.Windows.Forms.BindingSource выплатыBindingSource;
        private PrefektDBDataSetTableAdapters.ВыплатыTableAdapter выплатыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn имеетДетейDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn соцвыплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоДетейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn пенсионныеВыплатыDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пенсвыплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label StatusLabel;
        private IBLDatSet iBLDatSet;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private IBLDatSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.BindingSource paymentsBindingSource2;
        private System.Windows.Forms.BindingSource paymentsBindingSource1;
        private System.Windows.Forms.BindingSource paymentsBindingSource3;
    }
}