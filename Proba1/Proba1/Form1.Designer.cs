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
            this.addition_of_two_numbers = new System.Windows.Forms.Button();
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
            this.subtraction_of_two_numbers = new System.Windows.Forms.Button();
            this.multiplication_of_two_numbers = new System.Windows.Forms.Button();
            this.division_of_two_numbers = new System.Windows.Forms.Button();
            this.Extent = new System.Windows.Forms.Button();
            this.logorifm = new System.Windows.Forms.Button();
            this.DegreeRoot = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
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
            this.minus.Location = new System.Drawing.Point(12, 50);
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
            // addition_of_two_numbers
            // 
            this.addition_of_two_numbers.Location = new System.Drawing.Point(500, 217);
            this.addition_of_two_numbers.Name = "addition_of_two_numbers";
            this.addition_of_two_numbers.Size = new System.Drawing.Size(75, 23);
            this.addition_of_two_numbers.TabIndex = 12;
            this.addition_of_two_numbers.Text = "x+y";
            this.addition_of_two_numbers.UseVisualStyleBackColor = true;
            this.addition_of_two_numbers.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(405, 256);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 13;
            this.sin.Text = "sin(x)";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(500, 256);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 14;
            this.cos.Text = "cos(x)";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(305, 217);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 15;
            this.tan.Text = "tan(x)";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // arcsin
            // 
            this.arcsin.Location = new System.Drawing.Point(12, 256);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(75, 23);
            this.arcsin.TabIndex = 16;
            this.arcsin.Text = "arcsin(x)";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // arccos
            // 
            this.arccos.Location = new System.Drawing.Point(116, 165);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(75, 23);
            this.arccos.TabIndex = 17;
            this.arccos.Text = "arccos(x)";
            this.arccos.UseVisualStyleBackColor = true;
            this.arccos.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(116, 217);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(75, 23);
            this.ln.TabIndex = 18;
            this.ln.Text = "ln(x)";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(212, 217);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(75, 23);
            this.exp.TabIndex = 19;
            this.exp.Text = "e^x";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // ten_in_th_degree
            // 
            this.ten_in_th_degree.Location = new System.Drawing.Point(212, 256);
            this.ten_in_th_degree.Name = "ten_in_th_degree";
            this.ten_in_th_degree.Size = new System.Drawing.Size(75, 23);
            this.ten_in_th_degree.TabIndex = 20;
            this.ten_in_th_degree.Text = "10^x";
            this.ten_in_th_degree.UseVisualStyleBackColor = true;
            this.ten_in_th_degree.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // two_degrees
            // 
            this.two_degrees.Location = new System.Drawing.Point(305, 165);
            this.two_degrees.Name = "two_degrees";
            this.two_degrees.Size = new System.Drawing.Size(75, 23);
            this.two_degrees.TabIndex = 21;
            this.two_degrees.Text = "2^x";
            this.two_degrees.UseVisualStyleBackColor = true;
            this.two_degrees.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // unit_divided
            // 
            this.unit_divided.Location = new System.Drawing.Point(212, 165);
            this.unit_divided.Name = "unit_divided";
            this.unit_divided.Size = new System.Drawing.Size(75, 23);
            this.unit_divided.TabIndex = 22;
            this.unit_divided.Text = "1/x";
            this.unit_divided.UseVisualStyleBackColor = true;
            this.unit_divided.Click += new System.EventHandler(this.OneArgumentOperation);
            // 
            // subtraction_of_two_numbers
            // 
            this.subtraction_of_two_numbers.Location = new System.Drawing.Point(500, 165);
            this.subtraction_of_two_numbers.Name = "subtraction_of_two_numbers";
            this.subtraction_of_two_numbers.Size = new System.Drawing.Size(75, 23);
            this.subtraction_of_two_numbers.TabIndex = 23;
            this.subtraction_of_two_numbers.Text = "x-y";
            this.subtraction_of_two_numbers.UseVisualStyleBackColor = true;
            this.subtraction_of_two_numbers.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // multiplication_of_two_numbers
            // 
            this.multiplication_of_two_numbers.Location = new System.Drawing.Point(500, 22);
            this.multiplication_of_two_numbers.Name = "multiplication_of_two_numbers";
            this.multiplication_of_two_numbers.Size = new System.Drawing.Size(75, 23);
            this.multiplication_of_two_numbers.TabIndex = 24;
            this.multiplication_of_two_numbers.Text = "x*y";
            this.multiplication_of_two_numbers.UseVisualStyleBackColor = true;
            this.multiplication_of_two_numbers.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // division_of_two_numbers
            // 
            this.division_of_two_numbers.Location = new System.Drawing.Point(405, 112);
            this.division_of_two_numbers.Name = "division_of_two_numbers";
            this.division_of_two_numbers.Size = new System.Drawing.Size(75, 23);
            this.division_of_two_numbers.TabIndex = 25;
            this.division_of_two_numbers.Text = "x/y";
            this.division_of_two_numbers.UseVisualStyleBackColor = true;
            this.division_of_two_numbers.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // Extent
            // 
            this.Extent.Location = new System.Drawing.Point(500, 66);
            this.Extent.Name = "Extent";
            this.Extent.Size = new System.Drawing.Size(75, 23);
            this.Extent.TabIndex = 26;
            this.Extent.Text = "x^y";
            this.Extent.UseVisualStyleBackColor = true;
            this.Extent.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // logorifm
            // 
            this.logorifm.Location = new System.Drawing.Point(500, 115);
            this.logorifm.Name = "logorifm";
            this.logorifm.Size = new System.Drawing.Size(75, 23);
            this.logorifm.TabIndex = 27;
            this.logorifm.Text = "logx(y)";
            this.logorifm.UseVisualStyleBackColor = true;
            this.logorifm.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // DegreeRoot
            // 
            this.DegreeRoot.Location = new System.Drawing.Point(405, 66);
            this.DegreeRoot.Name = "DegreeRoot";
            this.DegreeRoot.Size = new System.Drawing.Size(75, 23);
            this.DegreeRoot.TabIndex = 28;
            this.DegreeRoot.Text = "x^(1/y)";
            this.DegreeRoot.UseVisualStyleBackColor = true;
            this.DegreeRoot.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(405, 165);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(75, 23);
            this.min.TabIndex = 29;
            this.min.Text = "min(x,y)";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(405, 217);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(75, 23);
            this.max.TabIndex = 30;
            this.max.Text = "max(x,y)";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // pow
            // 
            this.pow.Location = new System.Drawing.Point(405, 22);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(75, 23);
            this.pow.TabIndex = 31;
            this.pow.Text = "y^x";
            this.pow.UseVisualStyleBackColor = true;
            this.pow.Click += new System.EventHandler(this.TwoArgumentsOperation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 316);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.DegreeRoot);
            this.Controls.Add(this.logorifm);
            this.Controls.Add(this.Extent);
            this.Controls.Add(this.division_of_two_numbers);
            this.Controls.Add(this.multiplication_of_two_numbers);
            this.Controls.Add(this.subtraction_of_two_numbers);
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
            this.Controls.Add(this.addition_of_two_numbers);
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
        private System.Windows.Forms.Button addition_of_two_numbers;
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
        private System.Windows.Forms.Button subtraction_of_two_numbers;
        private System.Windows.Forms.Button multiplication_of_two_numbers;
        private System.Windows.Forms.Button division_of_two_numbers;
        private System.Windows.Forms.Button Extent;
        private System.Windows.Forms.Button logorifm;
        private System.Windows.Forms.Button DegreeRoot;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button pow;
    }
}

