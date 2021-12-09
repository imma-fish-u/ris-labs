<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ taglib uri="http://www.springframework.org/tags" prefix="spring" %>
<%@ taglib uri="http://www.springframework.org/tags/form" prefix="form" %>
<%@ taglib prefix="from" uri="http://www.springframework.org/tags/form" %>
<%@ page session="false" %>
<html>
<head>
    <title>Firms Page</title>

    <style type="text/css">
        .tg {
            border-collapse: collapse;
            border-spacing: 0;
            border-color: #ccc;
        }

        .tg td {
            font-family: Arial, sans-serif;
            font-size: 14px;
            padding: 10px 5px;
            border-style: solid;
            border-width: 1px;
            overflow: hidden;
            word-break: normal;
            border-color: #ccc;
            color: #333;
            background-color: #fff;
        }

        .tg th {
            font-family: Arial, sans-serif;
            font-size: 14px;
            font-weight: normal;
            padding: 10px 5px;
            border-style: solid;
            border-width: 1px;
            overflow: hidden;
            word-break: normal;
            border-color: #ccc;
            color: #333;
            background-color: #f0f0f0;
        }

        .tg .tg-4eph {
            background-color: #f9f9f9
        }
    </style>
</head>
<body>
<a href="workers.jsp">Back to Worker List</a>

<br/>
<br/>

<h1>Firm List</h1>

<c:if test="${!empty listFirms}">
    <table class="tg">
        <tr>
            <th width="80">ID</th>
            <th width="120">NameFirm</th>
            <th width="60">Edit</th>
            <th width="60">Delete</th>
        </tr>
        <c:forEach items="${listFirms}" var="firm">
            <tr>
                <td>${firm.id}</td>
                <td><a href="/firmdata/${firm.idFirm}" target="_blank">${firm.nameFirm}</a></td>
                <td><a href="<c:url value='/edit/${firm.idFirm}'/>">Edit</a></td>
                <td><a href="<c:url value='/remove/${firm.idFirm}'/>">Delete</a></td>
            </tr>
        </c:forEach>
    </table>
</c:if>


<h1>Add a Firm</h1>

<c:url var="addAction" value="/firms/add"/>

<form:form action="${addAction}" commandName="firm">
    <table>
        <c:if test="${!empty firm.nameFirm}">
            <tr>
                <td>
                    <form:label path="idFirm">
                        <spring:message text="ID"/>
                    </form:label>
                </td>
                <td>
                    <form:input path="idFirm" readonly="true" size="8" disabled="true"/>

                </td>
            </tr>
        </c:if>
        <tr>
            <td>
                <form:label path="nameFirm">
                    <spring:message text="NameFirm"/>
                </form:label>
            </td>
            <td>
                <form:input path="nameFirm"/>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <c:if test="${!empty firm.nameFirm}">
                    <input type="submit"
                           value="<spring:message text="Edit Firm"/>"/>
                </c:if>
                <c:if test="${empty firm.nameFirm}">
                    <input type="submit"
                           value="<spring:message text="Add Firm"/>"/>
                </c:if>
            </td>
        </tr>
    </table>
</form:form>
</body>
</html>
