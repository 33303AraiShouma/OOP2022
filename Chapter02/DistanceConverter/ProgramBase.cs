namespace DistanceConverter {
    internal class ProgramBase {
        private static void PrintFeetToMeterList(int start, int stop)
        {
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = FeetToMeter(feet);
                Console.WriteLine("{0} ft ={1:0.0000}m", feet, meter);
            }

        }

        //フィートからメートルを求める
        private static void PrintFeetToMeterList(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = FeetToMeter(meter);
                Console.WriteLine("{0} ft ={1:0.0000}m", meter, feet);
            }

        }
    }
}