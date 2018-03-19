﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Flexinets.Net
{
    /// <summary>
    /// Wrapper for System.Net.UdpClient
    /// Only a subset of the methods are currently supported
    /// </summary>
    public class UdpClientWrapper : IUdpClient
    {
        private UdpClient _client;
        public Socket Client => _client.Client;

        public UdpClientWrapper(IPEndPoint localEndpoint)
        {
            _client = new UdpClient(localEndpoint);
        }


        public void Close()
        {
            _client.Close();
        }


        public void Send(Byte[] content, Int32 length, IPEndPoint recipient)
        {
            _client.Send(content, length, recipient);
        }


        public Task<UdpReceiveResult> ReceiveAsync()
        {
            return _client.ReceiveAsync();
        }


        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}
