namespace Lab03_02
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởTậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuDướiDạngDOCXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuDướiDạngPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhDạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxSize = new System.Windows.Forms.ToolStripComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonForeColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBackColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInsertImage = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.địnhDạngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoMớiToolStripMenuItem,
            this.mởTậpTinToolStripMenuItem,
            this.lưuToolStripMenuItem,
            this.lưuDướiDạngDOCXToolStripMenuItem,
            this.lưuDướiDạngPDFToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tạoMớiToolStripMenuItem
            // 
            this.tạoMớiToolStripMenuItem.Name = "tạoMớiToolStripMenuItem";
            this.tạoMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tạoMớiToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.tạoMớiToolStripMenuItem.Text = "Tạo mới";
            this.tạoMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoMớiToolStripMenuItem_Click);
            // 
            // mởTậpTinToolStripMenuItem
            // 
            this.mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            this.mởTậpTinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mởTậpTinToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.mởTậpTinToolStripMenuItem.Text = "Mở tập tin";
            this.mởTậpTinToolStripMenuItem.Click += new System.EventHandler(this.mởTậpTinToolStripMenuItem_Click);
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.lưuToolStripMenuItem.Text = "Lưu (.rtf)";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // lưuDướiDạngDOCXToolStripMenuItem
            // 
            this.lưuDướiDạngDOCXToolStripMenuItem.Name = "lưuDướiDạngDOCXToolStripMenuItem";
            this.lưuDướiDạngDOCXToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.lưuDướiDạngDOCXToolStripMenuItem.Text = "Lưu dưới dạng Word (.docx)";
            this.lưuDướiDạngDOCXToolStripMenuItem.Click += new System.EventHandler(this.lưuDướiDạngDOCXToolStripMenuItem_Click);
            // 
            // lưuDướiDạngPDFToolStripMenuItem
            // 
            this.lưuDướiDạngPDFToolStripMenuItem.Name = "lưuDướiDạngPDFToolStripMenuItem";
            this.lưuDướiDạngPDFToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.lưuDướiDạngPDFToolStripMenuItem.Text = "Lưu dưới dạng PDF (.pdf)";
            this.lưuDướiDạngPDFToolStripMenuItem.Click += new System.EventHandler(this.lưuDướiDạngPDFToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // địnhDạngToolStripMenuItem
            // 
            this.địnhDạngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            this.địnhDạngToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.địnhDạngToolStripMenuItem.Text = "Định dạng";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripButtonBold,
            this.toolStripButtonItalic,
            this.toolStripButtonUnderline,
            this.toolStripButtonForeColor,
            this.toolStripButtonBackColor,
            this.toolStripSeparator2,
            this.toolStripButtonAlignLeft,
            this.toolStripButtonAlignCenter,
            this.toolStripButtonAlignRight,
            this.toolStripSeparator3,
            this.toolStripButtonInsertImage,
            this.toolStripComboBoxFont,
            this.toolStripComboBoxSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(900, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.CheckOnClick = true;
            this.toolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBold.Text = "B";
            this.toolStripButtonBold.Click += new System.EventHandler(this.toolStripButtonBold_Click);
            // 
            // toolStripButtonItalic
            // 
            this.toolStripButtonItalic.CheckOnClick = true;
            this.toolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonItalic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonItalic.Name = "toolStripButtonItalic";
            this.toolStripButtonItalic.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonItalic.Text = "I";
            this.toolStripButtonItalic.Click += new System.EventHandler(this.toolStripButtonItalic_Click);
            // 
            // toolStripButtonUnderline
            // 
            this.toolStripButtonUnderline.CheckOnClick = true;
            this.toolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUnderline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.toolStripButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            this.toolStripButtonUnderline.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUnderline.Text = "U";
            this.toolStripButtonUnderline.Click += new System.EventHandler(this.toolStripButtonUnderline_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBoxFont
            // 
            this.toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            this.toolStripComboBoxFont.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxFont.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFont_SelectedIndexChanged);
            // 
            // toolStripComboBoxSize
            // 
            this.toolStripComboBoxSize.Name = "toolStripComboBoxSize";
            this.toolStripComboBoxSize.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBoxSize.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxSize_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(900, 551);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = global::Lab03_02.Properties.Resources.folder;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNew.Text = "Tạo mới";
            this.toolStripButtonNew.Click += new System.EventHandler(this.tạoMớiToolStripMenuItem_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = global::Lab03_02.Properties.Resources.edit;
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "Mở";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.mởTậpTinToolStripMenuItem_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::Lab03_02.Properties.Resources.diskette;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "Lưu";
            this.toolStripButtonSave.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // toolStripButtonForeColor
            // 
            this.toolStripButtonForeColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonForeColor.Image = global::Lab03_02.Properties.Resources.font;
            this.toolStripButtonForeColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonForeColor.Name = "toolStripButtonForeColor";
            this.toolStripButtonForeColor.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonForeColor.Text = "A";
            this.toolStripButtonForeColor.ToolTipText = "Màu chữ";
            this.toolStripButtonForeColor.Click += new System.EventHandler(this.toolStripButtonForeColor_Click);
            // 
            // toolStripButtonBackColor
            // 
            this.toolStripButtonBackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBackColor.Image = global::Lab03_02.Properties.Resources.color_palette;
            this.toolStripButtonBackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBackColor.Name = "toolStripButtonBackColor";
            this.toolStripButtonBackColor.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBackColor.Text = "A";
            this.toolStripButtonBackColor.ToolTipText = "Màu nền";
            this.toolStripButtonBackColor.Click += new System.EventHandler(this.toolStripButtonBackColor_Click);
            // 
            // toolStripButtonAlignLeft
            // 
            this.toolStripButtonAlignLeft.CheckOnClick = true;
            this.toolStripButtonAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAlignLeft.Image = global::Lab03_02.Properties.Resources.t;
            this.toolStripButtonAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAlignLeft.Name = "toolStripButtonAlignLeft";
            this.toolStripButtonAlignLeft.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAlignLeft.Text = "L";
            this.toolStripButtonAlignLeft.ToolTipText = "Căn trái";
            this.toolStripButtonAlignLeft.Click += new System.EventHandler(this.toolStripButtonAlignLeft_Click);
            // 
            // toolStripButtonAlignCenter
            // 
            this.toolStripButtonAlignCenter.CheckOnClick = true;
            this.toolStripButtonAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAlignCenter.Image = global::Lab03_02.Properties.Resources.g;
            this.toolStripButtonAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAlignCenter.Name = "toolStripButtonAlignCenter";
            this.toolStripButtonAlignCenter.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAlignCenter.Text = "C";
            this.toolStripButtonAlignCenter.ToolTipText = "Căn giữa";
            this.toolStripButtonAlignCenter.Click += new System.EventHandler(this.toolStripButtonAlignCenter_Click);
            // 
            // toolStripButtonAlignRight
            // 
            this.toolStripButtonAlignRight.CheckOnClick = true;
            this.toolStripButtonAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAlignRight.Image = global::Lab03_02.Properties.Resources.p;
            this.toolStripButtonAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAlignRight.Name = "toolStripButtonAlignRight";
            this.toolStripButtonAlignRight.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAlignRight.Text = "R";
            this.toolStripButtonAlignRight.ToolTipText = "Căn phải";
            this.toolStripButtonAlignRight.Click += new System.EventHandler(this.toolStripButtonAlignRight_Click);
            // 
            // toolStripButtonInsertImage
            // 
            this.toolStripButtonInsertImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInsertImage.Image = global::Lab03_02.Properties.Resources.picture;
            this.toolStripButtonInsertImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInsertImage.Name = "toolStripButtonInsertImage";
            this.toolStripButtonInsertImage.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonInsertImage.Text = "🖼";
            this.toolStripButtonInsertImage.ToolTipText = "Chèn hình ảnh";
            this.toolStripButtonInsertImage.Click += new System.EventHandler(this.toolStripButtonInsertImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lab03-02";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhDạngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBold;
        private System.Windows.Forms.ToolStripButton toolStripButtonItalic;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnderline;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFont;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSize;
        private System.Windows.Forms.ToolStripButton toolStripButtonForeColor;
        private System.Windows.Forms.ToolStripButton toolStripButtonBackColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAlignLeft;
        private System.Windows.Forms.ToolStripButton toolStripButtonAlignCenter;
        private System.Windows.Forms.ToolStripButton toolStripButtonAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonInsertImage;
        private System.Windows.Forms.ToolStripMenuItem lưuDướiDạngDOCXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuDướiDạngPDFToolStripMenuItem;
    }
}