//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace RemoteSampleServer
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
//using System.Runtime.Remoting.Channels;
using RemoteSample;

namespace RemoteSampleServer
 {
    public class RemoteServerr
    {
        public static void Main(String[] args)
        {
           
           // System.Runtime.Remoting.Channels.Tcp 
             TcpServerChannel channel = new TcpServerChannel(6666);
             //IChannel channel = new TcpServerChannel(6666);
             ChannelServices.RegisterChannel(channel, true);
             RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteObject),
                 "RemoteObject", WellKnownObjectMode.SingleCall);
             System.Console.WriteLine("Press Any Key");
             System.Console.ReadLine();
         }
    }
}
//--------------------- 
//作者：evenhbz 
//来源：CSDN 
//原文：https://blog.csdn.net/evenhbz/article/details/83984149 
//版权声明：本文为博主原创文章，转载请附上博文链接！