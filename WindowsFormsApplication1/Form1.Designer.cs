namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.thaiLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.phoneticLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // thaiLabel
            // 
            this.thaiLabel.AutoSize = true;
            this.thaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thaiLabel.Location = new System.Drawing.Point(23, 155);
            this.thaiLabel.Name = "thaiLabel";
            this.thaiLabel.Size = new System.Drawing.Size(209, 76);
            this.thaiLabel.TabIndex = 0;
            this.thaiLabel.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // phoneticLabel
            // 
            this.phoneticLabel.AutoSize = true;
            this.phoneticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneticLabel.Location = new System.Drawing.Point(263, 155);
            this.phoneticLabel.Name = "phoneticLabel";
            this.phoneticLabel.Size = new System.Drawing.Size(209, 76);
            this.phoneticLabel.TabIndex = 3;
            this.phoneticLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 524);
            this.Controls.Add(this.phoneticLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.thaiLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label thaiLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label phoneticLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

