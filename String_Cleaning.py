in1 = input('Type Here:\n')
res = ''
for a in in1:
    print(a)
    if a.isnumeric():
        continue
    else:
        res+=a
print(res)