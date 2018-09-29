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
        //public Array<string, int> AryStudentGrades;
        public int iStudentCount;
        public int iAssignmentCount;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmitCounts_Click(object sender, RoutedEventArgs e)
        {
            
            if ( ValidateCounts() )
            {
                //init the student array and the grades array - student 1, student 2 grades 0.
                SetCountValues(tbxNumOfStudents.Text, tbxNumOfAssignments.Text);
                InitArrays(iStudentCount, iAssignmentCount);
            }

        }

        public void SetCountValues(string stuCount, string asntCount)
        {
            Int32.TryParse(stuCount, out iStudentCount);
            Int32.TryParse(asntCount, out iAssignmentCount);

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

        public bool ValidateCounts()
        {
            //TODO: validate
            //if good don't print error and return true
            // else print error message and return false
            return true;
        }
    }
}
