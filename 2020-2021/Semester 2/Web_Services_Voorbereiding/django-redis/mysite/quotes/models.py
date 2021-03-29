from django.db import models
from django.db.models.fields.related import ForeignKey

# Create your models here.
class Author(models.Model):
    author_name = models.CharField(max_length=200)
    author_bio = models.CharField(max_length=200)

    def __str__(self) -> str:
        return self.author_name

class Quote(models.Model):
    quote_text = models.CharField(max_length=200)
    author = ForeignKey(Author, on_delete=models.CASCADE)

    def __str__(self) -> str:
        return self.quote_text