<%@ page language='java' contentType='text/html; charset=UTF-8' pageEncoding='UTF-8' %>
<!DOCTYPE html>
<%@ page import="edu.ap.jdbc.JDBConnection" %>

<%
JDBConnection connection = null;

try {
    // extract values from POST
    int id = Integer.parseInt(request.getParameter("id"));

    // open connection and insert values
    connection = JDBConnection.getJDBConnection();
    connection.openConnection("students2", "root", "root");
    String deleteSQL = "DELETE FROM GRADES WHERE ID = " + id + ";";
    System.out.println(deleteSQL);
    connection.executeDelete(deleteSQL);

    response.sendRedirect("list.jsp");
}
catch(Exception e) {
    System.out.println(e);
}
finally {
    connection.closeConnection();
}
%>