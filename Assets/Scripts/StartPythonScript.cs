using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

//This is an example script to help explain the system
//Feel free to experiment
public class StartPythonScript : MonoBehaviour
{
    [Header("Use the context menu to run the example")]
    [Tooltip("Relative Path to Script/arguments (Args only if using compiled executable)")]
    public string scriptPath = @"ExamplePythonScript.py";
    [Tooltip("path to python.exe/compiled python executable")]
    public string pythonPath = @"python.exe";
    
    
    [ContextMenu("RunScript")]
    public void RunScript()
    {
        SampleServer server = new SampleServer();
        server.OpenServer();
        StartExternalPythonCode.StartCode(pythonPath,Application.dataPath + "/" + scriptPath);
    }
}
