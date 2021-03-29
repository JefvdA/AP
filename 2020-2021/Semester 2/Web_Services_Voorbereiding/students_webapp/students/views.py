from django.shortcuts import render
import redis

from .models import Student

r = redis.StrictRedis('localhost', 6379, decode_responses=True)

# Create your views here.
def index(request):
    keys = r.keys('student:*')
    students = []
    for key in keys:
        s = Student()
        s.id = key.split(':')[1]
        s.student_firstName = r.hget(key, 'firstName')
        s.student_lastName = r.hget(key, 'lastName')
        s.student_birthday = r.hget(key, 'birthday')
        s.student_program = r.hget(key, 'program')
        students.append(s)

    return render(request, 'students/index.html', {'students': students})