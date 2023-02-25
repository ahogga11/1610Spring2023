using System.Globalization;
using Scenes;
using UnityEngine;
using UnityEngine.UI;

namespace TextMesh_Pro
{
    [RequireComponent(typeof(Text))]
    public class TextLabelBehavior : MonoBehaviour
    {
        public Text label;
        public FloatData dataObj;

        private void Start()

        {

            label = GetComponent<Text>();
            UpdateLabel();
        }

        public void UpdateLabel()
        {
            label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
        }
    }
}