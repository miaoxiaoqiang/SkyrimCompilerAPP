using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LightPapyrusCompiler
{
    /// <summary>
    /// 脚本编译参数模型
    /// </summary>
    [DataContract]
    public class ParamsModel
    {
        /// <summary>
        /// 游戏标志
        /// </summary>
        [DataMember]
        public string Flags { get; set; } = "TESV_Papyrus_Flags.flg";
        /// <summary>
        /// 脚本编译输出目录
        /// </summary>
        [DataMember]
        public string OutPutFolder { get; set; }
        /// <summary>
        /// 原始脚本目录
        /// </summary>
        [DataMember]
        public string ScriptsFolder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Import { get; set; }
        /// <summary>
        /// 当前要编译的目标类型（文件或文件夹）
        /// </summary>
        [DataMember]
        public string FileType { get; set; }
        /// <summary>
        /// 编译参数集合
        /// </summary>
        [DataMember]
        public List<string> ComplieAruments { get; set; }
        /// <summary>
        /// 汇编参数集合
        /// </summary>
        [DataMember]
        public List<string> AssemblyAruments { get; set; }
        /// <summary>
        /// 源码文件集合
        /// </summary>
        [DataMember]
        public string PscFolder { get; set; }

        public ParamsModel()
        {
            ComplieAruments = new List<string>();
            AssemblyAruments = new List<string>();
            PscFolder = System.String.Empty;
            Import = System.String.Empty;
        }
    }
}
