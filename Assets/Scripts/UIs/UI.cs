using UnityEngine;
using UnityEngine.UI;

namespace UIs
{
    public class UI : MonoBehaviour
    {
        [SerializeField] Button backButton;
        [SerializeField] Button forwardButton;
        [SerializeField] Button photoButton;

        public Button BackButton => backButton;

        public Button ForwardButton => forwardButton;

        public Button PhotoButton => photoButton;
        
        
    }
}
