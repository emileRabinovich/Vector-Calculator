using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public float x;
        public float y;
        public float z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public double GetMagnitude()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
        }

        public double GetDirection()
        {
            return Math.Atan(this.y / this.x) * (180 / Math.PI);
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector Negate(Vector v)
        {
            return new Vector(v.x * -1, v.y * -1, v.z * -1);
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector Scale(Vector v, float scalar)
        {
            return new Vector(v.x * scalar, v.y * scalar, v.z * scalar);
        }

        public static Vector Normalize(Vector v1)
        { 
            float magnitude = (float)v1.GetMagnitude();
            return new Vector(v1.x / magnitude, v1.y / magnitude, v1.z / magnitude);
        }

        public static float DotProduct(Vector v1, Vector v2)
        {
            return (v1.x * v2.x + v1.y * v2.y + v1.z * v2.z);
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
           return new Vector(v1.y * v2.z - v1.z * v2.y, v1.z * v2.x - v1.x * v2.z, v1.x * v2.y - v1.y * v2.x);
        }

        public static float AngleBetween(Vector v1, Vector v2)
        {
            return (float)(Math.Acos((v1.x * v2.x + v1.y * v2.y + v1.z * v2.z) / ((MathF.Sqrt((v1.x * v1.x) + (v1.y * v1.y) + (v1.z * v1.z))) * MathF.Sqrt((v2.x * v2.x) + (v2.y * v2.y) + (v2.z * v2.z)))) * (180 / Math.PI));
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            float top = (float)((v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z));
            float bottom = (float)((v2.x * v2.x) + (v2.y * v2.y) + (v2.z * v2.z));
            return new Vector(top * v2.x / bottom, top * v2.y / bottom, top * v2.z / bottom);
        }
    }
}
