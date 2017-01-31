
namespace Host
{
    using NServiceBus;

    /*
		This class configures this endpoint as a Server. More information about how to configure the NServiceBus host
		can be found here: http://particular.net/articles/the-nservicebus-host
	*/
    /// <remarks>
    /// https://docs.particular.net/samples/hosting/nservicebus-host/?version=host_4
    /// </remarks>
    [EndpointName("Host")]
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server, IWantCustomInitialization
    {
	    public void Init()
	    {
            Configure.Serialization.Json();

            var configure = Configure.With();

            configure.DefineEndpointName("Host");
            configure.DefaultBuilder();
            configure.InMemorySagaPersister();
            configure.UseInMemoryTimeoutPersister();
            configure.InMemorySubscriptionStorage();
            configure.UseTransport<Msmq>();
        }
    }
}
