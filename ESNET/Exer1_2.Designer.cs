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
            this.button1.Location = new System.Drawing.Point(244, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Retrieve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exer1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.movies_list);
            this.Name = "Exer1_2";
            this.Text = "Exer1_2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox movies_list;
        private System.Windows.Forms.Button button1;
    }
}