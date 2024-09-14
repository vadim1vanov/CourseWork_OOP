# Course_project

## Класс: `Course_project.Edit_Book`

Класс формы редактирования книги

---

### Поле: `Course_project.Edit_Book.Title`

поле названия книги

---

### Поле: `Course_project.Edit_Book.Author`

поле автора книги

---

### Поле: `Course_project.Edit_Book.Genre`

поле жанра книги

---

### Поле: `Course_project.Edit_Book.CountPages`

поле количества страниц в книге

---

### Поле: `Course_project.Edit_Book.ProductionYear`

поле года издания книги

---

### Метод: `Course_project.Edit_Book.#ctor(System.String,System.String,System.String,System.Int32,System.Int32,System.Int32)`

Конструктор по умолчанию

**Параметры:**

- `title`: название

- `author`: автор

- `genre`: жанр

- `countPages`: количество страниц

- `productionYear`: год издания

- `bookID`: id книги

---

### Метод: `Course_project.Edit_Book.CheckOnCorrectTitle(System.Windows.Forms.TextBox)`

Проверка  ввода названия книги

**Параметры:**

- `tb`: Поле ввода

---

### Метод: `Course_project.Edit_Book.CheckOnCorrectAuthor(System.Windows.Forms.TextBox)`

Проверка  ввода автора книги

**Параметры:**

- `tb`: Поле ввода

---

### Метод: `Course_project.Edit_Book.CheckOnCorrectNumber(System.Windows.Forms.TextBox)`

Проверка  ввода количества страниц книги

**Параметры:**

- `tb`: Поле ввода

---

### Метод: `Course_project.Edit_Book.CheckOnCorrectYear(System.Windows.Forms.TextBox)`

Проверка  ввода года выпуска книги

**Параметры:**

- `tb`: Поле ввода

---

### Метод: `Course_project.Edit_Book.CheckOnCorrectGenre(System.Windows.Forms.TextBox)`

Проверка  ввода жанра книги

**Параметры:**

- `tb`: Поле ввода

---

### Свойство: `Course_project.Edit_Book.FlagCorrect`

Свойство для проверки корректности заполнения всех полей ввода

---

### Метод: `Course_project.Edit_Book.btn_Add_Click(System.Object,System.EventArgs)`

Кнопка добавления книги в базу

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Метод: `Course_project.Edit_Book.btn_Back_Click(System.Object,System.EventArgs)`

Кнопка выхода из формы добавления книги

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Поле: `Course_project.Edit_Book.components`

Required designer variable.

---

### Метод: `Course_project.Edit_Book.Dispose(System.Boolean)`

Clean up any resources being used.

**Параметры:**

- `disposing`: true if managed resources should be disposed; otherwise, false.

---

### Метод: `Course_project.Edit_Book.InitializeComponent`

Required method for Designer support - do not modify
            the contents of this method with the code editor.

---

## Класс: `Course_project.Add_Book`

Класс формы добавления книги в книгохранилище

---

### Поле: `Course_project.Add_Book.title`

поле названия книги

---

### Поле: `Course_project.Add_Book.author`

поле автора книги

---

### Поле: `Course_project.Add_Book.genre`

поле жанра книги

---

### Поле: `Course_project.Add_Book.countPages`

поле количества страниц

---

### Поле: `Course_project.Add_Book.productionYear`

поле года издания книги

---

### Метод: `Course_project.Add_Book.#ctor`

Конструктор класса

---

### Метод: `Course_project.Add_Book.CheckOnCorrectTitle(System.Windows.Forms.TextBox)`

Проверка  ввода названия книги

**Параметры:**

- `tb`: Поле ввода

---

### Метод: `Course_project.Add_Book.CheckOnCorrectAuthor(System.Windows.Forms.TextBox)`

Проверка  ввода автора книги

**Параметры:**

- `tb`: Поле ввода

---

### Метод: `Course_project.Add_Book.CheckOnCorrectNumber(System.Windows.Forms.TextBox)`

Проверка  ввода количества страниц книги

**Параметры:**

- `tb`: Поле ввода

---

### Метод: `Course_project.Add_Book.CheckOnCorrectYear(System.Windows.Forms.TextBox)`

Проверка  ввода года выпуска книги

**Параметры:**

- `tb`: Поле ввода

---

### Метод: `Course_project.Add_Book.CheckOnCorrectGenre(System.Windows.Forms.TextBox)`

Проверка  ввода жанра книги

**Параметры:**

- `tb`: Поле ввода

---

### Свойство: `Course_project.Add_Book.FlagCorrect`

