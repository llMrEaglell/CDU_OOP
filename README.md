# Черкаський національний університет ім. Б. Хмельницького
## Лабораторні та практичні роботи ООП C#
### Л1. ОБРОБКА МАСИВІВ У C#(Lab_1)
Варіант 5
**1. В матриці C кількість стовпчиків у кожному рядку є випадковим натуральним
числом з інтервалу [a; b], але загальна кількість елементів є квадратом
натурального числа. Переписати всі елементи з матриці C в одновимірний масив
F, відсортувати його за зростанням, після чого переписати його елементи у
квадратну матрицю Q по рядках.
2. Створити клас TTriangle для подання трикутника. Поля (protected) повинні містити дані про довжини сторін (для кожної з трьох сторін своє поле). Потрібно реалізувати:
* конструктор, який заповнює всі три довжини (перевіряючи можливість існування такого трикутника);
* отримання (get) довжини сторони (три окремі методи, для кожної сторони свій);
* задання (set) довжини сторони (три окремі методи, для кожної сторони свій; перевіряти можливість існування такого трикутника, де ця одна сторона змінена, а решта дві лишаються, які були);
* отримання периметру трикутника
* отримання площі трикутника (через формулу Герона)**

### Л2. Поліморфізм та наслідування(Lab_3)
Варіант 6<br>
Реалізувати клас, що представляє трикутник (трикутник задається координатами вершин) і містить опис індексатора для доступу до сторін трикутника( a – перша
сторона, b – друга сторона, c – третя сторона).
Передбачити методи введення/виведення, знаходження периметру та площі.
Варіант 6<br>
Клас “коло” – TCircle<br>
Поля:<br>
- для зберігання радіуса;<br>
Методи:<br>
* конструктор без параметрів, конструктор з параметрами, конструктор копіювання;
* override public string ToString();
* введення/виведення даних;
* визначення площі круга (обмеженого колом), площі сектора (кут є параметром);
* визначення довжини кола;
* порівняння з іншим колом;
* перевантаження операторів + (додавання радіусів), – (віднімання радіусів; при від’ємному результаті брати за модулем), (множення радіуса на число; забезпечити, щоб домноження могло відбуватися хоч як «число коло», хоч як «коло число»).<br>

2. Створити клас-нащадок TCylinder (циліндр) на основі класу TCircle. Додати поле висоти циліндру, метод знаходження об’єму циліндра та перевизначити відповідні методи.<br>
3. Створити програму-клієнт для тестування.<br>


### Л3. Тема(Lab_2)
Реалізуйте клас MyMatrix, який зберігає прямокутну числову матрицю і вміє виконувати дії
додавання матриць та множення матриць.
Матриця повинна містити єдине приватне поле — масив із власне елементами матриці (типу
double[,]) .<br>
Слід реалізувати такі конструктори, оператори, властивості та методи (усі публічні, якщо
тільки не вказано іншого):
- Конструктори:<br> 
	- **копіюючий з іншого примірника цього самого класу MyMatrix;**
	- **з двовимірного масиву типу double[,];**
	- **з «зубчастого» масиву double-ів, якщо він фактично прямокутний;**
	- **з масиву рядків, якщо фактично ці рядки містять записані через пробіли та/або
	числа, а кількість цих чисел однакова.**
	- **з рядка, що містить як пробіли та/або табуляції (їх трактувати як роздільники
	чисел у одному рядку матриці), так і символи переведення рядка (їх трактувати
	як роздільники рядків) — якщо фактичні дані того рядка утворюють прямокутну
	числову матрицю; зокрема, щоб цим конструктором можна було створити
	матрицю з рядка, раніше сформованого методом ToString (див. далі))**<br>

* **operator + додавання двох матриць (якщо вони мають однаковий розмір)**
* **operator * множення двох матриць (якщо кількість стовпчиків першої дорівнює
кількості рядків другої)**
* **Властивості (Properties) Height та Width, що дозволяють взнати (але не дозволяють
змінити) «висоту» (кількість рядків) та «ширину» (кількість стовпчиків)**
* **Java-style getter-и (без setter-ів) кількості рядків getHeight() та кількості
стовпчиків getWidth()**
* **Індексатори, що дозволяють публічно доступатися до будь-якого окремого елемента
матриці (як взнавати його значення, так і змінювати)**
* **Java-style getter та setter для окремого елемента (getter має два параметри — номер
рядка і номер стовпчика, setter має три параметра — номер рядка, номер стовпчика, і
значення, яке записати у той рядок і стовпчик)**
* **Метод override public String ToString(), перевантажений так, щоб
формував (табуляціями та переведеннями рядка) зручне для сприйняття людиною
прямокутне подання числової матриці; це повинен бути метод саме з вищенаведеним
заголовком, бо саме так вдається забезпечити, щоб примірники цього класу можна
було виводити просто через Console.WriteLine(A) (де A – примірник цього
самого класу MyMatrix)**
* **Метод (не статичний; private або protected) GetTransponedArray(), що повертає
новостворений масив double[,] (не MyMatrix, а просто масив), у якому вміст
елементів транспонований відносно тієї матриці, для якої він викликався**
* **Метод (не статичний) MyMatrix GetTransponedCopy(), який би створював
новий примірник MyMatrix, у якому вміст матриці транспонований відносно тієї,
для якої він викликався; технічну роботу по власне транспонуванню не повторювати,
а використати результат GetTransponedArray()**
* **Метод (не статичний) void TransponeMe(), який би замінював матрицю, для якої
викликається, на транспоновану (теж використати GetTransponedArray(), але
щоб результат змінився сам this-примірник MyMatrix).**
<br>
В усіх випадках неправильних даних (намагання створити матрицю з фактично
не прямокутного «зубчастого» масиву; намагання створити матрицю з масиву рядків, який
фактично містить взагалі не числа; намагання доступитися до неіснуючого елемента;
намагання додати матриці різного розміру, тощо) як базовий (стандартний) спосіб
пропонується, щоб виконання програми просто аварійно завершувалося. Рятування ситуації
шляхом коректної роботи з exception-ами – правильний підхід, вітається (хоч і
не вимагається). Намагання нівелювати ці помилки будь-якими іншими засобами –
неправильний підхід, категорично забороняється.

Варіант 1.


### Л4. Тема

### Л5. Тема

### Л6. Тема

### Л7. Тема

### Л8. Тема

### Л9. Тема

### Л10. Тема

### Л11. Тема

### Л12. Тема
