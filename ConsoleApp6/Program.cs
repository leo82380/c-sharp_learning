using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 변수들
            //정수형
            int ii;
            //실수형
            float ff;
            //정수, 실수 둘 다 되는 형(소숫점 표시)
            double dd;
            //논리형
            bool bb;
            #endregion
            #region 시프트 연산자
            ii = 8 >> 2;//오른쪽 시프트
            Console.WriteLine(ii);
            ii = ii << 2;//왼쪽 시프트
            Console.WriteLine(ii);
            #endregion
            #region 입력
            //string으로 입력받기
            Console.WriteLine("string 값을 입력하세요");
            string input = Console.ReadLine();
            //char로 입력받기
            Console.WriteLine("char값을 입력하세요");
            char charInput = char.Parse(Console.ReadLine());
            //int로 입력받기
            Console.WriteLine("int값을 입력하세요");
            int intInput = int.Parse(Console.ReadLine());
            //float로 입력받기
            Console.WriteLine("float 값을 입력하세요");
            float floatInput = float.Parse(Console.ReadLine());
            //double로 입력받기
            Console.WriteLine("double값을 입력하세요");
            double doubleInput = double.Parse(Console.ReadLine());
            #endregion

            #region 출력
            //+ 뒤의 input값들은 위에서 선언한 변수 이름
            //만약 다른 이름으로 선언했으면 그 이름으로 뒤에 붙이기
            
            //string 출력하기
            Console.WriteLine("string : " + input); 
            //char 출력하기
            Console.WriteLine("char : " + charInput);
            //int 출력하기
            Console.WriteLine("int : " + intInput);
            //float 출력하기
            Console.WriteLine("float : " + floatInput);
            //double 출력하기
            Console.WriteLine("double : " + doubleInput);
            #endregion

            #region 변수 포함해 출력 방법
            //1.
            Console.WriteLine("플러스 기호 붙이기 : " + intInput);
            //2.
            Console.WriteLine($"달러 붙이기 : {intInput}");
            //3.
            Console.WriteLine("뒤에 변수 이름 쓰기 : {0}", intInput);
            //변수만 출력
            Console.WriteLine(intInput);
            #endregion

            #region 형 변환
            //변수에 string값 넣기
            Console.WriteLine("숫자로 변환할 string값을 입력하세요");
            string inputString = Console.ReadLine();
            //string 값을 int 값으로 변환
            int stringToint = int.Parse(inputString);
            Console.WriteLine("int값으로 변환 값 : " + stringToint);
            //string 값을 float 값으로 변환
            float stringTofloat = float.Parse(inputString);
            Console.WriteLine("float값으로 변환 값 : " + stringTofloat);
            #endregion

            #region 예외처리
            //예외처리는 try와 catch로 함
            try//try 안에 있는거 실행 해보기
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a);
            }
            catch(FormatException e)//다른 형식 들어왔을 때
            {
                Console.WriteLine(e.Message);//에러 메세지 출력
                Console.WriteLine("다른 형식으로 입력됨. int값을 입력");
            }
            catch(OverflowException e)//오버플로우(값 초과 또는 미만)가 발생했을 때
            {
                Console.WriteLine(e.Message);//에러 메세지 출력
                Console.WriteLine("오버플로우 발생. int형에 맞는 값 입력");
            }
            #endregion

            #region 반복문
            //반복 횟수
            int aaa = int.Parse(Console.ReadLine());
            //for문
            for (int i = 0; i < aaa; i++)//i가 입력값보다 작을 때 반복
            {
                Console.WriteLine("for문 반복" + i);
            }
            Console.WriteLine("for문 끝");
            //while문
            int q = int.Parse(Console.ReadLine());
            while(q <= aaa) //q가 입력값보다 작거나 같을 때 반복
            {
                Console.WriteLine("while문 반복" + q);
                q++;
            }
            Console.WriteLine("while문 끝");
            #endregion

            #region do while문
            int dowhile = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("do");
                dowhile++;
            } while (dowhile <= 10);
            #endregion
        }
    }
}
