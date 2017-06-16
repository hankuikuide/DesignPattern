using System;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    /// 付款 抽象类
    /// </summary>
    public abstract class AbstractPayment
    {
        /// <summary>
        /// 第一步：设计请求参数
        /// </summary>
        protected abstract void Request();

        /// <summary>
        /// 第二步：排序
        /// </summary>
        protected abstract void Sort();

        /// <summary>
        /// 第三步：加密码
        /// </summary>
        protected abstract void Encrypt();

        /// <summary>
        /// 模板方法：付款
        /// </summary>
        public void Pay()
        {
            Request();
            Sort();
            Encrypt();
            Console.WriteLine("付款请求已发送");
        }
    }

    public class AliPayment : AbstractPayment
    {
        protected override void Encrypt()
        {
            Console.WriteLine("AliPay 请求加密 ");
        }

        protected override void Request()
        {
            Console.WriteLine("AliPay 构造请求参数 ");
        }

        protected override void Sort()
        {
            Console.WriteLine("AliPay 参数排序 ");

        }
    }

    public class WeiXinPay : AbstractPayment
    {
        protected override void Encrypt()
        {
            Console.WriteLine("WeiXinPay 参数加密");
        }

        protected override void Request()
        {
            Console.WriteLine("WeiXinPay 构造请求参数");
        }

        protected override void Sort()
        {
            Console.WriteLine("WeiXinPay 参数排序");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            AbstractPayment aliPay = new AliPayment();
            aliPay.Pay();

            Console.WriteLine("-----------------分界线------------------");

            AbstractPayment weixinPay = new WeiXinPay();
            weixinPay.Pay();

            Console.ReadKey();
        }
    }
}