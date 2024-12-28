using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    internal class GamePlay
    {
        bool game = true; // 게임 진행상태
        string[] gift = new string[] { "키보드,마우스", "꽝"}; // 상품목록
        ConsoleKeyInfo userKey; // 게임 시직 Y/N 여부
        ConsoleKeyInfo enter; // Y/N 클릭 후 확인 후 엔터
        Random rnd = new Random(); // 컴퓨터 설정을 위한 랜덤 함수

        public void Get()
        {

            while (true)
            {
                userKey = Console.ReadKey(); // 사용자에게 Y or N 키 받기
                enter = Console.ReadKey(); //   다음 스텝을 넘어가기 위한 키

                if (userKey.Key == ConsoleKey.Y && enter.Key == ConsoleKey.Enter)
                {
                    Console.Clear(); // 콘솔클리어
                    Console.WriteLine(" 게임 START ");

                    // 가위바위보 시작
                    Player player = new Player(3);   // player    목숨값 3
                    Player computer = new Player(3);   // computer  목숨값 3
                    Console.WriteLine();

                    while (game)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("1 : 가위    2 : 바위     3 : 보자기");
                        Console.WriteLine(" ［가위 바위 보자기 를 선택하세요 ］ ");
                        if (int.TryParse(Console.ReadLine(), out int user))
                        {
                            if (user < 1 || user > 3) // 사용자 입력값 유효한지 검사
                            {
                                Console.WriteLine("1~3번을 선택해주세요");
                                Console.WriteLine(); // 줄바꿈
                            }
                            else
                            {
                                Console.WriteLine(); // 줄바꿈
                                int com = rnd.Next(1, 4); // 컴퓨터 값

                                player.SetState(user); // 사용자 가위바위보 세팅
                                computer.SetState(com); // 컴퓨터 가위바위보 세팅

                                Player.Result result = Player.GetResult(player.state, computer.state);

                                if (result == Player.Result.Victory)
                                {                                                // player가 승리일 때 computer 생명값  - 
                                    computer.MinusLife();
                                }
                                if (result == Player.Result.Defeat)
                                {                                                // player가 패배일 때 player 생명값  -
                                    player.MinusLife();

                                }

                                Console.WriteLine();
                                Console.WriteLine();

                                Console.ResetColor();
                                Console.WriteLine("--------------------------");
                                Console.Write(" 플레이어 생명 : ");     // player 생명 
                                player.Print();
                                Console.WriteLine();
                                Console.Write(" 컴퓨터 생명 : ");   // computer 생명
                                computer.Print();
                                Console.WriteLine();

                                Console.WriteLine();
                                Console.WriteLine();

                                //int result = user - com; // 가위바위보 계산

                                if (result == Player.Result.Draw) // 무승부
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine(" ｜ Draw ｜ ");
                                }
                                else if (result == Player.Result.Victory) // 승리
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine(" ｜ Win ｜ ");
                                }
                                else // 패배
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("  ｜ Lose ｜ ");
                                }

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("--------------------------"); // 줄바꿈
                                Console.WriteLine();
                                Console.WriteLine();

                                if (player.life == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("　　Computer Win　　　");
                                    Console.WriteLine("　　　  패배         　");
                                    Console.WriteLine();
                                    Console.WriteLine($"        {gift[1]} !     ");
                                    game = false;
                                }                                                    // 승자판별 및 게임종료
                                else if (computer.life == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("　　　 Player Win　　　");
                                    Console.WriteLine("　　　    승리         ");
                                    Console.WriteLine();
                                    Console.WriteLine($"  상품  {gift[0]} 획득  ");
                                    game = false;
                                }
                            }
                            // 사용자 입력값
                        }
                        else
                        {
                            Console.WriteLine("다시 입력해주세요");
                        }
                    }

                }

                else if(userKey.Key == ConsoleKey.N && enter.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("프로그램이 종료됩니다");
                    Environment.Exit(0);  // 프로그램 종료 
                }
                else
                {
                    Console.WriteLine("다시 입력해주세요");
                }
            }
            // com 이라는 클래스
            // player 라는 클래스

            // 플레이어는 목숨을 들고있음

        }

          // public static void Life(int i, string[] life)
          //{

          //  for (; i < life.Length; i++)
          //  {
          //      Console.Write(life[i]);
          //  }
          //  Console.WriteLine();
        
          //}
        
        
    }
}
