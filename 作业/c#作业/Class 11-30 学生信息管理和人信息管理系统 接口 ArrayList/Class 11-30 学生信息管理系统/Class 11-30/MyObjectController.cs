using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    /// <summary>
    /// 让接口视图和接口对象数据产生关系
    /// </summary>
    public class MyObjectController
    {
        public MyObjectController()
        {
           
        }

        //得到万事万物中的某种信息的视图实例
        //人员信息管理
        private MyObjectView view = new MyObjectPersonView();

        //学生信息管理
        //private MyObjectView view = new MyObjectStudentView();

        //老师信息管理
        //private MyObjectView view = new MyObjectTeacherView();      

        //书信息管理
        //private MyObjectView view = new MyObjectBookView();

        //得到万事万物中的某种信息的数据访问对象实例
        //人DAO
        //private MyObjectDAO dao = new MyObjectPersonDAO();
        private IMyObjectDAO dao = new MyObjectPersonDAOArrayList();

       // private IMyObjectDAO dao = new MyObjectPesonDAOHashtable();
        //书DAO
        //private MyObjectDAO dao = new MyObjectBookDAO();

        //得到用户数据访问对象实例
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
                    view.PrintMessage("恭喜您！登录成功！");
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
                        QueryByNonPrimaryKey();
                        break;
                    default:
                        view.PrintMessage("对不起！没有实现您要的功能！");
                        break;
                }
                view.Clear();
            } while (true);
        }

        /// <summary>
        /// 增加信息
        /// </summary>
        public void Add()
        {
            IMyObject s = view.Create();
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
        /// 修改信息
        /// </summary>
        public void Modify()
        {
            IMyObject s = view.Modify();
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
        ///查询所有信息
        /// </summary>
        public void SelectAll()
        {
            IMyObject[] tempStu = dao.SelectAll();
            view.PrintMany(tempStu);
        }

        /// <summary>
        /// 按主键查询人信息
        /// </summary>
        public void QueryByPrimaryKey()
        {
            string stuNo = view.QueryByPrimaryKey();
            IMyObject s = dao.SelectByPrimaryKey(stuNo);
            view.PrintOne(s);
        }

        /// <summary>
        /// 按非主键查询信息
        /// </summary>
        public void QueryByNonPrimaryKey()
        {
            IMyObject obj = view.QueryByNonPrimaryKey();
            IMyObject[] objs = dao.SelectByNonPrimaykey(obj);
            view.PrintMany(objs);
        }

        public void Remove()
        {
            IMyObject s = view.Remove();
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



    }
}
