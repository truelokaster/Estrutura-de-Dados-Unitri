namespace Angela_VT_06
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
            this.rbtsoma = new System.Windows.Forms.RadioButton();
            this.rbtsub = new System.Windows.Forms.RadioButton();
            this.rbtmult = new System.Windows.Forms.RadioButton();
            this.rbtdiv = new System.Windows.Forms.RadioButton();
            this.rbtmed = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtmedpond = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtsoma
            // 
            this.rbtsoma.AutoSize = true;
            this.rbtsoma.Checked = true;
            this.rbtsoma.Location = new System.Drawing.Point(6, 19);
            this.rbtsoma.Name = "rbtsoma";
            this.rbtsoma.Size = new System.Drawing.Size(52, 17);
            this.rbtsoma.TabIndex = 0;
            this.rbtsoma.TabStop = true;
            this.rbtsoma.Text = "Soma";
            this.rbtsoma.UseVisualStyleBackColor = true;
            // 
            // rbtsub
            // 
            this.rbtsub.AutoSize = true;
            this.rbtsub.Location = new System.Drawing.Point(6, 42);
            this.rbtsub.Name = "rbtsub";
            this.rbtsub.Size = new System.Drawing.Size(74, 17);
            this.rbtsub.TabIndex = 1;
            this.rbtsub.Text = "Subtração";
            this.rbtsub.UseVisualStyleBackColor = true;
            // 
            // rbtmult
            // 
            this.rbtmult.AutoSize = true;
            this.rbtmult.Location = new System.Drawing.Point(6, 65);
            this.rbtmult.Name = "rbtmult";
            this.rbtmult.Size = new System.Drawing.Size(87, 17);
            this.rbtmult.TabIndex = 2;
            this.rbtmult.Text = "Multiplicação";
            this.rbtmult.UseVisualStyleBackColor = true;
            // 
            // rbtdiv
            // 
            this.rbtdiv.AutoSize = true;
            this.rbtdiv.Location = new System.Drawing.Point(6, 88);
            this.rbtdiv.Name = "rbtdiv";
            this.rbtdiv.Size = new System.Drawing.Size(60, 17);
            this.rbtdiv.TabIndex = 3;
            this.rbtdiv.Text = "Divisão";
            this.rbtdiv.UseVisualStyleBackColor = true;
            // 
            // rbtmed
            // 
            this.rbtmed.AutoSize = true;
            this.rbtmed.Location = new System.Drawing.Point(6, 111);
            this.rbtmed.Name = "rbtmed";
            this.rbtmed.Size = new System.Drawing.Size(54, 17);
            this.rbtmed.TabIndex = 4;
            this.rbtmed.Text = "Média";
            this.rbtmed.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtmedpond);
            this.groupBox1.Controls.Add(this.rbtsoma);
            this.groupBox1.Controls.Add(this.rbtmed);
            this.groupBox1.Controls.Add(this.rbtsub);
            this.groupBox1.Controls.Add(this.rbtdiv);
            this.groupBox1.Controls.Add(this.rbtmult);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 163);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtmedpond
            // 
            this.rbtmedpond.AutoSize = true;
            this.rbtmedpond.Location = new System.Drawing.Point(6, 134);
            this.rbtmedpond.Name = "rbtmedpond";
            this.rbtmedpond.Size = new System.Drawing.Size(109, 17);
            this.rbtmedpond.TabIndex = 5;
            this.rbtmedpond.Text = "Média Ponderada";
            this.rbtmedpond.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(139, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 162);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(48, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Peso 2";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(48, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Peso 1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultado:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(166, 183);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(304, 216);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtsoma;
        private System.Windows.Forms.RadioButton rbtsub;
        private System.Windows.Forms.RadioButton rbtmult;
        private System.Windows.Forms.RadioButton rbtdiv;
        private System.Windows.Forms.RadioButton rbtmed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton rbtmedpond;
    }
}

