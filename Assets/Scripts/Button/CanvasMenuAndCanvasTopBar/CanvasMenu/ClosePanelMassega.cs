using ComponentSearch;
using UnityEngine;

namespace Button.CanvasMenuAndCanvasTopBar.CanvasMenu
{
    public class ClosePanelMassega : MonoBehaviour
    {
        [SerializeField] private PanelMassege _panelMassega;

        public void ClosePanel()
        {
            _panelMassega.gameObject.SetActive(false);
        }
    }
}