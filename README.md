Обучение C# методом тыка

1. git config --global user.email trintos@live.ru
2. git init --Захват папки для отслеживания изменений и создания репозитория
3. git status -- проверка статуса отслеживания
4. git add -- добавить файлы в гит для отслеживания. Разрешение файла обязательное
5. git commit -a -m -- сохранить текущие изменения. Параметр m комментарий для коммита. Параметр -a для автоматического добавления файлов в гит и исключить постоянную команду git add
6. git log -- отображение всех версий изменений
7. git checkout (MDhash) -- выборочное переключение на одну из версий изменений. Параметр master возвращает к самой актуальной версии
8. git diff -- посмотреть произведенные изменения без сохранения

**Работа с гитом**

# Cоздайте новый репозиторий в командной строке

```
echo "# C" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/Artemedi/C.git
git push -u origin main
```
# Или отправить в существующий
```
git remote add origin https://github.com/Artemedi/C.git
git branch -M main
git push -u origin main
```
Перед отправкой в существующий требуется команда *git pull*
