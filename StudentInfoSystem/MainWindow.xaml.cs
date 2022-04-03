using StudentInfoSystem;
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

namespace StudentInfoSystem_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void EnterStudentData(Student student)
        {
            inputFirstName.Text = student.FirstName;
            inputSecondName.Text = student.SecondName;
            inputLastName.Text = student.LastName;
            inputFac.Text = student.Faculty;
            inputMajor.Text = student.Major;
            inputOKS.Text = student.OKS;
            inputStatus.Text = student.Status;
            inputFacNum.Text = student.FacNum;
            inputCourse.Text = student.Course.ToString();
            inputStream.Text = student.Stream.ToString();
            inputGroup.Text = student.Group.ToString();
        }

        public void CleanInputs()
        {
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }
        public void EnableInputs()
        {
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;
                }
            }
        }
        public void DisableInputs()
        {
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;
                }
            }
        }
    }
}
