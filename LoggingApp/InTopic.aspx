<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="InTopic.aspx.cs" Inherits="LoggingApp.InTopic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form name="comment" action="comment.php" method="post">
        <p>
            <label>Имя:</label>
            <input type="text" name="name" />
        </p>
        <p>
            <label>Комментарий:</label>
            <br />
            <textarea name="text_comment" style="height: 74px; width: 1370px"></textarea>
        </p>
        <p>
            <input type="hidden" name="page_id" value="150" />
            <input type="submit" value="Отправить" />
        </p>
        &nbsp;</form>
</body>
</html>
