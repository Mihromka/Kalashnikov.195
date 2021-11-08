Задания доступны по ссылке https://docs.google.com/presentation/d/17YdUQJrXn2dPckjSeDarp3v6mYDyaHhsLKEFe0GpqEk/edit#slide=id.p
Журнал с оценками доступен по ссылке https://docs.google.com/spreadsheets/d/1E97mF2Z5Yr-YBHZbKlfiQFnVlfq9CGhpl5XqJ7FoH3I/edit#gid=67700862

Enumerating objects: 32, done.
Counting objects: 100% (32/32), done.
Delta compression using up to 8 threads
Compressing objects: 100% (21/21), done.
Writing objects: 100% (32/32), 49.33 MiB | 2.57 MiB/s, done.
Total 32 (delta 5), reused 0 (delta 0), pack-reused 0
remote: Resolving deltas: 100% (5/5), done.
remote: warning: File .vs/Project1/v16/ipch/AutoPCH/8166788c1c868b97/КОНТУР.ipch is 80.00 MB; this is larger than GitHub's recommended maximum file size of 50.00 MB
remote: warning: File .vs/Project1/v16/ipch/AutoPCH/ea28e147d479e2a/SOURCE.ipch is 80.00 MB; this is larger than GitHub's recommended maximum file size of 50.00 MB
remote: error: Trace: 689d46030ad6b6c617aa2dae91db589b190893fbf41b6fdb6168bfe3b7b06610
remote: error: See http://git.io/iEPt8g for more information.
remote: error: File Debug/opencv_world453d.dll is 117.23 MB; this exceeds GitHub's file size limit of 100.00 MB
remote: error: GH001: Large files detected. You may want to try Git Large File Storage - https://git-lfs.github.com.
To https://github.com/Mihromka/Mustafa.git
 ! [remote rejected] master -> master (pre-receive hook declined)
error: failed to push some refs to 'https://github.com/Mihromka/Mustafa.git'

Репозиторий (от англ. repository — хранилище) — место, где хранятся и поддерживаются какие-либо данные. Чаще всего данные в репозитории хранятся в виде файлов, доступных для дальнейшего распространения по сети.

Существуют репозитории для хранения программ, написанных на одном языке или предназначенных для одной платформы.

Многие современные операционные системы, такие как OpenSolaris, FreeBSD и большинство дистрибутивов Linux, имеют официальные репозитории, но также позволяют устанавливать пакеты из других мест. Большинство репозиториев бесплатны, однако некоторые компании предоставляют доступ к собственным репозиториям за платную подписку.

Репозитории используются в системах управления версиями, в них хранятся все документы вместе с историей их изменения и другой служебной информацией.

Существуют различные автоматизированные системы создания репозиториев. Один из типов репозиториев: хранилища на CD/DVD — установочные диски для пакетов того или иного ПО.

Среди дистрибутивов Linux популярны репозитории с форматом метаданных YUM для дистрибутивов на базе RPM-пакетов, и репозитории с метаданными APT для дистрибутивов на основе DEB-пакетов.
Система контроля версий — программное обеспечение для облегчения работы с изменяющейся информацией.

Оновные возможности СКВ: 
<li>-Работа с локальными и удаленными репозиториями;</li>
<li>-Создание и слияние веток;</li>
<li>-Откат к предыдущим версиям.</li>

Ветка — подвижный указатель на один из коммитов. Обычно ветка указывает на последний коммит в цепочке коммитов.

1. Создание новой ветки

Основная ветка в каждом репозитории называется master. Чтобы создать еще одну ветку, используем команду branch <name><br>
  <b>$ git branch amazing_new_feature</b><br>
Это создаст новую ветку, пока что точную копию ветки master.
  
2. Переключение между ветками
 
Сейчас, если мы запустим branch, мы увидим две доступные опции:<br>
<b>$ git branch<br>
amazing_new_feature<br>
  * master</b><br>
master — это активная ветка, она помечена звездочкой. Но мы хотим работать с нашей “новой потрясающей фичей”, так что нам понадобится переключиться на другую ветку. Для этого воспользуемся командой checkout, она принимает один параметр — имя ветки, на которую необходимо переключиться.<br>
  <b>$ git checkout amazing_new_feature</b><br> 
  
3. Слияние веток
  
Наша “потрясающая новая фича” будет еще одним текстовым файлом под названием feature.txt. Мы создадим его, добавим и закоммитим:
<b>$ git add feature.txt<br>
   $ git commit -m "New feature complete.”</b><br>
Изменения завершены, теперь мы можем переключиться обратно на ветку master.
  <b>$ git checkout master</b><br>
Теперь, если мы откроем наш проект в файловом менеджере, мы не увидим файла feature.txt, потому что мы переключились обратно на ветку master, в которой такого файла не существует. Чтобы он появился, нужно воспользоваться merge для объединения веток (применения изменений из ветки amazing_new_feature к основной версии проекта).<br>
  <b>$ git merge amazing_new_feature</b><br>
Теперь ветка master актуальна. Ветка amazing_new_feature больше не нужна, и ее можно удалить.<br>
  <b>$ git branch -d awesome_new_feature</b><br>  
