dict1 = {    '1':690,    '2':420,    '3':530,    '4':330}
tot = 0
in1 = int(input())
for a in range(in1):
    in2 = input()
    a = dict1.get(in2)
    tot += a
print(f'Jumlah hari yang diperlukan ialah : {tot//365} Tahun, {(tot % 365) // 30} Bulan, {(tot%365)%30} Hari')