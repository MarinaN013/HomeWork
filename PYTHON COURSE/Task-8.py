"""Задача 8: Требуется определить, можно ли от шоколадки размером n
× m долек отломить k долек, если разрешается сделать один разлом по
прямой между дольками (то есть разломить шоколадку на два
прямоугольника)."""

n = int(input("Введите кол-во долек по горизнтали- "))
m = int(input("Введите кол-во долек по вертикали- "))
k = int(input("Сколько нужно отломить долек- "))

if n<=m:
    sum=n
else: sum=m
a=sum
while sum<n*m:
    if sum==k:
        print("Yes")
        break
    sum+=a
else: print("NO") 
