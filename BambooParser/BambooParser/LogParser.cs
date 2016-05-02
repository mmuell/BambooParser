using System;
using System.IO;
using System.Net;
using System.Threading;

namespace BambooParser
{
    internal class LogParser
    {
        private string _fileName;
        private readonly Action<string> _writeText;
        private readonly LogParserOptions _options;

        public LogParser(string fileName, Action<string> writeText, LogParserOptions options)
        {
            _fileName = fileName;
            _writeText = writeText;
            _options = options;
        }

        public void Parse()
        {
            Thread t1 = new Thread(ParseImpl);
            t1.Start();
        }

        private void ParseImpl()
        {
            bool isURL = false;
            Uri uriResult;
            try
            {
                if (Uri.TryCreate(_fileName, UriKind.Absolute, out uriResult)
                    && uriResult.Scheme == Uri.UriSchemeHttp)
                {
                    isURL = true;
                    using (WebClient client = new WebClient())
                    {
                        var tempFileName = Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                            string.Format("{0}.log", Guid.NewGuid()));
                        _writeText(string.Format("Downloading {0}", _fileName));
                        client.DownloadFile(_fileName, tempFileName);
                        _fileName = tempFileName;
                    }
                }

                if (!File.Exists(_fileName))
                {
                    _writeText(string.Format("File {0} was not found", _fileName));
                }
                DateTime? lastDate = null;
                string lastLine = null;
                foreach (var line in File.ReadAllLines(_fileName))
                {
                    try
                    {
                        var parsed = line.Split('\t');
                        var date = DateTime.Parse(parsed[1]);
                        if (lastDate == null)
                        {
                            lastDate = date;
                        }
                        var sinceLast = date - lastDate.Value;
                        if (sinceLast.TotalMilliseconds >= _options.MillisecondsThreshold)
                        {
                            _writeText(lastLine);
                            _writeText(string.Format("Took {0} MS", sinceLast.TotalMilliseconds));
                        }
                        lastLine = line;
                        lastDate = date;
                    }
                    catch (Exception e)
                    {
                        _writeText(string.Format("Error Parsing : {0}", e.Message));
                    }
                }
            }
            catch (Exception e)
            {
                _writeText(string.Format("Error : {0}", e.Message));
            }
            finally
            {
                if (isURL && File.Exists(_fileName))
                {
                    _writeText("Cleaning Downloaded File");
                    File.Delete(_fileName);
                }
            }
        }
    }

    internal class LogParserOptions
    {
        public int MillisecondsThreshold { get; set; }

        public LogParserOptions()
        {
            MillisecondsThreshold = 9000;
        }
    }
}