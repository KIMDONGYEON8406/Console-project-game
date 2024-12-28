using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
    class Player
    {
        public enum Result // 결과값
        {
            Victory,
            Defeat,
            Draw
        }

        public enum State  // 가위바위보 상태값
        {
            Scissor = 1,
            Rock = 2,
            Paper = 3,
        }

        public int life  // 목숨값
        {
            get;
            private set;
        }

        public State state
        {
            get;
            private set;
        }

        public Player(int num)
        {
            life = num;
        }

        public void SetState(int num)
        {
            state = (State)num;
        }

        public void MinusLife()
        {
            life--;
        }

        public void Print()
        {
            
            for(int i= 0; i < life; i++)
            {
                Console.Write("♥");
            }
            
        }

        public static Result GetResult(State player, State computer) // 가위바위보 결과값
        {
            switch(player)
            {
                case State.Rock:
                    if(computer == State.Scissor)
                    {
                        return Result.Victory;
                    }
                    else if(computer == State.Paper)
                    {
                        return Result.Defeat;
                    }
                    break;
                case State.Scissor:
                    if (computer == State.Paper)
                    {
                        return Result.Victory;
                    }
                    else if (computer == State.Rock)
                    {
                        return Result.Defeat;
                    }
                    break;
                case State.Paper:
                    if (computer == State.Rock)
                    {
                        return Result.Victory;
                    }
                    else if (computer == State.Scissor)
                    {
                        return Result.Defeat;
                    }
                    break;
            }
        
            return Result.Draw;
        }
    }
}