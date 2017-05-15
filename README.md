# SampleXUnitProject
This is a sample project that utilizes `.Net` and `xUnit`. This project is not an actual project to be taken, rather a demonstration / testable example of the relivant technologies.

## Running this project
In order to run this project you must first install the .Net Core Framework (Available at https://dot.net)

Once the framework is installed you can open the `sln` file using Visual Studio and press "Run" or navigate to the `SampleProject` folder in command prompt or terminal and enter the command `dotnet run`

The application should print "Hello World" to Console. (Note: if running from Visual Studio, the prompt might close too fast for you no see this output)

## Running the tests
In order to run the tests you can open "Test Explorer" in Visual Studio and choose "Run all tests" or you can navigate to the `SampleTests` folder in command prompt or Terminal and enter the command `dotnet test`

The results of these tests will populate the "Test Explorer Results" if in Visual Studio, otherwise results will be printed out to the screen.

## Getting Test Results recorded to filesystem
In order to have the results added to the file system navigate to the `SampleTests` folder and run `dotnet test --logger "trx;LogFileName=filename.trx"

This will add a `filename.trx` file containing xml with the tests results to a `TestResults` folder inside the `SampleTests`Folder.

Note: you can change the resulting file name by the value provided to `LogFileName`
