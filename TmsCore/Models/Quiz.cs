public class Quiz : IGradable
{
public required string Title { get; init; }
public required int CorrectAnswers { get; init; }
public required int TotalQuestions { get; init; }
public decimal CalculateGrade()
{
if (TotalQuestions == 0) return 0m;
return (decimal)CorrectAnswers / TotalQuestions * 100m;
}
}