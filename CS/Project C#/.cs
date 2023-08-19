// using System;
// using System.Collections.Generic;
// using System.Windows.Forms;

// namespace Program
// {
// //     interface Iner
// //     {
// //         void ma();
// //     }
// //     class mama : Iner
// //     {
// //         public int aser { get; set; }
// //         public void ma()
// //         {
// //             Console.WriteLine("ma");
// //         }
// //     }
// //     // {https://dl2.tlauncher.org/f.php?f=files%252FTLauncher-2.69-Installer-0.5.2.exe
// //     //class X_and_y
// //     //{
// //     //    public int X = 3423243;
// //     //    public int Y = 323121;
// //     //    public void print()
// //     //    {
// //     //        Console.WriteLine("X:\t" + x + '\nY:\t' + y);
// //     //    }
// //     //}
// //     class men_2
// //     {
// //         public string fname = "men";
// //         public string sname = "men";
// //     }
// //     class Student2 : men_2
// //     {

// //     }
// //     class abstr
// //     {
// //         public const int a = 0;
// //         // public static int a = 0; нельзя
// //         public readonly int b;
// //         public static readonly int a_ = 0;
// //         private int x;
// //         public int X
// //         {
// //             get { return x; }
// //             set { x = value; }
// //         }
// //         private int y;
// //         public int Y
// //         {
// //             get { return y; }
// //             set { y = value; }
// //         }

// //     }
// //     // class point
// //     // {
// //     //     private int _x;
// //     //     private int _y;
// //     //     public point()
// //     //     {

// //     //     }
// //     //     public point(int x, int y)
// //     //     {
// //     //         this._x = x;
// //     //         this._y = y;
// //     //     }
// //     //     public point(point point, int x, int y)
// //     //     {
// //     //         point._x = x;
// //     //         point._y = y;
// //     //     }
// //     //     public void Print()
// //     //     {
// //     //         Console.WriteLine('X : ' + _x + '\nY : ' + _y);
// //     //     }
// //     // }

// //     /////////////////////////////////////////////////////////////////////////////////////////

// //     // class Men
// //     // {
// //     //     public string second_name2;
// //     //     public string first_name2;
// //     //     public string birsday;
// //     //     public void input(second_name,first_name,birsday)
// //     //     {
// //     //         this.second_name2 = second_name;
// //     //         this.first_name2 = first_name;
// //     //         this.birsday = birsday;
// //     //     }
// //     //     public void Print()
// //     //     {
// //     //         Console.WriteLine('Name : '+first_name2+'\nLast name : '+second_name+'\nBirsday : '+birsday);
// //     //     }
// //     // // }

// //     /////////////////////////////////////////////////////////////////////////////////////////////

// //     // class Student
// //     // {
// //     //     public int id = 10;
// //     //     public string first_name = "Yulai";
// //     //     public string second_name = "Nigmatullin";
// //     //     public int age = 11;
// //     //     private int private_permen = 11111;
// //     //     public void Print_id()
// //     //     {
// //     //         Console.WriteLine(id);
// //     //     }
// //     //     private void Print_first_name()
// //     //     {
// //     //         Console.WriteLine(first_name);
// //     //     }
// //     //     public void Print_second_name()
// //     //     {
// //     //         Console.WriteLine(second_name);
// //     //     }
// //     //     private void Print_age()
// //     //     {
// //     //         Console.WriteLine(age);
// //     //     }
// //     //     public void Print_private_permen()
// //     //     {
// //     //         Console.WriteLine(private_permen);
// //     //     }
// //     //     public void Print_studend()
// //     //     {
// //     //         Print_id();
// //     //         Print_age();
// //     //         Print_first_name();
// //     //         Print_private_permen();
// //     //         Print_second_name();
// //     //     }
// //     // }

