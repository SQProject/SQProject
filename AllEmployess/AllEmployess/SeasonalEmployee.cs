using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllEmployess
{
    /// <summary>
    /// class SeasonalEmployee
    /// 
    /// Description: Derived class of an Employee base class.
    /// 
    /// Relation: Inherits the base class.
    /// </summary>
    public class SeasonalEmployee : Employee
    {
        string Season;
        string PieceDay;

        /// <summary>
        ///   public SeasonalEmployee():base()
        ///   
        /// Description: Default constructor to set properties empty. First it calls the base class's default constructor to set its values empty.
        /// </summary>
        public SeasonalEmployee():base()
        {
            Season = "";
            PieceDay = "";
            strType = "SS";
        }

        /// <summary>
        /// public SeasonalEmployee(string fName , string lName , string season , string pieceDay):base(fName,lName)
        /// 
        /// Description:  Parameterized constructor to set the values of its properties.First it calls the base class's parameterized constructor.
        /// </summary>
        /// <param name="fName">first name</param>
        /// <param name="lName">last name</param>
        /// <param name="season">season</param>
        /// <param name="pieceDay">piece day</param>
        public SeasonalEmployee(string fName , string lName , string season , string pieceDay):base(fName,lName)
        {
            Season = season;
            PieceDay = pieceDay;
            strType = "SS";
        }


        /// <summary>
        ///  public bool SetSeason(string season)
        ///  
        /// Description: does the validation first and then set its value.
        /// </summary>
        /// <param name="season">season</param>
        /// <returns>>True: if validation succeeds,else false.</returns>
        public bool SetSeason(string season)
        {
            // if basic validation is true
            if (Validation.BasicValidation.SeasonValidate(season))
            {
                Season = season;
                return true;
            }
            //validation fails.
            else
            {
                return false;
            }
        }


        /// <summary>
        /// public bool SetPieceDay(string pieceDay)
        /// 
        /// Description: does the validation first, then sets its value.
        /// </summary>
        /// <param name="pieceDay">piece day</param>
        /// <returns>>True: if validation succeeds,else false.</returns>
        public bool SetPieceDay(string pieceDay)
        {
            // if basic validation is true
            if (Validation.BasicValidation.SalaryValidate(pieceDay))
            {
                PieceDay = pieceDay;
                return true;
            }
            //validation fails.
            else
            {
                return false;
            }
        }

        /// <summary>
        ///   public string GetSeason()
        ///          
        /// Description: gets the season of an employee.
        /// </summary>
        /// <returns>season</returns>
        public string GetSeason()
        {
            return Season;
        }


        /// <summary>
        /// public string GetPieceDay()
        /// 
        /// Description: gets the piece day of an employee.
        /// </summary>
        /// <returns>piece day</returns>

        public string GetPieceDay()
        {
            return PieceDay;
        }
        
    }
}
