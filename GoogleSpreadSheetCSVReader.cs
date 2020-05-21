using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace GoogleSpreadSheetCSVReader
{
    public class SpreadSheetCSVReader
    {
        private const string baseUrl = "https://docs.google.com/spreadsheets/d/e/{0}/pub?gid={1}&single=true&output=csv";

        public static void GetSpreadSheetData<T>(string key, string gid, System.Action<T[]> callback)
        {
            StaticCoroutine.DoCoroutine(GetDataCoroutine(key, gid, callback));
        }

        static IEnumerator GetDataCoroutine<T>(string key, string gid, System.Action<T[]> callback)
        {
            string url = string.Format(baseUrl, key, gid);

            Debug.Log("Get Data From : " + url);

            using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
            {
                yield return webRequest.SendWebRequest();
                if (webRequest.isNetworkError)
                {
                    Debug.Log("Download Error : " + webRequest.error);
                    callback?.Invoke(null);
                }
                else
                {
                    Debug.Log("Data : " + webRequest.downloadHandler.text);

                    T[] data = CSVSerializer.Deserialize<T>(webRequest.downloadHandler.text);
                    callback?.Invoke(data);
                }
            }
        }

    }
}

