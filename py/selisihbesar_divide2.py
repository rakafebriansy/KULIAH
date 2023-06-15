def cariGap(list1):
    print(list1)
    if (len(list1) == 1) :
        return 0, list1[0], list1[0] # gap, batas kiri, batas kanan
    elif (len(list1) == 2) :
        return abs(list1[1] - list1[0]), list1[0], list1[1]
    else :
        mid = len(list1)//2
        gapl, lol, rol = cariGap(list1[:mid])
        gapr, lor, ror = cariGap(list1[mid:])
        gmid = abs(lor - rol)
        gap = max(gapl, gapr, gmid);
        print(lol)
        return(gap, lol, ror)     
list1 = [12, 3, 13, 87, 7, 51, 8]
gap, lol, ror = cariGap(list1)
print(gap)