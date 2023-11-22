using CGPA;

Input input1 = new();

input1.PrintMessage("Press (1) for GPA calculation");
input1.PrintMessage("Press (0) to end process");

// Check if correct input of (1) or (0)
string? input = "";
while (input != "1" && input != "0")
{
    input1.PrintMessage("Select an action to perform: ");
    input = Console.ReadLine();
}

if (input == "1")
{
    input1.PrintMessage("How many courses would you like to enter: ");
    int numberOfCourses;
    while (!int.TryParse(Console.ReadLine(), out numberOfCourses) || numberOfCourses <= 0)
    {
        input1.PrintMessage("Invalid input. Please enter a positive integer for Number of Courses.");
        input1.PrintMessage("How many courses would you like to enter: ");
    }

    Course[] courses = new Course[numberOfCourses];

    for (int i = 0; i < numberOfCourses; i++)
    {
        // Course Code
        input1.PrintMessage($"Entry number: {i + 1}");
        input1.PrintMessage("Enter course code e.g: Math-101 ");
        string? courseCode = Console.ReadLine();

        // Course Unit
        input1.PrintMessage("Enter course unit. Range 1 - 5");
        int courseUnit;
        while (!int.TryParse(Console.ReadLine(), out courseUnit) || courseUnit < 0 || courseUnit > 5)
        {
            input1.PrintMessage("Invalid input. Please enter a positive integer for Course Unit.");
            input1.PrintMessage("Enter Course Unit: ");
        }

        // Score
        input1.PrintMessage("Enter Score: ");
        int score;
        while (!int.TryParse(Console.ReadLine(), out score) || score < 0 || score > 100)
        {
            input1.PrintMessage("Invalid input. Please enter a score between 0 and 100.");
            input1.PrintMessage("Enter Score: ");
        }

        // Initialize new course and append to array
        courses[i] = new Course(courseCode, courseUnit, score);
    }


    // Display details for each course in the array
    Console.WriteLine("\nCourse Details:");
    Console.WriteLine("{0, -15} | {1, -12} | {2, -5} | {3, -5} | {4, -12} | {5, -15} |",
        "Course Code", "Course Unit", "Score", "Grade", "Grade Point", "Quality Point");
    Console.WriteLine(new string('-', 80)); // Separator line

    // Calculate GPA
    int totalCourseUnits = 0;
    double totalQualityPoints = 0;
    double gpa = 0.0;
    foreach (Course course in courses)
    {
        totalCourseUnits += course.CourseUnit;
        totalQualityPoints += course.QualityPoint;

        gpa = totalQualityPoints / totalCourseUnits;

        Console.WriteLine("{0, -15} | {1, -12} | {2, -5} | {3, -5} | {4, -12} | {5, -15} |",
        course.CourseCode, course.CourseUnit, course.Score, course.Grade, course.GradePoint, course.QualityPoint);
        Console.WriteLine(new string('-', 80));
    }

    input1.PrintMessage($"Your GPA is: {gpa}");
    input1.PrintMessage("GPA is calculated using the formula:");
    input1.PrintMessage("(Total Quality Points) / (Total Course Units)");
}