Свойство для проверки корректности заполнения всех полей ввода

---

### Метод: `Course_project.Add_Book.btn_Add_Click(System.Object,System.EventArgs)`

Кнопка добавления книги в базу

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Метод: `Course_project.Add_Book.btn_Back_Click(System.Object,System.EventArgs)`

Кнопка выхода из формы добавления книги

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Поле: `Course_project.Add_Book.components`

Required designer variable.

---

### Метод: `Course_project.Add_Book.Dispose(System.Boolean)`

Clean up any resources being used.

**Параметры:**

- `disposing`: true if managed resources should be disposed; otherwise, false.

---

### Метод: `Course_project.Add_Book.InitializeComponent`

Required method for Designer support - do not modify
            the contents of this method with the code editor.

---

## Класс: `Course_project.Add_Client`

Класс формы добавления клиента

---

### Поле: `Course_project.Add_Client.firstName`

поле фамилии клиента

---

### Поле: `Course_project.Add_Client.lastName`

поле имени клиента

---

### Поле: `Course_project.Add_Client.date`

поле даты выдачи книги клиенту

---

### Поле: `Course_project.Add_Client.deadline`

поле крайнего срока сдачи книги

---

### Поле: `Course_project.Add_Client.phone`

поле телефона клиента

---

### Поле: `Course_project.Add_Client.BookID`

поле id книги

---

### Поле: `Course_project.Add_Client.isReturned`

поле состояния сдачи книги

---

### Метод: `Course_project.Add_Client.#ctor`

Конструктор класса

---

### Метод: `Course_project.Add_Client.CheckOnCorrectName(System.Windows.Forms.TextBox)`

Проверка  ввода имени и фамилии клиента

**Параметры:**

- `tb`: Поле ввода

---

### Метод: `Course_project.Add_Client.CheckOnCorrectDate(System.Windows.Forms.TextBox)`

Проверка  ввода даты выдачи книги

**Параметры:**

- `tb`: Поле ввода

---

### Метод: `Course_project.Add_Client.CheckOnCorrectDeadline(System.Windows.Forms.TextBox)`

Проверка  ввода крайнего срока сдачи книги

**Параметры:**

- `tb`: Поле ввода

---

### Метод: `Course_project.Add_Client.CheckOnCorrectPhone(System.Windows.Forms.TextBox)`

Проверка  ввода телефона клиента

**Параметры:**

- `tb`: Поле ввода

---

### Метод: `Course_project.Add_Client.CheckOnCorrectID(System.Windows.Forms.TextBox)`

Проверка  ввода id книги

**Параметры:**

- `tb`: Поле ввода

---

### Свойство: `Course_project.Add_Client.FlagCorrect`

Свойство для проверки корректности заполнения всех полей ввода

---

### Метод: `Course_project.Add_Client.btn_Add_Click(System.Object,System.EventArgs)`

Кнопка добавления клиента в базу

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Метод: `Course_project.Add_Client.btn_Back_Click(System.Object,System.EventArgs)`

Кнопка выхода из формы добавления клиента

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Поле: `Course_project.Add_Client.components`

Required designer variable.

---

### Метод: `Course_project.Add_Client.Dispose(System.Boolean)`

Clean up any resources being used.

**Параметры:**

- `disposing`: true if managed resources should be disposed; otherwise, false.

---

### Метод: `Course_project.Add_Client.InitializeComponent`

Required method for Designer support - do not modify
            the contents of this method with the code editor.

---

## Класс: `Course_project.Books`

Класс формы работы с книгохранилищем

---

### Поле: `Course_project.Books.FILE_BOOKS`

Константа, содержащая имя json-файла с информацией по книгам

---

### Поле: `Course_project.Books.FILE_CLIENTS`

Константа, содержащая имя json-файла с информацией по клиентам

---

### Поле: `Course_project.Books.number`

поле для хранения номера строки

---

### Поле: `Course_project.Books.n_books`

поле для хранения количества книг

---

### Поле: `Course_project.Books.ID`

поле id книги

---

### Метод: `Course_project.Books.#ctor`

Конструктор класса

---

### Метод: `Course_project.Books.Books_Load(System.Object,System.EventArgs)`

Отображение всех книг из книгохранилища

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Метод: `Course_project.Books.WriteToFile``1(System.Collections.Generic.List{``0},System.String)`

Запись в файл

**Параметры:**

- `data`: Имя списка

- `FILE_NAME`: Имя файла, в который записывается

---

### Метод: `Course_project.Books.ReadFromFile``1(System.String)`

