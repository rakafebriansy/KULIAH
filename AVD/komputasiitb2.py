nim = int(input('Masukkan Akhiran NIM: '))
mod = nim%2

if mod == 1:
    if nim >= 1 and nim <= 100:
        print("Mahasiswa masuk ke kelas K1\n")
    elif nim >= 101 and nim <= 200:
        print("Mahasiswa masuk ke kelas K3\n")
    elif nim > 201 and nim <= 300:
        print("Mahasiswa masuk ke kelas K5\n")
    elif nim > 300:
        print("Mahasiswa masuk ke kelas K7\n")
if mod == 0:
    if nim >= 1 and nim <= 100:
        print("Mahasiswa masuk ke kelas K2\n")
    elif nim >= 101 and nim <= 200:
        print("Mahasiswa masuk ke kelas K4\n")
    elif nim > 201 and nim <= 300:
        print("Mahasiswa masuk ke kelas K6\n")
    elif nim > 300:
        print("Mahasiswa masuk ke kelas K8\n")
