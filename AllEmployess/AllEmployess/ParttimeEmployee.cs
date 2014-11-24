using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllEmployess
{
    /// <summary>
    /// Class ParttimeEmployee
    /// 
    /// Description:This is the derived class of type ParttimeEmployee,which extends the base class features.
    /// 
    /// Relation: Inherits the base class Employee.
    /// </summary>
    public class ParttimeEmployee : Employee
    {
        string DateOfHire;
        string DateOfTermination;
        string HourlyRate;

        /// <summary>
        /// public ParttimeEmployee():base()
        /// 
        /// Description: First it valls base class default constructor to set its values.This is the default constructor to set values to empty.
        /// 
        /// </summary>
        public ParttimeEmployee():base()
        {
            DateOfHire = "";
            DateOfTermination = "";
            HourlyRate = "";
            strType = "PT";
        }

        /// <summary>
        /// public ParttimeEmployee(string fName, string lName, string dateOfHire, string dateOfTermination, string hourlyRate): base(fName,lName)
        /// 
        /// Description: Calls the base class's parameterized constructor first,then sets its own values.
        /// </summary>
        /// <param name="fName">first name</param>
        /// <param name="lName">last name</param>
        /// <param name="dateOfHire">date of hire</param>
        /// <param name="dateOfTermination">date of termination</param>
        /// <param name="hourlyRate">hourly rate</param>
        public ParttimeEmployee(string fName, string lName, string dateOfHire, string dateOfTermination, string hourlyRate): base(fName,lName)
        {
            DateOfHire = dateOfHire;
            DateOfTermination = dateOfTermination;
            HourlyRate = hourlyRate;
            strType = "PT";
        }

        /// <summary>
        ///   public bool SetDateOfHire(string dateOfHire)
        ///   
        /// Descritpion: Does the validation first and then sets the value.
        /// </summary>
        /// <param name="dateOfHire">date of hire</param>
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
        /// public bool SetDateOfTermination(string dateofTermination)
        ///      
        /// Description: Does the validation first and then sets the value.
        /// </summary>
        /// <param name="dateofTermination">date of termination</param>
        /// <returns>True: if validation succeeds,else false.</returns>
        public bool SetDateOfTermination(string dateofTermination)
        {
            bool bResult = false;
            if (Validation.BasicValidation.dateValidator(dateofTermination))
            {
                DateOfTermination = dateofTermination;
                bResult = true;
            }
            else
            {
                bResult = false;
            }

            return bResult;
        }

        /// <summary>
        /// public bool SetHourlyRate(string hourlyRate)
        /// 
        /// Descritpion:Does the validation first and then sets the value.
        /// </summary>
        /// <param name="hourlyRate">hourly rate</param>
        /// <returns>True: if validation succeeds,else false.</returns>
        public bool SetHourlyRate(string hourlyRate)
        {
            // if basic validation is true
            if (Validation.BasicValidation.SalaryValidate(hourlyRate))
            {
                HourlyRate = hourlyRate;
                return true;
            }
            //validation fails.
            else
            {
                return false;
            }
        }

        /// <summary>
        ///  public string GetDateOfHire()
        ///  
        /// Description: gets the value of date of hire.
        /// </summary>
        /// <returns>date of hire.</returns>
        public string GetDateOfHire()
        {
            return DateOfHire;
        }

        /// <summary>
        ///  public string GetDateOfTermination()
        ///  
        /// Description: gets the value of date of termination.
        /// </summary>
        /// <returns>date of termination</returns>
        public string GetDateOfTermination()
        {
            return DateOfTermination;
        }

        /// <summary>
        ///  public string GetHourlyRate()
        ///  
        /// Description: gets the value of hourly rate.
        /// </summary>
        /// <returns>hourly rate</returns>
        public string GetHourlyRate()
        {
            return HourlyRate;
        }
    }
}
