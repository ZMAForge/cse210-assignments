class Program
{
    static void Main(string[] args)
    {
        {
            Circle myCircle = new Circle();

            myCircle._radius = 10;

            double area = myCircle.GetArea();
            Console.WriteLine(area);
        }
    }
}
