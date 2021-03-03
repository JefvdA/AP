from django.shortcuts import render
from django.http import HttpResponseRedirect, HttpResponse
from django.urls import reverse

from .models import Author, Quote

# Create your views here.
def index(request):
    authors = [a for a in Author.objects.all()]

    return render(request, 'quotes/index.html', {'authors': authors})

def detail(request, author_id):
    author = Author.objects.filter(id=author_id).first()

    return render(request, 'quotes/detail.html', {'author': author})

def search_form(request):
    return render(request, 'quotes/search_form.html', {})

def search(request):
    searchInput = request.POST['searchInput']

    searchResult = Quote.objects.filter(quote_text__contains=searchInput)

    return render(request, 'quotes/search_result.html', {
        'quotes': searchResult
    })

def add_form(request):
    return render(request, 'quotes/add_form.html', {})

def add(request):
    author_name = request.POST.get('author_name')
    author_bio = request.POST.get('author_bio')

    if(author_name=="" or author_bio==""):
        return render(request, 'quotes/add_form.html', {
            'error_message': 'please enter a name and bio'
        })

    # there is a name and bio, now add a new author
    a = Author(author_name=author_name, author_bio=author_bio)
    a.save()

    return HttpResponseRedirect(reverse('quotes:index'))