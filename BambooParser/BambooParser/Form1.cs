using System;
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
            ResultsET.Clear();
            LogParser parser = new LogParser(LogFileET.Text, SetText, new LogParserOptions() { MillisecondsThreshold = (int)ThresholdET.Value});
            parser.Parse();
        }

        private void SetText(string text)
        {
            if (ResultsET.InvokeRequired)
            {
                ResultsET.Invoke((MethodInvoker) (() => SetText(text)));
                return;
            }
            if (!string.IsNullOrEmpty(ResultsET.Text))
            {
                ResultsET.AppendText(Environment.NewLine);
            }
            ResultsET.AppendText(text);
        }
    }
}
