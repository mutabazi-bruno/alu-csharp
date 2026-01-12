#!/usr/bin/env bash
dotnet new console -n 1-new_project > /dev/null
dotnet build 1-new_project | tail -5 | head -3
