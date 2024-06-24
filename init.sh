#!/bin/bash
while :
do 
  PORTS=`lsof -i:1433`
  echo $PORTS
  if ["$PORTS" = '']; then
    echo 'Database is down, trying to reconnect to run initial migrations!'
    sleep 5s
  else
    docker exec todo-database /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P TodoApiSqlPass123! -d master -i initdb/initial.sql; echo "All done!";
    break
  fi
done

echo "successfuly executed!"