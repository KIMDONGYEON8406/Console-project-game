using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    internal class Program
    {

        //콘솔 커서 포지션
        static void Main(string[] args)
        {
            GameStart gameStart = new GameStart();//게임시작
            //Com com = new Com();//컴퓨터선언

            gameStart.startPage();

            GamePlay gamePlay = new GamePlay();

            gamePlay.Get();



            

            #region
            // 0 : 가위 ,   1 : 바위 :    2 : 보자기
            // 사용자에게는 총 3개의 목숨이 있다.
            // 무한으로 가위바위보가 시작되고  , 컴퓨터에게 패배할 시 목숨 하나가 사라진다
            // 마지막에는 사용자의 결과를 나타낸다


            //bool game = true; // 게임 진행상태
            //string[] life = { "♥", "♥", "♥", }; // 목숨 값 // char형은 왜 안먹히는지 물어보기
            //int win = 0; // 승리값
            //int lose = 0; // 패배값
            //ConsoleKeyInfo userKey; // 게임 시작 전 입력값 
            //Random rnd = new Random(); // 컴퓨터 설정을 위한 랜덤 함수

            //Console.WriteLine(" 반갑습니다 \n 가위바위보 게임에 참여하신 걸 환영합니다");
            //Console.WriteLine(" 게임을 시작하겠습니까 ?");
            //Console.WriteLine(" (Y / N) 키를 입력해주세요 ");

            //Console.WriteLine("------------------------------");
            //userKey = Console.ReadKey(); // 사용자에게 Y or N 키 받기

            //if (userKey.Key == ConsoleKey.Y)
            //{
            //    Console.Clear(); // 콘솔클리어
            //    Console.WriteLine(" 게임 START ");

            //    // 가위바위보 시작

            //    Console.WriteLine("0 : 가위 ,   1 : 바위 :    2 : 보자기");
            //    Console.WriteLine("가위바위보를 선택하세요. : ");


            //    while (game)
            //    {


            //        int user = int.Parse(Console.ReadLine()); // 사용자 입력값

            //        if (user < 0 || user > 2) // 사용자 입력값 유효한지 검사
            //        {
            //            Console.WriteLine("0~2번을 선택해주세요");
            //            Console.WriteLine(); // 줄바꿈
            //        }
            //        else
            //        {
            //            Console.WriteLine(); // 줄바꿈

            //            int com = rnd.Next(0, 3); // 컴퓨터 값

            //            int result = user - com; // 가위바위보 계산





            //            if (result == 0) // 무승부
            //            {
            //                Console.ForegroundColor = ConsoleColor.DarkGray;
            //                Console.WriteLine(" 무승부 입니다 ");
            //                Console.WriteLine(); // 줄바꿈
            //            }
            //            else if (result == 1 || result == 2) // 승리
            //            {
            //                Console.ForegroundColor = ConsoleColor.Blue;
            //                Console.WriteLine(" 승리 입니다 ");
            //                Console.WriteLine(); // 줄바꿈
            //                win++;
            //            }
            //            else // 패배
            //            {
            //                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //                Console.WriteLine(" 패배 입니다 ");
            //                Console.WriteLine(); // 줄바꿈
            //                lose++;
            //            }

            //            //결과물
            //            if (lose == 3)
            //            {
            //                Console.ForegroundColor = ConsoleColor.DarkYellow;
            //                Console.WriteLine(" Game Over");
            //                Console.WriteLine($"{win}번 승리로 게임이 종료 됩니다.");
            //                game = false;

            //            }
            //            else
            //            {
            //                Console.WriteLine($"{win}번째 승리중");

            //            }
           //                asd(lose, life);

        //            }
        //        }
        //    }
        //}

        //public static void asd(int i, string[] life)
        //{

        //    for (; i < life.Length; i++)
        //    {
        //        Console.Write(life[i]);
        //    }
        //    Console.WriteLine();
        }
        #endregion
    }
}



//switch (user) // 사용자
//{
//    case 0:
//        Console.WriteLine("가위");
//        break;
//    case 1:
//        Console.WriteLine("바위");
//        break;
//    case 2:
//        Console.WriteLine("보자기");
//        break;
//        switch (com) // 컴퓨터
//        {
//            case 0:
//                Console.WriteLine("가위");
//                break;
//            case 1:
//                Console.WriteLine("바위");
//                break;
//            case 2:
//                Console.WriteLine("보자기");
//                break;

//        }
//}
