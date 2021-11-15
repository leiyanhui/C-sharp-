namespace PPT_show
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.LabelMainName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.AllowDrop = true;
            resources.ApplyResources(this.BtnSubmit, "BtnSubmit");
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // LabelMainName
            // 
            resources.ApplyResources(this.LabelMainName, "LabelMainName");
            this.LabelMainName.Name = "LabelMainName";
            this.LabelMainName.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.LabelMainName);
            this.Controls.Add(this.BtnSubmit);
            this.Name = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label showText;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label LabelMainName;
    }
}

