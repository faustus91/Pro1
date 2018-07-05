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
            this.tan = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
            this.arccos = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.ten_in_th_degree = new System.Windows.Forms.Button();
            this.two_degrees = new System.Windows.Forms.Button();
            this.unit_divided = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(197, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 20);
            this.textBox3.TabIndex = 6;
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(12, 51);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 7;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(12, 90);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(75, 23);
            this.multi.TabIndex = 8;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(12, 132);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 23);
            this.Div.TabIndex = 9;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // squaring
            // 
            this.squaring.Location = new System.Drawing.Point(12, 175);
            this.squaring.Name = "squaring";
            this.squaring.Size = new System.Drawing.Size(75, 23);
            this.squaring.TabIndex = 10;
            this.squaring.Text = "x^2";
            this.squaring.UseVisualStyleBackColor = true;
            this.squaring.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // squareroot
            // 
            this.squareroot.Location = new System.Drawing.Point(12, 217);
            this.squareroot.Name = "squareroot";
            this.squareroot.Size = new System.Drawing.Size(75, 23);
            this.squareroot.TabIndex = 11;
            this.squareroot.Text = "√";
            this.squareroot.UseVisualStyleBackColor = true;
            this.squareroot.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "x+y";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Additionoftwo);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(394, 25);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 13;
            this.sin.Text = "sin(x)";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(394, 66);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 14;
            this.cos.Text = "cos(x)";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(394, 112);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 15;
            this.tan.Text = "tan(x)";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // arcsin
            // 
            this.arcsin.Location = new System.Drawing.Point(394, 154);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(75, 23);
            this.arcsin.TabIndex = 16;
            this.arcsin.Text = "arcsin(x)";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // arccos
            // 
            this.arccos.Location = new System.Drawing.Point(394, 193);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(75, 23);
            this.arccos.TabIndex = 17;
            this.arccos.Text = "arccos(x)";
            this.arccos.UseVisualStyleBackColor = true;
            this.arccos.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(394, 234);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(75, 23);
            this.ln.TabIndex = 18;
            this.ln.Text = "ln(x)";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(394, 275);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(75, 23);
            this.exp.TabIndex = 19;
            this.exp.Text = "e^x";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // ten_in_th_degree
            // 
            this.ten_in_th_degree.Location = new System.Drawing.Point(394, 313);
            this.ten_in_th_degree.Name = "ten_in_th_degree";
            this.ten_in_th_degree.Size = new System.Drawing.Size(75, 23);
            this.ten_in_th_degree.TabIndex = 20;
            this.ten_in_th_degree.Text = "10^x";
            this.ten_in_th_degree.UseVisualStyleBackColor = true;
            this.ten_in_th_degree.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // two_degrees
            // 
            this.two_degrees.Location = new System.Drawing.Point(498, 25);
            this.two_degrees.Name = "two_degrees";
            this.two_degrees.Size = new System.Drawing.Size(75, 23);
            this.two_degrees.TabIndex = 21;
            this.two_degrees.Text = "2^x";
            this.two_degrees.UseVisualStyleBackColor = true;
            this.two_degrees.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // unit_divided
            // 
            this.unit_divided.Location = new System.Drawing.Point(498, 69);
            this.unit_divided.Name = "unit_divided";
            this.unit_divided.Size = new System.Drawing.Size(75, 23);
            this.unit_divided.TabIndex = 22;
            this.unit_divided.Text = "1/x";
            this.unit_divided.UseVisualStyleBackColor = true;
            this.unit_divided.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 372);
            this.Controls.Add(this.unit_divided);
            this.Controls.Add(this.two_degrees);
            this.Controls.Add(this.ten_in_th_degree);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.arccos);
            this.Controls.Add(this.arcsin);
            this.Controls.Add(this.tan);
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
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button arcsin;
        private System.Windows.Forms.Button arccos;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button ten_in_th_degree;
        private System.Windows.Forms.Button two_degrees;
        private System.Windows.Forms.Button unit_divided;
    }
}

