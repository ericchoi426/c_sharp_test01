using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lgcns.tct.stick
{
    public class Stick
    {
        /// <summary> N개의 삼각형을 만들기 위한 막대 개수를 구하는 기능 </summary>
        /// <param name="inputData"> 입력데이터(삼각형 개수) </param> 
        /// <returns> 막대 개수 </returns>
        public int GetNumberOfStickForTriangle(int inputData)
        {
            int numberOfStickForTriangle = 0;
            ////////////////////////여기부터 구현 (1) ---------------->
            ///
            numberOfStickForTriangle = 3 + (inputData - 1) * 2;
           
            ///////////////////////////// <-------------- 여기까지 구현 (1)
            return numberOfStickForTriangle;
        }

        /// <summary> N층의 피라미드를 만들기 위한 막대 개수를 구하는 기능 </summary>
        /// <param name="numberOfLayers"> 입력데이터(피라미드 층수) </param> 
        /// <returns> 막대 개수 </returns>
        public int GetNumberOfStickForPyramid(int numberOfLayers)
        {
            int numberOfStickForPyramid = 0;
            ////////////////////////여기부터 구현 (2) ---------------->
            int count = numberOfLayers;
            while (count > 0)
            {
                numberOfStickForPyramid += 3 + (2 * count - 2) * 2;
                count--;
            }
            int num = numberOfLayers - 1;
            int sum = 0;
            while (num > 0) sum += num--;
            numberOfStickForPyramid -= sum;
            ///////////////////////////// <-------------- 여기까지 구현 (2)
            return numberOfStickForPyramid;
        }
    }
}
