using UnityEngine;

namespace SOA
{
    [System.Serializable]
    public class BaseReference<TBase, TVariable> where TVariable : BaseVariable<TBase>
    {
        public BaseReference() { }
        public BaseReference(TBase baseValue)
        {
            _useConstant = true;
            _constantValue = baseValue;
        }

        [SerializeField]
        protected bool _useConstant = false;
        [SerializeField]
        protected TBase _constantValue = default;
        [SerializeField]
        protected TVariable _variable = default;

        public TBase Value
        {
            get
            {
                return (_useConstant || _variable == null) ? _constantValue : _variable.Value;
            }
            set
            {
                if (!_useConstant && _variable != null)
                {
                    _variable.Value = value;
                }
                else
                {
                    _useConstant = true;
                    _constantValue = value;
                }
            }
        }
        static public bool operator true(BaseReference<TBase, TVariable> b) { return b._useConstant || b._variable != null; }
        static public bool operator false(BaseReference<TBase, TVariable> b) { return !(b._useConstant || b._variable != null); }

    }
}