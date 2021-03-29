from django.shortcuts import redirect, render
import redis

from .models import Author, Quote

r = redis.StrictRedis('localhost', 6379, decode_responses=True)

# Create your views here.
def index(request):
    keys = r.keys('author:*')
    authors = []
    for key in keys:
        a = Author()
        a.id = key.split(':')[1]
        a.author_name = key.split(':')[2]
        a.author_bio = r.get(key)
        authors.append(a)

    return render(request, 'quotes/index.html', {'authors': authors})

def detail(request, author_id):
    keys = r.keys(f'author:{author_id}:*')
    key = keys[0]
    a = Author()
    a.id = int(author_id)
    a.author_name = key.split(':')[2]
    a.author_bio = r.get(key)
    quote_list = r.smembers(f'quote:{author_id}')

    return render(request, 'quotes/detail.html', {'author':a, 'quote_list': quote_list})

def add_author(request):
    if request.method == "POST":
        author_name = request.POST["author_name"]
        author_bio = request.POST["author_bio"]
        r.incr('author_count')
        r.set(f'author:{str(r.get("author_count"))}:{author_name}', author_bio)

        return redirect('/quotes')

    return render(request, 'quotes/add_author.html', {})

def add_quote(request, author_id):
    if request.method == "POST":
        quote_text = request.POST["quote_text"]
        author_id = request.POST["author_id"]

        r.sadd(f'quote:{author_id}', quote_text)

        return redirect('/quotes')

    keys = r.keys(f'author:{author_id}:*')
    key = keys[0]
    a = Author()
    a.id = int(author_id)
    a.author_name = key.split(':')[2]

    return render(request, 'quotes/add_quote.html', {'author':a})