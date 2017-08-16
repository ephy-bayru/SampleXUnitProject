# SampleXUnitProject
This is a sample project that utilizes `.Net` and `xUnit`. This project is not an actual project to be taken, rather a demonstration / testable example of the relivant technologies.

## Running this project
In order to run this project you must first install the .Net Core Framework (Available at https://dot.net)

Once the framework is installed you can open the `sln` file using Visual Studio and press "Run" or navigate to the `SampleProject` folder in command prompt or terminal and enter the command `dotnet run`

The application should print "Hello World" to Console. (Note: if running from Visual Studio, the prompt might close too fast for you to see this output)

## Running the tests
In order to run the tests you can open "Test Explorer" in Visual Studio and choose "Run all tests" or you can navigate to the `SampleTests` folder in command prompt or terminal and enter the command `dotnet test /verbosity:quiet` (if on OSX use `--` instead of `/`)

The results of these tests will populate the "Test Explorer Results" if in Visual Studio, otherwise results will be printed out to the console.

## Save test results
In order to have the results added to the file system navigate to the `SampleTests` folder and run `dotnet test /verbosity:quiet /logger "trx;LogFileName=filename.trx"` (Note: omitting the verbosity tag dramatically increases run time on tests for xunit at this time. .NET 2.0 8/14/2017)

This will add a `filename.trx` file containing xml with the tests results to a `TestResults` folder inside the `SampleTests` Folder.

Note: you can change the resulting file name by changing the value provided to `LogFileName`
