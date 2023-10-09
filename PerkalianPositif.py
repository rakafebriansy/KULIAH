import time
def perkalian1(a,b):
    hasil = 0
    if a > b :
        for i in range(b):
            hasil+=a
    else :
        for i in range(a):
            hasil+=b
    return hasil
perkalian1(34521,48763)
def perkalian2(a,b,hasil=0):
    if a> b:
        a, b = b, a
    prime = 0
    for i in range(2,a):
        if a%i == 0:
            prime += i
            break
    new_b = 0
    for i in range(prime):
        new_b+=b
    for i in range(int(a/prime)):
        hasil+=new_b
    return hasil
perkalian2(34521,48763)
list_bil = [[34521,48763],[298764,233912],[980239, 123498]]