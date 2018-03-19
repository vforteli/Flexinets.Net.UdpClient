Flexinets.Net.IUdpClient

Usage
``` 
 var expected = "test";
var bytes = Encoding.UTF8.GetBytes(expected);

var client = new UdpClientMock();
var factory = new UdpClientMockFactory(client);

var task = factory.CreateClient(null).ReceiveAsync();

client.SendMock(new UdpReceiveResult(bytes, new IPEndPoint(IPAddress.Any, 1812)));

var resultBytes = await task;
var actual = Encoding.UTF8.GetString(resultBytes.Buffer);

Assert.AreEqual(expected, actual);