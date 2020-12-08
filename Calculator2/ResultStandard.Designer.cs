
namespace Calculator2
{
    partial class ResultStandard
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
            this.SuspendLayout();
            // 
            // outExp
            // 
            this.outExp.Font = new System.Drawing.Font("넥슨Lv2고딕", 11F);
            this.outExp.Location = new System.Drawing.Point(0, 0);
            this.outExp.Name = "outExp";
            this.outExp.Size = new System.Drawing.Size(328, 27);
            this.outExp.TabIndex = 19;
            this.outExp.Text = "30 + 60 + 25 = ";
            this.outExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outResult
            // 
            this.outResult.Font = new System.Drawing.Font("넥슨Lv2고딕", 28F);
            this.outResult.Location = new System.Drawing.Point(1, 27);
            this.outResult.Name = "outResult";
            this.outResult.Size = new System.Drawing.Size(332, 67);
            this.outResult.TabIndex = 18;
            this.outResult.Text = "115";
            this.outResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResultStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outExp);
            this.Controls.Add(this.outResult);
            this.Name = "ResultStandard";
            this.Size = new System.Drawing.Size(332, 94);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outExp;
        private System.Windows.Forms.Label outResult;
    }
}
