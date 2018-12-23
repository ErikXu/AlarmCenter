# Prerequisites

## Install Rabbitmq
mkdir -p /opt/rabbit  
docker run --name rabbit --restart always --hostname rabbit-host -d -v /opt/rabbit:/var/lib/rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.7-management-alpine

## Install Redis
mkdir -p /opt/redis  
docker run --name redis --restart always -d -v /opt/redis:/data -p 6379:6379 redis:5.0-alpine --appendonly yes --requirepass 123456  

## Install Mongodb
mkdir -p /opt/mongo
docker run --name mongodb --restart always -d  -v /opt/mongo:/data/db/ -p 27017:27017 -e MONGO_INITDB_ROOT_USERNAME=root -e MONGO_INITDB_ROOT_PASSWORD=123456 mongo:4.0

## Install ElasticSearch
mkdir -p /opt/elasticsearch
docker run --name elasticsearch --restart always -d -v /opt/elasticsearch:/usr/share/elasticsearch/data -p 9200:9200 -p 9300:9300 -e "discovery.type=single-node" docker.elastic.co/elasticsearch/elasticsearch:7.0.0-alpha2

## Install Kibana
docker run -d --name kibana --net es-net -p 5601:5601 kibana:5.6