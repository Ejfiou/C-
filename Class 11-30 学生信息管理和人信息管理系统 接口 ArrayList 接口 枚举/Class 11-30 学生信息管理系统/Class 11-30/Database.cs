using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

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
            this.users[1] = new User("tom", "123", "汤姆");
            this.users[2] = new User("jack", "123", "杰克");

            this.usersStruct[0] = new UserStruct("admin", "admin123", "管理员");
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

        private Hashtable myObjectsHashtable = new Hashtable();

        public Hashtable MyObjectsHashtable
        {
            get { return myObjectsHashtable; }
            set { myObjectsHashtable = value; }
        }

        private SortedList myObjectSorteList=new SortedList();

        public SortedList MyObjectSorteList
        {
            get { return myObjectSorteList; }
            set { myObjectSorteList = value; }
        }

        private List<IMyObject> myObjectList = new List<IMyObject>();
        public List<IMyObject> MyobjectList
        {
            get { return myObjectList; }
            set { myObjectList = value; }
        }

        private Dictionary<string,IMyObject> myObjectDictionary=new Dictionary<string, IMyObject>();

        public Dictionary<string,IMyObject> MyObjectDictionary
        {
            get { return myObjectDictionary; }
            set { myObjectDictionary= value; }
        }


        // 登录用户信息数据存放
        //最多只能存放20个用户
        private User[] users = new User[20];
        public User[] Users
        {
            get { return users; }
            set { users = value; }
        }

        private UserStruct[] usersStruct=new UserStruct[10];

        public UserStruct[] UsersStruct
        {
            get { return usersStruct; }
            set { usersStruct = value; }
        }

        /// <summary>
        /// 将字段中的数据保存到文件中
        /// </summary>
        /// <param name="tools">工具接口的实例</param>
        /// <returns>保存是否成功</returns>
        public bool Save(IMyObjectTools tools)
        {
            bool flag = false;

            try
            {
                using (StreamWriter sw = new StreamWriter(tools.SaveFile, false, Encoding.UTF8))
                {
                    //数组-数据结构
                    for (int i = 0; i < this.MyObjects.Length; i++)
                    {
                        //判断当前i位置上是否有某种对象
                        if (this.MyObjects[i] != null)//有某种对象
                        {
                            sw.WriteLine(tools.MySerialize(this.MyObjects[i]));
                        }
                    }

                    sw.Close();
                }
                flag = true;
               
            }
            catch(Exception e)
            {
                throw e;
            }
            
            return flag;
        }


        public bool SaveArrayList(IMyObjectTools tools)
        {
            bool flag = false;

            try
            {
                using (StreamWriter sw = new StreamWriter(tools.SaveFile, false, Encoding.UTF8))
                {
                    //ArrayList-数据结构
                    for (int i = 0; i < this.MyObjectArrayList.Count; i++)
                    {
                        if (this.MyObjectArrayList[i] is IMyObject)
                        {
                            sw.WriteLine(tools.MySerialize(this.MyObjectArrayList[i] as IMyObject));
                        }
                    }
                    sw.Close();
                }
                flag = true;

            }
            catch (Exception e)
            {
                throw e;
            }

            return flag;
        }

        public bool SaveHashtable(IMyObjectTools tools)
        {
            bool flag = false;

            try
            {
                using (StreamWriter sw = new StreamWriter(tools.SaveFile, false, Encoding.UTF8))
                {
                    //Hashtable-数据结构
                    foreach (DictionaryEntry de in this.MyObjectsHashtable)
                    {
                        if (de.Value is IMyObject)
                        {
                            sw.WriteLine(tools.MySerialize(de.Value as IMyObject));
                        }
                    }
                    sw.Close();
                }
                flag = true;

            }
            catch (Exception e)
            {
                throw e;
            }

            return flag;
        }

        public bool SaveSortedList(IMyObjectTools tools)
        {
            bool flag = false;

            try
            {
                using (StreamWriter sw = new StreamWriter(tools.SaveFile, false, Encoding.UTF8))
                {
                    //SortedList-数据结构
                    for (int i = 0; i < this.myObjectSorteList.Count; i++)
                    {
                        if (this.myObjectSorteList.GetByIndex(i) is IMyObject)
                        {
                            sw.WriteLine(tools.MySerialize(this.myObjectSorteList.GetByIndex(i) as IMyObject));
                        }
                    }
                    sw.Close();
                }
                flag = true;

            }
            catch (Exception e)
            {
                throw e;
            }

            return flag;
        }


        public bool SaveList(IMyObjectTools tools)
        {
            bool flag = false;

            try
            {
                using (StreamWriter sw = new StreamWriter(tools.SaveFile, false, Encoding.UTF8))
                {
                    //list<>泛型-数据结构
                    for (int i = 0; i < this.MyobjectList.Count; i++)
                    {
                        sw.WriteLine(tools.MySerialize(this.MyobjectList[i]));
                    }
                    sw.Close();
                }
                flag = true;

            }
            catch (Exception e)
            {
                throw e;
            }

            return flag;
        }

        public bool SaveDictionary(IMyObjectTools tools)
        {
            bool flag = false;

            try
            {
                using (StreamWriter sw = new StreamWriter(tools.SaveFile, false, Encoding.UTF8))
                {
                    //Dictionary<>泛型-数据结构
                    foreach (KeyValuePair<string, IMyObject> kv in this.MyObjectDictionary)
                    {
                        sw.WriteLine(tools.MySerialize(kv.Value));
                    }
                    sw.Close();
                }
                flag = true;

            }
            catch (Exception e)
            {
                throw e;
            }

            return flag;
        }
        /// <summary>
        /// 将文件中的数据装载到字段
        /// </summary>
        /// <param name="tools"></param>
        /// <returns></returns>
        public bool Load(IMyObjectTools tools)
        {
            bool flag = false;

            try
            {
                using (StreamReader sr = new StreamReader(tools.SaveFile, Encoding.UTF8))
                {
                    //第一步：清空数据
                    //第二部：装载数据

                    //数组-数据结构
                    for (int i = 0; i < this.MyObjects.Length; i++)
                    {
                        this.MyObjects[i] = null;
                    }
                    for (int i = 0; sr.Peek() > -1; i++)
                    {
                        if (i < this.MyObjects.Length)
                        {
                            this.MyObjects[i] = tools.MyDeserialize(sr.ReadLine());
                        }
                    }

                    sr.Close();
                }
                flag = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            

            return flag;
        }

        public bool LoadArrayList(IMyObjectTools tools)
        {
            bool flag = false;

            try
            {
                using (StreamReader sr = new StreamReader(tools.SaveFile, Encoding.UTF8))
                {
                    //第一步：清空数据
                    //第二部：装载数据
                    //ArrayList一数据结构
                    this.MyObjectArrayList.Clear();
                    while (sr.Peek() > -1)
                    {
                        this.myObjectArrayList.Add(tools.MyDeserialize(sr.ReadLine()));
                    }

                    sr.Close();
                }
                flag = true;
            }
            catch (Exception e)
            {
                throw e;
            }


            return flag;
        }

        public bool LoadHashtable(IMyObjectTools tools)
        {
            bool flag = false;

            try
            {
                using (StreamReader sr = new StreamReader(tools.SaveFile, Encoding.UTF8))
                {
                    //第一步：清空数据
                    //第二部：装载数据
                    
                    //Hashtable-数据结构
                    this.MyObjectsHashtable.Clear();
                    while (sr.Peek() > -1)
                    {
                        IMyObject temp = tools.MyDeserialize(sr.ReadLine());
                        this.MyObjectsHashtable.Add(temp.PrimaryKey, temp);
                    }
                    sr.Close();
                }
                flag = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return flag;
        }

        public bool LoadSortedList(IMyObjectTools tools)
        {
            bool flag = false;

            try
            {
                using (StreamReader sr = new StreamReader(tools.SaveFile, Encoding.UTF8))
                {
                    //第一步：清空数据
                    //第二部：装载数据

                    //SortedList-数据结构
                    this.MyObjectSorteList.Clear();
                    while (sr.Peek() > -1)
                    {
                        IMyObject temp = tools.MyDeserialize(sr.ReadLine());
                        this.MyObjectSorteList.Add(temp.PrimaryKey, temp);
                    }

                    sr.Close();
                }
                flag = true;
            }
            catch (Exception e)
            {
                throw e;
            }


            return flag;
        }

        public bool LoadList(IMyObjectTools tools)
        {
            bool flag = false;

            try
            {
                if (!File.Exists(tools.SaveFile))
                {
                    using (StreamWriter fs = new StreamWriter(tools.SaveFile,false,Encoding.UTF8))
                    {
                        fs.Close();
                    }
                }
                using (StreamReader sr = new StreamReader(tools.SaveFile, Encoding.UTF8))
                {
                    //第一步：清空数据
                    //第二部：装载数据

                    //List<>泛型-数据结构
                    this.MyobjectList.Clear();
                    while (sr.Peek() > -1)
                    {
                        IMyObject temp = tools.MyDeserialize(sr.ReadLine());
                        this.MyobjectList.Add(temp);
                    }

                    sr.Close();
                }
                flag = true;
            }
            catch (Exception e)
            {
                throw e;
            }


            return flag;
        }

        public bool LoadDictionary(IMyObjectTools tools)
        {
            bool flag = false;

            try
            {
                using (StreamReader sr = new StreamReader(tools.SaveFile, Encoding.UTF8))
                {
                    //第一步：清空数据
                    //第二部：装载数据

                    //Dictionary<>泛型-数据结构
                    this.MyObjectDictionary.Clear();
                    while (sr.Peek() > -1)
                    {
                        IMyObject temp = tools.MyDeserialize(sr.ReadLine());
                        this.MyObjectDictionary.Add(temp.PrimaryKey, temp);
                    }

                    sr.Close();
                }
                flag = true;
            }
            catch (Exception e)
            {
                throw e;
            }


            return flag;
        }
    }
}
