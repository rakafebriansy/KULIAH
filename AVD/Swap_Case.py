in1 = input('Type Here:\n')
res = ''
for a in in1:
    if a.isalpha():
        if a.isupper():
            a = a.lower()
        elif a.islower():
            a = a.upper()
        res+=a
    else:
        res+=a
print(res)