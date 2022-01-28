# ExtractNugetPackagePath
Very simple tool that extracts the package path from dotnet pack output (currently piped to a file called packageoutput)

Output from:
'dotnet pack error-reporting-csharp --configuration Release -o package > packoutputdotnet pack error-reporting-csharp --configuration Release -o package > packageoutput'


Update: replaced with a python script for more transparency on GHA
