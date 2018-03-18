using System.Net;

namespace Flexinets.Net
{
    public class UdpClientMockFactory : IUdpClientFactory
    {
        private IUdpClient _mockClient;


        public UdpClientMockFactory(IUdpClient mockClient)
        {
            _mockClient = mockClient;
        }


        public IUdpClient CreateClient(IPEndPoint localEndpoint)
        {
            return _mockClient;
        }
    }
}
