in1 = int(input())
for a in range(1,1000):
    if a == in1+1:
        break
    if a%3 == 0 and a%5 == 0:
        print('FizzBuzz')
    elif a%3 == 0 :
        print('Fizz')
    elif a%5 == 0 :
        print('Buzz')
    else:
        print(a)