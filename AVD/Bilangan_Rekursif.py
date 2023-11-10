list = input('Masukkan bilangan: ').split()
def palindrom(list):
    if len(list) <2 :
        return True
    if list[0] == list[-1]:
        list.remove(list[0])
        list.pop()
        return palindrom(list)
    else:
        return False
print(palindrom(list))