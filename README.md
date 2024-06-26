# Практична робота №1
# РОЗРОБКА КОМПОНЕНТІВ
## Постановка завдання
Створити додаток, який складається з двох програмних одиниць (проектів) – бібліотеки з компонентом (елементом управління) та файлу, що запускається та використовує компонент із бібліотеки. Розробити компонент шляхом наслідування та/або об'єднання декількох стандартних компонентів в один власний. Виконати його встановлення у середовище розробки Visual Studio та продемонструвати можливість повторного використання.  
Основні вимоги до роботи наведені в таблиці 1.1, а варіанти функціональних вимог до компонента в таблиці 1.2 при цьому у компонента має бути як мінімум одна властивість та одна подія з рекомендованих у варіанті або запропонованих самим автором роботи. Допускається реалізація цілком власного варіанта компонента з аналогічними вимогами до складності (після обговорення з викладачем).

Таблиця 1.1 Основні вимоги до роботи

| № | Вимоги до роботи  | Бали | Що виконано| 
---| ------------- | ------------- |---|
1|Реалізація компоненту та основної програми окремими проектами в рамках одного рішення (Solution)| 1  | +
2| Реалізація власних властивостей та подій компонента, що відображаються в редакторі властивостей (Properties) | 2  | +
3| Реалізація функціональності компонента згідно завдання | 2  | +
4| Прив'язка піктограми до компонента для відображення на панелі інструментів | 2  | +
5| Прив'язка меж та пропорційна зміна внутрішніх елементів щодо загального розміру компонента | 1  | +
6| Реалізація додаткової програми тестування в окремому рішенні (Solution) та підключення компонента через менеджер пакетів NuGet | 1  | -

Таблиця 1.2 Варіант 19, функціональні вимоги до компонента
| № | Призначення та функціональність компонента  | Властивості | Події | 
---| ------------- | ------------- |---|
19|Кнопка із блокуванням на заданий час після натискання| час блокування  | розблокування кнопки

# Виконання роботи
 - Реалізація компоненту (ControlLibrary) та основної програми (Lab_1_Button) окремими проектами в рамках одного рішення  
![image](https://github.com/JuliaSylenok/Lab_1_Sylenok_Net/assets/149322465/1ed9587d-5fd5-44ee-9f3d-6610fc635936)

- Реалізація власних властивостей та подій компонента, що відображаються в редакторі властивостей
Властивості (MyLockDurationSeconds - значення скільки буде тривати блокування кнопки):
  ![image](https://github.com/JuliaSylenok/Lab_1_Sylenok_Net/assets/149322465/79904a6d-9d65-4e20-9437-5ab6c5bff4a8)
Події (MyUnlocked - подія розблокування кнопки):
![image](https://github.com/JuliaSylenok/Lab_1_Sylenok_Net/assets/149322465/8e21e083-4582-40fb-a782-456d882f3956)
- Прив'язка піктограми до компонента для відображення на панелі інструментів
```

 [ToolboxBitmap(@"C:\VARIANT 19\2 course\АППЗ\Lab_1_Button\ControlLibrary\LockableButton.ico")]

```
![image](https://github.com/JuliaSylenok/Lab_1_Sylenok_Net/assets/149322465/4453c148-d550-4dc7-abb0-a72940f5e506)

- Прив'язка меж та пропорційна зміна внутрішніх елементів щодо загального розміру компонента
  Досягається за допомогою властивості Dock(Fill)
  ![image](https://github.com/JuliaSylenok/Lab_1_Sylenok_Net/assets/149322465/7ff53258-3c54-4aaa-8d18-25f469a1dade)

# Висновок

В результатаі виконання роботи було створено компонент LockableButton, що має властивість MyLockDurationSeconds - значення скільки буде тривати блокування кнопки та подію MyUnlocked - розблокування кнопки.

