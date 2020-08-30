using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace YFenGongLibCore.Util
{
    public class Debug
    {
        public static object LockLog = new object();
        public static async void Debuglog(string log, string logname = "_Debuglog.txt")
        {
            //zbq 
            await Task.Run(() =>
            {
                lock (LockLog)
                {
                    try
                    {
                        StreamWriter writer = System.IO.File.AppendText("App_Data/" + (DateTime.Now.ToString("yyyyMMdd") + logname));
                        writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ":" + log);
                        writer.WriteLine("---------------");
                        writer.Close();
                    }
                    catch (ThreadAbortException)
                    {
                    }
                    catch (Exception)
                    {
                    }
                }
            });
        }


        public static void DebuglogSync(string log, string logname = "_Debuglog.txt")
        {
            //zbq 
            Task.Run(() =>
            {
                lock (LockLog)
                {
                    try
                    {
                        StreamWriter writer = System.IO.File.AppendText("App_Data/" + (DateTime.Now.ToString("yyyyMMdd") + logname));
                        writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ":" + log);
                        writer.WriteLine("---------------");
                        writer.Close();
                    }
                    catch (ThreadAbortException)
                    {
                    }
                    catch (Exception)
                    {
                    }
                }
            });
        }

    }
}
