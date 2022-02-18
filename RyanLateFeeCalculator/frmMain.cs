// Student Number: c0842623
//Student Name : Pujan Gautam


namespace RyanLateFeeCalculator
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closing the windows form application
            Close();
        }

        private void btnNewRelease_Click(object sender, EventArgs e)
        {
            Hide();
            // Navigating to frmLibraryMovies on clicking button event
            //frmNewRelease newRelease = new frmNewRelease();
            frmLateFeeCalculator newRelease = new frmLateFeeCalculator("newRelease");
            //showing the window form
            newRelease.ShowDialog();
            //hiding the previously running window form
            Close();
    }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            Hide();
            // Navigating to frmLibraryMovies on clicking button event
            //frmLibraryMovies libraryMovies = new frmLibraryMovies();
            frmLateFeeCalculator libraryMovies = new frmLateFeeCalculator("libraryMovie");
            //showing the window form
            libraryMovies.ShowDialog();
            //hiding the previously running window forms
            Close();
        }

        private void btnKidMovies_Click(object sender, EventArgs e)
        {
            Hide();
            // Navigating to frmKidMovies on clicking button event
            //frmKidMovies kidMovies = new frmKidMovies();
            frmLateFeeCalculator kidMovies = new frmLateFeeCalculator("kidMovie");
            //showing the window form
            kidMovies.ShowDialog();
            Close();
            //hiding the previously running window forms
        }
    }
}