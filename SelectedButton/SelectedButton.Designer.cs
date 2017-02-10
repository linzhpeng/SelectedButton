namespace SelectedButton {
    partial class SelectedButton {
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.btnIcon = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIcon
            // 
            this.btnIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIcon.FlatAppearance.BorderSize = 0;
            this.btnIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIcon.Location = new System.Drawing.Point(0, 0);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(29, 53);
            this.btnIcon.TabIndex = 0;
            this.btnIcon.UseVisualStyleBackColor = true;
            this.btnIcon.Click += new System.EventHandler(this.button_Click);
            this.btnIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.btnIcon.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnIcon.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            this.btnIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // btnTitle
            // 
            this.btnTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTitle.FlatAppearance.BorderSize = 0;
            this.btnTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitle.Location = new System.Drawing.Point(29, 0);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(78, 53);
            this.btnTitle.TabIndex = 1;
            this.btnTitle.UseVisualStyleBackColor = true;
            this.btnTitle.Click += new System.EventHandler(this.button_Click);
            this.btnTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.btnTitle.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnTitle.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            this.btnTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // SelectedButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.btnIcon);
            this.Name = "SelectedButton";
            this.Size = new System.Drawing.Size(107, 53);
            this.Load += new System.EventHandler(this.SelectedButton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.Button btnTitle;
    }
}
