using System;
using System.Collections.Generic;
using GlobalVariable;
using UnityEngine;
using UnityEngine.Events;

namespace GlobalEvent
{
    public class GlobalEventManager : MonoBehaviour
    {
        public static UnityEvent<string> DataTransmissionButtonMark = new UnityEvent<string>();
        public static UnityEvent<string> DataTransmissionButtonModel = new UnityEvent<string>();
        public static UnityEvent<string> DataTransmissionButtonGeneration = new UnityEvent<string>();
        public static UnityEvent<string> DataTransmissionButtonModification = new UnityEvent<string>();
        public static UnityEvent<string> DataTransmissionButtonDrive = new UnityEvent<string>();
        public static UnityEvent<string> DataTransmissionButtonFuelGrade = new UnityEvent<string>();
        public static UnityEvent<string> DataTransmissionButtonStatus = new UnityEvent<string>();
        public static UnityEvent<string> DataTransmissionButtonOriginalPTS = new UnityEvent<string>();
        public static UnityEvent DataTransmissionStateCanvasTopBar = new UnityEvent();
        public static UnityEvent<StataCanvasTopBar> DataTran = new UnityEvent<StataCanvasTopBar>();
        public static UnityEvent<string> RemoveObject = new UnityEvent<string>();
        public static UnityEvent<string,string> AddComment = new UnityEvent<string, string>();
        

        public static UnityEvent<bool> ActiveCanvasEnterData = new UnityEvent<bool>();
    }
}