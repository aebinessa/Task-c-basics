int GPA = 3;
double version = 17.85;
string myName = "Abdullah";
bool isStrong = true;
int number = 5;
double result = Convert.ToDouble(number);
double rectangleWidth = 3.7;
double rectangleHeight = 6.9;
char A = 'A';
const string studentName = "khaled"; // will not be changed
//studentName = "ahmad";, does not work because it is a const


Console.WriteLine(A);
Console.WriteLine(studentName);
Console.WriteLine(GPA);
Console.WriteLine(version);
Console.WriteLine(myName);
Console.WriteLine(isStrong);
Console.WriteLine(result);
Console.WriteLine($"123 area of the rectangle is {rectangleWidth * rectangleHeight}");

var currentHour = 11;

if (currentHour >= 11 || currentHour <= 14)
{
    Console.WriteLine("time for lunch");

}

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("");

//BONUS!!
var index = 5;
while (index > 0)
{
    Console.WriteLine(index);
    index--;

}
Console.WriteLine("");

string[] daysOfWeek = { "Monday", "Tuesday", "wednsday", "tuesday", "thursday", "friday", "saturday", "sunday"};

foreach (string day in daysOfWeek)
{
    Console.WriteLine(day);
}

double[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
double accumulatorNum = 0;


foreach (double num in numbers)
{
    accumulatorNum += num;
    Console.WriteLine(accumulatorNum);
}//BONUS!!


///////////////////

var evenNumbers = numbers.Where(num => num % 2 == 0);

Console.WriteLine("Even numbers:");
foreach (var num in evenNumbers)
{
    Console.WriteLine(num);
}

double[] averageGrades = { 3.00, 4.00, 3.185, 3.7, 2.67, 2.00 };
var averageGrade = averageGrades.Average();
Console.WriteLine(averageGrade);

//sorting bonus ===>

int[] unsortedNumbers = {76, 678, 30, 45, 65, 987 };
var sortednumbers = unsortedNumbers.OrderByDescending(num => num);
foreach(var num in sortednumbers) { 
    Console.WriteLine(num); }