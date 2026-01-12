#!/usr/bin/env bash
dotnet new console -n 1-new_project -o 1-new_project &> /dev/null
dotnet build 1-new_project -v q --nologo | grep -A 2 "Build succeeded"
