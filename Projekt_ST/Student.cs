using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ST
{
    public class Student
    {
        
        public Student(int stuentIdd, int userIdd, string imie, string nazwisko, string telefon, char plec, string ulica, string numerdomu,string miasto)
        {
            this.studentId = stuentIdd;
            this.userId = userIdd;
            this.firstName = imie;
            this.lastName = nazwisko;
            this.phone = telefon;
            this.gender = plec;
            this.addressStreet = ulica;
            this.addressNumber = numerdomu;
            this.city = miasto;
        }
        public int studentId { get; set; }
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public char gender { get; set; }
        public string addressStreet { get; set; }
        public string addressNumber { get; set; }
        public string city { get; set; }


    }
}
