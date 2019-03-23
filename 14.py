#Вариант 7
#Создайте программу, которая каждые 10 секунд в течение минуты выводит случайным
#образом напоминание, о том сколько (дней или часов или недель, осталось до НГ или сессии).
import random, datetime, time
newYear = datetime.datetime(2020,1,1)
for i in range (0,7):
    today = datetime.datetime.today()
    days=str((newYear-today).days + (newYear-today).seconds/3600/24) + ' дней'
    weeks=str((newYear-today).days/7 + (newYear-today).seconds/3600/24/7) + ' недель'
    hours=str((newYear-today).days*24 + (newYear-today).seconds/3600) + ' часов'
    print(random.choice([days ,weeks ,hours]))
    if i!=6:
        time.sleep(1)

