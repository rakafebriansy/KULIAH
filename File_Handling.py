file = open('D:\\KULIAH\\Python\\dummy.txt', "r")
add = file.readlines() 
add[2] = 'Matakulliah favoritnya adalah "Algo"\nMereka selalu semangat dan hebat'
file = open('D:\\KULIAH\\Python\\dummy.txt', "w")
file.writelines(add)
file.close()