
namespace DBform
{
    partial class SelectionTablice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionTablice));
            this.ChPaymentsTab = new System.Windows.Forms.Button();
            this.ChAdditionalInfTab = new System.Windows.Forms.Button();
            this.ChRecordingsTab = new System.Windows.Forms.Button();
            this.ChPersDataTab = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AplClosingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChPaymentsTab
            // 
            this.ChPaymentsTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChPaymentsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChPaymentsTab.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChPaymentsTab.Location = new System.Drawing.Point(15, 32);
            this.ChPaymentsTab.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ChPaymentsTab.Name = "ChPaymentsTab";
            this.ChPaymentsTab.Size = new System.Drawing.Size(245, 39);
            this.ChPaymentsTab.TabIndex = 0;
            this.ChPaymentsTab.Text = "Выплаты";
            this.ChPaymentsTab.UseVisualStyleBackColor = false;
            this.ChPaymentsTab.Click += new System.EventHandler(this.ChPaymentsTab_Click);
            // 
            // ChAdditionalInfTab
            // 
            this.ChAdditionalInfTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChAdditionalInfTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChAdditionalInfTab.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChAdditionalInfTab.Location = new System.Drawing.Point(15, 84);
            this.ChAdditionalInfTab.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ChAdditionalInfTab.Name = "ChAdditionalInfTab";
            this.ChAdditionalInfTab.Size = new System.Drawing.Size(245, 39);
            this.ChAdditionalInfTab.TabIndex = 1;
            this.ChAdditionalInfTab.Text = "Доп. сведения";
            this.ChAdditionalInfTab.UseVisualStyleBackColor = false;
            this.ChAdditionalInfTab.Click += new System.EventHandler(this.ChAdditionalInfTab_Click);
            // 
            // ChRecordingsTab
            // 
            this.ChRecordingsTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChRecordingsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChRecordingsTab.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChRecordingsTab.Location = new System.Drawing.Point(15, 136);
            this.ChRecordingsTab.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ChRecordingsTab.Name = "ChRecordingsTab";
            this.ChRecordingsTab.Size = new System.Drawing.Size(245, 39);
            this.ChRecordingsTab.TabIndex = 2;
            this.ChRecordingsTab.Text = "Записи";
            this.ChRecordingsTab.UseVisualStyleBackColor = false;
            this.ChRecordingsTab.Click += new System.EventHandler(this.ChRecordingsTab_Click);
            // 
            // ChPersDataTab
            // 
            this.ChPersDataTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChPersDataTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChPersDataTab.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChPersDataTab.Location = new System.Drawing.Point(15, 196);
            this.ChPersDataTab.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ChPersDataTab.Name = "ChPersDataTab";
            this.ChPersDataTab.Size = new System.Drawing.Size(245, 39);
            this.ChPersDataTab.TabIndex = 3;
            this.ChPersDataTab.Text = "Личные данные";
            this.ChPersDataTab.UseVisualStyleBackColor = false;
            this.ChPersDataTab.Click += new System.EventHandler(this.ChPersDataTab_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Bahnschrift Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(271, 310);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(245, 39);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Назад";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.ChPaymentsTab);
            this.groupBox1.Controls.Add(this.ChAdditionalInfTab);
            this.groupBox1.Controls.Add(this.ChPersDataTab);
            this.groupBox1.Controls.Add(this.ChRecordingsTab);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(256, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 242);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа с базой данных";
            // 
            // AplClosingButton
            // 
            this.AplClosingButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AplClosingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AplClosingButton.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AplClosingButton.Location = new System.Drawing.Point(543, 399);
            this.AplClosingButton.Name = "AplClosingButton";
            this.AplClosingButton.Size = new System.Drawing.Size(245, 39);
            this.AplClosingButton.TabIndex = 6;
            this.AplClosingButton.Text = "Выключить систему";
            this.AplClosingButton.UseVisualStyleBackColor = false;
            this.AplClosingButton.Click += new System.EventHandler(this.AplClosingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Панель Администрирования";
            // 
            // SelectionTablice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AplClosingButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitButton);
            this.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SelectionTablice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectionTablice";
            this.Load += new System.EventHandler(this.SelectionTablice_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChAdditionalInfTab;
        private System.Windows.Forms.Button ChRecordingsTab;
        private System.Windows.Forms.Button ChPersDataTab;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.Button ChPaymentsTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AplClosingButton;
        private System.Windows.Forms.Label label1;
    }
}