# 📄 Word → Clean HTML

[UA] Утиліта для перетворення документів Word (.docx) у чистий, семантичний HTML-код без зайвого сміття.  
[EN] A utility for converting Word documents (.docx) into clean, semantic HTML code without bloat.

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

### 1. Install dependency

```bash
pip install mammoth
```

### 2. Run script

```bash
python convert.py document.docx
```

### 3. Result

You will get:

```
output.html
```

---

## 🛠 Tech

- Python 3.x  
- Library: `mammoth`  

---

## 📝 GitHub Setup

**Description:**

Word to Clean HTML: Convert .docx files to semantic, production-ready HTML without inline styles or Word bloat.

**Topics:**
```
word-to-html docx-to-html clean-html web-development python-automation seo-friendly
```

---

## 🛡 Disclaimer

Tool is provided as-is. No guarantees for perfect conversion of complex documents.
