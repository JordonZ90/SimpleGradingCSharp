using System;

namespace SimpleGrading
{
    class Program
    {
        static void Main(string[] args)
        {
            // GradingWithIfElseBlock();
            // GradingMinusIfElseBlock();
            GradingMinusIfElseBlockWithIntValidation();
        }
        public static void GradingWithIfElseBlock()
        {
            int counter = 0;
            int scoreTotal = 0;
            int testScore = 0;
            string grade = "";
            int averageScore = 0;


            Console.Write("Enter class size: ");
            int classSizeRatio = int.Parse(Console.ReadLine()) * 100;
            Console.WriteLine($"while test_score != {classSizeRatio}");
            while (testScore != classSizeRatio)
            {

                Console.Write("Enter test score ");
                testScore = int.Parse(Console.ReadLine());
                if (testScore >= 0 && testScore <= 100)
                {
                    scoreTotal += testScore;
                    counter += 1;
                }
                else
                {
                    Console.WriteLine("Discarding score");
                    Console.WriteLine($"Total score: {scoreTotal} ");
                    continue;
                }
                if (scoreTotal >= classSizeRatio)
                {
                    Console.WriteLine("Scoring complete");
                    Console.WriteLine($"Total score: {classSizeRatio} \nAverage score: {averageScore} \nGrade: {grade}");
                    break;
                }
                if (testScore >= 90)
                {
                    grade = "A";
                }
                else if (testScore >= 80)
                {
                    grade = "B";
                }
                else if (testScore >= 70)
                {
                    grade = "C";
                }
                else if (testScore >= 60)
                {
                    grade = "D";
                }
                else
                {
                    grade = "F";
                }
                averageScore = scoreTotal / counter;
                Console.WriteLine($"Total score: {scoreTotal} \nAverage score: {averageScore} \nGrade: {grade}");
            }
        }
        public static void GradingMinusIfElseBlock()
        {
            int counter = 0;
            int scoreTotal = 0;
            int testScore = 0;
            int averageScore = 0;


            Console.Write("Enter class size: ");
            int classSizeRatio = int.Parse(Console.ReadLine()) * 100;
            Console.WriteLine($"while test_score != {classSizeRatio}");
            while (testScore != classSizeRatio)
            {

                Console.Write("Enter test score ");
                testScore = int.Parse(Console.ReadLine());

                string gradeLetter = (testScore >= 90) ? "A" :
                (testScore >= 80) ? "B" :
                (testScore >= 70) ? "C" :
                (testScore >= 60) ? "D" :
                "E";


                if (testScore >= 0 && testScore <= 100)
                {
                    scoreTotal += testScore;
                    counter += 1;
                }
                else
                {
                    Console.WriteLine("Discarding score");
                    Console.WriteLine($"Total score: {scoreTotal} ");
                    continue;
                }
                if (scoreTotal >= classSizeRatio)
                {
                    Console.WriteLine("Scoring complete");
                    Console.WriteLine($"Total score: {classSizeRatio} \nAverage score: {averageScore} \nGrade: {gradeLetter}");
                    break;
                }
                averageScore = scoreTotal / counter;
                Console.WriteLine($"Total score: {scoreTotal} \nAverage score: {averageScore} \nGrade: {gradeLetter}");
            }
        } // while (!int.TryParse(Console.ReadLine(), out classSizeRatio))
        public static void GradingMinusIfElseBlockWithIntValidation()
        {
            int counter = 0;
            int scoreTotal = 0;
            int testScore = 0;
            int averageScore = 0;
            int classSizeRatio = 0;


            Console.Write("Enter class size: ");
            while (!int.TryParse(Console.ReadLine(), out classSizeRatio))
            {
                Console.WriteLine("Please enter a valid number");
                Console.Write("Enter class size: ");
            }
            int classSize = classSizeRatio;
            classSizeRatio *= 100;
            Console.WriteLine($"Max points possible {classSizeRatio}");

            while (testScore != classSizeRatio && counter != classSize)
            {

                Console.Write("Enter test score ");
                testScore = int.Parse(Console.ReadLine());

                string gradeLetter = (testScore >= 90) ? "A" :
                (testScore >= 80) ? "B" :
                (testScore >= 70) ? "C" :
                (testScore >= 60) ? "D" :
                "E";


                if (testScore >= 0 && testScore <= 100)
                {
                    scoreTotal += testScore;
                    counter += 1;
                }
                else
                {
                    Console.WriteLine("Discarding score");
                    Console.WriteLine($"Total score: {scoreTotal} ");
                    continue;
                }
                if (scoreTotal >= classSizeRatio)
                {
                    Console.WriteLine("Scoring complete");
                    Console.WriteLine($"Total score: {classSizeRatio} \nAverage score: {averageScore} \nGrade: {gradeLetter}");
                    break;
                }
                averageScore = scoreTotal / counter;
                Console.WriteLine($"Total score: {scoreTotal} \nAverage score: {averageScore} \nGrade: {gradeLetter}");
            }
        }
    }
}
