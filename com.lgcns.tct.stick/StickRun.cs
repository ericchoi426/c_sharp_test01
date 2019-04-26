using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lgcns.tct.stick
{
    public class StickRun
    {
        public static int numberOfLayers;

        static void Main(string[] args)
        {
            // 제공 데이터 세트2를 실행하려면 loadData에서 제공 데이터 세트1을 주석 처리하고 제공 데이터 세트2를 주석 해제하여 실행
            int inputData = LoadData();
            Stick stick = new Stick();

            // N개의 삼각형을 만들기 위한 막대 개수를 구하는 기능
            int numberOfStickForTriangle = stick.GetNumberOfStickForTriangle(inputData);
            PrintNumberOfStickForTriangle(inputData, numberOfStickForTriangle);

            // N층의 피라미드를 만들기 위한 막대 개수를 구하는 기능
            int numberOfStickForPyramid = stick.GetNumberOfStickForPyramid(numberOfLayers);
            PrintNumberOfStickForPyramid(numberOfLayers, numberOfStickForPyramid);

            Console.WriteLine("please press any key to continue");
            Console.ReadKey();
        }

        private static int LoadData()
        {


            //////////////////////////////////
            // 제공 데이터 세트 1
            /////////////////////////////////

            int inputData = 6;
            numberOfLayers = 4;

            //////////////////////////////////
            // 제공 데이터 세트 2
            /////////////////////////////////    	
            /*
            int inputData = 8;
            numberOfLayers = 7;
            */

            return inputData;
        }

        private static void PrintNumberOfStickForTriangle(int inputData, int numberOfStickForTriangle)
        {
            Console.Write("[" + inputData + "개의 삼각형을 만들기 위한 막대 개수]: ");
            if (numberOfStickForTriangle == 0)
            {
                Console.WriteLine("결과값이 없습니다.");
            }
            else
            {
                Console.WriteLine(numberOfStickForTriangle);
            }
            PrintLine();
        }

        private static void PrintNumberOfStickForPyramid(int numberOfLayers, int numberOfStickForPyramid)
        {
            Console.Write("[" + numberOfLayers + "층의 피라미드를 만들기 위한 막대 개수]: ");
            if (numberOfStickForPyramid == 0)
            {
                Console.WriteLine("결과값이 없습니다.");
            }
            else
            {
                Console.WriteLine(numberOfStickForPyramid);
            }
            PrintLine();
        }

        private static void PrintLine()
        {
            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}
