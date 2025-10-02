from socket import *
import threading
import random
import json

serverPort = 11000
serverSocket = socket(AF_INET, SOCK_STREAM)
serverSocket.bind(('', serverPort))
serverSocket.listen(5)                                #Lytter efter forbindelser Max 5
print('JSON Beregner og svar server is ready to receive')

def jsonBeregnerOgSvar(connectionSocket, addr):
    print(f'Connection established with {addr}')
    while True:
        try:
            message = connectionSocket.recv(1024).decode()
            if not message:
                break
            print(f"Received raw: {message}")

            data = json.loads(message)
            command = data.get("command")
            numbers = data.get("numbers", [])

            if command == "exit":
                print("Client afslutter forbindelsen")
                break

            if command == "Random" and len(numbers) == 2:
                result = random.randint(min(numbers), max(numbers))
            elif command == "Add" and len(numbers) == 2:
                result = numbers[0] + numbers[1]
            elif command == "Subtract" and len(numbers) == 2:
                result = numbers[0] - numbers[1]
            else:
                result = None

            response = { "result": result }           #Laver JSON svar
            connectionSocket.send(json.dumps(response).encode())
            print(f"Sent back: {response}")

        except Exception as e:
            print("Error:", e)
            break

    connectionSocket.close()
    print(f"Connection closed with {addr}")

while True:
    connectionSocket, addr = serverSocket.accept()
    t = threading.Thread(target=jsonBeregnerOgSvar, args=(connectionSocket, addr))
    t.start()