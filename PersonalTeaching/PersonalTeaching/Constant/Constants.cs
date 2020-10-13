using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace PersonalTeaching.Constant
{
    public static class Constants
    {

        //특별히 바뀌지 않을 것이기 때문에 미리 다 작성을 하자.
        public static int[] PriceForeachGrade = new int[] { 240000, 280000, 320000, 360000, 400000, 440000 };
        public static int[] OptionAdditionalPriceArray = new int[] { 80000, 92000, 104000, 116000, 118000, 120000 };

        public static int GetAddHourOptionPrice(int selectedPrcie)
        {
            return OptionAdditionalPriceArray[PriceForeachGrade.IndexOf(selectedPrcie)];
        }

        public static string AddHourOption = "시간 추가 (+30분)";
        public static string PreEduOption = "선행학습";
        public static string PrepareContestOption = "경시대회 준비";
        public static string PrepareSpecialHighSchoolOption = "특목고 대비";
        public static string MathAndSciencePartOption = "이과";

        public static int PreEduOptionPrice = 50000;
        public static int PrepareContestOptionPrice = 50000;
        public static int PrepareSpecialHighSchoolOptionPrice = 50000;
        public static int MathAndSciencePartOptionPrice = 50000;


        public static string Middle1 = "중학교 1학년";
        public static string Middle2 = "중학교 2학년";
        public static string Middle3 = "중학교 3학년";
        public static string High1 = "고등학교 1학년";
        public static string High2 = "고등학교 2학년";
        public static string High3 = "고등학교 3학년";

        public static int Middle1Price = 240000;
        public static int Middle2Price = 280000;
        public static int Middle3Price = 320000;
        public static int High1Price = 360000;
        public static int High2Price = 400000;
        public static int High3Price = 440000;


        public static Dictionary<string, string> GetDongDictionary()
        {
            var dic = new Dictionary<string, string>();
            string jungGu = "중앙동 , 동광동 , 대청동 , 보수동 , 부평동 , 광복동 , 남포동 , 영주1동 , 영주2동";
            string seoGu = "동대신1동 , 동대신2동 , 동대신3동 , 서대신1동 , 서대신3동 , 서대신4동 , 부민동 , 아미동 , 초장동 , 충무동 , 남부민1동 , 남부민2동 , 암남동";
            string dongGu = "초량1동 , 초량2동 , 초량3동 , 초량6동 , 수정1동 , 수정2동 , 수정4동 , 수정5동 , 좌천동 , 범일1동 , 범일2동 , 범일5동";
            string yeongdoGu = "남항동 , 영선1동 , 영선2동 , 신선동 , 봉래1동 , 봉래2동 , 청학1동 , 청학2동 , 동삼1동 , 동삼2동 , 동삼3동";
            string jinGu = "부전1동 , 부전2동 , 연지동 , 초읍동 , 양정1동 , 양정2동 , 전포1동 , 전포2동 , 부암1동 , 부암3동 , 당감1동 , 당감2동 , 당감4동 , 가야1동 , 가야2동 , 개금1동 , 개금2동 , 개금3동 , 범천1동 , 범천2동";
            string dongraeGu = "수민동 , 복산동 , 명륜동 , 온천1동 , 온천2동 , 온천3동 , 사직1동 , 사직2동 , 사직3동 , 안락1동 , 안락2동 , 명장1동 , 명장2동";
            string namGu = "대연1동 , 대연3동 , 대연4동 , 대연5동 , 대연6동 , 용호1동 , 용호2동 , 용호3동 , 용호4동 , 용당동 , 감만1동 , 감만2동 , 우암동 , 문현1동 , 문현2동 , 문현3동 , 문현4동 , 민우모택동 , 선자욱지동";
            string bukGu = "구포1동 , 구포2동 , 구포3동 , 금곡동 , 화명1동 , 화명2동 , 화명3동 , 덕천1동 , 덕천2동 , 덕천3동 , 만덕1동 , 만덕2동 , 만덕3동";
            string haewondaeGu = "우1동 , 우2동 , 우3동 , 중1동 , 중2동 , 좌1동 , 좌2동 , 좌3동 , 좌4동 , 송정동 , 반여1동 , 반여2동 , 반여3동 , 반여4동 , 반송1동 , 반송2동 , 재송1동 , 재송2동";
            string sahaGu = "괴정1동 , 괴정2동 , 괴정3동 , 괴정4동 , 당리동 , 감천1동 , 감천2동 , 다대1동 , 다대2동 , 구평동 , 장림1동 , 장림2동 , 신평1동 , 신평2동 , 하단1동 , 하단2동";
            string geumjungGu = "서1동 , 서2동 , 서3동 , 금사동 , 부곡1동 , 부곡2동 , 부곡3동 , 부곡4동 , 장전1동 , 장전2동 , 장전3동 , 선두구동 , 청룡노포동 , 남산동 , 구서1동 , 구서2동 , 금성동";
            string gangseoGu = "대저1동 , 대저2동 , 강동동 , 명지1동 , 명지2동 , 가락동 , 녹산동 , 가덕도동";
            string yeonjaeGu = "거제1동 , 거제2동 , 거제3동 , 거제4동 , 연산1동 , 연산2동 , 연산3동 , 연산4동 , 연산5동 , 연산6동 , 연산8동 , 연산9동";
            string suyeongGu = "남천1동 , 남천2동 , 수영동 , 망미1동 , 망미2동 , 광안1동 , 광안2동 , 광안3동 , 광안4동 , 민락동";
            string sasangGu = "삼락동 , 모라1동 , 모라3동 , 덕포1동 , 덕포2동 , 괘법동 , 감전동 , 주례1동 , 주례2동 , 주례3동 , 학장동 , 엄궁동";
            string gijangGu = "기장읍 , 장안읍 , 정관읍,일광면 , 철마면";

            dic.Add("중구", jungGu);
            dic.Add("서구", seoGu);
            dic.Add("동구", dongGu);
            dic.Add("영도구", yeongdoGu);
            dic.Add("부산진구", jinGu);
            dic.Add("동래구", dongraeGu);
            dic.Add("남구", namGu);
            dic.Add("북구", bukGu);
            dic.Add("해운대구", haewondaeGu);
            dic.Add("사하구", sahaGu);
            dic.Add("금정구", geumjungGu);
            dic.Add("강서구", gangseoGu);
            dic.Add("연제구", yeonjaeGu);
            dic.Add("수영구", suyeongGu);
            dic.Add("사상구", sasangGu);
            dic.Add("기장군", gijangGu);



            return dic;
        }

    }


}
