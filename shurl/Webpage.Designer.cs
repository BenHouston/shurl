namespace shurl
{
    partial class Webpage
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
            this.LongLink_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Convert_btn = new System.Windows.Forms.Button();
            this.ShortLink_txt = new System.Windows.Forms.TextBox();
            this.Copy_btn = new System.Windows.Forms.Button();
            this.Return_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LongLink_txt
            // 
            this.LongLink_txt.Location = new System.Drawing.Point(12, 25);
            this.LongLink_txt.Name = "LongLink_txt";
            this.LongLink_txt.Size = new System.Drawing.Size(776, 20);
            this.LongLink_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paste the link you would like to shorten here:";
            // 
            // Convert_btn
            // 
            this.Convert_btn.Location = new System.Drawing.Point(12, 51);
            this.Convert_btn.Name = "Convert_btn";
            this.Convert_btn.Size = new System.Drawing.Size(75, 23);
            this.Convert_btn.TabIndex = 2;
            this.Convert_btn.Text = "Convert Link";
            this.Convert_btn.UseVisualStyleBackColor = true;
            this.Convert_btn.Click += new System.EventHandler(this.Convert_btn_Click);
            // 
            // ShortLink_txt
            // 
            this.ShortLink_txt.Location = new System.Drawing.Point(12, 80);
            this.ShortLink_txt.Name = "ShortLink_txt";
            this.ShortLink_txt.Size = new System.Drawing.Size(367, 20);
            this.ShortLink_txt.TabIndex = 3;
            // 
            // Copy_btn
            // 
            this.Copy_btn.Location = new System.Drawing.Point(385, 77);
            this.Copy_btn.Name = "Copy_btn";
            this.Copy_btn.Size = new System.Drawing.Size(117, 23);
            this.Copy_btn.TabIndex = 2;
            this.Copy_btn.Text = "Copy to Clipboard";
            this.Copy_btn.UseVisualStyleBackColor = true;
            // 
            // Return_btn
            // 
            this.Return_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Return_btn.Location = new System.Drawing.Point(664, 51);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(124, 52);
            this.Return_btn.TabIndex = 2;
            this.Return_btn.Text = "Return to Browser";
            this.Return_btn.UseVisualStyleBackColor = true;
            // 
            // Webpage
            // 
            this.AcceptButton = this.Convert_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Return_btn;
            this.ClientSize = new System.Drawing.Size(800, 111);
            this.Controls.Add(this.ShortLink_txt);
            this.Controls.Add(this.Copy_btn);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.Convert_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LongLink_txt);
            this.Name = "Webpage";
            this.Text = "www.shurl.com";
            this.Load += new System.EventHandler(this.Webpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LongLink_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Convert_btn;
        private System.Windows.Forms.TextBox ShortLink_txt;
        private System.Windows.Forms.Button Copy_btn;
        private System.Windows.Forms.Button Return_btn;
    }
}