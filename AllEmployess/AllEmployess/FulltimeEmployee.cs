using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllEmployess
{
 /// <summary>
 /// Class FulltimeEmployee
 /// 
 /// Description: It extends the base class by adding some properties of its own.It can access all the abse class's methods and properties.
 /// 
 /// Relation: Inherits the base class Employee.
 /// </summary>
    public class FulltimeEmployee : Employee
    {
        string DateOfHire;
        string DateOfTermination;
        string Salary;

        /// <summary>
        ///  public FulltimeEmployee():base()
        ///   
        /// Description: First it calls the deafault constructor of the base class to set its values.This is the default constructor to initialize the values of properties to empty.
        /// </summary>
        public FulltimeEmployee():base()
        {
            //Setting the properties to empty.
            DateOfHire = "";
            DateOfTermination = "";
            Salary = "";
            strType = "FT";
        }

        /// <summary>
        /// public FulltimeEmployee(string fName , string lName , string dateOfHire , string dateOfTermination , string salary):base(fName,lName)
        /// 
        /// Description: First calls the parameterized constructore of the base class to set its properties.This is the parameterized constructor to store the values in properties.
        /// </summary>
        /// <param name="fName">First name of an employee</param>
        /// <param name="lName">Last name of an employee</param>
        /// <param name="dateOfHire">Date of hire of an employee</param>
        /// <param name="dateOfTermination">Date of termination of an employee</param>
        /// <param name="salary">Salary of an employee</param>
        public FulltimeEmployee(string fName , string lName , string dateOfHire , string dateOfTermination , string salary):base(fName,lName)
        {
            DateOfHire = dateOfHire;
            DateOfTermination = dateOfTermination;
            Salary = salary;
            strType = "FT";
        }

        /// <summary>
        ///  public bool SetDateOfHire(string dateOfHire)
        ///  
        /// Description: Does the validation first and then sets the value.
        /// </summary>
        /// <param name="dateOfHire">date of hire of an employee</param>
        /// <returns>True: if validation succeeds,else false.</returns>
        public bool SetDateOfHire(string dateOfHire)
        {
            // if basic validation is true
            if (Validation.BasicValidation.dateValidator(dateOfHire))
            {
                DateOfHire = dateOfHire;
                return true;
            }
            //validation fails.
            else
            {
                return false;
            }
        }

        /// <summary>
        /// public bool SetDateOfTermination(string dateOfTermination)
        /// 
        /// Descritpion: Does the validation first and then sets the value.
        /// </summary>
        /// <param name="dateOfTermination">date of termination of an employee.</param>
        /// <returns>True: if validation succeeds,else false.</returns>
        public bool SetDateOfTermination(string dateOfTermination)
        {
            // if basic validation is true
            if (Validation.BasicValidation.dateValidator(dateOfTermination))
            {
                DateOfTermination = dateOfTermination;
                return true;
            }
            //validation fails.
            else
            {
                return false;
            }
        }

        /// <summary>
        ///  public bool SetSalary(string salary)
        ///  
        /// Description: Does the validation first and then sets the value.
        /// </summary>
        /// <param name="salary">salary of an employee</param>
        /// <returns>True: if validation succeeds,else false.</returns>
        public bool SetSalary(string salary)
        {
             // if basic validation is true
            if (Validation.BasicValidation.SalaryValidate(salary))
            {
                Salary = salary;
                return true;
            }
            //validation fails.
            else
            {
                return false;
            }
        }

        /// <summary>
        /// public string GetDateOfHire()
        /// 
        /// Description: gets the date of hire of an employee.
        /// </summary>
        /// <returns>date of hire of an employee</returns>
        public string GetDateOfHire()
        {
            return DateOfHire;
        }

        /// <summary>
        /// public string GetDateOfTermination()
        /// 
        /// Description: gets the date of termination of an employee.
        /// </summary>
        /// <returns> date of temrination</returns>
        public string GetDateOfTermination()
        {
            return DateOfTermination;
        }

        /// <summary>
        ///  public string GetSalary()
        ///  
        /// Descritpion:gets the salary of an employee.
        /// </summary>
        /// <returns>salary of an employee</returns>
        public string GetSalary()
        {
            return Salary;
        }

        public override  void Details()
        {
           // string strDetails = "FisrName:";
           //strDetails += GetFirstName();
           //strDetails += ("\n" + "LastName" + GetLastName() + "\n");
            Console.WriteLine("FirstName:           {0}",GetFirstName());
            Console.WriteLine("LastName:            {0}",GetLastName());
            Console.WriteLine("SIN:                 {0}",GetSocialInsuranceNumber());
            Console.WriteLine("DateOfBirth:         {0}",GetDateOfBirth());
            Console.WriteLine("DateOfHire:          {0}",GetDateOfHire());
            Console.WriteLine("DateOfTermination:   {0}",GetDateOfTermination());
            Console.WriteLine("Salary:              {0}",GetSalary());
            
            //return strDetails;
        }

        public bool ValideEmployee()
        {
            return true;
        }
    }
}
