
namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.numShortRest = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numWork = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numLongRest = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numShortCount = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.strCycle = new System.Windows.Forms.Label();
            this.strRestTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numShortRest)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWork)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLongRest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShortCount)).BeginInit();
            this.SuspendLayout();
            // 
            // numShortRest
            // 
            this.numShortRest.Location = new System.Drawing.Point(128, 23);
            this.numShortRest.Name = "numShortRest";
            this.numShortRest.Size = new System.Drawing.Size(40, 24);
            this.numShortRest.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "짧은 휴식 시간 : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numWork);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 62);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "집중 시간";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "작업 시간 : ";
            // 
            // numWork
            // 
            this.numWork.InterceptArrowKeys = false;
            this.numWork.Location = new System.Drawing.Point(99, 27);
            this.numWork.Name = "numWork";
            this.numWork.Size = new System.Drawing.Size(40, 24);
            this.numWork.TabIndex = 3;
            this.numWork.ValueChanged += new System.EventHandler(this.numWork_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numLongRest);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numShortCount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numShortRest);
            this.groupBox2.Location = new System.Drawing.Point(12, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 117);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "휴식 시간";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "짧은 휴식 반복 횟 수 : ";
            // 
            // numLongRest
            // 
            this.numLongRest.Location = new System.Drawing.Point(113, 82);
            this.numLongRest.Name = "numLongRest";
            this.numLongRest.Size = new System.Drawing.Size(40, 24);
            this.numLongRest.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "긴 휴식 시간 : ";
            // 
            // numShortCount
            // 
            this.numShortCount.Location = new System.Drawing.Point(174, 53);
            this.numShortCount.Name = "numShortCount";
            this.numShortCount.Size = new System.Drawing.Size(40, 24);
            this.numShortCount.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(93, 249);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(221, 249);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "정지";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "싸이클 수 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "남은 시간 :";
            // 
            // strCycle
            // 
            this.strCycle.AutoSize = true;
            this.strCycle.Location = new System.Drawing.Point(105, 215);
            this.strCycle.Name = "strCycle";
            this.strCycle.Size = new System.Drawing.Size(0, 15);
            this.strCycle.TabIndex = 12;
            // 
            // strRestTime
            // 
            this.strRestTime.AutoSize = true;
            this.strRestTime.Location = new System.Drawing.Point(226, 215);
            this.strRestTime.Name = "strRestTime";
            this.strRestTime.Size = new System.Drawing.Size(0, 15);
            this.strRestTime.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 282);
            this.Controls.Add(this.strRestTime);
            this.Controls.Add(this.strCycle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numShortRest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWork)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLongRest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShortCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown numShortRest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numLongRest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numShortCount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numWork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label strCycle;
        private System.Windows.Forms.Label strRestTime;
    }
}

