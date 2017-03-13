#!/bin/sh
docker build -t dotnet-build-image -f Dockerfile.build .
docker rm mydotnet
docker run --name "mydotnet" -p 80:5000 -it dotnet-build-image
