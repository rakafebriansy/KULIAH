import csv
import os

clear_screen = lambda : os.system('cls' if os.name == 'nt' else 'clear')

#bubble sort
def bubble_sort(data_list):
    clear_screen()
    n = len(data_list)
    for i in range(n):
        for j in range(n-i-1):
            if data_list[j][0] > data_list[j+1][0]:
                data_list[j], data_list[j+1] = data_list[j+1],data_list[j] 
    return data_list

#bubble sort 1
def bubble_sort1(data_list):
    clear_screen()
    n = len(data_list)
    for i in range(n):
        for j in range(n-i-1):
            if data_list[j][0][1] > data_list[j+1][0][1]:
                data_list[j], data_list[j+1] = data_list[j+1],data_list[j] 
    return data_list

#selection Sort
def selection_sort(data_list):
    clear_screen()
    for i in range(len(data_list)):
        min_index = i
        for j in range(i + 1, len(data_list)):
            if data_list[j] < data_list[min_index]:
                min_index = j
        data_list[i], data_list[min_index] = data_list[min_index], data_list[i]
    return data_list

#selection Sort 1
def selection_sort1(data_list):
    clear_screen()
    for i in range(len(data_list)):
        min_index = i
        for j in range(i + 1, len(data_list)):
            if data_list[j][0][1] < data_list[min_index][0][1]:
                min_index = j
        data_list[i], data_list[min_index] = data_list[min_index], data_list[i]
    return data_list

# insertion_sort               
def insertion_sort(data_list):
    clear_screen()
    for i in range(1, len(data_list)):
        key = data_list[i]
        j = i - 1
        while j >= 0 and key < data_list[j]:
            data_list[j+1] = data_list[j]
            j -= 1
            data_list[j+1] = key
    return data_list

# insertion_sort 1           
def insertion_sort1(data_list):
    clear_screen()
    for i in range(1, len(data_list)):
        key = data_list[i]
        j = i - 1
        while j >= 0 and key[0][1] < data_list[j][0][1]:
            data_list[j+1] = data_list[j]
            j -= 1
            data_list[j+1] = key
    return data_list

#kamus
def kamus():
        clear_screen()
        print("================================")
        print("---------Selamat Datang---------")
        print("-------------KAMUS!-------------")
        print("================================")
        print("1. Sorting berdasarkan English")
        print("2. Sorting berdasarkan Indonesia")
        print("0. Keluar")
        kamus = int(input("Masukkan pilihan sortingan : "))
        if kamus == 1 :
            data_list = load_data()
            pilih(data_list)
            clear_screen()
        elif kamus == 2 :
            data_list = load_data()
            pilih1(data_list)
            clear_screen()
        elif kamus == 0 :
            clear_screen()
            print('Terima kasih telah menggunakan kamus !')
            exit()
def load_data():
    data_list = []
    with open('kamus.csv','r') as data:
            temporary = csv.reader(data)
            for i in temporary:
                 data_list.append([i])
    return data_list
#Sorting English
def pilih(data_list):
        clear_screen()
        print("-------Sortingan English-------")
        print("1. Bubble Sort")
        print("2. Selection Sort")
        print("3. Insertion Sort")
        print("0. Kamus")
        menu = int(input("Masukkan angka : "))
        if menu == 1 :
            bubble_sort(data_list)
            print(data_list)
            input("Tekan enter untuk kembali kemenu utama !")
            clear_screen()
            pilih(data_list)
        if menu == 2 :
            selection_sort(data_list)
            print(data_list)
            input("Tekan enter untuk kembali kemenu utama !")
            clear_screen()
            pilih(data_list)
        if menu == 3 :
            insertion_sort(data_list)
            print(data_list)
            input("Tekan enter untuk kembali kemenu utama !")
            clear_screen()
            pilih(data_list)
        if menu == 0 :
            clear_screen()
            kamus()
#Sorting Indonesia
def pilih1(data_list):
        clear_screen()
        print("-------Sortingan Indonesia-------")
        print("1. Bubble Sort")
        print("2. Selection Sort")
        print("3. Insertion Sort")
        print("0. Keluar")
        menu = int(input("Masukkan angka : "))
        if menu == 1 :
            bubble_sort1(data_list)
            print(data_list)
            input("Tekan enter untuk kembali kemenu utama !")
            clear_screen()
            pilih1(data_list)
        if menu == 2 :
            selection_sort1(data_list)
            print(data_list)
            input("Tekan enter untuk kembali kemenu utama !")
            clear_screen()
            pilih1(data_list)
        if menu == 3 :
            insertion_sort1(data_list)
            print(data_list)
            input("Tekan enter untuk kembali kemenu utama !")
            clear_screen()
            pilih1(data_list)
        if menu == 0 :
            clear_screen()
            kamus()
kamus()