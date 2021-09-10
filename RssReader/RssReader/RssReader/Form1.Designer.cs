
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.ibTitles = new System.Windows.Forms.ListBox();
            this.btRead = new System.Windows.Forms.Button();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.ladesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RssReader";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(139, 17);
            this.tbUrl.Multiline = true;
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(586, 34);
            this.tbUrl.TabIndex = 1;
            // 
            // ibTitles
            // 
            this.ibTitles.FormattingEnabled = true;
            this.ibTitles.ItemHeight = 15;
            this.ibTitles.Location = new System.Drawing.Point(13, 66);
            this.ibTitles.Name = "ibTitles";
            this.ibTitles.Size = new System.Drawing.Size(193, 454);
            this.ibTitles.TabIndex = 2;
            this.ibTitles.Click += new System.EventHandler(this.ibTitles_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(757, 17);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(105, 34);
            this.btRead.TabIndex = 3;
            this.btRead.Text = "読み込み";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(212, 66);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(650, 454);
            this.wbBrowser.TabIndex = 4;
            // 
            // ladesc
            // 
            this.ladesc.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ladesc.Location = new System.Drawing.Point(868, 66);
            this.ladesc.Name = "ladesc";
            this.ladesc.Size = new System.Drawing.Size(161, 454);
            this.ladesc.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 707);
            this.Controls.Add(this.ladesc);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.ibTitles);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ListBox ibTitles;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Label ladesc;
    }
}

