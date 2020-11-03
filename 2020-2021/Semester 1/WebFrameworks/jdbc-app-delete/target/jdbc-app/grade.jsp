<%@ page language='java' contentType='text/html; charset=UTF-8' pageEncoding='UTF-8' %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Grade a student</title>
</head>
<body>
    <form action="result.jsp" method="POST">
        First name: <input type="text" name="firstName" size=20><br>
        Last name: <input type="text" name="lastName" size=20><br>
        Grade: <input type="text" name="grade" size=4><br>
        <br>
        <input type="submit" value="Save">
    </form>
    <br><br>
    <a href="list.jsp">List</a>
</body>
</html>