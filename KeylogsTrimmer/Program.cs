using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
class Program
{
    static void Main(string[] args)
    {
        // Dosya yolunu belirle
        string filePath = @"C:\sex.txt";

        // Dosyayı oku
        string input = File.ReadAllText(filePath);

        // Belirli parantezleri ve parantez içerisindeki kelimeleri sil
        string pattern = @"\[.*?\]";
        string output = Regex.Replace(input, pattern, "");
        output = Regex.Replace(output, @"\s+", " "); // remove extra spaces between words

        // Dosyaya tekrar yaz
        File.WriteAllText(filePath, output);

        // Başarılı bir ekrana bilgi kutucuğu göster
        MessageBox.Show("Parantez içindeki tüm kelimeler dosyadan başarıyla kaldırıldı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
