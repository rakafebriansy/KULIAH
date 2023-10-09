import csv, pandas, os #PREPROCESS
def banner():
    os.system('cls'), print(('='*54)+'\n'+' Daftar Nilai Mahasiswa '.center(54,'-')+'\n'+('='*54))
def selectionsort(arr, operand):
    for i in range(len(arr)-1):
        min = i
        for j in range(i+1, len(arr)):
            if operand == 'tertinggi' and int(arr[min][3]) < int(arr[j][3]):
                min = j
            elif operand == 'terendah' and int(arr[min][3]) > int(arr[j][3]):
                min = j
        arr[i], arr[min] = arr[min], arr[i]
    return arr
def insertionsort(arr):
    for i in range(1,len(arr)):
        x, y = arr[i], i-1
        while x[3] == arr[y][3] and y >= 0 and x[2] < arr[y][2]:
            arr[y+1] = arr[y]
            y-=1
        arr[y+1] = x
    return arr
banner() #PROCESS
in1 = input('Urut nilai berdasarkan? (tertinggi/terendah)\n\n').lower()
with open('nilaimhs.csv','r') as raw:
    grades, columname, translated = [], ['Kelas', 'NIM', 'Nama', 'Nilai'], csv.reader(raw)
    for data in translated:
        grades.append(data)
    banner(), print(pandas.DataFrame(insertionsort(selectionsort(grades, in1)), index = [i + 1 for i in range(len(grades))], columns= columname)
                    if in1 == 'tertinggi' or in1 == 'terendah'
                    else False)