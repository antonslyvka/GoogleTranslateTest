using System;
using System.Net;

namespace Tests
{
    public static class ApiActions
    {
        public static string ApiTranslate(this WebClient client, string fromLanguage, string toLanguage, string word)
        {
            client = new WebClient();
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl=" + fromLanguage + 
                "&tl=" + toLanguage + "&dt=t&q=" + word;
            var googleResult = client.DownloadString(url);
            googleResult = googleResult.Substring(4, googleResult.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
            return googleResult;
        }
    }




}