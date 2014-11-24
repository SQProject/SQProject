///FILE         :UIMenu.cs
///PROJECT      :INFO2180-SQ
///PROGRAMMER   :Xiaodong Meng
///
///FIRST VERSION:20/11/2014
///
///Description: This class it interface between user and the data. It has the information of each employee class, contain  
///             a reference to the company class . It also can access the FILEIO class to read data from local file and save data to
///             local file.
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllEmployess;

namespace UIMenu
{
    class UIMenu
    {
        enum Operations
        {
            OPERATION_NONE = 0,
            OPERATION_CREATE,
            OPERATION_MODIFY
        }

        enum EmployeeType
        {
            EMPLOYEE_NONE = 0,
            EMPLOYEE_FULLTIME,
            EMPLOYEE_PARTTIME,
            EMPLOYEE_CONTRACT,
            EMPLOYEE_SEASONAL
        }

        TheCompany.EmployeeData EmployeeContainer;


        public void SetEmployeeContainer(ref TheCompany.EmployeeData con)
        {
            EmployeeContainer = con;
        }
        /// <summary>
        /// Function        :DisplayMainMenu
        /// Description     : This function used to show the Main menu to the user.
        /// 
        /// Parameters      : void
        /// 
        /// Return          :void
        /// </summary>
        private void DisplayMainMenu()
        {
            Console.Clear();
            DisplayNavi_Head("Main");
            Console.WriteLine("1. Manage EMS DBase files");
            Console.WriteLine("2. Manage Employee");
            Console.WriteLine("9. Quit");
        }
        
        /// <summary>
        /// Function        :DisplayFileManMenu
        /// Description     :This function is used to diplay the File operation menu. User can chose option to get data from a local file or \
        ///                    or save data to a local file.
        /// 
        /// 
        /// Parameters      :void
        /// 
        /// Return          :void
        /// </summary>
        private void DisplayFileManMenu()
        {
            Console.Clear();
            DisplayNavi_Head("Main > File Management");
            Console.WriteLine("1. Load EMS DBase from file");
            Console.WriteLine("2. Save Employee Set to EMS DBase file");
            Console.WriteLine("9. Return to MainMenu");

        }


        /// <summary>
        /// Function        :DisplayEmployeeMainMenu
        /// Description     :This function used to Display the Employee Main Menu. User can Display Employset, create new employee
        ///                 , modify employee, and modify an existing employee and remove existing employee.
        /// 
        /// 
        /// Parameters      :void 
        /// 
        /// Return          :void
        /// </summary>
        private void DisplayEmployeeMainMenu()
        {
            Console.Clear();
            DisplayNavi_Head("Main > Employee Management");
            Console.WriteLine("1. Display Employee Set");
            Console.WriteLine("2. Create a NEW Employee");
            Console.WriteLine("3. Modify an EXISTING Employee");
            Console.WriteLine("4. Remove an EXISTING Employee");
            Console.WriteLine("9. Return to Main menu");
        }


        /// <summary>
        /// Function        :
        /// Description     :
        /// 
        /// 
        /// Parameters      :
        /// 
        /// Return          :
        /// </summary>
        private void DisplayEmployeeDetailMenu(int nOperation, int nEmployType)
        {
            Console.Clear();

            if (nOperation == (int)Operations.OPERATION_CREATE)
            {
                DisplayNavi_Head("Main > Employee Details > Create Employee");
                Console.WriteLine("1.Specify Base Employee Details");

              
            }
            else if (nOperation == (int)Operations.OPERATION_MODIFY)
            {
                DisplayNavi_Head("Main > Employee Details > Modify Employee");
                Console.WriteLine("1.Specify Base Employee Details");
            }

            DisplayChildAttri(nOperation, nEmployType);
            
            Console.WriteLine("9. Return to Main menu");
        }


