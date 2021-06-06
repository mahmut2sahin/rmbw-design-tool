using System;

namespace rmbw_design_tool
{
    public static class InputService
    {
        public static double AskHs() // DONE!
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the significant wave height in meters, Hs: ");
                    var hs = Convert.ToDouble(Console.ReadLine());
                    return hs;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid wave height!");
                }

            }
        }

        internal static double AskFaceSlope() //DONE
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter structure face slope in xx.yy format, (ex: 3.12)");
                    double faceSlope = Convert.ToDouble(Console.ReadLine());
                    return faceSlope;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid value!");
                }
            }
        }

        public static double AskTs() // DONE!
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the significant wave period in seconds, Ts: ");
                    var ts = Convert.ToDouble(Console.ReadLine());
                    return ts;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid wave period!");
                }
            }
        }

        public static double AskStoneGama() // DONE!
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter unit weight of armor stone in t/m3: ");
                    Console.Write("Unit weight of armor stone in t/m3: ");
                    var stoneW = Convert.ToDouble(Console.ReadLine());
                    return stoneW;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid unit weight!");
                }
            }
        }

        public static double AskWaterGama() // DONE!
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter unit weight of water in t/m3: ");
                    Console.Write("Unit weight of water in t/m3: ");
                    var waterW = Convert.ToDouble(Console.ReadLine());
                    return waterW;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid unit weight!");
                }
            }
        }

        public static double AskBottomSlope() // DONE!
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter bottom of the sea in xx.yy format, (ex: 3.2): ");
                    var bottomSlope = Convert.ToDouble(Console.ReadLine());
                    return bottomSlope;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid bottom slope!");
                }
            }
        }

        public static double AskDepthAtToe() // DONE!
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the depth at the toe of the structure in meters: ");
                    var depthAtToe = Convert.ToDouble(Console.ReadLine());
                    return depthAtToe;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid depth!");
                }
            }
        }

        public static double AskStabilityCoef() // DONE!
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the stability coefficient: ");
                    var stabiityCoef = Convert.ToDouble(Console.ReadLine());
                    return stabiityCoef;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid bottom slope!");
                }
            }
        }

        public static double AskPermeability() // DONE!
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the notional permeability of the structure; the value of this parameter should be: 0.1 ≤ P ≤ 0.6: ");
                    var permeability = Convert.ToDouble(Console.ReadLine());
                    return permeability;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid bottom slope!");
                }
            }
        }

        public static double AskDamageParameter() // DONE!
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the damage parameter: ");
                    var damageParameter = Convert.ToDouble(Console.ReadLine());
                    return damageParameter;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid bottom slope!");
                }
            }
        }

        public static double AskStormDuration() // DONE!
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the duration of the storm in hours: ");
                    var duration = Convert.ToDouble(Console.ReadLine());
                    return duration;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid bottom slope!");
                }
            }
        }
    }
}
