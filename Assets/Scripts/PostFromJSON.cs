using UnityEngine;

public class PostFromJSON : MonoBehaviour
{
    public GameObject postPrefab;
    public Transform contentParent;

    void Start()
    {
        TextAsset jsonData = Resources.Load<TextAsset>("post");
        if (jsonData == null)
        {
            Debug.LogError(" post.json not found in Resources folder!");
            return;
        }

        PostList postList = JsonUtility.FromJson<PostList>(jsonData.text);
        if (postList?.posts == null)
        {
            Debug.LogError(" post.json format incorrect or no posts found.");
            return;
        }

        foreach (PostData post in postList.posts)
        {
            GameObject go = Instantiate(postPrefab, contentParent);
            LoadPost loader = go.GetComponent<LoadPost>();
            loader.Load_Post(post);
        }
    }
}
