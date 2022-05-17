namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_change = new System.Windows.Forms.Button();
            this.pbx_loc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loc)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(317, 12);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(122, 44);
            this.btn_change.TabIndex = 0;
            this.btn_change.Text = "Change To London";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // pbx_loc
            // 
            this.pbx_loc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_loc.Location = new System.Drawing.Point(191, 76);
            this.pbx_loc.Name = "pbx_loc";
            this.pbx_loc.Size = new System.Drawing.Size(410, 298);
            this.pbx_loc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_loc.TabIndex = 1;
            this.pbx_loc.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbx_loc);
            this.Controls.Add(this.btn_change);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_change;
        private PictureBox pbx_loc;
    }
}
