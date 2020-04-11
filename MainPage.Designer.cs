namespace Ven3
{
    partial class MainPage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.imgpannel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // imgpannel
            // 
            this.imgpannel.AutoScroll = true;
            this.imgpannel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imgpannel.Location = new System.Drawing.Point(12, 12);
            this.imgpannel.Margin = new System.Windows.Forms.Padding(10);
            this.imgpannel.Name = "imgpannel";
            this.imgpannel.Size = new System.Drawing.Size(1127, 617);
            this.imgpannel.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 641);
            this.Controls.Add(this.imgpannel);
            this.Name = "MainPage";
            this.Text = "Ven3";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResizeEnd += new System.EventHandler(this.mainPageResize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel imgpannel;
    }
}

