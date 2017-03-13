#!/bin/sh
docker build -t dotnet-build-image -f Dockerfile.build .
docker rm mydotnet
docker run --name "mydotnet" -it -p 5000:5000 dotnet-build-image ./run.sh