        /// <summary>
        /// Function        :DisplayChildAttri
        /// Description     :
        ///                    This function used to disploy the attributions in the childclass. It depends on the type of the employee class. 
        /// 
        /// Parameters      :
        ///                     void
        /// Return          :   void
        /// </summary>          
        private void DisplayChildAttri(int nOperation,int nEmployType)
        {
            //undo
                //if(nOperation ==(int)Operations.OPERATION_CREATE)
                //{

                //}
                //else if(nOperation == (int)Operations.OPERATION_MODIFY)
                //{

                //}
                switch(nEmployType)
                {
                    case 1: //Fulltime
                        Console.WriteLine("2.Specify DateOfBirth");
                        Console.WriteLine("3.Specify DateOfTermintation");
                        Console.WriteLine("4.Specify Salary");
                        break;
                    case 2://Partime
                        Console.WriteLine("2.Specify DateOfHire.");
                        Console.WriteLine("3.Specify DateOfTermination");
                        Console.WriteLine("3.Specify HourlyRate");
                        break;
                    case 3://Contract
                        Console.WriteLine("2.Specify ContractStartDate");
                        Console.WriteLine("3.Specify ContractStopDate");
                        Console.WriteLine("4.Specify FixedContractAmount");
                        break;
                    case 4://Seasonal 
                         Console.WriteLine("2.Specify Season");
                         Console.WriteLine("3.Specify Piecepay");
                        break;
                }
        }


        /// <summary>
        /// Function        :GetUserOption
        /// Description     :
        ///                  This function used to get use's option.
        ///                  
        /// 
        /// Parameters      :
        ///                 void    
        /// Return          :int: -1: User's input is not a number or number that less than 0;
        ///                        more than -1, User's input. 
        /// </summary>
        private int GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter your Option:");
            string strInput = Console.ReadLine();

            //ConsoleKeyInfo Key;
            //Key = Console.ReadKey();
            //string strInput = Key.KeyChar.ToString();
            int num;
            bool isNum = int.TryParse(strInput, out num);

            if (isNum)
            {
                if (num < 0)
                {
                    num = -1;
                }
                return num;
            }
            return -1;
        }


        /// <summary>
        /// Function        :MainMenuOperation
        /// Description     :
        ///                 This function used to go to different menu depend to user's option from the main menu.
        /// 
        /// Parameters      :void
        /// 
        /// Return          :void
        /// </summary>
        private void MainMenuOperation()
        {

            bool bResult = false;

            while (!bResult)
            {
                DisplayMainMenu();
                int nOption = GetUserOption();
                switch (nOption)
                {
                    case 1:
                        FileManMenuOperation();
                        break;
                    case 2:
                        EmployeeMainMenuOperation();
                        break;
                    case 9:
                        bResult = true;
                        break;
                    default:

                        break;
                }
            }

        }


        /// <summary>
        /// Function        :FileManMenuOperation
        /// Description     :
        ///                    This function used to support option for user to open a local file to read data or save data to a local file.
        /// 
        /// Parameters      :void
        /// 
        /// Return          :void
        /// </summary>
        private void FileManMenuOperation()
        {
            bool bResult = false;

            while (!bResult)
            {
                DisplayFileManMenu();
                int nOPtion = GetUserOption();
                switch (nOPtion)
                {
                    case 1:
                        LoadEMSDBFromFile();
                        break;
                    case 2:
                        SaveEmploySetToEMSDBFile();
                        break;
                    case 9:
                        bResult = true;
                        break;
                    default:
                        break;
                }
            }

        }


        /// <summary>
        /// Function        :EmployeeMainMenuOperation
        /// Description     :
        ///                 This function support different operation to the employee for user. 
        /// 
        /// Parameters      :void
        /// 
        /// Return          :void
        /// </summary>
        private void EmployeeMainMenuOperation()
        {
            bool bResult = false;
            while (!bResult)
            {
                DisplayEmployeeMainMenu();
                int nOPtion = GetUserOption();
                switch (nOPtion)
                {
                    case 1:
                        DisplayEmployeeSet();
                        break;
                    case 2:
                        CreateNewEmployee();
                        break;
                    case 3:
                        ModifyExistingEmployee();
                        break;
                    case 4:
                        RemoveExistingEmployee();
                        break;
                    case 9:
                        bResult = true;
                        break;
                    default:
                        break;
                }
            }



        }


