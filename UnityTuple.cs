using UnityEngine;
using System.Collections.Generic;
using System.Linq;

/* Tuple structs implementation for Unity 3d */
namespace Assets
{
	public class UnityTuple<T1, T2> : Object 
	{
        public T1 _value1;
        public T2 _value2;

        public UnityTuple(T1 v1, T2 v2)
        {
            _value1 = v1;
            _value2 = v2;
        }
    }

    public class UnityTuple<T1, T2, T3> : Object
    {
        public T1 _value1;
        public T2 _value2;
        public T3 _value3;

        public UnityTuple(T1 v1, T2 v2, T3 v3)
        {
            _value1 = v1;
            _value2 = v2;
            _value3 = v3;
        }
    }
}