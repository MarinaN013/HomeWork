n = int(input("Введите число "))
c=1
k=1
b=3
while b<n+2:
    m=k+c
    k=c
    c=m
    b=b+1
    if m==n:
            print(b)
            break
else: print("-1")

