using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SelectedButton {
    [DefaultEvent("ButtonClick")]
    [DefaultProperty("Title")]
    public partial class SelectedButton : UserControl {
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public SelectedButton() {
            InitializeComponent();
        }

        /// <summary>
        /// 自定义事件委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void MyEventHandler(object sender, EventArgs e);

        /// <summary>
        /// 自定义按钮类的点击事件
        /// </summary>
        [Description("自定义按钮类的点击事件")]
        public event MyEventHandler ButtonClick;

        /// <summary>
        /// 自定义按钮图标
        /// </summary>
        [Category("自定义属性")]
        [Description("按钮图标")]
        public Image Icon {
            get {
                if (btnIcon.BackgroundImage == null) {
                    btnIcon.Hide();
                }
                return btnIcon.BackgroundImage;
            }
            set {
                btnIcon.BackgroundImage = value;
                if (btnIcon.BackgroundImage != null) {
                    btnIcon.Show();
                }
            }
        }

        #region 自定义颜色属性

        /// <summary>
        /// 选中状态时背景颜色
        /// </summary>
        [Category("自定义属性")]
        [Description("选中背景色")]
        public Color CheckedColor {
            get;
            set;
        }

        /// <summary>
        /// 鼠标进入控件时背景色
        /// </summary>
        [Category("自定义属性")]
        [Description("鼠标进入控件时背景色")]
        public Color MouseEnterColor {
            get;
            set;
        }

        /// <summary>
        /// 鼠标离开控件时背景色
        /// </summary>
        [Category("自定义属性")]
        [Description("鼠标离开控件时背景色")]
        public Color MouseLeaveColor {
            get;
            set;
        }

        /// <summary>
        /// 鼠标点击控件时背景色
        /// </summary>
        [Category("自定义属性")]
        [Description("鼠标点击控件时背景色")]
        public Color MouseDownColor {
            get;
            set;
        }
        #endregion

        private bool disabled = false;
        private bool isSelectedUsed = true;
        private bool selected = false;
        private bool isMouseEnter = false;
        private bool isMouseLeave = false;
        private bool isMouseDown = false;

        /// <summary>
        /// 控件禁用标志
        /// true：表示被禁用，即Enabled = false
        /// false：标识未被禁用，即Enabled = true
        /// </summary>
        [Category("自定义属性")]
        [Description("是否禁用")]
        public bool Disabled {
            get {
                return disabled;
            }
            set {
                disabled = value;
                if (disabled) {
                    this.Enabled = false;
                    btnIcon.BackColor = Color.Gray;
                    btnTitle.BackColor = Color.Gray;
                } else {
                    this.Enabled = true;
                    btnIcon.BackColor = Color.Transparent;
                    btnTitle.BackColor = Color.Transparent;
                }
            }
        }

        /// <summary>
        /// 指示控件是否开启被选中状态
        /// true：开启被选中状态（设置Selected属性控件背景色会发生变化）
        /// false：关闭被选中状态（设置Selected属性控件背景色不会发生变化）
        /// </summary>
        [Category("自定义属性")]
        [Description("控件选中属性是否使用")]
        public bool IsSelectedUsed {
            get {
                return isSelectedUsed;
            }
            set {
                isSelectedUsed = value;
                if (!isSelectedUsed && !Disabled) {
                    btnIcon.BackColor = Color.Transparent;
                    btnTitle.BackColor = Color.Transparent;
                } else {
                    if (selected && !Disabled) {
                        btnIcon.BackColor = CheckedColor;
                        btnTitle.BackColor = CheckedColor;
                    }
                }
            }
        }

        /// <summary>
        /// 控件被选中状态
        /// true：被选中，false：未被选中
        /// </summary>
        [Category("自定义属性")]
        [Description("控件是否被选中")]
        public bool Selected {
            get {
                return selected;
            }
            set {
                selected = value;
                if (IsSelectedUsed && !Disabled) {
                    if (selected) {
                        btnIcon.BackColor = CheckedColor;
                        btnTitle.BackColor = CheckedColor;
                        this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    } else {
                        btnIcon.BackColor = Color.Transparent;
                        btnTitle.BackColor = Color.Transparent;
                        this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    }
                }
            }
        }

        /// <summary>
        /// 鼠标是否进入控件的状态
        /// </summary>
        [Category("自定义属性")]
        [Description("鼠标是否进入控件")]
        public bool IsMouseEnter {
            get {
                return isMouseEnter;
            }
            set {
                isMouseEnter = value;
                if (isMouseEnter && !Disabled) {
                    btnIcon.BackColor = MouseEnterColor;
                    btnTitle.BackColor = MouseEnterColor;
                }
            }
        }

        /// <summary>
        /// 鼠标是否离开控件的状态
        /// </summary>
        [Category("自定义属性")]
        [Description("鼠标是否离开控件")]
        public bool IsMouseLeave {
            get {
                return isMouseLeave;
            }
            set {
                isMouseLeave = value;
                if (isMouseLeave && !Disabled) {
                    if (!Selected && !IsMouseDown) {
                        btnIcon.BackColor = MouseLeaveColor;
                        btnTitle.BackColor = MouseLeaveColor;
                    } else {
                        btnIcon.BackColor = CheckedColor;
                        btnTitle.BackColor = CheckedColor;
                    }
                }
            }
        }

        /// <summary>
        /// 鼠标是否按下
        /// </summary>
        [Category("自定义属性")]
        [Description("鼠标是否按下")]
        public bool IsMouseDown {
            get {
                return isMouseDown;
            }
            set {
                isMouseDown = value;
            }
        }

        /// <summary>
        /// 控件中显示的文字
        /// </summary>
        [Category("自定义属性")]
        [Description("控件内容")]
        public string Title {
            get {
                return btnTitle.Text;
            }
            set {
                btnTitle.Text = value;
            }
        }

        private void SelectedButton_Load(object sender, EventArgs e) {
            if (Icon == null) {
                btnIcon.Hide();
            }
            btnIcon.FlatAppearance.MouseOverBackColor = MouseEnterColor;
            btnTitle.FlatAppearance.MouseOverBackColor = MouseEnterColor;
            btnIcon.FlatAppearance.MouseDownBackColor = MouseEnterColor;
            btnTitle.FlatAppearance.MouseDownBackColor = MouseEnterColor;
        }

        private void button_Click(object sender, EventArgs e) {
            IsMouseEnter = false;
            IsMouseLeave = false;
            if (IsSelectedUsed) {
                Selected = !Selected;
            }
            if (ButtonClick != null) {
                ButtonClick(sender, e);
            }
        }

        private void button_MouseDown(object sender, MouseEventArgs e) {
            IsMouseEnter = false;
            IsMouseLeave = false;
            IsMouseDown = true;
            btnIcon.FlatAppearance.MouseOverBackColor = MouseDownColor;
            btnIcon.FlatAppearance.MouseDownBackColor = MouseDownColor;
            btnTitle.FlatAppearance.MouseOverBackColor = MouseDownColor;
            btnTitle.FlatAppearance.MouseDownBackColor = MouseDownColor;
            btnIcon.BackColor = MouseDownColor;
            btnTitle.BackColor = MouseDownColor;
        }

        private void button_MouseEnter(object sender, EventArgs e) {
            IsMouseEnter = true;
            IsMouseDown = false;
            IsMouseLeave = false;
        }

        private void button_MouseLeave(object sender, EventArgs e) {
            if (!IsMouseDown) {
                IsMouseEnter = false;
                IsMouseLeave = true;
                IsMouseDown = false;
            }
        }

        private void button_MouseMove(object sender, MouseEventArgs e) {
            if (!IsMouseDown) {
                IsMouseEnter = true;
                IsMouseLeave = false;
                IsMouseDown = false;
            }
        }

        private void button_MouseUp(object sender, MouseEventArgs e) {
            IsMouseDown = false;
            btnIcon.FlatAppearance.MouseDownBackColor = MouseEnterColor;
            btnIcon.FlatAppearance.MouseOverBackColor = MouseEnterColor;
            btnTitle.FlatAppearance.MouseDownBackColor = MouseEnterColor;
            btnTitle.FlatAppearance.MouseOverBackColor = MouseEnterColor;
            if (Disabled) {
                btnIcon.BackColor = Color.Gray;
                btnTitle.BackColor = Color.Gray;
            }
        }






    }
}
