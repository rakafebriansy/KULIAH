symbols = '!@#$%^&*()_+-=}{[]\|:";,./<>?'+"'"
alphabet = 'QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm'
number = '1234567890'
password = ''
import random
for a in range(3):
    pw1 = random.choice(tuple(alphabet))
    password+=pw1
pw2 = random.choice(tuple(symbols))
password+=pw2
for b in range(4): 
    pw3 = random.choice(tuple(number))
    password+=pw3
print(password)