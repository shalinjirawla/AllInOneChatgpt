#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p bbe32312-4799-4222-bbdc-665ae2e460cc -t
    fi
    cd ../
fi

docker-compose up -d