        /// <summary>
        /// Function        :EmployeeDetailMenuOperation
        /// Description     :
        ///                 This function used to modify or create a specifc property of a employee.  
        /// 
        /// Parameters      :int nOperation: OPERATION_CREATE, Create an instance.
        ///                                  OPERATION_MODIFY, Modify an instance
        ///                 int nEmployType:  EMPLOYEE_FULLTIME,
        ///                                   EMPLOYEE_PARTTIME,
        ///                                   EMPLOYEE_CONTRACT,
        ///                                   EMPLOYEE_SEASONAL
        /// 
        /// 
        /// 
        /// Return          :void
        /// </summary>

        private void EmployeeDetailMenuOperation(int nOperation, int nEmployType)
        {

            CreateModifyEmployee(nOperation, nEmployType);

            return;


            bool bResult = false;
            while (!bResult)
            {
                DisplayEmployeeDetailMenu(nOperation, nEmployType);
                CreateModifyEmployee(nOperation, nEmployType);
                


                int nOption = GetUserOption();



                switch (nOption)
                {
                    case 9:
                        bResult = true;
                        break;
                    default:
                        break;

                }







            }

        }

        private void CreateModifyEmployee(int nOperation, int nEmployType)
        {
            if(nOperation == (int)Operations.OPERATION_CREATE)
            {
               switch(nEmployType)
               {
                   case (int)EmployeeType.EMPLOYEE_FULLTIME:
                       CreateFullTimeEmployee(nOperation,nEmployType);
                       break;
                   case (int)EmployeeType.EMPLOYEE_PARTTIME:
                       CreatePartTimeEmployee();
                           break;
                   case (int)EmployeeType.EMPLOYEE_CONTRACT:
                           CreateContractEmployee();
                           break;
                   case (int)EmployeeType.EMPLOYEE_SEASONAL:
                           CreateSeasonalEmployee();
                           break;
                   default:
                           break;

               }
            }
            
        }

        /// <summary>
        /// Function        :CreateModifySpecificAtt
        /// Description     :
        /// 
        /// 
        /// Parameters      :
        /// 
        /// Return          :
        /// </summary>
        private void CreateModifySpecificAtt(int nOperation, int nEmployType,int nUserOption)
        {


        }


        /// <summary>
        /// Function        :ModifyBaseAtt
        /// Description     :
        ///                  This funcion used to modify the base attribution of a specificed employee.
        /// 
        /// Parameters      :
        ///                    ref AllEmployess.Employee e: The instance of an specific employee.
        /// Return          :void
        /// </summary>
        private void ModifyBaseAtt(ref AllEmployess.Employee e)
        {

        }

        /// <summary>
        /// Function        :LoadEMSDBFromFile
        /// Description     :This function used to load data from a local file.
        /// 
        /// 
        /// Parameters      :void   
        /// 
        /// Return          :void
        /// </summary>
        private void LoadEMSDBFromFile()
        {
            Console.WriteLine("Loading");
            Console.WriteLine("Need Loading Function.");
            Console.Read();
        }


        /// <summary>
        /// Function        :SaveEmploySetToEMSDBFile
        /// Description     :This function used to load data from a local file.
        /// 
        /// 
        /// Parameters      :void
        /// 
        /// Return          :void
        /// </summary>
        private void SaveEmploySetToEMSDBFile()
        {
            Console.WriteLine("Writing");
            Console.WriteLine("Need Saving Function.");
            Console.Read();
        }


