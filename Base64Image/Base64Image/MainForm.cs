using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Base64Image
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_base64_to_img_Click(object sender, EventArgs e)
        {
            string base64 = text_base64_box.Text;

            if (String.IsNullOrEmpty(base64))
            {
                MessageBox.Show("请先填写Base64编码。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Bitmap bitmap = ImageBase64Utils.toImage(base64);

            if (bitmap != null)
            {
                picture_box.Image = bitmap;
            }


            setStatusText("Base64编码 ——> 图片 已完成");
        }

        private void btn_img_to_base64_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Title = "选择要转换的图片";
            dlg.Filter = "图像文件(*.jpg;*.png;*.gif;*.bmp)|*.jpg;*.png;*.gif;*.bmp";
            if (DialogResult.OK == dlg.ShowDialog())
            {
                string imageFilePath = dlg.FileName;
                picture_box.ImageLocation = imageFilePath;

                String base64 = ImageBase64Utils.toBase64(imageFilePath);
                if (!String.IsNullOrEmpty(base64))
                {

                    text_base64_box.Clear();
                    text_base64_box.Text = base64;
                }
            }

            dlg.Dispose();

            setStatusText("图片 ——> Base64编码 已完成");
        }

        private void link_save_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (requiredText())
            {
                // string saveFile = Environment.CurrentDirectory + "\\result_base64\\";

                // if (!Directory.Exists(saveFile))
                // {

                //    Directory.CreateDirectory(saveFile);
                // }

                // saveFile += string.Format("{0:yyyyMMddHHmmssffff}", DateTime.Now) + ".txt";


                // text_base64_box.SaveFile(saveFile, RichTextBoxStreamType.PlainText);

                // Clipboard.SetDataObject(saveFile);

                // MessageBox.Show("文件已保存到：" + saveFile + "\n同时该路径也已经复制到剪贴板。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // setStatusText("Base64文件已保存——>：" + saveFile);
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = string.Format("{0:yyyyMMddHHmmssffff}", DateTime.Now);
                save.Filter = "(.txt)|*.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    text_base64_box.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);

                    setStatusText("Base64文件已保存——>" + save.FileName);
                }
            }
        }

        private void link_save_img_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (picture_box.Image == null)
            {
                MessageBox.Show("没有图片可以保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.FileName = string.Format("{0:yyyyMMddHHmmssffff}", DateTime.Now);
            save.Filter = "(.png)|*.png";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit = new Bitmap(picture_box.ClientRectangle.Width, picture_box.ClientRectangle.Height);
                picture_box.DrawToBitmap(bit, picture_box.ClientRectangle);
                bit.Save(save.FileName);

                setStatusText("图片已保存——>" + save.FileName);
            }
        }

        private bool requiredText()
        {
            if (String.IsNullOrEmpty(text_base64_box.Text))
            {
                MessageBox.Show("文本框中没有内容。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void link_copy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (requiredText())
            {
                Clipboard.SetDataObject(text_base64_box.Text);

                String msg = "Base64编码已经复制到剪贴板";

                MessageBox.Show(msg, "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                setStatusText(msg);
            }
        }

        private void link_clean_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            text_base64_box.Clear();

            // picture_box.CreateGraphics().Clear(Color.White);
            picture_box.ImageLocation = null;

            setStatusText("已清空结果");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            setStatusText("已经就绪");
        }

        private void setStatusText(String msg)
        {
            String pattern = "  状态：{0}。";

            tb_status.Text = string.Format(pattern, msg);
        }



    }
}
