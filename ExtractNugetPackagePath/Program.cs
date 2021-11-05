﻿using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ExtractNugetPackagePath
{
    class Program
    {
        static void Main(string[] args)
        {
            //unescaped regex: (?<=Successfully created package ')[\w\:\\\-\.]*(?=')

            string sourceStr = File.ReadAllText("packageoutput");

            //string regexStr = File.ReadAllText("etc/regex.txt");
            string parsedRegexStr = "(?<= Successfully created package ')[\\w\\:\\\\\\-\\.]*(?=')";

            Regex packagePathRegex = new Regex(parsedRegexStr);
            var match = packagePathRegex.Match(sourceStr);

            if (match.Success)
            {
                //https://stackoverflow.com/questions/19774155/returning-a-string-from-a-console-application
                Console.Out.Write( match.Value);
                //Environment.SetEnvironmentVariable("NUGETPACKAGEPATH", match.Value);
            }
            else
            {
                throw new Exception($"No regex match");
            }


        }
    }
}
