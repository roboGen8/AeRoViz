var app = require('express')();
var fileUpload = require('express-fileupload');
var mongoose = require('mongoose');
 require('dotenv').config();
//elp
const fs = require('fs');
if(!fs.existsSync('./.env')) {
	throw new Error('.env file is missing');
}
mongoose.connect(process.env.MONGODB_URI,
	{ useNewUrlParser: true },
	 () => {
	console.log("Connected to mLab");
});
var server = require('http').Server(app);
 
app.use(fileUpload());
 
server.listen(80);
 
//mongoose.connect('mongodb://localhost/csvimport');
 
app.get('/', function (req, res) {
  res.sendFile(__dirname + '/index.html');
});
 
var template = require('./template.js');
app.get('/template', template.get);
 
var upload = require('./upload.js');
app.post('/', upload.post);