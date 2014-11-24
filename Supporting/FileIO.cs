using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supporting
{
    /// <summary>
    /// Class FileIO
    /// 
    /// Desctiption: This class contains the file input and output
    /// The file input reads the data from the user then enters it to a file.
    /// The Read file will read the data in the file and return the data to the main program
    /// and store it within the internal database.
    /// 
    /// Relationship: The class will be connected with the program start and end where it will
    /// load up the data and save the data to file.
    /// </summary>
    class FileIO
    {

        /// <summary>
        ///  static public void WriteToFile(string type, string data)
        ///  
        /// Description: This method allows the program to write to the file
        /// database. This will store the data when the program closes.
        ///
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        static public void WriteToFile(string type, string data)
        {
            //depending on the type it will write to that file

        }


        /// <summary>
        /// static public string ReadFromFile(string type)
        /// 
        /// Description: This method will help to read the file database
        /// and upload that info to program when the program calls this method.
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        static public string ReadFromFile(string type)
        {
            string data = "";

            //read the specified files then write to screen
            return data;
        }
    }
}
