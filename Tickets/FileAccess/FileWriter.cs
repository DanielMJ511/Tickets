﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.FileAccess;
namespace TicketsDataAggregator.FileAccess;

public class FileWriter : IFileWriter
{
    public void Write(
        string content, params string[] pathParts)
    {
        var resultPath = Path.Combine(pathParts);
        File.WriteAllText(resultPath, content);
        Console.WriteLine("Results saved to " + resultPath);
    }
}