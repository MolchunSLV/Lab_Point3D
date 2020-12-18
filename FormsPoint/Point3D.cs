using PointLib;
using System;

namespace FormsPoint
{
    [Serializable]
    class Point3D:Point//класс Point3D наследный от Point
    {
        public int Z { get; set; }//объявление переменной 

        public Point3D() : base()
        {
            Z = rnd.Next(10);//присвоение случайного значения z
        }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override double Metric()//метод измерения растояния от начала координат до точки
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public override string ToString()//метод возвращающий положение координаты в виде строки
        {
            return string.Format($"({X} , {Y}, {Z})");
        }


    }
}
