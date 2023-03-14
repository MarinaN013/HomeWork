
n = int(input("Введите общее количество арбузов: "))
a=[]
for i in range(0,n,1):
    a.insert(i,int(input("Введите вес арбуза: ")))
max=a[i]
min=a[i]
for i in range(0,len(a),1):
    if a[i]>max:
        max=a[i]
    elif a[i]< min:
        min=a[i]
print(f"Максимальный вес арбуза равен: {max}, минимальный вес равен: {min}")