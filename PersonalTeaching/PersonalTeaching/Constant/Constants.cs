using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace PersonalTeaching.Constant
{
    public static class Constants
    {

        //특별히 바뀌지 않을 것이기 때문에 미리 다 작성을 하자.
        public static string[] GradeStringArray = new string[] { "중학교 1학년", "중학교 2학년", "중학교 3학년", "고등학교 1학년", "고등학교 2학년", "고등학교 3학년" };
        public static int[] PriceForeachGrade = new int[] { 240000, 280000, 320000, 360000, 400000, 440000 };
        public static int[] OptionAdditionalPriceArray=new int[] { 80000, 92000, 104000, 116000, 118000, 120000 };
        public static string[] OptionStringArray = new string[] { "시간 (+30분)", "선행학습", "경시대회 준비", "특목고 대비", "이과" };

        public static IEnumerable<string> GetPriceForeachGradeStringArray()
        {
            List<string> list = new List<string>();

            foreach (var item in PriceForeachGrade)
            {
                var temp = "+ " + string.Format("{0:0,0}", item)+"원";
                list.Add(temp);
            }

            return list;
        }

        public static IEnumerable<string> GetOptionPriceStringArray(int selectedPrice)
        {
            List<string> list = new List<string>();
            var insertSring = "+ " + string.Format("{0:0,0}", OptionAdditionalPriceArray[PriceForeachGrade.IndexOf(selectedPrice)]) + "원";

            list.Add(insertSring);
            list.Add("+ 50,000원");
            list.Add("+ 50,000원");
            list.Add("+ 50,000원");
            list.Add("+ 50,000원");

            return list;

        }

        public static IEnumerable<int> GetOptionPriceArray(int selectedPrice)
        {
            List<int> list = new List<int>();
            list.Add(OptionAdditionalPriceArray[PriceForeachGrade.IndexOf(selectedPrice)]);
            list.Add(50000);
            list.Add(50000);
            list.Add(50000);
            list.Add(50000);

            return list;
        }
        

    }
}
