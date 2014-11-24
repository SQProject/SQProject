

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation;

namespace AllEmployess
{
    /// <summary>
    /// Class Employee
    /// 
    /// Description: This is a base class which has the firstname, lastname, social insurance number and date fo birth as its properties which can be inherited by all 4 derived class.
    /// It has a default constructor, parameyterized constructor , setters and getters for all properties.It inherits the IEQuatable class, to make the comparison with sin number.
    ///
    /// 
    /// Relation: Base class for all other employee type classes.
    /// 
    /// </summary>
    public class Employee:IEquatable<Employee>
    {

        string FirstName;
        string LastName;
        string SocialInsuranceNumber;
        string DateOfBirth;
        protected string strType;
        

        public string GetType()
        {
            return strType;
        }

        public void SetType(string str)
        {
            strType = str;
        }

        /// <summary>
        /// Employee()
        /// 
        /// Description: Default constructor which initializes the properties to the default values i.e empty. 
        /// </summary>
        public Employee()
        {
            FirstName = "";
            LastName = "";
            SocialInsuranceNumber = "";
            DateOfBirth = "";
            strType = "";
        }

        /// <summary>
        ///  public Employee(string fName,string lName)
        /// 
        /// Description: This is the parameterized constructor which tales the values of the first and last name and sets to it.
        ///  
        /// </summary>
        /// <param name="fName">Contains the first name of an employee.</param>
        /// <param name="lName">Contains the last name of an employee.</param>
        public Employee(string fName,string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        /// <summary>
        /// public bool Equals(Employee emp)
        /// 
        /// Description: This is used to compare the sin number of the employee before doing any operation in List<Employee> used in the container class. 
        /// </summary>
        /// <param name="emp">This can be the instance of any employee type.</param>
        /// <returns>bool value: true if sin matches, else false.</returns>
        public bool Equals(Employee emp)
        {
            if (emp == null)
            {
                return false;
            }
            else
            {
                return (this.SocialInsuranceNumber.Equals(emp.SocialInsuranceNumber));
            }
        }

        /// <summary>
        ///  public bool SetFirstName(string fName)
        ///  
        /// Description: Does the basic validation and then sets the first name of an employee in the property.
        /// </summary>
        /// <param name="fName">Contains the first name of an employee.</param>
        /// <returns>True:if validation succeeds, else false.</returns>
        /// 
        public bool SetFirstName(string fName)
        {
            // if basic validation is true
            if (Validation.BasicValidation.stringValidator(fName))
            {
                FirstName = fName;
                return true;
            }
             //validfation fails.
            else
            {
                return false;
            }
        }

        /// <summary>
        ///  public bool SetLastName(string lName)
        ///  
        /// Description: Does the basic validation and then sets the last name of an employee in the property.
        /// </summary>
        /// <param name="lName">Contains the last name of an employee.</param>
        /// <returns>True:if validation succeeds, else false.</returns>
        public bool SetLastName(string lName)
        {
            // if basic validation is true
            if (Validation.BasicValidation.stringValidator(lName))
            {
                LastName = lName;
                return true;
            }
            //validfation fails.
            else
            {
                return false;
            }
        }

        /// <summary>
        ///  public bool SetSocialInsuranceNumber(string socialInsuranceNumber)
        ///   
        /// Description: Does the basic validation and then sets the sin number of an employee in the property.
        /// </summary>
        /// <param name="socialInsuranceNumber">Contains the social insurance number of an employee.</param>
        /// <returns>True:if validation succeeds, else false.</returns>
        public bool SetSocialInsuranceNumber(string socialInsuranceNumber)
        {
            // if basic validation is true
            if (Validation.BasicValidation.sinValidator(socialInsuranceNumber))
            {
                SocialInsuranceNumber = socialInsuranceNumber;
                return true;
            }
            //validfation fails.
            else
            {
                return false;
            }
        }

        /// <summary>
        ///  public bool SetDateOfBirth(string dateOfBirth)
        ///  
        /// Description: Does the basic validation and then sets the sin number of an employee in the property.
        /// </summary>
        /// <param name="dateOfBirth">Contains the date of birth of an employee.</param>
        /// <returns>True:if validation succeeds, else false.</returns>
        public bool SetDateOfBirth(string dateOfBirth)
        {
            // if basic validation is true
            if (Validation.BasicValidation.dateValidator(dateOfBirth))
            {
                DateOfBirth = dateOfBirth;
                return true;
            }
            //validfation fails.
            else
            {
                return false;
            }
        }

        /// <summary>
        ///  public string GetFirstName()
        ///  
        /// Description: Gets the first anme of an employee.
        /// </summary>
        /// <returns>first name of an employee</returns>
        public string GetFirstName()
        {
            return FirstName;
        }

        /// <summary>
        /// public string GetLastName()
        /// 
        ///  Description: Gets the last name of an employee
        /// </summary>
        /// <returns>last name of an employee</returns>
        public string GetLastName()
        {
            return LastName;
        }

        /// <summary>
        /// public string GetSocialInsuranceNumber()
        /// 
        ///  Description: Gets the social insurance number of an employee.
        /// </summary>
        /// <returns>social insurance number od an employee</returns>
        public string GetSocialInsuranceNumber()
        {
            return SocialInsuranceNumber;
        }

        /// <summary>
        ///  public string GetDateOfBirth()
        ///  
        ///  Description: Gets the date of birth of an employee.
        /// </summary>
        /// <returns>date of birth of an employee</returns>
        public string GetDateOfBirth()
        {
            return DateOfBirth;
        }

        public virtual void Details()
        {

        }
    }
}
