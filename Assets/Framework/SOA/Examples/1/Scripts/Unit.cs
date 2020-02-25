using UnityEngine;

namespace SOA.Example
{
    public class Unit : MonoBehaviour
    {
        public FloatVariable LifeCurrent;
        public bool ResetHp = true;
        public FloatReference LifeMax;
        public IntGameEvent DamageEvent;
        public GameEvent DeathEvent;
        public IntReference ParticleEmitWhenDamaged;


        private void OnEnable()
        {
            if (ResetHp)
                LifeCurrent.Value = LifeMax.Value;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            print("Yes");
            DamageDealer damage = other.gameObject.GetComponent<DamageDealer>();
            if (damage != null)
            {
                print("damage");

                LifeCurrent.Value -= damage.DamageAmount.Value;
                DamageEvent.Raise((int)LifeCurrent.Value);
            }

            if (LifeCurrent.Value <= 0.0f)
            {
                print("LifeCurrent");

                DeathEvent.Raise();
            }
        }
    }
}