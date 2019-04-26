using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lgcns.tct.category
{
    public class CategoryRun
    {

        public static List<string> categories;
        public static string categoryStr;

        static void Main(string[] args)
        {
            // 제공 데이터 세트2를 실행하려면 loadData에서 제공 데이터 세트1을 주석 처리하고 제공 데이터 세트2를 주석 해제하여 실행
            string[,] inputData = LoadData();
            PrintInput(inputData);
            Category category = new Category();

            // 상위 카테고리를 검색하는 기능
            string topCategory = category.GetTopCategory(inputData, categories);
            PrintTopCategory(topCategory);

            // 하위 카테고리의 개수를 계산하는 기능
            int numberOfSubcategories = category.GetNumberOfSubcategories(inputData, categoryStr);
            PrintNumberOfSubcategories(numberOfSubcategories);

            Console.WriteLine("please press any key to continue");
            Console.ReadKey();
        }

        private static string[,] LoadData()
        {

            //////////////////////////////////
            // 제공 데이터 세트 1
            /////////////////////////////////

            string[,] inputData = {
                {"M","B"},
                {"M","C"},
                {"M","K"},
                {"B","E"},
                {"C","F"},
                {"C","G"},
                {"C","H"},
                {"K","I"},
                {"K","J"},
                {"E","D"},
                {"F","L"},
                {"F","A"},
                {"H","N"},
                {"H","O"},
                {"J","P"},
                {"J","Q"}
            };

            categories = new List<string>()
            {
                 "F", "N"
            };

            categoryStr = "J";


            //////////////////////////////////
            // 제공 데이터 세트 2
            /////////////////////////////////    	

            //string[,] inputData = {
            //    {"Z","B"},
            //    {"Z","W"},
            //    {"Z","V"},
            //    {"B","E"},
            //    {"W","F"},
            //    {"W","G"},
            //    {"V","H"},
            //    {"V","I"},
            //    {"V","J"},
            //    {"E","K"},
            //    {"F","L"},
            //    {"G","M"},
            //    {"G","N"},
            //    {"H","O"},
            //    {"I","P"},
            //    {"J","Q"}
            //};

            //categories = new List<string>()
            //{
            //    "I", "O"
            //};

            //categoryStr = "G";

            return inputData;

        }


        private static void PrintInput(string[,] inputData)
        {
            PrintLineInitial();
            Console.WriteLine("상위 카테고리\t하위 카테고리");
            for(int i = 0; i < inputData.GetLength(0); i++)
            {
                for (int j = 0; j < inputData.GetLength(1); j++)
                {
                    Console.Write(inputData[i,j]+"\t\t");
                }
                Console.WriteLine();
            }
            PrintLine();
        }

        private static void PrintTopCategory(string topCategory)
        {
            Console.Write("[입력으로 제공되는 두 개의 카테고리]: ");
            foreach (string category in categories)
            {
                Console.Write(category + " ");
            }
            Console.WriteLine();
            Console.Write("[두 개의 카테고리를 포함하는 상위 카테고리 중 최하위 카테고리]: ");
            if (topCategory == "")
            {
                Console.WriteLine("결과값이 없습니다.");
            }
            else
            {
                Console.WriteLine(topCategory);
            }
            PrintLine();
        }


        private static void PrintNumberOfSubcategories(int numberOfSubcategories)
        {
            Console.WriteLine("[입력으로 제공되는 카테고리]: " + categoryStr);
            Console.Write("[하위 카테고리의 개수]: ");
            if (numberOfSubcategories == 0)
            {
                Console.WriteLine("결과값이 없습니다.");
            }
            else
            {
                Console.WriteLine(numberOfSubcategories);
            }
            PrintLine();
        }


        private static void PrintLine()
        {
            Console.WriteLine("------------------------------------------------------------");
        }

        private static void PrintLineInitial()
        {
            Console.WriteLine("[초기 입력 데이터]");
        }
    }
}
