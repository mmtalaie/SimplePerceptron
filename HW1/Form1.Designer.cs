namespace HW1
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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxlr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.cxy = new System.Windows.Forms.TextBox();
            this.cyy = new System.Windows.Forms.TextBox();
            this.my = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cyx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cxx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mx = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cxy2 = new System.Windows.Forms.TextBox();
            this.cyy2 = new System.Windows.Forms.TextBox();
            this.my2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cyx2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cxx2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mx2 = new System.Windows.Forms.TextBox();
            this.btnPlot = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxe = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxbs = new System.Windows.Forms.TextBox();
            this.crntepc = new System.Windows.Forms.Label();
            this.chbrlr = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxCount = new System.Windows.Forms.TextBox();
            this.btnHeb = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblcurnheb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsAutoScrollRange = true;
            this.zedGraphControl1.IsShowCursorValues = true;
            this.zedGraphControl1.IsShowVScrollBar = true;
            this.zedGraphControl1.IsSynchronizeXAxes = true;
            this.zedGraphControl1.IsSynchronizeYAxes = true;
            this.zedGraphControl1.Location = new System.Drawing.Point(13, 13);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(451, 392);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(799, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Perseptron";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxlr
            // 
            this.tbxlr.Location = new System.Drawing.Point(565, 355);
            this.tbxlr.Name = "tbxlr";
            this.tbxlr.Size = new System.Drawing.Size(124, 20);
            this.tbxlr.TabIndex = 2;
            this.tbxlr.Text = "0.001";
            this.tbxlr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Learning Rate :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.x);
            this.groupBox1.Controls.Add(this.cxy);
            this.groupBox1.Controls.Add(this.cyy);
            this.groupBox1.Controls.Add(this.my);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cyx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cxx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mx);
            this.groupBox1.Location = new System.Drawing.Point(488, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 138);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataSet 1";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(80, 29);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(13, 13);
            this.x.TabIndex = 13;
            this.x.Text = "1";
            // 
            // cxy
            // 
            this.cxy.Location = new System.Drawing.Point(114, 71);
            this.cxy.Name = "cxy";
            this.cxy.Size = new System.Drawing.Size(34, 20);
            this.cxy.TabIndex = 12;
            this.cxy.Text = "0";
            // 
            // cyy
            // 
            this.cyy.Location = new System.Drawing.Point(114, 97);
            this.cyy.Name = "cyy";
            this.cyy.Size = new System.Drawing.Size(34, 20);
            this.cyy.TabIndex = 11;
            this.cyy.Text = "6";
            // 
            // my
            // 
            this.my.Location = new System.Drawing.Point(114, 45);
            this.my.Name = "my";
            this.my.Size = new System.Drawing.Size(34, 20);
            this.my.TabIndex = 10;
            this.my.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cov 2";
            // 
            // cyx
            // 
            this.cyx.Location = new System.Drawing.Point(69, 97);
            this.cyx.Name = "cyx";
            this.cyx.Size = new System.Drawing.Size(34, 20);
            this.cyx.TabIndex = 8;
            this.cyx.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cov 1";
            // 
            // cxx
            // 
            this.cxx.Location = new System.Drawing.Point(69, 71);
            this.cxx.Name = "cxx";
            this.cxx.Size = new System.Drawing.Size(34, 20);
            this.cxx.TabIndex = 6;
            this.cxx.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mean";
            // 
            // mx
            // 
            this.mx.Location = new System.Drawing.Point(69, 45);
            this.mx.Name = "mx";
            this.mx.Size = new System.Drawing.Size(34, 20);
            this.mx.TabIndex = 4;
            this.mx.Text = "4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cxy2);
            this.groupBox2.Controls.Add(this.cyy2);
            this.groupBox2.Controls.Add(this.my2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cyx2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cxx2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.mx2);
            this.groupBox2.Location = new System.Drawing.Point(685, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 138);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSet 2";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "1";
            // 
            // cxy2
            // 
            this.cxy2.Location = new System.Drawing.Point(114, 71);
            this.cxy2.Name = "cxy2";
            this.cxy2.Size = new System.Drawing.Size(34, 20);
            this.cxy2.TabIndex = 12;
            this.cxy2.Text = "0";
            // 
            // cyy2
            // 
            this.cyy2.Location = new System.Drawing.Point(114, 97);
            this.cyy2.Name = "cyy2";
            this.cyy2.Size = new System.Drawing.Size(34, 20);
            this.cyy2.TabIndex = 11;
            this.cyy2.Text = "2";
            // 
            // my2
            // 
            this.my2.Location = new System.Drawing.Point(114, 45);
            this.my2.Name = "my2";
            this.my2.Size = new System.Drawing.Size(34, 20);
            this.my2.TabIndex = 10;
            this.my2.Text = "-7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cov 2";
            // 
            // cyx2
            // 
            this.cyx2.Location = new System.Drawing.Point(69, 97);
            this.cyx2.Name = "cyx2";
            this.cyx2.Size = new System.Drawing.Size(34, 20);
            this.cyx2.TabIndex = 8;
            this.cyx2.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cov 1";
            // 
            // cxx2
            // 
            this.cxx2.Location = new System.Drawing.Point(69, 71);
            this.cxx2.Name = "cxx2";
            this.cxx2.Size = new System.Drawing.Size(34, 20);
            this.cxx2.TabIndex = 6;
            this.cxx2.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Mean";
            // 
            // mx2
            // 
            this.mx2.Location = new System.Drawing.Point(69, 45);
            this.mx2.Name = "mx2";
            this.mx2.Size = new System.Drawing.Size(34, 20);
            this.mx2.TabIndex = 4;
            this.mx2.Text = "-2";
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(780, 226);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(75, 23);
            this.btnPlot.TabIndex = 16;
            this.btnPlot.Text = "PlotData";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(695, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(485, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Epoch  :";
            this.label11.UseWaitCursor = true;
            // 
            // tbxe
            // 
            this.tbxe.Location = new System.Drawing.Point(565, 329);
            this.tbxe.Name = "tbxe";
            this.tbxe.Size = new System.Drawing.Size(81, 20);
            this.tbxe.TabIndex = 18;
            this.tbxe.Text = "10";
            this.tbxe.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(485, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Batch Size";
            this.label12.UseWaitCursor = true;
            // 
            // tbxbs
            // 
            this.tbxbs.Location = new System.Drawing.Point(565, 303);
            this.tbxbs.Name = "tbxbs";
            this.tbxbs.Size = new System.Drawing.Size(81, 20);
            this.tbxbs.TabIndex = 20;
            this.tbxbs.Text = "10";
            this.tbxbs.UseWaitCursor = true;
            // 
            // crntepc
            // 
            this.crntepc.AutoSize = true;
            this.crntepc.Location = new System.Drawing.Point(427, 420);
            this.crntepc.Name = "crntepc";
            this.crntepc.Size = new System.Drawing.Size(0, 13);
            this.crntepc.TabIndex = 22;
            // 
            // chbrlr
            // 
            this.chbrlr.AutoSize = true;
            this.chbrlr.Checked = true;
            this.chbrlr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbrlr.Location = new System.Drawing.Point(762, 357);
            this.chbrlr.Name = "chbrlr";
            this.chbrlr.Size = new System.Drawing.Size(171, 17);
            this.chbrlr.TabIndex = 23;
            this.chbrlr.Text = "Reduce LR after some epochs";
            this.chbrlr.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(485, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Data count";
            this.label13.UseWaitCursor = true;
            // 
            // tbxCount
            // 
            this.tbxCount.Location = new System.Drawing.Point(565, 214);
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.Size = new System.Drawing.Size(81, 20);
            this.tbxCount.TabIndex = 24;
            this.tbxCount.Text = "1000";
            this.tbxCount.UseWaitCursor = true;
            // 
            // btnHeb
            // 
            this.btnHeb.BackColor = System.Drawing.Color.Green;
            this.btnHeb.Enabled = false;
            this.btnHeb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHeb.Location = new System.Drawing.Point(713, 417);
            this.btnHeb.Name = "btnHeb";
            this.btnHeb.Size = new System.Drawing.Size(75, 23);
            this.btnHeb.TabIndex = 26;
            this.btnHeb.Text = "Heb";
            this.btnHeb.UseVisualStyleBackColor = false;
            this.btnHeb.Click += new System.EventHandler(this.btnHeb_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(632, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "To Gather";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblcurnheb
            // 
            this.lblcurnheb.AutoSize = true;
            this.lblcurnheb.Location = new System.Drawing.Point(199, 417);
            this.lblcurnheb.Name = "lblcurnheb";
            this.lblcurnheb.Size = new System.Drawing.Size(0, 13);
            this.lblcurnheb.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.lblcurnheb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnHeb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxCount);
            this.Controls.Add(this.chbrlr);
            this.Controls.Add(this.crntepc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxbs);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxlr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxlr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.TextBox cxy;
        private System.Windows.Forms.TextBox cyy;
        private System.Windows.Forms.TextBox my;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cyx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cxx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cxy2;
        private System.Windows.Forms.TextBox cyy2;
        private System.Windows.Forms.TextBox my2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cyx2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cxx2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mx2;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxbs;
        private System.Windows.Forms.Label crntepc;
        private System.Windows.Forms.CheckBox chbrlr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxCount;
        private System.Windows.Forms.Button btnHeb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblcurnheb;
    }
}

