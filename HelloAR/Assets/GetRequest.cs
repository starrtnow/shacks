using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class GetRequest : MonoBehaviour {

    public TextMesh text;
    // Use this for initialization
    void Start () {
        StartCoroutine(Upload());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Upload()
    {
        List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        formData.Add(new MultipartFormDataSection("image", "test"));

        UnityWebRequest www = UnityWebRequest.Post("138.68.230.6:5000/nutri/", formData);
        yield return www.SendWebRequest();

        if(www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
        }
    }
}
