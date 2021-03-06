﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月6日
/// 作业：04-6
/// 内容：制作一个电影查询系统。要求用户输入要查询的电影名称，返回该电影的相关信息。
///       随后提示"您是否想要再次查询？（y/n）"
/// </summary>
namespace Homework_04_6_11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("本系统现已收录的电影《自杀小队》、《澳门风云2》、《睡眠》。\n");
            do
            {
                Console.Write("请输入要查询的电影名称：");
                string name = Console.ReadLine();
                Console.WriteLine("=====================================================================================================");

                if (name == "自杀小队")
                {
                    Console.WriteLine("名称：《自杀小队》\n主演：威尔·史密斯  汤姆·哈迪  X特遣队\n导演：大卫·阿耶\n类型：喜剧片 剧情 惊悚 动作\n剧情介绍：\n\t《自杀小队》又称《X特遣队》，成员都是面对严重牢狱之灾的超级罪犯，包括死亡射手、鲨王、回旋镖队长和哈利·奎恩等，他们为美国政府干一些极其危险的脏活，以此来为自己减刑。每个成员脖子里都被装有纳米炸弹，如果不乖乖执行任务就会被炸死。");
                }
                else if (name == "澳门风云2")
                {
                    Console.WriteLine("名称：《澳门风云2》\n主演：周润发  张家辉  刘嘉玲    余文乐  王诗龄  \n导演：王晶\n类型：喜剧片 喜剧 剧情 动作\n剧情介绍：\n\t闻名赌坛的“魔术手”石一坚（周润发 饰）在参加好友龙叔（姜大卫 饰）的海上生日派对时，突遭来路不明的女杀手伏击，后得知她们受旧敌D.O.A组织派来灭口，而她们的目标不仅是杀死石一坚，更要捉拿携组织一百五十亿美元资金潜逃的会计小马（张家辉 饰）。为保护小马及粉碎D.O.A的阴谋，石一坚与徒弟Vincent（余文乐 饰）前往泰国，结果与小马及其女儿初一（王诗龄 饰）结成患难拍档，并经历一连串奇遇；期间，石一坚还与旧情人莫愁（刘嘉玲 饰）重逢，两人再续前缘。但让众人始料未及的是，这时D.O.A已布下了一个更大的圈套……");
                }
                else if (name == "睡眠")
                {
                    Console.WriteLine("名称：《睡眠》\n主演：Rohit  Gokani  Victoria  Oliver  Robert \n导演：Chris Reading\n类型：科幻片 科幻 剧情 动作\n剧情介绍：\n\t一个悲伤的船长踏上了他在老龄化货船指挥的最后使命。船上的小船员，沮丧和不满他们的生活在深空尝试完成一个成功的任务，但船有自己的想法。很快，一个“意外”在军队转移到睡眠，在一个被遗忘的部门对太阳系的一个废弃的小行星站。他们很快发现殖民地是由一个神秘的和邪恶的邪教组织，地狱执意对地球黑暗的计划。在睡眠区船员的希望很快变成了危险，因为他们反对殖民者自身的生存斗争，和人类的最终命运。关于地球生命的结束的可怕的事实很快迫使船长面对他的个人的痛苦，导致一个气候和令人兴奋的结论。");
                }
                else
                {
                    Console.WriteLine("您输入的信息有误，查询失败！");
                }

                Console.WriteLine("===================================================================================================");
                Console.Write("您是否想要再次查询？（y/n）：");
                str = Console.ReadLine();
                Console.WriteLine();
            }
            while (str == "y");
        }
    }
}
