// using System;

// namespace JaggedArray {
//     class Program {
//         static void Main(string[] args) {
            
//             // create a jagged array
//             int [][] jaggedArray = {
//                 new int[] {1,3,5},
//                 new int[] {2,4},
//             };

//             // print elements of jagged array
//             Console.WriteLine("jaggedArray[1][0]: " + jaggedArray[1][0]);
//             Console.WriteLine("jaggedArray[1][1]: " + jaggedArray[1][1]);
//             Console.WriteLine("jaggedArray[0][2]: " + jaggedArray[0][2]);

//             Console.ReadLine();
//         }
//     }
// }

// using System;

// namespace JaggedArray {
//     class Program {
//         static void Main(string[] args) {
            
//             // declare a jagged array
//             int[][] jaggedArray = new int[2][];

//             // set size of Jagged Array Elements
//             jaggedArray[0] = new int[3];
//             jaggedArray[1] = new int[2];

//             // initialize the first array
//             jaggedArray[0][0] = 1;
//             jaggedArray[0][1] = 3;
//             jaggedArray[0][2] = 5;
            
//             // initialize the second array
//             jaggedArray[1][0] = 2;
//             jaggedArray[1][1] = 2;

//             // outer for loop
//             for (int i = 0; i < jaggedArray.Length; i++) {

//                 Console.Write("Element " + i + ": ");
//                 // inner for loop
//                 for(int j = 0; j < jaggedArray[i].Length; j++) {
//                     Console.Write(jaggedArray[i][j] + " ");
//                 }
//                 Console.WriteLine();
//             }
//             Console.ReadLine();
//         }
//     }
// }

using System;

namespace JaggedArray  {
  class Program {
    static void Main(string[] args)  {
  	 
      // declare and initialize jagged array with 2D array
      int[][,] jaggedArray = new int[3][ , ]  {
          new int[ , ] { {1, 8}, {6, 7} },
          new int[ , ] { {0, 3}, {5, 6}, {9, 10} },
          new int[ , ] { {11, 23}, {100, 88}, {0, 10} }
      };

      Console.WriteLine(jaggedArray[0][0, 1]);
      Console.WriteLine(jaggedArray[1][2, 1]);
      Console.WriteLine(jaggedArray[2][1, 0]);

      Console.ReadLine();
    }    
  }
}