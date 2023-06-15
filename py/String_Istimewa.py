kiri = ['q','w','e','r','t','a','s','d','f','g','z','x','c','v','b']
kanan = ['y','u','i','o','p','h','j','k','l','n','m']
data1 = []
num1 = -1
kondisi = True
in1 = input('Input:')
for a in in1:
    mod = len(data1)%2
    num1+=1
    if len(data1)>=1 and mod==0 and a in kiri:
        if data1[num1-1] in kiri:
            kondisi = False
            break
        else:
            data1.append(a)
    elif len(data1)>=1 and mod==0 and a in kanan :
        if data1[num1-1] in kanan:
            kondisi = False
            break
        else:
            data1.append(a)
    elif len(data1)>=1 and mod==1 and a in kiri:
        if data1[num1-1] in kiri:
            kondisi = False
            break
        else:
            data1.append(a)
    elif len(data1)>=1 and mod==1 and a in kanan:
        if data1[num1-1] in kanan:
            kondisi = False
            break
        else:
            data1.append(a)
    elif ord(a) >= 97 and ord(a) <= 122 :
        data1.append(a)
    else:
        kondisi = False
        break
print('Output: ',kondisi)