
namespace Question6
{
    partial class BookControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UxTitle = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // UxTitle
            // 
            this.UxTitle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UxTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxTitle.Location = new System.Drawing.Point(8, 8);
            this.UxTitle.Margin = new System.Windows.Forms.Padding(15);
            this.UxTitle.Name = "UxTitle";
            this.UxTitle.ReadOnly = true;
            this.UxTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.UxTitle.Size = new System.Drawing.Size(134, 209);
            this.UxTitle.TabIndex = 2;
            this.UxTitle.Text = "This is a Title of a Book";
            // 
            // BookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.UxTitle);
            this.MinimumSize = new System.Drawing.Size(150, 225);
            this.Name = "BookControl";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(150, 225);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox UxTitle;
    }
}
