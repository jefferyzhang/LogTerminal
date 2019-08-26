using System;
using System.Text.RegularExpressions;

namespace LogTerminal
{
    /// <summary>
    /// 日志信息，一个LogInfo 相当于一行日志
    /// 结构基于FileBeat 推送到Redis上存储的结构(除 File ,MessageTime,SerialNo三个字段）
    /// </summary>
    public class LogInfo
    {
        public DateTime Timestamp { get; set; }
        public Metadata Metadata { get; set; }
        public Log Log { get; set; }
        public string Message { get; set; }
        public Input Input { get; set; }
        public Ecs Ecs { get; set; }
        public Host Host { get; set; }
        public Agent Agent { get; set; }

        public static LogInfo Empty = new LogInfo() {Message = string.Empty};

        public string File { set; get; }

        public DateTime? MessageTime { set; get; }

        public int SerialNo;

        public string Level
        {
            get
            {
                string level=null;
                if (Message.Contains(LogLevel.DEBUG))
                {
                    level = LogLevel.DEBUG;
                }
                else if (Message.Contains(LogLevel.INFO))
                {
                    level = LogLevel.INFO;
                }
                else if (Message.Contains(LogLevel.WARN))
                {
                    level = LogLevel.WARN;
                }
                else if (Message.Contains(LogLevel.ERROR))
                {
                    level = LogLevel.ERROR;
                }
                return level;
            }
        }


        public void Init(int serialNo)
        {
            SerialNo = serialNo;

            File = Host.Hostname + Log.File.Path;

            var match = Regex.Match(Message, @"^\d{4}\-\d{2}\-\d{2}\s\d{2}\:\d{2}\:\d{2}\.\d{3}");
            if (match.Success)
            {
                MessageTime = DateTime.Parse(match.Value);
                Message = Message.Substring(match.Value.Length);
            }
        }

        public string GetApp()
        {
            var pathParts = Log.File.Path.Split('\\');
            return pathParts[pathParts.Length - 3];
        }
    }

    public class Metadata
    {
        public string Beat { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
    }

    public class Log
    {
        public File File { get; set; }
        public int Offset { get; set; }
    }

    public class File
    {
        public string Path { get; set; }
    }

    public class Input
    {
        public string Type { get; set; }
    }

    public class Ecs
    {
        public string Version { get; set; }
    }

    public class Host
    {
        public string Name { get; set; }
        public string Hostname { get; set; }
        public string Architecture { get; set; }
        public Os Os { get; set; }
        public string Id { get; set; }
    }

    public class Os
    {
        public string Name { get; set; }
        public string Kernel { get; set; }
        public string Build { get; set; }
        public string Platform { get; set; }
        public string Version { get; set; }
        public string Family { get; set; }
    }

    public class Agent
    {
        public string EphemeralId { get; set; }
        public string Hostname { get; set; }
        public string Id { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }
    }

}
