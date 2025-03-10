namespace task2
{
    internal class Program
    {
        interface IShape
        {
            double getArea();
        }
        class Rectangle : IShape
        {
            private double width;
            private double height;
            public Rectangle(double w, double h)
            {
                width = w;
                height = h;
            }
            public double getArea()
            {
                return this.width * this.height;
            }
        }
        class Triangle : IShape
        {
            private double len1, len2, len3;
            public Triangle(double len1, double len2, double len3)
            {
                this.len1 = len1;
                this.len2 = len2;
                this.len3 = len3;
            }
            public double getArea()
            {
                double halfOfPerimeter = (this.len1 + this.len2 + this.len3) / 2;
                return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - this.len1) * (halfOfPerimeter - this.len2) *
                    (halfOfPerimeter - this.len3));
            }
        }
        class Circle : IShape
        {
            private double radius;
            public Circle(double radius)
            {
                this.radius = radius;
            }
            public double getArea()
            {
                return Math.PI * this.radius * this.radius;
            }
        }
        class ShapeFactory
        {
            private static Random random = new Random();
            public static IShape CreateShape()
            {
                int shapeType = random.Next(0, 3);
                switch (shapeType)
                {
                    case 0:
                        double radius = random.Next(1, 10);
                        return new Circle(radius);
                    case 1:
                        double width = random.Next(1, 10);
                        double height = random.Next(1, 10);
                        return new Rectangle(width, height);
                    case 2:
                        double len1, len2, len3;
                        do
                        {
                            len1 = random.Next(1, 10);
                            len2 = random.Next(1, 10);
                            len3 = random.Next(1, 10);
                        } while (!isValidTriangle(len1, len2, len3));
                        return new Triangle(len1, len2, len3);
                    default:
                        throw new InvalidOperationException("未知的形状类型!");
                }
            }
            private static bool isValidTriangle(double a, double b, double c)
            {
                return a + b > c && a + c > b && b + c > a;
            }
        }
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            for(int i = 0; i < 10; i++)
            {
                IShape shape = ShapeFactory.CreateShape();
                shapes.Add(shape);
            }
            double totalArea = 0;
            foreach(IShape shape in shapes)
            {
                totalArea += shape.getArea();
            }
            Console.WriteLine("十个随机图形的总面积为：" + totalArea);
        }
    }
}
