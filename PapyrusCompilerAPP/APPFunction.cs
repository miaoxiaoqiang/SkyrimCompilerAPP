using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightPapyrusCompiler
{
    internal class APPFunction
    {
        /// <summary>
        /// 判断.Net Framework的Version是否符合需要
        /// (.Net Framework 版本在2.0及以上)
        /// </summary>
        /// <param name="version">需要的版本</param>
        internal static bool GetDotNetVersion(string version)
        {
            string oldname = "0";
            using (RegistryKey ndpKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "").OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
            {
                foreach (string versionKeyName in ndpKey.GetSubKeyNames())
                {
                    if (versionKeyName.StartsWith("v"))
                    {
                        RegistryKey versionKey = ndpKey.OpenSubKey(versionKeyName);
                        string newname = (string)versionKey.GetValue("Version", "");
                        if (string.Compare(newname, oldname) > 0)
                        {
                            oldname = newname;
                        }
                        if (newname != "")
                        {
                            continue;
                        }
                        foreach (string subKeyName in versionKey.GetSubKeyNames())
                        {
                            RegistryKey subKey = versionKey.OpenSubKey(subKeyName);
                            newname = (string)subKey.GetValue("Version", "");
                            if (string.Compare(newname, oldname) > 0)
                            {
                                oldname = newname;
                            }
                        }
                    }
                }
            }
            return string.Compare(oldname, version) > 0 ? true : false;
        }

        /// <summary>
        /// 判断.Net Framework的Release是否符合需要
        /// (.Net Framework 版本在4.0及以上)
        /// </summary>
        /// <param name="release">需要的版本 version = 4.5 release = 379893</param>
        internal static bool GetDotNetRelease(int release)
        {
            const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";

            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
            {
                if (ndpKey != null && ndpKey.GetValue("Release") != null)
                {
                    return (int)ndpKey.GetValue("Release") >= release ? true : false;
                }
                return false;
            }
        }
    }
}
