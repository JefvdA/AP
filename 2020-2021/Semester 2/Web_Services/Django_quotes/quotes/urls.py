from django.urls import path

from . import views

app_name = 'quotes'
urlpatterns = [
    path('', views.index, name='index'),
    path('<int:author_id>', views.detail, name="detail"),
    path('search_form', views.search_form, name="search_form"),
    path('search', views.search, name="search"),
    path('add_form', views.add_form, name="add_form"),
    path('add', views.add, name="add")
]