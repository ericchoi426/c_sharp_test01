using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lgcns.tct.aggregate
{
    public class AggregateRun
    {
        static void Main(string[] args)
        {
            // 제공 데이터 세트2를 실행하려면 loadData에서 제공 데이터 세트1을 주석 처리하고 제공 데이터 세트2를 주석 해제하여 실행
            int[,] inputData = LoadData();
            PrintInput(inputData);
            Aggregate aggregate = new Aggregate();

            // 부분 배열의 개수를 구하는 기능
            int numberOfSubArrays = aggregate.GetNumberOfSubArrays(inputData.GetLength(0));
            PrintNumberOfSubArrays(inputData.GetLength(0), numberOfSubArrays);

            // 최대값을 찾는 기능
            int maximumValue = aggregate.GetMaximumValue(inputData);
            PrintMaximumValue(inputData.GetLength(0), maximumValue);

            Console.WriteLine("please press any key to continue");
            Console.ReadKey();
        }

        private static int[,] LoadData()
        {


            //////////////////////////////////
            // 제공 데이터 세트 1
            /////////////////////////////////
            
            //int[,] inputData =  {
            //    {-1, 0, 7, 9},
            //    {-6, 2, -3, 5},
            //    {3, -6, 0, -5},
            //    {7, 8, -7, 2}
            //};
            
            //////////////////////////////////
            // 제공 데이터 세트 2
            /////////////////////////////////
            
            int[,] inputData =  {
                    {1, -3, 0, 2, 5},
                    {-3, 0, 8, -3, 7},
                    {9, -1, -2, 6, 0},
                    {-2, -5, 9, 7, 6},
                    {3, 2, 4, 7, -5}
            };
            
        
            return inputData;
        }

        private static void PrintInput(int[,] inputData)
        {
            PrintLineInitial();
            for (int i = 0; i < inputData.GetLength(0); i++)
            {
                for (int j = 0; j < inputData.GetLength(1); j++)
                {
                    Console.Write(inputData[i,j] + " ");
                }
                Console.WriteLine();
            }
            PrintLine();
        }

        private static void PrintNumberOfSubArrays(int size, int numberOfSubArrays)
        {
            Console.Write("[" + size + "x" + size + "배열의 부분 배열 개수]: ");
            if (numberOfSubArrays == 0)
            {
                Console.WriteLine("결과값이 없습니다.");
            }
            else
            {
                Console.WriteLine(numberOfSubArrays + "개");
            }
            PrintLine();
        }

        private static void PrintMaximumValue(int size, int maximumValue)
        {
            Console.Write("[" + size + "x" + size + "배열의 부분 배열내의 최대합]: ");
            if (maximumValue == 0)
            {
                Console.WriteLine("결과값이 없습니다.");
            }
            else
            {
                Console.WriteLine(maximumValue);
            }
            PrintLine();
        }

        private static void PrintLineInitial()
        {
            Console.WriteLine("[초기 입력 데이터]");
        }

        private static void PrintLine()
        {
            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}
