namespace Serbina8
{
    partial class FormSeller
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
            this.labelRole = new System.Windows.Forms.Label();
            this.labelNames = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(489, 122);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(94, 20);
            this.labelRole.TabIndex = 7;
            this.labelRole.Text = "Продавец";
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNames.Location = new System.Drawing.Point(428, 70);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(211, 20);
            this.labelNames.TabIndex = 6;
            this.labelNames.Text = "Пак Дмитрий Игоревич ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(139, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(179, 169);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(422, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "НАЗАД";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelNames);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button3);
            this.Name = "FormSeller";
            this.Text = "FormSeller";
            this.Load += new System.EventHandler(this.FormSeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
    }
}