        /// <summary>
        /// Function        :DisplayEmployeeSet
        /// Description     :This function used to display the information for all the employees.
        /// 
        /// 
        /// Parameters      :void
        /// 
        /// Return          :void
        /// </summary>
        private void DisplayEmployeeSet()
        {

            EmployeeContainer.TraverseList("Details");
            Console.Read();
        }


        /// <summary>
        /// Function        :CreateNewEmployee
        /// Description     :This function used to ask for the employee's type that to be created.
        /// 
        /// 
        /// Parameters      :void
        /// 
        /// Return          :void
        /// </summary>
        private void CreateNewEmployee()
        {
            Console.Clear();
            int nEmployeeType = 0;
            nEmployeeType =  GetCreateEmployeeType();
            
            switch(nEmployeeType)
            {
                case (int)EmployeeType.EMPLOYEE_NONE:
                    break;
                case (int)EmployeeType.EMPLOYEE_FULLTIME:
                    EmployeeDetailMenuOperation((int)Operations.OPERATION_CREATE, (int)EmployeeType.EMPLOYEE_FULLTIME);
                    break;
                case (int)EmployeeType.EMPLOYEE_PARTTIME:
                    EmployeeDetailMenuOperation((int)Operations.OPERATION_CREATE, (int)EmployeeType.EMPLOYEE_PARTTIME);
                    break;
                case (int)EmployeeType.EMPLOYEE_CONTRACT:
                    EmployeeDetailMenuOperation((int)Operations.OPERATION_CREATE, (int)EmployeeType.EMPLOYEE_CONTRACT);
                    break;
                case (int)EmployeeType.EMPLOYEE_SEASONAL:
                    EmployeeDetailMenuOperation((int)Operations.OPERATION_CREATE, (int)EmployeeType.EMPLOYEE_SEASONAL);
                    break;
                default:
                    break;
            }
                           
        }


        /// <summary>
        /// Function        :ModifyExistingEmployee
        /// Description     :This function used to ask for an SIN number for a specific employee , and then modify the attributon information.
        /// 
        /// 
        /// Parameters      :void
        /// 
        /// Return          :void
        /// </summary>
        private void ModifyExistingEmployee()
        {

            bool bExist = false;
            bool bReInput = false;
            AllEmployess.Employee employee;
            string strSIN="";
            while (!bReInput)
            {
                DisplayNavi_Head("Menu > Employee Manegement > Modify");
                Console.WriteLine("Please input the SIN");
                strSIN = Console.ReadLine();
               
                if ((employee = EmployeeContainer.Find(strSIN)).GetType().CompareTo("") == 0)
                {
                    Console.WriteLine("Do not existing.");
                    Console.WriteLine("Do you another input? Y/N");

                    string strInput = Console.ReadLine();
                    strInput =strInput.ToUpper();
                     if(strInput.CompareTo("N") == 0)
                    {
                        bReInput = true;
                    }
                }
                else
                {
                    bReInput = true;
                    bExist = true;
                }
            }


            if(bExist)
            {
                employee = EmployeeContainer.Find(strSIN);
                string strType = employee.GetType();

                if(strType.CompareTo("FT") == 0)
                {
                    employee.Details();
                }
                else if(strType.CompareTo("PT") == 0)
                {

                }
                else if(strType.CompareTo("CT") == 0)
                {

                }
                else if(strType.CompareTo("SS") == 0)
                {

                }
                Console.Read();

            }

            
           // Console.Read();
        }

        /// <summary>
        /// Function        :RemoveExistingEmployee
        /// Description     :This function used to remove a specific employee.
        /// 
        /// 
        /// Parameters      :void
        /// 
        /// Return          :void
        /// </summary>
        private void RemoveExistingEmployee()
        {
            Console.WriteLine("Need Remove Existing Employee Function");
            Console.WriteLine("Removing");
            Console.Read();
        }

