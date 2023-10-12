list = [1,2,2,1]
def palindrom(list):
    if len(list) < 2: #base case
        return True
    if list[0] == list[-1]:
        return palindrom(list[1:-1]) #recursive case
    else:
        return False
print(palindrom(list))