namespace WindowsFormsApplication2
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.obliquity2 = new System.Windows.Forms.Label();
            this.variability2 = new System.Windows.Forms.Label();
            this.standardDeviation2 = new System.Windows.Forms.Label();
            this.meanB2 = new System.Windows.Forms.Label();
            this.meanG2 = new System.Windows.Forms.Label();
            this.meanR2 = new System.Windows.Forms.Label();
            this.obliquity1 = new System.Windows.Forms.Label();
            this.variability1 = new System.Windows.Forms.Label();
            this.standardDeviation1 = new System.Windows.Forms.Label();
            this.meanB1 = new System.Windows.Forms.Label();
            this.meanG1 = new System.Windows.Forms.Label();
            this.meanR1 = new System.Windows.Forms.Label();
            this.meanL2 = new System.Windows.Forms.Label();
            this.meanL1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(547, 22);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(481, 90);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(457, 382);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 480);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 283);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(913, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.obliquity2);
            this.panel1.Controls.Add(this.variability2);
            this.panel1.Controls.Add(this.standardDeviation2);
            this.panel1.Controls.Add(this.meanB2);
            this.panel1.Controls.Add(this.meanG2);
            this.panel1.Controls.Add(this.meanR2);
            this.panel1.Controls.Add(this.obliquity1);
            this.panel1.Controls.Add(this.variability1);
            this.panel1.Controls.Add(this.standardDeviation1);
            this.panel1.Controls.Add(this.meanB1);
            this.panel1.Controls.Add(this.meanG1);
            this.panel1.Controls.Add(this.meanR1);
            this.panel1.Controls.Add(this.meanL2);
            this.panel1.Controls.Add(this.meanL1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 246);
            this.panel1.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(220, 204);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 30);
            this.button8.TabIndex = 21;
            this.button8.Text = "sobel vertical";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(35, 204);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 30);
            this.button7.TabIndex = 20;
            this.button7.Text = "sobel horizontal";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // obliquity2
            // 
            this.obliquity2.AutoSize = true;
            this.obliquity2.Location = new System.Drawing.Point(641, 110);
            this.obliquity2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.obliquity2.Name = "obliquity2";
            this.obliquity2.Size = new System.Drawing.Size(14, 16);
            this.obliquity2.TabIndex = 19;
            this.obliquity2.Text = "0";
            this.obliquity2.Click += new System.EventHandler(this.label13_Click);
            // 
            // variability2
            // 
            this.variability2.AutoSize = true;
            this.variability2.Location = new System.Drawing.Point(641, 74);
            this.variability2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.variability2.Name = "variability2";
            this.variability2.Size = new System.Drawing.Size(14, 16);
            this.variability2.TabIndex = 18;
            this.variability2.Text = "0";
            // 
            // standardDeviation2
            // 
            this.standardDeviation2.AutoSize = true;
            this.standardDeviation2.Location = new System.Drawing.Point(641, 37);
            this.standardDeviation2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.standardDeviation2.Name = "standardDeviation2";
            this.standardDeviation2.Size = new System.Drawing.Size(14, 16);
            this.standardDeviation2.TabIndex = 17;
            this.standardDeviation2.Text = "0";
            // 
            // meanB2
            // 
            this.meanB2.AutoSize = true;
            this.meanB2.Location = new System.Drawing.Point(356, 145);
            this.meanB2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meanB2.Name = "meanB2";
            this.meanB2.Size = new System.Drawing.Size(14, 16);
            this.meanB2.TabIndex = 16;
            this.meanB2.Text = "0";
            // 
            // meanG2
            // 
            this.meanG2.AutoSize = true;
            this.meanG2.Location = new System.Drawing.Point(356, 110);
            this.meanG2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meanG2.Name = "meanG2";
            this.meanG2.Size = new System.Drawing.Size(14, 16);
            this.meanG2.TabIndex = 15;
            this.meanG2.Text = "0";
            // 
            // meanR2
            // 
            this.meanR2.AutoSize = true;
            this.meanR2.Location = new System.Drawing.Point(356, 74);
            this.meanR2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meanR2.Name = "meanR2";
            this.meanR2.Size = new System.Drawing.Size(14, 16);
            this.meanR2.TabIndex = 14;
            this.meanR2.Text = "0";
            // 
            // obliquity1
            // 
            this.obliquity1.AutoSize = true;
            this.obliquity1.Location = new System.Drawing.Point(567, 110);
            this.obliquity1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.obliquity1.Name = "obliquity1";
            this.obliquity1.Size = new System.Drawing.Size(62, 16);
            this.obliquity1.TabIndex = 12;
            this.obliquity1.Text = "Obliquity:";
            // 
            // variability1
            // 
            this.variability1.AutoSize = true;
            this.variability1.Location = new System.Drawing.Point(561, 74);
            this.variability1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.variability1.Name = "variability1";
            this.variability1.Size = new System.Drawing.Size(69, 16);
            this.variability1.TabIndex = 11;
            this.variability1.Text = "Variability:";
            this.variability1.Click += new System.EventHandler(this.variability1_Click);
            // 
            // standardDeviation1
            // 
            this.standardDeviation1.AutoSize = true;
            this.standardDeviation1.Location = new System.Drawing.Point(564, 38);
            this.standardDeviation1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.standardDeviation1.Name = "standardDeviation1";
            this.standardDeviation1.Size = new System.Drawing.Size(61, 16);
            this.standardDeviation1.TabIndex = 10;
            this.standardDeviation1.Text = "Std. Dev:";
            // 
            // meanB1
            // 
            this.meanB1.AutoSize = true;
            this.meanB1.Location = new System.Drawing.Point(285, 145);
            this.meanB1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meanB1.Name = "meanB1";
            this.meanB1.Size = new System.Drawing.Size(56, 16);
            this.meanB1.TabIndex = 9;
            this.meanB1.Text = "Mean B:";
            // 
            // meanG1
            // 
            this.meanG1.AutoSize = true;
            this.meanG1.Location = new System.Drawing.Point(284, 110);
            this.meanG1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meanG1.Name = "meanG1";
            this.meanG1.Size = new System.Drawing.Size(57, 16);
            this.meanG1.TabIndex = 8;
            this.meanG1.Text = "Mean G:";
            // 
            // meanR1
            // 
            this.meanR1.AutoSize = true;
            this.meanR1.Location = new System.Drawing.Point(284, 74);
            this.meanR1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meanR1.Name = "meanR1";
            this.meanR1.Size = new System.Drawing.Size(57, 16);
            this.meanR1.TabIndex = 7;
            this.meanR1.Text = "Mean R:";
            // 
            // meanL2
            // 
            this.meanL2.AutoSize = true;
            this.meanL2.Location = new System.Drawing.Point(356, 38);
            this.meanL2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meanL2.Name = "meanL2";
            this.meanL2.Size = new System.Drawing.Size(14, 16);
            this.meanL2.TabIndex = 6;
            this.meanL2.Text = "0";
            this.meanL2.Click += new System.EventHandler(this.meanL2_Click);
            // 
            // meanL1
            // 
            this.meanL1.AutoSize = true;
            this.meanL1.Location = new System.Drawing.Point(287, 38);
            this.meanL1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meanL1.Name = "meanL1";
            this.meanL1.Size = new System.Drawing.Size(54, 16);
            this.meanL1.TabIndex = 5;
            this.meanL1.Text = "Mean L:";
            this.meanL1.Click += new System.EventHandler(this.meanL1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(35, 169);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 28);
            this.button6.TabIndex = 4;
            this.button6.Text = "Rotate Colors";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(35, 62);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 28);
            this.button5.TabIndex = 3;
            this.button5.Text = " Blacky";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 97);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 28);
            this.button4.TabIndex = 2;
            this.button4.Text = " Grayscale";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 133);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = " Redy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = " Reset Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(913, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.zedGraphControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 246);
            this.panel2.TabIndex = 0;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(504, 17);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(360, 202);
            this.zedGraphControl1.TabIndex = 13;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 768);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label obliquity2;
        private System.Windows.Forms.Label variability2;
        private System.Windows.Forms.Label standardDeviation2;
        private System.Windows.Forms.Label meanB2;
        private System.Windows.Forms.Label meanG2;
        private System.Windows.Forms.Label meanR2;
        private System.Windows.Forms.Label obliquity1;
        private System.Windows.Forms.Label variability1;
        private System.Windows.Forms.Label standardDeviation1;
        private System.Windows.Forms.Label meanB1;
        private System.Windows.Forms.Label meanG1;
        private System.Windows.Forms.Label meanR1;
        private System.Windows.Forms.Label meanL2;
        private System.Windows.Forms.Label meanL1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

