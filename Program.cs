using System.Runtime.InteropServices.ComTypes;

class Program
{
    static void Main(string[] args)
    {
    }
    public static int reverse(int num)
    {
        int newNum = 0;
        int temp = num % 10;

        while (temp != 0)
        {
            num = num / 10;
            newNum = newNum * 10 + temp;
            temp = num % 10;
        }

        return newNum;
    }

    public static void time()
    {
        const int MINUTE_SECONDS_PER_HOUR = 60;

        System.Console.WriteLine("Hours: " + System.DateTime.Now.Hour);
        System.Console.WriteLine("Minutes: " + (System.DateTime.Now.Hour * MINUTE_SECONDS_PER_HOUR + System.DateTime.Now.Minute));
        System.Console.WriteLine("Seconds: " + (System.DateTime.Now.Hour * MINUTE_SECONDS_PER_HOUR * MINUTE_SECONDS_PER_HOUR +
                                  System.DateTime.Now.Minute * MINUTE_SECONDS_PER_HOUR + System.DateTime.Now.Second));
    }

    public static void averageDigits(int num)
    {
        int temp;
        int count = 0;
        double resultArith = 0;
        double resultGeom = 1;

        while (num != 0)
        {
            temp = num % 10;
            num = num / 10;
            resultArith += temp;
            resultGeom *= temp;
            ++count;
        }

        System.Console.WriteLine("Sum of digits: " + resultArith);

        resultArith /= count;
        resultGeom = System.Math.Sqrt(resultGeom);

        System.Console.WriteLine("Arithmetic average: " + resultArith);
        System.Console.WriteLine("Geometric average: " + resultGeom);

    }

    public static void dayOfWeek(int num)
    {
        if (num < 1 || num > 365)
        {
            System.Console.WriteLine("Error");
            return;
        }

        const int DAY_IN_WEEK = 7;
        int result = num;

        while (result > DAY_IN_WEEK)
        {
            result -= DAY_IN_WEEK;
        }

        switch (result)
        {
            case 1:
                System.Console.WriteLine("Monday");
                break;

            case 2:
                System.Console.WriteLine("Tuesday");
                break;

            case 3:
                System.Console.WriteLine("Wednesday");
                break;

            case 4:
                System.Console.WriteLine("Thursday");
                break;

            case 5:
                System.Console.WriteLine("Friday");
                break;

            case 6:
                System.Console.WriteLine("Saturday");
                break;

            case 7:
                System.Console.WriteLine("Sunday");
                break;

        }
    }

    public static int squareOnRect(double a, double b, double c)
    {
        if (a < 1 || b < 1 || c < 1)
        {
            System.Console.WriteLine("Error");
            return -1;
        }

        int countSquare = 0;
        double spaceRectangle = 0;

        while (a <= b && a <= c)
        {
            ++countSquare;
            b -= a;
            c -= a;
        }

        if (b == 0 || c == 0)
        {
            System.Console.WriteLine("Space rectangle: " + spaceRectangle);
            return countSquare;
        }

        spaceRectangle = b * c;
        System.Console.WriteLine("Space rectangle: " + spaceRectangle);

        return countSquare;
    }

    public static int definitCentury(int year)
    {
        if (year < 0)
        {
            System.Console.WriteLine("Error");
            return 0;
        }

        return year / 100 + 1;
    }
}
