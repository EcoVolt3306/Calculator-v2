
namespace Calculator2
{
    partial class Frame
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
            this.AreaKeypad = new System.Windows.Forms.Panel();
            this.AreaResult = new System.Windows.Forms.Panel();
            this.MenuPgm = new System.Windows.Forms.Button();
            this.MenuStn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AreaKeypad
            // 
            this.AreaKeypad.Location = new System.Drawing.Point(12, 147);
            this.AreaKeypad.Name = "AreaKeypad";
            this.AreaKeypad.Size = new System.Drawing.Size(332, 266);
            this.AreaKeypad.TabIndex = 8;
            // 
            // AreaResult
            // 
            this.AreaResult.Location = new System.Drawing.Point(12, 47);
            this.AreaResult.Name = "AreaResult";
            this.AreaResult.Size = new System.Drawing.Size(332, 94);
            this.AreaResult.TabIndex = 7;
            // 
            // MenuPgm
            // 
            this.MenuPgm.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.MenuPgm.Location = new System.Drawing.Point(101, 12);
            this.MenuPgm.Name = "MenuPgm";
            this.MenuPgm.Size = new System.Drawing.Size(106, 29);
            this.MenuPgm.TabIndex = 6;
            this.MenuPgm.Text = "Programmer";
            this.MenuPgm.UseVisualStyleBackColor = true;
            this.MenuPgm.Click += new System.EventHandler(this.MenuPgm_Click);
            // 
            // MenuStn
            // 
            this.MenuStn.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.MenuStn.Location = new System.Drawing.Point(12, 12);
            this.MenuStn.Name = "MenuStn";
            this.MenuStn.Size = new System.Drawing.Size(83, 29);
            this.MenuStn.TabIndex = 5;
            this.MenuStn.Text = "Standard";
            this.MenuStn.UseVisualStyleBackColor = true;
            this.MenuStn.Click += new System.EventHandler(this.MenuStn_Click);
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AreaKeypad);
            this.Controls.Add(this.AreaResult);
            this.Controls.Add(this.MenuPgm);
            this.Controls.Add(this.MenuStn);
            this.Name = "Frame";
            this.Text = "Calculator V2.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AreaKeypad;
        private System.Windows.Forms.Panel AreaResult;
        private System.Windows.Forms.Button MenuPgm;
        private System.Windows.Forms.Button MenuStn;
    }
}

