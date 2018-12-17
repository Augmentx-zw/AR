using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class details : MonoBehaviour {

    public Text textshowed = null;
    public void about (string detail)
    {
        textshowed.text = detail;
    }

}
