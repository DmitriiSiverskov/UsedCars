namespace Button.AutorizationAndRegistration
{
    public class RegisterButton : ClickButton
    {
        public void ButtonClick()
        {
            var ELL = EditingLoginLine();
            var EPL = EditingPasswordLine();
            if(ELL && EPL)
            {
                _db.Register(_inputLogin.text, _inputPassword.text);
                ShowCanvas(_db.ShowArrayCanvas[0], _db.ShowArrayCanvas[1]);
           
            }
        
        }
   
    }
}

