alphabet = 'qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM '
in1 = input('Type Here:\n')
for a in in1:
    if a in alphabet:
        print(a, end='')