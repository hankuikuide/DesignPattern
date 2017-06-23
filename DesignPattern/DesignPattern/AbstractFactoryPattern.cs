﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DesignPattern
{
    public abstract class Mac
    {
        public abstract void Show();
    }

    public class MacPro : Mac
    {
        public override void Show()
        {
            Console.WriteLine("我是 Mac Pro");
        }
    }

    public class MacAir : Mac
    {
        public override void Show()
        {
            Console.WriteLine("我是 Mac Air");
        }
    }

    public class MacMini : Mac
    {
        public override void Show()
        {
            Console.WriteLine("我是 Mac Mini");
        }
    }

    public abstract class IPad
    {
        public abstract void Show();
    }

    public class IPadPro:IPad
    {
        public override void Show()
        {
            Console.WriteLine("我是 IPad Pro");
        }
    }

    public class IPadAir : IPad
    {
        public override void Show()
        {
            Console.WriteLine("我是 IPad Air");
        }
    }

    public class IPadMini : IPad
    {
        public override void Show()
        {
            Console.WriteLine("我是 IPad Mini");
        }
    }

    public abstract class AbstractFactory
    {
        public abstract Mac CreateMac();
        public abstract IPad CreateIPad();
    }

    /// <summary>
    /// Pro产品族工厂
    /// </summary>
    public class ProFactory : AbstractFactory
    {
        public override IPad CreateIPad()
        {
            return new IPadPro();
        }

        public override Mac CreateMac()
        {
            return new MacPro();
        }
    }

    /// <summary>
    /// Air产品族工厂
    /// </summary>
    public class AirFactory : AbstractFactory
    {
        public override IPad CreateIPad()
        {
            return new IPadAir();
        }

        public override Mac CreateMac()
        {
            return new MacAir();
        }
    }

    /// <summary>
    /// Mini产品族工厂
    /// </summary>
    public class MIniFactory : AbstractFactory
    {
        public override IPad CreateIPad()
        {
            return new IPadMini();
        }

        public override Mac CreateMac()
        {
            return new MacMini();
        }
    }
}
