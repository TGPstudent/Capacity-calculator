using System;

namespace Capacity_calculator
{
    class Tank4
    {
        private double length;
        private double width;
        private double height;
        private double liquid;

        //Конструктор:
        public Tank4(string SA, string SB, string SH, string SHL)
        {
            if (SA != "") Length = double.Parse(SA.Replace(",", "."));
            else throw new FormatException();

            if (SB != "") Width = double.Parse(SB.Replace(",", "."));
            else throw new FormatException();

            if (SH != "") Height = double.Parse(SH.Replace(",", "."));
            else throw new FormatException();

            if (SHL != "") Liquid = double.Parse(SHL.Replace(",", "."));
            else Liquid = 0;
        }
        //Методи:
        virtual protected double Calculat_V()
        {
            double V = Length * Width * Height;
            return (V);
        }
        virtual protected double Calculat_S()
        {
            double S = 2 * Length * Height + 2 * Width * Height + Length * Width;
            return (S);
        }
        virtual protected double Calculat_VL()
        {
            double VL = Length * Width * (Height-Liquid);
            return (VL);
        }
        virtual public string InArh()
        {
            string inArh;
            if (Liquid != 0)
                inArh = String.Format($" Довжина сторони А: {Length:f3};\n Довжина сторони В: {Width:f3};\n Висота Н: {Height:f3};\n Відстань до рідини H1: {Liquid:f3};");
            else
                inArh = String.Format($" Довжина сторони А: {Length:f3};\n Довжина сторони В: {Width:f3};\n Висота Н: {Height:f3};\n Відстань до рідини H1: - ;");
            return inArh;
        }
        virtual public string OutArh()
        {
            string outArh;
            if (Liquid != 0)
                outArh = String.Format($" Повний об'єм: {Calculat_V():f3}, м куб.;\n Об'єм рідини: {Calculat_VL():f3}, м куб.;\n Площа поверхні: {Calculat_S():f3}, м кв.");
            else
                outArh = String.Format($" Повний об'єм: {Calculat_V():f3}, м куб.;\n Об'єм рідини: - ;\n Площа поверхні: {Calculat_S():f3}, м кв.");
            return outArh;
        }
        virtual public string Print()
        {
            string print;

            if (Liquid != 0)
                print = String.Format($"{Calculat_V():F3}\n{Calculat_S():F3}\n{Calculat_VL():F3}");
            else
                print = String.Format($"{Calculat_V():F3}\n {Calculat_S():F3}");
            return print;
        }
        //Властивості
        public double Length
        {
            get { return (length); }
            set
            {
                if (value > 0) length = value;
                else throw new FormatException();
            }
        }
        public double Width
        {
            get { return (width); }
            set
            {
                if (value > 0) width = value;
                else throw new FormatException();
            }
        }
        public double Height
        {
            get { return (height); }
            set
            {
                if (value > 0) height = value;
                else throw new FormatException();
            }
        }
        public double Liquid
        {
            get { return (liquid); }
            set
            {
                if (value >= 0 && value <= height) liquid = value;
                else throw new FormatException();
            }
        }

    }
}
