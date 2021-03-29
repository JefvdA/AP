from django.contrib import admin
from django.db.models.deletion import CASCADE

from .models import Author, Quote

# Register your models here.
admin.site.register(Author)
admin.site.register(Quote)