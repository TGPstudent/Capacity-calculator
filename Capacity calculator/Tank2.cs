using System;

namespace Capacity_calculator
{
    class Tank2 : Tank1
    {
        private double height_cone;

        //Конструктор:
        public Tank2(string SD, string SH, string SHL, string SCH) : base(SD, SH, SHL)
        {
            if (SD != "") Diameter = double.Parse(SD.Replace(",", "."));
            else throw new FormatException();

            if (SH != "") Height = double.Parse(SH.Replace(",", "."));
            else throw new FormatException();

            if (SHL != "") Liquid = double.Parse(SHL.Replace(",", "."));
            else Liquid = 0;

            if (SCH != "") Height_cone = double.Parse(SCH.Replace(",", "."));
            else throw new FormatException();
        }

        //Методи:
        protected override double Calculat_V()
        {
            double V = ((Math.PI * Math.Pow((this.Diameter / 2), 2) * Height_cone) / 3) + base.Calculat_V();
            return (V);
        }
        protected override double Calculat_S()
        {
            double S = Math.PI * (this.Diameter / 2) * Math.Sqrt(Math.Pow((this.Diameter / 2), 2) + Math.Pow(Height_cone, 2)) + base.Calculat_S();
            return (S);
        }
        protected override double Calculat_VL()
        {
            double VL = ((Math.PI * Math.Pow((this.Diameter / 2), 2) * Height_cone) / 3) + base.Calculat_VL();
            return (VL);
        }

        public override string InArh()
        {
            string inArh = base.InArh() + String.Format($"\n Висота конусу Н2: {Height_cone:f3}");
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
    }
}
