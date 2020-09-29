using System;
using UnityEngine;

namespace RPG.Cinematics
{
    public class FakePlayableDirector : MonoBehaviour
    {
        public event Action<float> onFinish;

        private void Start()
        {
            Invoke("OnFinish", 3f);
        }

        private void OnFinish()
        {
            onFinish(4.3f);
        }
    }
}