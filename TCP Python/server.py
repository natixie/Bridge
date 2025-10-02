from socket import *
import threading
import random

serverPort = 12000
serverSocket = socket(AF_INET, SOCK_STREAM)
serverSocket.bind(('', serverPort))
serverSocket.listen(5)                  # Lytter efter forbindelser max 5
print('The server is ready to receive')

def beregnerOgSvar(connectionSocket, addr):
    print(f'Connection established with {addr}')
    while True:
        message = connectionSocket.recv(1024).decode().strip()
        if not message:
            break
        print(f'Received message: {message}')

        if message.lower() in ["exit", "quit", "stop"]:
            print("klient afslutter forbindelsen")
            break

        if message == 'Random' or message == 'Add' or message == 'Subtract':
            connectionSocket.send(('Input numbers').encode())
            nums = connectionSocket.recv(1024).decode().strip()
            print(f'Received message: {nums}')
            parts = nums.split()        # Splitter tal med mellemrum
            if len(parts) == 2:
                no1 = int(parts[0])
                no2 = int(parts[1])
                if message == 'Random':
                    low = min(no1, no2)
                    high = max(no1, no2)
                    result = random.randint(low, high)
                elif message == 'Add':
                    result = no1 + no2
                elif message == 'Subtract':
                    result = no1 - no2
                
                connectionSocket.send((str(result) + "\n").encode())
                print(f'Sent back result: {result}')
        else:
            print('Did not receive a command')

        connectionSocket.close()
        print("Connection closed with", addr)

while True:
    connectionSocket, addr = serverSocket.accept()
    t = threading.Thread(target=beregnerOgSvar, args=(connectionSocket, addr))
    t.start()



