def selisihBrute(a):
    besar = 0
    for i in range(len(a)-1):
        x = abs(a[i] - a[i+1])
        if x > besar :
            besar = x
    return besar
LIST = [12,1,1,2,5,71,6,0,14]
print(selisihBrute(LIST))