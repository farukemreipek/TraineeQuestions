
using SumsOfComplexRows;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SumsOfComplexRows
{
    // Calculate each schools classroom count for the given floor. Assign them to a dto. In the end, we should know each school's, each floor's classroom count.
    //Verilen kat için her okulun sınıf sayısını hesaplayın.
    //Onları bir dto'ya atayın. Sonunda, her okulun
    //her katın derslik sayısını bilmeliyiz.
    class Program
    {
        static void Main(string[] args)
        {
            var testData = new List<Entity>
{
    new Entity
    {
        SchoolName = "Haldun Taner İlkokulu",
        ClassroomsByFloor = new List<EntityRow>
        {
            new EntityRow
            {
                FloorNumber = 1,
                ClassroomNames = new List<string>
                {
                    "a",
                    "s",
                    "d",
                    "f",
                    "z",
                    "x",
                    "c",
                    "v",
                    "q",
                    "w",
                }
            },
            new EntityRow
            {
                FloorNumber = 2,
                ClassroomNames = new List<string>
                {
                    "a",
                    "s",
                    "d",
                    "f",
                    "z",
                    "x",
                    "c",
                }
            },
            new EntityRow
            {
                FloorNumber = 3,
                ClassroomNames = new List<string>
                {
                    "v",
                    "q",
                    "w",
                }
            }
        }
    },
    new Entity
    {
        SchoolName = "Okul",
        ClassroomsByFloor = new List<EntityRow>
        {
            new EntityRow
            {
                FloorNumber = 1,
                ClassroomNames = new List<string>
                {
                    "a",
                    "s",
                    "d",
                    "f",

                    "q",
                    "w",
                }
            },
            new EntityRow
            {
                FloorNumber = 2,
                ClassroomNames = new List<string>
                {
                    "a",
                }
            },
            new EntityRow
            {
                FloorNumber = 3,
                ClassroomNames = new List<string>
                {
                    "v",
                    "q",
                    "w",
                }
            }
        }
    },
};
            var results = Math.Calculate(testData);

            foreach (var result in results)
            {
                Console.WriteLine($"School Name: {result.SchoolName}");

                foreach (var row in result.ClassRoomCounts)
                {
                    Console.WriteLine($"Floor Number: {row.FloorNumber}, Class Room Count: {row.ClassRoomCount}");
                }

                Console.WriteLine();
            }
        }
    }
}

public class Math
{
    public static List<ResultDto> Calculate(List<Entity> data)
    {
        var results = new List<ResultDto>();

        foreach (var entity in data)
        {
            var result = new ResultDto
            {
                SchoolName = entity.SchoolName,
                ClassRoomCounts = new List<ResultRowDto>()
            };

            foreach (var row in entity.ClassroomsByFloor)
            {
                var resultRow = new ResultRowDto
                {
                    FloorNumber = row.FloorNumber,
                    ClassRoomCount = row.ClassroomNames.Count
                };

                result.ClassRoomCounts.Add(resultRow);
            }

            results.Add(result);
        }

        return results;
    }
}




