using System;
using UnityEngine;

public class Utilities
{
    public static void Log(string message)
    {
        Console.WriteLine(message);
        Debug.LogFormat(LogType.Log, LogOption.NoStacktrace, null, message);
    }
}
