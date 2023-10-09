abjad = 'qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM'
abjas = 'mnbvcxzlkjhgfdsapoiuytrewqMNBVCXZLKJHGFDSAPOIUYTREWQ'
data_index = []
in1 = input()
for a in in1:
    if a in abjad :
        data_index.append(abjad.index(a))
    else:
        data_index.append(a)
for b in data_index:
    if type(b) == int:
        print(abjas[b],end='')
    else:
        print(b,end='')