//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnvisionAGreenLife.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class clothes_washer
    {
        public int Clothes_Washer_Id { get; set; }
        public string ApplStandard { get; set; }
        public string Brand { get; set; }
        public Nullable<decimal> Cap { get; set; }
        public Nullable<int> Cap_Second_Drum { get; set; }
        public Nullable<int> CEC_Cold { get; set; }
        public Nullable<int> CEC_Cold_Second_Drum { get; set; }
        public Nullable<int> CEC { get; set; }
        public Nullable<int> CEC_Second_Drum { get; set; }
        public string Cold_Prog { get; set; }
        public Nullable<int> Cold_Prog_Second_Drum { get; set; }
        public Nullable<decimal> Cold_Wat_Cons { get; set; }
        public Nullable<int> Cold_Wat_Cons_Second_Drum { get; set; }
        public string Combination { get; set; }
        public string Combination_Second_Drum { get; set; }
        public string Conn_Mode { get; set; }
        public string Conn_Mode_Second_Drum { get; set; }
        public string Country { get; set; }
        public string delayStartMode { get; set; }
        public string delayStartMode_Second_Drum { get; set; }
        public Nullable<int> Depth { get; set; }
        public Nullable<int> Depth_Second_Drum { get; set; }
        public string DetergentType { get; set; }
        public string DetergentType_Second_Drum { get; set; }
        public Nullable<int> Height { get; set; }
        public Nullable<int> Height_Second_Drum { get; set; }
        public Nullable<decimal> Hot_Wat_Cons { get; set; }
        public Nullable<int> Hot_Wat_Cons_Second_Drum { get; set; }
        public string internal_heater { get; set; }
        public string internal_heater_Second_Drum { get; set; }
        public string Loading { get; set; }
        public string Loading_Second_Drum { get; set; }
        public string MachineAction { get; set; }
        public Nullable<int> MachineAction_Second_Drum { get; set; }
        public string Model_No { get; set; }
        public string Family_Name { get; set; }
        public string N_Standard { get; set; }
        public Nullable<decimal> New_SRI { get; set; }
        public Nullable<decimal> New_SRI_Second_Drum { get; set; }
        public Nullable<decimal> New_Star { get; set; }
        public Nullable<int> New_Star_Second_Drum { get; set; }
        public Nullable<decimal> postProgenergy { get; set; }
        public Nullable<decimal> postProgenergy_Second_Drum { get; set; }
        public Nullable<decimal> powerConsMode { get; set; }
        public Nullable<decimal> powerConsMode_Second_Drum { get; set; }
        public string Prog_Name { get; set; }
        public string Prog_Name_Second_Drum { get; set; }
        public string Sold_in { get; set; }
        public Nullable<decimal> standbyPowerUsage { get; set; }
        public Nullable<int> standbyPowerUsage_Second_Drum { get; set; }
        public Nullable<int> Submit_ID { get; set; }
        public string SubmitStatus { get; set; }
        public Nullable<decimal> Test_Prog_Time { get; set; }
        public Nullable<int> Test_Prog_Time_Second_Drum { get; set; }
        public Nullable<decimal> Tot_Wat_Cons { get; set; }
        public Nullable<int> Tot_Wat_Cons_Second_Drum { get; set; }
        public string Type { get; set; }
        public string Type_Second_Drum { get; set; }
        public Nullable<decimal> WEI { get; set; }
        public Nullable<decimal> WEI_Second_Drum { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Width_Second_Drum { get; set; }
        public Nullable<System.DateTime> ExpDate { get; set; }
        public Nullable<int> GrandDate { get; set; }
        public string Product_Class { get; set; }
        public string Availability_Status { get; set; }
        public string Product_Website { get; set; }
        public string Representative_Brand_URL { get; set; }
        public Nullable<decimal> Program_Time { get; set; }
        public Nullable<int> Program_Time_Second_Drum { get; set; }
        public Nullable<decimal> Hot_Water_L { get; set; }
        public Nullable<decimal> Hot_Water_L_Second_Drum { get; set; }
        public Nullable<decimal> Cold_Water_L { get; set; }
        public Nullable<int> Cold_Water_L_Second_Drum { get; set; }
        public Nullable<int> Star_Rating_old { get; set; }
        public string Star_Image_Large { get; set; }
        public string Star_Image_Large_Second_Drum { get; set; }
        public string Star_Image_Small { get; set; }
        public string Star_Image_Small_Second_Drum { get; set; }
        public string Registration_Number { get; set; }
        public Nullable<int> Type_Id { get; set; }
    
        public virtual appliance_types appliance_types { get; set; }
    }
}
