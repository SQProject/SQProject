using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCompany
{
    /// <summary>
    /// class EmployeeData
    /// 
    /// Description: This class stores all the valid employees in a list.
    /// </summary>
    public class EmployeeData
    {
        //hold only validated employee objects
        List<AllEmployess.Employee> employees = new List<AllEmployess.Employee>();

        /// <summary>
        ///  public bool AddEmployee(EmployeeData emp1)
        ///  
        /// Descritpion: This function adds an employee in a list,but before adding in a list it checks whether the client with same sin number exists or not because two employees cannot 
        ///             have same sin number.
        /// </summary>
        /// <param name="emp1">instance of an employee to be added</param>
        /// <returns>True: if added, else false.</returns>
        public bool AddEmployee(AllEmployess.Employee emp1)
        {
            //check employee exists or not.
            //comapre sin number

            if (employees.Contains(emp1))
            {
                return false;
            }
            else
            {
                employees.Add(emp1);
                return true;
            }
        }

        /// <summary>
        ///  public bool RemoveEmployee(EmployeeData emp)
        ///  
        /// Description: This function removes the employee form the list by matching the sin number.
        /// </summary>
        /// <param name="emp">instance of an employee</param>
        /// <returns>True:if removed, else false.</returns>
        public bool RemoveEmployee(AllEmployess.Employee emp)
        {
            if (emp == null)
            {
                return true;
            }
            else
            {
                return employees.Remove(emp);
            }
            
        }

        /// <summary>
        /// public bool ModifyEmployee()
        /// 
        /// Description: This function modifies the employee.
        /// </summary>
        /// <returns>True:if it is modified, else false.</returns>
        public bool ModifyEmployee(AllEmployess.Employee e)
        {

            return true;
        }

        /// <summary>
        ///  public bool TraverseList()
        ///  
        /// Description: This fucntion traverse the list containing all employees.
        /// </summary>
        /// <returns>True:if traversed, else false.</returns>
        public bool TraverseList(string strCom)
        {
            foreach (AllEmployess.Employee e in employees)
            {
                if(strCom.CompareTo("Details") == 0)
                {
                    e.Details();
                }
            }
            return true;
        }


        public bool TraverseList(string strCom, string strArg)
        {
            bool bResult = false;

            foreach(AllEmployess.Employee e in employees)
            {
                if(strCom.CompareTo("FindExist") == 0)
                {
                    if(e.GetSocialInsuranceNumber().CompareTo(strArg)  == 0)
                    {
                        bResult = true;
                        break;

                    }
                }
            }

            return bResult;
        }

        public AllEmployess.Employee Find(string strSIN)
        {
           
            foreach(AllEmployess.Employee e in employees)
            {
                if(e.GetSocialInsuranceNumber().CompareTo(strSIN) == 0)
                {
                    return e;
                }
            }
            return new AllEmployess.Employee();
        }
        
    }
}
