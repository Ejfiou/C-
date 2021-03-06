﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public struct UserStruct
    {

        public UserStruct(string username, string password, string realName)
        {
            this.username = username;
            this.password = password;
            this.realName = realName;
        }
        /// <summary>
        /// 用户名,唯一的，不能重复
        /// </summary>
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        /// 密码
        /// </summary>
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// 真实姓名
        /// </summary>
        private string realName;
        public string RealName
        {
            get { return realName; }
            set { realName = value; }
        }

        public string ShowMe()
        {
            return $"用户名：{username,-15}密码：{password,-15}真实姓名：{realName}";
        }

    }
}
