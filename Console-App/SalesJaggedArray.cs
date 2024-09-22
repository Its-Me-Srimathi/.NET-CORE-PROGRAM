int[][] WeeklySales = new int[4][];
int OverallTotal = 0;

WeeklySales[0] = new int[] { 300,550,240};
WeeklySales[1] = new int[] { 800, 350, 600, 230, 500 };
WeeklySales[2] = new int[] { 640, 400 };
WeeklySales[3] = new int[] { 720, 400, 500, 100 };

int[] TotalSalesPerWeek = new int[WeeklySales.Length];

for(int i = 0; i<WeeklySales.Length; i++)    //total weekly sales
{
    for(int j = 0; j < WeeklySales[i].Length; j++ )          //each week total sales
    {
        TotalSalesPerWeek[i] += WeeklySales[i][j];
    }
    Console.WriteLine($"Total sales in week {i+1} : {TotalSalesPerWeek[i]}");
}

foreach(int WeekTotal in TotalSalesPerWeek)
{
    OverallTotal += WeekTotal;
}
Console.WriteLine("Overall Total Sales : " + OverallTotal);