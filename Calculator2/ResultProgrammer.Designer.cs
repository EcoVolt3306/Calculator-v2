
namespace Calculator2
{
    partial class ResultProgrammer
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
            this.outExp = new System.Windows.Forms.Label();
            this.outResult = new System.Windows.Forms.Label();
            this.ViewOCT = new System.Windows.Forms.RadioButton();
            this.ViewBIN = new System.Windows.Forms.RadioButton();
            this.ViewDEC = new System.Windows.Forms.RadioButton();
            this.ViewHEX = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // outExp
            // 
            this.outExp.Font = new System.Drawing.Font("넥슨Lv2고딕", 11F);
            this.outExp.Location = new System.Drawing.Point(49, 0);
            this.outExp.Name = "outExp";
            this.outExp.Size = new System.Drawing.Size(277, 27);
            this.outExp.TabIndex = 21;
            this.outExp.Text = "(exp)";
            this.outExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outResult
            // 
            this.outResult.Font = new System.Drawing.Font("넥슨Lv2고딕", 24F);
            this.outResult.Location = new System.Drawing.Point(50, 27);
            this.outResult.Name = "outResult";
            this.outResult.Size = new System.Drawing.Size(281, 67);
            this.outResult.TabIndex = 20;
            this.outResult.Text = "0";
            this.outResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ViewOCT
            // 
            this.ViewOCT.AutoSize = true;
            this.ViewOCT.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.ViewOCT.Location = new System.Drawing.Point(2, 50);
            this.ViewOCT.Name = "ViewOCT";
            this.ViewOCT.Size = new System.Drawing.Size(47, 17);
            this.ViewOCT.TabIndex = 19;
            this.ViewOCT.Text = "OCT";
            this.ViewOCT.UseVisualStyleBackColor = true;
            this.ViewOCT.CheckedChanged += new System.EventHandler(this.ViewOCT_CheckedChanged);
            // 
            // ViewBIN
            // 
            this.ViewBIN.AutoSize = true;
            this.ViewBIN.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.ViewBIN.Location = new System.Drawing.Point(2, 73);
            this.ViewBIN.Name = "ViewBIN";
            this.ViewBIN.Size = new System.Drawing.Size(42, 17);
            this.ViewBIN.TabIndex = 18;
            this.ViewBIN.Text = "BIN";
            this.ViewBIN.UseVisualStyleBackColor = true;
            this.ViewBIN.CheckedChanged += new System.EventHandler(this.ViewBIN_CheckedChanged);
            // 
            // ViewDEC
            // 
            this.ViewDEC.AutoSize = true;
            this.ViewDEC.Checked = true;
            this.ViewDEC.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.ViewDEC.Location = new System.Drawing.Point(2, 27);
            this.ViewDEC.Name = "ViewDEC";
            this.ViewDEC.Size = new System.Drawing.Size(46, 17);
            this.ViewDEC.TabIndex = 17;
            this.ViewDEC.TabStop = true;
            this.ViewDEC.Text = "DEC";
            this.ViewDEC.UseVisualStyleBackColor = true;
            this.ViewDEC.CheckedChanged += new System.EventHandler(this.ViewDEC_CheckedChanged);
            // 
            // ViewHEX
            // 
            this.ViewHEX.AutoSize = true;
            this.ViewHEX.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.ViewHEX.Location = new System.Drawing.Point(2, 4);
            this.ViewHEX.Name = "ViewHEX";
            this.ViewHEX.Size = new System.Drawing.Size(46, 17);
            this.ViewHEX.TabIndex = 16;
            this.ViewHEX.Text = "HEX";
            this.ViewHEX.UseVisualStyleBackColor = true;
            this.ViewHEX.CheckedChanged += new System.EventHandler(this.ViewHEX_CheckedChanged);
            // 
            // ResultProgrammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outExp);
            this.Controls.Add(this.outResult);
            this.Controls.Add(this.ViewOCT);
            this.Controls.Add(this.ViewBIN);
            this.Controls.Add(this.ViewDEC);
            this.Controls.Add(this.ViewHEX);
            this.Name = "ResultProgrammer";
            this.Size = new System.Drawing.Size(332, 94);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outExp;
        private System.Windows.Forms.Label outResult;
        private System.Windows.Forms.RadioButton ViewOCT;
        private System.Windows.Forms.RadioButton ViewBIN;
        private System.Windows.Forms.RadioButton ViewDEC;
        private System.Windows.Forms.RadioButton ViewHEX;
    }
}
