using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Data;
using UnityEngine.Rendering;
using System.IO;

public class PostFromJSON : MonoBehaviour
{
    public TextMeshProUGUI username;
    public TextMeshProUGUI postContent;
    public TextMeshProUGUI likeCount;
    public Image profilePicture;
    public GameObject postPrefabs;
    public Transform postContainer;
    public TextAsset jsonFile;
    void Start()
    {
        jsonFile = Resources.Load<TextAsset>("post");
        if (jsonFile != null)
        {
            PostData postData = JsonUtility.FromJson<PostData>(jsonFile.text);
            username.text = postData.userName;
            postContent.text = postData.postContent;
            likeCount.text = postData.likeCount.ToString();
            Sprite profilePictureSprite = Resources.Load<Sprite>(postData.imageUrl);
            if (profilePictureSprite != null)
            {
                profilePicture.sprite = profilePictureSprite;
            }
            else
            {
                Debug.Log("Sprite was not found");
            }
        }
        else
        {
            Debug.Log("json not found");
        }
    }
}