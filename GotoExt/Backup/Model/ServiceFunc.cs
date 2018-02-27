﻿using System.Text.RegularExpressions;

namespace GotoExt.Model
{
    /// <summary>
    /// Service相关信息
    /// </summary>
    public class ServiceFunc : FuncInfo
    {
        /// <summary>
        /// 项目名称：Mysoft.Gtxt.GtFaMng
        /// </summary>
        public new string ProjName => Regex.Replace(Namespace, @"\.AppServices\b.*", "");
        
        /// <summary>
        /// 文件相对路径：Mysoft.Gtxt.GtFaMng\AppServices\GtFaAppService
        /// </summary>
        public string FilePath
        {
            get
            {
                if (string.IsNullOrEmpty(Namespace) ||
                    string.IsNullOrEmpty(Class) ||
                    string.IsNullOrEmpty(Func))
                {
                    return "";
                }

                return $@"{Regex.Replace(Namespace, @"\.AppServices.*", m => m.Value.Replace(".", @"\"))}\{Class}";
            }
        }

        /// <summary>
        /// 文件相对路径：AppServices\GtFaAppService
        /// </summary>
        public string FilePath2
        {
            get
            {
                if (string.IsNullOrEmpty(Namespace) ||
                    string.IsNullOrEmpty(Class) ||
                    string.IsNullOrEmpty(Func))
                {
                    return "";
                }

                return $@"{Namespace.Replace($"{ProjName}.", "").Replace(".", @"\")}\{Class}";
            }
        }
    }
}
