using System;

namespace Serialization
{
    internal class Program
    {
        private static Method method;
        static void Main(string[] args)
        {
            method.Write();
            method.XMLSer();
            method.XMLDes();
            method.JsonSer();
            method.JsonDes();
        }
    }
}
