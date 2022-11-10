# Введение 
Пицца – это одно из тех блюд, которое пользуется популярностью и спросом в скромных закусочных и дорогих ресторанах. Кроме того, в последнее время появилось множество желающих заказать пиццу на дом. Кроме того, в последнее время появилось множество желающих заказать пиццу на дом. Поэтому ___доставка пиццы___ очень актуальна в наши дни.
## 1. Предметная область
### 1.1 Анализ предметной области
В условиях перехода общества в информационную эпоху, все большую актуальность приобретают автоматизированные системы и бизнес-процессы. Пицца — это всемирно известное блюдо, сочетание изысканности и доступности. Вот почему пиццерия — очень выгодный бизнес. Поэтому целью качественного обслуживания клиентов является автоматизированная служба доставки.
Комплексная автоматизация управления предприятия на сегодняшний день - один из самых эффективных и функциональных инструментов систематизации работы ключевых бизнес-процессов. Зачастую управление бизнес-процессами становится трудоемким, а анализ большого потока первичных данных отнимает много сил, времени.
В условиях современной жизни требуется ускорение процессов обработки информации. Этот процесс подлежит автоматизации, так как обработка информации очень долгий, кропотливый и требующий больших ресурсов процесс.
Системы автоматизации пиццерий ощутимо повышают скорость и удобство работы в целом, увеличивают прибыльность, а отчеты и аналитика программы дадут ту ключевую и актуальную информацию, которая откроет ясную и четкую картину ведения вашего бизнеса. 
Возможность управлять доставкой пиццы при наличии нескольких точек приготовления пиццы позволяет сократить время доставки - программа сама, исходя из заданных критериев (остатков еды, расстояние до клиента), выберет место исполнения заказа. 
Система рассчитывает оптимальные маршруты доставки, что особенно важно для доставки пиццы. Так, каждый сотрудник будет максимально загружен, а вся необходимая информация будет выведена на экране его мобильного телефона.  
Приложение, которым оснащается пеший курьер или водитель, отслеживает местонахождение курьера и состояние заказа в режиме реального времени. Оно поможет курьеру проложить маршрут, связаться с клиентом, фиксировать выполнение заказа. 


 
### 1.2 Создание BPMN-модели 
Основные блюда:
-	Пицца большого размера (60 см)
-	Пицца среднего размера (30 см)
-	Бургер
-	Картошка фри
-	Картошка по-деревенски
-	Газированные напитки
-	Негазированные напитки
Персонал:
-	Администратор
-	Повар
-	Курьер
Режим работы:
С 8:00 до 22:00

Клиент заказывает товар из каталога блюд и заполняет свою контактную информацию. Администратор вносит информацию о клиенте в базу данных, передает заказ повару и формирует маршрутный чек-лист доставки. Если товар доставлен вовремя, клиент платит деньги и ест еду.
Оптимальное формирование чек-листа для доставки заключается в том, что система автоматически просчитывает наименьшее время для доставки на несколько адресов.
Если доставка задерживается более чем на 40 минут, клиент подаёт жалобу в сервис. По истечении этих 40 минут даётся ещё 20 минут на доставку.
За опоздание штраф получает курьер и оплачивает его. 
Если за это время товар не доставлен (60 мин), клиент имеет право отказаться от заказа с возвратом денег.
Клиент может оплатить заказ до его получения онлайн, либо после получения онлайн или наличными.

## Диаграмма BPMN (рисунки 1-4)
 ![image](https://user-images.githubusercontent.com/68990296/193074428-b91e0a04-ffd2-4a56-a17f-b04a93723b3b.png)
 
 Рисунок 1 - Полная диаграмма бизнес процесса

 ![image](https://user-images.githubusercontent.com/68990296/193074467-57c0f7f9-e358-4973-bcd3-f86cb8ea440d.png)
 
 Рисунок 2 - Формирование чек-листа для доставок

 ![image](https://user-images.githubusercontent.com/68990296/193074520-1066dccc-135c-411c-851f-83e0004ca7ac.png)
 
 Рисунок 3 - Доставка блюд ограничивается по времени

 ![image](https://user-images.githubusercontent.com/68990296/193074574-eee1f3bc-4a60-41cb-aa6b-64b418912a52.png)
 Рисунок 4 - Передача заказа клиенту
 
### 1.3 Use Case модель (рисунок 5)
Диаграмма вариантов использования
![use-case](https://user-images.githubusercontent.com/68990296/201192346-f5928d9a-9b46-4690-819c-5f1a92b6eb36.png)
Рисунок 5 - Use Case модель "Доставка пиццы"


### 1.4 Создание ER-диаграммы (рисунок 6)
![image](https://user-images.githubusercontent.com/68990296/200371669-9f75ac0f-9582-42d1-8524-d3b7db8e110b.png)

Рисунок 6 - ER-диаграмма "Доставка пиццы"

 
