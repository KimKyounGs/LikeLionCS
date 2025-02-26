﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Study4
{
    class Program
    {
        //1단계함수
        //반환형 함수이름 (매개변수)
        //{
        //}
        //1단계 기본형
        static void Loading()
        {

            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
        }

        //2단계
        //입력
        static void AttackFunction(int Attack)
        {
            Console.WriteLine("공격력은 : " + Attack);
        }


        //3단계
        //출력
        static int BaseAttack()
        {
            //기본공격력 10
            int attack = 10;

            return attack; //출력
        }


        static int Add()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            return num1 + num2; 
        }

        static int Length()
        {
            string str = Console.ReadLine();
            int len = 0;
            foreach(char c in str)
            {
                len++;
            }
            return len;
        }

        static int Max()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            else if (num3 > num2 && num3 > num1)
            {
                return num3;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            Length();
            //int[] iArray = new int[25];


            //for (int i = 0; i < 25; i++)
            //{
            //    iArray[i] = i + 1;
            //}



            //Random rand = new Random();
            ////셔플
            //for (int i = 0; i < 100; i++)
            //{
            //    int iA = rand.Next(0, 25);
            //    int iB = rand.Next(0, 25);
            //    int iT = 0;


            //    iT = iArray[iA];
            //    iArray[iA] = iArray[iB];
            //    iArray[iB] = iT;
            //}

            //int input = 0;


            //while (true)
            //{
            //    Console.Clear();

            //    //빙고판
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {

            //            if (iArray[i * 5 + j] == 0)  //0일경우 체크
            //            {
            //                Console.Write(" * ");
            //            }
            //            else
            //            {
            //                Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }

            //    Console.WriteLine("숫자를 입력하세요: ");
            //    input = int.Parse(Console.ReadLine());

            //    for (int i = 0; i < 25; i++)
            //    {
            //        if (iArray[i] == input)
            //        {
            //            iArray[i] = 0;
            //            break;
            //        }
            //    }
            //}




            //int[] iArray = new int[25];


            //for (int i = 0; i < 25; i++)
            //{
            //    iArray[i] = i + 1;
            //}



            //Random rand = new Random();
            ////셔플
            //for (int i = 0; i < 100; i++)
            //{
            //    int iA = rand.Next(0, 25);
            //    int iB = rand.Next(0, 25);
            //    int iT = 0;


            //    iT = iArray[iA];
            //    iArray[iA] = iArray[iB];
            //    iArray[iB] = iT;
            //}

            //int input = 0;

            //int iCount = 0;
            //int iBingo = 0;
            //while (true)
            //{
            //    Console.Clear();

            //    //빙고판
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {

            //            if (iArray[i * 5 + j] == 0)  //0일경우 체크
            //            {
            //                Console.Write(" * ");
            //            }
            //            else
            //            {
            //                Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("빙고 숫자 : " + iBingo);
            //    Console.WriteLine("숫자를 입력하세요: ");
            //    input = int.Parse(Console.ReadLine());
            //    iBingo = 0;
            //    for (int i = 0; i < 25; i++)
            //    {
            //        if (iArray[i] == input)
            //        {
            //            iArray[i] = 0;
            //            break;
            //        }
            //    }


            //    //빙고 체크 로직
            //    //가로 체크
            //    for (int i = 0; i < 5; ++i)
            //    {
            //        for (int j = 0; j < 5; ++j)
            //        {
            //            if (iArray[i * 5 + j] == 0)
            //            {
            //                ++iCount;
            //            }

            //            if (iCount == 5)
            //            {
            //                ++iBingo;
            //            }
            //        }
            //        iCount = 0;
            //    }

            //    //세로 체크
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (iArray[i + 5 * j] == 0)
            //            {
            //                ++iCount;
            //            }

            //            if (iCount == 5)
            //            {
            //                ++iBingo;
            //            }
            //        }
            //        iCount = 0;
            //    }



            //    //대각선 오른쪽체크
            //    //00 01 02 03 04
            //    //05 06 07 08 09
            //    //10 11 12 13 14
            //    //15 16 17 18 19
            //    //20 21 22 23 24

            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (iArray[i * 4 + 4] == 0)
            //        {
            //            ++iCount;
            //        }

            //        if (iCount == 5)
            //        {
            //            ++iBingo;
            //        }
            //    }
            //    iCount = 0;







            //    //대각선 왼쪽체크
            //    //00 01 02 03 04
            //    //05 06 07 08 09
            //    //10 11 12 13 14
            //    //15 16 17 18 19
            //    //20 21 22 23 24
            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (iArray[i * 6] == 0)
            //        {
            //            ++iCount;
            //        }

            //        if (iCount == 5)
            //        {
            //            ++iBingo;
            //        }
            //    }
            //    iCount = 0;


            //    if (iBingo >= 5)
            //    {
            //        Console.WriteLine("빙고 성공");
            //        break;
            //    }
            //}



            //int[] iArray = new int[25];


            //for(int i =0; i<25; i++)
            //{
            //    iArray[i] = i + 1; 
            //}



            //Random rand = new Random();
            ////셔플
            //for(int i =0; i<100; i++)
            //{
            //    int iA = rand.Next(0, 25);
            //    int iB = rand.Next(0, 25);
            //    int iT = 0;


            //    iT = iArray[iA];
            //    iArray[iA] = iArray[iB];
            //    iArray[iB] = iT;
            //}

            //int input = 0;

            //int iCount = 0;
            //int iBingo = 0;
            //while (true)
            //{
            //    Console.Clear();

            //    //빙고판
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {

            //            if (iArray[i * 5 + j] == 0)  //0일경우 체크
            //            {
            //                Console.Write(" * ");
            //            }
            //            else
            //            {
            //                Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("빙고 숫자 : " + iBingo);
            //    Console.WriteLine("숫자를 입력하세요: ");
            //    input = int.Parse(Console.ReadLine());
            //    iBingo = 0;
            //    for (int i =0; i<25; i++)
            //    {
            //        if (iArray[i] == input)
            //        {
            //            iArray[i] = 0;
            //            break;
            //        }
            //    }


            //    //빙고 체크 로직
            //    //가로 체크
            //    for (int i = 0; i <5; ++i)
            //    {
            //        for(int j=0; j<5; ++j)
            //        {
            //            if (iArray[i *5 +j] ==  0)
            //            {
            //                ++iCount;
            //            }

            //            if(iCount == 5)
            //            {
            //                ++iBingo;
            //            }
            //        }
            //        iCount = 0;
            //    }

            //    //세로 체크
            //    for(int i=0; i<5; i++)
            //    {
            //        for(int j=0; j<5; j++)
            //        {
            //            if (iArray[i+5*j] == 0)
            //            {
            //                ++iCount;
            //            }

            //            if(iCount == 5)
            //            {
            //                ++iBingo;
            //            }
            //        }
            //        iCount = 0;
            //    }



            //    //대각선 오른쪽체크
            //    //00 01 02 03 04
            //    //05 06 07 08 09
            //    //10 11 12 13 14
            //    //15 16 17 18 19
            //    //20 21 22 23 24

            //    for(int i=0; i< 5; i++)
            //    {
            //        if (iArray[i*4+4] == 0)
            //        {
            //            ++iCount;
            //        }

            //        if(iCount == 5)
            //        {
            //            ++iBingo;
            //        }
            //    }
            //    iCount = 0;







            //    //대각선 왼쪽체크
            //    //00 01 02 03 04
            //    //05 06 07 08 09
            //    //10 11 12 13 14
            //    //15 16 17 18 19
            //    //20 21 22 23 24
            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (iArray[i *6] == 0)
            //        {
            //            ++iCount;
            //        }

            //        if (iCount == 5)
            //        {
            //            ++iBingo;
            //        }
            //    }
            //    iCount = 0;


            //    if(iBingo >= 5)
            //    {
            //        Console.WriteLine("빙고 성공");
            //        break;
            //    }
            //}




            //int[,] board = new int[5, 5]; //5x5 빙고판
            //bool[,] marked = new bool[5, 5]; //선택된 숫자 체크

            //int bingoCount = 0;

            //Random random = new Random();

            ////빙고판 초기화
            //int[] numbers = new int[25];

            //for (int i = 0; i < 25; i++)
            //    numbers[i] = i + 1;

            ////랜덤 섞기(Fisher-Yates Shuffle)
            //for (int i = 0; i < 100; i++)
            //{
            //    int a = random.Next(25);
            //    int b = random.Next(25);

            //    // C#의 튜플(Tuple) 문법을 활용하여 두 변수의 값을 교환(Swap)하는 방법
            //    (numbers[a], numbers[b]) = (numbers[b], numbers[a]);

            //}


            ////2차원 배열로 변환
            //int index = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        board[i, j] = numbers[index++];
            //    }
            //}

            ////게임시작
            //while (bingoCount < 5)
            //{
            //    Console.Clear();

            //    //빙고판 출력
            //    Console.WriteLine("현재 빙고판");


            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (marked[i, j])
            //                Console.Write(" X ");
            //            else
            //                Console.Write($"{board[i, j],2} ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine($"현재 빙고 개수 : {bingoCount}");
            //    Console.Write("숫자를 입력하세요 (1~25) : ");
            //    int number = int.Parse(Console.ReadLine());

            //    bool found = false;
            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            if (board[i, j] == number)
            //            {
            //                marked[i, j] = true; //숫자를 X로 변경
            //                found = true;
            //                break;
            //            }
            //        }
            //        if (found)
            //            break;
            //    }

            //    //빙고 개수 체크
            //    bingoCount = 0;

            //    //가로체크
            //    for (int i = 0; i < 5; i++)
            //    {
            //        bool rowBingo = true;
            //        for (int j = 0; j < 5; j++)
            //            if (!marked[i, j]) rowBingo = false;

            //        if (rowBingo) bingoCount++;
            //    }


            //    //세로체크
            //    for (int j = 0; j < 5; j++)
            //    {
            //        bool colBingo = true;

            //        for (int i = 0; i < 5; i++)
            //            if (!marked[i, j]) colBingo = false;

            //        if (colBingo) bingoCount++;
            //    }


            //    //대각선 체크 (왼쪽위 ->오른쪽 아래)

            //    bool diag1Bingo = true;

            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (!marked[i, i])
            //            diag1Bingo = false;
            //    }
            //    if (diag1Bingo)
            //        bingoCount++;


            //    //대각선 오른쪽위 ->왼쪽아래
            //    bool diag2Bingo = true;

            //    for (int i = 0; i < 5; i++)
            //        if (!marked[i, 4 - i]) diag2Bingo = false;


            //    if (diag2Bingo) bingoCount++;

            //}

            //Console.WriteLine("빙고 5개 완성! 게임종료");


            //string[] fruits = { "사과", "바나나", "체리" };
            ////반복문
            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}




            //// 배열 문제 1
            //int[] arr = new int[5] { 10, 20, 30, 40, 50 };

            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}



            //// 배열 문제 2
            //string input = Console.ReadLine();
            //int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            //int sum = 0;
            //foreach(int num in numbers)
            //{
            //    sum += num;
            //}
            //Console.WriteLine(sum);



            //// 배열 문제 3
            //string input = Console.ReadLine();
            //int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            //int max = 0;
            //foreach (int num in numbers)
            //{
            //    if (max < num)
            //    {
            //        max = num;
            //    }
            //}
            //Console.WriteLine(max);



            //// 반복문 문제 1
            //for (int i = 1; i <= 10; i ++)
            //{
            //    Console.Write(i + " ");
            //}




            //// 반복문 문제 2
            //int num = 1;
            //while(num <= 10)
            //{
            //    if (num % 2 == 0)
            //    {
            //        Console.Write(num + " ");
            //    }
            //    num++;
            //}




            //// 반복문 문제 3
            //int[] nums = new int[5] { 1, 2, 3, 4, 5 };

            //foreach(int num in nums)
            //{
            //    Console.Write(num + " ");
            //}
        }
    }
}
