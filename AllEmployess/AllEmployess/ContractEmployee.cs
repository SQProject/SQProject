using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation;

namespace AllEmployess
{
    /// <summary>
    /// class ContractEmployee
    /// 
    /// Description:Extends the features of a base class by adding its own properties.
    /// 
    /// Relation:Inherits the base class Employee.
    /// </summary>
    public class ContractEmployee : Employee
    {
        string ContractStartDate;
        string ContractStopDate;
        string FixedContractAmount;

        /// <summary>
        /// public ContractEmployee():base()
        /// 
        /// Description:Calls the default constructor of the base class, then sets the properties to be empty.
        /// </summary>
        public ContractEmployee():base()
        {
            ContractStartDate = "";
            ContractStopDate = "";
            FixedContractAmount = "";
            strType = "CT";
        }

        /// <summary>
        /// public ContractEmployee(string fName , string lName ,string contractStartDate,string contractStopDate,string fixedContractAmount):base(fName,lName)
        /// 
        /// Description: Calls the parameterized constructor of base class, then sets its properties values.
        /// </summary>
        /// <param name="fName">first name</param>
        /// <param name="lName">last name</param>
        /// <param name="contractStartDate">contract start date</param>
        /// <param name="contractStopDate">contract stop date</param>
        /// <param name="fixedContractAmount">fixed contract amount</param>
        public ContractEmployee(string fName , string lName ,string contractStartDate,string contractStopDate,string fixedContractAmount):base(fName,lName)
        {
            ContractStartDate = contractStartDate;
            ContractStopDate = contractStopDate;
            FixedContractAmount = fixedContractAmount;
            strType = "CT";
        }

        /// <summary>
        /// public bool SetContractStartDate(string contractStartDate)
        /// 
        /// Description: Does the basic validation and then sets the value.
        /// </summary>
        /// <param name="contractStartDate">contract start date</param>
        /// <returns>True:if validation succeeds, else false.</returns>
        public bool SetContractStartDate(string contractStartDate)
        {
            // if basic validation is true
            if (Validation.BasicValidation.dateValidator(contractStartDate))
            {
                ContractStartDate = contractStartDate;
                return true;
            }
            //validation fails.
            else
            {
                return false;
            }
        }


        /// <summary>
        ///  public bool SetContractStopDate(string contractStopDate)
        ///  
        /// Description: Does the basic validation and then sets the value.
        /// </summary>
        /// <param name="contractStopDate">contract stop date</param>
        /// <returns>True:if validation succeeds, else false.</returns>
        public bool SetContractStopDate(string contractStopDate)
        {
            // if basic validation is true
            if (Validation.BasicValidation.dateValidator(contractStopDate))
            {
                ContractStopDate = contractStopDate;
                return true;
            }
            //validation fails.
            else
            {
                return false;
            }
        }


        /// <summary>
        /// public bool SetFixedContractAmount(string fixedContractAmount)
        /// 
        /// Description: Does the basic validation and then sets the value.
        /// </summary>
        /// <param name="fixedContractAmount">fixed contract amount</param>
        /// <returns>True:if validation succeeds, else false.</returns>
        public bool SetFixedContractAmount(string fixedContractAmount)
        {
            // if basic validation is true
            if (Validation.BasicValidation.SalaryValidate(fixedContractAmount))
            {
                FixedContractAmount = fixedContractAmount;
                return true;
            }
            //validation fails.
            else
            {
                return false;
            }
        }

        /// <summary>
        /// public string GetContractStartDate()
        /// 
        /// Description: gets the contract start date.
        /// </summary>
        /// <returns>contract start date.</returns>
        public string GetContractStartDate()
        {
            return ContractStartDate;
        }

        /// <summary>
        ///  public string GetContractStopDate()
        ///  
        /// Description: gets the value of contract stop date.
        /// </summary>
        /// <returns>contract stop date</returns>
        public string GetContractStopDate()
        {
            return ContractStopDate;
        }

        /// <summary>
        /// public string GetFixedContractAmount()
        /// 
        /// Description:gets the value of fixed contract amount.
        /// </summary>
        /// <returns>fixed contract amount</returns>
        public string GetFixedContractAmount()
        {
            return FixedContractAmount;
        }
    }
}
