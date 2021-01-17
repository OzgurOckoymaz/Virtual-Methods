
namespace Virtual_Methods
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnChocolate = new System.Windows.Forms.Button();
            this.btnBread = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the exc. VAT Price";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(215, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnChocolate
            // 
            this.btnChocolate.Location = new System.Drawing.Point(74, 104);
            this.btnChocolate.Name = "btnChocolate";
            this.btnChocolate.Size = new System.Drawing.Size(75, 23);
            this.btnChocolate.TabIndex = 4;
            this.btnChocolate.Text = "Chocolate";
            this.btnChocolate.UseVisualStyleBackColor = true;
            this.btnChocolate.Click += new System.EventHandler(this.btnChocolate_Click);
            // 
            // btnBread
            // 
            this.btnBread.Location = new System.Drawing.Point(244, 104);
            this.btnBread.Name = "btnBread";
            this.btnBread.Size = new System.Drawing.Size(75, 23);
            this.btnBread.TabIndex = 5;
            this.btnBread.Text = "Bread";
            this.btnBread.UseVisualStyleBackColor = true;
            this.btnBread.Click += new System.EventHandler(this.btnBread_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter the exc. VAT Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBread);
            this.Controls.Add(this.btnChocolate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnChocolate;
        private System.Windows.Forms.Button btnBread;
        private System.Windows.Forms.Label label3;
    }
}

