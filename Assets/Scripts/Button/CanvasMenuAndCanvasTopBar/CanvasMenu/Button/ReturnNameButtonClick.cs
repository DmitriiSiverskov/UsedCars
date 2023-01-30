using Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button.AbstractClass;
using GlobalEvent;
using TMPro;
using UnityEngine;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasMenu.Button
{
    public class ReturnNameButtonClick : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _buttonItemText;
        
        public void Close()
        {
            if (GlobalVariable.GlobalVariable.StateButton == StateButton.MarkButton)
            {
                GlobalEventManager.DataTransmissionButtonMark.Invoke(_buttonItemText.text);
            }
            else if (GlobalVariable.GlobalVariable.StateButton == StateButton.ModelButton)
            {
                GlobalEventManager.DataTransmissionButtonModel.Invoke(_buttonItemText.text);
            }
            else if (GlobalVariable.GlobalVariable.StateButton == StateButton.GenerationButton)
            {
                GlobalEventManager.DataTransmissionButtonGeneration.Invoke(_buttonItemText.text);
            }
            else if (GlobalVariable.GlobalVariable.StateButton == StateButton.ModificationButton)
            {
                GlobalEventManager.DataTransmissionButtonModification.Invoke(_buttonItemText.text);
            }
            else if (GlobalVariable.GlobalVariable.StateButton == StateButton.Drive)
            {
                GlobalEventManager.DataTransmissionButtonDrive.Invoke(_buttonItemText.text);
            }
            else if (GlobalVariable.GlobalVariable.StateButton == StateButton.FielGrade)
            {
                GlobalEventManager.DataTransmissionButtonFuelGrade.Invoke(_buttonItemText.text);
            }
            else if (GlobalVariable.GlobalVariable.StateButton == StateButton.Status)
            {
                GlobalEventManager.DataTransmissionButtonStatus.Invoke(_buttonItemText.text);
            }
            else if (GlobalVariable.GlobalVariable.StateButton == StateButton.OriginalPTS)
            {
                GlobalEventManager.DataTransmissionButtonOriginalPTS.Invoke(_buttonItemText.text);
            }
            GlobalEventManager.ActiveCanvasEnterData.Invoke(false);
        }
    }
}