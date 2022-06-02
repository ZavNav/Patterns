using System;
using UnityEngine;

namespace Builder
{
    public class UIDirector : MonoBehaviour
    {
        private IInterfaceBuilder _interfaceBuilder;

        private void Start()
        {
            _interfaceBuilder = FindObjectOfType<InterfaceBuilder>();
        }

        public void BuildEasyUI()
        {
            _interfaceBuilder.Init()
                .BuildBottomBtns()
                .BuildMiddleTopImages();
        }

        public void BuildFullUI()
        {
            _interfaceBuilder.Init()
                .BuildImages()
                .BuildBottomBtns()
                .BuildMiddleTopImages()
                .BuildLeftColumn();
        }
    }
}