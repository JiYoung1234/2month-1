using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2월_1주차
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1번 이름받기
            string name;
            System.Console.WriteLine("이름은 무엇입니까? ");
            name = System.Console.ReadLine();
            System.Console.WriteLine("당신의 이름은 {0}입니다.", name);

            // 2. 생년월일 받기
            string birthyear;
            System.Console.WriteLine("당신의 생년월일을 입력하세요.");
            System.Console.WriteLine("태어난 년도? ");
            birthyear = System.Console.ReadLine();
            System.Console.WriteLine("당신은 {0}년도에 태어났습니다.", birthyear);

            //3. 자기소개 입력받기
            System.Console.WriteLine("제 이름은 박지영입니다");

            // 4. writeLine으로 출력하기(생년월일 -> 나이)
            int myAgenumber = Convert.ToInt32(birthyear);
            string nowage = (2023 - myAgenumber).ToString();
            System.Console.WriteLine(nowage);
            System.Console.WriteLine("당신의 나이는 {0}세, 이름은 {1} 입니다.",nowage,name);

            // 5. $넣어서 표현하기
            System.Console.WriteLine($"당신의 나이는 {nowage}세, 이름은 {name} 입니다.");

            System.Console.WriteLine("\n");

            // 6. @를 넣어서 사격형 그리기
            System.Console.WriteLine(@"
            ㅁㅁㅁㅁㅁㅁㅁㅁㅁ
            ㅁㅁㅁㅁㅁㅁㅁㅁㅁ
            ㅁㅁㅁㅁㅁㅁㅁㅁㅁ
            ㅁㅁㅁㅁㅁㅁㅁㅁㅁ
            ㅁㅁㅁㅁㅁㅁㅁㅁㅁ");

            // 7. 1,2,3 string 배열에 넣기
            string[] aa = new string[3] { name, birthyear, $"당신의 이름은 {name}, 나이는 {nowage}세 입니다." };
            System.Console.WriteLine($"{aa[2]}");
            System.Console.WriteLine("\n");

            //8. string 배열값을 4번과 같은 방식으로 출력
            System.Console.WriteLine("당신의 이름은 {0}, 나이는 {1}\n{2}",aa[0],aa[1],aa[2]);
            System.Console.WriteLine("\n");
            //9. string 배열값을 4번과 같은 방식으로 출력
            System.Console.WriteLine($"당신의 이름은 {aa[0]}, 나이는 {aa[1]}\n{aa[2]}");
            */

            int number1 = 10;
            int number2 = 20;
            int plusresult = number1 + number2;
            int minuresult = number1 - number2;
            int multresult = number1 * number2;
            int quiresult = number1 / number2;
            int mmresult = number1 % number2;
            System.Console.WriteLine($"결과: {plusresult}");
            System.Console.WriteLine($"결과: {minuresult}");
            System.Console.WriteLine($"결과: {multresult}");
            System.Console.WriteLine($"결과: {quiresult}");
            System.Console.WriteLine($"결과: {mmresult}");

            int number11 = 123;
            int number22 = 532;
            number22 *= number11;
            System.Console.WriteLine("{0}", number22);

            int vale = 123;
            System.Console.WriteLine("{0}", ++vale); // 결과값 나오기전에 +1을 한다.
            System.Console.WriteLine("{0}", vale++);  //결과값 나오고 난 후에 +1을 더한다.

            const int thenumber = 10; //값을 부여한순간 바꿀수없음. 값을 바로 부여해줘야함
            bool nnn = true; //bool은 true/false 만 넣을수있음

            // == 같다
            // != 다르다
            // < 작다
            // > 크다
            // <= 작거나 같다
            // => 크거나 같다

            bool q1 = (1 == 1);
            System.Console.WriteLine(q1); //true

            bool q2 = (1 != 1);
            System.Console.WriteLine(q2); //false

            bool q3 = (1 < 1);
            System.Console.WriteLine(q3); //false

            bool q4 = (2 > 1);
            System.Console.WriteLine(q4); //true

            bool q5 = (3 >= 5);
            System.Console.WriteLine(q5); //false

            bool q6 = (1 <= 2);
            System.Console.WriteLine(q6); //true

            //논리연산자
            bool w1 = (q1 && q2); //and
            bool w2 = (q2 || q5); //or
            System.Console.WriteLine(w1);
            System.Console.WriteLine(w2);



        }
    }
}
