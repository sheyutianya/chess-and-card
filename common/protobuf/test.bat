@echo off

set XLS_NAME=%1
set XLS_PATH=%2
set SHEET_NAME=%3
set C_PATH=%4
set BYTES_PATH=%5
set isDedug=%6

echo.
echo =========Compilation of %XLS_NAME%=========


::---------------------------------------------------
::第一步，将xls经过xls_deploy_tool转成bytes和proto
::---------------------------------------------------
set STEP1_XLSTOPROTO_PATH=step1_xlsToProto

@echo on
cd %STEP1_XLSTOPROTO_PATH%

@echo off
echo TRY TO DELETE TEMP FILES:
del *_pb2.py
del *_pb2.pyc
del *.proto
del *.bytes
del *.log
del *.txt

@echo on
python xls_deploy_tool.py %SHEET_NAME% %XLS_PATH%%XLS_NAME%

::---------------------------------------------------
::第二步：把proto翻译成cs
::---------------------------------------------------
cd ..

set STEP2_PROTOTOCS_PATH=.\step2_ProtoToCS

cd %STEP2_PROTOTOCS_PATH%

@echo off
echo TRY TO DELETE TEMP FILES:
del *.cs
del *.txt


@echo on
protoc --descriptor_set_out=%SHEET_NAME%.protobin --proto_path=..\%STEP1_XLSTOPROTO_PATH% ..\%STEP1_XLSTOPROTO_PATH%\*.proto

cd ..

cd ProtoGen

protogen -i:..\%STEP2_PROTOTOCS_PATH%\%SHEET_NAME%.protobin -o:%C_PATH%\%SHEET_NAME%.cs

cd ..

copy %STEP1_XLSTOPROTO_PATH%\*.bytes %BYTES_PATH%\

if %isDedug% == 1 pause
@echo on


