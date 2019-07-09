﻿/****************************************************************************
 * Description: 
 * 
 * Document: https://github.com/hiramtan/HiProtobuf
 * Author: hiramtan@live.com
 ****************************************************************************/
namespace HiProtobuf.Lib
{
    public static class Settings
    {
        /// <summary>
        /// protoc路径
        /// </summary>
        public static string Protoc_Path = @"D:\MyGit\github\HiProtobuf\protoc-3.8.0-win64\bin\protoc.exe";

        /// <summary>
        /// Excel文件夹
        /// </summary>
        public static string Excel_Folder = @"D:\MyGit\github\HiProtobuf\temp\excel";

        /// <summary>
        /// 导出文件夹
        /// </summary>
        public static string Export_Folder = @"D:\MyGit\github\HiProtobuf\temp\export";

        /// <summary>
        /// 编译器地址
        /// </summary>
        public static string Compiler_Path = @"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe";

        /// <summary>
        /// protobuf dll
        /// </summary>
        public static string Protobuf_Dll_Path = @"D:\MyGit\github\HiProtobuf\HiProtobuf\lib\Google.Protobuf.dll";

        /// <summary>
        /// Proto文件存放目录
        /// </summary>
        internal static readonly string proto_folder = "/proto";

        /// <summary>
        /// 语言存放目录
        /// </summary>
        internal static readonly string language_folder = "/language";

        /// <summary>
        /// 数据存放目录
        /// </summary>
        internal static readonly string dat_folder = "/dat";

        //导出语言文件夹
        internal static readonly string csharp_folder = "/csharp";
        internal static readonly string csharp_dll_folder = "/csharp_dll";
        internal static readonly string cpp_folder = "/cpp";
        internal static readonly string go_folder = "/go";
        internal static readonly string java_folder = "/java";
        internal static readonly string python_folder = "/python";
    }
}