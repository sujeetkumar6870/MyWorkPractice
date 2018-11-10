using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionHouseDAL
{
    public class DALMain
    {
        #region //generate Id
        public static string GenerateID()
        {
            string allowedChars = "0123456789";

            char[] chars = new char[5];
            Random rd = new Random(DateTime.Now.Millisecond);


            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
            //In calling func append this id with respective Id type using concatination

        }
        #endregion
        public void AddNewMovie(string Producer_Id, string Movie_Name, string Movie_Year, string Movie_Plot, byte[] Movie_Poster)
        {

        }
    }
}
