using UnityEngine;

namespace SOA.Example
{
    public class DamageDealer : MonoBehaviour
    {
        public SetGameObject SetDamageDealer;
        public FloatReference DamageAmount;

        private void OnEnable()
        {
            SetDamageDealer.Add(gameObject);
        }
        private void OnDisable()
        {
            SetDamageDealer.Remove(gameObject);
        }
    }
}

