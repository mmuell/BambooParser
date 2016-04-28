using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BambooParser
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void ParsePB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LogFileET.Text))
            {
                return;
            }
            LogParser parser = new LogParser(LogFileET.Text, SetText);
            parser.Parse();
        }

        private void SetText(string text)
        {
            if (ResultsET.InvokeRequired)
            {
                ResultsET.Invoke((MethodInvoker) (() => SetText(text)));
                return;
            }
            ResultsET.AppendText(Environment.NewLine);
            ResultsET.AppendText(text);
        }
    }

    internal class LogParser
    {
        private readonly string _fileName;
        private readonly Action<string> _writeText;

        public LogParser(string fileName, Action<string> writeText)
        {
            _fileName = fileName;
            _writeText = writeText;
        }

        public void Parse()
        {
            Thread t1 = new Thread(ParseImpl);
            t1.Start();
        }

        private void ParseImpl()
        {
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
                    if (sinceLast.TotalSeconds > 9)
                    {
                        _writeText(lastLine);
                        _writeText(string.Format("Took {0} MS", sinceLast.TotalMilliseconds));
                    }
                    lastLine = line;
                    lastDate = date;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
