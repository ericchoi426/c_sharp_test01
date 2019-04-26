using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lgcns.tct.aggregate
{
    public class Aggregate
    {

        /// <summary> 부분 배열의 개수를 구하는 기능 </summary>
        /// <param name="arraySize"> 배열 크기 </param>
        /// <returns> 부분 배열의 개수 </returns>
        public int GetNumberOfSubArrays(int arraySize)
        {
            int numberOfSubArrays = 0;
            ////////////////////////여기부터 구현 (1) ---------------->
            while (arraySize > 0)
            {
                numberOfSubArrays += arraySize * arraySize;
                arraySize--;
            }

            ///////////////////////////// <-------------- 여기까지 구현 (1)
            return numberOfSubArrays;
        }

        /// <summary> 최대값을 찾는 기능 </summary>
        /// <param name="inputData"> 입력데이터(NxN배열) </param>
        /// <returns> 최대값 </returns>
        public int GetMaximumValue(int[,] inputData)
        {
            int maximumValue = 0;
            ////////////////////////여기부터 구현 (2) ---------------->
            int length = inputData.GetLength(0);
            List<int> sum_list = new List<int>(); 
            for(int width = 1; width <= length; width++)
            {
                int max_idx = length - width + 1;
                for(int x = 0; x < max_idx; x++)
                {
                    for(int y = 0; y < max_idx; y++)
                    {
                        int start_x = x; int end_x = start_x + width;
                        int start_y = y; int end_y = start_y + width;
                        int sum = 0;
                        for(int i = start_x; i < end_x; i++)
                        {
                            for(int j = start_y; j < end_y; j++)
                            {
                                sum += inputData[i, j];
                            }
                        }
                        sum_list.Add(sum);
                    }
                }
            }
            maximumValue = sum_list.Max();
            ///////////////////////////// <-------------- 여기까지 구현 (2)
            return maximumValue;
        }
    }
}
