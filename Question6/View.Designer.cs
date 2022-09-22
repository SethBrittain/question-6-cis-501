
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
            this.Ux = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Ux
            // 
            this.Ux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ux.Location = new System.Drawing.Point(0, 0);
            this.Ux.Name = "Ux";
            this.Ux.Size = new System.Drawing.Size(565, 692);
            this.Ux.TabIndex = 0;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 692);
            this.Controls.Add(this.Ux);
            this.Name = "View";
            this.Text = "KindleApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Ux;
    }
}

