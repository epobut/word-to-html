# 📄 Word → Clean HTML

[UA] Проста утиліта на C# для перетворення Word-документів (.docx) у чистий HTML без зайвого сміття.
[EN] A simple C# utility to convert Word documents (.docx) into clean HTML without redundant bloat.

---

## ❓ Навіщо це потрібно? / Why use this?

### 🇺🇦 Українською

Стандартний експорт із Microsoft Word у HTML створює величезну кількість зайвих стилів, тегів та сміттєвого коду.  
Його складно використовувати на сайтах або в CMS (WordPress, Shopify тощо).

Цей інструмент:
- видаляє інлайнові стилі  
- очищує HTML від сміття  
- зберігає структуру (заголовки, списки)  
- робить код придатним для продакшену  

---

### 🇺🇸 English

Microsoft Word HTML export produces a lot of redundant styles and messy markup.

This tool:
- removes inline styles  
- cleans unnecessary tags  
- preserves semantic structure (headings, lists)  
- outputs production-ready HTML  

---

## 🚀 How to use / Як користуватись

### 1. Відкрийте проект у Visual Studio або Visual Studio Code.

### 2. Встановіть NuGet пакет: Install-Package Mammoth

### 3. Запустіть програму, вказавши шлях до файлу:
```bash
word-to-html.exe my_file.docx
```


You will get:

```
output.html
```

---

## 📝 GitHub Setup

**Description:**

Word to Clean HTML (C#): Convert .docx files to semantic, production-ready HTML code using .NET and Mammoth. No inline styles, no Word bloat.

**Topics:**
```
csharp, dotnet, word-to-html, docx-to-html, clean-html, mammoth-dotnet, content-migration
```

---

## 🛡 Disclaimer

Tool is provided as-is. No guarantees for perfect conversion of complex documents.
