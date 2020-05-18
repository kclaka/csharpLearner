using System;
using TestDeconstruct;
using TestDelegate;

namespace csharpLearner
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Rectangle rec = new Rectangle(1.2f, 3.5f);
            (float width, float height) = rec;
            Console.WriteLine(width + " " + height);

            Del handler = DelegateMethod;
            handler("Hello World");

            Transformer t = Square;
            Console.WriteLine(t(3));


            int[] values = {10, 20, 30, 40, 50};
            Transform(values, Square);
            foreach(int i in values)
                Console.Write(i + " ");




        }

        public delegate void Del(string message);

        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public  delegate int Transformer(int x);

        public static int Square(int x)
        {
            return x * x;
        }

        public static int Square(int x, int y)
        {
            return x * y;
        }

        public static void Transform(int[] values, Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }
        }
    }
}

namespace TestDeconstruct
{
    class Rectangle
    {
        public readonly float Width, Height;

        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public void Deconstruct(out float width, out float height)
        {
            width = Width;
            height = Height;
        }
    } 
}

namespace TestDelegate
{

    class util
    {
    }
    
        
    

        
    
}

    

