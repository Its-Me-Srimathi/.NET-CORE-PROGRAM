int Students;
int Total;
int NoOfSub = 6;
Console.Write("\nEnter the number of Students : ");
Students = Convert.ToInt32(Console.ReadLine());

string[] Subject = new string[] { "English", "Tamil", "Maths", "Science", "Social", "Computer" };
string[,] Records = new string[Students,NoOfSub + 4];

for (int i= 0; i<Students; i++)
{
    Total = 0;
    Console.Write("\nEnter the Student {0} Name : ", i+1);
    Records[i, 0] = Console.ReadLine();
    Records[i, 9] = "Pass";

    for ( int j = 1; j<=NoOfSub; j++)
    {
        Console.Write($"Enter {Subject[j-1]} Marks : ");
        Records[i,j] = Console.ReadLine();
        Total += Convert.ToInt32(Records[i, j]);
        if (Convert.ToInt32(Records[i, j]) < 40)
        {
            Records[i, 9] = "Fail";
        }
    }
    Records[i, 8] = Total.ToString();
}

for( int i=0; i<Students; i++)
{
    Console.WriteLine("\nStudent Name : " + Records[i, 0]);
     
    for( int j = 1; j<=NoOfSub; j++)
    {
        Console.WriteLine(Subject[j-1] + ":" + Records[i,j]);
    }
    Console.WriteLine("Total : " + Records[i, 8]);
    Console.WriteLine("Result : "+ Records[i, 9]);
}


