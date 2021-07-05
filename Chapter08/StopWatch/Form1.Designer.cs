
namespace StopWatch {
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
            this.TimerLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimerLabel
            // 
            this.TimerLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimerLabel.Location = new System.Drawing.Point(12, 22);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(474, 64);
            this.TimerLabel.TabIndex = 0;
            this.TimerLabel.Text = "label1";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 107);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(128, 81);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "スタート";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(146, 107);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(128, 81);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "リセット";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(12, 194);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(128, 81);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "ストップ";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(146, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 81);
            this.button4.TabIndex = 1;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(498, 286);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.TimerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button button4;
    }
}

