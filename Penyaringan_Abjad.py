data1 = []
data2 = []
data3 = []
numb = 0
in1 = input('Type Here:\n')
for a in in1 :
    aa = [a]
    data1.append(aa)
    bb = ord(data1[numb][0])
    numb+= 1
    data3.append(bb)
for c in data3:
    if c == 32 or c >= 65 and c <= 90 or c >= 97 and c <= 122:
        data2.append(c)
    else:
        continue
numb*=0
data2_c = data2.copy()
for d in data2 :
    dd = (chr(d))
    data2.append(dd)
    numb+= 1
    if numb == len(data2_c):
        break
print(f"\nOutput:\n{''.join(data2[int(len(data2)/2):1000])}")
print('\nDAPET +3 GAK SIE....')