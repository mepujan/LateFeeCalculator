// Student Number: c0842623
//Student Name : Pujan Gautam

namespace RyanLateFeeCalculator
{
    public partial class frmLateFeeCalculator : Form
    {
        //declaring class variables

        frmMain frmMain;
        private String movieType;
        private int newReleaseMoviesCount = 0;
        private int libraryMoviesCount = 0;
        private int kidMoviesCount = 0;
        public frmLateFeeCalculator(string movieType)
        {
            InitializeComponent();
            //initializing the object of main form.
            frmMain = new frmMain();
            //adding current date to textbox 
            txtBoxCurrentDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            this.movieType = movieType;
            // switching to different form title based on movie type provided.
            switch (movieType)
            {
                case "libraryMovie":
                    lblTitle.Text = "Library Movie";
                    break;
                case "kidMovie":
                    lblTitle.Text = "Kid Movie";
                    break;
                default:
                    lblTitle.Text = "New Release Movie";
                    break;
            }
        }
        /// <summary>
        /// Hide and close the main form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {   Hide(); 
            frmMain.ShowDialog();
            Close();
        }

        /// <summary>
        /// Calculate the late fee of different movie type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCalculateClick(object sender, EventArgs e)
        {
            // Calculating the due days
            double dueDays;
            double lateFee = 0;
            int numberOfMovies;
            DateTime dueDate;
            double breakPercentage;
            String customerType = customerTypeCombobox.Text;


            //providing break percentage based on customer type 
            switch (customerType)
            {
                case "New":
                    breakPercentage = 0;
                    break;
                case "Junior":
                    breakPercentage = 5;
                    break;
                case "Loyal":
                    breakPercentage = 10;
                    break;
                default:
                    breakPercentage =0;
                    break;
            }
            //assigning current date and time to currentDate variable
            DateTime currentDate = DateTime.Now;


            //validating the duedate inputted by the user
            bool dueDateValidator = UserInputValidator.TryParseDate(txtBoxDueDate.Text, lblDueDateError,out dueDate);

            //converting double value to integer 
            dueDays = Convert.ToInt32((currentDate - dueDate).TotalDays);

            //validating user input for number of movies inputted by the user
            bool moviesNumbervalidator = UserInputValidator.MoviesNumberInputValidator(txtBoxNumberOfMovies,lblNumberOfMoviesError,out numberOfMovies);

            //checking condition for the user validation.
            if (moviesNumbervalidator & dueDateValidator)
            {
                // displaying message box if due days contains the zero or negativa value.
                if (dueDays <= 0)
                {
                    MessageBox.Show("Due Date Should Be Older than Current Date.");
                }
                else
                {
                    txtBoxDaysLate.Text = dueDays.ToString();

                    //assignment of late fee as per the movie type and updating the 
                    //counter of movies returned of current type
                    if (movieType == "newRelease")
                    {
                        lateFee = 2;
                        newReleaseMoviesCount += numberOfMovies;
                        this.lblCounter.Text = newReleaseMoviesCount.ToString();
                    }
                        
                    else if (movieType == "libraryMovie")
                    {
                        lateFee = 0.57;
                        libraryMoviesCount += numberOfMovies;
                        this.lblCounter.Text = libraryMoviesCount.ToString();
                    }
                        
                    else if(movieType == "kidMovie")
                    {
                        lateFee = 0.15;
                        kidMoviesCount += numberOfMovies;
                        this.lblCounter.Text = kidMoviesCount.ToString();
                    }

                    //calculating late fee
                    double lateCharge = (lateFee * dueDays * numberOfMovies) - 
                                        (lateFee * dueDays * numberOfMovies * breakPercentage) / 100;

                    txtBoxLateFee.Text = (lateCharge).ToString("c");
                    lblDueDateError.Visible = false;
                    lblNumberOfMoviesError.Visible = false;
                    
                }
            }
        }
    
    }
}
