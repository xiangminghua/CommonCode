﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Common.CSharpEventDelegate
{
    // 该类保留写入日志文件的条款
    class BoilerInfoLogger
    {
        FileStream fs;
        StreamWriter sw;
        public BoilerInfoLogger(string filename)
        {
            fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
        }
        public void Logger(string info)
        {
            sw.WriteLine(info);
        }
        public void Close()
        {
            sw.Close();
            fs.Close();
        }

    }
}
