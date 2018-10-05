using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FadeInScript : MonoBehaviour {
    public bool[] alphaBool;
    private List<Image> rend = new List<Image> ();
    public float FadeOutSpd=1f;
    public float FadeInSpd=0.5f;
    public GameObject[] objects;
	private int count;
	void Start () {
        //semua jadi transparan
		count = 0;
        for(int i=0;i<objects.Length;i++)
        {
            rend.Add(objects[i].GetComponent<Image>());
        }
       
        

        for (int i = 0; i < rend.Count; i++) {
            Color c = rend [i].color;
			c.a = 0f;
			rend [i].color = c;
            alphaBool[i] = false;
		}
	}
    
	void Update () {
        if (Input.anyKeyDown)
        {
            //Change which ones appear and disappear here;
            //**legend**
            //count: which panel is latest(added with any key input [down])
            //alphaBool[i] controls which panels will appear
            //* true means appear
            //* false means disappear

            count++;
            if (count == 6) { for (int i = 0; i < 6; i++) { alphaBool[i] = false; } }
            if (count == 11) { for (int i = 0; i < 11; i++) { alphaBool[i] = false; } }
            if (count == 16) { for (int i = 0; i < 16; i++) { alphaBool[i] = false; } }
            if (count == 22) { for (int i = 0; i < 22; i++) { alphaBool[i] = false; } }
            if (count == 24) { SceneManager.LoadScene("SelectLevel"); PlayerPrefs.SetInt("IntroDone", 1); }
        }
        for (int i=0;i<rend.Count;i++)
        {
            if (i==count) { alphaBool[i] = true;  }
            Color c = rend[i].color;
            if (alphaBool[i]) {
                if (c.a + FadeInSpd * Time.deltaTime > 1){ c.a = 1;  rend[i].color = c; }
                else if (c.a < 1)
                {
                    c.a += FadeInSpd * Time.deltaTime;
                    rend[i].color = c;
                }
            }
            else
            {
                if (c.a - FadeOutSpd * Time.deltaTime<0) { c.a = 0; rend[i].color = c; }
                else if (c.a > 0)
                {
                    c.a -= FadeOutSpd * Time.deltaTime;
                    rend[i].color = c;
                }
            }

        }
    }
}
