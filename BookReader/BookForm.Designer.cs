
namespace Question6
{
    partial class BookForm
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
            this.UxLibraryLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UxPrevPageButton = new System.Windows.Forms.Button();
            this.UxNextPageButton = new System.Windows.Forms.Button();
            this.UxBackButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UxPageNumber = new System.Windows.Forms.TextBox();
            this.UxAddBookmarkButton = new System.Windows.Forms.Button();
            this.UxPageText = new System.Windows.Forms.RichTextBox();
            this.UxLibraryLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UxLibraryLayout
            // 
            this.UxLibraryLayout.ColumnCount = 2;
            this.UxLibraryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UxLibraryLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UxLibraryLayout.Controls.Add(this.UxPrevPageButton, 0, 2);
            this.UxLibraryLayout.Controls.Add(this.UxNextPageButton, 1, 2);
            this.UxLibraryLayout.Controls.Add(this.UxBackButton, 0, 0);
            this.UxLibraryLayout.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.UxLibraryLayout.Controls.Add(this.UxPageText, 0, 1);
            this.UxLibraryLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxLibraryLayout.Location = new System.Drawing.Point(0, 0);
            this.UxLibraryLayout.Name = "UxLibraryLayout";
            this.UxLibraryLayout.RowCount = 3;
            this.UxLibraryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.UxLibraryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.UxLibraryLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.UxLibraryLayout.Size = new System.Drawing.Size(584, 761);
            this.UxLibraryLayout.TabIndex = 0;
            // 
            // UxPrevPageButton
            // 
            this.UxPrevPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxPrevPageButton.Enabled = false;
            this.UxPrevPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxPrevPageButton.Location = new System.Drawing.Point(3, 702);
            this.UxPrevPageButton.Name = "UxPrevPageButton";
            this.UxPrevPageButton.Size = new System.Drawing.Size(286, 56);
            this.UxPrevPageButton.TabIndex = 0;
            this.UxPrevPageButton.Text = "Previous Page";
            this.UxPrevPageButton.UseVisualStyleBackColor = true;
            // 
            // UxNextPageButton
            // 
            this.UxNextPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxNextPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxNextPageButton.Location = new System.Drawing.Point(295, 702);
            this.UxNextPageButton.Name = "UxNextPageButton";
            this.UxNextPageButton.Size = new System.Drawing.Size(286, 56);
            this.UxNextPageButton.TabIndex = 1;
            this.UxNextPageButton.Text = "Next Page";
            this.UxNextPageButton.UseVisualStyleBackColor = true;
            // 
            // UxBackButton
            // 
            this.UxBackButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.UxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxBackButton.Location = new System.Drawing.Point(3, 3);
            this.UxBackButton.Name = "UxBackButton";
            this.UxBackButton.Size = new System.Drawing.Size(107, 54);
            this.UxBackButton.TabIndex = 2;
            this.UxBackButton.Text = "Back";
            this.UxBackButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.UxPageNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UxAddBookmarkButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(295, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 54);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // UxPageNumber
            // 
            this.UxPageNumber.BackColor = System.Drawing.SystemColors.Control;
            this.UxPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UxPageNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxPageNumber.Enabled = false;
            this.UxPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxPageNumber.Location = new System.Drawing.Point(146, 3);
            this.UxPageNumber.Name = "UxPageNumber";
            this.UxPageNumber.Size = new System.Drawing.Size(137, 42);
            this.UxPageNumber.TabIndex = 0;
            this.UxPageNumber.Text = "1";
            this.UxPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UxAddBookmarkButton
            // 
            this.UxAddBookmarkButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxAddBookmarkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxAddBookmarkButton.Location = new System.Drawing.Point(3, 3);
            this.UxAddBookmarkButton.Name = "UxAddBookmarkButton";
            this.UxAddBookmarkButton.Size = new System.Drawing.Size(137, 48);
            this.UxAddBookmarkButton.TabIndex = 1;
            this.UxAddBookmarkButton.Text = "Add Bookmark";
            this.UxAddBookmarkButton.UseVisualStyleBackColor = true;
            // 
            // UxPageText
            // 
            this.UxLibraryLayout.SetColumnSpan(this.UxPageText, 2);
            this.UxPageText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UxPageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxPageText.Location = new System.Drawing.Point(15, 75);
            this.UxPageText.Margin = new System.Windows.Forms.Padding(15);
            this.UxPageText.Name = "UxPageText";
            this.UxPageText.ReadOnly = true;
            this.UxPageText.Size = new System.Drawing.Size(554, 609);
            this.UxPageText.TabIndex = 4;
            this.UxPageText.Text = "";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.UxLibraryLayout);
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "BookForm";
            this.Text = "BookView";
            this.UxLibraryLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel UxLibraryLayout;
        private System.Windows.Forms.Button UxPrevPageButton;
        private System.Windows.Forms.Button UxNextPageButton;
        private System.Windows.Forms.Button UxBackButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox UxPageNumber;
        private System.Windows.Forms.Button UxAddBookmarkButton;
        private System.Windows.Forms.RichTextBox UxPageText;
    }
}