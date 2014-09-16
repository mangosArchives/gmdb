GMDB for CMaNGOS or MaNGOSZero
==========

Short description
-------
GMDB is a German update for MaNGOSZero (https://github.com/mangoszero/database) or CMaNGOS Classic (https://github.com/classicdb/database) Database. 



How to Install
-------
Short instruction:

- enter _tools directory

- run: make_full_db.bat (if you are doing it under Windows) or

- run: /bin/sh make_full_db.sh (if you are running it under *nix/Linux). Don't forget chmod +x.

- apply created file to mangos database, eg.: mysql -u root -p mangos < locales_mangos.sql

- apply created file to scriptdev2 database, eg.: mysql -u root -p scriptdev2 < locales_scriptdev2.sql

That's all!

