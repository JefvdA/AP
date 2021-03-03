from django.db import models

# Create your models here.
class Author(models.Model):
    author_name = models.CharField(max_length=50)
    author_bio = models.CharField(max_length=200)

    def __str__(self):
        return self.author_name

class Quote(models.Model):
    # FK
    author = models.ForeignKey(Author, on_delete=models.CASCADE)

    quote_text = models.CharField(max_length=200)

    def __str__(self):
        return self.quote_text

    def search_quote(self, word):
        return True if word.lower() in self.quote_text.lower().replace('.', '').split() else False