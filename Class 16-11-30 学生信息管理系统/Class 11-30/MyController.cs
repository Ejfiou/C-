using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{ 
    /// <summary>
    /// 让MyView和StudentDAO产生关系
    /// </summary>
    public class MyController
    {
        public MyController()
        {

        }
        //得到视图实例
        private MyView view = new MyView();
        //得到数据访问对象实例
        private StudentDAO dao = new StudentDAO();

        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            do
            {
                view.PrintMenu();
                int menuIndex = view.ChoiceMenu();
                
                if (menuIndex == 0)
                {
                    break;
                }

                switch (menuIndex)
                {
                    case 1: //增加学生信息
                        AddStudent();
                        break;
                    case 2://查询所有学生信息
                        SelectAllStudent();
                        break;
                    case 3://修改学生信息
                        ModifyStudent();
                        break;
                    case 4://删除学生信息
                        RemoveStudent();
                        break;
                    case 5://按学号查询对应的学生信息
                        QueryStudentByStuNo();
                        break;
                    case 6://按学号查询对应的学生信息
                        QueryStudentsByName();
                        break;
                    default:
                        view.NotFound();
                        break;
                }
                view.Clear(); 
            } while (true);
        }

        /// <summary>
        /// 增加学生信息
        /// </summary>
        public void AddStudent()
        {
            Student s = view.CreatStudent();
            bool f = dao.Insert(s);
            if(f)
            {
                view.PrintSuccess();   
            }
            else
            {
                view.PrintFail();
            }
        }

        /// <summary>
        ///查询所有学生信息
        /// </summary>
        public void SelectAllStudent()
        {
            Student[] tempStu = dao.SelectAll();
            view.PrintAllStudents(tempStu);
        }

        /// <summary>
        /// 修改学生信息
        /// </summary>
        public void ModifyStudent()
        {
            Student s = view.ModifyStudent();
            bool f = dao.Update(s);
            if (f)
            {
                view.PrintSuccess();
            }
            else
            {
                view.PrintFail();
            }
        }

        /// <summary>
        /// 删除学生信息
        /// </summary>
        public void RemoveStudent()
        {
            Student s = view.RemoveStudent();
            bool f = dao.Delete(s);
            if (f)
            {
                view.PrintSuccess();
            }
            else
            {
                view.PrintFail();
            }
        }

        /// <summary>
        /// 查询一个学生信息
        /// </summary>
        public void QueryStudentByStuNo()
        {
            string stuNo = view.QueryStudentByStuNo();
            Student s = dao.SelectByStuNo(stuNo);
            view.PrintStudent(s);            
        }

        public void QueryStudentsByName()
        {
            string name = view.QueryStudentsByName();
            Student[] stus = dao.SelectByStuName(name);
            view.PrintAllStudents(stus);
        }
    }
}
