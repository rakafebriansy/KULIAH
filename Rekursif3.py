def ParentCheck(menuId, idnt = 0): 
    print("." * idnt + newData[menuId]["Label"])
    for x in newData:
        if newData[x]["Parent"] == menuId:
            ParentCheck(x , idnt +5)

loop = int(input())
newData = {}
for i in range(loop):
    menuId, parent, label = input().split()
    newData[menuId] = {"Parent" : parent, "Label" : label }
print(newData)
for j in newData:
    print(j)
    if newData[j]["Parent"] == "0":
        ParentCheck(j)