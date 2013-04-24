GMDB for MaNGOSZero
==========

Short description
-------
GMDB is a German update for the MaNGOSZero Database. 



How to Install
-------
Short instruction:

- enter _tools directory

- run: make_full_db.bat (if you are doing it under Windows) or

- run: /bin/sh make_full_db.sh (if you are running it under *nix/Linux). Don't forget chmod +x.

- apply created file to mangos database, eg.: mysql -u root -p mangos < locales_mangos.sql

- apply created file to scriptdev2 database, eg.: mysql -u root -p scriptdev2 < locales_scriptdev2.sql

That's all!

Requires still full database from MaNGOSZero (https://github.com/mangoszero/database).


License
-------
**GMDB for MaNGOSZero** is released under the Creative Commons Attribution-NonCommercial-ShareAlike 3.0.
The file (`LICENSE.md`) **must** be a part of any redistributable packages
made from this software.  No licenses should be removed from this software if
you are making redistributable copies.
