using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //활용
            #region 랜덤 수를 이용한 로또번호 뽑기
            Random rd1 = new Random();

            for (int i = 0; i <= 6; i++)
            {
                int lotto = rd1.Next(1, 45);
                Console.WriteLine($"{i+1}번째 수 : {lotto}");
            }
            #endregion

            #region 입력한 수까지 짝수 또는 홀수만 출력하기
            try { 
            Console.WriteLine("짝수 출력 1번 홀수 출력 2번");
            int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("짝수만 출력합니다.");
                        Console.WriteLine("최대값을 입력하세요.");
                        int inp = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= inp; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("홀수만 출력합니다.");
                        Console.WriteLine("최대값을 입력하세요");
                        int inp2 = int.Parse(Console.ReadLine());
                        for (int i = 0; i <= inp2; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        break;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion

            #region 입력한 것 출력하기
            try
            {
                string stinput = Console.ReadLine();
                Console.WriteLine(stinput);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion


        }
    }
}
