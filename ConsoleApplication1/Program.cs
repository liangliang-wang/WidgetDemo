using System;
using System.IO;

namespace ConsoleApplication1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //var creatXML = XmlCreateAndReadForLinq.CreatXML();
            //var value = XmlCreateAndReadForLinq.SearchXML();

            //IOTest t = new IOTest();
            //t.Get(@"F:\保存文件\王亮-Utf8.txt");

            // WindowsServiceMonitor monitor = new WindowsServiceMonitor("10.1.56.85", "lj5351", "2015@ly.com");

            //var obj = monitor.GetServiceList("TickService");
            //var obj01 = monitor.GetServiceValue("TickService", "TcVacationTick");


            //Person p = new Person();
            //p.Name = "HJJ";
            //p.Age = 18;
            //p.Sex = "女";

            //Car c = new Car("red", "DS");

            //Console.WriteLine(c.Qidong(p));

            //Oldpeople op = new Oldpeople();
            //op.Name = "KKK";

            //Console.WriteLine(op.Foot(p));

            //Test t = new Test();
            //t.s();
            ContentFind s = new ContentFind();
            var filesNmae = s.FindContent(@"C:\Users\Administrator\Documents\WeChat Files\wl6491\Files\brokers\brokers", "金石");
            Console.WriteLine(filesNmae);
            Console.ReadLine();
        }


        private void Test()
        {
            int a = 10;
            object a1 = a;//装箱

            int b = Convert.ToInt32(a1); //拆箱
        }
    }
}
