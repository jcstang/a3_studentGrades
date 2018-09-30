using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentGrades
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] AryStudents;
        public int[,] AryStudentGrades;
        public int iStudentCount;
        public int iAssignmentCount;
        bool bSubmitCountButtonClicked;

        public MainWindow()
        {
            bSubmitCountButtonClicked = false;
            InitializeComponent();
        }

        #region Button Clicks

        private void btnSubmitCounts_Click(object sender, RoutedEventArgs e)
        {
            bSubmitCountButtonClicked = true;
            if ( ValidateCounts(tbxNumOfStudents.Text, tbxNumOfAssignments.Text) )
            {
                //SetCountValues(tbxNumOfStudents.Text, tbxNumOfAssignments.Text);

                InitArrays(iStudentCount, iAssignmentCount);
            }

        }

        private void btnFirstStudent_Click(object sender, RoutedEventArgs e)
        {
            if (bSubmitCountButtonClicked)
            {
                Console.WriteLine("First Student btn clicked");
            }
        }

        private void btnPrevStudent_Click(object sender, RoutedEventArgs e)
        {
            if (bSubmitCountButtonClicked)
            {
                Console.WriteLine("Previous Student btn clicked");
            }
        }

        private void btnNextStudent_Click(object sender, RoutedEventArgs e)
        {
            if (bSubmitCountButtonClicked)
            {
                Console.WriteLine("Next Student btn clicked");
            }
        }

        private void btnLastStudent_Click(object sender, RoutedEventArgs e)
        {
            if (bSubmitCountButtonClicked)
            {
                Console.WriteLine("Last Student btn clicked");
            }
        }

        private void btnSaveScore_Click(object sender, RoutedEventArgs e)
        {
            if (bSubmitCountButtonClicked)
            {
                Console.WriteLine("Save Score btn clicked");
            }
        }

        private void btnSaveName_Click(object sender, RoutedEventArgs e)
        {
            if (bSubmitCountButtonClicked)
            {
                Console.WriteLine("Save Name btn clicked");
            }
        }

        private void btnDisplayScores_Click(object sender, RoutedEventArgs e)
        {
            if (bSubmitCountButtonClicked)
            {
                Console.WriteLine("Display scores btn clicked");
            }
        }

        private void btnResetScores_Click(object sender, RoutedEventArgs e)
        {
            if (bSubmitCountButtonClicked)
            {
                Console.WriteLine("Reset scores btn clicked");
            }
        }

        #endregion


        #region Helper Methods
        public bool ValidateCounts(string stuCount, string asntCount)
        {
            //TODO: validate
            bool retValStudents = false;
            bool retValAssignments = false;

            retValStudents = Int32.TryParse(stuCount, out iStudentCount);
            retValAssignments = Int32.TryParse(asntCount, out iAssignmentCount);

            return retValStudents && retValAssignments;
        }

        //helper methods
        public void InitArrays(int iStuCount, int iAsntCount)
        {
            AryStudents = new string[iStuCount];
            AryStudentGrades = new int[iStuCount, iAsntCount];

            for (int i = 0; i < iStuCount; i++)
            {
                string sCount = "Student #" + (i+1).ToString();
                AryStudents[i] = sCount;
                Console.WriteLine("here is: " + AryStudents[i]);
                for (int j = 0; j < iAsntCount; j++)
                {
                    AryStudentGrades[i, j] = 0;
                    Console.Write("grades: " + AryStudentGrades[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        
        #endregion

        
    }
}
