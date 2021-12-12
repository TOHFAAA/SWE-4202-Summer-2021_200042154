using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApp
{
    public partial class Gradesapp : Form
    {
        public Gradesapp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (NametextBox.Text != "" && IDtextBox.Text != "" && SemestertextBox.Text != "" &&
                       AttendancetextBox.Text != "" && MidtextBox.Text != "" && FinaltextBox.Text != "" &&
                       Quiz1textBox.Text != "" && Quiz2textBox.Text != "" && Quiz3textBox.Text != "" &&
                       Quiz4textBox.Text != "")
                {
                    string Name = NametextBox.Text;
                    int ID = Convert.ToInt32(IDtextBox.Text);
                    int Semester = Convert.ToInt32(SemestertextBox.Text);
                    int NumberofClasses = Convert.ToInt32(AttendancetextBox.Text);
                    double MidMarks = Convert.ToDouble(MidtextBox.Text);
                    double FinalMarks = Convert.ToDouble(FinaltextBox.Text);
                    double Quiz1 = Convert.ToDouble(Quiz1textBox.Text);
                    double Quiz2 = Convert.ToDouble(Quiz2textBox.Text);
                    double Quiz3 = Convert.ToDouble(Quiz3textBox.Text);
                    double Quiz4 = Convert.ToDouble(Quiz4textBox.Text);
                    double AttendedClasses = Convert.ToDouble(NumberofClasses);
                    double Attendance = (AttendedClasses / 28) * 30;
                    double[] ArrayofQuiz = { Quiz1, Quiz2, Quiz3, Quiz4 };
                    Array.Sort(ArrayofQuiz);
                    double QuizTotal = 0;
                    for (int i = 1; i < ArrayofQuiz.Length; i++)
                    {
                        QuizTotal = QuizTotal + ArrayofQuiz[i];
                    }
                    Attendancelabel.Text = "Attendance: " + Math.Round(Attendance, 2) + "/30";
                    Midlabel.Text = "Mid: " + MidMarks + "/75";
                    Quizlabel.Text = "Quiz: " + QuizTotal + "/45";
                    Finallabel.Text = "Final: " + FinalMarks + "/150";
                    double Total = Attendance + MidMarks + QuizTotal + FinalMarks;
                    Totallabel.Text = "Total: " + Math.Round(Total, 2) + "/300";
                    double MarksinPercantage = (Total / 300) * 100;

                    string Grade = null;
                    if (MarksinPercantage >= 80)
                    {
                        Grade = "A+";
                    }
                    else if (MarksinPercantage >= 75 && MarksinPercantage < 80)
                    {
                        Grade = "A";
                    }
                    else if (MarksinPercantage >= 70 && MarksinPercantage < 75)
                    {
                        Grade = "A-";
                    }
                    else if (MarksinPercantage >= 65 && MarksinPercantage < 70)
                    {
                        Grade = "B+";
                    }
                    else if (MarksinPercantage >= 60 && MarksinPercantage < 65)
                    {
                        Grade = "B";
                    }
                    else if (MarksinPercantage >= 55 && MarksinPercantage < 60)
                    {
                        Grade = "B-";
                    }
                    else if (MarksinPercantage >= 50 && MarksinPercantage < 55)
                    {
                        Grade = "C+";
                    }
                    else if (MarksinPercantage >= 45 && MarksinPercantage < 50)
                    {
                        Grade = "C";
                    }
                    else if (MarksinPercantage >= 40 && MarksinPercantage < 45)
                    {
                        Grade = "D";
                    }
                    else
                    {
                        Grade = "F";
                    }
                    Gradelabel.Text = "Grade: " + Grade;
                    Final_Statement.Text = Name + " obtained " + Math.Round(MarksinPercantage, 2) + "% marks.";
                }
                else
                {
                    MessageBox.Show("Error!" + "\n" + "Fill all necessary data.");
                }
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox4_TextChanged(object sender, EventArgs e)
            {
            }
    }
}
