using NServiceBus;
using NServiceBus.Logging;

namespace Host
{
    public class CancelOrderService :
        WcfService<CancelOrder, ErrorCodes>
    {
    }

    public class CancelOrderHandler :
        IHandleMessages<CancelOrder>
    {
        static readonly ILog Log = LogManager.GetLogger(typeof(CancelOrderHandler));

        IBus bus;

        public CancelOrderHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(CancelOrder message)
        {
            // code to handle the message
            Log.InfoFormat("Handler to cancel order {0}", message.OrderId);
            // return a status so that the WCF service has a return value
            bus.Return(ErrorCodes.Success);
        }
    }

    public enum ErrorCodes
    {
        Success,
        Fail
    }

    public class CancelOrder :
        ICommand
    {
        public int OrderId { get; set; }

    }
}