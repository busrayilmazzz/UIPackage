using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
using System;

namespace com.asger.core.modules.ui
{
    public class TextManagerInputField : MonoBehaviour
    {

        [SerializeField]
        private Text text;

        private string mrtkGuiInputField_Text;

        private MRTKUGUIInputField mrtkUGUIInputField;


        // Start is called before the first frame update
        void Start()
        {
            mrtkGuiInputField_Text = "";

            try
            {
                mrtkUGUIInputField = gameObject.GetComponent<MRTKUGUIInputField>();

                try
                {

                    mrtkUGUIInputField.onEndEdit.AddListener(delegate { SetInputField(text.GetComponent<Text>().text); });

                }
                catch (Exception e)
                {

                    Debug.Log("TextManagerInputField Start() | mrtkUGUIInputField onEndEdit AddListener : " + e.Message);

                }


            }
            catch (Exception e)
            {

                Debug.Log("TextManagerInputField Start() | mrtkUGUIInputField not found : " + e.Message);

            }


        }


        private void SetInputField(string mrtkGuiInputField_Text)
        {
            Debug.Log("TextManagerInputField SetInputField() | Begin |  mrtkUGUIInputField setting... ");

            this.mrtkGuiInputField_Text = mrtkGuiInputField_Text;

            Debug.Log("TextManagerInputField SetInputField() | End ");
        }


        public string GetInputField()
        {
            Debug.Log("TextManagerInputField GetInputField() | mrtkUGUIInputField text : " + mrtkGuiInputField_Text);

            return mrtkGuiInputField_Text;
        }

    }
}
