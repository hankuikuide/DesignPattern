using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DesignPattern
{
    //继承自EventArgs
    //用作保存状态,还可以扩展其他的功能
    public class StateChangeEventArgs : EventArgs
    {
        public string State { get; set; }
        public StateChangeEventArgs(string state)
        {
            this.State = state;
        }
    }

    //定义一个委托 
    public delegate void StateChangeEventHandler(object sender, StateChangeEventArgs e);

    public class Door
    {
        public event StateChangeEventHandler StateChange;

        public string DoorState { get; set; }
        public void Open()
        {
            this.DoorState = "开启";

            Console.WriteLine(string.Format("门开起"));
            StateChangeEventArgs e = new StateChangeEventArgs(this.DoorState);
            StateChange(this, e);
        }
    }

    public abstract class Observer
    {
        public abstract void Action(object sender, StateChangeEventArgs e);
    }

    public class Light : Observer
    {
        private string name;

        public Light(string name)
        {
            this.name = name;
        }
        public override void Action(object sender, StateChangeEventArgs e)
        {

            Console.WriteLine(string.Format("门{0}，{1}灯 亮起", e.State, this.name));
        }
    }

    public class TV : Observer
    {
        public override void Action(object sender, StateChangeEventArgs e)
        {
            Console.WriteLine(string.Format("TV 打开"));
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.OutputEncoding = Encoding.UTF8;

    //        Observer masterRoom = new Light("主卧室");
    //        Observer livingRoom = new Light("客厅");
    //        Observer tv = new TV();

    //        Door door = new Door();

    //        door.StateChange += masterRoom.Action;
    //        door.StateChange += livingRoom.Action;
    //        door.StateChange += tv.Action;

    //        door.Open();

    //        Console.ReadKey();
    //    }
    //}

}
