sum= int(input("Введите суму чисел: "))
mult = int(input("Введите произведение чисел: "))

N=sum//2
for i in range(1,N,1):
    if ((N-i)*(N+i))==mult:
        Number1=N-i
        Number2=N+i
        print(f"первое число: {Number1}, второе число: {Number2}")
