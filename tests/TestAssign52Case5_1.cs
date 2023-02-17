using Xunit;
using System.IO;
using System;
using System.Text;

public class TestAssign52Case5_1
{

    [Fact]
    public void TestCase1()
    {
        //Sets the Out property to target the TextWriter object. Note that the System.IO.StringWriter is 
        //derived from TextWriter. The TextWriter class is an abstract class. Therefore, you do not 
        //instantiate it in your code.
        //The StreamWriter class derives from TextWriter and provides implementations of the members for 
        //writing to a stream. 
        var output = new StringWriter();
        Console.SetOut(output);

        //Sets the In property to the specified TextReader object. System.IO.StringReader is derived
        //from TextReader. The TextReader class is an abstract class. Therefore, you do not instantiate 
        //it in your code.
        //The StreamReader class derives from TextReader and provides implementations of the 
        //members for reading from a stream.
        //Use case 1
        var lastYearInput = "6";
        var thisYearInput = "31";
        var correctedThisYear = "30";
        //separte multiple inputs with a new line break
        var input = new StringReader(lastYearInput + Environment.NewLine + thisYearInput + Environment.NewLine + correctedThisYear);
        Console.SetIn(input);
        
        GreenvilleRevenue.Main();

        //use a string writer to format the expected outcome
        var expectedOutcome = new StringBuilder();
        expectedOutcome.Append("Enter number of contestants last year >> ");
        expectedOutcome.Append("Enter number of contestants this year >> ");
        expectedOutcome.AppendLine("Number must be between 0 and 30");
        expectedOutcome.Append("Enter number of contestants this year >> ");
        expectedOutcome.AppendLine(string.Format("Last year's competition had {0} contestants, and this year's has {1} contestants",lastYearInput,correctedThisYear));
        expectedOutcome.AppendLine("Revenue expected this year is $750.00");
        expectedOutcome.AppendLine("The competition is more than twice as big this year!");   

        Assert.Equal(expectedOutcome.ToString(), output.ToString());

        //clean up
        output.Dispose();
        input.Dispose();
    }

    //TODO: update test per the expected console input and output
    [Fact]
    public void TestCase2()
    {
        //use case 2
        var output = new StringWriter();
        Console.SetOut(output);

        //Use case 1
        var lastYearInput = "-1";
        var correctedLastYear = "10";
        var thisYearInput = "20";
        //separte multiple inputs with a new line break
        var input = new StringReader(lastYearInput + Environment.NewLine + correctedLastYear + Environment.NewLine + thisYearInput);
        Console.SetIn(input);
        
        GreenvilleRevenue.Main();

        //use a string writer to format the expected outcome
        var expectedOutcome = new StringBuilder();
        expectedOutcome.Append("Enter number of contestants last year >> ");
        expectedOutcome.AppendLine("Number must be between 0 and 30");
        expectedOutcome.Append("Enter number of contestants last year >> ");
        expectedOutcome.Append("Enter number of contestants this year >> ");
        expectedOutcome.AppendLine(string.Format("Last year's competition had {0} contestants, and this year's has {1} contestants",correctedLastYear,thisYearInput));
        expectedOutcome.AppendLine("Revenue expected this year is $500.00");
        expectedOutcome.AppendLine("The competition is bigger than ever!");

        Assert.Equal(expectedOutcome.ToString(), output.ToString());

        //clean up
        output.Dispose();
        input.Dispose();
    }

    [Fact]
    public void TestCase3(){
        //use case 3
        var output = new StringWriter();
        Console.SetOut(output);

        //Use case 1
        var lastYearInput = "26";
        var thisYearInput = "25";
        //separte multiple inputs with a new line break
        var input = new StringReader(lastYearInput + Environment.NewLine + thisYearInput);
        Console.SetIn(input);
        
        GreenvilleRevenue.Main();

        //use a string writer to format the expected outcome
        var expectedOutcome = new StringBuilder();
        expectedOutcome.Append("Enter number of contestants last year >> ");
        expectedOutcome.Append("Enter number of contestants this year >> ");
        expectedOutcome.AppendLine(string.Format("Last year's competition had {0} contestants, and this year's has {1} contestants",lastYearInput,thisYearInput));
        expectedOutcome.AppendLine("Revenue expected this year is $625.00");
        expectedOutcome.AppendLine("A tighter race this year! Come out and cast your vote!");

        Assert.Equal(expectedOutcome.ToString(), output.ToString());

        //clean up
        output.Dispose();
        input.Dispose();
    }
}
