using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace ProgramW11
{
    public class Employee
    {
        List<float> grades = new List<float>();

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade?");
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float grade0))
            {
                this.AddGrade(grade0);
            }
            else
            {
                Console.WriteLine("Invalid type of string?");
            }
        }

        public void AddGrade(int grade)
        {
            float grade1 = grade;
            this.AddGrade(grade1);
        }

        public void AddGrade(double grade)
        {
            float grade2 = (float)grade;
            this.AddGrade(grade2);
        }

        public void AddGrade(long grade)
        {
            float grade3 = (float)grade;
            this.AddGrade(grade3);
        }

        public Statistics GetStatisticsForeach()
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsFor()
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;

            for (var counter = 0; counter < this.grades.Count; counter++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[counter]);
                statistics.Min = Math.Min(statistics.Min, grades[counter]);
                statistics.Average += grades[counter];
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsDoWhile()
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            var counter = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, grades[counter]);
                statistics.Min = Math.Min(statistics.Min, grades[counter]);
                statistics.Average += grades[counter];
                counter++;
            } while (counter < this.grades.Count);

            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWhile()
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            var counter = 0;

            while (counter < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, grades[counter]);
                statistics.Min = Math.Min(statistics.Min, grades[counter]);
                statistics.Average += grades[counter];
                counter++;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
