var mongoose = require('mongoose');
 
var flightDataSchema = mongoose.Schema({
    _id: mongoose.Schema.Types.ObjectId,
    Offset_sec: {
        type: Number,
        required: true
    },
    Latitude_deg: {
        type: Number,
        required: true
    },
    Longitude_deg: {
        type: Number,
        required: true
    },
    Altitude_ft: {
        type: Number,
        required: true
    },
    Airspeed_knot: {
        type: Number,
        required: true
    },
    Heading_deg: {
        type: Number,
        required: true
    },
    Flap_Position_deg: {
        type: Number,
        required: true
    },
    LndGear_Position: {
        type: Number,
        required: true
    },
    GrossWeight_lbs: {
        type: Number,
        required: true
    },
    GCD_to_Threshold: {
        type: Number,
        required: true
    },
    TCAS_RA: {
        type: Number,
        required: true
    },
    Stall_Warning: {
        type: Number,
        required: true
    },
    Windshear: {
        type: Number,
        required: true
    }   ,
    VFE: {
        type: Number,
        required: true
    },
    High_Angle_of_Bank  : {
        type: Number,
        required: true
    },
    High_Angle_of_Pitch: {
        type: Number,
        required: true
    },
    VMO : {
        type: Number,
        required: true
    },
    Dual_Input: {
        type: Number,
        required: true
    }  ,
    High_Angle_of_Attack: {
        type: Number,
        required: true
    }
});
 
var Flightdata = mongoose.model('Flightdata', flightDataSchema);
 
module.exports = Flightdata;