using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard
{
    public class ByteHelper
    {        /// <summary>
             ///將檔案轉成byte[]
             /// </summary>
             /// <param name="fileName">檔案的實體路徑</param>
             /// <returns></returns>
        public static byte[] ReadFileToByte(string fileName)
        {
            FileStream pFileStream = null;
            byte[] pReadByte = new byte[0];
            try
            {
                pFileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader r = new BinaryReader(pFileStream);
                r.BaseStream.Seek(0, SeekOrigin.Begin);    //将文件指针设置到文件开
                pReadByte = r.ReadBytes((int)r.BaseStream.Length);
                return pReadByte;
            }
            catch
            {
                return pReadByte;
            }
            finally
            {
                if (pFileStream != null)
                    pFileStream.Close();
            }
        }

        /// <summary>
        /// 將byte[]輸出成檔案
        /// </summary>
        /// <param name="pReadByte">byte[]</param>
        /// <param name="fileName">檔案名稱</param>
        /// <returns></returns>
        public static bool WriteByteToFile(byte[] pReadByte, string fileName)
        {
            FileStream pFileStream = null;
            try
            {
                pFileStream = new FileStream(fileName, FileMode.OpenOrCreate);
                pFileStream.Write(pReadByte, 0, pReadByte.Length);
            }
            catch
            {
                return false;
            }
            finally
            {
                if (pFileStream != null)
                    pFileStream.Close();
            }
            return true;
        }

    }
}
