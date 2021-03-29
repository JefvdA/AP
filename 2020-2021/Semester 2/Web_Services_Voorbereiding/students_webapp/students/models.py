from django.db import models

# Create your models here.
class Student(models.Model):
    student_firstName = models.CharField(max_length=200)
    student_lastName = models.CharField(max_length=200)
    student_birthday = models.CharField(max_length=200)
    student_program = models.CharField(max_length=200)

    def __str__(self) -> str:
        return self.student_firstName + " " + self.student_lastName