using System;

namespace oef_les3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cow =
@$"
         (__)   ┌──────....
         (oo)  <│ {Environment.UserName}
  /-------\/    └──────....
 / |     ||
*  ||----||
   ~~    ~~ ";

            Console.WriteLine(cow);

            System.Threading.Thread.Sleep(1000);

            Console.SetCursorPosition(10, 2);
            Console.Write("-");
            Console.SetCursorPosition(10, 10);

            Console.Beep(659, 125);
            Console.Beep(659, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 125);
            System.Threading.Thread.Sleep(167);
            Console.Beep(523, 125);
            Console.Beep(659, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(784, 125);
            System.Threading.Thread.Sleep(375);
            Console.Beep(392, 125);
            System.Threading.Thread.Sleep(375);
            Console.Beep(523, 125);
            System.Threading.Thread.Sleep(250);
            Console.Beep(392, 125);
            System.Threading.Thread.Sleep(250);
            Console.Beep(330, 125);
            System.Threading.Thread.Sleep(250);
            Console.Beep(440, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(494, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(466, 125);
            System.Threading.Thread.Sleep(42);
            Console.Beep(440, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(392, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(784, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(880, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(784, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(523, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(523, 125);
            System.Threading.Thread.Sleep(250);
            Console.Beep(392, 125);
            System.Threading.Thread.Sleep(250);
            Console.Beep(330, 125);
            System.Threading.Thread.Sleep(250);
            Console.Beep(440, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(494, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(466, 125);
            System.Threading.Thread.Sleep(42);
            Console.Beep(440, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(392, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(784, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(880, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(784, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(523, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            System.Threading.Thread.Sleep(375);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            System.Threading.Thread.Sleep(42);
            Console.Beep(622, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 125);
            System.Threading.Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            System.Threading.Thread.Sleep(250);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            System.Threading.Thread.Sleep(42);
            Console.Beep(622, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 125);
            System.Threading.Thread.Sleep(167);
            Console.Beep(698, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(698, 125);
            System.Threading.Thread.Sleep(625);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            System.Threading.Thread.Sleep(42);
            Console.Beep(622, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 125);
            System.Threading.Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            System.Threading.Thread.Sleep(250);
            Console.Beep(622, 125);
            System.Threading.Thread.Sleep(250);
            Console.Beep(587, 125);
            System.Threading.Thread.Sleep(250);
            Console.Beep(523, 125);
            System.Threading.Thread.Sleep(1125);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            System.Threading.Thread.Sleep(42);
            Console.Beep(622, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 125);
            System.Threading.Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            System.Threading.Thread.Sleep(250);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            System.Threading.Thread.Sleep(42);
            Console.Beep(622, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 125);
            System.Threading.Thread.Sleep(167);
            Console.Beep(698, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(698, 125);
            System.Threading.Thread.Sleep(625);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            System.Threading.Thread.Sleep(42);
            Console.Beep(622, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(659, 125);
            System.Threading.Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            System.Threading.Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            System.Threading.Thread.Sleep(250);
            Console.Beep(622, 125);
            System.Threading.Thread.Sleep(250);
            Console.Beep(587, 125);
            System.Threading.Thread.Sleep(250);
            Console.Beep(523, 125);
        }
    }
}
