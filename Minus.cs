using System;
using System.Security.Cryptography.X509Certificates;

namespace quadFunc
{
  public class Vector
    {
        public Vector(double num1,double num2,double num3)
        {
            X = num1;
            Y = num2;
            Z = num3;
        }
        public static Vector operator -(Vector A, Vector B) 
        {
            Vector C;

            if (A.X < B.X || A.Y < B.Y || A.Z < B.Z)
                throw new Exception("Vector A's values should be greater than B's values");
            else 
            {
                 C = new Vector(A.X - B.X, A.Y - B.Y, A.Z - B.Z);
            }
            return C;
        }/*=> new Vector(A.X - B.X, A.Y - B.Y, A.Z - B.Z);*/


        public double X
        {
            get;
            set;
        }
        public double Y
        {
            get;
            set;
        }
        public double Z
        {
            get;
            set;
        }
        public Double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 1:
                        return X;
                    case 2:
                        return Y;
                    case 3:
                        return Z;
                    default: throw new Exception("Index out of range");
                }
            }
            set
            {
                switch (index)
                {
                    case 1:
                        X = value;
                        break;
                    case 2:
                        Y = value;
                        break;
                    case 3:
                        Z = value;
                        break;
                    default: throw new Exception("Index out of range");
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Vector A = new Vector(47.3, 32, 95.5);
            Vector B = new Vector(20,30,40);
            Vector C = A - B;
            Console.WriteLine($"Vector A's X ({A.X}) minus Vector B's X ({B.X}) is : {C[1]}\nVector A's Y ({A.Y}) minus Vector B's Y ({B.Y}) is : {C[2]}\nVector A's Z ({A.Z}) minus Vector B's Z ({B.Z}) is : {C.Z}");
            return;
        }
    }
}
