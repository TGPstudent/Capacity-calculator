using System;

namespace Capacity_calculator
{
    class Tank1
    {
        private double diameter;
        private double height;
        private double liquid;

        //Конструктор:
        public Tank1(string SD, string SH, string SHL)
        {
            if (SD != "") Diameter = double.Parse(SD.Replace(",", "."));
            else throw new FormatException();

            if (SH != "") Height = double.Parse(SH.Replace(",", "."));
            else throw new FormatException();

            if (SHL != "") Liquid = double.Parse(SHL.Replace(",", "."));
            else Liquid = 0;
        }
        //Методи:
        virtual protected double Calculat_V()
        {
            double V = Math.PI * Math.Pow((Diameter / 2), 2) * Height;
            return (V);
        }
        virtual protected double Calculat_S()
        {
            double S = 2 * Math.PI * (Diameter / 2) * Height + Math.PI * Math.Pow((Diameter / 2), 2);
            return (S);
        }
        virtual protected double Calculat_VL()
        {
            double VL = Math.PI * Math.Pow((Diameter / 2), 2) * (Height - Liquid);
            return (VL);
        }

        virtual public string InArh()
        {
            string inArh;
            if (Liquid != 0)
                inArh = String.Format($" Діаметр D = {Diameter:f3};\n Висота Н = {Height:f3};\n До рідини H1 = {Liquid:f3};");
            else
                inArh = String.Format($" Діаметр D = {Diameter:f3};\n Висота Н = {Height:f3};\n До рідини H1 = - ;");
            return inArh;
        }

        virtual public string OutArh()
        {
            string outArh;
            if (Liquid != 0)
                outArh = String.Format($" Повний об'єм: {Calculat_V():f3}, м куб.;\n Об'єм рідини: {Calculat_VL():f3}, м куб.;\n Площа поверхні: {Calculat_S():f3}, м кв.");
            else
                outArh = String.Format($" Повний об'єм: {Calculat_V():f3};\n Об'єм рідини: - ;\n Площа поверхні: {Calculat_S():f3}, м кв.");
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
        public double Diameter
        {
            get { return (diameter); }
            set
            {
                if (value > 0) diameter = value;
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
