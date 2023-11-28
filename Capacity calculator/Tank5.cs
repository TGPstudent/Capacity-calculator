using System;

namespace Capacity_calculator
{
    class Tank5 : Tank4
    {
        private double height_cone;
        //Конструктор
        public Tank5(string SA, string SB, string SH, string SHL, string SCH) : base(SA, SB, SH, SHL)
        {
            if (SA != "") Length = double.Parse(SA.Replace(",", "."));
            else throw new FormatException();

            if (SB != "") Width = double.Parse(SB.Replace(",", "."));
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
            double V = base.Calculat_V() + (Length * Width * Height_cone) / 3;
            return (V);
        }
        protected override double Calculat_S()
        {
            double S = base.Calculat_S() + Length * Math.Sqrt(Math.Pow((Width / 2), 2) + Math.Pow((Height_cone), 2)) + Width * Math.Sqrt(Math.Pow((Length / 2), 2) + Math.Pow((Height_cone), 2));
            return (S);
        }
        protected override double Calculat_VL()
        {
            double VL = base.Calculat_VL() + (Length * Width * Height_cone) / 3;
            return (VL);
        }

        public override string InArh()
        {
            string inArh = base.InArh() + String.Format($"\n Висота конусу H2: {Height_cone:f3};");
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
