namespace BMI
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double weight;
            double height;
            double bmiFinish;

            Console.WriteLine("BMI tool");
            Console.WriteLine("------------------");
            Console.WriteLine("Tast vægt");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tast højde");
            height = Convert.ToDouble(Console.ReadLine());
            bmiFinish = weight / Math.Pow(height, 2);
            Console.WriteLine("\n\n\n\tDin BMI er: {0}", bmiFinish);
            Console.ReadKey();

        }
    }
}
