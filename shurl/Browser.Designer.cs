namespace shurl
{
    partial class Browser
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
            this.GoTo_btn = new System.Windows.Forms.Button();
            this.Address_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Quit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoTo_btn
            // 
            this.GoTo_btn.Location = new System.Drawing.Point(12, 51);
            this.GoTo_btn.Name = "GoTo_btn";
            this.GoTo_btn.Size = new System.Drawing.Size(226, 44);
            this.GoTo_btn.TabIndex = 0;
            this.GoTo_btn.Text = "Go to \'Website\'";
            this.GoTo_btn.UseVisualStyleBackColor = true;
            this.GoTo_btn.Click += new System.EventHandler(this.GoTo_btn_Click);
            // 
            // Address_txt
            // 
            this.Address_txt.Location = new System.Drawing.Point(12, 25);
            this.Address_txt.Name = "Address_txt";
            this.Address_txt.Size = new System.Drawing.Size(776, 20);
            this.Address_txt.TabIndex = 1;
            this.Address_txt.Text = "www.shurl.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type/Paste ULR here:";
            // 
            // Quit_btn
            // 
            this.Quit_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Quit_btn.Location = new System.Drawing.Point(562, 51);
            this.Quit_btn.Name = "Quit_btn";
            this.Quit_btn.Size = new System.Drawing.Size(226, 44);
            this.Quit_btn.TabIndex = 0;
            this.Quit_btn.Text = "Quit Application";
            this.Quit_btn.UseVisualStyleBackColor = true;
            this.Quit_btn.Click += new System.EventHandler(this.Quit_btn_Click);
            // 
            // Browser
            // 
            this.AcceptButton = this.GoTo_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Quit_btn;
            this.ClientSize = new System.Drawing.Size(800, 104);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Address_txt);
            this.Controls.Add(this.Quit_btn);
            this.Controls.Add(this.GoTo_btn);
            this.Name = "Browser";
            this.Text = "Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoTo_btn;
        private System.Windows.Forms.TextBox Address_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Quit_btn;
    }
}

