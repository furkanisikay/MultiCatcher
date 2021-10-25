using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GetEMail
{
    public static class Funcs
    {
        public static List<string> GetEMails(string text)
        {
            List<string> epostalar = new List<string>();
            const string MatchEmailPattern =
           @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";
            Regex rx = new Regex(MatchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(text);
            foreach (Match match in matches)
            {
                string item = match.Value.ToString();
                if (!epostalar.Contains(item))
                { epostalar.Add(item); }
            }
            return epostalar;
        }

        public static List<string> GetPhoneNumbers(string text)
        {
            List<string> telefonlar = new List<string>();
            string pattern = @"(05(\d{9}))";
            Regex rx = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(text);
            foreach (Match match in matches)
            {
                string item = match.Value.ToString();
                if (!telefonlar.Contains(item))
                { telefonlar.Add(item); }
            }
            return telefonlar;
        }

        public static bool SaveFile(List<string> List, string Path)
        {
            if (List != null && List.Count >= 1)
            {
                string Text = string.Empty;
                foreach (string phone in List)
                {
                    Text +=  phone + "\n";
                }
                try { File.WriteAllText(Path, Text); return true; }
                catch { return false; }
            }
            else
            {
                return false;
            }
        }

        public static string GetSource(string urlAddress)
        {
            string data = string.Empty;
            if (IsURL(urlAddress))
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;
                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }
                    data = readStream.ReadToEnd();
                    response.Close();
                    readStream.Close();
                    response.Dispose();
                    readStream.Dispose();
                }
            }
            return data;
        }
        public static bool NesnenleriLstBoxEkle(List<string> nesneler, ref System.Windows.Forms.ListBox lst)
        {
            if (nesneler != null && nesneler.Count > 0)
            {
                lst.Items.AddRange(nesneler.ToArray());
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsURL(string source)
        {
            Uri uriResult;
            return Uri.TryCreate(source, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
        public static void Delagate(Control ctrl, Action islemler)
        {
            if (ctrl != null)
            {
                if (ctrl.InvokeRequired)
                {
                    try { ctrl.Invoke((MethodInvoker)delegate { islemler(); }); }
                    catch (Exception) { }
                }
                else { islemler(); }
            }
        }
    }
}
