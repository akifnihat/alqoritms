//namespace alqoritms
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//            Console.WriteLine(SumArray(1, 2, 3));
//            fesiller(2);
//            Console.WriteLine(multip(231));
//            Console.WriteLine(Market(20, 30, 40));


//            static int SumArray(params int[] arr)
//            {
//                int result = 0;
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    if (arr[i] >= 10 && arr[i] <= 100)
//                    {
//                        result += arr[i];
//                    }
//                }
//                return result;
//            }

//            static void fesiller(int n)
//            {
//                switch (n)
//                {
//                        case 1:
//                        Console.WriteLine("qish");
//                        break;
//                        case 2:
//                        Console.WriteLine("qish");
//                            break;
//                        case 3:
//                        Console.WriteLine("yaz");
//                        break;
//                        case 4:
//                        Console.WriteLine("yaz");
//                            break;
//                        case 5:
//                        Console.WriteLine("yaz");
//                            break;
//                        case 6:
//                        Console.WriteLine("yay");
//                        break;
//                        case 7:
//                        Console.WriteLine("yay");
//                            break;
//                        case 8:
//                        Console.WriteLine("yay");
//                        break;
//                        case 9:
//                        Console.WriteLine("payiz");
//                        break;
//                        case 10:
//                        Console.WriteLine("payiz");
//                        break;
//                        case 11:
//                        Console.WriteLine("payiz");
//                        break;
//                        case 12:
//                        Console.WriteLine("qish");
//                        break;
//                        default:
//                        Console.WriteLine("duzgun eded daxil et");
//                        break;
//                }

//            }

//            static int multip(int n)
//            {
//                int result = 1;
//                while (n > 0)
//                {
//                    int a = n % 10;
//                    result *= a;
//                    n /= 10;
//                }
//                return result;
//            }

//            static int Market(params int[] arr)
//            {
//                int result = 0;
//                int min = arr[0];
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    if (arr[i] < min)
//                    {
//                        min = arr[i];
//                    }
//                }
//                foreach (var item in arr)
//                {
//                    if (item == min)
//                    {
//                        continue;
//                    }
//                    result += item;
//                }
//                return result;
//            }

//        }
//    }
//}