using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 입력
            //string으로 입력받기
            string input = Console.ReadLine();
            //char로 입력받기
            char charInput = char.Parse(Console.ReadLine());
            //int로 입력받기
            int intInput = int.Parse(Console.ReadLine());
            //float로 입력받기
            float floatInput = float.Parse(Console.ReadLine());
            //double로 입력받기
            double doubleInput = double.Parse(Console.ReadLine());
            #endregion
            #region 출력
            //string 출력하기
            Console.WriteLine("string : " + input);//+ 뒤의 input값들은 위에서 선언한 변수 이름 
            //char 출력하기
            Console.WriteLine("char : " + charInput);
            //int 출력하기
            Console.WriteLine("int : " + intInput);
            //float
        }
    }
}
