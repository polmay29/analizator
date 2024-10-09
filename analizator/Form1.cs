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

            // Валидация: проверка на пустой ввод
            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Пожалуйста, введите текст для анализа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Подсчет символов
            int characterCount = inputText.Length;

            // Подсчет слов
            string[] words = Regex.Split(inputText, @"\W+");
            int wordCount = words.Count(w => !string.IsNullOrWhiteSpace(w));

            // Подсчет предложений
            int sentenceCount = Regex.Matches(inputText, @"[.!?]").Count;

            // Подсчет уникальных слов
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

            // Нахождение самого длинного и самого короткого слова
            string longestWord = wordFrequency.Keys.OrderByDescending(w => w.Length).FirstOrDefault() ?? "";
            string shortestWord = wordFrequency.Keys.OrderBy(w => w.Length).FirstOrDefault() ?? "";

            // Вывод результатов
            lblCharacterCount.Text = $"Количество символов: {characterCount}";
            lblWordCount.Text = $"Количество слов: {wordCount}";
            lblSentenceCount.Text = $"Количество предложений: {sentenceCount}";
            lblUniqueWordCount.Text = $"Количество уникальных слов: {uniqueWordCount}";
            lblLongestWord.Text = $"Самое длинное слово: {longestWord}";
            lblShortestWord.Text = $"Самое короткое слово: {shortestWord}";

            // Отображение частоты каждого уникального слова
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
