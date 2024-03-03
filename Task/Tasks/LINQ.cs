using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;



//Task 1


double EvaluateSumOfElementsOddPositions(double[] inputData)
{
    return inputData.Where((item, index) => index % 2 == 1).Sum();
}
//Task 2
double EvaluateAggregate(double[] inputData, Func<double, double, double> aggregate, Func<double, int, bool> predicate)
{
    return inputData.Where(predicate).Aggregate(aggregate);
}

//Task 3

int ProductWithCondition(List<int> elements, Func<int, bool> condition) =>
    elements.Where(condition)
        .DefaultIfEmpty(1)
        .Aggregate((total, next) => total * next);

//Task 4


string GetWord(string input, string seed)
{
    return new string(input.Split(" ").Aggregate(seed, (max, cur) => max.Length >= cur.Length ? max : cur)
        .SkipWhile(cr => cr != 'a').ToArray());
}


namespace Tasks
{

    //Task 5


    class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Worker Manager { get; set; }

        public Department(string name, int id, Worker manager)
        {
            Name = name;
            Id = id;
            Manager = manager;
        }
        public Department() { }
    }

    class Worker
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonPropertyName("Full name")]
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Department Department { get; set; }

        public Worker(string nmae, decimal salary, Department department)
        {
            Name = nmae;
            Salary = salary;
            Department = department;

        }
        public Worker() { }

        public string Serialize()
        {
            return JsonSerializer.Serialize(this,
                new JsonSerializerOptions() { IgnoreNullValues = true, WriteIndented = true, });
        }

        public static Worker Deserialize(string info)
        {
            return JsonSerializer.Deserialize<Worker>(info);
        }


    }

}
