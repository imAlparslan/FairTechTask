using System;

namespace RemotingTask.Server.Common
{
    public static class Logger
    {

        public static void Information(string log)
        {

            Console.WriteLine($"[{DateTime.Now.ToString("u")}] {log} ");
        }

        public static void Error(string log)
        {

            Console.WriteLine($"[{DateTime.Now.ToString("u")}] {log} ");

        }
    }
}
