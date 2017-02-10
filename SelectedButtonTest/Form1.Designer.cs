namespace SelectedButtonTest {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.selectedButton1 = new SelectedButton.SelectedButton();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // selectedButton1
            // 
            this.selectedButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectedButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedButton1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.selectedButton1.Disabled = false;
            this.selectedButton1.Icon = global::SelectedButtonTest.Properties.Resources._155;
            this.selectedButton1.IsMouseDown = false;
            this.selectedButton1.IsMouseEnter = false;
            this.selectedButton1.IsMouseLeave = false;
            this.selectedButton1.IsSelectedUsed = true;
            this.selectedButton1.Location = new System.Drawing.Point(33, 83);
            this.selectedButton1.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.selectedButton1.MouseEnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.selectedButton1.MouseLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.selectedButton1.Name = "selectedButton1";
            this.selectedButton1.Selected = false;
            this.selectedButton1.Size = new System.Drawing.Size(107, 53);
            this.selectedButton1.TabIndex = 0;
            this.selectedButton1.Title = "测试按钮";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(202, 23);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(265, 253);
            this.propertyGrid1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 319);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.selectedButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SelectedButton.SelectedButton selectedButton1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;

    }
}

