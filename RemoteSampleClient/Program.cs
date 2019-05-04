//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace RemoteSampleClient
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}


using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemoteSample;

namespace RemoteSampleClient
{
    public class RemoteClient
    {
        public static void Main(string[] args)
       {
           ChannelServices.RegisterChannel(new TcpClientChannel(), true);
            RemoteObject remoteobj = (RemoteObject)Activator.GetObject(typeof(RemoteObject),
            "tcp://localhost:6666/RemoteObject");
            Console.WriteLine("1 + 2 = " + remoteobj.sum(1,2).ToString());
            Console.ReadLine();
        }
    }
}
//--------------------- 
//作者：evenhbz 
//来源：CSDN 
//原文：https://blog.csdn.net/evenhbz/article/details/83984149 
//版权声明：本文为博主原创文章，转载请附上博文链接！
