using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Base64Image
{
    class ImageBase64Utils
    {

        public static Bitmap toImage(String base64)
        {
            MemoryStream stream = null;
            try
            {
                stream = new MemoryStream(Convert.FromBase64String(base64));

                return new Bitmap(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Base64编码转图片失败。\nException：" + ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
            return null;
        }

        public static String toBase64(String imageFilePath)
        {
            MemoryStream stream = null;
            try
            {
                Bitmap bmp = new Bitmap(imageFilePath);

                stream = new MemoryStream();
                bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[stream.Length];
                stream.Position = 0;
                stream.Read(arr, 0, (int)stream.Length);

                return Convert.ToBase64String(arr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("图片转失Base64编码败。\nException:" + ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
            return null;
        }
    }
}
