﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Class_11_30
{
    /// <summary>
    /// 数据仓库（数据库）
    /// </summary>
   public class Database
    {
        public Database()
        {
            this.users[0] = new User("admin", "admin", "管理员");
        }

        //private Student[] students = new Student[20];
        ///// <summary>
        ///// 人信息数据（人信息表）
        ///// </summary>
        //public Student[] Students
        //{
        //    get { return students; }
        //    set { students = value; }
        //}

        //人信息数据存放
        //最多只能存放20个人
        //private Person[] people = new Person[20];
        ///// <summary>
        ///// 人信息数据（人信息表）
        ///// </summary>
        //public Person[] People
        //{
        //    get { return people; }
        //    set { people = value; }
        //}

        //万事万物中的某种信息数据存放
        //最多只能存放20个万事万物中的某种
        private IMyObject[] myObjects = new IMyObject[20];
        /// <summary>
        /// 万事万物中的某种信息数据
        /// </summary>
        public IMyObject[] MyObjects
        {
            get { return myObjects; }
            set { myObjects = value; }
        }

        //万事万物中的某种信息数据存放
        //这里可以存放无数个万事万物中的某种信息
        private ArrayList myObjectArrayList = new ArrayList();

        /// <summary>
        /// 万事万物中的某种信息数据
        /// </summary>
        public ArrayList MyObjectArrayList
        {
            get { return myObjectArrayList; }
            set { myObjectArrayList = value; }
        }

        private Hashtable hash = new Hashtable();

        public Hashtable Hash
        {
            get { return hash; }
            set { hash = value; }
        }



        // 登录用户信息数据存放
        //最多只能存放20个用户
        private User[] users = new User[20];
        public User[] Users
        {
            get { return users; }
            set { users = value; }
        }
    }
}
