﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace word_to_html
{
    /// <summary>
    /// YouTube Data API v3 sample: search by keyword.
    /// Relies on the Google APIs Client Library for .NET, v1.7.0 or higher.
    /// See https://developers.google.com/api-client-library/dotnet/get_started
    ///
    /// Set ApiKey to the API key value from the APIs & auth > Registered apps tab of
    ///   https://cloud.google.com/console
    /// Please ensure that you have enabled the YouTube Data API for your project.
    /// </summary>
    internal class Search
    {
        static public string listUrl;
        static public string listId;
        static public string listNazv;
        static public string q;
        static public string YtbId;
        static public String[] idSplit;
        static public String[] nazvSplit;
        // [STAThread]
        public static void YTBsearch()
        {
           
            try
            {
                new Search().Run();
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

           // Console.WriteLine("Press any key to continue...");
           // Console.ReadKey();
        }

        private async Task Run()
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyCMrzFAewUA4gI_4AchQ8WM8unZ9WhDJeo",
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = q; // Replace with your search term.
            searchListRequest.MaxResults = 10;

            // Call the search.list method to retrieve results matching the specified query term.
            var searchListResponse = await searchListRequest.ExecuteAsync();

            List<string> videos = new List<string>();
            List<string> id = new List<string>();
            List<string> nazv = new List<string>();
            //List<string> channels = new List<string>();
            //List<string> playlists = new List<string>();

            // Add each result to the appropriate list, and then display the lists of
            // matching videos, channels, and playlists.
            foreach (var searchResult in searchListResponse.Items)
            {
                switch (searchResult.Id.Kind)
                {
                    case "youtube#video":
                        videos.Add(String.Format("{1} {0};", searchResult.Snippet.Title, videos.Count + 1));
                        id.Add(searchResult.Id.VideoId);
                        nazv.Add(searchResult.Snippet.Title);
                        break;

                    //case "youtube#channel":
                    //    channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.ChannelId));
                    //    break;

                    //case "youtube#playlist":
                    //    playlists.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.PlaylistId));
                    //    break;
                }
            }
            
            listUrl = string.Join("\n", videos);

            YtbId = string.Join("\n", id);
            idSplit = YtbId.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            listNazv = string.Join("\n", nazv);
            nazvSplit = listNazv.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}