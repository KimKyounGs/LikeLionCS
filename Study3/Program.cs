using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Study3
{
    class Program
    {
        static void Main(string[] args)
        {
            // // switch 문
            // int day = 5;

            // switch(day)
            // {
            //     case 1:
            //         Console.WriteLine("월요일");
            //         break;
            //     case 2:
            //         Console.WriteLine("화요일");
            //         break;
            //     case 3:
            //         Console.WriteLine("수요일");
            //         break;
            //     case 4:
            //         Console.WriteLine("목요일");
            //         break;
            //     case 5:
            //         Console.WriteLine("금요일");
            //         break;
            //     case 6:
            //         Console.WriteLine("토요일");
            //         break;
            //     case 7:
            //         Console.WriteLine("일요일");
            //         break;
            //     default:
            //         Console.WriteLine("잘못입력 했습니다.");
            //         break;
            // }


            // int iInput = 0;
            // Console.Write("캐릭터를 선택하세요 (1.검사 2.마법사 3.도적): ");
            // iInput = int.Parse(Console.ReadLine());

            // switch(iInput)
            // {
            //     case 1:

            //         Console.WriteLine("검사 ");
            //         Console.WriteLine("공격력 100");
            //         Console.WriteLine("방어력  90");
            //         break;
            //     case 2:

            //         Console.WriteLine("마법사");
            //         Console.WriteLine("공격력 110");
            //         Console.WriteLine("방어력  80");
            //         break;
            //     case 3:

            //         Console.WriteLine("도적");
            //         Console.WriteLine("공격력 115");
            //         Console.WriteLine("방어력  70");
            //         break;
            // } 


            // //대장장이 키우기
            // //도끼등급 SSS  10%
            // //도끼등급 SS   40%
            // //도끼등급 S    50%

            // Random rand = new Random(); //랜덤값을 뽑는 문장

            // int rnd = 0;

            // for(int i =0; i<20; i++)
            // {
            //     rnd = rand.Next(1, 101);  //1~100


            //     if(rnd >= 1 && rnd <=10)
            //     {
            //         Console.WriteLine("도끼등급 SSS");
            //     }
            //     else if (rnd >= 11 && rnd <= 40)
            //     {
            //         Console.WriteLine("도끼등급 SS");
            //     }
            //     else
            //     {
            //         Console.WriteLine("도끼등급 S");
            //     }
            //     Thread.Sleep(500); //0.5초정도로 뽑아라.

            // }




            //goto 

            //int n = 1;

            //start:

            //if(n <=5)
            //{
            //    Console.WriteLine(n);
            //    n++;

            //    goto start; //레이블로 이동
            //} 








            ////랜덤
            //Random rand = new Random();

            //Console.WriteLine(" 대장장이 키우기 ");

            //int pmoney = 100;
            //int input;
            //int rnd;

            //Thread.Sleep(500);


            ////무한반복
            //while (true)
            //{
            //    Console.Clear(); //화면지우기 
            //    Console.WriteLine("1. 나무캐기 ");
            //    Console.WriteLine("2. 장비뽑기 ");
            //    Console.WriteLine("3. 나가기 ");
            //    Console.Write("입력 : ");
            //    input = int.Parse(Console.ReadLine()); //input에 키로 눌린 숫자 담기

            //    if (input == 1) //나무캐기화면
            //    {
            //        while (true)
            //        {
            //            Console.WriteLine("나무캐기(엔터)");
            //            Console.WriteLine("뒤로가기 x");

            //            string str = Console.ReadLine();

            //            pmoney += 100;
            //            Console.WriteLine("소지금 : " + pmoney);
            //            if (str == "x")
            //            {
            //                Console.WriteLine("뒤로가기");
            //                break;
            //            }

            //        }
            //    }
            //    else if (input == 2)
            //    {
            //        //장비뽑기
            //        if (pmoney >= 1000) //돈이 있는지 확인후 뽑기
            //        {
            //            pmoney -= 1000;


            //            //20번 뽑기
            //            for (int i = 1; i <= 20; i++)
            //            {
            //                rnd = rand.Next(1, 101);

            //                if (rnd == 1) // 1퍼
            //                {
            //                    Console.WriteLine("도끼등급 SSS");
            //                }
            //                else if (rnd >= 2 && rnd <= 6)
            //                {
            //                    Console.WriteLine("도끼등급 SS");
            //                }
            //                else if (rnd >= 7 && rnd <= 17)
            //                {
            //                    Console.WriteLine("도끼등급 S");
            //                }
            //                else if (rnd >= 18 && rnd <= 38)
            //                {
            //                    Console.WriteLine("도끼등급 A");
            //                }
            //                else if (rnd >= 39 && rnd <= 69)
            //                {
            //                    Console.WriteLine("도끼등급 B");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("도끼등급 C");
            //                }
            //                Thread.Sleep(500); // 0.5초정도로 뽑혀라.
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("돈이 부족합니다. \n");
            //            Thread.Sleep(1000);
            //        }
            //    }
            //    else if (input == 3)
            //    {
            //        Console.WriteLine("나갑니다.");
            //        Environment.Exit(0);
            //    }
            //}



            //Random rand = new Random();

            ////멋사 4기는 능력이 사기다
            //int gold = 500;
            //int health = 100;
            //int power = 10;
            //int input;
            //bool isAlive = true;

            //Console.WriteLine(" ⚔️ 모험가 키우기 ⚔️ ");
            //Thread.Sleep(1000);

            //while (isAlive)
            //{
            //    Console.Clear();
            //    Console.WriteLine($" 현재 상태: 체력 {health} | 골드 {gold} | 공격력 {power}");
            //    Console.WriteLine("\n1. 탐험하기 🏕️");
            //    Console.WriteLine("2. 장비 뽑기 🎲 (1000골드)");
            //    Console.WriteLine("3. 휴식하기 💤 (체력 +20");
            //    Console.WriteLine("4. 게임 종료 ");
            //    Console.Write("입력: ");

            //    input = int.Parse(Console.ReadLine());


            //    if (input == 1)  //탐험하기
            //    {
            //        Console.Clear();
            //        Console.WriteLine(" 탐험을 떠납니다.");
            //        Thread.Sleep(500);
            //        Console.WriteLine(" 탐험을 떠납니다..");
            //        Thread.Sleep(500);
            //        Console.WriteLine(" 탐험을 떠납니다...");
            //        Thread.Sleep(500);
            //        Console.WriteLine(" 탐험을 떠납니다....");

            //        int eventChance = rand.Next(1, 101); //1~100 랜덤 이벤트 발생


            //        if (eventChance <= 30) //30%확률로 전투 발생
            //        {
            //            int damage = rand.Next(5, 21);
            //            Console.WriteLine($"⚔️ 몬스터를 만났습니다! (체력 -{damage}");
            //            health -= damage;
            //        }
            //        else if (eventChance <= 70)  //40%확률로 보상
            //        {
            //            int reward = rand.Next(100, 301); //100~300골드
            //            Console.WriteLine($"💰 보물을 발견했습니다! (+{reward} 골드)");
            //            gold += reward;
            //        }
            //        else //30$확률로 회복
            //        {
            //            int heal = rand.Next(10, 31); //10~30 체력 회복
            //            Console.WriteLine($"🌿 신비한 약초를 발견했습니다! (+{heal} 체력)");
            //            health += heal;
            //        }

            //        if (health <= 0)
            //        {
            //            Console.WriteLine("\n 💀체력이 0이 되어 사망했습니다... 게임 오버!");
            //            isAlive = false;
            //        }
            //    }
            //    else if (input == 2) //장비 뽑기
            //    {
            //        if (gold >= 1000)
            //        {
            //            gold -= 1000;
            //            Console.Clear();
            //            Console.WriteLine("🎲 장비를 뽑습니다...");
            //            Thread.Sleep(1000);

            //            int rnd = rand.Next(1, 101); //1~100랜덤

            //            if (rnd == 1)
            //            {
            //                Console.WriteLine("SSS급 전설의 검 (공격력 +50) 획득!");
            //                power += 50;
            //            }
            //            else if (rnd <= 10)
            //            {
            //                Console.WriteLine("SS급 희귀한 검 (공격력 +30) 획득!");
            //                power += 30;
            //            }
            //            else if (rnd <= 30)
            //            {
            //                Console.WriteLine("S급 강철 검 (공격력 +20) 획득!");
            //                power += 20;
            //            }
            //            else
            //            {
            //                Console.WriteLine("녹슨칼 (공격력 +5) 획득!");
            //                power += 5;
            //            }
            //            Thread.Sleep(5000);
            //        }
            //        else
            //        {
            //            Console.WriteLine("골드가 부족합니다. (1000 골드 필요) ");
            //            Thread.Sleep(1000);
            //        }
            //    }
            //    else if (input == 3) //휴식하기
            //    {
            //        Console.WriteLine("휴식을 취합니다...(+20 체력)");
            //        health += 20;
            //        Thread.Sleep(1000);
            //    }
            //    else if (input == 4) //휴식하기
            //    {
            //        Console.WriteLine("게임을 종료합니다.");
            //        Environment.Exit(1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
            //        Thread.Sleep(1000);
            //    }

            //}





            ////콘솔 창 크기 설정 
            //Console.SetWindowSize(80, 25); //x 80 , y 25

            ////콘솔 버퍼 크기도 설정 (스크롤없이 고정된 창 유지)
            //Console.SetBufferSize(80, 25);

            //Console.CursorVisible = false; //커서 숨기기


            //Console.Clear(); //화면 지우기
            //Console.SetCursorPosition(0, 0);
            //Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            //Console.SetCursorPosition(0, 1);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 2);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 3);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 4);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 4);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 5);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 6);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 7);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 8);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 9);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 10);
            //Console.Write("┃                          대장장이 키우기                                     ┃");
            //Console.SetCursorPosition(0, 11);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 12);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 13);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 14);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 15);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 16);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 17);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 18);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 19);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 20);
            //Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");


            //Thread.Sleep(3000);


            //for (int x = 0; x < 30; x++) //0~ 29이동
            //{
            //    Console.Clear();
            //    Console.SetCursorPosition(x, 10);
            //    Console.Write("◎");
            //    Thread.Sleep(100);
            //}

            




            // 검 키우기 게임

            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(0, 1);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 2);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 3);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 4);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 5);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 6);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 7);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 8);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 9);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 10);
            Console.Write("┃                              검 키우기                                       ┃");
            Console.SetCursorPosition(0, 11);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 12);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 13);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 14);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 15);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 16);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 17);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 18);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 19);
            Console.Write("┃                                                                              ┃");
            Console.SetCursorPosition(0, 20);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");


            Thread.Sleep(3000);

            string[] swordNames = {
            "녹슨 검", "기본 검", "전사의 검", "정제된 강철 검", "빛나는 은 검",
            "붉은 용의 검", "암흑의 검", "성스러운 검", "고대 전설의 검", "불멸의 검",
            "마신의 검", "신성한 검", "용의 심장 검", "초월의 검", "신의 검",
            "절대 검", "운명의 검", "시간의 검", "창조주의 검", "궁극의 검"
            };
            int[] upgradeChances = { 100, 90, 85, 80, 75, 70, 65, 60, 55, 50, 45, 40, 35, 30, 25, 20, 15, 10, 5, 1 };
            int[] swordPrices = { 100, 500, 1000, 2000, 5000, 10000, 20000, 40000, 80000, 150000,
                              300000, 500000, 750000, 1000000, 1500000, 2000000, 3000000, 5000000,
                              10000000, 50000000 };

            int gold = 10000;
            int swordLevel = 1;
            int maxSwordLevel = 1;

            Random random = new Random();

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"최대 강화 등급 : {maxSwordLevel}");
                Console.WriteLine($"현재 가지고 있는 골드 : {gold}원 | 현재 검 : {swordNames[swordLevel - 1]} (강화 등급 : {swordLevel})" );
                Console.WriteLine($"검 강화비용 : {swordPrices[swordLevel - 1]/2}원");
                Console.WriteLine($"검 강화확률 : {upgradeChances[swordLevel - 1]}%");
                Console.WriteLine("검을 강화하려면 (y,Y) 판매하시려면 (n,N) 게임을 종료하려면 (e,E)키를 눌러주세요.");
                char input = char.ToLower(Console.ReadKey(true).KeyChar);
                if (input == 'y')
                {
                    int upgradeCost = swordPrices[swordLevel - 1] / 2; // 강화 비용

                    if (gold < upgradeCost)
                    {
                        Console.WriteLine("골드가 부족합니다!");
                        continue;
                    }

                    gold -= upgradeCost; // 골드차감
                    int successChance = upgradeChances[swordLevel - 1];
                    int roll = random.Next(1, 101); // 1~100 랜덤 숫자

                    Console.WriteLine($"강화 비용 : {upgradeCost}원 | 남은 골드 : {gold}원");
                    Thread.Sleep(1500);
                    Console.WriteLine("강화 시작!");
                    Thread.Sleep(1500);
                    Console.WriteLine("강화중...");
                    Thread.Sleep(1500);
                    if (roll <= successChance)
                    {
                        swordLevel++;
                        Console.WriteLine("강화 성공! ^0^");
                        Console.WriteLine($"새로운 검 : {swordNames[swordLevel - 1]}");

                        if (maxSwordLevel < swordLevel)
                        {
                            maxSwordLevel = swordLevel;
                        }
                    }
                    else
                    {
                        swordLevel = swordLevel > 5 ? swordLevel - 1 : 1;
                        Console.WriteLine(swordLevel == 1 ? "❌ 강화 실패! 검이 초기화되었습니다!" : $"❌ 강화 실패! 검이 {swordLevel} 단계로 하락했습니다.");
                    }
                }
                else if (input == 'n')
                {
                    Console.WriteLine("검을 판매합니다!");
                    Thread.Sleep(1500);
                    Console.WriteLine($"골드 {swordPrices[swordLevel - 1]}을 받았습니다!");
                    gold += swordPrices[swordLevel - 1];
                    swordLevel = 1;
                }
                else if (input == 'e')
                {
                    Console.WriteLine("게임을 종료합니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다!!");
                }

                Thread.Sleep(2000);
            }
        }
    }
}
