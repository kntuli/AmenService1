using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using Google.Apis.Authentication.OAuth2;
//using Google.Apis.Authentication.OAuth2.DotNetOpenAuth;
//using System.Security.Cryptography.X509Certificates;
//using Google.Apis.Youtube.v3;
//using Google.Apis.Services;
//using Google.Apis.Youtube;
//using Google.Apis.Youtube.v3.Data;
//using Google.Apis.Util;
//using DotNetOpenAuth.OAuth2;
//using Google.Apis.Upload;


namespace AmenService1
{
    public class YoutubeUploaderService
    {
        //private static string CLIENT_ID = "Your ClientID";
        //private static string CLIENT_SECRET = "Your ClientSecret";
        //private static string REFRESH_TOKEN = "Your RefreshToken";

        //private YouTubeService youtube;
        //private IAuthorizationState refreshToken;

        //public YoutubeUploaderService()
        //{
        //    youtube = BuildService();
        //    refreshToken = new AuthorizationState()
        //    {
        //        RefreshToken = REFRESH_TOKEN
        //    };
        //}

        //public void UploadExampleVideo()
        //{
        //    Video video = new Video();
        //    video.Snippet = new VideoSnippet();
        //    video.Snippet.Title = "SomeTitle";
        //    video.Snippet.Description = "SomeDescription";
        //    video.Snippet.Tags = new string[] { "tag1", "tag2" };
        //    video.Snippet.CategoryId = "22";  // You need to investigate Youtube API more to learn about category IDs
        //    video.Status = new VideoStatus();
        //    video.Status.PrivacyStatus = "private";

        //    FileStream fileStream = new FileStream("PathToYourVideoFile", FileMode.Open);
        //    VideosResource.InsertMediaUpload insertRequest = youtube.Videos.Insert(video, "snippet, status", fileStream, "video/*");
        //    insertRequest.ProgressChanged += insertRequest_ProgressChanged;
        //    insertRequest.ResponseReceived += insertRequest_ResponseReceived;

        //    insertRequest.Upload();
        //}

        //void insertRequest_ResponseReceived(Google.Apis.Youtube.v3.Data.Video obj)
        //{
        //    // obj.ID gives you the ID of the Youtube video.
        //    // you can access the video from
        //    // http://www.youtube.com/watch?v={obj.ID}
        //}

        //void insertRequest_ProgressChanged(Google.Apis.Upload.IUploadProgress obj)
        //{
        //    // You can handle several status messages here.
        //    switch (obj.Status)
        //    {
        //        case UploadStatus.Failed:
        //            break;
        //        case UploadStatus.Completed:
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //private YouTubeService BuildService()
        //{
        //    var provider = new NativeApplicationClient(GoogleAuthenticationServer.Description)
        //    {
        //        ClientIdentifier = CLIENT_ID,
        //        ClientSecret = CLIENT_SECRET
        //    };

        //    var auth = new OAuth2Authenticator<NativeApplicationClient>(provider, GetAuthorization);

        //    YouTubeService service = new YouTubeService((new BaseClientService.Initializer()
        //    {
        //        Authenticator = auth
        //    }));

        //    service.HttpClient.Timeout = TimeSpan.FromSeconds(360); // Choose a timeout to your liking
        //    return service;
        //}

        //private IAuthorizationState GetAuthorization(NativeApplicationClient client)
        //{
        //    client.RefreshToken(refreshToken);
        //    return refreshToken;
        //}
    }
}