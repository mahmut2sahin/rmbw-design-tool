using System;

namespace rmbw_design_tool
{
    public class VanDerMeersMethod
    {
        public void Design()
        {
            // Taking inputs from user
            var hs = InputService.AskHs();
            var ts = InputService.AskTs();
            var gamaStone = InputService.AskStoneGama();
            var gamaWater = InputService.AskWaterGama();
            double FaceSlope = InputService.AskFaceSlope();
            var depthAtToe = InputService.AskDepthAtToe();
            double damageLevel = InputService.AskDamageParameter();
            double permeability = InputService.AskPermeability();
            double duration = InputService.AskStormDuration();
            double stoneWeight;

            double hstoe = FindHsToe(ts, hs, depthAtToe);

            double tm = 0.81 * ts;
            double ksiM = (FaceSlope) / Math.Sqrt(((2 * Math.PI) / 9.81) * (hstoe / Math.Pow(tm, 2)));
            double ksiCR = Math.Pow((6.2 * Math.Pow(permeability, 0.31) * Math.Sqrt(FaceSlope)), 1 / (permeability + 0.5));

            if (ksiM < ksiCR)
            {
                Console.WriteLine("PLUNGING CASE!");
                stoneWeight = PurgingCase(hstoe, permeability, damageLevel, duration, tm, ksiM, gamaStone, gamaWater);
            }
            else
            {
                Console.WriteLine("SURGING CASE!");
                stoneWeight = SurgingCase(hstoe, gamaStone, gamaWater, permeability, damageLevel, ksiM, tm, duration, FaceSlope);
            }
            Console.WriteLine("Please enter any button to continue...");
            SectionPropOperations.StoneSizeAtHead(stoneWeight, gamaStone);
            SectionPropOperations.WeightOfUnits(stoneWeight, gamaStone);
            SectionPropOperations.ThicknessesOfLayers(stoneWeight, gamaStone);
            SectionPropOperations.MinCrestWidth(stoneWeight, gamaStone);
        }

        public double SurgingCase(double hstoe, double gamaStone, double gamaWater, double permeability, double damageLevel, double ksiM, double tm, double duration, double faceSlope)
        {
            double n = (duration * 60 * 60) / tm;
            double d50 = hstoe / (((gamaStone / gamaWater) - 1) * 1 * Math.Pow(permeability, -0.13) * Math.Pow(damageLevel / Math.Sqrt(n), 0.2) * Math.Sqrt(1 / faceSlope) * Math.Pow(ksiM, permeability));
            double stoneWeight = gamaStone * Math.Pow(d50, 3);
            Console.WriteLine("Armor stone weight is: {0} tons", Math.Round(stoneWeight, 3));
            Console.WriteLine("Stone size is: {0}", Math.Round(d50, 3));
            Console.WriteLine("Please enter any button to continue...");
            Console.ReadLine();
            return stoneWeight;
        }

        public double PurgingCase(double hstoe, double permeability, double damageLevel, double duration, double tm, double ksiM, double gamaStone, double gamaWater)
        {
            double n = (duration * 60 * 60) / tm;
            double d50 = hstoe / (((gamaStone / gamaWater) - 1) * 6.2 * Math.Pow(permeability, 0.18) * Math.Pow(damageLevel / Math.Sqrt(n), 0.2) * Math.Pow(ksiM, -0.5));
            double stoneWeight = gamaStone * Math.Pow(d50, 3);
            Console.WriteLine("Armor stone weight is: {0} tons", Math.Round(stoneWeight, 3));
            Console.WriteLine("Stone size is: {0}", Math.Round(d50, 3));
            Console.WriteLine("Please enter any button to continue...");
            Console.ReadLine();
            return stoneWeight;
        }

        public double FindHsToe(double ts, double hs, double depthAtToe)
        {
            double tp = 1.05 * ts;
            double lop = 1.56 * Math.Pow(tp, 2);
            double hOverlop = Math.Round(depthAtToe / lop, 3);
            double sop = Math.Round(hs / lop, 3);
            Console.WriteLine("Found h/Lop: {0}, found Sop: {1}", hOverlop, sop);
            while (true)
            {
                try
                {
                    Console.Write("Do necessary interpolation and enter found Hs,toe value: ");
                    double hstoe = Convert.ToDouble(Console.ReadLine());
                    return hstoe;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid input!");
                }
            }
        }
    }
}
