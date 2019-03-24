using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Management_System
{
    class BMO
    {
        private double sehir;
        private double dil;
        private double akademikDerece;
        private double yoneticilikGorevi;
        private double aile;
        private double deneyim;

        public double Sehir
        {
            get { return sehir; }
            set { sehir = value; }
        }
        public double Dil
        {
            get { return dil; }
            set { dil = value; }
        }
        public double AkademikDerece
        {
            get { return akademikDerece; }
            set { akademikDerece = value; }
        }
        public double YoneticilikGorevi
        {
            get { return yoneticilikGorevi; }
            set { yoneticilikGorevi = value; }
        }
        public double Aile
        {
            get { return aile; }
            set { aile = value; }
        }
        public double Deneyim
        {
            get { return deneyim; }
            set { deneyim = value; }
        }

        public double CalculateBMO()
        {
            double result = 0;
            if (deneyim==0)
            {
                result = 0;
            }
            if (deneyim == 1)
            {
                result += 0.6;
            }
            if (deneyim==2)
            {
                result += 1;
            }
            if (deneyim==3)
            {
                result += 1.2;
            }
            if (deneyim==4)
            {
                result += 1.35;
            }
            if (deneyim==5)
            {
                result += 1.5;
            }
            if (sehir==0)
            {
                result += 0.15;
            }
            if (sehir == 1||sehir==2)
            {
                result += 0.1;
            }
            if (sehir == 3|| sehir==4)
            {
                result += 0.05;
            }
            if (sehir == 5 || sehir == 6 || sehir == 7 || sehir == 8 || sehir == 9 || sehir == 10)
            {
                result += 0.03;
            }
            if (sehir == 11 )
            {
                result += 0;
            }
            if (akademikDerece==0)
            {
                result += 0.10;
            }
            if (akademikDerece == 1)
            {
                result += 0.30;
            }
            if (akademikDerece == 2)
            {
                result += 0.35;
            }
            if (akademikDerece == 3)
            {
                result += 0.05;
            }
            if (akademikDerece == 4)
            {
                result += 0.15;
            }
            if (yoneticilikGorevi==0)
            {
                result += 0.5;
            }
            if (yoneticilikGorevi == 1)
            {
                result += 0.75;
            }
            if (yoneticilikGorevi == 2)
            {
                result += 0.85;
            }
            if (yoneticilikGorevi == 3)
            {
                result += 1;
            }
            if (yoneticilikGorevi == 4)
            {
                result += 0.4;
            }
            if (yoneticilikGorevi == 5)
            {
                result += 0.6;
            }

            result += aile + dil;

            return result + 1;
        }
    }
}
