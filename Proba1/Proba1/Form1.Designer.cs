namespace Proba1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.minus = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.squaring = new System.Windows.Forms.Button();
            this.squareroot = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(312, 51);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(43, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 20);
            this.textBox3.TabIndex = 6;
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(312, 90);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 7;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(312, 132);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(75, 23);
            this.multi.TabIndex = 8;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(312, 175);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 23);
            this.Div.TabIndex = 9;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // squaring
            // 
            this.squaring.Location = new System.Drawing.Point(312, 217);
            this.squaring.Name = "squaring";
            this.squaring.Size = new System.Drawing.Size(75, 23);
            this.squaring.TabIndex = 10;
            this.squaring.Text = "x^2";
            this.squaring.UseVisualStyleBackColor = true;
            this.squaring.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // squareroot
            // 
            this.squareroot.Location = new System.Drawing.Point(312, 256);
            this.squareroot.Name = "squareroot";
            this.squareroot.Size = new System.Drawing.Size(75, 23);
            this.squareroot.TabIndex = 11;
            this.squareroot.Text = "√";
            this.squareroot.UseVisualStyleBackColor = true;
            this.squareroot.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "x+y";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Additionoftwo);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(540, 51);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 13;
            this.sin.Text = "sin(x)";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(540, 90);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 14;
            this.cos.Text = "cos(x)";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 443);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.squareroot);
            this.Controls.Add(this.squaring);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button squaring;
        private System.Windows.Forms.Button squareroot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
    }
}

