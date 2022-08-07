using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d2._5转义符
{
    class Program
    {
        static void Main(string[] args)
        {
            //换行        /n
            Console.WriteLine(" 轲既取图奉之，\n 发图，\n 图穷而匕首见。\n");
            Console.ReadKey();
            // 输出"         \"
            Console.WriteLine(" 书曰：\"郑伯克段于鄢。\"段不弟，故不言弟；");
            Console.ReadKey();
            // 空格【tab】 \t
            Console.WriteLine(" \t 忆梅下西洲，\t 折梅寄江北。\t 单衫杏子红，\t 双鬓鸦雏色。\t ");
            Console.ReadKey();
            // 删除前面一个字符   \b   \b在字符串两边无作用
            Console.WriteLine(" 我\b我知言，我\b我善养吾浩然之气气\b。 ");
            Console.ReadKey();

            // \r\n Windows 文本格式换行
            //String txt = "北冥有鱼其名为鲲。";
            //System.IO.File.WriteAllText(@"D:\1.txt",txt);
            //String txt1 = "北冥有鱼\r\n其名为鲲。";
            //System.IO.File.WriteAllText(@"D:\2.txt", txt1);
            //Console.WriteLine("OK ");
            //Console.ReadKey();


            //  \\表示为 一个\
            String app = "C:\\APP\\app.exe";
            Console.WriteLine(app);
            Console.ReadKey();
            //@  1.取消斜线在字符串中的转义作用
            String app1 = @"C:\APP\1111111\vs\ooooooooooo\app.exe";
            Console.WriteLine(app1);
            Console.ReadKey();


            /*!!!!!!!!!!!!!!!!!!!!!!报错！！！！！！！！！！！！！！！！
            Console.WriteLine(" 我知言，
            我善养吾浩然之气。 ");
             
             */

            //@ 2.保留原格式输出
            Console.WriteLine(@" 我知言，
            我善养吾浩然之气。 ");
            Console.ReadKey();



        }
    }
}
