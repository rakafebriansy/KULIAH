data1 = 0
data2 = 0
in1 = input('Input 1: ')
in2 = input('Input 2: ')
for x in in1 :
    data1 += ord(x)
for y in in2 :
    data2 += ord(y)
if data1 > data2:
    print('Output: ',in1)
elif data2 > data1:
    print('Output: ',in2)
else:
    print('Output: ',in1,in2)