using TMPro.Examples;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class LoadPost : MonoBehaviour
{
    public TextMeshProUGUI username;
    public TextMeshProUGUI postContent;
    public int likeCount = 0;
    public Image profilePicture;
    public Button likeButton ;
    public TextMeshProUGUI likeCountText;

    public bool isLiked = false;
    public Sprite likedSprite;
    public Sprite unlikedSprite;
    public Image buttonImage ;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Load_Post(PostData data)
    {
        username.text = data.userName;
        postContent.text = data.postContent;
        likeCount = data.likeCount;
        likeCountText.text = likeCount.ToString();
        likeButton.onClick.AddListener(ToggleLike);

    }
    public void ToggleLike()
    {
        isLiked = !isLiked;
       
        likeCountText.text = likeCount.ToString();
        if (isLiked) {
            likeButton.image.sprite = likedSprite;
            likeCount++;
        }
        else
        {
            {
                likeButton.image.sprite = unlikedSprite;
               
            }
        }

    }
}
