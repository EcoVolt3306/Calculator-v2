
namespace Calculator2
{
    partial class KeyBit
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.KeyStn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "비트 키패드 영역입니다.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.button1.Location = new System.Drawing.Point(240, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "비트 키패드";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // KeyStn
            // 
            this.KeyStn.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.KeyStn.Location = new System.Drawing.Point(151, 3);
            this.KeyStn.Name = "KeyStn";
            this.KeyStn.Size = new System.Drawing.Size(83, 23);
            this.KeyStn.TabIndex = 10;
            this.KeyStn.Text = "기본 키패드";
            this.KeyStn.UseVisualStyleBackColor = true;
            this.KeyStn.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 45);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(84, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 45);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(165, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 45);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(246, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 45);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(75, 45);
            this.panel5.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(3, 141);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(75, 45);
            this.panel6.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(3, 192);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(75, 45);
            this.panel7.TabIndex = 13;
            // 
            // KeyBit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KeyStn);
            this.Controls.Add(this.label1);
            this.Name = "KeyBit";
            this.Size = new System.Drawing.Size(326, 260);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button KeyStn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}
