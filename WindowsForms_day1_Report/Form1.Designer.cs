namespace WindowsForms_day1_Report
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b_equal = new System.Windows.Forms.Button();
            this.b_dot = new System.Windows.Forms.Button();
            this.b_abs = new System.Windows.Forms.Button();
            this.b_share = new System.Windows.Forms.Button();
            this.b_pow = new System.Windows.Forms.Button();
            this.b_multiply = new System.Windows.Forms.Button();
            this.b_div = new System.Windows.Forms.Button();
            this.b_sub = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.b_backspace = new System.Windows.Forms.Button();
            this.b_clear = new System.Windows.Forms.Button();
            this.Accumulate_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB
            // 
            this.TB.Font = new System.Drawing.Font("나눔스퀘어OTF ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TB.Location = new System.Drawing.Point(303, 186);
            this.TB.Name = "TB";
            this.TB.ReadOnly = true;
            this.TB.Size = new System.Drawing.Size(508, 48);
            this.TB.TabIndex = 0;
            this.TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(303, 254);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(52, 56);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(303, 324);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(52, 56);
            this.b4.TabIndex = 2;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(303, 395);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(52, 56);
            this.b7.TabIndex = 3;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(360, 469);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(52, 56);
            this.b0.TabIndex = 4;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(360, 395);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(52, 56);
            this.b8.TabIndex = 7;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(360, 324);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(52, 56);
            this.b5.TabIndex = 6;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(360, 254);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(52, 56);
            this.b2.TabIndex = 5;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(421, 395);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(52, 56);
            this.b9.TabIndex = 10;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(421, 324);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(52, 56);
            this.b6.TabIndex = 9;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(421, 254);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(52, 56);
            this.b3.TabIndex = 8;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b_equal
            // 
            this.b_equal.Location = new System.Drawing.Point(421, 469);
            this.b_equal.Name = "b_equal";
            this.b_equal.Size = new System.Drawing.Size(52, 56);
            this.b_equal.TabIndex = 19;
            this.b_equal.Text = "=";
            this.b_equal.UseVisualStyleBackColor = true;
            this.b_equal.Click += new System.EventHandler(this.b_equal_Click);
            // 
            // b_dot
            // 
            this.b_dot.Location = new System.Drawing.Point(303, 469);
            this.b_dot.Name = "b_dot";
            this.b_dot.Size = new System.Drawing.Size(52, 56);
            this.b_dot.TabIndex = 18;
            this.b_dot.Text = ".";
            this.b_dot.UseVisualStyleBackColor = true;
            this.b_dot.Click += new System.EventHandler(this.b_dot_Click);
            // 
            // b_abs
            // 
            this.b_abs.Location = new System.Drawing.Point(732, 469);
            this.b_abs.Name = "b_abs";
            this.b_abs.Size = new System.Drawing.Size(52, 56);
            this.b_abs.TabIndex = 17;
            this.b_abs.Text = "abs";
            this.b_abs.UseVisualStyleBackColor = true;
            this.b_abs.Click += new System.EventHandler(this.b_abs_Click);
            // 
            // b_share
            // 
            this.b_share.Location = new System.Drawing.Point(658, 469);
            this.b_share.Name = "b_share";
            this.b_share.Size = new System.Drawing.Size(52, 56);
            this.b_share.TabIndex = 16;
            this.b_share.Text = "%";
            this.b_share.UseVisualStyleBackColor = true;
            this.b_share.Click += new System.EventHandler(this.b_share_Click);
            // 
            // b_pow
            // 
            this.b_pow.Location = new System.Drawing.Point(658, 395);
            this.b_pow.Name = "b_pow";
            this.b_pow.Size = new System.Drawing.Size(52, 56);
            this.b_pow.TabIndex = 15;
            this.b_pow.Text = "^";
            this.b_pow.UseVisualStyleBackColor = true;
            this.b_pow.Click += new System.EventHandler(this.b_pow_Click);
            // 
            // b_multiply
            // 
            this.b_multiply.Location = new System.Drawing.Point(590, 395);
            this.b_multiply.Name = "b_multiply";
            this.b_multiply.Size = new System.Drawing.Size(52, 56);
            this.b_multiply.TabIndex = 14;
            this.b_multiply.Text = "*";
            this.b_multiply.UseVisualStyleBackColor = true;
            this.b_multiply.Click += new System.EventHandler(this.b_multiply_Click);
            // 
            // b_div
            // 
            this.b_div.Location = new System.Drawing.Point(590, 469);
            this.b_div.Name = "b_div";
            this.b_div.Size = new System.Drawing.Size(52, 56);
            this.b_div.TabIndex = 13;
            this.b_div.Text = "/";
            this.b_div.UseVisualStyleBackColor = true;
            this.b_div.Click += new System.EventHandler(this.b_div_Click);
            // 
            // b_sub
            // 
            this.b_sub.Location = new System.Drawing.Point(658, 324);
            this.b_sub.Name = "b_sub";
            this.b_sub.Size = new System.Drawing.Size(52, 56);
            this.b_sub.TabIndex = 12;
            this.b_sub.Text = "-";
            this.b_sub.UseVisualStyleBackColor = true;
            this.b_sub.Click += new System.EventHandler(this.b_sub_Click);
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(590, 324);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(52, 56);
            this.b_add.TabIndex = 11;
            this.b_add.Text = "+";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // b_backspace
            // 
            this.b_backspace.Location = new System.Drawing.Point(504, 469);
            this.b_backspace.Name = "b_backspace";
            this.b_backspace.Size = new System.Drawing.Size(52, 56);
            this.b_backspace.TabIndex = 21;
            this.b_backspace.Text = "S";
            this.b_backspace.UseVisualStyleBackColor = true;
            this.b_backspace.Click += new System.EventHandler(this.b_backspace_Click);
            // 
            // b_clear
            // 
            this.b_clear.Location = new System.Drawing.Point(504, 395);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(52, 56);
            this.b_clear.TabIndex = 20;
            this.b_clear.Text = "C";
            this.b_clear.UseVisualStyleBackColor = true;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // Accumulate_TB
            // 
            this.Accumulate_TB.Font = new System.Drawing.Font("나눔스퀘어OTF ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Accumulate_TB.Location = new System.Drawing.Point(303, 122);
            this.Accumulate_TB.Name = "Accumulate_TB";
            this.Accumulate_TB.ReadOnly = true;
            this.Accumulate_TB.Size = new System.Drawing.Size(508, 48);
            this.Accumulate_TB.TabIndex = 22;
            this.Accumulate_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Accumulate_TB.TextChanged += new System.EventHandler(this.Accumulate_TB_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 794);
            this.Controls.Add(this.Accumulate_TB);
            this.Controls.Add(this.b_backspace);
            this.Controls.Add(this.b_clear);
            this.Controls.Add(this.b_equal);
            this.Controls.Add(this.b_dot);
            this.Controls.Add(this.b_abs);
            this.Controls.Add(this.b_share);
            this.Controls.Add(this.b_pow);
            this.Controls.Add(this.b_multiply);
            this.Controls.Add(this.b_div);
            this.Controls.Add(this.b_sub);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b_equal;
        private System.Windows.Forms.Button b_dot;
        private System.Windows.Forms.Button b_abs;
        private System.Windows.Forms.Button b_share;
        private System.Windows.Forms.Button b_pow;
        private System.Windows.Forms.Button b_multiply;
        private System.Windows.Forms.Button b_div;
        private System.Windows.Forms.Button b_sub;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_backspace;
        private System.Windows.Forms.Button b_clear;
        private System.Windows.Forms.TextBox Accumulate_TB;
    }
}

