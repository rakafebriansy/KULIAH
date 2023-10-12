list = input('Masukkan bilangan: ').split()
def cariTerbesar(list):
    if  len(list) == 1:
        return int(list[0])
    if int(list[0]) > int(list[-1]):
        list.pop()
    else:
        list.remove(list[0])
    return cariTerbesar(list)
print(cariTerbesar(list))