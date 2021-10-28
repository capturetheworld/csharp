using System;


namespace csharp
{

    class Square
     {
        private int length;
        public Square(){
            length = 1;
        }
        public Square(int input){
            length = input;
        }

        public int getLength(){
            return this.length;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // int[] a =  {2,3,4,1,2};
            int[,] a  = {{1,3,6,7,8}, {9,67,32,23,1}};
    
            Console.WriteLine("Length: " + a.GetUpperBound(0));
            Console.WriteLine("Length: " + a.GetUpperBound(1));

            // int[][] jaggedArray2 = new int[][]
            // {
            //     new int[] { 1, 3, 5, 7, 9 },
            //     new int[] { 0, 2, 4, 6 },
            //     new int[] { 11, 22 }
            // };

            Console.WriteLine(Square(4));

            Square aSquare = new Square();
            Console.WriteLine(aSquare.getLength());
            Square bSquare = new Square(243);
            Console.WriteLine(bSquare.getLength());

        }

        static int Square(int i){
            return i*i;
        }
    }
}
