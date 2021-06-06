using System;

namespace rmbw_design_tool
{
    public static class SectionPropOperations
    {
        public static void StoneSizeAtHead(double stoneWeight, double gamaStone)
        {
            Console.WriteLine("Stone size required at the head-section: {0} m", Math.Round(1.15 * Math.Pow((stoneWeight / gamaStone), 0.33), 3));
        }

        public static void WeightOfUnits(double stoneWeight, double gamaStone)
        {
            double armourDia = 1.15 * Math.Pow((stoneWeight / gamaStone), 0.33);
            double armourW = Math.Pow(armourDia, 3) * gamaStone;
            double armourFilter = armourW / 10;
            Console.WriteLine("Weight of filter units = {0} tons", Math.Round(armourFilter, 2));
            Console.WriteLine("Weight of core units = {0} tons", Math.Round(armourFilter / 10, 2));
        }

        public static void ThicknessesOfLayers(double weightStone, double gamaStone)
        {
            // Armour
            Console.Write("Please enter number of quarrystone or concrete armor units in the thickness for armour layer (typically 2) = ");
            double numberOfStonesAr = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter layer coefficient for armour layer: ");
            double layerCoefAr = Convert.ToDouble(Console.ReadLine());
            double armourThickness = numberOfStonesAr * layerCoefAr * Math.Pow((weightStone / gamaStone), 0.33);

            // Filter
            Console.Write("Please enter number of quarrystone or concrete armor units in the thickness for filter layer (typically 2) = ");

            double numberOfStonesFilt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter layer coefficient for filter layer: ");
            double layerCoefFilt = Convert.ToDouble(Console.ReadLine());
            double FilterThickness = numberOfStonesAr * layerCoefAr * Math.Pow(((weightStone / 10) / gamaStone), 0.33);

            Console.WriteLine("Thickness of armour layer = {0} m", Math.Round(armourThickness, 2));
            Console.WriteLine("Thickness of filter layer = {0} m", Math.Round(FilterThickness, 2));
        }
        public static void MinCrestWidth(double stoneWeight, double gamaStone)
        {
            Console.Write("Please enter number of quarrystone or concrete armor units in the thickness for crest width (typically 3) = ");
            double numberOfStones = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter layer coefficient for armour layer: ");
            double layerCoef = Convert.ToDouble(Console.ReadLine());

            double crestWidth = numberOfStones * layerCoef * Math.Pow((stoneWeight / gamaStone), 0.33);
            Console.WriteLine("Minimum crest weight = {0} m", Math.Round(crestWidth, 2));
        }

    }
}
