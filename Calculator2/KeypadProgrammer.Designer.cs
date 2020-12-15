
namespace Calculator2
{
    partial class KeypadProgrammer
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
            this.KeyBit = new System.Windows.Forms.Button();
            this.KeyStn = new System.Windows.Forms.Button();
            this.AreaPgmKey = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // KeyBit
            // 
            this.KeyBit.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.KeyBit.Location = new System.Drawing.Point(246, 3);
            this.KeyBit.Name = "KeyBit";
            this.KeyBit.Size = new System.Drawing.Size(83, 23);
            this.KeyBit.TabIndex = 7;
            this.KeyBit.Text = "비트 키패드";
            this.KeyBit.UseVisualStyleBackColor = true;
            this.KeyBit.Visible = false;
            this.KeyBit.Click += new System.EventHandler(this.KeyBit_Click);
            // 
            // KeyStn
            // 
            this.KeyStn.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.KeyStn.Location = new System.Drawing.Point(157, 3);
            this.KeyStn.Name = "KeyStn";
            this.KeyStn.Size = new System.Drawing.Size(83, 23);
            this.KeyStn.TabIndex = 6;
            this.KeyStn.Text = "기본 키패드";
            this.KeyStn.UseVisualStyleBackColor = true;
            this.KeyStn.Visible = false;
            this.KeyStn.Click += new System.EventHandler(this.KeyStn_Click);
            // 
            // AreaPgmKey
            // 
            this.AreaPgmKey.Location = new System.Drawing.Point(3, 3);
            this.AreaPgmKey.Name = "AreaPgmKey";
            this.AreaPgmKey.Size = new System.Drawing.Size(326, 260);
            this.AreaPgmKey.TabIndex = 8;
            // 
            // KeypadProgrammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.KeyBit);
            this.Controls.Add(this.KeyStn);
            this.Controls.Add(this.AreaPgmKey);
            this.Name = "KeypadProgrammer";
            this.Size = new System.Drawing.Size(332, 266);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KeyBit;
        private System.Windows.Forms.Button KeyStn;
        private System.Windows.Forms.Panel AreaPgmKey;
    }
}
