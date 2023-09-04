namespace AVCHDをmp4にするやつ
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Input_folder_pick_button = new System.Windows.Forms.Button();
            this.Input_folder_path = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Output_folder_pick_button = new System.Windows.Forms.Button();
            this.Output_folder_path = new System.Windows.Forms.TextBox();
            this.Start_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Delete_check = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Input_folder_pick_button);
            this.groupBox1.Controls.Add(this.Input_folder_path);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1.入力元フォルダを選択";
            // 
            // Input_folder_pick_button
            // 
            this.Input_folder_pick_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Input_folder_pick_button.Location = new System.Drawing.Point(239, 17);
            this.Input_folder_pick_button.Name = "Input_folder_pick_button";
            this.Input_folder_pick_button.Size = new System.Drawing.Size(84, 23);
            this.Input_folder_pick_button.TabIndex = 1;
            this.Input_folder_pick_button.Text = "参照";
            this.Input_folder_pick_button.UseVisualStyleBackColor = true;
            this.Input_folder_pick_button.Click += new System.EventHandler(this.Input_folder_pick_button_Click);
            // 
            // Input_folder_path
            // 
            this.Input_folder_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input_folder_path.Enabled = false;
            this.Input_folder_path.Location = new System.Drawing.Point(7, 19);
            this.Input_folder_path.Name = "Input_folder_path";
            this.Input_folder_path.Size = new System.Drawing.Size(226, 19);
            this.Input_folder_path.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Output_folder_pick_button);
            this.groupBox2.Controls.Add(this.Output_folder_path);
            this.groupBox2.Location = new System.Drawing.Point(13, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2.出力先フォルダを選択";
            // 
            // Output_folder_pick_button
            // 
            this.Output_folder_pick_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_folder_pick_button.Location = new System.Drawing.Point(239, 16);
            this.Output_folder_pick_button.Name = "Output_folder_pick_button";
            this.Output_folder_pick_button.Size = new System.Drawing.Size(84, 23);
            this.Output_folder_pick_button.TabIndex = 1;
            this.Output_folder_pick_button.Text = "参照";
            this.Output_folder_pick_button.UseVisualStyleBackColor = true;
            this.Output_folder_pick_button.Click += new System.EventHandler(this.Output_folder_pick_button_Click);
            // 
            // Output_folder_path
            // 
            this.Output_folder_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_folder_path.Enabled = false;
            this.Output_folder_path.Location = new System.Drawing.Point(7, 18);
            this.Output_folder_path.Name = "Output_folder_path";
            this.Output_folder_path.Size = new System.Drawing.Size(226, 19);
            this.Output_folder_path.TabIndex = 0;
            // 
            // Start_button
            // 
            this.Start_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Start_button.Location = new System.Drawing.Point(267, 266);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(75, 23);
            this.Start_button.TabIndex = 2;
            this.Start_button.Text = "開始";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.Delete_check);
            this.groupBox3.Location = new System.Drawing.Point(13, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 138);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3.オプション";
            // 
            // Delete_check
            // 
            this.Delete_check.AutoSize = true;
            this.Delete_check.Location = new System.Drawing.Point(7, 19);
            this.Delete_check.Name = "Delete_check";
            this.Delete_check.Size = new System.Drawing.Size(103, 16);
            this.Delete_check.TabIndex = 0;
            this.Delete_check.Text = "元ファイルを削除";
            this.Delete_check.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 301);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(370, 340);
            this.Name = "Form1";
            this.Text = "AVCHDをmp4にするやつ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Input_folder_pick_button;
        private System.Windows.Forms.TextBox Input_folder_path;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Output_folder_pick_button;
        private System.Windows.Forms.TextBox Output_folder_path;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Delete_check;
    }
}

