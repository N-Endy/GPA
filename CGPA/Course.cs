using System;

public class Course
{
    // Properties
    public string CourseCode { get; set; }
    public int CourseUnit { get; set; }
    public int Score { get; set; }
    public string Grade { get; private set; }
    public double GradePoint { get; private set; }
    public double QualityPoint { get; private set; }

    // Constructor
    public Course(string courseCode, int courseUnit, int score)
    {
        CourseCode = courseCode;
        CourseUnit = courseUnit;
        Score = score;

        // Calculate grade and quality point and cal in constructor
        CalculateGrade();
        CalculateQualityPoint();
    }

    // Method to calculate quality point
    private void CalculateQualityPoint()
    {
        QualityPoint = CourseUnit * GradePoint;
    }

    // Method to calculate grade based on score
    private void CalculateGrade()
    {
        if (Score >= 70 && Score <= 100)
        {
            Grade = "A";
            GradePoint = 5.0;
        }
        else if (Score >= 60 && Score <= 69)
        {
            Grade = "B";
            GradePoint = 4.0;
        }
        else if (Score >= 50 && Score <= 59)
        {
            Grade = "C";
            GradePoint = 3.0;
        }
        else if (Score >= 45 && Score <= 49)
        {
            Grade = "D";
            GradePoint = 2.0;
        }
        else if (Score >= 40 && Score <= 44)
        {
            Grade = "E";
            GradePoint = 1.0;
        }
        else if (Score < 40 && Score >= 0)
        {
            Grade = "F";
            GradePoint = 0.0;
        }
        else
        {
            throw new ArgumentException("Invalid score. Score must be between 0 and 100.");
        }
    }
}