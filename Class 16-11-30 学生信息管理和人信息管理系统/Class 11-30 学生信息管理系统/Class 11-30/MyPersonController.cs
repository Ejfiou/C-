using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public class MyPersonController
    {
        public MyPersonController()
        { }

        //得到人视图实例
       // private MyPersonView view = new MyPersonView();
        private MyPersonView view = new MyStudentView();
        //得到人数据访问对象实例
        private PersonDAO dao = new PersonDAO();
        //得到学生数据访问对象实例
        private UserDAO daoUser = new UserDAO();

        /// <summary>
        /// 程序开始
        /// </summary>
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
                if (correctUser.Password == logInUser.Password)
                {
                    //登录成功
                    view.Clear();
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
                    case 1: //增加人信息
                        Add();
                        break;
                    case 2://查询所有人信息
                        SelectAll();
                        break;
                    case 3://修改人信息
                        Modify();
                        break;
                    case 4://删除人信息
                        Remove();
                        break;
                    case 5://按主键查询对应的人信息
                        QueryByPrimaryKey();
                        break;
                    case 6://按名字查询对应的人信息
                        QueryByName();
                        break;
                    default:
                        view.PrintMessage("对不起！没有实现您要的功能！");
                        break;
                }
                view.Clear();
            } while (true);
        }


        /// <summary>
        /// 增加人信息
        /// </summary>
        public void Add()
        {
            Person s = view.Create();
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
        /// 修改人信息
        /// </summary>
        public void Modify()
        {
            Person s = view.Modify();
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
        /// 删除人信息
        /// </summary>
        public void Remove()
        {
            Person s = view.Remove();
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
        ///查询所有人信息
        /// </summary>
        public void SelectAll()
        {
            Person[] tempStu = dao.SelectAll();
            view.PrintMany(tempStu);
        }

        /// <summary>
        /// 按主键查询人信息
        /// </summary>
        public void QueryByPrimaryKey()
        {
            string stuNo = view.QueryByPrimaryKey();
            Person s = dao.SelectByPrimaryKey(stuNo);
            view.PrintOne(s);
        }

        /// <summary>
        /// 按姓名查询人信息
        /// </summary>
        public void QueryByName()
        {
            string name = view.QueryByName();
            Person[] stus = dao.SelectByName(name);
            view.PrintMany(stus);
        }




    }
}
