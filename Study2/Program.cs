using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("2진수를 입력하세요: ");
            // string binaryInput = Console.ReadLine();
            // int decimalValue = Convert.ToInt32(binaryInput, 2); // 2진수 -> 10진수 변환

            // // 정수를 이진수로 변환
            // string binaryOutput = Convert.ToString(decimalValue, 2); // 10진수 -> 2진수

            // Console.WriteLine($"입력한 이진수 : {binaryInput}");
            // Console.WriteLine($"1진수로 변환 : {decimalValue}");
            // Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");




            // var name = "Alice";
            // var age = 25;
            // var isStudent = true; 

            // Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 여부 : {isStudent}");





            // int defaultInt = default;
            // string defaultString = default;
            // bool defaultBool = default;

            // Console.WriteLine($"정수 기본값: {defaultInt}");
            // Console.WriteLine($"문자열 기본값: {defaultString}");
            // Console.WriteLine($"논리값 기본값: {defaultBool}");





            // int a = 5, b = 3;

            // int sum = 0;

            // sum = a + b; // 산술 연산자 사용
            // Console.WriteLine($"합 : {sum}");

            // sum = a - b; 
            // Console.WriteLine($"합 : {sum}");
            // sum = a * b;
            // Console.WriteLine($"합 : {sum}");
            // sum = a / b;
            // Console.WriteLine($"합 : {sum}");

            // int c = 0, d = 0;
            // c = 2;
            // d = 5;
            // sum = d % c;
            // Console.WriteLine(sum);

            // int number = 7;
            // int sum = 0;
            // sum = number % 2;
            // Console.WriteLine("짝수 홀수 판별 " + sum);

            // int a = 5;
            // int b = 5;

            // // 관계형 연산자
            // bool isEqual = (a == b);

            // Console.WriteLine("같은가? " + isEqual);





            // int number = 5;
            // bool flag = true;

            // Console.WriteLine(+number); // 양수 출력
            // Console.WriteLine(-number); // 음수 출력
            // Console.WriteLine(!flag); // 논리 부정 






            // 비트 반전
            // 10 -> 1010
            //    -> 0101

            // int num = 10;
            // int result = ~num;

            // Console.WriteLine("원래 값 : " + num);
            // Console.WriteLine("~ 연산자 적용 후 : " + result);





            // double pi = 3.14;
            // int intergerPi = (int)pi; // 실수형 -> 정수형로 번환
            // Console.WriteLine(intergerPi);






            // int iKor = 90;
            // int iEng = 75;
            // int iMath = 58;

            // int sum = 0;
            // float average = 0.0f;

            // sum = iKor + iEng + iMath;

            // average = (float)sum / 3;

            // Console.WriteLine("총점 : " + sum);
            // Console.WriteLine("평균 : " + average);




            // int a = 10, b = 3;

            // Console.WriteLine(a + b);
            // Console.WriteLine(a - b);
            // Console.WriteLine(a * b);
            // Console.WriteLine(a / b);
            // Console.WriteLine(a % b); 



            // string firstName = "Alice";
            // string lastName = "Smith";

            // Console.WriteLine(firstName + " " + lastName); //출력





            // // 문제 1
            // int iKor = int.Parse(Console.ReadLine());
            // int iEng = int.Parse(Console.ReadLine());
            // int iMath = int.Parse(Console.ReadLine());

            // int sum = 0;
            // float average = 0.0f;

            // sum = iKor + iEng + iMath;

            // average = (float)sum / 3;

            // Console.WriteLine("총점 : " + sum);
            // Console.WriteLine("퍙균 : " + average.ToString("F2"));

            // // 문제 2
            // int num = int.Parse(Console.ReadLine());
            // int result = ~num;

            // Console.WriteLine("원래 값 : " + num);
            // Console.WriteLine("~ 연산자 적용 후 : " + result);





            //int b = 3;

            ////전위 ++b , 후위 b++

            //Console.WriteLine("b의 값은 : " + (b++));






            //int x = 5, y = 10;


            //Console.WriteLine(x == y);  // false
            //Console.WriteLine(x != y);  // true
            //Console.WriteLine(x < y);   // true
            //Console.WriteLine(x > y);   // false
            //Console.WriteLine(x >= y);  // false
            //Console.WriteLine(x <= y);  //true  





            //int value = 4;  //0100

            //Console.WriteLine(value << 1); //왼쪽이동 : 8 (1000)
            //Console.WriteLine(value >> 1); //오른쪽이동: 2 (0010)






            //int a = 10, b = 20;

            //int max;

            //max = (a < b) ? a : b; //삼항 연산자

            //Console.WriteLine(max);

            //int key = 1;

            //string str;
            //str = (key == 2) ? "문이열렸습니다." : "문을 못열었습니다.";

            //Console.WriteLine(str);







            //int score = 60;

            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B 학점");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C 학점");
            //}
            //else
            //{
            //    Console.WriteLine("F 학점");
            //}



            //// 문제

            //Console.Write("가지고 있는 소지금을 입력하세요 : ");
            //int gold = int.Parse(Console.ReadLine());
            //Console.Write("캐릭터 이름 : ");
            //string name = Console.ReadLine();
            //int add = 0;

            //if (gold >= 501)
            //{
            //    Console.WriteLine("유령검을 구매했습니다.");
            //    add = 6;
            //}
            //else if (gold >= 401)
            //{
            //    Console.WriteLine("엑스칼리버을 구매했습니다.");
            //    add = 5;
            //}
            //else if (gold >= 301)
            //{
            //    Console.WriteLine("집판검을 구매했습니다.");
            //    add = 4;
            //}
            //else if (gold >= 201)
            //{
            //    Console.WriteLine("진은검을 구매했습니다.");
            //    add = 3;
            //}
            //else if (gold >= 101)
            //{
            //    Console.WriteLine("카타나을 구매했습니다.");
            //    add = 2;
            //}
            //else
            //{
            //    Console.WriteLine("무한의대검을 구매했습니다.");
            //    add = 1;
            //}


            //Console.WriteLine("캐릭터 이름 : "+ name);
            //Console.WriteLine("공격력 : 100 + ", + add);




            // 문제1
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("최대값 : " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("최대값 : " + b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("최대값 : " + c);
            }


            // 문제2
            int score = int.Parse(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }


            // 문제3
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operate = (char)Console.Read();

            if (operate == '+')
            {
                Console.WriteLine($"{num1} {operate} {num2} = {num1 + num2}");
            }
            else if (operate == '-')
            {
                Console.WriteLine($"{num1} {operate} {num2} = {num1 - num2}");
            }
            else if (operate == '*')
            {
                Console.WriteLine($"{num1} {operate} {num2} = {num1 * num2}");
            }
            else if (operate == '/')
            {
                Console.WriteLine($"{num1} {operate} {num2} = {num1 / num2}");
            }
            else if (operate == '%')
            {
                Console.WriteLine($"{num1} {operate} {num2} = {num1 % num2}");
            }
            else
            {
                Console.WriteLine("잘못 입력 하였습니다.");
            }
        }
    }
}
