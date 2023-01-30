using System;
using System.Collections;
using System.Collections.Generic;
using ClassCar;
using ComponentSearch;
using Firebase.Auth;
using Firebase.Database;
using GlobalEvent;
using ItemScriptableObject;
using TMPro;
using UnityEngine;

namespace Button.AutorizationAndRegistration
{
    public class DB : MonoBehaviour
    {
        protected DatabaseReference _dataBaseRef;
        private FirebaseAuth _auth;
        
        [SerializeField] private TextMeshProUGUI _textEnter;
        [SerializeField] private IndeõItemCarsSo _indeõItemCars;
        [SerializeField] private ContentCanvasListAuto _contentCanvasListAuto;
        [SerializeField] private ItemButtonCanvasListAuto _itemButtonCanvasListAuto;
        
        public TextMeshProUGUI TextEnter => _textEnter;

        [SerializeField]private GameObject[] _arrayCanvas;
        public GameObject[] ShowArrayCanvas => _arrayCanvas;
        public bool EnterMenu = false;
        
        private List<GameObject> _listItemButtonCanvasListAuto = new List<GameObject>();
        private Dictionary<string,string[]> _dictionaryCars = new Dictionary<string, string[]>();
        void Start()
        {
            _dataBaseRef = FirebaseDatabase.DefaultInstance.RootReference;
            _auth = FirebaseAuth.DefaultInstance;
            _auth.SignOut();
            GlobalEventManager.RemoveObject.AddListener(RemoveObject);
            GlobalEventManager.AddComment.AddListener(AddComment);
            StartCoroutine(LoadData());
        }

        public void Auth_StateChanged(object sender, System.EventArgs e)
        {
            if(_auth.CurrentUser != null)
            {
                _textEnter.text = "Âõîä âûïîëíåí " + _auth.CurrentUser.Email;
                EnterMenu = true;
            }
            else
            {
                _textEnter.text = "Ïî÷òà èëè ïàðîëü íå âåðíû";
            }
        }

        public void SaveData(Car car)
        {
            string json = JsonUtility.ToJson(car);
            _dataBaseRef.Child("Ìàøèíû").Child(_indeõItemCars.Index + car._mark).SetRawJsonValueAsync(json);
            _indeõItemCars.Index++;
            _dataBaseRef.Child("Ìàøèíû").Child("ID").SetValueAsync(_indeõItemCars.Index);
        }

