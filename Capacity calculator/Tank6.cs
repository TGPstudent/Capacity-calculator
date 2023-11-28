using System;

namespace Capacity_calculator
{
    class Tank6 : Tank4
    {
        private double height_cone;
        private double length_cone;
        private double width_cone;

        //Конструктор
        public Tank6(string SA, string SB, string SH, string SHL, string SCH, string SCA, string SCB) : base(SA, SB, SH, SHL)
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

            if (SCA != "") Length_cone = double.Parse(SCA.Replace(",", "."));
            else throw new FormatException();

            if (SCB != "") Width_cone = double.Parse(SCB.Replace(",", "."));
            else throw new FormatException();
        }

        //Методи:
        protected override double Calculat_V()
        {
            double V = base.Calculat_V() + (Height_cone * (Length * Width + Math.Sqrt(Length * Width * Length_cone * Width_cone) + Length_cone * Width_cone)) / 3;
            return (V);
        }
        protected override double Calculat_S()
        {
            double S = base.Calculat_S() + (Length + Length_cone) * Math.Sqrt(Math.Pow((Width - Width_cone) / 2, 2) + Math.Pow(Height_cone, 2) - (Math.Pow((Length - Length_cone)/2, 2))) + (Width + Width_cone) * Math.Sqrt(Math.Pow((Length - Length_cone) / 2, 2) + Math.Pow(Height_cone, 2) - (Math.Pow((Width - Width_cone)/2, 2)));
            return (S);
        }

        protected override double Calculat_VL()
        {
            double VL = base.Calculat_VL() + (Height_cone * (Length * Width + Math.Sqrt(Length * Width * Length_cone * Width_cone) + Length_cone * Width_cone)) / 3;
            return (VL);
        }

        public override string InArh()
        {
            string inArh = base.InArh() + String.Format($"\n Висота конусу H2: {Height_cone:f3};\n Довжина основи А1: {Length_cone:f3}; \n Ширина основи В1: {Width_cone:f3}");
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
        public double Length_cone
        {
            get { return (length_cone); }
            set
            {
                if (value > 0 && value< Length) length_cone = value;
                else throw new FormatException();
            }
        }
        public double Width_cone
        {
            get { return (width_cone); }
            set
            {
                if (value > 0 && value < Width) width_cone = value;
                else throw new FormatException();
            }
        }
    }
}