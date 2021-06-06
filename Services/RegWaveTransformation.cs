using System;

namespace rmbw_design_tool
{
    public static class RegWaveTransformation
    {
        public static double Transform(double hs, double ts, double depthAtToe)
        {
            var deepWaterLength = 1.56 * Math.Pow(ts, 2);
            Console.WriteLine("d/L0 value is: {0}", depthAtToe / deepWaterLength);
            Console.WriteLine("Read Ks value from GWT! If you read and wrote it, press any button to continue!");
            Console.ReadLine();
            Console.Write("Please enter the read Ks value to here: ");
            double ks = Convert.ToDouble(Console.ReadLine());
            // Kr input from the user
            Console.Write("Please enter the Kr, refraction coefficient: ");
            double kr = Convert.ToDouble(Console.ReadLine());

            return hs * ks * kr;
        }
    }
}
