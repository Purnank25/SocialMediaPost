using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LoadPost : MonoBehaviour
{
    public TextMeshProUGUI username;
    public TextMeshProUGUI postContent;
    public Image profilePicture;
    public Button likeButton;
    public TextMeshProUGUI likeCountText;
    public Image buttonImage;
    public Sprite likedSprite;
    public Sprite unlikedSprite;

    private int likeCount = 0;
    private bool isLiked = false;

    public void Load_Post(PostData data)
    {
        username.text = data.userName;
        postContent.text = data.postContent;
        likeCount = data.likeCount;
        likeCountText.text = likeCount.ToString();

        Sprite pic = Resources.Load<Sprite>(data.profilePic);
        if (pic != null)
            profilePicture.sprite = pic;

        UpdateLikeUI();
        likeButton.onClick.AddListener(ToggleLike);
    }

    private void ToggleLike()
    {
        isLiked = !isLiked;
        likeCount += isLiked ? 1 : -1;
        UpdateLikeUI();
    }

    private void UpdateLikeUI()
    {
        likeCountText.text = likeCount.ToString();
        buttonImage.sprite = isLiked ? likedSprite : unlikedSprite;
    }
}
