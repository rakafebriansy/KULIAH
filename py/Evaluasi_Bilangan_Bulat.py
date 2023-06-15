input = int(input("Masukkan angka:"))
mod = input%2

if mod == 1:
    if input < 10:
        print("Bilangan tersebut adalah bilangan gasal dan termasuk dalam nilai kecil")
    elif input >= 10 and input <= 50 :
        print("Bilangan tersebut adalah bilangan gasal dan termasuk dalam nilai sedang")
    elif input > 50:
        print("Bilangan tersebut adalah bilangan gasal dan termasuk dalam nilai besar")
elif mod == 0:
    if input < 10:
        print("Bilangan tersebut adalah bilangan genap dan termasuk dalam nilai kecil")
    elif input >= 10 and input <= 50 :
        print("Bilangan tersebut adalah bilangan genap dan termasuk dalam nilai sedang")
    elif input > 50:
        print("Bilangan tersebut adalah bilangan genap dan termasuk dalam nilai besar")