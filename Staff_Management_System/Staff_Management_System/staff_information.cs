using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Management_System
{
    class staff_information
    {
        private string id;
        private string name;
        private string surname;
        private string addres;
        private string salary;
        private BMO bmo=new BMO();

        public staff_information()
        {
            id = "";
            name = "";
            surname = "";
            addres = "";
            salary = "";
            bmo.Deneyim =0.0;
            bmo.AkademikDerece = 0.0;
            bmo.Aile = 0.0;
            bmo.Dil = 0.0;
            bmo.Sehir = 0.0;
            bmo.YoneticilikGorevi = 0.0;
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Addres
        {
            get { return addres; }
            set { addres = value; }
        }
        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public double BmoSehir
        {
            get { return bmo.Sehir; }
            set { bmo.Sehir = value; }
        }
        public double BmoDil
        {
            get { return bmo.Dil; }
            set { bmo.Dil = value; }
        }
        public double BmoAkademikDerece
        {
            get { return bmo.AkademikDerece; }
            set { bmo.AkademikDerece = value; }
        }
        public double BmoYoneticilikGorevi
        {
            get { return bmo.YoneticilikGorevi; }
            set { bmo.YoneticilikGorevi = value; }
        }
        public double BmoAile
        {
            get { return bmo.Aile; }
            set { bmo.Aile = value; }
        }
        public double BmoDeneyim
        {
            get { return bmo.Deneyim; }
            set { bmo.Deneyim = value; }
        }

        public double calculateBmo()
        {
            salary=(bmo.CalculateBMO()*4500).ToString();
            return bmo.CalculateBMO();
            
        }
        public string getStaff()
        {
            string staff = "";
            staff = id + "," + name + "," + surname + "," + addres + "," + salary;
            return staff;
        }
    }
}
