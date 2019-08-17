using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class4
    {
        static void Main(string[] args)
        {
            //2 实例化委托
            //  TestDelegate td = new TestDelegate(Show);
            // TestDelegate td = Show;
            //匿名方法
            //TestDelegate td = delegate (int ba) {
            //    return ba + "夏天好热";
            //};
            //lambda
            TestDelegate td = (ba) =>
            {
                return ba + "夏天好热";
            };
            Func<int, string> td2 = (e) => {
                return e + "夏天好热";
            };
        
           
            //3 调用委托 
           string a= td2(1);
            Console.WriteLine(a);
        }

        private static string Show(int a)
        {
            // Console.WriteLine("夏天好热");
            return a+ "夏天好热";
        }
    }
    //1 定位委托
    public delegate string TestDelegate(int a);
}
