using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    /// <summary>
    /// 对于学生信息的数据访问对象
    /// （student database access object）
    /// </summary>
    public class StudentDAO
    {
        public StudentDAO()
        {

        }

        //得到数据仓库（数据库）实例
        private Database db = new Database();

        /// <summary>
        /// 增加学生信息
        /// </summary>
        /// <param name="stu">新增学生信息</param>
        /// <returns>返回true表示增加成功；否则返回false表示增加失败</returns>
        public bool Insert(Student stu)
        {
            bool flag = false;

            //判断是否存在有相同的学号
            for (int i = 0; i < db.Students.Length; i++)
            {
                //判断当前i位置上是否有学生对象
                if (db.Students[i] != null)//有学生对象
                {
                    if (db.Students[i].StuNo == stu.StuNo)
                    {
                        return flag;
                    }
                }
            }


            for (int i = 0; i < db.Students.Length; i++)
            {
                //判断当前i位置上是否有学生对象
                if (db.Students[i] == null)//没有学生对象
                {
                    db.Students[i] = stu;
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="stu">要删除的学生对象</param>
        /// <returns>返回true表示删除成功；否则返回false表示删除失败</returns>
        public bool Delete(Student stu)
        {
            bool flag = false;

            for (int i = 0; i < db.Students.Length; i++)
            {
                //判断当前i位置上是否有学生对象
                if (db.Students[i] != null)//有学生对象
                {
                    if (db.Students[i].StuNo == stu.StuNo)
                    {
                        //删除学生信息
                        db.Students[i] = null;
                        flag = true;
                        break;
                    }
                }
            }
            return flag;
        }

        /// <summary>
        ///查询所有学生信息 
        /// </summary>
        /// <returns>所有学生信息的数组</returns>
        public Student[] SelectAll()
        {
            Student[] temp = null;

            int realStudentCount = 0;
            for (int i = 0; i < db.Students.Length; i++)
            {
                //判断当前i位置上是否有学生对象
                if (db.Students[i] != null)//有学生对象
                {
                    realStudentCount++;
                }
            }

            if (realStudentCount > 0)
            {
                temp = new Student[realStudentCount];//创建有多少个学生的数组

                //将 学生信息数据（学生信息表）中的学生信息写人到temp中
                int j = 0;//作为temp数组的下标
                for (int i = 0; i < db.Students.Length; i++)
                {
                    //判断当前i位置上是否有学生对象
                    if (db.Students[i] != null)//有学生对象
                    {
                        //将db.Students的i位置上的学生对象赋值给temp的j位置
                        temp[j] = db.Students[i];
                        j++;
                    }
                }
            }

            return temp;
        }

        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="stu">修改后的新的学生信息数据</param>
        /// <returns>返回true表示修改成功；否则返回false表示修改失败</returns>
        public bool Update(Student stu)
        {
            bool flag = false;

            for (int i = 0; i < db.Students.Length; i++)
            {
                //判断当前i位置上是否有学生对象
                if (db.Students[i] != null)//有学生对象
                {
                    if (db.Students[i].StuNo == stu.StuNo)
                    {
                        //修改学生信息
                        db.Students[i] = stu;
                        flag = true;
                        break;
                    }
                }
            }

            return flag;
        }




        /// <summary>
        /// 按照学号查询对应的学生信息
        /// </summary>
        /// <param name="stu">查询的学号</param>
        /// <returns>对应的学生信息</returns>
        public Student SelectByStuNo(string stu)
        {
            Student temp = null;

            for (int i = 0; i < db.Students.Length; i++)
            {
                //判断当前i位置上是否有学生对象
                if (db.Students[i] != null)//有学生对象
                {
                    if (db.Students[i].StuNo == stu)
                    {
                        //查出学生信息
                        temp = db.Students[i];
                        break;                       
                    }
                }
            }
            return temp;
        }

        /// <summary>
        /// 按照姓名查询对应的学生信息
        /// </summary>
        /// <param name="stu">查询的姓名</param>
        /// <returns>所有学生信息的数组</returns>
        public Student[] SelectByStuName(string name)
        {
            Student[] temp = null;

            int realStudentByNameCount  = 0;

            for (int i = 0; i < db.Students.Length; i++)
            {
                //判断当前i位置上是否有学生对象
                if (db.Students[i] != null)//有学生对象
                {
                    if (db.Students[i].Name == name)
                    {
                        //查出学生信息                       
                        realStudentByNameCount++;
                    }
                }
            }

            if(realStudentByNameCount>0)
            {
                temp = new Student[realStudentByNameCount];
                int j = 0;
                for (int i = 0; i < db.Students.Length; i++)
                {
                    //判断当前i位置上是否有学生对象
                    if (db.Students[i] != null)//有学生对象
                    {
                        if (db.Students[i].Name == name)
                        {
                            //查出学生信息
                            temp[j] = db.Students[i];
                            j++;
                        }
                    }
                }
            }

            return temp;
        }   
    }
}
