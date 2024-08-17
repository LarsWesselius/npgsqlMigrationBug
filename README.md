# README
Just run it with a postgres instance running with postgis support enabled (or change it so that any other extension is activated in the migration).

I used docker
`docker run -p 5432:5432 -e POSTGRES_PASSWORD=mypassword postgis/postgis`
