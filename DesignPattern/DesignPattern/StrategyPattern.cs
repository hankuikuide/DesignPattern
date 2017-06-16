using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DesignPattern
{
    /// <summary>
    /// 行程方案
    /// </summary>
    public abstract class JourneyStrategy
    {
        public abstract void Show();
    }

    /// <summary>
    /// 火车
    /// </summary>
    public class TrainStrategy : JourneyStrategy
    {
        public override void Show()
        {
            Console.WriteLine("火车方案...");
        }
    }

    /// <summary>
    /// 飞机
    /// </summary>
    public class PlaneStrategy : JourneyStrategy
    {
        public override void Show()
        {
            Console.WriteLine("飞机方案...");

        }
    }

    /// <summary>
    /// 汽车
    /// </summary>
    public class BusStrategy : JourneyStrategy
    {
        public override void Show()
        {
            Console.WriteLine("汽车方案...");
        }
    }

    /// <summary>
    /// 游客Context
    /// </summary>
    public class Tourist
    {
        public JourneyStrategy Strategy { get; set; }

        public void ShowJourneyStrategy()
        {
            Strategy.Show();
        }
    }

}
