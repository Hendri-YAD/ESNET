namespace ESNET
{
    partial class Exer1_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_videoCode = new System.Windows.Forms.TextBox();
            this.btn_retrieve = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_movieTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_rentalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type a Video Code";
            // 
            // tb_videoCode
            // 
            this.tb_videoCode.Location = new System.Drawing.Point(206, 72);
            this.tb_videoCode.Name = "tb_videoCode";
            this.tb_videoCode.Size = new System.Drawing.Size(140, 20);
            this.tb_videoCode.TabIndex = 1;
            // 
            // btn_retrieve
            // 
            this.btn_retrieve.Location = new System.Drawing.Point(388, 72);
            this.btn_retrieve.Name = "btn_retrieve";
            this.btn_retrieve.Size = new System.Drawing.Size(84, 23);
            this.btn_retrieve.TabIndex = 2;
            this.btn_retrieve.Text = "Retrieve";
            this.btn_retrieve.UseVisualStyleBackColor = true;
            this.btn_retrieve.Click += new System.EventHandler(this.btn_retrieve_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.tb_movieTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(120, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie Details";
            // 
            // tb_movieTitle
            // 
            this.tb_movieTitle.Location = new System.Drawing.Point(97, 24);
            this.tb_movieTitle.Name = "tb_movieTitle";
            this.tb_movieTitle.Size = new System.Drawing.Size(236, 20);
            this.tb_movieTitle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Movie Title:";
            // 
            // tb_rentalPrice
            // 
            this.tb_rentalPrice.Location = new System.Drawing.Point(217, 230);
            this.tb_rentalPrice.Name = "tb_rentalPrice";
            this.tb_rentalPrice.Size = new System.Drawing.Size(80, 20);
            this.tb_rentalPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rental Price:";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(134, 96);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Exer1_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 493);
            this.Controls.Add(this.tb_rentalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_retrieve);
            this.Controls.Add(this.tb_videoCode);
            this.Controls.Add(this.label1);
            this.Name = "Exer1_3";
            this.Text = "Movie Data Screen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_videoCode;
        private System.Windows.Forms.Button btn_retrieve;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_movieTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_rentalPrice;
        private System.Windows.Forms.Label label3;
    }
}