using CSharp;
using CSharp.Day01.Part1;
using CSharp.Day01.Part2;
using CSharp.Day02.Part1;
using CSharp.Day02.Part2;
using CSharp.Day03;
using CSharp.Day04;

// Day01
// var (left, right) = Utilities.GetLeftAndRightLists("Day01/input_day_01_1.txt");
//
// Console.WriteLine(TotalDistance.GetTotalDistance(left, right));
// Console.WriteLine(SimilarityScore.GetSimilarityScore(left, right));

// Day02
// var reports = Utilities.GetArrayOfArrays("Day02/input_day_02.txt");
//
// Console.WriteLine(RedNosedReports.GetNumberOfSafeReports(reports));
// Console.WriteLine(RedNosedReportsWithTolerating.GetNumberOfSafeReports(reports));

// Day03
// var mulProgram = File.ReadAllText("Day03/input_day_03.txt");
//
// Console.WriteLine(Multiplicator.Part1(mulProgram));
// Console.WriteLine(Multiplicator.Part2(mulProgram));

// Day04
var lines = System.IO.File.ReadAllLines(@"Day04/input_day_04.txt");

// Console.WriteLine(XmasSearcher.Part1(lines)); // 2618
Console.WriteLine(XmasSearcher.Part2(lines)); // 2011