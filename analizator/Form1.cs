using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TextAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text.Trim();

            // ���������: �������� �� ������ ����
            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("����������, ������� ����� ��� �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ������� ��������
            int characterCount = inputText.Length;

            // ������� ����
            string[] words = Regex.Split(inputText, @"\W+");
            int wordCount = words.Count(w => !string.IsNullOrWhiteSpace(w));

            // ������� �����������
            int sentenceCount = Regex.Matches(inputText, @"[.!?]").Count;

            // ������� ���������� ����
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
            foreach (var word in words.Where(w => !string.IsNullOrWhiteSpace(w)))
            {
                var lowerWord = word.ToLower();
                if (wordFrequency.ContainsKey(lowerWord))
                {
                    wordFrequency[lowerWord]++;
                }
                else
                {
                    wordFrequency[lowerWord] = 1;
                }
            }
            int uniqueWordCount = wordFrequency.Count;

            // ���������� ������ �������� � ������ ��������� �����
            string longestWord = wordFrequency.Keys.OrderByDescending(w => w.Length).FirstOrDefault() ?? "";
            string shortestWord = wordFrequency.Keys.OrderBy(w => w.Length).FirstOrDefault() ?? "";

            // ����� �����������
            lblCharacterCount.Text = $"���������� ��������: {characterCount}";
            lblWordCount.Text = $"���������� ����: {wordCount}";
            lblSentenceCount.Text = $"���������� �����������: {sentenceCount}";
            lblUniqueWordCount.Text = $"���������� ���������� ����: {uniqueWordCount}";
            lblLongestWord.Text = $"����� ������� �����: {longestWord}";
            lblShortestWord.Text = $"����� �������� �����: {shortestWord}";

            // ����������� ������� ������� ����������� �����
            lstWordFrequency.Items.Clear();
            foreach (var pair in wordFrequency)
            {
                lstWordFrequency.Items.Add($"{pair.Key}: {pair.Value}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lblCharacterCount.Text = "";
            lblWordCount.Text = "";
            lblSentenceCount.Text = "";
            lblUniqueWordCount.Text = "";
            lblLongestWord.Text = "";
            lblShortestWord.Text = "";
            lstWordFrequency.Items.Clear();
        }
    }
}
