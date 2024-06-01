using System.Reflection.Metadata.Ecma335;

namespace Date
{
   
    class Date
    {
        private int year, month, day;
        public Date(int y, int m, int d) //생성자
        {
            year = y;
            month = m;
            day = d;
        }
        public static Date operator +(Date a, int n)
        {
            Date result = new Date(a.year, a.month, a.day);
            result.day = result.day + n; 

            while (true) //while문을 이용하여 작성(case문을 이용하면 원하는 조건에서 break 되지 않음)
            {

                if (result.month == 1 || result.month == 3 || result.month == 5 || result.month == 7
                || result.month == 8 || result.month == 10 || result.month == 12)
                {
                    if (result.day <= 31)
                        break;
                    result.day -= 31;
                    result.month += 1;
                    while (result.month > 12)
                        result.month -= 12;
                    continue;
                }

                if (result.month == 4 || result.month == 6 || result.month == 9 || result.month == 11)
                {
                    if (result.day <= 30)
                        break;
                    result.day -= 30;
                    result.month += 1;
                    continue;

                }
                if(result.month == 2)
                {
                    if (result.day <= 28)
                        break;
                    result.day -= 28;
                    result.month += 1;
                    continue;

                }
                
            }

                return result;

        }

        public static Date operator -(Date a, int n) //while문 속에 switch문을 이용(뺄셈은 어차피 모든 코드가 돌아야 하므로!)
        {
            Date result = new Date(a.year, a.month, a.day);
            result.day = result.day - n;

            while (result.day <= 0)
            {
                result.month -= 1;
                switch (result.month)
                {

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (result.day <= 0)
                        {
                            result.day = result.day + 30;
                        }
                        break;
                    case 2:
                        if (result.day <= 0)
                        {
                            result.day = result.day + 28;
                        }
                        break;

                    default:
                        if (result.day <= 0)
                        {
                            result.day = result.day + 31;
                        }
                        if (result.month <= 0)
                        {
                            result.month += 12;
                        }
                        break;
                }
            }

            return result;
        }

        public static Date operator ++(Date a)
        {

            return (a + 1);
        }

        public static Date operator --(Date a)
        {
            return (a - 1);
        }

        public static bool operator ==(Date a, Date b) //연도, 달, 개월이 모두 같을 경우 true반환
        {
            if (a.day == b.day && a.month == b.month
                 && a.year == b.year)
            { return true; }

            else
            { return false; }
        }

        public static bool operator !=(Date a, Date b)//연도, 달, 개월 중 하나라도 다를 경우 true 반환
        {
            if (a.day != b.day || a.month != b.month
                || a.year != b.year)
            { return true; }

            else
            { return false; }
        }

        public static bool operator >(Date a, Date b)
        {
            if (a.year > b.year) //연도가 크면 무조건 true
            {
                return true;
            }
            else if(a.year == b.year) //연도가 같은 경우엔
            {
                if (a.month > b.month)//월이 큰 경우 true
                    return true;
                else if(a.month ==b.month)//만일 월이 같은 경우
                {
                    if(a.day > b.day) { return true; }//일을 비교
                    else { return false; }
                }
                else return false;
            }
            else
                return false;
        }
        public static bool operator <(Date a, Date b)
        {
            if (a.year < b.year)
            {
                return true;
            }
            else if (a.year == b.year)
            {
                if (a.month < b.month)
                    return true;
                else if (a.month == b.month)
                {
                    if (a.day < b.day) { return true; }
                    else { return false; }
                }
                else return false;
            }
            else
                return false;
        }
   
        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", year, month, day);
            // 2023/10/11로 출력
        }
    }

    internal class Program
    {
        static void Main()
        {
            Date date1 = new Date(2023, 1, 31);
            Console.WriteLine("date1: " + date1.ToString());

            Date date2 = new Date(2023, 1, 11);
            Console.WriteLine("date2: " + date2.ToString());

            Console.WriteLine("date1 == date2: " + (date1 == date2));
            Console.WriteLine("date1 != date2: " + (date1 != date2));
            Console.WriteLine("date1 > date2: " + (date1 > date2));
            Console.WriteLine("date1 < date2: " + (date1 < date2));
            Console.WriteLine(date1 +" 다음날: " + (++date1).ToString());
            Console.WriteLine(date1 +" 전날: "+ (--date1).ToString());
            Console.WriteLine(date1+" + 90: " + (date1 + 90).ToString());
            Console.WriteLine(date1+" - 62: " + (date1 - 62).ToString());
        }
    }
}