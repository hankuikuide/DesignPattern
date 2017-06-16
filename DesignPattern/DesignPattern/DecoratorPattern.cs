using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatten.DesignPattern
{
    /// <summary>
    /// 酒店服务
    /// </summary>
    public interface IHotelService
    {
        /// <summary>
        /// 客房预订
        /// </summary>
        void Booking();
    }

    public class HotelService : IHotelService
    {
        public void Booking()
        {
            // 业务逻辑。。。
        }
    }


    public abstract class DecoratorService : IHotelService
    {
        private IHotelService hotelService;

        public DecoratorService(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        public virtual void Booking()
        {
            if (this.hotelService != null)
            {
                this.hotelService.Booking();
            }
        }
    }

    /// <summary>
    /// 携程服务给酒店预订增加了服务
    /// </summary>
    public class CtripService : DecoratorService
    {
        public CtripService(IHotelService hotelService) : base(hotelService)
        {
        }

        public override void Booking()
        {
            this.Before();

            base.Booking();

            this.After();
        }

        public void Before()
        {
            //租车 + 早餐 + 保险
        }

        public void After()
        {
            //景点门票+其他费用
        }

    }

    /// <summary>
    /// 携程服务给酒店预订增加了服务
    /// </summary>
    public class QunarService : DecoratorService
    {
        public QunarService(IHotelService hotelService) : base(hotelService)
        {
        }

        public override void Booking()
        {
            this.Before();

            base.Booking();

            this.After();
        }

        public void Before()
        {
            //租车 + 早餐 + 保险
        }

        public void After()
        {
            //景点门票+其他费用
        }

    }


    public class Customer
    {
        public void Travel()
        {

            IHotelService hotelService = new HotelService();

            DecoratorService ctripService = new CtripService(hotelService);
            // 如使用第三方的服务:携程，势必要加一些其他的“服务”项目。。。。。
            ctripService.Booking();

            DecoratorService qunarService = new QunarService(hotelService);
            // 如使用第三方的服务：去哪儿，势必要加一些其他的“服务”项目。。。。。
            qunarService.Booking();

        }
    }
}
