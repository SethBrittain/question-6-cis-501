namespace AlarmClock2
{
    partial class AlarmEdit
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
            this.UxTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UxAlarmSet = new System.Windows.Forms.CheckBox();
            this.UxCancelButton = new System.Windows.Forms.Button();
            this.UxSetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UxAlarmTypes = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UxTimePicker
            // 
            this.UxTimePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UxTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.UxTimePicker.Location = new System.Drawing.Point(8, 25);
            this.UxTimePicker.Margin = new System.Windows.Forms.Padding(8);
            this.UxTimePicker.Name = "UxTimePicker";
            this.UxTimePicker.ShowUpDown = true;
            this.UxTimePicker.Size = new System.Drawing.Size(183, 23);
            this.UxTimePicker.TabIndex = 0;
            // 
            // UxAlarmSet
            // 
            this.UxAlarmSet.AutoSize = true;
            this.UxAlarmSet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UxAlarmSet.Location = new System.Drawing.Point(207, 29);
            this.UxAlarmSet.Margin = new System.Windows.Forms.Padding(8);
            this.UxAlarmSet.Name = "UxAlarmSet";
            this.UxAlarmSet.Size = new System.Drawing.Size(110, 19);
            this.UxAlarmSet.TabIndex = 1;
            this.UxAlarmSet.Text = "Enabled";
            this.UxAlarmSet.UseVisualStyleBackColor = true;
            // 
            // UxCancelButton
            // 
            this.UxCancelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.UxCancelButton.Location = new System.Drawing.Point(10, 115);
            this.UxCancelButton.Margin = new System.Windows.Forms.Padding(10);
            this.UxCancelButton.Name = "UxCancelButton";
            this.UxCancelButton.Size = new System.Drawing.Size(90, 53);
            this.UxCancelButton.TabIndex = 2;
            this.UxCancelButton.Text = "Cancel";
            this.UxCancelButton.UseVisualStyleBackColor = true;
            this.UxCancelButton.Click += new System.EventHandler(this.UxEditButton_Click);
            // 
            // UxSetButton
            // 
            this.UxSetButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.UxSetButton.Location = new System.Drawing.Point(228, 115);
            this.UxSetButton.Margin = new System.Windows.Forms.Padding(10);
            this.UxSetButton.Name = "UxSetButton";
            this.UxSetButton.Size = new System.Drawing.Size(87, 53);
            this.UxSetButton.TabIndex = 3;
            this.UxSetButton.Text = "Set";
            this.UxSetButton.UseVisualStyleBackColor = true;
            this.UxSetButton.Click += new System.EventHandler(this.UxEditButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.30137F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.69863F));
            this.tableLayoutPanel1.Controls.Add(this.UxTimePicker, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UxAlarmSet, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UxCancelButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.UxSetButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.UxAlarmTypes, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.44828F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.55172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 178);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // UxAlarmTypes
            // 
            this.UxAlarmTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.UxAlarmTypes.FormattingEnabled = true;
            this.UxAlarmTypes.Items.AddRange(new object[] {
            "Radar",
            "Beacon",
            "Charms",
            "Circuit",
            "Reflection"});
            this.UxAlarmTypes.Location = new System.Drawing.Point(8, 64);
            this.UxAlarmTypes.Margin = new System.Windows.Forms.Padding(8);
            this.UxAlarmTypes.Name = "UxAlarmTypes";
            this.UxAlarmTypes.Size = new System.Drawing.Size(183, 23);
            this.UxAlarmTypes.TabIndex = 4;
            // 
            // AlarmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 178);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AlarmEdit";
            this.Text = "AlarmEdit";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker UxTimePicker;
        private CheckBox UxAlarmSet;
        private Button UxCancelButton;
        private Button UxSetButton;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox UxAlarmTypes;
    }
}