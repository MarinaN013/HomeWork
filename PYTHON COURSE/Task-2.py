"""Задача 2: Найдите сумму цифр трехзначного числа"""

number = int(input("Введите число- "))
sum=0
while number>0:
    x=number%10
    sum+=x
    number//=10
print(f"Сумма чисел равна {sum}")    

