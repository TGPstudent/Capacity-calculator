using System;

namespace Capacity_calculator
{
    class Tank3 : Tank1
    {
        private double height_cone;
        private double diametr_cone;

        //Конструктор:
        public Tank3(string SD, string SH, string SHL, string SCH, string SDl) : base(SD, SH, SHL)
        {
            if (SD != "") Diameter = double.Parse(SD.Replace(",", "."));
            else throw new FormatException();

            if (SH != "") Height = double.Parse(SH.Replace(",", "."));
            else throw new FormatException();

            if (SHL != "") Liquid = double.Parse(SHL.Replace(",", "."));
            else Liquid = 0;

            if (SCH != "") Height_cone = double.Parse(SCH.Replace(",", "."));
            else throw new FormatException();

            if (SDl != "") Diametr_cone = double.Parse(SDl.Replace(",", "."));
            else throw new FormatException();
        }

        //Методи:
        protected override double Calculat_V()
        {
            double V = base.Calculat_V() + (Math.PI * Height_cone * (Math.Pow((Diameter / 2), 2) + ((Diameter * Diametr_cone) / 2) + Math.Pow((Diametr_cone / 2), 2)) / 3);
            return (V);
        }
        protected override double Calculat_S()
        {
            double S = base.Calculat_S() + Math.PI * ((Diameter / 2) + (Diametr_cone / 2)) * Math.Sqrt(Math.Pow(((Diameter - Diametr_cone) / 2), 2) + Math.Pow(Height_cone, 2));
            return (S);
        }
        protected override double Calculat_VL()
        {
            double VL = base.Calculat_VL() + (Math.PI * Height_cone * (Math.Pow((Diameter / 2), 2) + ((Diameter * Diametr_cone) / 2) + Math.Pow((Diametr_cone / 2), 2)) / 3);
            return (VL);
        }
        public override string InArh()
        {
            string inArh = base.InArh() + String.Format($"\n Висота конусу Н2: { Height_cone:f3};\n Діаметр витоку D1 {Diametr_cone:f3}");
            return inArh;
        }
        public override string OutArh()
        {
            string outArh = base.OutArh();
            return outArh;
        }
        public override string Print()
        {
            string print = base.Print();
            return print;
        }
        //Властивості
        public double Height_cone
        {
            get { return (height_cone); }
            set
            {
                if (value > 0) height_cone = value;
                else throw new FormatException();
            }
        }
        public double Diametr_cone
        {
            get { return (diametr_cone); }
            set
            {
                if (value > 0 && value < Diameter) diametr_cone = value;
                else throw new FormatException();
            }
        }
    }
}
