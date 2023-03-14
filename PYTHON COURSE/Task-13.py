
n = int(input("Введите общее количество рассматриваемых дней: "))
a=[]
for i in range(0,n,1):
    a.insert(i,int(input("Введите среднесуточную температуру: ")))
b=0
for i in range(0,len(a),2):
    if a[i]+a[i+1]>0:
        b=b+1
print(f"Оттепель длилась {b} дней")