using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public static class StartExternalPythonCode
{
    public static void StartCode(string pythonPath, string scriptPath)
    {
        ProcessStartInfo processStartInfo = new ProcessStartInfo();
        processStartInfo.FileName = "python.exe";
        processStartInfo.Arguments = @scriptPath;
        processStartInfo.UseShellExecute = true;
        processStartInfo.RedirectStandardOutput = false;
        Process process = Process.Start(processStartInfo);
        process.WaitForExit();

    }
}
