from socket import *

serverName = '127.0.0.1'            # Serverens adresse (localhost addresse)
serverPort = 12000
clientSocket = socket(AF_INET, SOCK_STREAM)
clientSocket.connect((serverName, serverPort))

while True:
    command = input("Skriv kommando (Random/Add/Subtract) eller 'exit' for at stoppe: ")
    clientSocket.send(command.encode())

    if command.lower() in ["exit", "quit", "stop"]: # Lukker klienten
        print("Lukker klient...")                   # Bekræfter og fortæller at klienten lukker
        break

    msg = clientSocket.recv(1024).decode()
    print(f'Server siger: {msg}')

    nums = input("Skriv to tal med mellemrum")
    clientSocket.send(nums.encode())

    res = clientSocket.recv(1024).decode()
    print(f'Resultat fra server: {res}')

clientSocket.close()