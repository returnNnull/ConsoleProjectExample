// See https://aka.ms/new-console-template for more information

var task1 = LongTask();
var task2 = LongTask2();
var task3 = LongTask3();


var result1 = await task1;
var result2 = await task2;
var result3 = await task3;

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);

async Task<string> LongTask()
{
    Console.WriteLine("Start method1");
    await Task.Delay(1000);
    return "End method1";

}

async Task<string> LongTask2()
{
    Console.WriteLine("Start method2");
    await Task.Delay(1000);
    return "End method2";

}

async Task<string> LongTask3()
{
    Console.WriteLine("Start method3");
    await Task.Delay(1000);
    return "End method3";

}