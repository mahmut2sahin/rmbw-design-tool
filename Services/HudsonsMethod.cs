using System;

namespace rmbw_design_tool
{
    public class HudsonsMethod
    {
        public void Design()
        {
            // Taking inputs from user
            var hs = InputService.AskHs();
            var ts = InputService.AskTs();
            var gamaStone = InputService.AskStoneGama();
            var gamaWater = InputService.AskWaterGama();
            double sr = gamaStone / gamaWater;
            double FaceSlope = InputService.AskFaceSlope();
            var depthAtToe = InputService.AskDepthAtToe();
            double stoneWeight;

            double heightAtToe = RegWaveTransformation.Transform(hs, ts, depthAtToe);

            if (heightAtToe / depthAtToe < 0.6)
            {
                Console.WriteLine("NON-BREAKING WAVES CASE!");
                Console.WriteLine("Please press any button to continue!");
                Console.ReadLine();
                stoneWeight = NonBreakingCase(heightAtToe, gamaStone, sr, FaceSlope);
            }
            else
            {
                Console.WriteLine("BREAKING WAVES CASE!");
                Console.WriteLine("Please press any button to continue!");
                Console.ReadLine();
                stoneWeight = BreakingCase(gamaStone, sr, FaceSlope, depthAtToe);
            }
            Console.WriteLine("Armor stone weight = {0} tons", Math.Round(stoneWeight, 2));
            Console.WriteLine("Please enter any button to continue...");
            Console.ReadLine();

            SectionPropOperations.StoneSizeAtHead(stoneWeight, gamaStone);
            SectionPropOperations.WeightOfUnits(stoneWeight, gamaStone);
            SectionPropOperations.ThicknessesOfLayers(stoneWeight, gamaStone);
            SectionPropOperations.MinCrestWidth(stoneWeight, gamaStone);
        }

        public static double BreakingCase(double gamaStone, double sr, double faceSlope, double depthAtToe)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please read Kd, design coefficient, from the table and enter here: ");
                    double kd = Convert.ToDouble(Console.ReadLine());
                    double hDesign = 0.78 * depthAtToe;
                    double stoneWeight = (gamaStone * Math.Pow(hDesign, 3) * faceSlope) / (Math.Pow((sr - 1), 3) * kd);
                    return stoneWeight;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid input!");
                }
            }
        }

        public static double NonBreakingCase(double heightAtToe, double gamaStone, double sr, double faceSlope)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please read Kd, design coefficient, from the table and enter here: ");
                    double kd = Convert.ToDouble(Console.ReadLine());
                    double hDesign = 1.27 * heightAtToe;
                    double stoneWeight = (gamaStone * Math.Pow(hDesign, 3) * faceSlope) / (Math.Pow((sr - 1), 3) * kd);
                    return stoneWeight;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid input!");
                }
            }
        }
    }
}
