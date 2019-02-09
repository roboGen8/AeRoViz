var csv = require('fast-csv');
var mongoose = require('mongoose');
var Flightdata = require('./flightdata');
 
exports.post = function (req, res) {
    if (!req.files)
        return res.status(400).send('No files were uploaded.');
     
    var flightdataFile = req.files.file;
 
    var flightdata = [];
         
    csv
     .fromString(flightdataFile.data.toString(), {
         headers: true,
         ignoreEmpty: true
     })
     .on("data", function(data){
         data['_id'] = new mongoose.Types.ObjectId();
          
         flightdata.push(data);
     })
     .on("end", function(){
         Flightdata.create(flightdata, function(err, documents) {
            if (err) throw err;
         });
          
         res.send(flightdata.length + ' flight data fields have been successfully uploaded.');
     });
};