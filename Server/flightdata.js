var mongoose = require('mongoose');

// var flightDataSchema = mongoose.Schema({
//     _id: mongoose.Schema.Types.ObjectId,
//     Offset_sec: {
//         type: Number,
//         required: true
//     },
//     Latitude_deg: {
//         type: Number,
//         required: true
//     },
//     Longitude_deg: {
//         type: Number,
//         required: true
//     },
//     Altitude_ft: {
//         type: Number,
//         required: true
//     },
//     Airspeed_knot: {
//         type: Number,
//         required: true
//     },
//     Heading_deg: {
//         type: Number,
//         required: true
//     },
//     Flap_Position_deg: {
//         type: Number,
//         required: true
//     },
//     LndGear_Position: {
//         type: Number,
//         required: true
//     },
//     GrossWeight_lbs: {
//         type: Number,
//         required: true
//     },
//     GCD_to_Threshold: {
//         type: Number,
//         required: true
//     },
//     TCAS_RA: {
//         type: Number,
//         required: true
//     },
//     Stall_Warning: {
//         type: Number,
//         required: true
//     },
//     Windshear: {
//         type: Number,
//         required: true
//     }   ,
//     VFE: {
//         type: Number,
//         required: true
//     },
//     High_Angle_of_Bank  : {
//         type: Number,
//         required: true
//     },
//     High_Angle_of_Pitch: {
//         type: Number,
//         required: true
//     },
//     VMO : {
//         type: Number,
//         required: true
//     },
//     Dual_Input: {
//         type: Number,
//         required: true
//     }  ,
//     High_Angle_of_Attack: {
//         type: Number,
//         required: true
//     },
//     Flight_Day: {
//         type: Number,
//         required: true
//     }
// });
var flightDataSchema = mongoose.Schema({
    _id: mongoose.Schema.Types.ObjectId,
    ACN:{
            type: String,
            required: false
        },
    Date:{
            type: String,
            required: false
        },
    Local_Time_Of_Day:{
            type: String,
            required: false
        },
    Locale_Reference:{
            type: String,
            required: false
        },
    State_Reference:{
            type: String,
            required: false
        },
    Relative_Position_Angle_Radial:	{
            type: String,
            required: false
        },
    Relative_Position_Distance_Nautical_Miles:{
            type: String,
            required: false
        },
    Altitude_AGL_Single_Value:{
            type: String,
            required: false
        },
    Altitude_MSL_Single_Value:{
            type: String,
            required: false
        },
    Flight_Conditions:{
            type: String,
            required: false
        },
    Weather_Elements_Visibility:	{
            type: String,
            required: false
        },
    Work_Environment_Factor:{
            type: String,
            required: false
        },
    Light:{
            type: String,
            required: false
        },
    Ceiling:{
            type: String,
            required: false
        },
    RVR_Single_Value:{
            type: String,
            required: false
        },
    ATC_Advisory:{
            type: String,
            required: false
        },
    Aircraft_Operator:{
            type: String,
            required: false
        },
    Make_Model_Name2:{
            type: String,
            required: false
        },
    Aircraft_Zone:{
            type: String,
            required: false
        },
    Crew_Size:{
            type: String,
            required: false
        },
    Operating_Under_FAR_Part2:{
            type: String,
            required: false
        },
    Flight_Plan:{
            type: String,
            required: false
        },
    Mission:{
            type: String,
            required: false
        },
    Nav_In_Use2: {
            type: String,
            required: false
        },
    Flight_Phase:{
            type: String,
            required: false
        },
    Route_In_Use:{
            type: String,
            required: false
        },
    Airspace:{
            type: String,
            required: false
        },
    Maintenance_Status_Maintenance_Deferred:{
            type: String,
            required: false
        },
    Maintenance_Status_Records_Complete:{
            type: String,
            required: false
        },
    Maintenance_Status_Released_For_Service:	{
            type: String,
            required: false
        },
    Maintenance_Status_Required_Correct_Doc_On_Board:{
            type: String,
            required: false
        },
    Maintenance_Status_Maintenance_Type	:{
            type: String,
            required: false
        },
    Maintenance_Status_Maintenance_Items_Involved:{
            type: String,
            required: false
        },
    Cabin_Lighting:{
            type: String,
            required: false
        },
    Number_Of_Seats_Number:{
            type: String,
            required: false
        },
    Passengers_On_Board_Number:{
            type: String,
            required: false
        },
    Crew_Size_Flight_Attendant_Number_Of_Crew:{
            type: String,
            required: false
        },
    Aircraft_Component:{
            type: String,
            required: false
        },
    Manufacturer:{
            type: String,
            required: false
        },
    Aircraft_Reference:{
            type: String,
            required: false
        },
    Problem:{
            type: String,
            required: false
        },
    ATC_Advisory2:{
            type: String,
            required: false
        },
    Aircraft_Operator2:{
            type: String,
            required: false
        },
    Make_Model_Name:{
            type: String,
            required: false
        },
    Aircraft_Zone2:{
            type: String,
            required: false
        },
    Crew_Size2:{
            type: String,
            required: false
        },
    Operating_Under_FAR_Part:{
            type: String,
            required: false
        },
    Flight_Plan2:{
            type: String,
            required: false
        },
    Mission2	:{
            type: String,
            required: false
        },
    Nav_In_Use:{
            type: String,
            required: false
        },
    Flight_Phase2:{
            type: String,
            required: false
        },
    Route_In_Use2:{
            type: String,
            required: false
        },
    Airspace2:{
            type: String,
            required: false
        },
    Maintenance_Status_Maintenance_Deferred2:{
            type: String,
            required: false
        },
    Maintenance_Status_Records_Complete2:	{
            type: String,
            required: false
        },
    Maintenance_Status_Released_For_Service2:	{
            type: String,
            required: false
        },
    Maintenance_Status_Required_Correct_Doc_On_Board2:{
            type: String,
            required: false
        },
    Maintenance_Status_Maintenance_Type2:	{
            type: String,
            required: false
        },
    Maintenance_Status_Maintenance_Items_Involved2:{
            type: String,
            required: false
        },
    Cabin_Lighting2	:{
            type: String,
            required: false
        },
    Number_Of_Seats_Number2:{
            type: String,
            required: false
        },
    Passengers_On_Board_Number2:{
            type: String,
            required: false
        },
    Crew_Size_Flight_Attendant_Number_Of_Crew2:{
            type: String,
            required: false
        },
    Location_Of_Person	:{
            type: String,
            required: false
        },
    Location_In_Aircraft:{
            type: String,
            required: false
        },
    Reporter_Organization:{
            type: String,
            required: false
        },
    Function:{
            type: String,
            required: false
        },
    Qualification:{
            type: String,
            required: false
        },
    Experience	:{
            type: String,
            required: false
        },
    Cabin_Activity:	{
            type: String,
            required: false
        },
    Human_Factors:{
            type: String,
            required: false
        },
    Communication_Breakdown:	{
            type: String,
            required: false
        },
    ASRS_Report_Number_Accession_Number:	{
            type: String,
            required: false
        },
    Location_Of_Person2:{
            type: String,
            required: false
        },
    Location_In_Aircraft2:{
            type: String,
            required: false
        },
    Reporter_Organization2:{
            type: String,
            required: false
        },
    Function2	:{
            type: String,
            required: false
        },
    Qualification2:{
            type: String,
            required: false
        },
    Experience2	:{
            type: String,
            required: false
        },
    Cabin_Activity2:	{
            type: String,
            required: false
        },
    Human_Factors2:	{
            type: String,
            required: false
        },
    Communication_Breakdown2	:{
            type: String,
            required: false
        },
    ASRS_Report_Number_Accession_Number2	:{
            type: String,
            required: false
        },
    Anomaly:{
            type: String,
            required: false
        },
    Miss_Distance:{
            type: String,
            required: false
        },
    Were_Passengers_Involved_In_Event:{
            type: String,
            required: false
        },
    Detector:{
            type: String,
            required: false
        },
    When_Detected:{
            type: String,
            required: false
        },
    Result:{
            type: String,
            required: false
        },
    Contributing_Factors_Situations:{
            type: String,
            required: false
        },
    Primary_Problem:{
            type: String,
            required: false
        },
    Narrative:{
            type: String,
            required: false
        },
    Callback:{
            type: String,
            required: false
        },
    Narrative2:{
            type: String,
            required: false
        },
    Callback2:{
            type: String,
            required: false
        },
    Synopsis:{
            type: String,
            required: false
        },


});

var Defective2011 = mongoose.model('Defective2011', flightDataSchema);

module.exports = Defective2011;
