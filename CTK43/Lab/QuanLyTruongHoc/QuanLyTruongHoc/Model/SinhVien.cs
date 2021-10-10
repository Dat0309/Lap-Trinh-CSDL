using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Model
{
    public class SinhVien
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public SinhVien()
        {
        }

        public SinhVien(string studentID, string firstName, string lastName, bool gender, DateTime birthDay, string phoneNumber, string address)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            BirthDay = birthDay;
            PhoneNumber = phoneNumber;
            Address = address;
        }
        
    }
}
