namespace HitAndBlow
{
    partial class OneToOneMode
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blackbtn = new System.Windows.Forms.Button();
            this.purplebtn = new System.Windows.Forms.Button();
            this.greenbtn = new System.Windows.Forms.Button();
            this.lightgreenbtn = new System.Windows.Forms.Button();
            this.yellowbtn = new System.Windows.Forms.Button();
            this.pinkbtn = new System.Windows.Forms.Button();
            this.OpponentResult8 = new System.Windows.Forms.Panel();
            this.OpponentResult7 = new System.Windows.Forms.Panel();
            this.OpponentResult6 = new System.Windows.Forms.Panel();
            this.OpponentResult5 = new System.Windows.Forms.Panel();
            this.OpponentResult4 = new System.Windows.Forms.Panel();
            this.OpponentResult3 = new System.Windows.Forms.Panel();
            this.OpponentResult2 = new System.Windows.Forms.Panel();
            this.OpponentResult1 = new System.Windows.Forms.Panel();
            this.answerpanel = new System.Windows.Forms.Panel();
            this.colorselectionbtn = new System.Windows.Forms.Button();
            this.playerpanel8 = new System.Windows.Forms.Panel();
            this.playerpanel7 = new System.Windows.Forms.Panel();
            this.playerpanel6 = new System.Windows.Forms.Panel();
            this.playerpanel5 = new System.Windows.Forms.Panel();
            this.playerpanel4 = new System.Windows.Forms.Panel();
            this.playerpanel3 = new System.Windows.Forms.Panel();
            this.playerpanel2 = new System.Windows.Forms.Panel();
            this.playerpanel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.connectionLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.blackbtn);
            this.groupBox1.Controls.Add(this.purplebtn);
            this.groupBox1.Controls.Add(this.greenbtn);
            this.groupBox1.Controls.Add(this.lightgreenbtn);
            this.groupBox1.Controls.Add(this.yellowbtn);
            this.groupBox1.Controls.Add(this.pinkbtn);
            this.groupBox1.Location = new System.Drawing.Point(365, 472);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 75);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // blackbtn
            // 
            this.blackbtn.BackColor = System.Drawing.Color.Black;
            this.blackbtn.Location = new System.Drawing.Point(430, 10);
            this.blackbtn.Name = "blackbtn";
            this.blackbtn.Size = new System.Drawing.Size(60, 60);
            this.blackbtn.TabIndex = 16;
            this.blackbtn.UseVisualStyleBackColor = false;
            this.blackbtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // purplebtn
            // 
            this.purplebtn.BackColor = System.Drawing.Color.Purple;
            this.purplebtn.Location = new System.Drawing.Point(346, 11);
            this.purplebtn.Name = "purplebtn";
            this.purplebtn.Size = new System.Drawing.Size(60, 60);
            this.purplebtn.TabIndex = 15;
            this.purplebtn.UseVisualStyleBackColor = false;
            this.purplebtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // greenbtn
            // 
            this.greenbtn.BackColor = System.Drawing.Color.Green;
            this.greenbtn.Location = new System.Drawing.Point(260, 11);
            this.greenbtn.Name = "greenbtn";
            this.greenbtn.Size = new System.Drawing.Size(60, 60);
            this.greenbtn.TabIndex = 14;
            this.greenbtn.UseVisualStyleBackColor = false;
            this.greenbtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // lightgreenbtn
            // 
            this.lightgreenbtn.BackColor = System.Drawing.Color.LightGreen;
            this.lightgreenbtn.Location = new System.Drawing.Point(173, 11);
            this.lightgreenbtn.Name = "lightgreenbtn";
            this.lightgreenbtn.Size = new System.Drawing.Size(60, 60);
            this.lightgreenbtn.TabIndex = 13;
            this.lightgreenbtn.UseVisualStyleBackColor = false;
            this.lightgreenbtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // yellowbtn
            // 
            this.yellowbtn.BackColor = System.Drawing.Color.Yellow;
            this.yellowbtn.Location = new System.Drawing.Point(88, 11);
            this.yellowbtn.Name = "yellowbtn";
            this.yellowbtn.Size = new System.Drawing.Size(60, 60);
            this.yellowbtn.TabIndex = 12;
            this.yellowbtn.UseVisualStyleBackColor = false;
            this.yellowbtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // pinkbtn
            // 
            this.pinkbtn.BackColor = System.Drawing.Color.Pink;
            this.pinkbtn.Location = new System.Drawing.Point(3, 11);
            this.pinkbtn.Name = "pinkbtn";
            this.pinkbtn.Size = new System.Drawing.Size(60, 60);
            this.pinkbtn.TabIndex = 11;
            this.pinkbtn.UseVisualStyleBackColor = false;
            this.pinkbtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // OpponentResult8
            // 
            this.OpponentResult8.BackColor = System.Drawing.SystemColors.Control;
            this.OpponentResult8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpponentResult8.Location = new System.Drawing.Point(922, 176);
            this.OpponentResult8.Name = "OpponentResult8";
            this.OpponentResult8.Size = new System.Drawing.Size(70, 280);
            this.OpponentResult8.TabIndex = 18;
            // 
            // OpponentResult7
            // 
            this.OpponentResult7.BackColor = System.Drawing.SystemColors.Control;
            this.OpponentResult7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpponentResult7.Location = new System.Drawing.Point(825, 176);
            this.OpponentResult7.Name = "OpponentResult7";
            this.OpponentResult7.Size = new System.Drawing.Size(70, 280);
            this.OpponentResult7.TabIndex = 17;
            // 
            // OpponentResult6
            // 
            this.OpponentResult6.BackColor = System.Drawing.SystemColors.Control;
            this.OpponentResult6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpponentResult6.Location = new System.Drawing.Point(729, 176);
            this.OpponentResult6.Name = "OpponentResult6";
            this.OpponentResult6.Size = new System.Drawing.Size(70, 280);
            this.OpponentResult6.TabIndex = 16;
            // 
            // OpponentResult5
            // 
            this.OpponentResult5.BackColor = System.Drawing.SystemColors.Control;
            this.OpponentResult5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpponentResult5.Location = new System.Drawing.Point(632, 176);
            this.OpponentResult5.Name = "OpponentResult5";
            this.OpponentResult5.Size = new System.Drawing.Size(70, 280);
            this.OpponentResult5.TabIndex = 15;
            // 
            // OpponentResult4
            // 
            this.OpponentResult4.BackColor = System.Drawing.SystemColors.Control;
            this.OpponentResult4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpponentResult4.Location = new System.Drawing.Point(534, 176);
            this.OpponentResult4.Name = "OpponentResult4";
            this.OpponentResult4.Size = new System.Drawing.Size(70, 280);
            this.OpponentResult4.TabIndex = 14;
            // 
            // OpponentResult3
            // 
            this.OpponentResult3.BackColor = System.Drawing.SystemColors.Control;
            this.OpponentResult3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpponentResult3.Location = new System.Drawing.Point(433, 176);
            this.OpponentResult3.Name = "OpponentResult3";
            this.OpponentResult3.Size = new System.Drawing.Size(70, 280);
            this.OpponentResult3.TabIndex = 13;
            // 
            // OpponentResult2
            // 
            this.OpponentResult2.BackColor = System.Drawing.SystemColors.Control;
            this.OpponentResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpponentResult2.Location = new System.Drawing.Point(333, 176);
            this.OpponentResult2.Name = "OpponentResult2";
            this.OpponentResult2.Size = new System.Drawing.Size(70, 280);
            this.OpponentResult2.TabIndex = 12;
            // 
            // OpponentResult1
            // 
            this.OpponentResult1.BackColor = System.Drawing.SystemColors.Control;
            this.OpponentResult1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpponentResult1.Location = new System.Drawing.Point(234, 176);
            this.OpponentResult1.Name = "OpponentResult1";
            this.OpponentResult1.Size = new System.Drawing.Size(70, 280);
            this.OpponentResult1.TabIndex = 11;
            // 
            // answerpanel
            // 
            this.answerpanel.BackColor = System.Drawing.SystemColors.Control;
            this.answerpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerpanel.Location = new System.Drawing.Point(1056, 382);
            this.answerpanel.Name = "answerpanel";
            this.answerpanel.Size = new System.Drawing.Size(70, 280);
            this.answerpanel.TabIndex = 19;
            // 
            // colorselectionbtn
            // 
            this.colorselectionbtn.BackColor = System.Drawing.Color.White;
            this.colorselectionbtn.Enabled = false;
            this.colorselectionbtn.Location = new System.Drawing.Point(903, 487);
            this.colorselectionbtn.Name = "colorselectionbtn";
            this.colorselectionbtn.Size = new System.Drawing.Size(50, 50);
            this.colorselectionbtn.TabIndex = 17;
            this.colorselectionbtn.UseVisualStyleBackColor = false;
            // 
            // playerpanel8
            // 
            this.playerpanel8.BackColor = System.Drawing.SystemColors.Control;
            this.playerpanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerpanel8.Location = new System.Drawing.Point(922, 575);
            this.playerpanel8.Name = "playerpanel8";
            this.playerpanel8.Size = new System.Drawing.Size(70, 280);
            this.playerpanel8.TabIndex = 10;
            // 
            // playerpanel7
            // 
            this.playerpanel7.BackColor = System.Drawing.SystemColors.Control;
            this.playerpanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerpanel7.Location = new System.Drawing.Point(825, 575);
            this.playerpanel7.Name = "playerpanel7";
            this.playerpanel7.Size = new System.Drawing.Size(70, 280);
            this.playerpanel7.TabIndex = 9;
            // 
            // playerpanel6
            // 
            this.playerpanel6.BackColor = System.Drawing.SystemColors.Control;
            this.playerpanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerpanel6.Location = new System.Drawing.Point(729, 575);
            this.playerpanel6.Name = "playerpanel6";
            this.playerpanel6.Size = new System.Drawing.Size(70, 280);
            this.playerpanel6.TabIndex = 8;
            // 
            // playerpanel5
            // 
            this.playerpanel5.BackColor = System.Drawing.SystemColors.Control;
            this.playerpanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerpanel5.Location = new System.Drawing.Point(632, 575);
            this.playerpanel5.Name = "playerpanel5";
            this.playerpanel5.Size = new System.Drawing.Size(70, 280);
            this.playerpanel5.TabIndex = 7;
            // 
            // playerpanel4
            // 
            this.playerpanel4.BackColor = System.Drawing.SystemColors.Control;
            this.playerpanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerpanel4.Location = new System.Drawing.Point(534, 575);
            this.playerpanel4.Name = "playerpanel4";
            this.playerpanel4.Size = new System.Drawing.Size(70, 280);
            this.playerpanel4.TabIndex = 6;
            // 
            // playerpanel3
            // 
            this.playerpanel3.BackColor = System.Drawing.SystemColors.Control;
            this.playerpanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerpanel3.Location = new System.Drawing.Point(433, 575);
            this.playerpanel3.Name = "playerpanel3";
            this.playerpanel3.Size = new System.Drawing.Size(70, 280);
            this.playerpanel3.TabIndex = 5;
            // 
            // playerpanel2
            // 
            this.playerpanel2.BackColor = System.Drawing.SystemColors.Control;
            this.playerpanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerpanel2.Location = new System.Drawing.Point(333, 575);
            this.playerpanel2.Name = "playerpanel2";
            this.playerpanel2.Size = new System.Drawing.Size(70, 280);
            this.playerpanel2.TabIndex = 1;
            // 
            // playerpanel1
            // 
            this.playerpanel1.BackColor = System.Drawing.SystemColors.Control;
            this.playerpanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerpanel1.Location = new System.Drawing.Point(234, 575);
            this.playerpanel1.Name = "playerpanel1";
            this.playerpanel1.Size = new System.Drawing.Size(70, 280);
            this.playerpanel1.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label.Location = new System.Drawing.Point(495, 32);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(132, 32);
            this.label.TabIndex = 4;
            this.label.Text = "카운트: ";
            // 
            // connectionLb
            // 
            this.connectionLb.AutoSize = true;
            this.connectionLb.Location = new System.Drawing.Point(12, 21);
            this.connectionLb.Name = "connectionLb";
            this.connectionLb.Size = new System.Drawing.Size(32, 12);
            this.connectionLb.TabIndex = 20;
            this.connectionLb.Text = "label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "label";
            // 
            // OneToOneMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectionLb);
            this.Controls.Add(this.colorselectionbtn);
            this.Controls.Add(this.answerpanel);
            this.Controls.Add(this.OpponentResult8);
            this.Controls.Add(this.OpponentResult7);
            this.Controls.Add(this.OpponentResult1);
            this.Controls.Add(this.OpponentResult6);
            this.Controls.Add(this.label);
            this.Controls.Add(this.OpponentResult2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OpponentResult3);
            this.Controls.Add(this.OpponentResult5);
            this.Controls.Add(this.OpponentResult4);
            this.Controls.Add(this.playerpanel1);
            this.Controls.Add(this.playerpanel2);
            this.Controls.Add(this.playerpanel3);
            this.Controls.Add(this.playerpanel4);
            this.Controls.Add(this.playerpanel5);
            this.Controls.Add(this.playerpanel6);
            this.Controls.Add(this.playerpanel7);
            this.Controls.Add(this.playerpanel8);
            this.Name = "OneToOneMode";
            this.Text = "1:1 모드";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OneToOneMode_FormClosing);
            this.Load += new System.EventHandler(this.OneToOneMode_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button blackbtn;
        private System.Windows.Forms.Button purplebtn;
        private System.Windows.Forms.Button greenbtn;
        private System.Windows.Forms.Button lightgreenbtn;
        private System.Windows.Forms.Button yellowbtn;
        private System.Windows.Forms.Button pinkbtn;
        private System.Windows.Forms.Panel OpponentResult8;
        private System.Windows.Forms.Panel OpponentResult7;
        private System.Windows.Forms.Panel OpponentResult6;
        private System.Windows.Forms.Panel OpponentResult5;
        private System.Windows.Forms.Panel OpponentResult4;
        private System.Windows.Forms.Panel OpponentResult3;
        private System.Windows.Forms.Panel OpponentResult2;
        private System.Windows.Forms.Panel OpponentResult1;
        private System.Windows.Forms.Panel answerpanel;
        private System.Windows.Forms.Button colorselectionbtn;
        private System.Windows.Forms.Panel playerpanel8;
        private System.Windows.Forms.Panel playerpanel7;
        private System.Windows.Forms.Panel playerpanel6;
        private System.Windows.Forms.Panel playerpanel5;
        private System.Windows.Forms.Panel playerpanel4;
        private System.Windows.Forms.Panel playerpanel3;
        private System.Windows.Forms.Panel playerpanel2;
        private System.Windows.Forms.Panel playerpanel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label connectionLb;
        private System.Windows.Forms.Label label1;
    }
}

