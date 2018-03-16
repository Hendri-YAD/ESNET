namespace ESNET
{
    partial class Exer1_2
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
            this.movies_list = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rating_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movies_list
            // 
            this.movies_list.FormattingEnabled = true;
            this.movies_list.Location = new System.Drawing.Point(155, 46);
            this.movies_list.Name = "movies_list";
            this.movies_list.Size = new System.Drawing.Size(281, 251);
            this.movies_list.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Retrieve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rating_tb
            // 
            this.rating_tb.Location = new System.Drawing.Point(231, 322);
            this.rating_tb.Name = "rating_tb";
            this.rating_tb.Size = new System.Drawing.Size(100, 20);
            this.rating_tb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rating";
            // 
            // Exer1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rating_tb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.movies_list);
            this.Name = "Exer1_2";
            this.Text = "Exer1_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox movies_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox rating_tb;
        private System.Windows.Forms.Label label1;
    }
}