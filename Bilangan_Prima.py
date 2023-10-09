
def prima1(bil):
    count = 2
    for i in range(2,bil):
        print(i)
        if bil%i == 0:
            count+=1
    if count > 2:
        return False
    else:
        return True
print(prima1(5000))

def prima2(bil):
    for i in range(2,bil): #kenapa mulai dari 2? karena menghindari bil dibagi 0 dan 1
        print(i) #ini buat nunjukin iterasi
        if bil%i == 0:
            return False
    return True
print(prima2(5000)) #masukan bilangannya disini