using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2월_1주차
{
    class Program
    {
        private static int ShowUpNewSentence(int number)
        {
            int newNumber2 = number * 5;
            System.Console.WriteLine(newNumber2);
            return newNumber2;
        }
        private static int minus(int number)
        {
            int newNumber4 = number - 5;
            System.Console.WriteLine(newNumber4);
            return newNumber4;
        }
        private static int plus(int number)
        {
            int newNumber3 = number + 5;
            System.Console.WriteLine(newNumber3);
            return newNumber3;
        }
        private static int Plus(int s1number ,int s2number)
        {
            int resultnumber = s1number + s2number;
            return resultnumber;
        }
        private static int minus(int s1number, int s2number)
        {
            int resultnumber2 = s1number - s2number;
            return resultnumber2;
        }
        private static int multipl(int s1number, int s2number)
        {
            int resultnumber3 = s1number * s2number;
            return resultnumber3;
        }
        private static int div(int s1number, int s2number)
        {
            int resultnumber4 = s1number / s2number;
            return resultnumber4;
        }


        static void Main(string[] args)
        {
            string s1 = System.Console.ReadLine();
            int s1number = Convert.ToInt32(s1);
            string s3 = System.Console.ReadLine();
            string s2 = System.Console.ReadLine();
            int s2number = Convert.ToInt32(s2);
            

            if (s3 == "+")
            {
                int NewInt = Plus(s1number, s2number);
                System.Console.WriteLine(NewInt);
            }
            else if (s3 == "-")
            {
                int NewInt = minus(s1number, s2number);
                System.Console.WriteLine(NewInt);
            }
            else if (s3 == "*")
            {
                int NewInt = multipl(s1number, s2number);
                System.Console.WriteLine(NewInt);
            }
            else if (s3 == "/")
            {
                int NewInt = div(s1number, s2number);
                System.Console.WriteLine(NewInt);
            }
            else
            {
                System.Console.WriteLine("잘못된 부호입니다.");
            }




            System.Console.WriteLine("0");
            int newInt = ShowUpNewSentence(5);
            System.Console.WriteLine("3");
            int newint = plus(5);
            int aaa = minus(6);

            

            //int newINt = plustwoparam(s1number, s2number);
            //System.Console.WriteLine(newINt);


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

            System.Console.WriteLine(true && true);
            System.Console.WriteLine(true && false);
            System.Console.WriteLine(false && true);
            System.Console.WriteLine(false && false);

            System.Console.WriteLine(true || true);
            System.Console.WriteLine(true || false);
            System.Console.WriteLine(false || true);
            System.Console.WriteLine(false || false);

            if (true)
            {
                System.Console.WriteLine("if문 실행");
            }
            
            else if (false)
            {
                System.Console.WriteLine("else if문 시행");
            }
            else 
            {
                System.Console.WriteLine("else문 시행");
            }
            //<0 <2 <4
            int num = 2 + 3;
            if (num < 0)
            {
                System.Console.WriteLine("num은 0보다 큽니다.");
            }
            else if (num < 2)
            {
                System.Console.WriteLine("num은 0보다 크고 2보다 작습니다.");
            }
            else if (num < 4)
            {
                System.Console.WriteLine("num은 2보다 크고 4보다 작습니다.");
            }
            else
            {
                System.Console.WriteLine("num은 4보다 큽니다.");
            }
             /*
            int myAgenumber = Convert.ToInt32(birthyear);
            string nowage = (2023 - myAgenumber).ToString();
            System.Console.WriteLine(nowage);
            System.Console.WriteLine("당신의 나이는 {0}세, 이름은 {1} 입니다.", nowage, name);
             */


            /*
             //a가 짝수이고 b가 0보다 큰경우
            string number12, number34;
            number12 = System.Console.ReadLine();
            number34 = System.Console.ReadLine();
            int res = Convert.ToInt32(number12) + Convert.ToInt32(number34);
            if (res < 10)
            {
                System.Console.WriteLine("10보다 작다");
            }
            else if (res < 20)
            {
                System.Console.WriteLine("20보다 작다");
            }
            else
            {
                System.Console.WriteLine("20보다 크다");
            }

            string AA, BB;
            AA = System.Console.ReadLine();
            BB = System.Console.ReadLine();
            int A = Convert.ToInt32(AA);
            int B = Convert.ToInt32(BB);

            if (A % 2 == 0 && B < 0)
            {
                System.Console.WriteLine("A는 짝수이고 B는 0보다 작다");
            }
            else if(A % 2 == 0 && B < 3){
                System.Console.WriteLine("A는 짝수이고 B는 3보다 작다");
            }
            else if (A % 2 == 1 && B < 5)
            {
                System.Console.WriteLine("A는 홀수이고 B는 5보다 작다");
            }
            else
            {
                System.Console.WriteLine("aaaaaaaaaaaaaaa");
            }
            */

            /*
            //반복문
            int numberlimit = 10;
            while (numberlimit>0)
            {
                System.Console.WriteLine("hi");
                numberlimit--;
            }

            System.Console.WriteLine("\n");

            do
            {
                System.Console.WriteLine("hi");
            } while (numberlimit > 5);



            string ss;
            ss=System.Console.ReadLine();
            int s = Convert.ToInt32(ss);
            do
            {
                System.Console.WriteLine("aa");
                s--;
            } while (s > 5);
            */

            //for문 반복문(초기식; 조건식; 증강식)
            for (int a = 0; a < 5; a++)
                System.Console.WriteLine("tr");

            //string dd;
            //dd = System.Console.ReadLine();
            //int d = Convert.ToInt32(dd);
            //for (d = 0; d < 10; d++)
            // System.Console.WriteLine("QW");
            int cor, low;
            for (cor= 0; cor < 5; cor++)
            {
                for(low = 0; low <= cor; low++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");
            }


            //switch(비교대상)

            int nul = 3;
            switch (nul)
            {
                case 0:
                    System.Console.WriteLine("0");
                    break;
                case 1:
                    System.Console.WriteLine("1");
                    break;
                default:
                    break;
            }

            for(int i=0;i<5; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("0");
                    continue;
                }
                else if (i == 1)
                {
                    Console.WriteLine("1");
                    Console.WriteLine("11");
                    continue;
                    Console.WriteLine("111");
                }
                else if (i == 2)
                {
                    Console.WriteLine("2");
                    break;
                }
                else if (i == 3)
                {
                    Console.WriteLine("3");
                }
            }
            Console.WriteLine("끝");

        }
        
        /*
        private static void ShowUpNewSentence()
        {
            System.Console.WriteLine("1");
            System.Console.WriteLine("새로운 문장");
            System.Console.WriteLine("2");
        }*/
            

    }
}