        public IEnumerator LoadData()
        {
            var car = _dataBaseRef.Child("Ìàøèíû").GetValueAsync();
            yield return new WaitUntil(predicate: () => car.IsCompleted);
          

            if (car.Exception != null)
            {
                Debug.LogError(car.Exception);
            }
            else if (car.Result == null)
            {
                Debug.Log("Null");
            }
            else
            {
                DataSnapshot snapshot = car.Result;
                if (_listItemButtonCanvasListAuto.Count > 0)
                {
                    foreach (var item in _listItemButtonCanvasListAuto)
                    {
                        Destroy(item.gameObject);
                    }
                }
                foreach (var item in snapshot.Children)
                {
                    if (item.Key != "ID")
                    {
                        _itemButtonCanvasListAuto.pathObject = item.Key;
                        var itemButtonCanvasListAuto =
                            Instantiate(_itemButtonCanvasListAuto, _contentCanvasListAuto.transform);
                        itemButtonCanvasListAuto.GetComponentInChildren<Mark>().GetComponent<TMP_Text>().text =
                            item.Child("_mark").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<Model>().GetComponent<TMP_Text>().text =
                            item.Child("_model").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<Generation>().GetComponent<TMP_Text>().text =
                            item.Child("_generation").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<Modification>().GetComponent<TMP_Text>().text =
                            item.Child("_modification").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<BodyType>().GetComponent<TMP_Text>().text =
                            item.Child("_bodyType").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<Drive>().GetComponent<TMP_Text>().text =
                            item.Child("_drive").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<FuelGrade>().GetComponent<TMP_Text>().text =
                            item.Child("_fuelGrade").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<VinNumber>().GetComponent<TMP_Text>().text =
                            item.Child("_vinNumber").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<Run>().GetComponent<TMP_Text>().text =
                            item.Child("_run").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<Year>().GetComponent<TMP_Text>().text =
                            item.Child("_year").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<RegistrationPlate>().GetComponent<TMP_Text>()
                                .text =
                            item.Child("_registrationPlate").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<ColorCar>().GetComponent<TMP_Text>().text =
                            item.Child("_colorCar").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<Status>().GetComponent<TMP_Text>().text =
                            item.Child("_status").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<NumberOfOwner>().GetComponent<TMP_Text>().text =
                            item.Child("_numberOfOwner").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<NumberPTS>().GetComponent<TMP_Text>().text =
                            item.Child("_numberPTS").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<NumberCPTS>().GetComponent<TMP_Text>().text =
                            item.Child("_numberCPTS").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<NumberDVS>().GetComponent<TMP_Text>().text =
                            item.Child("_numberDVS").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<OriginPTS>().GetComponent<TMP_Text>().text =
                            item.Child("_originPTS").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<Price>().GetComponent<TMP_Text>().text =
                            item.Child("_price").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<LastName>().GetComponent<TMP_Text>().text =
                            item.Child("_lastName").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<FirstName>().GetComponent<TMP_Text>().text =
                            item.Child("_firstName").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<MiddleName>().GetComponent<TMP_Text>().text =
                            item.Child("_middleName").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<SeriesAndNumber>().GetComponent<TMP_Text>()
                                .text =
                            item.Child("_seriesAndNumber").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<IssuedByWhom>().GetComponent<TMP_Text>().text =
                            item.Child("_issuedByWhom").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<Registration>().GetComponent<TMP_Text>().text =
                            item.Child("_registration").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<RegistrationData>().GetComponent<TMP_Text>()
                                .text =
                            item.Child("_registrationDate").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<NumberPhone>().GetComponent<TMP_Text>().text =
                            item.Child("_numberPhone").Value.ToString();
                        itemButtonCanvasListAuto.GetComponentInChildren<Comment>().GetComponent<TMP_Text>().text =
                            item.Child("_coment").Value.ToString();


                        _listItemButtonCanvasListAuto.Add(itemButtonCanvasListAuto.gameObject);
                    }
                    else
                    {
                        var value = item.GetValue(true);
                        _indeõItemCars.Index = Convert.ToInt32(value);
                    }
                }
             
            }
        }

        public void Autorization(string login, string password)
        {
            _auth.SignInWithEmailAndPasswordAsync(login, password);
            _auth.StateChanged += Auth_StateChanged;
        }

        public void Register(string login, string password)
        {
            _auth.CreateUserWithEmailAndPasswordAsync(login, password);
        }

        private void RemoveObject(string path)
        {
            _dataBaseRef.Child("Ìàøèíû").Child(path).RemoveValueAsync();
            StartCoroutine(LoadData());
        }

        private void AddComment(string path, string text)
        {
            _dataBaseRef.Child("Ìàøèíû").Child(path).Child("_coment").SetValueAsync(text);
            StartCoroutine(LoadData());
        }

        private IEnumerator LoadID()
        {
            var id = _dataBaseRef.Child("ID").GetValueAsync();
            yield return new WaitUntil(predicate:() => id.IsCompleted);
            if (id.Exception != null)
            {
                Debug.LogError(id.Exception);
            }
            else if (id.Result == null)
            {
                Debug.Log("Null");
            }
            else
            {
                DataSnapshot snapshotq = id.Result;
                var s = snapshotq.Child("ID").Value.ToString();
                _indeõItemCars.Index = Int32.Parse(s);
                print(_indeõItemCars.Index);
            }
           
        }
    }
}
