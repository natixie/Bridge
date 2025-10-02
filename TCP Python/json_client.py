from socket import *
import json

serverName = '127.0.0.1'        # Serverens adresse
serverPort = 11000              # JSON Serverens port
clientSocket = socket(AF_INET, SOCK_STREAM)
clientSocket.connect((serverName, serverPort)) 

print("Forbindelse er oprettet til serveren\n")

while True:
    command = input("Skriv kommando (Random/Add/Subtract) eller 'exit' for at stoppe: ")

    if command.lower() in ["exit", "quit", "stop"]:         # For at lukke klienten
        msg = { "command": "exit" }
        clientSocket.send(json.dumps(msg).encode())         # Sender exit til serveren
        print("Lukker klient...")
        break

    no1 = int(input("Skriv første tal: "))
    no2 = int(input("Skriv andet tal: "))

    msg = { "command": command, "numbers": [no1, no2] }     # Laver JSON objekt
    clientSocket.send(json.dumps(msg).encode())             # Sender JSON til server
    print(f"Sent: {msg}")

    res = clientSocket.recv(1024).decode()
    data = json.loads(res)
    print(f"Server siger: {data}")

clientSocket.close()