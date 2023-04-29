using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 변수선언
            //정수형(예: 1, 2, 3...)
            int ii;
            //실수형(예: 1.2, 4.5, 5.245...)
            float ff;
            //정수, 실수 둘 다 되는 형(소숫점 표시)(예: 1, 2, 3, 2.4, 5.32...)
            double dd;
            //논리형(예: true, false)
            bool bb;
            #endregion

            #region 시프트 연산자
            ii = int.Parse(Console.ReadLine());
            ii = ii >> 2;//오른쪽 시프트
            Console.WriteLine(ii);
            ii = ii << 2;//왼쪽 시프트
            Console.WriteLine(ii);
            #endregion

            #region 비트 연산자
            Console.WriteLine("연산자를 이용해 바꿀 수 2개를 입력하세요");
            int ab = int.Parse(Console.ReadLine());
            int ba = int.Parse(Console.ReadLine());
            int aba = ab & ba;
            Console.WriteLine(aba);
            int aba2 = ab | ba;
            Console.WriteLine(aba2);
            int aba3 = ab ^ ba;
            Console.WriteLine(aba3);
            int aba4 = ~ab;
            Console.WriteLine(aba4);
            #endregion

            #region 논리 연산자
            bool x = true;
            bool y = false;
            //&&(AND)연산자는 둘 다 true면 true를 반환
            bool result1 = x && y;
            //||(OR)연산자는 하나라도 true면 true를 반환
            bool result2 = x || y;
            //!(NOT)연산자는 값을 반대로 출력
            bool result3 = !x;
            Console.WriteLine(result1);// true && false = false
            Console.WriteLine(result2);// true || false = true
            Console.WriteLine(result3);// !true = false
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
            Console.WriteLine("string을 int형으로 변환할 값을 입력하세요");
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
                Console.WriteLine("정수를 입혁하세요");
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
                Console.WriteLine("오버플로우 발생. int형 범위 안에 있는 값을 입력");
            }
            #endregion

            #region 반복문

            #region for문
            //반복 횟수
            Console.WriteLine("몇번 반복합니까?(for)");
            int aaa = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < aaa; i++)//i가 입력값보다 작을 때 반복
            {
                Console.WriteLine("for문 반복 : " + i);
            }
            Console.WriteLine("for문 끝");
            #endregion

            #region while문
            int q = 0;
            Console.WriteLine("몇번 반복합니까?(while)");
            int inp = int.Parse(Console.ReadLine());
            while(q <= inp) //q가 입력값보다 작거나 같을 때 반복
            {
                Console.WriteLine("while문 반복 : " + q);
                q++;
            }
            Console.WriteLine("while문 끝");
            #endregion

            #region do while문
            Console.WriteLine("몇번 반복합니까?(do while)");
            int dowhile = int.Parse(Console.ReadLine());
            int asdf = 0;
            do//while문의 조건식이 참일 때 do안에 있는 걸 반복
            {
                Console.WriteLine("do " + asdf);
                asdf++;
            } while (asdf <= dowhile);
            #endregion

            #region 무한반복
            int fdsa = 30;
            int dsa = 0;
            while (true)
            {
                Console.Write(dsa);
                dsa++;
                if(dsa >= fdsa)
                {
                    break;
                }
            }
            #endregion

            #endregion

            #region switch case문
            int switchCase = int.Parse(Console.ReadLine());
            switch (switchCase)
            {
                case 1://1을 입력 받았을때
                    Console.WriteLine("1");//1을 출력
                    break;//switch case문은 break가 있어야한다
                case 2:
                    Console.WriteLine("2");
                    break;
                default://1, 2 말고 다른 값을 입력 받았을 때
                    Console.WriteLine("나머지");//나머지 출력
                    break;
            }
            #endregion

            #region 띄어쓰기를 포함해 입력받기
            Console.WriteLine("띄어쓰기를 포함해 입력받을 값을 입력하세요");
            string[] inpu = Console.ReadLine().Split();
            for (int i = 0; i < inpu.Length; i++)
            {
                Console.WriteLine(inpu[i]);
            }
            #endregion

            #region 삼항연산자
            Console.WriteLine("비교할 첫번째 수를 입력하세요 :");
            int inp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("비교할 두번째 수를 입력하세요 :");
            int inp2 = int.Parse(Console.ReadLine());
            //inp1과 inp2를 비교
            //inp1이 inp2보다 크면 inp1을 in3에 넣고 아니면 inp2를 in3에 넣는다.
            string in3 = inp1 > inp2 ? "첫번째 값이 두번째 값보다 큽니다\n값 : " + inp1 : "첫번째 값이 두번째 값보다 작습니다\n값 : " + inp2;
            Console.WriteLine(in3);//그리고 in3을 출력한다.
            #endregion
        }
    }
}
