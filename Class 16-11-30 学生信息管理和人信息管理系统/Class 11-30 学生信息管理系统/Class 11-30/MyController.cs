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
        //得到学生数据访问对象实例
        private StudentDAO dao = new StudentDAO();
        //得到学生数据访问对象实例
        private UserDAO daoUser = new UserDAO();

        public void Start()
        {
            do
            {
                view.PrintLogInMenu();
                int menuIndex = view.ChoiceMenu();
                if (menuIndex == 0)
                {
                    break;
                }
                switch (menuIndex)
                {
                    case 1://登录系统
                        
                        LogIn();
                        break;
                    default:
                        view.PrintMessage("没有此选项");
                        break;
                }
                view.Clear();
            } while (true);
            
        }

        /// <summary>
        /// 打印菜单
        /// </summary>
        public void Main()
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
                        view.PrintMessage("对不起！没有实现您要的功能！");
                        break;
                }
                view.Clear();
            } while (true);
        }

        /// <summary>
        /// 登录系统
        /// </summary>
        public void LogIn()
        {
            //logInUser是从界面上得到的用户对象
            User logInUser = view.LogIn();
            //correctUser是从数据仓库得到的正确的用户对象
            User correctUser = daoUser.SelectByUsername(logInUser.Username);
            //判断logInUser是否为合法用户correctUser

            if (correctUser != null)
            {
                if(correctUser.Password==logInUser.Password)
                {
                    //登录成功
                    view.Clear1();
                    Main();
                }
                else
                {
                    view.PrintMessage("对不起！密码错误！");
                }
            }
            else
            {
                view.PrintMessage("对不起！没有该用户名！");
            }
        }

        /// <summary>
        /// 增加学生信息
        /// </summary>
        public void AddStudent()
        {
            Student s = view.CreatStudent();
            bool f = dao.Insert(s);
            if (f)
            {
                view.PrintMessage("增加成功！");
            }
            else
            {
                view.PrintMessage("增加失败！");
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
                view.PrintMessage("修改成功！");
            }
            else
            {
                view.PrintMessage("修改失败！");
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
                view.PrintMessage("删除成功！");
            }
            else
            {
                view.PrintMessage("删除失败！");
            }
        }

        /// <summary>
        /// 按学号查询学生信息
        /// </summary>
        public void QueryStudentByStuNo()
        {
            string stuNo = view.QueryStudentByStuNo();
            Student s = dao.SelectByStuNo(stuNo);
            view.PrintStudent(s);
        }

        /// <summary>
        /// 按姓名查询学生信息
        /// </summary>
        public void QueryStudentsByName()
        {
            string name = view.QueryStudentsByName();
            Student[] stus = dao.SelectByStuName(name);
            view.PrintAllStudents(stus);
        }
    }
}
