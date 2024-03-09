using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8TP
{
    internal class TrianglePyramid
    {
        // Поля класса
        private double baseSide;
        protected internal double height;

        // Конструктор класса
        public TrianglePyramid(double baseSide, double height)
        {
            this.baseSide = baseSide;
            this.height = height;
        }

        // Статический метод для вычисления модуля разности
        private static double ModuloDifference(double a, double b)
        {
            return Math.Abs(a - b);
        }

        // Перегрузка операторов

        public static TrianglePyramid operator -(TrianglePyramid a, TrianglePyramid b)
        {
            double newBaseSide = ModuloDifference(a.baseSide, b.baseSide);
            double newHeight = ModuloDifference(a.height, b.height);
            return new TrianglePyramid(newBaseSide, newHeight);
        }

        public static TrianglePyramid operator *(TrianglePyramid a, double scaleFactor)
        {
            double newHeight = a.height * scaleFactor;
            return new TrianglePyramid(a.baseSide, newHeight);
        }

        public static TrianglePyramid operator /(TrianglePyramid a, double divisor)
        {
            double newHeight = a.height / divisor;
            return new TrianglePyramid(a.baseSide, newHeight);
        }

        public static bool operator ==(TrianglePyramid a, TrianglePyramid b)
        {
            return a.baseSide == b.baseSide && a.height == b.height;
        }

        public static bool operator !=(TrianglePyramid a, TrianglePyramid b)
        {
            return !(a == b);
        }

        // Метод для вывода информации о пирамиде
        public override string ToString()
        {
            return $"Правильная треугольная пирамида с основанием: {baseSide}, и высотой: {height}";
        }
    }
}
