using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Config
    {
        public string userName = "";
        public string passWord = "";
        public string email = "";
        public string name = "";
        public string popAddress = "";
        public string popPort = "";
        public string smtpAddress = "";
        public string smtpPort = "";
        
        public Config()
        {
            string Current;
            string filePath;
            Current = System.IO.Directory.GetCurrentDirectory();//获取当前根目录
            filePath = Current + "/config.ini";
            if (!System.IO.File.Exists(filePath))
            {
                System.IO.File.Create(filePath);//创建该文件  
            }

            IniConfig ini = new IniConfig(filePath);

            // 读取ini
            userName = ini.ReadValue("Setting", "userName")==""?"":DESEncrypt.Decrypt(ini.ReadValue("Setting", "userName"));
            passWord = ini.ReadValue("Setting", "passWord") == "" ? "" : DESEncrypt.Decrypt(ini.ReadValue("Setting", "passWord"));
            email = ini.ReadValue("Setting", "email") == "" ? "" : DESEncrypt.Decrypt(ini.ReadValue("Setting", "email"));
            name = ini.ReadValue("Setting", "name") == "" ? "" : DESEncrypt.Decrypt(ini.ReadValue("Setting", "name"));
            popAddress = ini.ReadValue("Setting", "popAddress") == "" ? "" : DESEncrypt.Decrypt(ini.ReadValue("Setting", "popAddress"));
            popPort = ini.ReadValue("Setting", "popPort") == "" ? "" : DESEncrypt.Decrypt(ini.ReadValue("Setting", "popPort"));
            smtpAddress = ini.ReadValue("Setting", "smtpAddress") == "" ? "" : DESEncrypt.Decrypt(ini.ReadValue("Setting", "smtpAddress"));
            smtpPort = ini.ReadValue("Setting", "smtpPort") == "" ? "" : DESEncrypt.Decrypt(ini.ReadValue("Setting", "smtpPort"));

        }
    }
}
