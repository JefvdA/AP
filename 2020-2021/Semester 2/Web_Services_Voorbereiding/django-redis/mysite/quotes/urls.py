from django.urls import path

from . import views

app_name = "quotes"
urlpatterns = [
    path('', views.index, name="index"),
    path('<int:author_id>', views.detail, name="detail"),
    path('add/author', views.add_author, name="add_author"),
    path('add/quote/<int:author_id>', views.add_quote, name="add_quote")
]
