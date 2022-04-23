using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using WebSocketSharp.Server;

public class SampleServerSocket : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        Debug.Log(e.Data);
        Send(e.Data + " Printed to Console in Unity successfully!\n");
    }
}

public class SampleServer
{
    WebSocketServer wssv;
    // Start is called before the first frame update
    public SampleServer()
    {
        wssv = new WebSocketServer(4649);
        wssv.AddWebSocketService<SampleServerSocket>("/SampleServerSocket");
        Debug.Log("Server Constructed");
    }
    [ContextMenu("Open")]
    public void OpenServer()
    {
        wssv.Start();
        Debug.Log("Server Opened");
    }
    [ContextMenu("Close")]
    public void CloseServer()
    {
        wssv.Stop();
    }
}