using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Study1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("멋사4기 출력 성공.");



            //char letter = 'A'; // 문자 'A' 저장
            //char symbol = '#'; // 특수 기호 저장
            //char number = '9'; // 숫자 형태의 문자 저장

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);

            //string greeting = "Hello World!"; // 문자열 저장
            //string name = "Alice"; // 이름 저장

            //Console.WriteLine(greeting); // Hello,World!
            //Console.WriteLine(name);
            //Console.WriteLine(greeting + " " + name);

            //bool isRunning = false;
            //bool isFinished = true;

            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);


            // 닷넷 형식 : 기본 형식의 닷넷표현
            //System.Int32 number = 123;
            //System.String text = "Hello";
            //System.Boolean flag = true;

            //Console.WriteLine(number);
            //Console.WriteLine(text);
            //Console.WriteLine(flag);



            // int 래퍼 형식의 메서드 활용
            //int number = 123;
            //string numberAsString = number.ToString(); // 정수를 문자열로 변환

            //Console.WriteLine(number + 123);
            //Console.WriteLine(numberAsString + 123);

            //// bool 래퍼 형식
            //Console.ForegroundColor = ConsoleColor.Green; // 글자색 바꾸기.
            //bool flag = true;

            //string flagAsString = flag.ToString();
            //Console.WriteLine(flagAsString);

            //Console.ResetColor();


            //// □ ■
            //Console.WriteLine("□ □ □ □ □ □ □ □");
            //Thread.Sleep(2000); // 2000 밀리초 = 2초
            //Console.Clear();
            //Console.WriteLine("■ □ □ □ □ □ □ □"");



            //// 문자열 입력받기
            //Console.Write("이름을 입력하세요 : ");
            //string userName = Console.ReadLine();

            //Console.WriteLine("내 이름은 : " + userName);


            //Console.Write("나이를 입력하세요 : ");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);

            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!");
            //Console.WriteLine("내년에는 {0}살이 되겠군요! ", age+1);
            //Console.WriteLine("내년에는 " + (age + 1) + "살이 되겠군요!");


            //// 입력 받기
            //Console.Write("루인 스킬 피해 : ");
            //float ruinSkillDamage = float.Parse(Console.ReadLine());

            //Console.Write("카드 게이지 획득량 : ");
            //float cardGaugeGain = float.Parse(Console.ReadLine());

            //Console.Write("각성기 피해: ");
            //float awakeningDamage = float.Parse(Console.ReadLine());

            //Console.Write("최대 마나 : ");
            //float maxMana = float.Parse(Console.ReadLine());

            //Console.Write("전투 중 마나 회복량 : ");
            //int manaRegenInCombat = int.Parse(Console.ReadLine());

            //Console.Write("비전투 중 마나 회복량 : ");
            //int manaRegenOutCombat = int.Parse(Console.ReadLine());

            //Console.Write("이동 속도 : ");
            //float moveSpeed = float.Parse(Console.ReadLine());

            //Console.Write("탈 것 속도 : ");
            //float mountSpeed = float.Parse(Console.ReadLine());

            //Console.Write("운반 속도 : ");
            //float sailingSpeed = float.Parse(Console.ReadLine());

            //Console.Write("스킬 재사용 대기시간 감소 : ");
            //float skillCooldownReduction = float.Parse(Console.ReadLine());

            //// 출력
            //Console.WriteLine();

            //Console.Write("활동\t\t\t\t");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("▼");
            //Console.ResetColor();

            //Console.Write("루인 스킬 피해 \t\t\t");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine($"{ruinSkillDamage}%");
            //Console.ResetColor();

            //Console.Write("카드 게이지 획득량 \t\t");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine($"{cardGaugeGain}%");
            //Console.ResetColor();

            //Console.Write("각성기 피해\t\t\t");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine($"{awakeningDamage}%");
            //Console.ResetColor();

            //Console.Write("최대 마나 \t\t\t");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine(maxMana);
            //Console.ResetColor();

            //Console.Write("전투 중 마나 회복량 \t\t");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine(manaRegenInCombat);
            //Console.ResetColor();

            //Console.Write("비전투 중 마나 회복량 \t\t");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine(manaRegenOutCombat);
            //Console.ResetColor();

            //Console.Write("이동 속도 \t\t\t");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine($"{moveSpeed}%");
            //Console.ResetColor();

            //Console.Write("탈 것 속도 \t\t\t");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine($"{mountSpeed}%");
            //Console.ResetColor();

            //Console.Write("운반 속도 \t\t\t");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine($"{sailingSpeed}%");
            //Console.ResetColor();

            //Console.Write("스킬 재사용 대기시간 감소 :\t");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine($"{skillCooldownReduction}%");
            //Console.ResetColor();


            // □ ■
            Console.Write("□ □ □ □ □ □ □ □");
            Thread.Sleep(2000); // 2000 밀리초 = 2초
            Console.Clear();
            Console.Write("■ □ □ □ □ □ □ □");
            Thread.Sleep(2000); // 2000 밀리초 = 2초
            Console.Clear();
            Console.Write("■ ■ □ □ □ □ □ □");
            Thread.Sleep(2000); // 2000 밀리초 = 2초
            Console.Clear();
            Console.Write("■ ■ ■ □ □ □ □ □");
            Thread.Sleep(2000); // 2000 밀리초 = 2초
            Console.Clear();
            Console.Write("■ ■ ■ ■ □ □ □ □");
            Thread.Sleep(2000); // 2000 밀리초 = 2초
            Console.Clear();
            Console.Write("■ ■ ■ ■ ■ □ □ □");
            Thread.Sleep(2000); // 2000 밀리초 = 2초
            Console.Clear();
            Console.Write("■ ■ ■ ■ ■ ■ □ □");
            Thread.Sleep(2000); // 2000 밀리초 = 2초
            Console.Clear();
            Console.Write("■ ■ ■ ■ ■ ■ ■ □");
            Thread.Sleep(2000); // 2000 밀리초 = 2초
            Console.Clear();
            Console.Write("■ ■ ■ ■ ■ ■ ■ ■");
            Thread.Sleep(2000); // 2000 밀리초 = 2초
            Console.Clear();

            Console.WriteLine("제목: [던전 속 편의점, 오늘도 영업 중] (Dungeon Convenience Store, Open for Business!)");
            Console.Write("엔터를 눌러 진행해주세요...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("1. 프롤로그 - 무덤을 뒤지는 영업사원");
            Thread.Sleep(2000);
            Console.Write("엔터를 눌러 진행해주세요...");
            Console.ReadLine();
            Console.Clear();

            Thread.Sleep(2000);
            Console.WriteLine("던전 35층. 몬스터들의 영역을 넘어선 죽음의 지대.");
            Thread.Sleep(2000);
            Console.WriteLine("그곳에서, 한 청년이 마법 상자를 꺼내더니 그 안에서 뭔가를 꺼냈다.");
            Thread.Sleep(2000);
            Console.Write("엔터를 눌러 진행해주세요...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("“좋아, 오늘의 첫 손님은... 어? 해골 기사님이네?”");
            Thread.Sleep(2000); 
            Console.WriteLine("그가 내민 것은 핫바였다.");
            Thread.Sleep(2000); 
            Console.WriteLine("따뜻한 증기가 피어오르는 갓 조리된 핫바.");
            Thread.Sleep(2000); 
            Console.WriteLine("방패를 든 해골 기사가 고개를 갸웃했다.");
            Thread.Sleep(2000);
            Console.Write("엔터를 눌러 진행해주세요...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("“으으...?\"");
            Thread.Sleep(2000);
            Console.WriteLine("\"어이, 형님. 배고프지? 이거 마나 충전 20% 효과도 있음.\"");
            Thread.Sleep(2000);
            Console.WriteLine("해골 기사는 이리저리 고민하더니 핫바를 집어 들었다.");
            Thread.Sleep(2000);
            Console.WriteLine("그리고... 단번에 한입에 삼켜버렸다.");
            Thread.Sleep(2000);
            Console.Write("엔터를 눌러 진행해주세요...");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("[해골 기사 A가 당신의 상점에서 물건을 구매했습니다!]");
            Thread.Sleep(2000);
            Console.WriteLine("[현재 총 수익: 2골드 50실버]");
            Thread.Sleep(2000);
            Console.WriteLine("청년은 흐뭇하게 미소 지으며 계산을 마쳤다.");
            Thread.Sleep(2000);
            Console.WriteLine("“역시! 오늘 장사도 대박이네!”");
            Thread.Sleep(2000);
            Console.Write("엔터를 눌러 진행해주세요...");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("프롤로그 종료..");
        }
    }
}
