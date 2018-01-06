@echo off

set protoFileName=%1
set C_PATH=%2
set protoFilePath=%3
set proto_path=%4
set isDedug=%5
set STEP2_XLSTOPROTO_PATH=step2_ProtoToCS


cd %STEP2_XLSTOPROTO_PATH%

@echo off
echo TRY TO DELETE TEMP FILES:
del *_pb2.py
del *_pb2.pyc
del *.proto
del *.bytes
del *.log
del *.txt
del *.cs
del *.txt


@echo on
protoc --descriptor_set_out=%protoFileName%.protobin --proto_path=%proto_path% %protoFilePath%

cd ..

cd ProtoGen

protogen -i:..\%STEP2_XLSTOPROTO_PATH%\%protoFileName%.protobin -o:%C_PATH%\%protoFileName%.cs -ns:GameP


if %isDedug% == 1 pause
@echo on


