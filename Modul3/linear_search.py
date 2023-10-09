data = [1,2,2,5,9,13,14,17]
def linear_search(): 
    found = False
    for i in range(len(data)-1): 
            if data[i+1] - data[i] == 3:  
                print(f'data yang menghasilkan selisih 3 yaitu {data[i+1],data[i]}')
                found = True
    if not found :
        print("Tidak terdapat angka yang selisihnya mengahsilkan 3")
linear_search() 