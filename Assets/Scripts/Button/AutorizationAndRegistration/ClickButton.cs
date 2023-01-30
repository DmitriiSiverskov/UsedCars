using System.Collections;
using TMPro;
using UnityEngine;

namespace Button.AutorizationAndRegistration
{
    public abstract class ClickButton : MonoBehaviour
    {
        [SerializeField] protected TMP_InputField _inputLogin;
        [SerializeField] protected TMP_InputField _inputPassword;

        [SerializeField] protected GameObject _panelErrorLogin;
        [SerializeField] protected TextMeshProUGUI _textPanelErrorLogin;

        [SerializeField] protected GameObject _panelErrorPassword;
        [SerializeField] protected TextMeshProUGUI _textPanelErrorPassword;

        [SerializeField] protected short _leghtStringInputLogin;
        [SerializeField] protected float _timeLifeErrorPanel;
  
        [SerializeField] protected DB _db;

        private string[] _arrayTextError = { "Ограничение по вводу логина 30 симболов", 
            "Не корректный ввод почты",
            "Убедитесь в корректности расширения после точки (Пример : .com, .ru)",
            "Пароль должен содержать буквы и цифры",
            "Добрый день! Для регистрации требуется корректный ввод\nПример :\nLogin : (Имя@почта.расширение)\nPassword : (Буквы и цифры)",
            "Пароль должен быть не менее 8-ми симболов"};

        private void Start()
        {
            ShowInstructions(gameObject.name);
        }
        protected virtual void Update()
        {
            CheckingStringLeght();
        }
  
        protected void ClearInputText()
        {
            _inputLogin.text = string.Empty;
            _inputPassword.text = string.Empty;
       
        }

        protected void ShowCanvas(GameObject enable, GameObject disable)
        {
            enable.SetActive(true);
            disable.SetActive(false);
        }
        private void CheckingStringLeght()
        {
            if (_inputLogin.text.Length > _leghtStringInputLogin)
            {
                var str = _inputLogin.text.Remove(_leghtStringInputLogin, 1);
                _inputLogin.text = str;
                _textPanelErrorLogin.text = _arrayTextError[0]; 
                StartCoroutine(ShowPanelError(_panelErrorLogin));
            }
        }

        private IEnumerator ShowPanelError(GameObject panelError)
        {
            panelError.gameObject.SetActive(true);
            yield return new WaitForSeconds(_timeLifeErrorPanel);
            panelError.gameObject.SetActive(false);
        }

        protected bool EditingLoginLine()
        {
            bool simbolDog = true;
            bool simbolPoint = false;
            bool simbolExpansion = false;
            bool result = false;

            for (int i = 0; i < _inputLogin.text.Length; i++)
            {
                if (simbolDog)
                {
                    if (_inputLogin.text[i] == '@')
                    {
                        simbolDog = false;
                        simbolPoint = true;
                    }
                    else if (i == _inputLogin.text.Length - 1)
                    {

                        _textPanelErrorLogin.text = _arrayTextError[1];
                        StartCoroutine(ShowPanelError(_panelErrorLogin));
                        break;
                    }
                }
                if (simbolPoint)
                {
                    if (_inputLogin.text[i] == '.')
                    {

                        simbolPoint = false;
                        simbolExpansion = true;
                    }
                    else if (i == _inputLogin.text.Length - 1)
                    {
                        _textPanelErrorLogin.text = _arrayTextError[1];
                        StartCoroutine(ShowPanelError(_panelErrorLogin));
                        break;
                    }
                }
                if (simbolExpansion)
                {
                
                    i = _inputLogin.text.Length;
                    string str = string.Empty;

                    for (int j = _inputLogin.text.Length - 3; j < _inputLogin.text.Length; j++)
                    {
                        str += _inputLogin.text[j];
                    }
                    if (string.Equals(str, "com", System.StringComparison.Ordinal) | string.Equals(str, ".ru", System.StringComparison.Ordinal))
                    {
                        result = true;
                    }
                    else
                    {
                        _textPanelErrorLogin.text = _arrayTextError[2];
                        StartCoroutine(ShowPanelError(_panelErrorLogin));
                    }
                }
            }
            return result;
        }

        protected bool EditingPasswordLine()
        {
            bool result = false;

            if(_inputPassword.text.Length < 8)
            {
                _textPanelErrorPassword.text = _arrayTextError[5];
                StartCoroutine(ShowPanelError(_panelErrorPassword));
                return result;
            }

            for (int i = 0; i < _inputPassword.text.Length; i++)
            {
                if (char.IsDigit(_inputPassword.text[i]))
                {
                    if(i < _inputPassword.text.Length - 1 && char.IsLetter(_inputPassword.text[i + 1]))
                    {
                        result = true;
                        break;
                    }
                }
                if (char.IsLetter(_inputPassword.text[i]))
                {
                    if (i < _inputPassword.text.Length - 1 && char.IsDigit(_inputPassword.text[i + 1]))
                    {
                        result = true;
                        break;
                    }
                }

            }
            if(result == false)
            {
                _textPanelErrorPassword.text = _arrayTextError[3];
                StartCoroutine(ShowPanelError(_panelErrorPassword));
            }

            return result;
        }

        private void ShowInstructions(string str)
        {
            if (str == "ButtonRegister")
            {
                _textPanelErrorLogin.text = _arrayTextError[4];
                _timeLifeErrorPanel = 10;
                StartCoroutine(ShowPanelError(_panelErrorLogin));
                _timeLifeErrorPanel = 4;
            }
        }

    }
}
