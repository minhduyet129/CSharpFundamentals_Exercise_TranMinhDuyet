using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai1
{

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Phone { get; set; }
        public string BirthPlace { get; set; }



    }
    public enum Gender
    {
        Male,
        Female
    }


    class Member : Person
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        

        
    }
    
    
    

    public  class Program
    { 
        
        // IEnumerable<Member> Member1(List<Member> members)
        // {
        //     return members.Where(x => x.DateOfBirth.Year == 1998);
        // }
        // IEnumerable<Member> Member2(List<Member> members)
        // {
        //     return members.Where(x => x.DateOfBirth.Year > 1998);
        // }
        // IEnumerable<Member> Member3(List<Member> members)
        // {
        //     return members.Where(x => x.DateOfBirth.Year < 1998);
        // }
        // IEnumerable<Member> MembersInHaNoi(List<Member> members)
        // {
        //     return members.Where(x => x.BirthPlace.ToUpper().Contains("Ha Noi"));
        // }
        // IEnumerable<Member> Members4(List<Member> members)
        // {
        //     return members.Where(x => x.StartDate < DateTime.Parse("22/03/2021"));
        // }
        // Member GetOldesOneMember(List<Member> members)
        // {
        //     return members.OrderByDescending(x => x.DateOfBirth).FirstOrDefault();
        // }
        // IEnumerable<string> JoinName(List<Member> members)
        // {
        //     return members.Select(x => x.LastName + x.FirstName);
        // }
         
        static void Main(string[] args)
        {
            

            List<Member> abc = new List<Member>(){
            new Member{FirstName="Tran",LastName="Duyet",Gender=Gender.Male,DateOfBirth=DateTime.Parse("1999-09-12"),Phone=0912432264,BirthPlace="Bắc Giang",StartDate=DateTime.Parse("2020-09-12"),EndDate=DateTime.Parse("2021-09-12")},
            new Member{FirstName="Nguyen",LastName="Cuong",Gender=Gender.Male,DateOfBirth=DateTime.Parse("1999-07-12"),Phone=0912322264,BirthPlace="Hà Nội",StartDate=DateTime.Parse("1999-09-02"),EndDate=DateTime.Parse("2022-09-12")},
            new Member{FirstName="Tran",LastName="Tuan",Gender=Gender.Male,DateOfBirth=DateTime.Parse("1996-09-24"),Phone=0912432224,BirthPlace="Hải Dương",StartDate=DateTime.Parse("1999-09-10"),EndDate=DateTime.Parse("2023-09-12")},
            new Member{FirstName="Nguyen",LastName="Nam",Gender=Gender.Male,DateOfBirth=DateTime.Parse("1995-03-12"),Phone=0912412364,BirthPlace="Cao Bằng",StartDate=DateTime.Parse("2002-06-12"),EndDate=DateTime.Parse("2021-04-24")},
            new Member{FirstName="Le",LastName="Hoai",Gender=Gender.Female,DateOfBirth=DateTime.Parse("1998-12-24"),Phone=0956732264,BirthPlace="Bắc Cạn",StartDate=DateTime.Parse("2003-09-12"),EndDate=DateTime.Parse("1999-07-16")},
            new Member{FirstName="Ly",LastName="Duc",Gender=Gender.Male,DateOfBirth=DateTime.Parse("1999-05-06"),Phone=0912494764,BirthPlace="Hà Nam",StartDate=DateTime.Parse("2004-05-12"),EndDate=DateTime.Parse("2020-09-18")},
            new Member{FirstName="Tran",LastName="Van",Gender=Gender.Female,DateOfBirth=DateTime.Parse("1998-02-12"),Phone=0912345664,BirthPlace="Nghệ An",StartDate=DateTime.Parse("2006-04-12"),EndDate=DateTime.Parse("2023-09-11")},
            new Member{FirstName="Vu",LastName="Linh",Gender=Gender.Female,DateOfBirth=DateTime.Parse("1999-04-22"),Phone=0910989884,BirthPlace="Bạc Liêu",StartDate=DateTime.Parse("1999-05-12"),EndDate=DateTime.Parse("2020-09-13")},
            new Member{FirstName="Dao",LastName="Ngoc",Gender=Gender.Female,DateOfBirth=DateTime.Parse("1999-07-21"),Phone=0912342364,BirthPlace="Sơn La",StartDate=DateTime.Parse("2020-07-12"),EndDate=DateTime.Parse("2022-09-23")},
            new Member{FirstName="Dao",LastName="Quan",Gender=Gender.Male,DateOfBirth=DateTime.Parse("1999-04-12"),Phone=01234224264,BirthPlace="Ninh Bình",StartDate=DateTime.Parse("1999-09-21"),EndDate=DateTime.Parse("2022-09-24")},
            new Member{FirstName="Le",LastName="Dung",Gender=Gender.Male,DateOfBirth=DateTime.Parse("1997-09-10"),Phone=0134244264,BirthPlace="Quảng Ninh",StartDate=DateTime.Parse("1999-01-24"),EndDate=DateTime.Parse("2021-09-28")},
            new Member{FirstName="Ly",LastName="Hiep",Gender=Gender.Male,DateOfBirth=DateTime.Parse("1999-09-05"),Phone=0910989864,BirthPlace="Hải Phòng",StartDate=DateTime.Parse("2018-09-06"),EndDate=DateTime.Parse("2021-09-29")}

        };
        Console.WriteLine(abc.ToString());
         //Lay dan ong
         List<Member> male=new List<Member>(){};
         foreach(Member item in abc){
             if(item.Gender==Gender.Male){
                 Console.WriteLine(item.FirstName+" "+item.LastName+" "+item.Gender+" "+item.DateOfBirth+" "+item.Phone+" "+item.BirthPlace);
             }
         }

        //Lay nguoi co tuoi lon nhat
        DateTime AgeOld = DateTime.Now;
         foreach(Member item in abc){
              if(AgeOld>item.DateOfBirth){
                    AgeOld=item.DateOfBirth;
              }
         }
         foreach(Member item in abc){
             if(item.DateOfBirth==AgeOld){
                  Console.WriteLine(item.FirstName+" "+item.LastName+" "+item.Gender+" "+item.DateOfBirth+" "+item.Phone+" "+item.BirthPlace);
             }
         }
         //
         foreach(Member item in abc){
             Console.WriteLine("Full name:"+item.LastName+item.FirstName);
         }
       
        
        
            
           
            }




        }
    }

}
