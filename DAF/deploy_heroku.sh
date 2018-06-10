wget -qO- https://toolbelt.heroku.com/install-ubuntu.sh | sh
heroku plugins:install heroku-container-registry
docker login -e _ -u _ --password=$HEROKU_API_KEY registry.heroku.com
docker build -t  testnetcore21 ./bin/release/netcoreapp2.0/publish
heroku container:push web --app $HEROKU_APP_NAME