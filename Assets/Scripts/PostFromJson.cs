using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PostFromJSON : MonoBehaviour
{
    public TextMeshProUGUI username;
    public TextMeshProUGUI postContent;
    public TextMeshProUGUI likeCount;

    
     void Start()
    {
        TextAsset jsonFile = Resources.Load<TextAsset>("post");
        if (jsonFile != null)
        {
            PostData postData = JsonUtility.FromJson<PostData>(jsonFile.text);
            Debug.Log("post data result =" + postData.likeCount);
            username.text = postData.userName;
            postContent.text = postData.postContent;
            likeCount.text = postData.likeCount.ToString();

        }
        else
        {
            Debug.Log("json not found");
        }

    }
    void Update()
    {

    }

}