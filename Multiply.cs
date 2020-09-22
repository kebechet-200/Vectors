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

        public static Vector operator *(Vector A, double B) => new Vector(A.X * B, A.Y * B, A.Z * B);
            




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
            Console.WriteLine("Enter the number , for second multiplier : ");
            double B = Convert.ToDouble(Console.ReadLine());
            Vector C = A * B;
            Console.WriteLine($"Vectors X multiply by {B} is : {C[1]}\nVectors Y multiply by {B} is : {C[2]}\nVectors Z multiply by {B} is : {C.Z}");
            return;
        }
    }
}
