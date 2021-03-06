﻿using SalamanderWnmp.Configuration;
using SalamanderWnmp.Programs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static SalamanderWnmp.Tool.RedisHelper;

namespace SalamanderWnmp
{
    class Common
    {
        /// <summary>
        /// 不能实例化Common类
        /// </summary>
        private Common()
        {

        }

        private static Ini settings = null;

        /// <summary>
        /// 应用程序配置(单例模式)
        /// </summary>
        public static Ini Settings {
            get
            {
                if(settings == null)
                {
                    settings = new Ini();
                }
                return settings;
            }
        }

        /// <summary>
        /// 改变全局设置量
        /// </summary>
        /// <param name="settingsNew"></param>
        public static void ChangeSettings(Ini settingsNew)
        {
            if(settingsNew != null)
            {
                settings = settingsNew;
            }
        }


        // 应用启动目录
        public static readonly String APP_STARTUP_PATH = AppDomain.CurrentDomain.BaseDirectory;


        // Redis连接配置列表
        public static Dictionary<string, RedisConnConfig> ConnConfigList = null;



        public static readonly MysqlProgram Mysql = new MysqlProgram();
        public static readonly BaseProgram Nginx = new NginxProgram();
        public static readonly PHPProgram PHP = new PHPProgram();
        public static readonly RedisProgram Redis = new RedisProgram();

    }
}
