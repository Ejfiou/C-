using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace SabBoy
{
    /// <summary>
    /// 抽象类
    /// </summary>
    public abstract class BaseEntity
    {
        //坐标
        public int XPos { get; set; }
        public int YPos { get; set; }
        //速度和方向控制
        public int SpeedX { get; set; }
        public int SpeedY { get; set; }
        //对象载体
        public Rectangle Rect { get; set; }
        //画对象
        public abstract void Draw(Graphics g);
    }
}
