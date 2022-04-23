import asyncio
import websockets

async def repeatDataRequest(websocket):
    dataToSendToUnity = input("Input some sample data that unity should print to the console, submit close to stop\n")
    await websocket.send(dataToSendToUnity)
    dataRecievedFromUnity = await websocket.recv()
    print(f"< {dataRecievedFromUnity}")
    if dataToSendToUnity != "close":
        await repeatDataRequest(websocket)
    

async def sampleServer():
    url = "ws://localhost:4649/SampleServerSocket"
    async with websockets.connect(url) as websocket:
        await repeatDataRequest(websocket)

asyncio.get_event_loop().run_until_complete(sampleServer())