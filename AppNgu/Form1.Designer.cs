namespace AppNgu
{
    partial class Form1
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
            this.ViewSieuNgu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSieuNgu)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewSieuNgu
            // 
            this.ViewSieuNgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewSieuNgu.Location = new System.Drawing.Point(219, 136);
            this.ViewSieuNgu.Name = "ViewSieuNgu";
            this.ViewSieuNgu.RowHeadersWidth = 82;
            this.ViewSieuNgu.RowTemplate.Height = 33;
            this.ViewSieuNgu.Size = new System.Drawing.Size(1099, 432);
            this.ViewSieuNgu.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 923);
            this.Controls.Add(this.ViewSieuNgu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewSieuNgu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewSieuNgu;
    }
}

