﻿namespace MenuStatusPrac
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.새프로젝트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새솔루션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로젝트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.빌드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.디버그ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.테스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.분석ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도구ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배고픔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배고파ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보통ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배불러ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.프로젝트ToolStripMenuItem,
            this.빌드ToolStripMenuItem,
            this.디버그ToolStripMenuItem,
            this.서식ToolStripMenuItem,
            this.테스트ToolStripMenuItem,
            this.분석ToolStripMenuItem,
            this.도구ToolStripMenuItem,
            this.확장ToolStripMenuItem,
            this.창ToolStripMenuItem,
            this.도움말ToolStripMenuItem,
            this.배고픔ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.새로만들기ToolStripMenuItem.Text = "새로 만들기";
            this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새프로젝트ToolStripMenuItem,
            this.새솔루션ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem1.Text = "추가";
            // 
            // 새프로젝트ToolStripMenuItem
            // 
            this.새프로젝트ToolStripMenuItem.Name = "새프로젝트ToolStripMenuItem";
            this.새프로젝트ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.새프로젝트ToolStripMenuItem.Text = "새 프로젝트";
            // 
            // 새솔루션ToolStripMenuItem
            // 
            this.새솔루션ToolStripMenuItem.Name = "새솔루션ToolStripMenuItem";
            this.새솔루션ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.새솔루션ToolStripMenuItem.Text = "새 솔루션";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // 프로젝트ToolStripMenuItem
            // 
            this.프로젝트ToolStripMenuItem.Name = "프로젝트ToolStripMenuItem";
            this.프로젝트ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.프로젝트ToolStripMenuItem.Text = "프로젝트";
            // 
            // 빌드ToolStripMenuItem
            // 
            this.빌드ToolStripMenuItem.Name = "빌드ToolStripMenuItem";
            this.빌드ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.빌드ToolStripMenuItem.Text = "빌드";
            // 
            // 디버그ToolStripMenuItem
            // 
            this.디버그ToolStripMenuItem.Name = "디버그ToolStripMenuItem";
            this.디버그ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.디버그ToolStripMenuItem.Text = "디버그";
            // 
            // 서식ToolStripMenuItem
            // 
            this.서식ToolStripMenuItem.Name = "서식ToolStripMenuItem";
            this.서식ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.서식ToolStripMenuItem.Text = "서식";
            // 
            // 테스트ToolStripMenuItem
            // 
            this.테스트ToolStripMenuItem.Name = "테스트ToolStripMenuItem";
            this.테스트ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.테스트ToolStripMenuItem.Text = "테스트";
            // 
            // 분석ToolStripMenuItem
            // 
            this.분석ToolStripMenuItem.Name = "분석ToolStripMenuItem";
            this.분석ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.분석ToolStripMenuItem.Text = "분석";
            // 
            // 도구ToolStripMenuItem
            // 
            this.도구ToolStripMenuItem.Name = "도구ToolStripMenuItem";
            this.도구ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.도구ToolStripMenuItem.Text = "도구";
            // 
            // 확장ToolStripMenuItem
            // 
            this.확장ToolStripMenuItem.Name = "확장ToolStripMenuItem";
            this.확장ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.확장ToolStripMenuItem.Text = "확장";
            // 
            // 창ToolStripMenuItem
            // 
            this.창ToolStripMenuItem.Name = "창ToolStripMenuItem";
            this.창ToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.창ToolStripMenuItem.Text = "창";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 배고픔ToolStripMenuItem
            // 
            this.배고픔ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.배고파ToolStripMenuItem,
            this.보통ToolStripMenuItem,
            this.배불러ToolStripMenuItem});
            this.배고픔ToolStripMenuItem.Name = "배고픔ToolStripMenuItem";
            this.배고픔ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.배고픔ToolStripMenuItem.Text = "배고픔";
            // 
            // 배고파ToolStripMenuItem
            // 
            this.배고파ToolStripMenuItem.Name = "배고파ToolStripMenuItem";
            this.배고파ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.배고파ToolStripMenuItem.Text = "배고파";
            this.배고파ToolStripMenuItem.Click += new System.EventHandler(this.배고파ToolStripMenuItem_Click);
            // 
            // 보통ToolStripMenuItem
            // 
            this.보통ToolStripMenuItem.Name = "보통ToolStripMenuItem";
            this.보통ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.보통ToolStripMenuItem.Text = "보통";
            this.보통ToolStripMenuItem.Click += new System.EventHandler(this.보통ToolStripMenuItem_Click);
            // 
            // 배불러ToolStripMenuItem
            // 
            this.배불러ToolStripMenuItem.Name = "배불러ToolStripMenuItem";
            this.배불러ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.배불러ToolStripMenuItem.Text = "배불러";
            this.배불러ToolStripMenuItem.Click += new System.EventHandler(this.배불러ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "준비중";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로젝트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 빌드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 디버그ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 테스트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 분석ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도구ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 새프로젝트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새솔루션ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem 배고픔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배고파ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보통ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배불러ToolStripMenuItem;
    }
}

