namespace CarManager
{
    partial class ParkingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_parkingManager = new System.Windows.Forms.DataGridView();
            this.listBox_logPrint = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_parkingSpot_lookUp = new System.Windows.Forms.TextBox();
            this.button_SelectedLookUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_parkingSpot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_driverName = new System.Windows.Forms.TextBox();
            this.textBox_carNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_parkingRemove = new System.Windows.Forms.Button();
            this.button_parkingAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.timer_DisplayNowtime = new System.Windows.Forms.Timer(this.components);
            this.statusStrip_Now = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Now = new System.Windows.Forms.ToolStripStatusLabel();
            this.parkingSpotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parkingManager)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip_Now.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_parkingManager);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(67, 176);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(727, 197);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주차현황";
            // 
            // dataGridView_parkingManager
            // 
            this.dataGridView_parkingManager.AutoGenerateColumns = false;
            this.dataGridView_parkingManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_parkingManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkingSpotDataGridViewTextBoxColumn,
            this.carNumberDataGridViewTextBoxColumn,
            this.driverNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.parkingTimeDataGridViewTextBoxColumn});
            this.dataGridView_parkingManager.DataSource = this.parkingCarBindingSource;
            this.dataGridView_parkingManager.Location = new System.Drawing.Point(7, 26);
            this.dataGridView_parkingManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_parkingManager.Name = "dataGridView_parkingManager";
            this.dataGridView_parkingManager.RowHeadersWidth = 51;
            this.dataGridView_parkingManager.RowTemplate.Height = 23;
            this.dataGridView_parkingManager.Size = new System.Drawing.Size(714, 163);
            this.dataGridView_parkingManager.TabIndex = 0;
            this.dataGridView_parkingManager.CurrentCellChanged += new System.EventHandler(this.dataGridView_parkingManager_CurrentCellChanged);
            // 
            // listBox_logPrint
            // 
            this.listBox_logPrint.FormattingEnabled = true;
            this.listBox_logPrint.HorizontalScrollbar = true;
            this.listBox_logPrint.ItemHeight = 15;
            this.listBox_logPrint.Location = new System.Drawing.Point(74, 381);
            this.listBox_logPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_logPrint.Name = "listBox_logPrint";
            this.listBox_logPrint.Size = new System.Drawing.Size(713, 154);
            this.listBox_logPrint.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_parkingSpot_lookUp);
            this.groupBox2.Controls.Add(this.button_SelectedLookUp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Location = new System.Drawing.Point(451, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(343, 80);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주차 공간 현황 관리";
            // 
            // textBox_parkingSpot_lookUp
            // 
            this.textBox_parkingSpot_lookUp.Location = new System.Drawing.Point(83, 22);
            this.textBox_parkingSpot_lookUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_parkingSpot_lookUp.Name = "textBox_parkingSpot_lookUp";
            this.textBox_parkingSpot_lookUp.Size = new System.Drawing.Size(114, 25);
            this.textBox_parkingSpot_lookUp.TabIndex = 5;
            // 
            // button_SelectedLookUp
            // 
            this.button_SelectedLookUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_SelectedLookUp.Location = new System.Drawing.Point(234, 20);
            this.button_SelectedLookUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_SelectedLookUp.Name = "button_SelectedLookUp";
            this.button_SelectedLookUp.Size = new System.Drawing.Size(86, 29);
            this.button_SelectedLookUp.TabIndex = 1;
            this.button_SelectedLookUp.Text = "조회";
            this.button_SelectedLookUp.UseVisualStyleBackColor = false;
            this.button_SelectedLookUp.Click += new System.EventHandler(this.button_SelectedLookUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "공간번호";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_parkingSpot);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox_phoneNumber);
            this.groupBox4.Controls.Add(this.textBox_driverName);
            this.groupBox4.Controls.Add(this.textBox_carNumber);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.button_parkingRemove);
            this.groupBox4.Controls.Add(this.button_parkingAdd);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox4.Location = new System.Drawing.Point(67, 3);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(343, 165);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "주차/출차";
            // 
            // textBox_parkingSpot
            // 
            this.textBox_parkingSpot.Location = new System.Drawing.Point(83, 20);
            this.textBox_parkingSpot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_parkingSpot.Name = "textBox_parkingSpot";
            this.textBox_parkingSpot.Size = new System.Drawing.Size(114, 25);
            this.textBox_parkingSpot.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "공간번호";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "전화번호";
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(83, 128);
            this.textBox_phoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(114, 25);
            this.textBox_phoneNumber.TabIndex = 7;
            // 
            // textBox_driverName
            // 
            this.textBox_driverName.Location = new System.Drawing.Point(83, 94);
            this.textBox_driverName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_driverName.Name = "textBox_driverName";
            this.textBox_driverName.Size = new System.Drawing.Size(114, 25);
            this.textBox_driverName.TabIndex = 6;
            // 
            // textBox_carNumber
            // 
            this.textBox_carNumber.Location = new System.Drawing.Point(83, 60);
            this.textBox_carNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_carNumber.Name = "textBox_carNumber";
            this.textBox_carNumber.Size = new System.Drawing.Size(114, 25);
            this.textBox_carNumber.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "차주이름";
            // 
            // button_parkingRemove
            // 
            this.button_parkingRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_parkingRemove.Location = new System.Drawing.Point(234, 61);
            this.button_parkingRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_parkingRemove.Name = "button_parkingRemove";
            this.button_parkingRemove.Size = new System.Drawing.Size(86, 29);
            this.button_parkingRemove.TabIndex = 2;
            this.button_parkingRemove.Text = "출차";
            this.button_parkingRemove.UseVisualStyleBackColor = false;
            this.button_parkingRemove.Click += new System.EventHandler(this.button_parkingRemove_Click);
            // 
            // button_parkingAdd
            // 
            this.button_parkingAdd.BackColor = System.Drawing.Color.Red;
            this.button_parkingAdd.Location = new System.Drawing.Point(234, 25);
            this.button_parkingAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_parkingAdd.Name = "button_parkingAdd";
            this.button_parkingAdd.Size = new System.Drawing.Size(86, 29);
            this.button_parkingAdd.TabIndex = 1;
            this.button_parkingAdd.Text = "주차";
            this.button_parkingAdd.UseVisualStyleBackColor = false;
            this.button_parkingAdd.Click += new System.EventHandler(this.button_parkingAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "차량번호";
            // 
            // timer_DisplayNowtime
            // 
            this.timer_DisplayNowtime.Enabled = true;
            this.timer_DisplayNowtime.Interval = 1000;
            this.timer_DisplayNowtime.Tick += new System.EventHandler(this.timer_DisplayNowtime_Tick);
            // 
            // statusStrip_Now
            // 
            this.statusStrip_Now.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_Now.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Now});
            this.statusStrip_Now.Location = new System.Drawing.Point(0, 555);
            this.statusStrip_Now.Name = "statusStrip_Now";
            this.statusStrip_Now.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip_Now.Size = new System.Drawing.Size(830, 22);
            this.statusStrip_Now.TabIndex = 24;
            this.statusStrip_Now.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Now
            // 
            this.toolStripStatusLabel_Now.Name = "toolStripStatusLabel_Now";
            this.toolStripStatusLabel_Now.Size = new System.Drawing.Size(0, 16);
            // 
            // parkingSpotDataGridViewTextBoxColumn
            // 
            this.parkingSpotDataGridViewTextBoxColumn.DataPropertyName = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.HeaderText = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkingSpotDataGridViewTextBoxColumn.Name = "parkingSpotDataGridViewTextBoxColumn";
            this.parkingSpotDataGridViewTextBoxColumn.Width = 125;
            // 
            // carNumberDataGridViewTextBoxColumn
            // 
            this.carNumberDataGridViewTextBoxColumn.DataPropertyName = "CarNumber";
            this.carNumberDataGridViewTextBoxColumn.HeaderText = "CarNumber";
            this.carNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carNumberDataGridViewTextBoxColumn.Name = "carNumberDataGridViewTextBoxColumn";
            this.carNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "DriverName";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "DriverName";
            this.driverNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            this.driverNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // parkingTimeDataGridViewTextBoxColumn
            // 
            this.parkingTimeDataGridViewTextBoxColumn.DataPropertyName = "ParkingTime";
            this.parkingTimeDataGridViewTextBoxColumn.HeaderText = "ParkingTime";
            this.parkingTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkingTimeDataGridViewTextBoxColumn.Name = "parkingTimeDataGridViewTextBoxColumn";
            this.parkingTimeDataGridViewTextBoxColumn.Width = 160;
            // 
            // parkingCarBindingSource
            // 
            this.parkingCarBindingSource.DataSource = typeof(CarManager.ParkingCar);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(CarManager.Program);
            // 
            // ParkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(830, 577);
            this.Controls.Add(this.statusStrip_Now);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_logPrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ParkingForm";
            this.Text = "ParkingForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parkingManager)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip_Now.ResumeLayout(false);
            this.statusStrip_Now.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_parkingManager;
        private System.Windows.Forms.ListBox listBox_logPrint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_parkingSpot_lookUp;
        private System.Windows.Forms.Button button_SelectedLookUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_parkingSpot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.TextBox textBox_driverName;
        private System.Windows.Forms.TextBox textBox_carNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_parkingRemove;
        private System.Windows.Forms.Button button_parkingAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Timer timer_DisplayNowtime;
        private System.Windows.Forms.StatusStrip statusStrip_Now;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Now;
        private System.Windows.Forms.BindingSource parkingCarBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingSpotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingTimeDataGridViewTextBoxColumn;
    }
}