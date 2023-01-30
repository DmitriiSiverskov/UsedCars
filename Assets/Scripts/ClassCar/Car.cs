using UnityEngine;

namespace ClassCar
{
    public class Car : MonoBehaviour
    {
        public string _mark;
        public string _model;
        public string _generation;
        public string _modification;
        public string _bodyType;
        public string _drive;
        public string _fuelGrade;
        public string _vinNumber;
        public string _run;
        public string _year;
        public string _registrationPlate;
        public string _colorCar;
        public string _status;
        public string _numberOfOwner;
        public string _numberPTS;
        public string _numberCPTS;
        public string _numberDVS;
        public string _originPTS;
        public string _lastName;
        public string _firstName;
        public string _middleName;
        public string _seriesAndNumber;
        public string _issuedByWhom;
        public string _registration;
        public string _numberPhone;
        public string _registrationDate;
        public string _price;
        public string _coment;

        public Car(string mark, string model, string generation, string modification, string bodyType, string drive, string fuelGrade, string vinNumber, string run, string year, string registrationPlate, string colorCar, string status, string numberOfOwner, string numberPts, string numberCpts, string numberDvs, string originPts,string price, string lastName, string firstName, string middleName, string seriesAndNumber, string issuedByWhom, string registration, string numberPhone, string registrationDate,string coment)
        {
            _mark = mark;
            _model = model;
            _generation = generation;
            _modification = modification;
            _bodyType = bodyType;
            _drive = drive;
            _fuelGrade = fuelGrade;
            _vinNumber = vinNumber;
            _run = run;
            _year = year;
            _registrationPlate = registrationPlate;
            _colorCar = colorCar;
            _status = status;
            _numberOfOwner = numberOfOwner;
            _numberPTS = numberPts;
            _numberCPTS = numberCpts;
            _numberDVS = numberDvs;
            _originPTS = originPts;
            _price = price;
            _lastName = lastName;
            _firstName = firstName;
            _middleName = middleName;
            _seriesAndNumber = seriesAndNumber;
            _issuedByWhom = issuedByWhom;
            _registration = registration;
            _numberPhone = numberPhone;
            _registrationDate = registrationDate;
            _coment = coment;
        }
    }
}