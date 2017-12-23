const express = require('express');
const path = require('path');
var ejs = require('ejs');
const chalk = require('chalk');

const homeController = require ('./controllers/home');

const app = express();

app.set('port', process.env.PORT || 3000);
app.set('view engine', 'ejs');
app.set('views', path.join(__dirname, 'views'));

app.use('/', express.static('.'));
app.get('/', homeController.index);
app.listen(app.get('port'), () => {
    console.log('%s App is running at http://localhost:%d in %s mode', chalk.green('✓'), app.get('port'), app.get('env')); 
    console.log('  Press CTRL-C to stop\n');
  });
  