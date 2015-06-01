using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBClass
{
    /// <summary>
    /// 对一段包含QP编码的字符串进行解码
    /// Author:coollzh@263.net
    /// 
    /// </summary>
    public class DecodeQP
    {
        public DecodeQP()
        {
        }

        /// <summary>
        /// 一段连续的QP编码的字符串进行解码
        /// </summary>
        /// <param name="HexString">要解码的一段连续的QP编码的字符串</param>
        /// <param name="encode">编码方式</param>
        /// <returns>已解码的字符串</returns>
        private string ConvertHexToString(string HexString, System.Text.Encoding encode)
        {
            if (HexString == null || HexString.Equals("")) return "";

            if (HexString.StartsWith("=")) HexString = HexString.Substring(1);

            string[] aHex = HexString.Split(new char[1] { '=' });
            byte[] abyte = new Byte[aHex.Length];

            for (int i = 0; i < abyte.Length; i++)
            {
                //	Console.WriteLine(aHex[i]);
                abyte[i] = (byte)int.Parse(aHex[i], System.Globalization.NumberStyles.HexNumber);
            }
            return encode.GetString(abyte);
        }

        /// <summary>
        /// 对包含QP编码的字符串进行解码
        /// </summary>
        /// <param name="HexString">要解码的包含QP编码的字符串</param>
        /// <param name="encode">字符编码方式，建议用Default</param>
        /// <param name="nStart">开始解码的字符开始位置，一般为0</param>
        /// <returns>已解码的字符串</returns>
        public string ConvertHexContent(string HexString, System.Text.Encoding encode, long nStart)
        {
            if (nStart >= HexString.Length) return HexString;

            //存放要解码的字符串
            StringBuilder sbHex = new StringBuilder();
            sbHex.Append("");
            //存放已经解码过的字符串
            StringBuilder sbEncoded = new StringBuilder();
            sbEncoded.Append("");
            //是否已经碰到QP的字符串
            bool isBegin = false;
            string temp;
            int i = (int)nStart;

            while (i < HexString.Length)
            {
                //初始化下次循环
                sbHex.Remove(0, sbHex.Length);
                isBegin = false;

                while (i < HexString.Length)
                {
                    temp = HexString.Substring(i, 1);//还没有开始碰到第一个QP字符时每次取一个字符进行比较
                    if (temp.StartsWith("="))
                    {
                        temp = HexString.Substring(i, 3);//对于以等号开始的每次取3个字符
                        if (temp.EndsWith("\r\n"))//换行符
                        {
                            if (isBegin)
                                break;
                            //	sbEncoded.Append("");
                            i = i + 3;
                        }
                        else if (!temp.EndsWith("3D"))
                        {
                            sbHex.Append(temp);
                            isBegin = true;//已开始碰到第一个QP字符，放到QP缓冲区
                            i = i + 3;
                        }
                        else //如果是以3D结尾则该字符串只是一个等号，放到已解码缓冲区
                        {
                            if (isBegin)
                                break;

                            sbEncoded.Append("=");
                            i = i + 3;
                        }

                    }
                    else
                    {
                        if (isBegin)//已经取得整块的QP字符串，跳出该次循环
                            break;
                        sbEncoded.Append(temp);//不是QP字符则放到已解码缓冲区中
                        i++;
                    }

                }
                //一次循环结束，把已经取得整块的QP字符串进行解码
                sbEncoded.Append(this.ConvertHexToString(sbHex.ToString(), encode));
            }

            return sbEncoded.ToString();
        }


        /// <summary>
        /// 对包含QP编码的字符串进行解码,用Default字符编码方式，从字符串开始位置进行解码
        /// </summary>
        /// <param name="HexString">要解码的包含QP编码的字符串</param>
        /// <returns>已解码的字符串</returns>
        public string ConvertHexContent(string HexString)
        {
            if (HexString == null || HexString.Equals("")) return HexString;

            return this.ConvertHexContent(HexString, Encoding.Default, 0);

        }
    }

}
