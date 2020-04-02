using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LightPapyrusCompiler
{
    /// <summary>
    /// 内容混淆
    /// </summary>
    internal class EDncrypt
    {
        private string strFilePath = "";
        private ToolStripProgressBar PBar = null;
        //private Thread EThread = null;
        //private Thread DThread = null;
        private string strContent = string.Empty;
        private static readonly string KeySecret= @"xl6cDd%5";
        private static readonly string IVSecret = @"Hf&2P*hH";
        /// <summary>
        /// 解密后的内容流
        /// </summary>
        public string DeContent = string.Empty;

        /// <summary>
        /// 初始化 <see cref="EDncrypt" /> 类的新实例
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="content"></param>
        /// <param name="pb"></param>
        public EDncrypt(string filepath, string content, ToolStripProgressBar pb)
        {
            strFilePath = filepath;
            PBar = pb;
            strContent = content;
            //EThread = new Thread(new ThreadStart(this.EThreadContent));
            //DThread = new Thread(new ThreadStart(this.DThreadCotent));
        }

        /// <summary>
        /// 内容加密
        /// </summary>
        private void EThreadContent()
        {
            byte[] btRKey = Encoding.UTF8.GetBytes(KeySecret);
            byte[] btRIV = Encoding.UTF8.GetBytes(IVSecret);
            MemoryStream _ms = new MemoryStream(Encoding.UTF8.GetBytes(strContent));
            FileStream NewFStream = new FileStream(strFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            NewFStream.SetLength((long)0);
            byte[] buffer = new byte[0x400];
            int MinNum = 0;
            long length = _ms.Length;
            int MaxNum = (int)(length / ((long)0x400));
            PBar.Maximum = MaxNum;
            DES myDES = new DESCryptoServiceProvider
            {
                Key = btRKey,
                IV = btRIV
            };
            CryptoStream CStream = new CryptoStream(NewFStream, myDES.CreateEncryptor(), CryptoStreamMode.Write);
            while (MinNum < length)
            {
                int count = _ms.Read(buffer, 0, 0x400);
                CStream.Write(buffer, 0, count);
                MinNum += count;
                try
                {
                    if (PBar.Value < PBar.Maximum)
                    {
                        PBar.Value++;
                    }
                }
                catch
                {

                }
            }
            CStream.FlushFinalBlock();
            CStream.Close();
            NewFStream.Close();
            _ms.Close();
            myDES.Dispose();
            MessageBox.Show("写入成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 内容解密
        /// </summary>
        private void DThreadCotent()
        {
            if (File.Exists(strFilePath))
            {
                FileStream FStream = new FileStream(strFilePath, FileMode.Open, FileAccess.Read);
                byte[] bytes = new byte[FStream.Length];
                FStream.Read(bytes, 0, bytes.Length);
                FStream.Seek(0, SeekOrigin.Begin);

                DES myDES = new DESCryptoServiceProvider();
                MemoryStream _DeContent = new MemoryStream();

                try
                {
                    byte[] btRKey = Encoding.UTF8.GetBytes(KeySecret);
                    byte[] btRIV = Encoding.UTF8.GetBytes(IVSecret);

                    if (bytes.Length > 0)
                    {
                        CryptoStream CStream = new CryptoStream(_DeContent, myDES.CreateDecryptor(btRKey, btRIV), CryptoStreamMode.Write);
                        CStream.Write(bytes, 0, bytes.Length);
                        CStream.FlushFinalBlock();
                        DeContent = Encoding.UTF8.GetString(_DeContent.ToArray());
                        CStream.Close();
                        CStream.Dispose();
                    }
                }
                catch
                {
                    MessageBox.Show("配置读取失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    _DeContent.Close();
                    _DeContent.Dispose();
                    FStream.Close();
                    FStream.Close();
                    myDES.Dispose();
                }
            }
        }

        /// <summary>
        /// 运行加密线程
        /// </summary>
        public void StartEncrypt()
        {
            EThreadContent();
            //EThread.Start();
        }

        /// <summary>
        /// 运行解密线程
        /// </summary>
        public void StartDncrypt()
        {
            DThreadCotent();
            //DThread.Start();
        }
    }
}
