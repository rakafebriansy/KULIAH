def palindrom(input):
    input = ''.join(e for e in input if e.isalnum()).lower()
    for i in range(len(input)//2):
        if input[i] != input[-i-1]:
            return False
    return True
input = input("Masukkan sebuah Kata: ")
if palindrom(input):
    print("Kata tersebut adalah palindrom")
else:
    print("Kata tersebut bukan palindrom")