Чтение из файла

**Параметры:**

- `FILE_NAME`: Имя файла, в который записывается

---

### Метод: `Course_project.Books.btn_Add_Click(System.Object,System.EventArgs)`

Кнопка открытия формы добавления книги

**Параметры:**

- `sender`: 

- `e`: 

---

### Метод: `Course_project.Books.btn_Remove_Click(System.Object,System.EventArgs)`

Кнопка удаления книги

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Метод: `Course_project.Books.Print(Course_project.InfoBooks)`

Вывод всех строчек с информацией о каждой книге

**Параметры:**

- `book`: 

**Возвращает:**


---

### Метод: `Course_project.Books.btn_filter_Click(System.Object,System.EventArgs)`

Фильтрация книг по заданному критерию

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Метод: `Course_project.Books.btn_search_Click(System.Object,System.EventArgs)`

Поиск книги по заданному id

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Метод: `Course_project.Books.btn_Reset_Click(System.Object,System.EventArgs)`

Сброс всех фильтров

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Метод: `Course_project.Books.dataGridView1_CellContentDoubleClick(System.Object,System.Windows.Forms.DataGridViewCellEventArgs)`

Редактирование книги

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Метод: `Course_project.Books.btn_Back_Click(System.Object,System.EventArgs)`

Кнопка выхода из формы управления книгохранилищем

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Поле: `Course_project.Books.components`

Required designer variable.

---

### Метод: `Course_project.Books.Dispose(System.Boolean)`

Clean up any resources being used.

**Параметры:**

- `disposing`: true if managed resources should be disposed; otherwise, false.

---

### Метод: `Course_project.Books.InitializeComponent`

Required method for Designer support - do not modify
            the contents of this method with the code editor.

---

## Класс: `Course_project.Clients`

Класс формы работы с клиентами

---

### Поле: `Course_project.Clients.FILE_BOOKS`

Константа, содержащая имя json-файла с информацией по книгам

---

### Поле: `Course_project.Clients.FILE_CLIENTS`

Константа, содержащая имя json-файла с информацией по клиентам

---

### Поле: `Course_project.Clients.n_clients`

поле для хранения количества клиентов

---

### Поле: `Course_project.Clients.numbers`

поле для хранения номера строки

---

### Метод: `Course_project.Clients.#ctor`

Конструктор класса

---

### Метод: `Course_project.Clients.Clients_Load(System.Object,System.EventArgs)`

Отображение всех клиентов из базы данных

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Метод: `Course_project.Clients.WriteToFile``1(System.Collections.Generic.List{``0},System.String)`

Запись в файл

**Параметры:**

- `data`: Имя списка

- `FILE_NAME`: Имя файла, в который записывается

---

### Метод: `Course_project.Clients.ReadFromFile``1(System.String)`

Чтение из файла

**Параметры:**

- `FILE_NAME`: Имя файла, в который записывается

---

### Метод: `Course_project.Clients.btn_Add_Click(System.Object,System.EventArgs)`

Кнопка открытия формы добавления клиента

**Параметры:**

- `sender`: 

- `e`: 

---

### Метод: `Course_project.Clients.btn_Remove_Click(System.Object,System.EventArgs)`

Кнопка удаления клиента

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Метод: `Course_project.Clients.btn_Back_Click(System.Object,System.EventArgs)`

Кнопка выхода из формы управления клиентами

**Параметры:**

- `sender`: 

- `e`: 

---

### Поле: `Course_project.Clients.components`

Required designer variable.

---

### Метод: `Course_project.Clients.Dispose(System.Boolean)`

Clean up any resources being used.

**Параметры:**

- `disposing`: true if managed resources should be disposed; otherwise, false.

---

### Метод: `Course_project.Clients.InitializeComponent`

Required method for Designer support - do not modify
            the contents of this method with the code editor.

---

## Класс: `Course_project.Info`

Класс хранящий id книги

---

## Класс: `Course_project.InfoBooks`

Класс с информацией о книге

---

### Свойство: `Course_project.InfoBooks.Title`

свойство названия книги

---

### Свойство: `Course_project.InfoBooks.Author`

свойство автора книги

---

### Свойство: `Course_project.InfoBooks.Genre`

свойство жанра книги

---

### Свойство: `Course_project.InfoBooks.CountPages`

свойство количества страниц книги

---

### Свойство: `Course_project.InfoBooks.ProductionYear`

свойство года издания книги

---

### Метод: `Course_project.InfoBooks.CompareTo(System.Object)`

проверка id книги

**Параметры:**

- `obj`: объект, который проверяется

