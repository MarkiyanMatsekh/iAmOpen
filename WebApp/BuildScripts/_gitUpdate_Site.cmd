set RootPath=%1%
set LogFile=%2%

set Repository="git@github.com:moiMusique/iAmOpen.git"

set git="C:\Program Files\Git\bin\git.exe"

%git% pull Repository master >> %LogFile%