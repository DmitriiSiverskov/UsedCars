using Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button.AbstractClass;
using GlobalEvent;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button
{
    public class FuelGradeButton : itemButton
    {
        protected override void Start()
        {
            base.Start();
            
            GlobalEventManager.DataTransmissionButtonFuelGrade.AddListener(SetName);
        }

        public void Click()
        {
            ShowCanvasEnterData(GlobalVariable.GlobalVariable.StateButton = StateButton.FielGrade);
        }
    }
}