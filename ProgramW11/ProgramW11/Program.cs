using ProgramW11;

var employee0 = new Employee("L", "W");
employee0.AddGrade("101");
employee0.AddGrade("Adam");
employee0.AddGrade(2);
employee0.AddGrade(6);
employee0.AddGrade(2000);
var statistics = employee0.GetStatisticsFor();

Console.WriteLine($"max: {statistics.Max}");
Console.WriteLine($"min: {statistics.Min}");
Console.WriteLine($"average: {statistics.Average:n2}");