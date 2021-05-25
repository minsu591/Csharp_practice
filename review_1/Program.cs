using System;

namespace review_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //배열에 랜덤값 채우기
            // 미션 1
            // 정수형태의 사이즈 10인 배열 numbers를 만든다.
            // 이 배열을 1부터 12까지의 랜덤한 수로 채운다.
            // 출력

            Random rand = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1,13);
            }

            Console.Write("랜덤값 채운 배열 : ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("======================");
            // 미션 2 
            // 배열에 랜덤값을 채울때 중복이 되지 않도록 채운다.
            // 출력

            int[] numbers2 = new int[10];
            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = rand.Next(1,13);
                for (int j = 0; j < i; j++)
                {
                    if (numbers2[i] == numbers2[j])
                    {
                        i--;
                        break;
                    }
                }
            }

            Console.Write("중복값 없이 랜덤값 채운 배열 : ");
            foreach(int number in numbers2)
            {
                Console.Write(number+" ");
            }


            // 과제 1
            // 중복없이 채운 배열을 오름차순으로 정렬해보자!

            Console.WriteLine("==================");

            int[] listNum = new int[10];
            for (int i = 0; i <numbers2.Length; i++)
            {
                int countNum = 0;
                for (int j = 0; j < numbers2.Length; j++)
                {

                    if (numbers2[i] > numbers2[j])
                    {
                        countNum++;
                    }

                    
                }
                listNum[countNum] = numbers2[i];

            }

            Console.Write("오름차순으로 정리한 배열 : ");
            foreach(int number in listNum)
            {
                Console.Write(number + " ");
            }

        }
    }
}
