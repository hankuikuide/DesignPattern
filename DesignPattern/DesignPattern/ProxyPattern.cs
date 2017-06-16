
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatten.DesignPattern
{
    ///// <summary>
    ///// 酒店服务
    ///// </summary>
    //public interface IHotelService
    //{
    //    /// <summary>
    //    /// 客房预订
    //    /// </summary>
    //    void Booking();
    //}

    //public class HotelService : IHotelService
    //{
    //    //使用Castle动态代理，被代理的方法，需要加virtual
    //    public virtual void Booking()
    //    {
    //        // 业务逻辑。。。
    //    }
    //}


    //public class CtripProcessCastle : IInterceptor
    //{
    //    public void Intercept(IInvocation invocation)
    //    {
    //        this.Before();
    //        invocation.Proceed();
    //        this.After();
    //    }

    //    public void Before()
    //    {
    //        //租车 + 早餐 + 保险
    //    }

    //    public void After()
    //    {
    //        //景点门票+其他费用
    //    }
    //}


    //public class Customer
    //{
    //    public void Travel()
    //    {
    //        IHotelService hotelService = new CtripService();
    //        // 使用代理模式，如使用第三方的服务，势必要加一些其他的“服务”项目。。。。。
    //        hotelService.Booking();

    //    }
    //}
}
