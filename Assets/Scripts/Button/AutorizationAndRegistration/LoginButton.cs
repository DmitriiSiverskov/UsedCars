namespace Button.AutorizationAndRegistration
{
    public class LoginButton : ClickButton
    {
        protected override void Update()
        {
            base.Update();
            if (_db.EnterMenu)
            {
                ShowCanvas(_db.ShowArrayCanvas[2], _db.ShowArrayCanvas[0]);
            }
        }
        public void ButtonClick()
        {
            if (_inputLogin.text == "root" & _inputPassword.text == "root")
            {
                ClearInputText();
                ShowCanvas(_db.ShowArrayCanvas[1], _db.ShowArrayCanvas[0]);
            }
            else
            {
                _db.Autorization(_inputLogin.text, _inputPassword.text);
            }
     
        }
    }
}

