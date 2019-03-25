# Код написали: Зинченко Марк, Александр Решетников;
# Вариант 10;
def age(count = 0):
    ages = [0, 7, 17, 23, 30, 50, 65, 140]
    count += 1
    try:
        if your_age >= ages[count-1] and your_age <= ages[count]:
            print("Тебе", your_age ,"лет, чувак!")
            return
    except Exception:
        print("Шо за дичь у вас тут?")
    else:
        age(count)

try:
    your_year = int(input("Введите ваш год рождения:"))
except Exception:
    print("Вы ввели неправильно!")
else:
    now_year = 2019
    your_age = now_year - your_year
    age()