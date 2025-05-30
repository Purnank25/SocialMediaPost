using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadPost : MonoBehaviour
{
    public TextMeshProUGUI usernameText;
    public Image profilePic;
    public TextMeshProUGUI contentText;
    public Button likeButton;
    public TextMeshProUGUI likeCountText;
    public Sprite likedSprite, unlikedSprite;

    private bool isLiked = false;
    private int likeCount ;

    public void Start()
    {
        likeCount = int.Parse(likeCountText.text);
    }

    public void ToggleLike()
    {
        isLiked = !isLiked;
        if (isLiked)
        {
             likeCount++;
            likeButton.image.sprite = likedSprite;
        }
        else
        {
            likeCount--;
        }
        likeCountText.text = likeCount.ToString();
         
        Debug.Log("program starrted");
    }
}
