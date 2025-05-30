# Social Media Post
UI social media post developed in Unity that dynamically loads user data (username, message, and profile picture) from a local JSON file. The profile image is loaded locally as a sprite from the Resources folder, making the post fully data-driven and offline-friendly.
## Runtime UI Result 
![Screenshot 2025-05-31 001407](https://github.com/user-attachments/assets/1f717125-46e8-4465-8bcc-01bbf3bcae09)
![Screenshot 2025-05-31 001422](https://github.com/user-attachments/assets/678e69c6-961a-48b1-9e06-a5bd0c7a85f5)

## UI Layout In Unity
![Screenshot 2025-05-31 004331](https://github.com/user-attachments/assets/6489e516-87b0-4436-a5f0-7890f447347b)

## Technologies Used
- Unity UI (Text, Image)
- UnityWebRequestTexture for loading images from the web
- JsonUtility for JSON deserialization
- C# Coroutines for asynchronous loading
  
## Steps Implemented
- Created a data class (PostData) with username, message, and profilePicture fields.
- Stored a JSON file (post.json) in the Resources folder.
- Parsed JSON using JsonUtility.FromJson<PostData>().
- Populated UI Text components for username and message.
- Downloaded image from a URL using UnityWebRequestTexture.
- Converted downloaded texture to a Sprite.
- Displayed the Sprite in a Unity Image component.
- Bound UI references in the Inspector (Text and Image).

 ## Features
- Load structured post data from a JSON file
- Parse and display username, message, and profilePicture fields
- Load a .jpg or .png profile image from a remote URL
- Display the loaded data in a Unity UI panel

## JSON Format
  Example post.json (in Assets/Resources):

```json
    {
      "userName": "Alice Johnson",
      "postContent": "Had a great day at the beach!",
      "likeCount": 5,
      "imageUrl": "Profile/profile2"
    }

