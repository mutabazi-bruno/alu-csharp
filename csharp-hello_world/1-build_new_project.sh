#!/usr/bin/env bash

set -e

DIR="1-new_project"


if [ -d "$DIR" ]; then
  rm -rf "$DIR"
fi


dotnet new console -o "$DIR" >/dev/null


if ! build_output=$(dotnet build "$DIR/$DIR.csproj" 2>&1); then
  echo "$build_output" >&2
  exit 1
fi

warnings=$(printf "%s\n" "$build_output" | awk '/Warning\(s\)/{w=$1} END{if(w=="")print 0; else print w}')
errors=$(printf "%s\n" "$build_output" | awk '/Error\(s\)/{e=$1} END{if(e=="")print 0; else print e}')
printf "Build succeeded.\n    %s Warning(s)\n    %s Error(s)\n" "$warnings" "$errors"