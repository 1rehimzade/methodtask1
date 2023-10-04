
//Task 1

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] array = { 8, 2, 9, 1, 4, 6 };
//        int minElement = FindMin(array);
//        Console.WriteLine("En kiçik element: " + minElement);
//    }

//    static int FindMin(int[] arr)
//    {

//        int min = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < min)
//            {
//                min = arr[i];
//            }
//        }
//        return min;
//    }
//}


//Task 2
//using System;

//public class AreaCalculator
//{
//    const double pi = 3.14; 


//    public static double CalculateCircleArea(double radius)
//    {
//        return pi * radius * radius;
//    }


//    public static double CalculateRectangleArea(double length, double width)
//    {
//        return length * width;
//    }


//    public static double CalculateParallelepipedArea(double length, double width, double height)
//    {
//        return 2 * (length * width + length * height + width * height);
//    }


//    public static double CalculateTriangleCircleArea(double a, double b, double c)
//    {
//        double s = (a + b + c) / 2;
//        double radius = 2 * CalculateCircleArea(s) / (a + b + c);
//        return CalculateCircleArea(radius);
//    }

//    static void Main()
//    {
//        double circleRadius = 6.0;
//        double rectangleLength = 4.0;
//        double rectangleWidth = 9.0;
//        double parallelepipedLength = 3.0;
//        double parallelepipedWidth = 4.0;
//        double parallelepipedHeight = 5.0;
//        double triangleSideA = 7.0;
//        double triangleSideB = 35.0;
//        double triangleSideC = 31.0;


//        double circleArea = CalculateCircleArea(circleRadius);
//        double rectangleArea = CalculateRectangleArea(rectangleLength, rectangleWidth);
//        double parallelepipedArea = CalculateParallelepipedArea(parallelepipedLength, parallelepipedWidth, parallelepipedHeight);
//        double triangleCircleArea = CalculateTriangleCircleArea(triangleSideA, triangleSideB, triangleSideC);


//        Console.WriteLine("Çevrenin Sahesi: " + circleArea);
//        Console.WriteLine("Düzbucaqlının Sahesi: " + rectangleArea);
//        Console.WriteLine("Düzbucaqlı Paralelpipedin Tam Sethi: " + parallelepipedArea);
//        Console.WriteLine("Üçbucaqlının Daxiline Çekilmiş Çevrenin Sahesi: " + triangleCircleArea);
//    }
//}

//                 Task 3
//using System;

//class Program
//{
//    static bool Menfieddir(int eded)
//    {
//        return eded < 0;
//    }

//    static int ReqemlerinCemi(int eded)
//    {
//        int cem = 0;
//        while (eded > 0)
//        {
//            cem += eded % 10;
//            eded /= 10;
//        }
//        return cem;
//    }

//    static void Main()
//    {
//        int eded;
//        do
//        {
//            Console.Write("eded daxil edin: ");
//            eded = int.Parse(Console.ReadLine());

//            if (Menfieddir(eded))
//            {
//                Console.WriteLine("eded menfi ededdir. Yeniden daxil edin.");
//            }
//            else
//            {
//                int cem = ReqemlerinCemi(eded);
//                Console.WriteLine($"Reqemlerinin cemi: {cem}");
//            }
//        } while (Menfieddir(eded));
//    }
//}



