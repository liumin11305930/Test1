//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1
//{
//    class Class1
//    {
//        static void Main(string[] args)
//        {
//            MyClass mc = new MyClass();
//            mc.Age = 10;
//            mc.Name = "张三";
//            //需求：只包含有属性为名字的类
//          var st=  new { Name = "李四" };
//            net15Entities net15 = new net15Entities();
//           var list2= net15.Product.Select(e => new {编号=e.Pid});
//            foreach (var item in list2)
//            {
//                Console.WriteLine(item.编号);
//            }
//           // Console.WriteLine(st.GetType().Name);

//        }
//    }


//    class MyClass
//    {
//        public int Age { get; set; }
//        public string Name { get; set; }
//    }
//}
