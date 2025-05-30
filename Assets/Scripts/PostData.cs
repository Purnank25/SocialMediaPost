using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
[System.Serializable]
public class PostData
{
    public string username;
    public string postContent;
    public int likeCount;
    public Sprite profilePicture;
}
public class PostList
{
    public PostData posts;
}
