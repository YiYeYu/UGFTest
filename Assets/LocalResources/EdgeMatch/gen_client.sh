#!/bin/bash

WORKSPACE=../../../
LUBAN_DLL=$WORKSPACE/Tools/Luban/Luban.dll
CONF_ROOT=$WORKSPACE/DataTables
GAME_ROOT=./
TEMPLATE_ROOT=$WORKSPACE/Assets/Configs/LubanTemplates

dotnet $LUBAN_DLL \
    -t client \
    -c lua-bin \
    -c cs-bin \
    -d bin  \
    -d json \
    --conf $CONF_ROOT/luban.conf \
    -x lua-bin.outputCodeDir=$GAME_ROOT/Lua/Gen \
    -x cs-bin.outputCodeDir=$WORKSPACE/Assets/Scripts/Gen \
    -x bin.outputDataDir=$GAME_ROOT/Luban/bytes \
    -x json.outputDataDir=$GAME_ROOT/Luban/json \
    --customTemplateDir ${TEMPLATE_ROOT}

# dotnet $LUBAN_DLL \
#     -t client \
#     -c lua-bin \
#     # -c cs-simple-json \
#     -d bin  \
#     -d json \
#     --conf $CONF_ROOT/luban.conf \
#     -x lua-bin.outputCodeDir=$GAME_ROOT/Lua/Gen \
#     -x bin.outputDataDir=$GAME_ROOT/Luban/bytes \
#     # -x cs-simple-json.outputCodeDir=$GAME_ROOT/Json/Gen \
#     -x json.outputDataDir=$GAME_ROOT/Luban/json \