        /// <summary>
        /// Function        :Run
        /// Description     :This function used as the beginning of the UI.
        /// 
        /// 
        /// Parameters      :void
        /// 
        /// Return          :void
        /// </summary>
        public void Run()
        {
            ChangeTheFontColor();
            MainMenuOperation();
        }


        /// <summary>
        /// Function        :DisplayNavi_Head
        /// Description     :This function used as the navigation for this application.
        /// 
        /// 
        /// Parameters      :string strNavi: Current location.
        /// 
        /// Return          :void
        /// </summary>
        private void DisplayNavi_Head(string strNavi)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("                     {0}", strNavi);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }


        /// <summary>
        /// Function        :ChangeTheFontColor
        /// Description     :Change the color of the font.
        /// 
        /// 
        /// Parameters      :void
        /// 
        /// Return          :void
        /// </summary>
        private void ChangeTheFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }


        /// <summary>
        /// Function        :GetCreateEmployeeType
        /// Description     :This function used to get the employee type to be create.
        /// 
        /// 
        /// Parameters      :void
        /// 
        /// Return          : int :EMPLOYEE_FULLTIME,
       ///    EMPLOYEE_PARTTIME,
        ///    EMPLOYEE_CONTRACT,
        /// EMPLOYEE_SEASONAL
        /// </summary>
        private int GetCreateEmployeeType()
        {

            bool bResult = false;
            int nOption  = (int)EmployeeType.EMPLOYEE_NONE;
            while (!bResult)
            {
                Console.Clear();
                DisplayNavi_Head("Main > Employee Management > Create");

                DisplayEmployeeType();
                nOption = GetUserOption();
                if (nOption == 9)
                {
                    nOption = (int)EmployeeType.EMPLOYEE_NONE;
                    bResult = true;
                }

                switch (nOption)
                {
                    case 1:
                        nOption = (int)EmployeeType.EMPLOYEE_FULLTIME;
                        bResult = true;
                        break;
                    case 2:
                        nOption = (int)EmployeeType.EMPLOYEE_PARTTIME;
                        bResult = true;
                        break;
                    case 3:
                        nOption = (int)EmployeeType.EMPLOYEE_CONTRACT;
                        bResult = true;
                        break;
                    case 4:
                        nOption = (int)EmployeeType.EMPLOYEE_SEASONAL;
                        bResult = true;
                        break;
                    default:
                        break;
                }
            }

            return nOption;
        }


        /// <summary>
        /// Function        :DisplayEmployeeType
        /// Description     :Show all the employee type for the user.
        /// 
        /// 
        /// Parameters      :void
        /// 
        /// Return          :void
        /// </summary>
        private void DisplayEmployeeType()
        {
            Console.WriteLine("1. FullTimeEmployee");
            Console.WriteLine("2. PartrimeEmployee");
            Console.WriteLine("3. ContractEmployee");
            Console.WriteLine("4. SeasonalEmployee");
            Console.WriteLine("9. Back");
        }


        /// <summary>
        /// Function        :CreateFullTimeEmployee
        /// Description     :Create a fulltime.
        /// 
        /// 
        /// Parameters      :void
        /// 
        /// Return          :void
        /// </summary>
        private void CreateFullTimeEmployee(int nOperation, int nEmployType)
        {
           
            FulltimeEmployee fullEmployee = new FulltimeEmployee();
            bool bDone = true;
            while (bDone)
            {
                DisplayEmployeeDetailMenu(nOperation, nEmployType);
                   int nOption = GetUserOption();

                   switch (nOption)
                   {
                       case 1:
                           CreateFullTimeBaseAttribution(ref fullEmployee, (int)EmployeeType.EMPLOYEE_FULLTIME);
                           break; 
                       case 2:
                           CreateFullTimeDateOfHire(ref fullEmployee, (int)EmployeeType.EMPLOYEE_FULLTIME);
                           break;
                       case 3:
                           CreateFullTimeDateOfTermination(ref fullEmployee, (int)EmployeeType.EMPLOYEE_FULLTIME);
                           break;
                       case 4:
                           CreateFullTimeSalary(ref fullEmployee, (int)EmployeeType.EMPLOYEE_FULLTIME);
                           break;
                       case 9:
                           //UNDO Add to the Company List.
                           if(fullEmployee.ValideEmployee())
                           {
                               EmployeeContainer.AddEmployee(fullEmployee);
                               bDone = false;
                           }
                           
                           break;
                       default:
                           break;

                   }
      
            }
            //undo Function that used to create the base attribution of an employee. And create a function for each childattribution.
         
        }


        private void CreateBaseAttribution(ref Employee e, int nType)
        {

        }


        private void CreateFullTimeBaseAttribution(ref FulltimeEmployee e, int nType)
        {
            DisplayNavi_Head("Menu > Create Base Attribution For  FullTime Employee");
            while (true)
            {
                Console.WriteLine("Please Input Employee's FirstName");
                string strFirstName;
                strFirstName = Console.ReadLine();

                if (e.SetFirstName(strFirstName))
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please Input Employee's LastName");
                string strLastName;
                strLastName = Console.ReadLine();

                if (e.SetLastName(strLastName))
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please Input Employee's DateofBirth");
                string strDateofBirth;
                strDateofBirth = Console.ReadLine();

                if (e.SetDateOfBirth(strDateofBirth))
                {
                    break;
                }
            }
        
            while (true)
            {
                Console.WriteLine("Please Input Employee's SIN");
                string strSIN;
                strSIN = Console.ReadLine();
                if (e.SetSocialInsuranceNumber(strSIN))
                {

                    break;
                }

            }

        }
        private void CreateFullTimeDateOfTermination(ref FulltimeEmployee e, int nType)
        {
            DisplayNavi_Head("Menu > Create DateOfTermination For  FullTime Employee");
            while (true)
            {
                Console.WriteLine("Please Input Employee's DateOfTermination.");
                string strDateOfTermination;
                strDateOfTermination = Console.ReadLine();

                if (e.SetDateOfTermination(strDateOfTermination))
                {
                    break;
                }


            }
        }


        private void CreateFullTimeSalary(ref FulltimeEmployee e, int nType)
        {
            DisplayNavi_Head(" Menu > Create Salary For  FullTime Employee");
            while (true)
            {
                Console.WriteLine("Please Input Employee's DataOfBirth.");
                string strSalary;
                strSalary = Console.ReadLine();

                if (e.SetSalary(strSalary))
                {
                    break;
                }


            }
        }
        private void CreateFullTimeDateOfHire(ref FulltimeEmployee e, int nType)
        {
            DisplayNavi_Head("Menu > Create DateOfBirth For  FullTime Employee");
            while (true)
            {
                Console.WriteLine("Please Input Employee's DataOfBirth.");
                string strDateOfBirth;
                strDateOfBirth = Console.ReadLine();

                if(e.SetDateOfHire(strDateOfBirth))
                {
                    break;
                }
                

            }
        }
        private  void CreatePartTimeBaseAttribution(ref ParttimeEmployee e, int nType)
        {
            DisplayNavi_Head("Menu > Create Base Attribution For  PartTime Employee");

            while (true)
            {
                Console.WriteLine("Please Input Employee's FirstName");
                string strFirstName;
                strFirstName = Console.ReadLine();

                if (e.SetFirstName(strFirstName))
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please Input Employee's LastName");
                string strLastName;
                strLastName = Console.ReadLine();

                if (e.SetLastName(strLastName))
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please Input Employee's DateofBirth");
                string strDateofBirth;
                strDateofBirth = Console.ReadLine();

                if (e.SetDateOfBirth(strDateofBirth))
                {
                    break;
                }
            }

           
          
            while (true)
            {
                Console.WriteLine("Please Input Employee's SIN");
                string strSIN;
                strSIN = Console.ReadLine();
                if (e.SetSocialInsuranceNumber(strSIN))
                {

                    break;
                }

            }
        }

        private void CreateContractBaseAttribution(ref ContractEmployee e, int nType)
        {
            DisplayNavi_Head("                               Menu > Create Base Attribution For  Contract Employee");
            while (true)
            {
                Console.WriteLine("Please Input Employee's FirstName");
                string strFirstName;
                strFirstName = Console.ReadLine();

                if (e.SetFirstName(strFirstName))
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please Input Employee's LastName");
                string strLastName;
                strLastName = Console.ReadLine();

                if (e.SetLastName(strLastName))
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please Input Employee's DateofBirth");
                string strDateofBirth;
                strDateofBirth = Console.ReadLine();

                if (e.SetDateOfBirth(strDateofBirth))
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please Input Employee's SIN");
                string strSIN;
                strSIN = Console.ReadLine();
                if (e.SetSocialInsuranceNumber(strSIN))
                {

                    break;
                }

            }
        }

        private void CreateSeasonalBaseAttribution(ref SeasonalEmployee e, int nType)
        {
            DisplayNavi_Head("                               Menu > Create Base Attribution For  Seasonal Employee");
            while (true)
            {
                Console.WriteLine("Please Input Employee's FirstName");
                string strFirstName;
                strFirstName = Console.ReadLine();

                if (e.SetFirstName(strFirstName))
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please Input Employee's LastName");
                string strLastName;
                strLastName = Console.ReadLine();

                if (e.SetLastName(strLastName))
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please Input Employee's DateofBirth");
                string strDateofBirth;
                strDateofBirth = Console.ReadLine();

                if (e.SetDateOfBirth(strDateofBirth))
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please Input Employee's SIN");
                string strSIN;
                strSIN = Console.ReadLine();
                if (e.SetSocialInsuranceNumber(strSIN))
                {

                    break;
                }

            }
        }

      

        /// <summary>
        /// Function        :CreatePartTimeEmployee
        /// Description     :Create a Parttime employee
        /// Parameters      :void
        /// Return          :void
        /// </summary>
        private void CreatePartTimeEmployee()
        {

        }

        /// <summary>
        /// Function        :CreateContractEmployee
        /// Description     :Create a Contract employee.
        /// Parameters      :void
        /// Return          :void
        /// </summary>
        private void CreateContractEmployee()
        {
        }

        /// <summary>
        /// Function        :CreateSeasonalEmployee
        /// Description     :Create a sensonal employee.
        /// Parameters      :void
        /// Return          :void
        /// </summary>
        private void CreateSeasonalEmployee()
        {


        }


        /// <summary>
        /// Function        :ModifyFullTimeEmployee
        /// Description     :Modify a full time employee.
        /// Parameters      :void
        /// Return          :void
        /// </summary>
        private void ModifyFullTimeEmployee()
        {
        }

        /// <summary>
        /// Function        :ModifyPartTimeEmployee
        /// Description     :Modify a parttime employee.
        /// Parameters      :void
        /// Return          :void
        /// </summary>
        private void ModifyPartTimeEmployee()
        {
        }
        /// <summary>
        /// Function        :ModifyContractEmployee
        /// Description     :Modify a contract employee.
        /// Parameters      :void
        /// Return          :void
        /// </summary>
        private void ModifyContractEmployee()
        {
        }
        /// <summary>
        /// Function        :ModifySenasonalEmployee
        /// Description     :Modify an sensonal employee.
        /// Parameters      :void
        /// Return          :void
        /// </summary>
        private void ModifySenasonalEmployee()
        {
        }

        /// <summary>
        /// Function        :ModifyBaseAttribution
        /// Description     :Modify the base attribution of an employee.
        /// Parameters      :
        /// Return          :
        /// </summary>
        private void ModifyBaseAttribution(ref Employee e)
        {

        }
    
        
    }
}
