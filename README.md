Flexinets.Net.IUdpClient

Usage
``` 
var expected = "test";
var bytes = Encoding.UTF8.GetBytes(expected);

var client = new UdpClientMock();
var factory = new UdpClientMockFactory(client);

// It is important that the receive and send methods are called on different threads, or they will deadlock
var task = Task.Run(() =>
{
  return factory.CreateClient(null).ReceiveAsync();
});

client.SendMock(new UdpReceiveResult(bytes, new IPEndPoint(IPAddress.Any, 1812)));

var resultBytes = await task;
var actual = Encoding.UTF8.GetString(resultBytes.Buffer);

Assert.AreEqual(expected, actual);
