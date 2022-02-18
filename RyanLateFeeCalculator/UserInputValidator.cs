
namespace RyanLateFeeCalculator
{
    internal class UserInputValidator
    {
        /// <summary>
        /// Validate the numberOfMovies inputted by user is integer or not
        /// and return the boolean value based on the parsing of the inputted value.
        /// this function out the integer movieNumber value.
        /// </summary>
        /// <param name="numberOfMovies"></param>
        /// <param name="errorMsg"></param>
        /// <param name="numberOfMovie"></param>
        /// <returns> isValid</returns>
        public static bool MoviesNumberInputValidator(TextBox numberOfMovies,Label errorMsg, out int numberOfMovie)
        {
            bool isValid = true;
            isValid = Int32.TryParse(numberOfMovies.Text, out int moviesNumber);
            numberOfMovie = moviesNumber;
            if (!isValid)
            {
                //making error message visible if parsing return false
                errorMsg.Visible = true;
                return isValid;

            }
          else if(moviesNumber <= 0){
                //making error message visible if parsing return false
                errorMsg.Visible = true;
               return !isValid;
           }
            errorMsg.Visible = false;
            return isValid;
        }

        /// <summary>
        /// parse the due date inputted by the user and return boolean value
        /// if the inputted value is date or not.
        /// </summary>
        /// <param name="dateToParse"></param>
        /// <param name="errorMsg"></param>
        /// <param name="dueDate"></param>
        /// <returns>boolean isValid value</returns>
        public static bool TryParseDate(string dateToParse,Label errorMsg,out DateTime dueDate)
        {
            bool isValid = DateTime.TryParse(dateToParse,out DateTime result);
            dueDate = result;
            if (!isValid)
            {
                //making error message visible if parsing return false
                errorMsg.Visible = true;
                return isValid;
            }
            errorMsg.Visible=false;
            return isValid;
        }
    }
}
