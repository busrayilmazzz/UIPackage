using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit.Experimental.UI;


namespace com.asger.core.modules.ui
{
    public class TextManagerInputField : MonoBehaviour
    {
        [SerializeField]
        private Text text;

        private string MrtkGuiInputField_Text_1="";

        // Start is called before the first frame update
        void Start()
        {
          
            gameObject.GetComponent<MRTKUGUIInputField>().onEndEdit.AddListener(delegate { SetInputField(text.GetComponent<Text>().text); });
        }


        private void SetInputField(string MrtkGuiInputField_Text_1)
        {

        
            this.MrtkGuiInputField_Text_1 = MrtkGuiInputField_Text_1;

        }


        public string GetInputField()
        {
            return MrtkGuiInputField_Text_1;
        }

    }
}
