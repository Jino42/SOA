using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOA
{
    public class BaseVariable<T> : SOA_BaseObject
    {
        [SerializeField]
        protected T _value = default;

        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }

}
