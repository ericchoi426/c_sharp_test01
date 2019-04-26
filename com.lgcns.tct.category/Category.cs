using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lgcns.tct.category
{
    public class Category
    {

        /// <summary> 상위 카테고리를 검색하는 기능 </summary>
        /// <param name="inputData"> 입력데이터(카테고리 정보) </param> 
        /// <param name="categories"> 입력데이터(inputCategories[0]: 카테고리1, inputCategories[1]: 카테고리2) </param> 
        /// <returns> 상위 카테고리 </returns>
        public string GetTopCategory(string[,] inputData, List<string> categories)
        {
            string topCategory = "";
            ////////////////////////여기부터 구현 (1) ---------------->





            ///////////////////////////// <-------------- 여기까지 구현 (1)
            return topCategory;
        }

        /// <summary> 하위 카테고리의 개수를 계산하는 기능 </summary>
        /// <param name="inputData"> 입력데이터(카테고리 정보) </param> 
        /// <param name="categoryStr"> 입력데이터(카테고리) </param> 
        /// <returns> 하위 카테고리의 개수 </returns>
        public int GetNumberOfSubcategories(string[,] inputData, string categoryStr)
        {
            int numberOfSubcategories = 0;
            ////////////////////////여기부터 구현 (2) ---------------->




            ///////////////////////////// <-------------- 여기까지 구현 (2)
            return numberOfSubcategories;
        }
    }
}
