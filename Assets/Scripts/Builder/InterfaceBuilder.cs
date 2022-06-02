using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Builder
{
    public class InterfaceBuilder : MonoBehaviour, IInterfaceBuilder
    {
        private readonly Dictionary<string,GameObject> _elements = new ();

        private void Start()
        {
            _elements.Add("top", GameObject.Find("MiddleTopImages"));
            _elements.Add("column", GameObject.Find("LeftColumn"));
            _elements.Add("images", GameObject.Find("Images"));
            _elements.Add("bottom", GameObject.Find("BottomBtns"));
        }

        public IInterfaceBuilder BuildLeftColumn()
        {
            _elements["column"].SetActive(true);
            return this;
        }

        public IInterfaceBuilder BuildMiddleTopImages()
        {
            _elements["top"].SetActive(true);
            return this;
        }

        public IInterfaceBuilder BuildImages()
        {
            _elements["images"].SetActive(true);
            return this;
        }

        public IInterfaceBuilder BuildBottomBtns()
        {
            _elements["bottom"].SetActive(true);
            return this;
        }

        public IInterfaceBuilder Init()
        {
            foreach (var element in _elements)
            {
                element.Value.SetActive(false);
            }

            return this;
        }
    }
}