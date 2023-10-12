prima = [2,3,5,7,11,13,17,19,23,29,31,37,41,43,47]
data1 = []
in1 = int(input())
for a in range(in1):
    in2 = int(input())
    data1.append(in2)
for b in data1:
    count = 0
    for c in prima:
        if c >= b:
            break
        else:
            count+=1
    print(count)