// //     /////////////////////////////////////////////////////////////////////////////////////////////
// //     class point2d
// //     {
// //         public int x { set; get; }
// //         public int y { set; get; }
// //         public void print2d()
// //         {
// //             Console.WriteLine("x:" + x);
// //             Console.WriteLine("y:" + y);
// //         }
// //         public point2d(int a, int b)
// //         {
// //             Console.WriteLine("hiiiiiii !!!");
// //         }
// //     }
// //     class point3d : point2d
// //     {
// //         public int z { set; get; }
// //         public void print3d()
// //         {
// //             base.print2d();
// //             Console.WriteLine("z:" + z);
// //         }
// //         public point3d() : base(2, 3)
// //         {
// //             Console.WriteLine("hiiiiiiiiiiiiiiiiiiiiiiiiiiii !!!");
// //         }
// //     }
// //     class config
// //     {
// //         public string configuration_2()
// //         {
// //             return "local db";
// //         }
// //     }
// //     static class myclass
// //     {
// //         public static void print(string a)
// //         {
// //             Console.WriteLine(a);
// //         }
// //     }
// //     class db
// //     {
// //         private static string configuration;
// //         static db()
// //         {
// //             config configs = new config();
// //             configuration = configs.configuration_2();
// //             Console.WriteLine("well");
// //         }

// //     }

//     class programm
//     {
// //         //struct programms
// //         //{
// //         //    public decimal x;
// //         //    public decimal y;
// //         //    public decimal z;
// //         //}
// //         //static void out_(out programms value)
// //         //{
// //         //    value.x = 11m;
// //         //    value.y = 12m;
// //         //    value.z = 13m;
// //         //}
// //         //static void in_out(in programms value)
// //         //{
// //         //}
// //         //static void print(programms value)
// //         //{
// //         //}
// //         //static void Bar(object obj)
// //         //{
// //         //    if (obj is X_and_y X_and_y)
// //         //    {
// //         //        X_and_y.print();
// //         //    }
// //         //}
// //         //static void Foo(object obj)
// //         //{
// //         //    X_and_y X_and_y = obj as X_and_y;
// //         //    if (X_and_y != null)
// //         //    {
// //         //        X_and_y.print();
// //         //    }
// //         //}
//         static void Main()
//         {
//             Application.EnableVisualstyles();
//             Application.SetCompatibleTextRenderingDefault(false);
//             Application.Run(new Form1());
// //             // abstr abstr = new abstr();
// //             // abstr.Y = 0;
// //             // int a = abstr.Y;
// //             // int? b = null;
// //             point2d d2 = new point2d(2, 2);
// //             point3d d3 = new point3d();
// //             mama d100 = new mama();
// //             d100.aser = 2;
// //             Console.WriteLine(d100.aser);
// //             d3.print3d();
// //             db d4 = new db();
// //             // myclass.print("wtf");
// //             Console.WriteLine(System.Math.PI);
// //             Console.WriteLine(System.Math.E);
// //             // point value;
// //             // value.x = 2m;
// //             // value.y = 1m;
// //             // value.z = 3m;
// //             // object X_and_y = new X_and_y();
// //             // Foo(X_and_y);
// //             // Bar(X_and_y);
// //             // in_out(value);
//         }
//     }

// //     /////////////////////////////////////////////////////////////////////////////////////////////

// //     // class programm
// //     // {
// //     //     static void Main()
// //     //     {
// //     //         Random random = new Random();
// //     //         int[,,] Array = new int[2, 2, 2];
// //     //         for (int i = 0; i < Array.GetLength(0); i++)
// //     //         {
// //     //             for (int j = 0; j < Array.GetLength(1); j++)
// //     //             {
// //     //                 for (int k = 0; k < Array.GetLength(2); k++)
// //     //                 {
// //     //                     Array[i, j, k] = random.Next(100);
// //     //                 }
// //     //             }
// //     //         }
// //     //         Console.WriteLine("==================================");

