namespace Base64Image
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_img_to_base64 = new System.Windows.Forms.Button();
            this.link_copy = new System.Windows.Forms.LinkLabel();
            this.link_clean = new System.Windows.Forms.LinkLabel();
            this.text_base64_box = new System.Windows.Forms.RichTextBox();
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.btn_base64_to_img = new System.Windows.Forms.Button();
            this.link_save_base64 = new System.Windows.Forms.LinkLabel();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.link_save_img = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_img_to_base64
            // 
            this.btn_img_to_base64.Location = new System.Drawing.Point(512, 8);
            this.btn_img_to_base64.Name = "btn_img_to_base64";
            this.btn_img_to_base64.Size = new System.Drawing.Size(211, 28);
            this.btn_img_to_base64.TabIndex = 0;
            this.btn_img_to_base64.Text = "选择要转换成Base64的图片";
            this.btn_img_to_base64.UseVisualStyleBackColor = true;
            this.btn_img_to_base64.Click += new System.EventHandler(this.btn_img_to_base64_Click);
            // 
            // link_copy
            // 
            this.link_copy.AutoSize = true;
            this.link_copy.Location = new System.Drawing.Point(431, 18);
            this.link_copy.Name = "link_copy";
            this.link_copy.Size = new System.Drawing.Size(29, 12);
            this.link_copy.TabIndex = 1;
            this.link_copy.TabStop = true;
            this.link_copy.Text = "复制";
            this.link_copy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_copy_LinkClicked);
            // 
            // link_clean
            // 
            this.link_clean.AutoSize = true;
            this.link_clean.Location = new System.Drawing.Point(466, 18);
            this.link_clean.Name = "link_clean";
            this.link_clean.Size = new System.Drawing.Size(29, 12);
            this.link_clean.TabIndex = 2;
            this.link_clean.TabStop = true;
            this.link_clean.Text = "清空";
            this.link_clean.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_clean_LinkClicked);
            // 
            // text_base64_box
            // 
            this.text_base64_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_base64_box.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_base64_box.Location = new System.Drawing.Point(12, 42);
            this.text_base64_box.Name = "text_base64_box";
            this.text_base64_box.Size = new System.Drawing.Size(484, 267);
            this.text_base64_box.TabIndex = 3;
            this.text_base64_box.Text = "";
            // 
            // picture_box
            // 
            this.picture_box.BackColor = System.Drawing.Color.White;
            this.picture_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_box.Location = new System.Drawing.Point(512, 42);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(211, 267);
            this.picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box.TabIndex = 4;
            this.picture_box.TabStop = false;
            // 
            // btn_base64_to_img
            // 
            this.btn_base64_to_img.Location = new System.Drawing.Point(12, 8);
            this.btn_base64_to_img.Name = "btn_base64_to_img";
            this.btn_base64_to_img.Size = new System.Drawing.Size(216, 28);
            this.btn_base64_to_img.TabIndex = 5;
            this.btn_base64_to_img.Text = "点击这里将Base64转化成图片";
            this.btn_base64_to_img.UseVisualStyleBackColor = true;
            this.btn_base64_to_img.Click += new System.EventHandler(this.btn_base64_to_img_Click);
            // 
            // link_save_base64
            // 
            this.link_save_base64.AutoSize = true;
            this.link_save_base64.Location = new System.Drawing.Point(360, 18);
            this.link_save_base64.Name = "link_save_base64";
            this.link_save_base64.Size = new System.Drawing.Size(67, 12);
            this.link_save_base64.TabIndex = 6;
            this.link_save_base64.TabStop = true;
            this.link_save_base64.Text = "保存BASE64";
            this.link_save_base64.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_save_LinkClicked);
            // 
            // tb_status
            // 
            this.tb_status.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_status.Enabled = false;
            this.tb_status.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_status.ForeColor = System.Drawing.Color.Black;
            this.tb_status.Location = new System.Drawing.Point(0, 318);
            this.tb_status.Name = "tb_status";
            this.tb_status.ReadOnly = true;
            this.tb_status.Size = new System.Drawing.Size(734, 14);
            this.tb_status.TabIndex = 7;
            this.tb_status.Text = "  状态：{0}。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(590, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "© wuwz.job@gmail.com";
            // 
            // link_save_img
            // 
            this.link_save_img.AutoSize = true;
            this.link_save_img.Location = new System.Drawing.Point(301, 18);
            this.link_save_img.Name = "link_save_img";
            this.link_save_img.Size = new System.Drawing.Size(53, 12);
            this.link_save_img.TabIndex = 9;
            this.link_save_img.TabStop = true;
            this.link_save_img.Text = "保存图片";
            this.link_save_img.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_save_img_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "预览-缩略图";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 332);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.link_save_img);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_status);
            this.Controls.Add(this.link_save_base64);
            this.Controls.Add(this.btn_base64_to_img);
            this.Controls.Add(this.picture_box);
            this.Controls.Add(this.text_base64_box);
            this.Controls.Add(this.link_clean);
            this.Controls.Add(this.link_copy);
            this.Controls.Add(this.btn_img_to_base64);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base64 & Image 转换器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_img_to_base64;
        private System.Windows.Forms.LinkLabel link_copy;
        private System.Windows.Forms.LinkLabel link_clean;
        private System.Windows.Forms.RichTextBox text_base64_box;
        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.Button btn_base64_to_img;
        private System.Windows.Forms.LinkLabel link_save_base64;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_save_img;
        private System.Windows.Forms.Label label2;
    }
}

