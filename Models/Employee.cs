
using FluentNHibernate.Conventions.Helpers;
using System;
using System.ComponentModel.DataAnnotations;

namespace Example.Models
{
    public class Employee
    {
     
       [Key]
       public int Id { get; set; }  
       public string FirstName { get; set; }    
       public string LastName { get; set; } 
       public string Payroll_Number { get; set; }   
       public DateTime Date_Of_Birth { get; set; } 
       public int Telephone { get; set; }   
       public int Mobile { get; set; }  
       public string Address { get; set; }  
       public string Address_2 { get; set; }    
       public string PostCode { get; set; } 
       
   
       public string Email_Home { get; set; }   
       public DateTimeOffset Start_date { get; set; } 


    }
}
