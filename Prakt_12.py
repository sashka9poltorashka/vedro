# Код написали: Зинченко Марк, Александр Решетников;
# Файл содержит информацию о книгах: фамилия автора, 
# название книги, кол-во страниц, цена. 
# Определить самую дешевую книгу и вывести название на экран.

min_price = -1 # ценник на книгу не может быть меньше нуля
min_indexs = []

with open('price1.txt') as file:
    lines = file.readlines()

index = 0
for i, line in enumerate(lines):
    x = line.rfind('Стоимость: ') + 11

    price = line[x: line.rfind('.')]
    print(line[x: line.rfind('.')], i)
    try:
        price = int(price)
    except Exception:
        print(file, 'Ошибка: структура файла нарушена в',i+1,'-й строке')
        continue
    
    if i == 1:
        min_price = price
    
    if price < min_price:
        min_price = price
        min_indexs = [i]
    elif price == min_price:
        min_indexs.append(i)

print('Самые дешевые книги: ' )
[print(' ' + lines[index]) for index in min_indexs]
