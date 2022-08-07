using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d2._6_算术运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             + - * / %
             * 运算优先级：先乘除，后加减，右括号先算括号里面，相同级别的从左到右运算。
             */


            //已知a1=30,a2=60,a3=90求a1 a2 a3 总和和平均值。
            int a1 = 30;
            int a2 = 60;
            int a3 = 90;
            Console.WriteLine("总和{0}，平均值{1}",a1 +a2 + a3,(a1+a2+a3)/3);
            Console.ReadKey();

            //已知圆的半径为9求周长和面积？已知（pi=3.14）面积=pi*半径² 周长=2pi * 半径
            int r = 9;
            double pi =3.14;
            double area = pi * r * r;
            double circumference = 2 * pi * r;
            Console.WriteLine("圆的面积{0}，圆的周长{1}", area, circumference);
            Console.ReadKey();


            //衣服30¥ 裤子150¥  5件衣服2件裤子要花多少¥？如果打五折需要多少  
            int clothes =30;
            int trousers =150;
            double y52k = clothes * 5 + trousers * 2;  //隐式类型转换  int转double自动类型转换 用法：double 变量名 = int变量
            Console.WriteLine("5件衣服2件裤子要花"+ y52k +"¥");
            double d5z = y52k *0.5 ;
            Console.WriteLine("5件衣服2件裤子打五折需{0}", d5z + "¥");
            Console.ReadKey();




             //甲、乙两地相距360千米，一辆汽车从甲地开往乙地，行了全程的4/9，这时距甲地多少千米？
            double e1 = 360 * 4 / 9;
            double e2 = 360 - e1;
            Console.WriteLine("这时距甲地{0}千米？",e2);
            Console.ReadKey();





            //师徒两人共加工零件80个，徒弟加工零件的个数是师傅的3/5。师傅和徒弟共加工零件多少个?师傅和徒弟各加工零件多少个？
            int gong = 80;
            //在c# 中保留几位小数         Math.Round(((decimal)除法运算), 保留几位小数);
            double sf = gong * (double)Math.Round(((decimal)5 / 8), 3); //显式类型转换  decimal 变量转double 强制类型转换  用法： （double）值
            double td = gong - sf;
            //double 变量转int  （int）变量名
            Console.WriteLine("师傅和徒弟各加工零件{0}个，师傅加工了{1}个，徒弟加工了{2}个", gong,sf,td);
            Console.ReadKey();
            Console.WriteLine(5 % 2); //取余
            Console.WriteLine((double)Math.Round(((decimal)5/ 2), 10)); ; //取商

            Console.ReadKey();

            /*
             * 5/2=2.5
                        2                ---------------->商
                    ---------
     除数 <——— 2 ﹚ 5                 ---------------->被除数
                        4                ---------------->商*除数
                    -----------
                        1               ---------------->余数
             取余“%”，就是获取一个数除以另一个数的余数。
             取商“/”，就是数学四则运算中的除数计算，获取“商值"，不管"余数"。
             
             
             
             */

        }
    }
}
