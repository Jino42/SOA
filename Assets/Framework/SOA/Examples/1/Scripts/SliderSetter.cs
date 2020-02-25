using UnityEngine;
using UnityEngine.UI;
using SOA;

namespace SOA.Example
{
    [ExecuteInEditMode]
    public class SliderSetter : MonoBehaviour
    {
        public Slider Slider;
        public FloatVariable Variable;
        public FloatVariable Max;

        private void Start()
        {
            Slider.maxValue = Max.Value;
        }

        private void Update()
        {
            if (Slider != null && Variable != null)
                Slider.value = Variable.Value;
        }
    }
}
