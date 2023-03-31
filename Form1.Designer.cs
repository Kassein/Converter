namespace Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            txtGLitres = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtResultG = new TextBox();
            txtT2G = new TextBox();
            txtT1G = new TextBox();
            txtQ = new TextBox();
            btnCalculateG = new Button();
            progressBar1 = new ProgressBar();
            txtQGkal = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            txtResultQ = new TextBox();
            txtT2Q = new TextBox();
            txtT1Q = new TextBox();
            txtG = new TextBox();
            btnCalculateQ = new Button();
            progressBar2 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtGLitres);
            splitContainer1.Panel1.Controls.Add(textBox3);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(txtResultG);
            splitContainer1.Panel1.Controls.Add(txtT2G);
            splitContainer1.Panel1.Controls.Add(txtT1G);
            splitContainer1.Panel1.Controls.Add(txtQ);
            splitContainer1.Panel1.Controls.Add(btnCalculateG);
            splitContainer1.Panel1.Controls.Add(progressBar1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtQGkal);
            splitContainer1.Panel2.Controls.Add(textBox4);
            splitContainer1.Panel2.Controls.Add(textBox5);
            splitContainer1.Panel2.Controls.Add(textBox6);
            splitContainer1.Panel2.Controls.Add(txtResultQ);
            splitContainer1.Panel2.Controls.Add(txtT2Q);
            splitContainer1.Panel2.Controls.Add(txtT1Q);
            splitContainer1.Panel2.Controls.Add(txtG);
            splitContainer1.Panel2.Controls.Add(btnCalculateQ);
            splitContainer1.Panel2.Controls.Add(progressBar2);
            splitContainer1.Panel2.Paint += btnCalculateG_Click;
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 399;
            splitContainer1.TabIndex = 0;
            // 
            // txtGLitres
            // 
            txtGLitres.Location = new Point(3, 302);
            txtGLitres.Name = "txtGLitres";
            txtGLitres.Size = new Size(389, 23);
            txtGLitres.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 81);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(44, 23);
            textBox3.TabIndex = 8;
            textBox3.Text = "T2 (°С)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(44, 23);
            textBox2.TabIndex = 7;
            textBox2.Text = "T1 (°С)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(44, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = "Q (кВт)";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtResultG
            // 
            txtResultG.Location = new Point(3, 273);
            txtResultG.Name = "txtResultG";
            txtResultG.Size = new Size(389, 23);
            txtResultG.TabIndex = 5;
            // 
            // txtT2G
            // 
            txtT2G.Location = new Point(53, 81);
            txtT2G.Name = "txtT2G";
            txtT2G.Size = new Size(117, 23);
            txtT2G.TabIndex = 4;
            // 
            // txtT1G
            // 
            txtT1G.Location = new Point(53, 52);
            txtT1G.Name = "txtT1G";
            txtT1G.Size = new Size(117, 23);
            txtT1G.TabIndex = 3;
            // 
            // txtQ
            // 
            txtQ.Location = new Point(53, 23);
            txtQ.Name = "txtQ";
            txtQ.Size = new Size(117, 23);
            txtQ.TabIndex = 2;
            // 
            // btnCalculateG
            // 
            btnCalculateG.Location = new Point(3, 183);
            btnCalculateG.Name = "btnCalculateG";
            btnCalculateG.Size = new Size(389, 23);
            btnCalculateG.TabIndex = 1;
            btnCalculateG.Text = "Расчитать расход G";
            btnCalculateG.UseVisualStyleBackColor = true;
            btnCalculateG.Click += btnCalculateG_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(3, 224);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(389, 23);
            progressBar1.TabIndex = 0;
            // 
            // txtQGkal
            // 
            txtQGkal.Location = new Point(3, 302);
            txtQGkal.Name = "txtQGkal";
            txtQGkal.Size = new Size(387, 23);
            txtQGkal.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 81);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(58, 23);
            textBox4.TabIndex = 12;
            textBox4.Text = "T2 (°С)";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(3, 52);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(58, 23);
            textBox5.TabIndex = 11;
            textBox5.Text = "T1 (°С)";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(3, 23);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(58, 23);
            textBox6.TabIndex = 10;
            textBox6.Text = "G (м3/ч)";
            // 
            // txtResultQ
            // 
            txtResultQ.Location = new Point(3, 273);
            txtResultQ.Name = "txtResultQ";
            txtResultQ.Size = new Size(387, 23);
            txtResultQ.TabIndex = 9;
            // 
            // txtT2Q
            // 
            txtT2Q.Location = new Point(67, 81);
            txtT2Q.Name = "txtT2Q";
            txtT2Q.Size = new Size(117, 23);
            txtT2Q.TabIndex = 8;
            // 
            // txtT1Q
            // 
            txtT1Q.Location = new Point(67, 52);
            txtT1Q.Name = "txtT1Q";
            txtT1Q.Size = new Size(117, 23);
            txtT1Q.TabIndex = 7;
            // 
            // txtG
            // 
            txtG.Location = new Point(67, 23);
            txtG.Name = "txtG";
            txtG.Size = new Size(117, 23);
            txtG.TabIndex = 6;
            // 
            // btnCalculateQ
            // 
            btnCalculateQ.Location = new Point(3, 183);
            btnCalculateQ.Name = "btnCalculateQ";
            btnCalculateQ.Size = new Size(387, 23);
            btnCalculateQ.TabIndex = 1;
            btnCalculateQ.Text = "Расчитать нагрузку Q";
            btnCalculateQ.UseVisualStyleBackColor = true;
            btnCalculateQ.Click += btnCalculateQ_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(3, 224);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(387, 23);
            progressBar2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnCalculateG;
        private ProgressBar progressBar1;
        private Button btnCalculateQ;
        private ProgressBar progressBar2;
        private TextBox txtResultG;
        private TextBox txtT2G;
        private TextBox txtT1G;
        private TextBox txtQ;
        private TextBox txtResultQ;
        private TextBox txtT2Q;
        private TextBox txtT1Q;
        private TextBox txtG;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox txtGLitres;
        private TextBox txtQGkal;
    }
}