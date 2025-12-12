using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

// Thư viện DocX
//using Novacode;
using Xceed.Words.NET;


// Thư viện iTextSharp – dùng alias để tránh xung đột
using iText = iTextSharp.text;
using iTextPdf = iTextSharp.text.pdf;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        private string currentFilePath = null;

        public Form1()
        {
            InitializeComponent();
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tải font hệ thống
            foreach (FontFamily font in FontFamily.Families)
            {
                toolStripComboBoxFont.Items.Add(font.Name);
            }

            // Kích cỡ theo giáo trình
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in sizes)
            {
                toolStripComboBoxSize.Items.Add(size);
            }

            // Giá trị mặc định
            toolStripComboBoxFont.Text = "Tahoma";
            toolStripComboBoxSize.Text = "14";
            richTextBox1.Font = new System.Drawing.Font("Tahoma", 14);
        }

        // === HỆ THỐNG ===
        private void tạoMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            currentFilePath = null;
            toolStripComboBoxFont.Text = "Tahoma";
            toolStripComboBoxSize.Text = "14";
            toolStripButtonBold.Checked = false;
            toolStripButtonItalic.Checked = false;
            toolStripButtonUnderline.Checked = false;
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Rich Text Format (*.rtf)|*.rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ext = Path.GetExtension(ofd.FileName).ToLower();
                    if (ext == ".rtf")
                        richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                    else
                        richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                    currentFilePath = ofd.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở file:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFilePath == null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Rich Text Format (*.rtf)|*.rtf";
                sfd.DefaultExt = "rtf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                    currentFilePath = sfd.FileName;
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // === LƯU .DOCX / .PDF ===
        private void lưuDướiDạngDOCXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Word Document (*.docx)|*.docx";
                sfd.DefaultExt = "docx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (DocX doc = DocX.Create(sfd.FileName))
                        {
                            doc.InsertParagraph(richTextBox1.Text);
                            doc.Save();
                        }
                        MessageBox.Show("Lưu file Word thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu .docx:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void lưuDướiDạngPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Document (*.pdf)|*.pdf";
                sfd.DefaultExt = "pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                        {
                            iText.Document doc = new iText.Document();
                            iTextPdf.PdfWriter.GetInstance(doc, fs);
                            doc.Open();
                            doc.Add(new iText.Paragraph(richTextBox1.Text));
                            doc.Close();
                        }
                        MessageBox.Show("Lưu file PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu .pdf:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // === ĐỊNH DẠNG ===
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            if (dlg.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.SelectionFont = dlg.Font;
                richTextBox1.SelectionColor = dlg.Color;

                toolStripComboBoxFont.Text = dlg.Font.Name;
                toolStripComboBoxSize.Text = dlg.Font.Size.ToString();
                toolStripButtonBold.Checked = dlg.Font.Bold;
                toolStripButtonItalic.Checked = dlg.Font.Italic;
                toolStripButtonUnderline.Checked = dlg.Font.Underline;
            }
        }

        // === TOOLBAR ===
        private void UpdateSelectionFont(FontStyle style, bool enable)
        {
            System.Drawing.Font current = richTextBox1.SelectionFont ?? richTextBox1.Font;
            FontStyle newStyle = current.Style;
            if (enable) newStyle |= style;
            else newStyle &= ~style;
            richTextBox1.SelectionFont = new System.Drawing.Font(current, newStyle);
        }

        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            UpdateSelectionFont(FontStyle.Bold, toolStripButtonBold.Checked);
        }

        private void toolStripButtonItalic_Click(object sender, EventArgs e)
        {
            UpdateSelectionFont(FontStyle.Italic, toolStripButtonItalic.Checked);
        }

        private void toolStripButtonUnderline_Click(object sender, EventArgs e)
        {
            UpdateSelectionFont(FontStyle.Underline, toolStripButtonUnderline.Checked);
        }

        private void toolStripButtonForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = dlg.Color;
        }

        private void toolStripButtonBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = dlg.Color;
            }
        }

        private void toolStripButtonAlignLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButtonAlignCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButtonAlignRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripComboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBoxFont.SelectedItem != null)
            {
                string name = toolStripComboBoxFont.SelectedItem.ToString();
                float size = richTextBox1.SelectionFont?.Size ?? 14;
                richTextBox1.SelectionFont = new System.Drawing.Font(name, size, richTextBox1.SelectionFont?.Style ?? FontStyle.Regular);
            }
        }

        private void toolStripComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBoxSize.SelectedItem != null && float.TryParse(toolStripComboBoxSize.Text, out float size))
            {
                string name = richTextBox1.SelectionFont?.Name ?? "Tahoma";
                richTextBox1.SelectionFont = new System.Drawing.Font(name, size, richTextBox1.SelectionFont?.Style ?? FontStyle.Regular);
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            toolStripButtonAlignLeft.Checked = richTextBox1.SelectionAlignment == HorizontalAlignment.Left;
            toolStripButtonAlignCenter.Checked = richTextBox1.SelectionAlignment == HorizontalAlignment.Center;
            toolStripButtonAlignRight.Checked = richTextBox1.SelectionAlignment == HorizontalAlignment.Right;
        }

        // === CHÈN HÌNH ẢNH ===
        private void toolStripButtonInsertImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile(ofd.FileName);
                    Clipboard.SetImage(img);
                    richTextBox1.Paste();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể chèn hình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}