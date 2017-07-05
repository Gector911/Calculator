namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Subtruction = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tg = new System.Windows.Forms.Button();
            this.ctg = new System.Windows.Forms.Button();
            this.lg = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
            this.arccos = new System.Windows.Forms.Button();
            this.arctg = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.sinh = new System.Windows.Forms.Button();
            this.cosh = new System.Windows.Forms.Button();
            this.tgh = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.exponent = new System.Windows.Forms.Button();
            this.decad = new System.Windows.Forms.Button();
            this.radians = new System.Windows.Forms.RadioButton();
            this.degrees = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(34, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 20);
            this.textBox3.TabIndex = 2;
            // 
            // Subtruction
            // 
            this.Subtruction.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Subtruction.Location = new System.Drawing.Point(34, 129);
            this.Subtruction.Name = "Subtruction";
            this.Subtruction.Size = new System.Drawing.Size(75, 23);
            this.Subtruction.TabIndex = 3;
            this.Subtruction.Text = "-";
            this.Subtruction.UseVisualStyleBackColor = false;
            this.Subtruction.Click += new System.EventHandler(this.Subtruction_Click);
            // 
            // Addition
            // 
            this.Addition.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Addition.Location = new System.Drawing.Point(115, 129);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(75, 23);
            this.Addition.TabIndex = 4;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = false;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Multiplication.Location = new System.Drawing.Point(34, 158);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(75, 23);
            this.Multiplication.TabIndex = 5;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = false;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Division.Location = new System.Drawing.Point(115, 158);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // sin
            // 
            this.sin.BackColor = System.Drawing.Color.Coral;
            this.sin.Location = new System.Drawing.Point(34, 187);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 7;
            this.sin.Text = "sin(x)";
            this.sin.UseVisualStyleBackColor = false;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // cos
            // 
            this.cos.BackColor = System.Drawing.Color.Coral;
            this.cos.Location = new System.Drawing.Point(115, 187);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 8;
            this.cos.Text = "cos(x)";
            this.cos.UseVisualStyleBackColor = false;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // tg
            // 
            this.tg.BackColor = System.Drawing.Color.Coral;
            this.tg.Location = new System.Drawing.Point(34, 216);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(75, 23);
            this.tg.TabIndex = 9;
            this.tg.Text = "tg(x)";
            this.tg.UseVisualStyleBackColor = false;
            this.tg.Click += new System.EventHandler(this.tg_Click);
            // 
            // ctg
            // 
            this.ctg.BackColor = System.Drawing.Color.Coral;
            this.ctg.Location = new System.Drawing.Point(115, 216);
            this.ctg.Name = "ctg";
            this.ctg.Size = new System.Drawing.Size(75, 23);
            this.ctg.TabIndex = 10;
            this.ctg.Text = "ctg(x)";
            this.ctg.UseVisualStyleBackColor = false;
            this.ctg.Click += new System.EventHandler(this.ctg_Click);
            // 
            // lg
            // 
            this.lg.BackColor = System.Drawing.Color.Aquamarine;
            this.lg.Location = new System.Drawing.Point(34, 303);
            this.lg.Name = "lg";
            this.lg.Size = new System.Drawing.Size(75, 23);
            this.lg.TabIndex = 11;
            this.lg.Text = "lg(x)";
            this.lg.UseVisualStyleBackColor = false;
            this.lg.Click += new System.EventHandler(this.lg_Click);
            // 
            // ln
            // 
            this.ln.BackColor = System.Drawing.Color.Aquamarine;
            this.ln.Location = new System.Drawing.Point(115, 303);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(75, 23);
            this.ln.TabIndex = 12;
            this.ln.Text = "ln(x)";
            this.ln.UseVisualStyleBackColor = false;
            this.ln.Click += new System.EventHandler(this.ln_Click);
            // 
            // arcsin
            // 
            this.arcsin.BackColor = System.Drawing.Color.LightSalmon;
            this.arcsin.Location = new System.Drawing.Point(34, 245);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(75, 23);
            this.arcsin.TabIndex = 13;
            this.arcsin.Text = "arcsin(x)";
            this.arcsin.UseVisualStyleBackColor = false;
            this.arcsin.Click += new System.EventHandler(this.arcsin_Click);
            // 
            // arccos
            // 
            this.arccos.BackColor = System.Drawing.Color.LightSalmon;
            this.arccos.Location = new System.Drawing.Point(115, 245);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(75, 23);
            this.arccos.TabIndex = 14;
            this.arccos.Text = "arccos(x)";
            this.arccos.UseVisualStyleBackColor = false;
            this.arccos.Click += new System.EventHandler(this.arccos_Click);
            // 
            // arctg
            // 
            this.arctg.BackColor = System.Drawing.Color.LightSalmon;
            this.arctg.Location = new System.Drawing.Point(34, 274);
            this.arctg.Name = "arctg";
            this.arctg.Size = new System.Drawing.Size(75, 23);
            this.arctg.TabIndex = 15;
            this.arctg.Text = "arctg(x)";
            this.arctg.UseVisualStyleBackColor = false;
            this.arctg.Click += new System.EventHandler(this.arctg_Click);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sqrt.Location = new System.Drawing.Point(196, 129);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(75, 23);
            this.sqrt.TabIndex = 16;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // power
            // 
            this.power.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.power.Location = new System.Drawing.Point(196, 158);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(75, 23);
            this.power.TabIndex = 17;
            this.power.Text = "x^y";
            this.power.UseVisualStyleBackColor = false;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // sinh
            // 
            this.sinh.BackColor = System.Drawing.Color.DarkOrange;
            this.sinh.Location = new System.Drawing.Point(196, 187);
            this.sinh.Name = "sinh";
            this.sinh.Size = new System.Drawing.Size(75, 23);
            this.sinh.TabIndex = 18;
            this.sinh.Text = "sinh(x)";
            this.sinh.UseVisualStyleBackColor = false;
            this.sinh.Click += new System.EventHandler(this.sinh_Click);
            // 
            // cosh
            // 
            this.cosh.BackColor = System.Drawing.Color.DarkOrange;
            this.cosh.Location = new System.Drawing.Point(196, 216);
            this.cosh.Name = "cosh";
            this.cosh.Size = new System.Drawing.Size(75, 23);
            this.cosh.TabIndex = 19;
            this.cosh.Text = "cosh(x)";
            this.cosh.UseVisualStyleBackColor = false;
            this.cosh.Click += new System.EventHandler(this.cosh_Click);
            // 
            // tgh
            // 
            this.tgh.BackColor = System.Drawing.Color.DarkOrange;
            this.tgh.Location = new System.Drawing.Point(196, 245);
            this.tgh.Name = "tgh";
            this.tgh.Size = new System.Drawing.Size(75, 23);
            this.tgh.TabIndex = 20;
            this.tgh.Text = "tgh(x)";
            this.tgh.UseVisualStyleBackColor = false;
            this.tgh.Click += new System.EventHandler(this.tgh_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.min.Location = new System.Drawing.Point(34, 332);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(75, 23);
            this.min.TabIndex = 21;
            this.min.Text = "MIN";
            this.min.UseVisualStyleBackColor = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // max
            // 
            this.max.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.max.Location = new System.Drawing.Point(115, 332);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(75, 23);
            this.max.TabIndex = 22;
            this.max.Text = "MAX";
            this.max.UseVisualStyleBackColor = false;
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // exponent
            // 
            this.exponent.BackColor = System.Drawing.Color.MediumTurquoise;
            this.exponent.Location = new System.Drawing.Point(196, 303);
            this.exponent.Name = "exponent";
            this.exponent.Size = new System.Drawing.Size(75, 23);
            this.exponent.TabIndex = 23;
            this.exponent.Text = "e^x";
            this.exponent.UseVisualStyleBackColor = false;
            this.exponent.Click += new System.EventHandler(this.exponent_Click);
            // 
            // decad
            // 
            this.decad.BackColor = System.Drawing.Color.MediumTurquoise;
            this.decad.Location = new System.Drawing.Point(196, 332);
            this.decad.Name = "decad";
            this.decad.Size = new System.Drawing.Size(75, 23);
            this.decad.TabIndex = 24;
            this.decad.Text = "10^x";
            this.decad.UseVisualStyleBackColor = false;
            this.decad.Click += new System.EventHandler(this.decad_Click);
            // 
            // radians
            // 
            this.radians.AutoSize = true;
            this.radians.BackColor = System.Drawing.Color.PowderBlue;
            this.radians.Location = new System.Drawing.Point(278, 134);
            this.radians.Name = "radians";
            this.radians.Size = new System.Drawing.Size(40, 17);
            this.radians.TabIndex = 25;
            this.radians.TabStop = true;
            this.radians.Text = "rad";
            this.radians.UseVisualStyleBackColor = false;
            // 
            // degrees
            // 
            this.degrees.AutoSize = true;
            this.degrees.BackColor = System.Drawing.Color.PowderBlue;
            this.degrees.Location = new System.Drawing.Point(278, 158);
            this.degrees.Name = "degrees";
            this.degrees.Size = new System.Drawing.Size(43, 17);
            this.degrees.TabIndex = 26;
            this.degrees.TabStop = true;
            this.degrees.Text = "deg";
            this.degrees.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(326, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.degrees);
            this.Controls.Add(this.radians);
            this.Controls.Add(this.decad);
            this.Controls.Add(this.exponent);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.tgh);
            this.Controls.Add(this.cosh);
            this.Controls.Add(this.sinh);
            this.Controls.Add(this.power);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.arctg);
            this.Controls.Add(this.arccos);
            this.Controls.Add(this.arcsin);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.lg);
            this.Controls.Add(this.ctg);
            this.Controls.Add(this.tg);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Subtruction);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Subtruction;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tg;
        private System.Windows.Forms.Button ctg;
        private System.Windows.Forms.Button lg;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button arcsin;
        private System.Windows.Forms.Button arccos;
        private System.Windows.Forms.Button arctg;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button sinh;
        private System.Windows.Forms.Button cosh;
        private System.Windows.Forms.Button tgh;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button exponent;
        private System.Windows.Forms.Button decad;
        private System.Windows.Forms.RadioButton radians;
        private System.Windows.Forms.RadioButton degrees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}