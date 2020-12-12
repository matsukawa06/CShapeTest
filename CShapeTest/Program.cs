using System;

namespace CShapeTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //// 文字列の処理
            //StringTest st = new StringTest();
            //st.test();

            //// 数値
            //NumberTest num = new NumberTest();
            //num.NumberInteger();
            //num.NumberDouble();
            //num.NumberDecimal();
            //num.Kadai();

            // 分岐・ループ
            IfLoopTest ifloop = new IfLoopTest();
            ifloop.Bunki();
            ifloop.loop();

            // リストコレクション

        }
    }
}
