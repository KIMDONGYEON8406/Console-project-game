using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    internal class GameStart
    {
        public void startPage()
        {

            Console.WriteLine(" 반갑습니다 \n 가위바위보 게임에 참여하신 걸 환영합니다");
          
            Console.WriteLine("  승리를 통해 상품을 얻어 가세요 ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("  1 : 승리 시 키보드 마우스 증정    "); 
            Console.WriteLine("  2 : 패배 시 꽝    ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" 게임을 시작하겠습니까 ?");
            Console.WriteLine(" (Y / N) 키를 입력 후 Enter 키를 눌러주세요 ");


            //while (true)
            //{
            //    switch (Console.ReadKey(true).Key)
            //    {
            //        case ConsoleKey.A:
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.SetCursorPosition(3, 3);
            //            Console.WriteLine(Console.CursorLeft);
            //            break;
            //        case ConsoleKey.D:
            //            Console.SetCursorPosition(7, 3);
            //            Console.WriteLine(Console.CursorLeft);
            //            break;

                    
            //    }
            ////}


        }
    }
}
