**Задача** :
Написать программу, которая из имеющегося массива строк формирует массив из строк,длина котрых меньше, либо равна 3 символа.

**Решение** :
Объявим 2 массива , в первый положим наши строковые значения, второй возьмем  такой же длины как и первый.
Напишем метод  void Finish Arr в котором укажем строки из массива 1 и  массива 2.
Пускай переменная  count = 0 , запустим цикл for который прощелкает длину первого массива с условием if, что если в длине массива1 элемент i <=3 , то положит его в count второго массива. Переменная count нужна для того чтобы поочередно закидывать из первого массива во второй.
После присвоения увеличивается переменная count на 1 и возвращается в цикл for в котором i увеличивается на 1 пока не проверит его весь.
Расспечатываем массив.    
