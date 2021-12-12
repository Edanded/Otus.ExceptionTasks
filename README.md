Есть программа, имитирующая примитивные калькулятор

Пользователь вводит простое выражение, и программа выводит ответ.

Выражение, которое вводит пользователь имеет следующий формат

`число1 операнд число2` (обязательно учитывать по пробелу между числами и операндом)


Операнд - один из символов: `+` (сложение), `-` (вычитание), `*` (умножение), `/` (деление)

Пример работы программы

```console
1 + 2
3

100 - 1
99

2 * 4
8

10 / 5
2
```


Программа работает до тех пор, пока пользователь не введет слово `exit`, тогда программа завершается

Но программа сейчас не может нормально обрабатывать ошибки: деление на 0, некорректный операнд и т.д.

Нужно чтобы программа научилась обрабатывать исключения:

- Если формат вводимой строки не соответствует нужному - выбрасывать исключение и выводить текст
```console
Введите строку в формате 'число1 операнд число2'
```

- Если операнд не относится к нужному типу, вывести текст

```console
Калькулятор умеет работать только с операндами '+', '-', '*', '/',
```

- Если число не помещается в тип int - выводить

```console
Число число1 слишком большое
```
или
```console
Число число1 слишком маленькое
```
или
```console
Число число2 слишком большое
```
или
```console
Число число2 слишком маленькое
```

- Если делим на ноль - выводить cоответствующее сообщение

```console
На ноль делить нельзя
```


- Если ввели нецелое число (с плавающей точкой) - выводить

```console
Калькулятор работает только с целыми числами
```

- Если число не парсится - вывести ошибку

```console
Числов1 не является целым числом
```