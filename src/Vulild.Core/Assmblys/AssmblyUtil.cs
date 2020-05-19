using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Vulild.Core.Assmblys
{
    public static class AssmblyUtil
    {

        /// <summary>
        /// 扫描dll文件，获取类型
        /// </summary>
        /// <param name="fileName">要扫描的dll文件名</param>
        public static void SearchAssmbly(string fileName, params Action<Type>[] actions)
        {
            try
            {
                //非IL程序集不能读取
                Type[] types = Assembly.LoadFrom(fileName).GetTypes();
                foreach (var type in types)
                {
                    foreach (var action in actions)
                    {
                        action?.Invoke(type);
                    }
                }
            }
            catch (BadImageFormatException)
            {

                //throw;
            }
        }

        /// <summary>
        /// 扫描dll文件，获取类型
        /// </summary>
        /// <param name="fileNames">要扫描的dll文件名</param>
        public static void SearchAssmbly(IEnumerable<string> fileNames, params Action<Type>[] actions)
        {
            foreach (var fileName in fileNames)
            {
                SearchAssmbly(fileName, actions);
            }
        }

        public static void SearchAllAssmbly(params Action<Type>[] actions)
        {
            SearchAllAssmbly(null, actions);
        }

        /// <summary>
        /// 扫描dll文件，获取类型
        /// </summary>
        /// <param name="excludePath">排除的路径和文件名</param>
        public static void SearchAllAssmbly(IEnumerable<string> excludePath, params Action<Type>[] actions)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            SearchDirectoryAssmbly(path, excludePath, actions);
        }

        public static void SearchDirectoryAssmbly(string dirPath, IEnumerable<string> excludePath, params Action<Type>[] actions)
        {
            string[] dirs = Directory.GetDirectories(dirPath);
            foreach (var dir in dirs)
            {
                if (excludePath == null || !excludePath.Contains(dir))//排除的文件夹
                {
                    SearchDirectoryAssmbly(Path.Combine(dirPath, dir), excludePath, actions);
                }

            }

            IEnumerable<string> fis = Directory.GetFiles(dirPath).Where(a => Path.GetExtension(a) == ".dll");
            IEnumerable<string> includeFileNames = fis;
            if (excludePath != null && excludePath.Any())
            {
                includeFileNames = includeFileNames.Except(excludePath);//排除的文件
            }
            SearchAssmbly(includeFileNames, actions);
        }

    }
}
