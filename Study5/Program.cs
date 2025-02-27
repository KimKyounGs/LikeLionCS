using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Study5
{
    class Program
    {
        //C# 구조체 
        // 클래스와 비슷하지만 , 값 타입(Value Type)이며 가볍고 빠름
        // 주로 간단한 데이터 묶음을 만들때 사용

        struct Point
        {
            //public 어디서든 사용가능하게 권한
            //private 나만 사용할려고 하는 키워드
            public int X;
            public int Y;

            public void Print()
            {
                Console.WriteLine($"좌표 : {X} , {Y}");
            }
        }

        struct Rectangle
        {
            public int Width;
            public int Height;

            public int GetArea() => Width * Height;
        }

        struct Student
        {
            public string Name;  //학생 이름
            public int iKor;     //국어
            public int iEng;     //영어
            public int iMath;    //수학

            //학생 정보를 출력하는 함수
            public void Print()
            {
                Console.WriteLine($"{Name,-3} {iKor,5} {iEng,7}{iMath,8}");
            }
        }


        struct Item
        {
            //최대 아이템 개수(배열 크기)
            const int MAX_ITEMS = 10;
            public int curItemCnt;

            //아이템 배열 (이름 저장)
            public string[] itemNames;
            public int[] itemCounts;
            

            public void Initialize()
            {
                itemNames = new string[MAX_ITEMS];
                itemCounts = new int[MAX_ITEMS];
                curItemCnt = 0;
            }
            //아이템 추가 함수
            public void AddItem(string name, int count)
            {
                if (curItemCnt < MAX_ITEMS)
                {
                    for (int i = 0; i < curItemCnt; i++)
                    {
                        if (itemNames[i] == name)  //이미 있는 아이템이면 개수 증가
                        {
                            itemCounts[i] += count;
                            return;
                        }
                    }

                    //빈 슬롯에 새로운 아이템 추가
                    for (int i = 0; i < MAX_ITEMS; i++)
                    {
                        if (itemNames[i] == null)
                        {
                            itemNames[i] = name;
                            itemCounts[i] = count;
                            curItemCnt++;
                            return;
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("인벤토리가 가득 찼습니다.");
                }


            }

            //아이템 제거 함수
            public void RemoveItem(string name, int count)
            {
                for (int i = 0; i < curItemCnt; i++)
                {
                    if (itemNames[i] == name) //이름하고 같은지
                    {
                        if (itemCounts[i] >= count) //개수가 충분하면 차감
                        {
                            itemCounts[i] -= count;
                            if (itemCounts[i] == 0) //개수가 0이면 삭제
                            {
                                itemNames[i] = null;
                            }
                            return;
                        }
                        else
                        {
                            Console.WriteLine("아이템 개수가 부족합니다!");
                            return;
                        }
                    }
                }

                Console.WriteLine("아이템을 찾을 수 없습니다!");

            }


            //인벤토리 출력 함수
            public void ShowInventory()
            {
                Console.WriteLine("현재 인벤토리 : ");

                if (curItemCnt > 0)
                {
                    for (int i = 0; i < curItemCnt; i++)
                    {
                        if (itemNames[i] != null)
                        {
                            Console.WriteLine($"{itemNames[i]} (x{itemCounts[i]})");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("인벤토리가 비어 있습니다.");
                }
            }
        }

        struct ShootingGame
        {
            string[] player;
            int playerX;
            int playerY;
            public void Initialize()
            {
                player = new string[]
                {
                "->",
                ">>>",
                "->",
                }; //배열 문자열로 그리기

                playerX = 0;
                playerY = 12;
            }

            public void Start()
            {
                ConsoleKeyInfo keyInfo;

                Console.CursorVisible = false;

                //시간 1초루프
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                long prevSecond = stopwatch.ElapsedMilliseconds; // 1 /1000    1000일때 1초

                while (true)
                {

                    long currentSecond = stopwatch.ElapsedMilliseconds; //현재시간 가져오기

                    // Console.WriteLine("1초루프");


                    if (currentSecond - prevSecond >= 100)
                    {

                        Console.Clear();

                        if (Console.KeyAvailable) //키가 눌렸을때 true
                        {
                            keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력 X)
                                                             //방향키 입력에 따른 좌표 변경
                            switch (keyInfo.Key)
                            {
                                case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                                case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 1) playerY++; break;
                                case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                                case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
                                case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                                case ConsoleKey.Escape: return; //ESC키로 종료 

                            }

                        }

                        for (int i = 0; i < player.Length; i++)
                        {
                            //콘솔좌표 설정 플레이어X 플레이어Y
                            Console.SetCursorPosition(playerX, playerY + i);
                            //문자열배열 출력
                            Console.WriteLine(player[i]);
                        }

                        prevSecond = currentSecond;//이전 시간 업데이트
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            //Item item = new Item();
            //item.Initialize();


            ////테스트 : 아이템 추가
            //item.AddItem("포션", 5);
            //item.AddItem("칼", 1);
            //item.AddItem("포션", 3); //포션 개수 추가

            //item.ShowInventory();

            ////아이템 사용
            //Console.WriteLine("포션 2개 사용");
            //item.RemoveItem("포션", 2);
            //item.ShowInventory();

            ////테스트 : 없는 아이템 제거
            //Console.WriteLine("방패 1개 제거 시도");
            //item.RemoveItem("방패", 1);

            //item.ShowInventory();


            ////테스트: 모든 포션 제거
            //Console.WriteLine("포션 6개 사용(초과 사용 테스트)");
            //item.RemoveItem("포션", 6);
            //item.ShowInventory();


            //int x = 10, y = 10;

            //ConsoleKeyInfo keyInfo;

            //Console.CursorVisible = false;

            //while (true)
            //{
            //    Console.Clear(); //화면 지우기

            //    Console.SetCursorPosition(x, y);

            //    Console.Write("●"); //현재 위치 출력

            //    keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력 X)

            //    //방향키 입력에 따른 좌표 변경
            //    switch (keyInfo.Key)
            //    {
            //        case ConsoleKey.UpArrow: if (y > 0) y--; break;
            //        case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
            //        case ConsoleKey.LeftArrow: if (x > 0) x--; break;
            //        case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
            //        case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
            //        case ConsoleKey.Escape: return; //ESC키로 종료 

            //    }


            //}


            ShootingGame shootingGame = new ShootingGame();
            shootingGame.Initialize();
            shootingGame.Start();



        }
    }
}
