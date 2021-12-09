<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ taglib uri="http://www.springframework.org/tags" prefix="spring" %>
<%@ taglib uri="http://www.springframework.org/tags/form" prefix="form" %>
<%@ taglib prefix="from" uri="http://www.springframework.org/tags/form" %>
<%@ page session="false" %>
<html>
<head>
    <title>Workers Page</title>

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
<a href="../../index.jsp">Back to main menu</a>
<br/>
<a href="firms.jsp">Firm List</a>

<br/>
<br/>

<h1>Worker List</h1>

<c:if test="${!empty listWorkers}">
    <table class="tg">
        <tr>
            <th width="80">ID</th>
            <th width="120">Name</th>
            <th width="120">Lastname</th>
            <th width="120">IdFirm</th>
            <th width="60">Edit</th>
            <th width="60">Delete</th>
        </tr>
        <c:forEach items="${listWorkers}" var="worker">
            <tr>
                <td>${worker.id}</td>
                <td><a href="/workerdata/${worker.idWorker}" target="_blank">${worker.name}</a></td>
                <td>${worker.lastname}</td>
                <td><a href="<c:url value='/edit/${work.idWorker}'/>">Edit</a></td>
                <td><a href="<c:url value='/remove/${work.idWorker}'/>">Delete</a></td>
            </tr>
        </c:forEach>
    </table>
</c:if>


<h1>Add a Worker</h1>

<c:url var="addAction" value="/workers/add"/>

<form:form action="${addAction}" commandName="worker">
    <table>
        <c:if test="${!empty worker.name}">
            <tr>
                <td>
                    <form:label path="idWorker">
                        <spring:message text="ID"/>
                    </form:label>
                </td>
                <td>
                    <form:input path="idWorker" readonly="true" size="8" disabled="true"/>

                </td>
            </tr>
        </c:if>
        <tr>
            <td>
                <form:label path="name">
                    <spring:message text="Name"/>
                </form:label>
            </td>
            <td>
                <form:input path="name"/>
            </td>
        </tr>
        <tr>
            <td>
                <form:label path="lastname">
                    <spring:message text="Lastname"/>
                </form:label>
            </td>
            <td>
                <form:input path="lastname"/>
            </td>
        </tr>
        <tr>
            <td>
                <form:label path="idFirm">
                    <spring:message text="IdFirm"/>
                </form:label>
            </td>
            <td>
                <form:input path="idFirm"/>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <c:if test="${!empty worker.name}">
                    <input type="submit"
                           value="<spring:message text="Edit Worker"/>"/>
                </c:if>
                <c:if test="${empty worker.name}">
                    <input type="submit"
                           value="<spring:message text="Add Worker"/>"/>
                </c:if>
            </td>
        </tr>
    </table>
</form:form>
</body>
</html>