**Возвращает:**
id

---

### Метод: `Course_project.InfoBooks.#ctor(System.String,System.String,System.String,System.Int32,System.Int32,System.Int32)`

Конструктор класса

**Параметры:**

- `title`: название

- `author`: автор

- `genre`: жанр

- `countPages`: количество страниц

- `productionYear`: год издания

- `bookID`: id книги

---

## Класс: `Course_project.InfoClients`

Класс с информацией о клиенте

---

### Свойство: `Course_project.InfoClients.FirstName`

свойство фамилии

---

### Свойство: `Course_project.InfoClients.LastName`

свойство имени

---

### Свойство: `Course_project.InfoClients.Date`

свойство даты выдачи книги

---

### Свойство: `Course_project.InfoClients.Deadline`

свойство крайнего срока сдачи

---

### Свойство: `Course_project.InfoClients.Phone`

свойство телефона

---

### Свойство: `Course_project.InfoClients.IsReturned`

свойство статуса сдачи

---

### Метод: `Course_project.InfoClients.#ctor(System.String,System.String,System.String,System.String,System.String,System.Int32,System.String)`

Конструктор класса

**Параметры:**

- `firstName`: фамилия

- `lastName`: имя

- `date`: дата выдачи

- `deadline`: дата сдачи

- `phone`: телефон

- `bookID`: id книги

- `isReturned`: статус сдачи

---

### Поле: `Course_project.Menu.components`

Обязательная переменная конструктора.

---

### Метод: `Course_project.Menu.Dispose(System.Boolean)`

Освободить все используемые ресурсы.

**Параметры:**

- `disposing`: истинно, если управляемый ресурс должен быть удален; иначе ложно.

---

### Метод: `Course_project.Menu.InitializeComponent`

Требуемый метод для поддержки конструктора — не изменяйте 
            содержимое этого метода с помощью редактора кода.

---

## Класс: `Course_project.Properties.Resources`

Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.

---

### Свойство: `Course_project.Properties.Resources.ResourceManager`

Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.

---

### Свойство: `Course_project.Properties.Resources.Culture`

Перезаписывает свойство CurrentUICulture текущего потока для всех
              обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.

---

### Свойство: `Course_project.Properties.Resources.books`

Поиск локализованного ресурса типа System.Drawing.Bitmap.

---

## Класс: `Course_project.Report`

Класс формы отчета по должникам

---

### Поле: `Course_project.Report.FILE_BOOKS`

Константа, содержащая имя json-файла с информацией по книгам

---

### Поле: `Course_project.Report.FILE_CLIENTS`

Константа, содержащая имя json-файла с информацией по клиентам

---

### Поле: `Course_project.Report.number`

поле для хранения номера строки

---

### Метод: `Course_project.Report.#ctor`

Конструктор класса

---

### Метод: `Course_project.Report.Report_Load(System.Object,System.EventArgs)`

Отображение всех должников

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Метод: `Course_project.Report.ReadFromFile``1(System.String)`

Чтение из файла

**Параметры:**

- `FILE_NAME`: Имя файла, в который записывается

---

### Метод: `Course_project.Report.btn_Back_Click(System.Object,System.EventArgs)`

Кнопка выхода из формы отчета по должникам

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Поле: `Course_project.Report.components`

Required designer variable.

---

### Метод: `Course_project.Report.Dispose(System.Boolean)`

Clean up any resources being used.

**Параметры:**

- `disposing`: true if managed resources should be disposed; otherwise, false.

---

### Метод: `Course_project.Report.InitializeComponent`

Required method for Designer support - do not modify
            the contents of this method with the code editor.

---

## Класс: `Course_project.StartForm`

Класс загрузочной формы

---

### Метод: `Course_project.StartForm.#ctor`

Конструктор класса

---

### Метод: `Course_project.StartForm.StartForm_Load(System.Object,System.EventArgs)`

Отображение формы с задержкой

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Метод: `Course_project.StartForm.StartForm_Click(System.Object,System.EventArgs)`

Закрытие формы

**Параметры:**

- `sender`: Объект, который вызвал срабатывание

- `e`: Объект, с дополнительной информацией

---

### Поле: `Course_project.StartForm.components`

Required designer variable.

---

### Метод: `Course_project.StartForm.Dispose(System.Boolean)`

Clean up any resources being used.

**Параметры:**

- `disposing`: true if managed resources should be disposed; otherwise, false.

---

### Метод: `Course_project.StartForm.InitializeComponent`

Required method for Designer support - do not modify
            the contents of this method with the code editor.

---
