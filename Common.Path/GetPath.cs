using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Path
{
    public class GetPath
    {
        public string WinService()
        {
            //Windows服务取安装路径
            string path = AppDomain.CurrentDomain.BaseDirectory;
            return path;
        }

    }
}
