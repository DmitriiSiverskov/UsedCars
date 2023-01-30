using UnityEngine;

namespace PanelQuestion
{
    public class QuestionPanel : MonoBehaviour
    {
        [SerializeField] private GameObject _panelQestion;

        public void Cancel()
        {
            _panelQestion.gameObject.SetActive(false);
        }
    }
}