// //     //         for (int i = 0; i < Array.GetLength(0); i++)
// //     //         {
// //     //             for (int j = 0; j < Array.GetLength(1); j++)
// //     //             {
// //     //                 for (int k = 0; k < Array.GetLength(2); k++)
// //     //                 {
// //     //                     Console.Write(Array[i, 0, 0]);
// //     //                     Console.WriteLine('');
// //     //                     Console.Write(Array[0, j, 0]);
// //     //                     Console.WriteLine('');
// //     //                     Console.Write(Array[0, 0, k]);
// //     //                     Console.WriteLine('');
// //     //                 }
// //     //             }
// //     //         }
// //     //         Console.WriteLine("==================================");
// //     //     }
// //     // }

// //     /////////////////////////////////////////////////////////////////////////////////////////////

// //     // class program{
// //     //     static void Add_in_first(ref int[] arr, int value)
// //     //     {
// //     //         insert(ref arr,value,0);
// //     //     }
// //     //     static void insert(ref int[] arr, int value , int id)
// //     //     {
// //     //         int[] newarr = new int[arr.GetLength(0) + 1];
// //     //         newarr[id] = value;
// //     //         for (int i = 0; i < id; i++)
// //     //             newarr[i] = arr[i];

// //     //         arr = newarr;
// //     //     }

// //     //     static int idof(int[] arr, int value)
// //     //     {
// //     //         for (int i = 0; i < arr.GetLength(0); i++)
// //     //         {
// //     //             if (arr[i]==value)
// //     //             {
// //     //                 return i;
// //     //             }
// //     //         }
// //     //         return -1;
// //     //     }
// //     //     static void resize(ref int[] arr, int size)
// //     //     {
// //     //         int[] newarr = new int[size];
// //     //         for (int i = 0; i < arr.GetLength(0) &&  i < newarr.GetLength(0); i++)
// //     //             newarr[i] = arr[i];
// //     //         arr = newarr;
// //     //     }
// //     //     static void Main()
// //     //     {
// //     //         int[] arr1 = {1,11,111};
// //     //         idof(arr1,11);
// //     //         Console.WriteLine();
// //     //         for (int i = 0; i < arr1.GetLength(0); i++)
// //     //         {
// //     //             Console.WriteLine(arr1[i]);
// //     //         }

// //     //         double a = 9.056;
// //     //         float b = (float)a;

// //     //         // так незьзя
// //     //         // string a = "5";
// //     //         // float b = (float)a;

// //     //         // string a1 = "2.22";
// //     //         // float b1 = Convert.ToInt(a1);

// //     //         Console.WriteLine();
// //     //         Console.WriteLine(b);
// //     //         // Console.WriteLine(b1);

// //     //         byte aggre = 254;
// //     //         byte democra = 34;
// //     //         aggre = (byte)(aggre+democra);
// //     //         Console.WriteLine(aggre);
// //     //     }
// //     // }

// //     /////////////////////////////////////////////////////////////////////////////////////////////

// //     // class programm1
// //     // {
// //     //     static void Main()
// //     //     {
// //     //         Random random = new Random();
// //     //         int[][][] Array = new int[random.Next(3, 6)][][];
// //     //         for (int i = 0; i < Array.GetLength(0); i++)
// //     //         {
// //     //             Array = new int[][random.Next(3, 6)][];
// //     //             for (int j = 0; j < Array.GetLength(1); j++)
// //     //             {
// //     //                 Array = new int[][][random.Next(3, 6)];
// //     //                 for (int k = 0; k < Array.GetLength(2); k++)
// //     //                 {
// //     //                     Array[i]
// //     //                     [j][k] = random.Next(100);
// //     //                 }
// //     //             }
// //     //         }
// //     //         Console.WriteLine("==================================");

// //     //         for (int i = 0; i < Array.GetLength(0); i++)
// //     //         {
// //     //             for (int j = 0; j < Array.GetLength(1); j++)
// //     //             {
// //     //                 for (int k = 0; k < Array.GetLength(2); k++)
// //     //                 {
// //     //                     Console.Write(Array[i][j][k]);
// //     //                 }
// //     //             }
// //     //         }
// //     //         Console.WriteLine('==================================');
// //     //     }
// //     // }

// //     /////////////////////////////////////////////////////////////////////////////////////////////
// }