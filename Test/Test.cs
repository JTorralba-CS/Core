using System;

using Core;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            Log.Console("<START>");

            HelloWorld Test = new HelloWorld();

            if (Test.M != null)
            {
                Log.Console(Test.M);
            }

            Log.Console("I = " + Test.I);
            Log.Console("S = " + Test.S);

            HelloWorld Test2 = new HelloWorld(789, "XYZ");

            if (Test2.M != null)
            {
                Log.Console(Test2.M);
            }

            Log.Console("I = " + Test2.I);
            Log.Console("S = " + Test2.S);

            String[] Grades = new String[5] { "AAAAABBBBBCCCCC", "DDDDDEEEEEFFFFF", "GGGGGHHHHHIIIII", "JJJJJKKKKKLLLLL", "MMMMMNNNNNOOOOO" };
            Log.Console("Grades");
            Log.Console(Grades);

            int[] Scores = new int[5] { 111111, 222222, 333333, 444444, 555555 };
            Log.Console("Scores");
            Log.Console(Scores);

            String Sample = "♥0123456789♥ABBCCC DDDDEEEEEFFFFFF@GGGGGGG!HHHHHHHH.IIIIIIIII?JJJJJJJJJJ[KKKKKKKKKKK]LLLLLLLLLLLL  MMMMMMMMMMMMM{NNNNNNNNNNNNNN}OOOOOOOOOOOOOOO%PPPPPPPPPPPPPPPP~QQQQQQQQQQQQQQQQQ♥";

            Log.Console("Wrap Test");
            Log.Console("Printable = " + Sample);
            Log.Console("Readable = " + ASCII.Readable(Sample));
            Log.Console("AlphaNumeric = " + ASCII.AlphaNumeric(Sample));
            Log.Console("Alpha = " + ASCII.Alpha(Sample));
            Log.Console("Numeric = " + ASCII.Numeric(Sample));

            Log.Console("<STOP>");
        }
    }
}
