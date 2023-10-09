in1 =  input('Enter the text:  ').lower()
inBersih = ''
for i in in1:
    if i.isalpha():
        inBersih+=i
def recursive1(kalimat, n):
    if n == 0:
        return kalimat[0]
    else:
        return kalimat[n] + recursive1(kalimat, n-1)
inReverse = recursive1(inBersih, len(inBersih)-1)
if inBersih == inReverse:
    print('\nPalindrome')
else: 
    print('\nNot a Palindrome')