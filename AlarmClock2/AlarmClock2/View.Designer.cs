namespace AlarmClock2
{
    partial class View
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
            this.UxTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UxEditButton = new System.Windows.Forms.Button();
            this.UxAddButton = new System.Windows.Forms.Button();
            this.UxSnoozeButton = new System.Windows.Forms.Button();
            this.UxStopButton = new System.Windows.Forms.Button();
            this.UxAlarmList = new System.Windows.Forms.ListBox();
            this.UxStatusBar = new System.Windows.Forms.TextBox();
            this.UxTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // UxTableLayout
            // 
            this.UxTableLayout.ColumnCount = 3;
            this.UxTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.UxTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.UxTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.UxTableLayout.Controls.Add(this.UxEditButton, 0, 0);
            this.UxTableLayout.Controls.Add(this.UxAddButton, 2, 0);
            this.UxTableLayout.Controls.Add(this.UxSnoozeButton, 0, 3);
            this.UxTableLayout.Controls.Add(this.UxStopButton, 2, 3);
            this.UxTableLayout.Controls.Add(this.UxAlarmList, 0, 1);
            this.UxTableLayout.Controls.Add(this.UxStatusBar, 0, 2);
            this.UxTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxTableLayout.Location = new System.Drawing.Point(0, 0);
            this.UxTableLayout.Name = "UxTableLayout";
            this.UxTableLayout.RowCount = 4;
            this.UxTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.19771F));
            this.UxTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.06017F));
            this.UxTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.742121F));
            this.UxTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.UxTableLayout.Size = new System.Drawing.Size(333, 418);
            this.UxTableLayout.TabIndex = 0;
            // 
            // UxEditButton
            // 
            this.UxEditButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxEditButton.Enabled = false;
            this.UxEditButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxEditButton.Location = new System.Drawing.Point(10, 10);
            this.UxEditButton.Margin = new System.Windows.Forms.Padding(10);
            this.UxEditButton.Name = "UxEditButton";
            this.UxEditButton.Size = new System.Drawing.Size(106, 47);
            this.UxEditButton.TabIndex = 0;
            this.UxEditButton.Text = "Edit";
            this.UxEditButton.UseVisualStyleBackColor = true;
            this.UxEditButton.Click += new System.EventHandler(this.UxEditButton_Click);
            // 
            // UxAddButton
            // 
            this.UxAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxAddButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxAddButton.Location = new System.Drawing.Point(215, 10);
            this.UxAddButton.Margin = new System.Windows.Forms.Padding(10);
            this.UxAddButton.Name = "UxAddButton";
            this.UxAddButton.Size = new System.Drawing.Size(108, 47);
            this.UxAddButton.TabIndex = 1;
            this.UxAddButton.Text = "+";
            this.UxAddButton.UseVisualStyleBackColor = true;
            this.UxAddButton.Click += new System.EventHandler(this.UxAddButton_Click);
            // 
            // UxSnoozeButton
            // 
            this.UxSnoozeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxSnoozeButton.Enabled = false;
            this.UxSnoozeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxSnoozeButton.Location = new System.Drawing.Point(10, 359);
            this.UxSnoozeButton.Margin = new System.Windows.Forms.Padding(10);
            this.UxSnoozeButton.Name = "UxSnoozeButton";
            this.UxSnoozeButton.Size = new System.Drawing.Size(106, 49);
            this.UxSnoozeButton.TabIndex = 2;
            this.UxSnoozeButton.Text = "Snooze";
            this.UxSnoozeButton.UseVisualStyleBackColor = true;
            this.UxSnoozeButton.Click += new System.EventHandler(this.UxSnoozeButton_Click);
            // 
            // UxStopButton
            // 
            this.UxStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxStopButton.Enabled = false;
            this.UxStopButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxStopButton.Location = new System.Drawing.Point(215, 359);
            this.UxStopButton.Margin = new System.Windows.Forms.Padding(10);
            this.UxStopButton.Name = "UxStopButton";
            this.UxStopButton.Size = new System.Drawing.Size(108, 49);
            this.UxStopButton.TabIndex = 3;
            this.UxStopButton.Text = "Stop";
            this.UxStopButton.UseVisualStyleBackColor = true;
            this.UxStopButton.Click += new System.EventHandler(this.UxStopButton_Click);
            // 
            // UxAlarmList
            // 
            this.UxTableLayout.SetColumnSpan(this.UxAlarmList, 3);
            this.UxAlarmList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxAlarmList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxAlarmList.FormattingEnabled = true;
            this.UxAlarmList.ItemHeight = 25;
            this.UxAlarmList.Location = new System.Drawing.Point(20, 87);
            this.UxAlarmList.Margin = new System.Windows.Forms.Padding(20);
            this.UxAlarmList.Name = "UxAlarmList";
            this.UxAlarmList.Size = new System.Drawing.Size(293, 208);
            this.UxAlarmList.TabIndex = 4;
            this.UxAlarmList.SelectedValueChanged += new System.EventHandler(this.UxAlarmList_SelectedValueChanged);
            // 
            // UxStatusBar
            // 
            this.UxStatusBar.BackColor = System.Drawing.SystemColors.Control;
            this.UxStatusBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UxTableLayout.SetColumnSpan(this.UxStatusBar, 3);
            this.UxStatusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxStatusBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxStatusBar.Location = new System.Drawing.Point(3, 318);
            this.UxStatusBar.Name = "UxStatusBar";
            this.UxStatusBar.Size = new System.Drawing.Size(327, 22);
            this.UxStatusBar.TabIndex = 5;
            this.UxStatusBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 418);
            this.Controls.Add(this.UxTableLayout);
            this.Name = "View";
            this.Text = "Alarms";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.View_FormClosed);
            this.UxTableLayout.ResumeLayout(false);
            this.UxTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel UxTableLayout;
        private Button UxEditButton;
        private Button UxAddButton;
        private Button UxSnoozeButton;
        private Button UxStopButton;
        private ListBox UxAlarmList;
        private TextBox UxStatusBar;
    }
}