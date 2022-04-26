using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter { 
    //フィートとメートルの単位変換クラス{
   public  class FeetConverter {

        private static double ratio = 0.3048;
        //フィールドからメートルを求める
        public static double FromMeter(double meter)
        {
            return meter / ratio;
        }

        //メートルからフィートを求める
        public static double ToMeter(double feet)
        {
            return feet * ratio;
        }
    }
}
