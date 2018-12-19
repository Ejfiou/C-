using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public class Bus : IMyObject
    {
        public Bus()
        {

        }

        public Bus(string busNum, string busLine, string startPoint, string endPoint)
        {
            this.BusNum = busNum;
            this.BusLine = busLine;
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }
        private string busLine;

        public string BusLine
        {
            get { return busLine; }
            set { busLine = value; }
        }

        private string busNum;

        public string BusNum
        {
            get { return busNum; }
            set { busNum = value; }
        }

        private string startPoint;

        public string StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }

        private string endPoint;

        public string EndPoint
        {
            get { return endPoint; }
            set { endPoint = value; }
        }

        public string PrimaryKey
        {
            get
            {
                return BusNum;
            }

            set
            {
                BusNum = value;
            }
        }

        public string ShowMe()
        {
            return $"车牌：{BusNum,-10}线路：{BusLine,-9}起点：{StartPoint,-8}终点：{EndPoint,10}";
        }
    }
}
