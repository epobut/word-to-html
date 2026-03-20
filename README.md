[UA] Утиліта для перетворення документів Word (.docx) у чистий, семантичний HTML-код без зайвого сміття.
[EN] A utility for converting Word documents (.docx) into clean, semantic HTML code without bloat.
--- Навіщо це потрібно? / Why use this? ---
Українською:
Стандартний експорт із Microsoft Word у HTML створює величезну кількість зайвих стилів, тегів та сміттєвого коду, який важко вставити на сайт або в CMS (WordPress, Shopify тощо). Цей інструмент очищує код від інлайнових стилів, зберігає правильну структуру (заголовки, списки) та видаляє непотрібні класи.
English:
Standard export from Microsoft Word to HTML generates a massive amount of redundant styles and garbage code. This tool cleans the output by removing inline styles while preserving semantic structure like headings and lists. It's perfect for web publishing and CMS integration.
--- Як користуватися / How to use ---
Встановіть необхідну бібліотеку:
pip install mammoth
Запустіть скрипт, вказавши шлях до вашого документа:
python convert.py document.docx
Отримайте готовий файл output.html.
--- Налаштування GitHub (About & Topics) ---
Description:
Word to Clean HTML: Convert .docx files to semantic, production-ready HTML code without inline styles or redundant Word bloat.
Topics:
word-to-html, docx-to-html, clean-html, web-development, python-automation, seo-friendly
