set project_name=%1%
set build_configuration=%2%
set root_path=%3%
set deploy_path=%4%
set git_update_script=%5%

set project_path=%root_path%\%project_name%\%project_name%.csproj 

For /f "tokens=2-4 delims=/ " %%a in ('date /t') do (set Today=%%a.%%b.%%c)
For /f "tokens=1,2 delims=: " %%a in ('time /t') do (set Now=%%a.%%b)

set LogFile=%project_name%_UPDATE.log
del %LogFile%

echo --------------------------------------------------------------------- >>%LogFile%
echo UPDATING AND BUILDING %project_name%. BUILD BY USER %USERNAME%. STARTED %date% at %Now%. >>%LogFile%
echo --------------------------------------------------------------------- >>%LogFile%

echo --------------------------------------------------------------------- >>%LogFile%
echo UPDATING DIRECTORIES >>%LogFile%
echo --------------------------------------------------------------------- >>%LogFile%
call %git_update_script% %root_path% %LogFile%

set msbuild=C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\msbuild.exe
set build_script=%msbuild% %project_path% /t:PipelinePreDeployCopyAllFilesToOneFolder /p:Configuration=%build_configuration%;_PackageTempDir=%deploy_path%\%project_name%;OutputPath=bin\;AutoParameterizationWebConfigConnectionStrings=false
echo --------------------------------------------------------------------- >>%LogFile%
echo PUBLISHING PROJECT TO %deploy_path%\%project_name%" >>%LogFile%
echo %build_script% >>%LogFile%
echo --------------------------------------------------------------------- >>%LogFile%
%build_script% >>%LogFile%

set history_path=%deploy_path%\History\%project_name%\%Today%\%Now%\
echo --------------------------------------------------------------------- >>%LogFile%
echo WRITING HISTORY %deploy_path%\%project_name% to %history_path% >>%LogFile%
echo --------------------------------------------------------------------- >>%LogFile%
xcopy %deploy_path%\%project_name% %history_path% /s/z/Y >>%LogFile%
xcopy %LogFile% %history_path% /s/z/Y

echo --------------------------------------------------------------------- >>%LogFile%
echo UPDATE FINISHED >>%LogFile%
echo --------------------------------------------------------------------- >>%LogFile%