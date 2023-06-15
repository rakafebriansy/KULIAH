list = [9,21,7,1]
def cariTerbesar(list):
    print(list)
    if len(list) < 2: #base case
        return int(list[0])
    if int(list[0]) > int(list[-1]):
        return cariTerbesar(list[0:-1]) #recursive case
    else:
        return cariTerbesar(list[1::]) #recursive case
print(cariTerbesar(list))