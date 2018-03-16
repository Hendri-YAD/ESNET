namespace ESNET
{
    partial class Exer1_1
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
            this.VideoCode_tb = new System.Windows.Forms.TextBox();
            this.RentalPrice_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video Code:";
            // 
            // VideoCode_tb
            // 
            this.VideoCode_tb.Location = new System.Drawing.Point(235, 118);
            this.VideoCode_tb.Name = "VideoCode_tb";
            this.VideoCode_tb.Size = new System.Drawing.Size(129, 20);
            this.VideoCode_tb.TabIndex = 1;
            // 
            // RentalPrice_tb
            // 
            this.RentalPrice_tb.Location = new System.Drawing.Point(235, 164);
            this.RentalPrice_tb.Name = "RentalPrice_tb";
            this.RentalPrice_tb.Size = new System.Drawing.Size(129, 20);
            this.RentalPrice_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rental Price:";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(217, 260);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(87, 33);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Exer1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 538);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.RentalPrice_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VideoCode_tb);
            this.Controls.Add(this.label1);
            this.Name = "Exer1_1";
            this.Text = "Change Video Rental Price";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VideoCode_tb;
        private System.Windows.Forms.TextBox RentalPrice_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_update;
    }
}

