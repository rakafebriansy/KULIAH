kumpulanData = []
banyakData = int(input())
for i in range(banyakData):
    in1 = input().split()
    kumpulanData.append(in1)
def recursive(n,m):
    for data in kumpulanData:
        if int(data[1]) == n:
            print('...'*m+data[2])
            recursive(int(data[0]),m+1)
recursive(0,0)