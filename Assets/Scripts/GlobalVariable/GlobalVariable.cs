using System;
using Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button.AbstractClass;

namespace GlobalVariable
{
    public enum StataCanvasTopBar
    {
        List,
        Auto,
        Owner
    }
    [System.Serializable]
    public static class GlobalVariable
    {
        public static string VariableNameMark { get; set; }
        public static string VariableNameModel { get; set; }
        public static string VariableNameGeneration { get; set; }
        public static string VariableNameModification { get; set; }
        public static string VariableNameBodyType { get; set; }
        public static string VariableNameDrive { get; set; }
        public static string VariableNameFielGrade { get; set; }
        public static string VariableNameVin { get; set; }
        public static string VariableNameRun { get; set; }
        public static string VariableNameYear { get; set; }
        public static string VariableNameRegistrationPlate { get; set; }
        public static string VariableNameColorCar { get; set; }
        public static string VariableNameStatus { get; set; }
        public static string VariableNameNumberOfOwner { get; set; }
        public static string VariableNameNumberPTS { get; set; }
        public static string VariableNameNumberCPTS { get; set; }
        public static string VariableNameNumberDVS { get; set; }
        public static string VariableNameOriginalPTS { get; set; }
        public static string VariableNamePrice { get; set; }
        public static string VariableNameComent = String.Empty;
        public static string VariableNameLastName { get; set; }
        public static string VariableNameFirstName { get; set; }
        public static string VariableNameMiddleName { get; set; }
        public static string VariableNameSeriesAndNumber { get; set; }
        public static string VariableNameIssuedByWhom { get; set; }
        public static string VariableNameRegistration { get; set; }
        public static string VariableNameNumberPhone { get; set; }
        public static string VariableNameRegistrationDate { get; set; }
        public static StateButton StateButton { get; set; }
        public static StataCanvasTopBar StateCanvasTopBar { get; set; }
    }
}