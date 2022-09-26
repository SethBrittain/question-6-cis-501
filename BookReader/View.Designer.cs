
namespace Question6
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UxSynchronizeButton = new System.Windows.Forms.Button();
            this.UxBookshelf = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.UxSynchronizeButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UxBookshelf, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.047945F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.95206F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UxSynchronizeButton
            // 
            this.UxSynchronizeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.UxSynchronizeButton.Location = new System.Drawing.Point(3, 3);
            this.UxSynchronizeButton.Name = "UxSynchronizeButton";
            this.UxSynchronizeButton.Size = new System.Drawing.Size(116, 47);
            this.UxSynchronizeButton.TabIndex = 0;
            this.UxSynchronizeButton.Text = "Synchronize";
            this.UxSynchronizeButton.UseVisualStyleBackColor = true;
            this.UxSynchronizeButton.Click += new System.EventHandler(this.UxSynchronizeButton_Click);
            // 
            // UxBookshelf
            // 
            this.UxBookshelf.AutoScroll = true;
            this.UxBookshelf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxBookshelf.Location = new System.Drawing.Point(3, 56);
            this.UxBookshelf.Name = "UxBookshelf";
            this.UxBookshelf.Size = new System.Drawing.Size(578, 602);
            this.UxBookshelf.TabIndex = 1;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "View";
            this.Text = "LibraryView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.View_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button UxSynchronizeButton;
        private System.Windows.Forms.FlowLayoutPanel UxBookshelf;
    }
}