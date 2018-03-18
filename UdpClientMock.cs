using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Flexinets.Net
{
    public class UdpClientMock : IUdpClient
    {
        private TaskCompletionSource<UdpReceiveResult> _taskCompletionSource;

        public Socket Client => throw new NotImplementedException();

        public void Close()
        {
            // Ok...
        }

        public void Dispose()
        {
            // Sure...            
        }

        public async Task<UdpReceiveResult> ReceiveAsync()
        {
            _taskCompletionSource = new TaskCompletionSource<UdpReceiveResult>();
            return await _taskCompletionSource.Task;
        }

        public void Send(Byte[] content, Int32 length, IPEndPoint recipient)
        {
            throw new NotImplementedException();
        }


        public void SendMock(UdpReceiveResult mockResult)
        {
            _taskCompletionSource.SetResult(mockResult);
        }
    }
}
